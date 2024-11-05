// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the events.</para>
        /// </summary>
        [NameInMap("events")]
        [Validation(Required=false)]
        public List<DescribeEventsResponseBodyEvents> Events { get; set; }
        public class DescribeEventsResponseBodyEvents : TeaModel {
            /// <summary>
            /// <para>The ID of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cluster-id</para>
            /// </summary>
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The description of the event.</para>
            /// </summary>
            [NameInMap("data")]
            [Validation(Required=false)]
            public DescribeEventsResponseBodyEventsData Data { get; set; }
            public class DescribeEventsResponseBodyEventsData : TeaModel {
                /// <summary>
                /// <para>The severity level of the event. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>info</description></item>
                /// <item><description>warning</description></item>
                /// <item><description>error</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>info</para>
                /// </summary>
                [NameInMap("level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// <para>The details of the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Start to upgrade NodePool nodePool/nodePool-A</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The status of the event.</para>
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
            /// <para>A234-1234-1234</para>
            /// </summary>
            [NameInMap("event_id")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            /// <summary>
            /// <para>The source of the event.</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The subject of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nodePool-id</para>
            /// </summary>
            [NameInMap("subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

            /// <summary>
            /// <para>The time when the event started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-23T20:48:01+08:00</para>
            /// </summary>
            [NameInMap("time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            /// <summary>
            /// <para>The event type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>cluster_create</c>: cluster creation.</description></item>
            /// <item><description><c>cluster_scaleout</c>: cluster scale-out.</description></item>
            /// <item><description><c>cluster_attach</c>: node addition.</description></item>
            /// <item><description><c>cluster_delete</c>: cluster deletion.</description></item>
            /// <item><description><c>cluster_upgrade</c>: cluster upgrades.</description></item>
            /// <item><description><c>cluster_migrate</c>: cluster migration.</description></item>
            /// <item><description><c>cluster_node_delete</c>: node removal.</description></item>
            /// <item><description><c>cluster_node_drain</c>: node draining.</description></item>
            /// <item><description><c>cluster_modify</c>: cluster modifications.</description></item>
            /// <item><description><c>cluster_configuration_modify</c>: modifications of control plane configurations.</description></item>
            /// <item><description><c>cluster_addon_install</c>: component installation.</description></item>
            /// <item><description><c>cluster_addon_upgrade</c>: component updates.</description></item>
            /// <item><description><c>cluster_addon_uninstall</c>: component uninstallation.</description></item>
            /// <item><description><c>runtime_upgrade</c>: runtime updates.</description></item>
            /// <item><description><c>nodepool_upgrade</c>: node pool upgrades.</description></item>
            /// <item><description><c>nodepool_update</c>: node pool updates.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>nodepool_upgrade</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("page_info")]
        [Validation(Required=false)]
        public DescribeEventsResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeEventsResponseBodyPageInfo : TeaModel {
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
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("page_size")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("total_count")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

    }

}
