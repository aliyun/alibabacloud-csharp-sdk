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
        /// <para>The maximum number of results to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("max_results")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Set this parameter to the value of <c>NextToken</c> returned by the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5c0a1c0f91c14c6****</para>
        /// </summary>
        [NameInMap("next_token")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page_number")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of results per page.</para>
        /// <para>Valid values: [1,100].</para>
        /// <para>Default: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("page_size")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The event type. If you do not specify this parameter, events of all types are returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>cluster_create</c>: Create a cluster.</para>
        /// </description></item>
        /// <item><description><para><c>cluster_scaleout</c>: Scale out a cluster.</para>
        /// </description></item>
        /// <item><description><para><c>cluster_attach</c>: Attach an existing node.</para>
        /// </description></item>
        /// <item><description><para><c>cluster_delete</c>: Delete a cluster.</para>
        /// </description></item>
        /// <item><description><para><c>cluster_upgrade</c>: Upgrade a cluster.</para>
        /// </description></item>
        /// <item><description><para><c>cluster_migrate</c>: Migrate a cluster.</para>
        /// </description></item>
        /// <item><description><para><c>cluster_node_delete</c>: Remove a node.</para>
        /// </description></item>
        /// <item><description><para><c>cluster_node_drain</c>: Drain a node.</para>
        /// </description></item>
        /// <item><description><para><c>cluster_modify</c>: Modify a cluster.</para>
        /// </description></item>
        /// <item><description><para><c>cluster_configuration_modify</c>: Modify the control plane configuration of a cluster.</para>
        /// </description></item>
        /// <item><description><para><c>cluster_addon_install</c>: Install an add-on.</para>
        /// </description></item>
        /// <item><description><para><c>cluster_addon_upgrade</c>: Upgrade an add-on.</para>
        /// </description></item>
        /// <item><description><para><c>cluster_addon_uninstall</c>: Uninstall an add-on.</para>
        /// </description></item>
        /// <item><description><para><c>runtime_upgrade</c>: Upgrade the runtime.</para>
        /// </description></item>
        /// <item><description><para><c>nodepool_upgrade</c>: Upgrade a node pool.</para>
        /// </description></item>
        /// <item><description><para><c>nodepool_update</c>: Update a node pool.</para>
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

}
