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

}
