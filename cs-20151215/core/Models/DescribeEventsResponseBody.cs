// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeEventsResponseBody : Darabonba.Model {
        /// <summary>
        /// <para>The event details.</para>
        /// </summary>
        [NameInMap("events")]
        [Validation(Required=false)]
        public List<DescribeEventsResponseBodyEvents> Events { get; set; }
        public class DescribeEventsResponseBodyEvents : Darabonba.Model {
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
            /// <para>The event description.</para>
            /// </summary>
            [NameInMap("data")]
            [Validation(Required=false)]
            public DescribeEventsResponseBodyEventsData Data { get; set; }
            public class DescribeEventsResponseBodyEventsData : Darabonba.Model {
                /// <summary>
                /// <para>The event level. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>info: Information.</description></item>
                /// <item><description>warning: Warning.</description></item>
                /// <item><description>error: Error.</description></item>
                /// </list>
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
                /// <para>Start to upgrade NodePool nodePool/nodePool-A</para>
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
            /// <para>e-dba703c8-953b-40d8-82e8-cb713590****</para>
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
            /// <para>The event subject.</para>
            /// 
            /// <b>Example:</b>
            /// <para>np6a5c86f4ecae436f8f4a3dc034a7****</para>
            /// </summary>
            [NameInMap("subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

            /// <summary>
            /// <para>The start time of the event in ISO 8601 format, including the time zone.</para>
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
            /// <item><description><c>cluster_create</c>: Cluster creation.</description></item>
            /// <item><description><c>cluster_scaleout</c>: Cluster scale-out.</description></item>
            /// <item><description><c>cluster_attach</c>: Addition of existing nodes.</description></item>
            /// <item><description><c>cluster_delete</c>: Cluster deletion.</description></item>
            /// <item><description><c>cluster_upgrade</c>: Cluster upgrade.</description></item>
            /// <item><description><c>cluster_migrate</c>: Cluster migration.</description></item>
            /// <item><description><c>cluster_node_delete</c>: Node removal.</description></item>
            /// <item><description><c>cluster_node_drain</c>: Node draining.</description></item>
            /// <item><description><c>cluster_modify</c>: Cluster modification.</description></item>
            /// <item><description><c>cluster_configuration_modify</c>: Cluster control configuration modification.</description></item>
            /// <item><description><c>cluster_addon_install</c>: Add-on installation.</description></item>
            /// <item><description><c>cluster_addon_upgrade</c>: Add-on upgrade.</description></item>
            /// <item><description><c>cluster_addon_uninstall</c>: Add-on uninstallation.</description></item>
            /// <item><description><c>runtime_upgrade</c>: Runtime upgrade.</description></item>
            /// <item><description><c>nodepool_upgrade</c>: Node pool upgrade.</description></item>
            /// <item><description><c>nodepool_update</c>: Node pool update.</description></item>
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
        /// <para>The pagination token. Set this parameter to the next_token value returned from the previous API call.</para>
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
        public class DescribeEventsResponseBodyPageInfo : Darabonba.Model {
            /// <summary>
            /// <para>The page number for paging in the paged query.</para>
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
            /// <para>3</para>
            /// </summary>
            [NameInMap("total_count")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

    }

}

