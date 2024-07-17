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
        /// The node name.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The node type. Valid values:
        /// 
        /// *   qrs: Query Result Searcher (QRS) worker
        /// *   search: Search worker
        /// *   index: index
        /// *   cluster: cluster
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
