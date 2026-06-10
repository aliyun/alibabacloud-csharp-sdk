// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of events.</para>
        /// </summary>
        [NameInMap("events")]
        [Validation(Required=false)]
        public List<DescribeClusterEventsResponseBodyEvents> Events { get; set; }
        public class DescribeClusterEventsResponseBodyEvents : TeaModel {
            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c82e6987e2961451182edacd74faf****</para>
            /// </summary>
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The event data.</para>
            /// </summary>
            [NameInMap("data")]
            [Validation(Required=false)]
            public DescribeClusterEventsResponseBodyEventsData Data { get; set; }
            public class DescribeClusterEventsResponseBodyEventsData : TeaModel {
                /// <summary>
                /// <para>The severity level of the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>info</para>
                /// </summary>
                [NameInMap("level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// <para>The event message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Start to upgrade NodePool nodePool/npdd89dc2b76c04f14b06774883b******</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The event status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Started</para>
                /// </summary>
                [NameInMap("reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

            }

            /// <summary>
            /// <para>The event ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e-9ad04f72-8ee7-46bf-a02c-e4a06b39****</para>
            /// </summary>
            [NameInMap("event_id")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            /// <summary>
            /// <para>The event source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The object associated with the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>npdd89dc2b76c04f14b06774883b******</para>
            /// </summary>
            [NameInMap("subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

            /// <summary>
            /// <para>The time the event occurred.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-05-14T10:00:56+08:00</para>
            /// </summary>
            [NameInMap("time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            /// <summary>
            /// <para>The event type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>cluster_create</c>: Cluster creation.</para>
            /// </description></item>
            /// <item><description><para><c>cluster_scaleout</c>: Cluster scale-out.</para>
            /// </description></item>
            /// <item><description><para><c>cluster_attach</c>: Attaching existing nodes to a cluster.</para>
            /// </description></item>
            /// <item><description><para><c>cluster_delete</c>: Cluster deletion.</para>
            /// </description></item>
            /// <item><description><para><c>cluster_upgrade</c>: Cluster upgrade.</para>
            /// </description></item>
            /// <item><description><para><c>cluster_migrate</c>: Cluster migration.</para>
            /// </description></item>
            /// <item><description><para><c>cluster_node_delete</c>: Node removal.</para>
            /// </description></item>
            /// <item><description><para><c>cluster_node_drain</c>: Node drain.</para>
            /// </description></item>
            /// <item><description><para><c>cluster_modify</c>: Cluster modification.</para>
            /// </description></item>
            /// <item><description><para><c>cluster_configuration_modify</c>: Control plane configuration modification.</para>
            /// </description></item>
            /// <item><description><para><c>cluster_addon_install</c>: Add-on installation.</para>
            /// </description></item>
            /// <item><description><para><c>cluster_addon_upgrade</c>: Add-on upgrade.</para>
            /// </description></item>
            /// <item><description><para><c>cluster_addon_uninstall</c>: Add-on uninstallation.</para>
            /// </description></item>
            /// <item><description><para><c>runtime_upgrade</c>: Container runtime upgrade.</para>
            /// </description></item>
            /// <item><description><para><c>nodepool_upgrade</c>: Node pool upgrade.</para>
            /// </description></item>
            /// <item><description><para><c>nodepool_update</c>: Node pool update.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>nodepool_update</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The token used to retrieve the next page of results. If this parameter is empty, there are no more results to return.</para>
        /// </summary>
        [NameInMap("next_token")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("page_info")]
        [Validation(Required=false)]
        public DescribeClusterEventsResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeClusterEventsResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("page_number")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("page_size")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries that match the query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>126</para>
            /// </summary>
            [NameInMap("total_count")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

    }

}
