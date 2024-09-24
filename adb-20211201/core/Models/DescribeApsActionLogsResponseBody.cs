// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeApsActionLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the request denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;AuthAction&quot;: &quot;xxx&quot;,
        ///   &quot;AuthPrincipalDisplayName&quot;: &quot;sampleName&quot;,
        ///   &quot;AuthPrincipalOwnerId&quot;: &quot;111111111111111111&quot;,
        ///   &quot;AuthPrincipalType&quot;: &quot;SubUser&quot;,
        ///   &quot;AuthResource&quot;: &quot;xxx&quot;,
        ///   &quot;NoPermissionType&quot;: &quot;xxx&quot;,
        ///   &quot;PolicyType&quot;: &quot;xxx&quot;
        /// }</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The queried logs.</para>
        /// </summary>
        [NameInMap("ActionLogs")]
        [Validation(Required=false)]
        public List<DescribeApsActionLogsResponseBodyActionLogs> ActionLogs { get; set; }
        public class DescribeApsActionLogsResponseBodyActionLogs : TeaModel {
            /// <summary>
            /// <para>The content of the log.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DDL migration job finished</para>
            /// </summary>
            [NameInMap("Context")]
            [Validation(Required=false)]
            public string Context { get; set; }

            /// <summary>
            /// <para>The phase during which the log was generated. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>StructureMigrate</b>: schema migration.</description></item>
            /// <item><description><b>FullDataSync</b>: full data synchronization.</description></item>
            /// <item><description><b>IncrementalSync</b>: incremental data synchronization.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FullDataSync</para>
            /// </summary>
            [NameInMap("Stage")]
            [Validation(Required=false)]
            public string Stage { get; set; }

            /// <summary>
            /// <para>The type of the log. Multiple log types are separated by commas (,). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>INFO</b></description></item>
            /// <item><description><b>WARN</b></description></item>
            /// <item><description><b>ERROR</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>INFO,WARN,ERROR</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The time when the log was generated. The time follows the ISO 8601 standard in the <b>yyyy-MM-ddTHH:mm:ssZ</b> format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-02-01T05:46:30Z</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

        }

        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp1r053byu48p****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A5EDBA27-AF3E-5966-9503-FD1557E19167</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        /// <summary>
        /// <para>The ID of the real-time data ingestion job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aps-hz109vpvt4fg8528d****</para>
        /// </summary>
        [NameInMap("WorkloadId")]
        [Validation(Required=false)]
        public string WorkloadId { get; set; }

    }

}
