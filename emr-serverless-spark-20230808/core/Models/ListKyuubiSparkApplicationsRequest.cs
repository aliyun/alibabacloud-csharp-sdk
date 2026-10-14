// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListKyuubiSparkApplicationsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Spark application submitted by Kyuubi, used for search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>spark-339f844005b6404c95f9f7c7a13b****</para>
        /// </summary>
        [NameInMap("applicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The name of the Spark application submitted by Kyuubi, used for search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kyuubi-connection-spark-sql-anonymous-fa9a5e73-b4b1-474a-b****</para>
        /// </summary>
        [NameInMap("applicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// <para>The end time range of the task.</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public ListKyuubiSparkApplicationsRequestEndTime EndTime { get; set; }
        public class ListKyuubiSparkApplicationsRequestEndTime : TeaModel {
            /// <summary>
            /// <para>The end point of the task end time range. The value is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1774209636</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The start point of the task end time range. The value is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1774209636</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// <para>The list of statuses of the latest SQL statement used for filtering.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;SUCCESS&quot;]</para>
        /// </summary>
        [NameInMap("latestSqlStatementStatuses")]
        [Validation(Required=false)]
        public string LatestSqlStatementStatuses { get; set; }

        /// <summary>
        /// <para>The maximum number of records to retrieve at a time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The minimum execution duration of the application, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60000</para>
        /// </summary>
        [NameInMap("minDuration")]
        [Validation(Required=false)]
        public long? MinDuration { get; set; }

        /// <summary>
        /// <para>The token for the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The list of sort fields.</para>
        /// </summary>
        [NameInMap("orderBy")]
        [Validation(Required=false)]
        public List<string> OrderBy { get; set; }

        /// <summary>
        /// <para>The resource queue ID used to filter Spark applications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>root_queue</para>
        /// </summary>
        [NameInMap("resourceQueueId")]
        [Validation(Required=false)]
        public string ResourceQueueId { get; set; }

        /// <summary>
        /// <para>The sort order. A value of asc indicates ascending order, and desc indicates descending order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asc</para>
        /// </summary>
        [NameInMap("sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        /// <summary>
        /// <para>The start time range of the task.</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public ListKyuubiSparkApplicationsRequestStartTime StartTime { get; set; }
        public class ListKyuubiSparkApplicationsRequestStartTime : TeaModel {
            /// <summary>
            /// <para>The end point of the task start time range. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1710432000000</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The start point of the task start time range. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1709740800000</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// <para>The list of Spark application states used for filtering.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;ERROR&quot;]</para>
        /// </summary>
        [NameInMap("states")]
        [Validation(Required=false)]
        public string States { get; set; }

    }

}
