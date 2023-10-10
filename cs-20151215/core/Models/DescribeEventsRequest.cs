// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeEventsRequest : TeaModel {
        /// <summary>
        /// The cluster ID.
        /// </summary>
        [NameInMap("cluster_id")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("page_number")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("page_size")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The event type. Valid values:
        /// 
        /// *   `cluster_create`: cluster creation.
        /// *   `cluster_scaleout`: cluster scale-out.
        /// *   `cluster_attach`: node addition.
        /// *   `cluster_delete`: cluster deletion.
        /// *   `cluster_upgrade`: cluster upgrades.
        /// *   `cluster_migrate`: cluster migration.
        /// *   `cluster_node_delete`: node removal.
        /// *   `cluster_node_drain`: node draining.
        /// *   `cluster_modify`: cluster modifications.
        /// *   `cluster_configuration_modify`: modifications of control plane configurations.
        /// *   `cluster_addon_install`: component installation.
        /// *   `cluster_addon_upgrade`: component updates.
        /// *   `cluster_addon_uninstall`: component uninstallation.
        /// *   `runtime_upgrade`: runtime updates.
        /// *   `nodepool_upgrade`: node pool upgrades.
        /// *   `nodepool_update`: node pool updates.
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
