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
            /// <para>The event description.</para>
            /// </summary>
            [NameInMap("data")]
            [Validation(Required=false)]
            public DescribeClusterEventsResponseBodyEventsData Data { get; set; }
            public class DescribeClusterEventsResponseBodyEventsData : TeaModel {
                /// <summary>
                /// <para>The event level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>info</para>
                /// </summary>
                [NameInMap("level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// <para>The event details.</para>
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
            /// <para>The operation object associated with the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>npdd89dc2b76c04f14b06774883b******</para>
            /// </summary>
            [NameInMap("subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

            /// <summary>
            /// <para>The start time of the event in ISO 8601 format, including the time zone.</para>
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
            /// <item><description>cluster_create: Cluster creation.</description></item>
            /// <item><description>cluster_scaleout: Cluster scale-out.</description></item>
            /// <item><description>cluster_attach: Addition of existing nodes.</description></item>
            /// <item><description>cluster_delete: Cluster deletion.</description></item>
            /// <item><description>cluster_upgrade: Cluster upgrade.</description></item>
            /// <item><description>cluster_migrate: Cluster migration.</description></item>
            /// <item><description>cluster_node_delete: Node removal.</description></item>
            /// <item><description>cluster_node_drain: Node draining.</description></item>
            /// <item><description>cluster_modify: Cluster modification.</description></item>
            /// <item><description>cluster_configuration_modify: Cluster management configuration modification.</description></item>
            /// <item><description>cluster_addon_install: Add-on installation.</description></item>
            /// <item><description>cluster_addon_upgrade: Add-on upgrade.</description></item>
            /// <item><description>cluster_addon_uninstall: Add-on uninstallation.</description></item>
            /// <item><description>runtime_upgrade: Runtime upgrade.</description></item>
            /// <item><description>nodepool_upgrade: Node pool upgrade.</description></item>
            /// <item><description>nodepool_update: Node pool update.</description></item>
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
        /// <para>The pagination token.</para>
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
            /// <para>The maximum number of results to return per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("page_size")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of results.</para>
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
