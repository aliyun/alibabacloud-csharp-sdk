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
        /// <para>The maximum number of results returned per request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("max_results")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The query token. Set this parameter to the NextToken value returned by the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5c0a1c0f91c14c6****</para>
        /// </summary>
        [NameInMap("next_token")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number for the paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page_number")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return per page.</para>
        /// <para>Valid values: [1,100].</para>
        /// <para>Default value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("page_size")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The event type. If you do not set this parameter, all types of events are queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>cluster_create</c>: creates a cluster.</description></item>
        /// <item><description><c>cluster_scaleout</c>: scales out a cluster.</description></item>
        /// <item><description><c>cluster_attach</c>: adds existing nodes.</description></item>
        /// <item><description><c>cluster_delete</c>: deletes a cluster.</description></item>
        /// <item><description><c>cluster_upgrade</c>: upgrades a cluster.</description></item>
        /// <item><description><c>cluster_migrate</c>: migrates a cluster.</description></item>
        /// <item><description><c>cluster_node_delete</c>: removes nodes.</description></item>
        /// <item><description><c>cluster_node_drain</c>: drains nodes.</description></item>
        /// <item><description><c>cluster_modify</c>: modifies a cluster.</description></item>
        /// <item><description><c>cluster_configuration_modify</c>: modifies cluster management configurations.</description></item>
        /// <item><description><c>cluster_addon_install</c>: installs a component.</description></item>
        /// <item><description><c>cluster_addon_upgrade</c>: upgrades a component.</description></item>
        /// <item><description><c>cluster_addon_uninstall</c>: uninstalls a component.</description></item>
        /// <item><description><c>runtime_upgrade</c>: upgrades the runtime.</description></item>
        /// <item><description><c>nodepool_upgrade</c>: upgrades a node pool.</description></item>
        /// <item><description><c>nodepool_update</c>: updates a node pool.</description></item>
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
