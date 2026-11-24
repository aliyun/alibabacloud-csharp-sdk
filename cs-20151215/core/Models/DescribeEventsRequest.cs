// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeEventsRequest : TeaModel {
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
        /// <para>The maximum number of results to return for a single request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("max_results")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The query token, which is the value of the NextToken parameter returned by the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5c0a1c0f91c14c6****</para>
        /// </summary>
        [NameInMap("next_token")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number for paging.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page_number")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return per page.</para>
        /// <para>Valid values: 1 to 100.</para>
        /// <para>Default value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("page_size")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The event type. If you do not specify this parameter, events of all types are queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>cluster_create</c>: cluster creation</description></item>
        /// <item><description><c>cluster_scaleout</c>: cluster scale-out</description></item>
        /// <item><description><c>cluster_attach</c>: adding existing nodes</description></item>
        /// <item><description><c>cluster_delete</c>: cluster deletion</description></item>
        /// <item><description><c>cluster_upgrade</c>: cluster upgrade</description></item>
        /// <item><description><c>cluster_migrate</c>: cluster migration</description></item>
        /// <item><description><c>cluster_node_delete</c>: node removal</description></item>
        /// <item><description><c>cluster_node_drain</c>: node draining</description></item>
        /// <item><description><c>cluster_modify</c>: cluster modification</description></item>
        /// <item><description><c>cluster_configuration_modify</c>: cluster management configuration modification</description></item>
        /// <item><description><c>cluster_addon_install</c>: add-on installation</description></item>
        /// <item><description><c>cluster_addon_upgrade</c>: add-on upgrade</description></item>
        /// <item><description><c>cluster_addon_uninstall</c>: add-on uninstallation</description></item>
        /// <item><description><c>runtime_upgrade</c>: runtime upgrade</description></item>
        /// <item><description><c>nodepool_upgrade</c>: node pool upgrade</description></item>
        /// <item><description><c>nodepool_update</c>: node pool update</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>nodepool_upgrade</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
