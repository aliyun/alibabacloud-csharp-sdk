// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListKyuubiSparkApplicationsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of application details.</para>
        /// </summary>
        [NameInMap("applications")]
        [Validation(Required=false)]
        public List<ListKyuubiSparkApplicationsResponseBodyApplications> Applications { get; set; }
        public class ListKyuubiSparkApplicationsResponseBodyApplications : TeaModel {
            /// <summary>
            /// <para>The ID of the Spark application submitted by Kyuubi.</para>
            /// 
            /// <b>Example:</b>
            /// <para>spark-339f844005b6404c95f9f7c7a13b****</para>
            /// </summary>
            [NameInMap("applicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>The name of the Spark application submitted by Kyuubi.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kyuubi-connection-spark-sql-anonymous-fa9a5e73-b4b1-474a-b****</para>
            /// </summary>
            [NameInMap("applicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            /// <summary>
            /// <para>The number of CUs consumed during the task lifecycle. This is an estimated value. The final amount is subject to your bill.</para>
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
            /// <para>The exit code.</para>
            /// 
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
            /// <para>The status of the last task execution in the session.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("latestSqlStatementStatus")]
            [Validation(Required=false)]
            public string LatestSqlStatementStatus { get; set; }

            /// <summary>
            /// <para>The total memory allocated to the task in MB, multiplied by the number of seconds the task ran.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3513900</para>
            /// </summary>
            [NameInMap("mbSeconds")]
            [Validation(Required=false)]
            public long? MbSeconds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// <para>The name of the resource queue where the Spark task runs.</para>
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
            /// <item><description><para>STARTING: The application is starting.</para>
            /// </description></item>
            /// <item><description><para>RUNNING: The application is running.</para>
            /// </description></item>
            /// <item><description><para>TERMINATED: The application is terminated.</para>
            /// </description></item>
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
            /// <para>The total vCores allocated to the task, multiplied by the number of seconds the task ran.</para>
            /// 
            /// <b>Example:</b>
            /// <para>780</para>
            /// </summary>
            [NameInMap("vcoreSeconds")]
            [Validation(Required=false)]
            public long? VcoreSeconds { get; set; }

            /// <summary>
            /// <para>The URL of the Spark application UI.</para>
            /// </summary>
            [NameInMap("webUI")]
            [Validation(Required=false)]
            public string WebUI { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of records returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token to retrieve the next page of results.</para>
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
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
