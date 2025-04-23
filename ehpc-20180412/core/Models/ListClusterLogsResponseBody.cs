// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListClusterLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-FYUr32****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The queried operations logs.</para>
        /// </summary>
        [NameInMap("Logs")]
        [Validation(Required=false)]
        public ListClusterLogsResponseBodyLogs Logs { get; set; }
        public class ListClusterLogsResponseBodyLogs : TeaModel {
            [NameInMap("LogInfo")]
            [Validation(Required=false)]
            public List<ListClusterLogsResponseBodyLogsLogInfo> LogInfo { get; set; }
            public class ListClusterLogsResponseBodyLogsLogInfo : TeaModel {
                /// <summary>
                /// <para>The time when the log was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-09-18T13:24:13.000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The level of the log entry. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>warn</description></item>
                /// <item><description>error</description></item>
                /// <item><description>info</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>info</para>
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// <para>The content of the log.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Begin to create cluster</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The type of the operation. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CreateCluster</description></item>
                /// <item><description>StartCluster</description></item>
                /// <item><description>StopCluster</description></item>
                /// <item><description>DeleteCluster</description></item>
                /// <item><description>AddNodes</description></item>
                /// <item><description>StartNodes</description></item>
                /// <item><description>ResetNodes</description></item>
                /// <item><description>StopNodes</description></item>
                /// <item><description>DeleteNodes</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CreateCluster</para>
                /// </summary>
                [NameInMap("Operation")]
                [Validation(Required=false)]
                public string Operation { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BBC2F93D-003A-49C4-850C-B826EECF6667</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
