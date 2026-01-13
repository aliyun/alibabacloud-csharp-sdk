// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListKyuubiSparkApplicationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the applications.</para>
        /// </summary>
        [NameInMap("applications")]
        [Validation(Required=false)]
        public List<ListKyuubiSparkApplicationsResponseBodyApplications> Applications { get; set; }
        public class ListKyuubiSparkApplicationsResponseBodyApplications : TeaModel {
            /// <summary>
            /// <para>The ID of the application that is submitted by using a Kyuubi gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>spark-339f844005b6404c95f9f7c7a13b****</para>
            /// </summary>
            [NameInMap("applicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>The name of the Spark application that is submitted by using a Kyuubi gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kyuubi-connection-spark-sql-anonymous-fa9a5e73-b4b1-474a-b****</para>
            /// </summary>
            [NameInMap("applicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            /// <summary>
            /// <para>The number of CUs consumed during a specified cycle of a task. The value is an estimated value. Refer to your Alibaba Cloud bill for the actual number of consumed CUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.238302</para>
            /// </summary>
            [NameInMap("cuHours")]
            [Validation(Required=false)]
            public double? CuHours { get; set; }

            /// <summary>
            /// <para>The time when the task ended.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-02-12 20:02:02</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Exit Code: 137, Exit Reason: OOMKilled</para>
            /// </summary>
            [NameInMap("exitReason")]
            [Validation(Required=false)]
            public string ExitReason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>kb-2b93ec*******c9440c</para>
            /// </summary>
            [NameInMap("kyuubiServiceId")]
            [Validation(Required=false)]
            public string KyuubiServiceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("latestSqlStatementStatus")]
            [Validation(Required=false)]
            public string LatestSqlStatementStatus { get; set; }

            /// <summary>
            /// <para>The total amount of memory allocated to the job multiplied by the running duration (seconds).</para>
            /// 
            /// <b>Example:</b>
            /// <para>3513900</para>
            /// </summary>
            [NameInMap("mbSeconds")]
            [Validation(Required=false)]
            public long? MbSeconds { get; set; }

            /// <summary>
            /// <para>The name of the resource queue on which the Spark jobs run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dev_queue</para>
            /// </summary>
            [NameInMap("resourceQueueId")]
            [Validation(Required=false)]
            public string ResourceQueueId { get; set; }

            [NameInMap("runLog")]
            [Validation(Required=false)]
            public RunLog RunLog { get; set; }

            /// <summary>
            /// <para>The time when the task started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-02-12 19:59:16</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The status of the Spark application.</para>
            /// <list type="bullet">
            /// <item><description>STARTING</description></item>
            /// <item><description>RUNNING</description></item>
            /// <item><description>TERMINATED</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>STARTING</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// <para>The total number of CPU cores allocated to the job multiplied by the running duration (seconds).</para>
            /// 
            /// <b>Example:</b>
            /// <para>780</para>
            /// </summary>
            [NameInMap("vcoreSeconds")]
            [Validation(Required=false)]
            public long? VcoreSeconds { get; set; }

            /// <summary>
            /// <para>The URL of the web UI for the Spark application.</para>
            /// </summary>
            [NameInMap("webUI")]
            [Validation(Required=false)]
            public string WebUI { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
