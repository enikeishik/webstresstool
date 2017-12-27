/**
 * WebStressTool
 * Web Stress Tool, testing hiload sites
 * 
 * Created by SharpDevelop.
 * User: Enikeishik
 * Date: 26.12.2017
 * Time: 10:32
 * 
 * @copyright   Copyright (C) 2005 - 2017 Enikeishik <enikeishik@gmail.com>. All rights reserved.
 * @author      Enikeishik <enikeishik@gmail.com>
 * @license     GNU General Public License version 2 or later; see LICENSE.txt
 */


using System;
using System.Threading;
using System.Net;

namespace WebStressTool
{
    /// <summary>
    /// Make requests to url.
    /// </summary>
    public class Worker
    {
        protected const int threadsLimit = 32768;
        protected const int threadWait = 10;
        
        protected readonly string url;
        protected readonly int requestTimeout;
        
        protected Thread[] threads;
        
        public bool IsAlive
        {
            get; protected set;
        }
        
        public delegate void WorkResultDelegate(Worker sender, WorkerResult result);
        
        public event WorkResultDelegate onWorkResult;
        
        public Worker(string url, int requestTimeout)
        {
            this.url = url;
            this.requestTimeout = requestTimeout;
        }
        
        public void DoWork(int iterateNum, int threadsCount)
        {
            threads = new Thread[threadsCount];
            for (int i = 0; i < threadsCount; i++) {
                threads[i] = new Thread(ThreadProc);
                threads[i].Start(new WorkerData(iterateNum, i + 1, threadsCount));
            }
            Thread thAwait = new Thread(AwaitRequests);
            thAwait.Start();
        }
        
        public void Abort()
        {
            foreach (Thread t in threads)
                t.Abort();
        }
        
        protected void ThreadProc(object data)
        {
            WorkerData d = (WorkerData) data;
            WebRequest request = WebRequest.Create(url);
            request.Timeout = requestTimeout;
            
            HttpWebRequest wr = (HttpWebRequest) request;
            
            try {
                HttpWebResponse response = (HttpWebResponse) request.GetResponse();
                System.Diagnostics.Debug.WriteLine("Response " + "[" + d.iterateNum + "|" + d.threadNum + "/" + d.threadsCount + "]: " + response.StatusCode);
                response.Close();
                if (null != onWorkResult)
                    onWorkResult(this, new WorkerResult(d, response, ""));
            } catch (Exception e) {
                System.Diagnostics.Debug.WriteLine("Error " + "[" + d.iterateNum + "|" + d.threadNum + "/" + d.threadsCount + "]: " + e.Message);
                if (null != onWorkResult)
                    onWorkResult(this, new WorkerResult(d, null, e.Message));
            }
        }
        
        protected void AwaitRequests()
        {
           IsAlive = true;
           bool alive = true;
           while (alive) {
                alive = false;
                foreach (Thread t in threads) {
                    if (null != t && t.IsAlive) {
                        alive = true;
                        Thread.Sleep(threadWait);
                        break;
                    }
                }
            }
           IsAlive = false;
        }
    }
    
    public struct WorkerData
    {
        public int iterateNum;
        public int threadNum;
        public int threadsCount;
        public WorkerData(int iterateNum, int threadNum, int threadsCount)
        {
            this.iterateNum = iterateNum;
            this.threadNum = threadNum;
            this.threadsCount = threadsCount;
        }
    }
    
    public class WorkerResult
    {
        public WorkerData data;
        public HttpWebResponse response;
        public string error;
        public WorkerResult(WorkerData data, HttpWebResponse response, string error)
        {
            this.data = data;
            this.response = response;
            this.error = error;
        }
    }
}
