// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class GetJobExecutionThreadDumpResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetJobExecutionThreadDumpResponseBodyData Data { get; set; }
        public class GetJobExecutionThreadDumpResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>\&quot;Thread-7\&quot; Id=67 TIMED_WAITING\n\tat <a href="mailto:java.base@17.0.5">java.base@17.0.5</a>/java.lang.Thread.sleep(Native Method)\n\tat app//com.xxl.job.executor.service.jobhandler.SampleXxlJob.shardingJobHandler(SampleXxlJob.java:73)\n\tat <a href="mailto:java.base@17.0.5">java.base@17.0.5</a>/jdk.internal.reflect.NativeMethodAccessorImpl.invoke0(Native Method)\n\tat <a href="mailto:java.base@17.0.5">java.base@17.0.5</a>/jdk.internal.reflect.NativeMethodAccessorImpl.invoke(NativeMethodAccessorImpl.java:77)\n\tat <a href="mailto:java.base@17.0.5">java.base@17.0.5</a>/jdk.internal.reflect.DelegatingMethodAccessorImpl.invoke(DelegatingMethodAccessorImpl.java:43)\n\tat <a href="mailto:java.base@17.0.5">java.base@17.0.5</a>/java.lang.reflect.Method.invoke(Method.java:568)\n\tat app//com.xxl.job.core.handler.impl.MethodJobHandler.execute(MethodJobHandler.java:29)\n\tat app//com.xxl.job.core.thread.JobThread.run(JobThread.java:152)\n</para>
            /// </summary>
            [NameInMap("Dump")]
            [Validation(Required=false)]
            public string Dump { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Parameter error: appId is null.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3835AA29-2298-5434-BC53-9CC377CDFD2C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
