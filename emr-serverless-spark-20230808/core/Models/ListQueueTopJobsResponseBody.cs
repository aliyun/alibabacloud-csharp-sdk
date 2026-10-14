// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListQueueTopJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The job details.</para>
        /// </summary>
        [NameInMap("queueTopJobs")]
        [Validation(Required=false)]
        public ListQueueTopJobsResponseBodyQueueTopJobs QueueTopJobs { get; set; }
        public class ListQueueTopJobsResponseBodyQueueTopJobs : TeaModel {
            /// <summary>
            /// <para>The list of jobs.</para>
            /// </summary>
            [NameInMap("jobs")]
            [Validation(Required=false)]
            public List<ListQueueTopJobsResponseBodyQueueTopJobsJobs> Jobs { get; set; }
            public class ListQueueTopJobsResponseBodyQueueTopJobsJobs : TeaModel {
                /// <summary>
                /// <para>The number of CPU cores requested by the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("cpuCores")]
                [Validation(Required=false)]
                public string CpuCores { get; set; }

                /// <summary>
                /// <para>The number of CUs consumed by the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("cu")]
                [Validation(Required=false)]
                public string Cu { get; set; }

                /// <summary>
                /// <para>The job ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>jr-1234abcd</para>
                /// </summary>
                [NameInMap("jobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <para>The job type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>spark-batch</para>
                /// </summary>
                [NameInMap("jobType")]
                [Validation(Required=false)]
                public string JobType { get; set; }

                /// <summary>
                /// <para>The amount of memory requested by the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32</para>
                /// </summary>
                [NameInMap("memoryGiB")]
                [Validation(Required=false)]
                public string MemoryGiB { get; set; }

            }

            /// <summary>
            /// <para>The maximum number of records returned in a single request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public string MaxResults { get; set; }

            /// <summary>
            /// <para>The name of the queue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dev_queue</para>
            /// </summary>
            [NameInMap("queueName")]
            [Validation(Required=false)]
            public string QueueName { get; set; }

            /// <summary>
            /// <para>The total number of CUs consumed by the queue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>128</para>
            /// </summary>
            [NameInMap("totalCu")]
            [Validation(Required=false)]
            public string TotalCu { get; set; }

            /// <summary>
            /// <para>The total number of jobs in the queue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>25</para>
            /// </summary>
            [NameInMap("totalJobCount")]
            [Validation(Required=false)]
            public int? TotalJobCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
