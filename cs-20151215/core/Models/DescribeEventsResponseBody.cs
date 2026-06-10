// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of events.</para>
        /// </summary>
        [NameInMap("events")]
        [Validation(Required=false)]
        public List<DescribeEventsResponseBodyEvents> Events { get; set; }
        public class DescribeEventsResponseBodyEvents : TeaModel {
            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cf62854ac2130470897be7a27ed1f****</para>
            /// </summary>
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The event details.</para>
            /// </summary>
            [NameInMap("data")]
            [Validation(Required=false)]
            public DescribeEventsResponseBodyEventsData Data { get; set; }
            public class DescribeEventsResponseBodyEventsData : TeaModel {
                /// <summary>
                /// <para>The severity level of the event. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>info: An informational message.</para>
                /// </description></item>
                /// <item><description><para>warning: A warning.</para>
                /// </description></item>
                /// <item><description><para>error: An error.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>info</para>
                /// </summary>
                [NameInMap("level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// <para>A human-readable description of the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Start to upgrade NodePool nodePool/nodePool-A</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>A brief, machine-readable string that describes the reason for the event.</para>
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
            /// <para>e-dba703c8-953b-40d8-82e8-cb713590****</para>
            /// </summary>
            [NameInMap("event_id")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            /// <summary>
            /// <para>The source of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The object that the event is about.</para>
            /// 
            /// <b>Example:</b>
            /// <para>np6a5c86f4ecae436f8f4a3dc034a7****</para>
            /// </summary>
            [NameInMap("subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

            /// <summary>
            /// <para>The event timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-23T20:48:01+08:00</para>
            /// </summary>
            [NameInMap("time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            /// <summary>
            /// <para>The event type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>cluster_create</c>: A cluster is created.</para>
            /// </description></item>
            /// <item><description><para><c>cluster_scaleout</c>: A cluster is scaled out.</para>
            /// </description></item>
            /// <item><description><para><c>cluster_attach</c>: An existing node is added.</para>
            /// </description></item>
            /// <item><description><para><c>cluster_delete</c>: A cluster is deleted.</para>
            /// </description></item>
            /// <item><description><para><c>cluster_upgrade</c>: A cluster is upgraded.</para>
            /// </description></item>
            /// <item><description><para><c>cluster_migrate</c>: A cluster is migrated.</para>
            /// </description></item>
            /// <item><description><para><c>cluster_node_delete</c>: A node is removed.</para>
            /// </description></item>
            /// <item><description><para><c>cluster_node_drain</c>: A node is drained.</para>
            /// </description></item>
            /// <item><description><para><c>cluster_modify</c>: A cluster is modified.</para>
            /// </description></item>
            /// <item><description><para><c>cluster_configuration_modify</c>: The control plane configuration of a cluster is modified.</para>
            /// </description></item>
            /// <item><description><para><c>cluster_addon_install</c>: An add-on is installed.</para>
            /// </description></item>
            /// <item><description><para><c>cluster_addon_upgrade</c>: An add-on is upgraded.</para>
            /// </description></item>
            /// <item><description><para><c>cluster_addon_uninstall</c>: An add-on is uninstalled.</para>
            /// </description></item>
            /// <item><description><para><c>runtime_upgrade</c>: The runtime is upgraded.</para>
            /// </description></item>
            /// <item><description><para><c>nodepool_upgrade</c>: A node pool is upgraded.</para>
            /// </description></item>
            /// <item><description><para><c>nodepool_update</c>: A node pool is updated.</para>
            /// </description></item>
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
        /// <para>The token to retrieve the next page of results. If this parameter is absent from the response, all results have been returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5c0a1c0f91c14c6****</para>
        /// </summary>
        [NameInMap("next_token")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("page_info")]
        [Validation(Required=false)]
        public DescribeEventsResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeEventsResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The current page number.</para>
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
            /// <para>3</para>
            /// </summary>
            [NameInMap("total_count")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

    }

}
