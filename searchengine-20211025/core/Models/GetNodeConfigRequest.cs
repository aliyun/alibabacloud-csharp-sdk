// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetNodeConfigRequest : TeaModel {
        /// <summary>
        /// The name of the cluster
        /// </summary>
        [NameInMap("clusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// The name of the cluster.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The type of the node. Valid values: qrs, search, index, and cluster. qrs indicates a query node, search indicates a data node, index indicates an index node, and cluster indicates a cluster node.
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
