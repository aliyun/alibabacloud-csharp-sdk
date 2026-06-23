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
            /// <para>The object associated with the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>npdd89dc2b76c04f14b06774883b******</para>
            /// </summary>
            [NameInMap("subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

            /// <summary>
            /// <para>The time when the event started.</para>
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
            /// <item><description>cluster_create: creates a cluster.</description></item>
            /// <item><description>cluster_scaleout: scales out a cluster.</description></item>
            /// <item><description>cluster_attach: adds existing nodes.</description></item>
            /// <item><description>cluster_delete: deletes a cluster.</description></item>
            /// <item><description>cluster_upgrade: upgrades a cluster.</description></item>
            /// <item><description>cluster_migrate: migrates a cluster.</description></item>
            /// <item><description>cluster_node_delete: removes nodes.</description></item>
            /// <item><description>cluster_node_drain: drains nodes.</description></item>
            /// <item><description>cluster_modify: modifies a cluster.</description></item>
            /// <item><description>cluster_configuration_modify: modifies cluster management configurations.</description></item>
            /// <item><description>cluster_addon_install: installs a component.</description></item>
            /// <item><description>cluster_addon_upgrade: upgrades a component.</description></item>
            /// <item><description>cluster_addon_uninstall: uninstalls a component.</description></item>
            /// <item><description>runtime_upgrade: upgrades the runtime.</description></item>
            /// <item><description>nodepool_upgrade: upgrades a node pool.</description></item>
            /// <item><description>nodepool_update: updates a node pool.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>nodepool_update</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

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
            /// <para>The maximum number of results returned per page.</para>
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
