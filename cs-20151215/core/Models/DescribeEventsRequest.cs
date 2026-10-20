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
        /// <para>The pagination token. Set this parameter to the NextToken value returned from the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5c0a1c0f91c14c6****</para>
        /// </summary>
        [NameInMap("next_token")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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

}
