// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class CreateClusterRequest : TeaModel {
        /// <summary>
        /// The remarks of the query node
        /// </summary>
        [NameInMap("autoLoad")]
        [Validation(Required=false)]
        public bool? AutoLoad { get; set; }

        /// <summary>
        /// The description of the data node
        /// </summary>
        [NameInMap("dataNode")]
        [Validation(Required=false)]
        public CreateClusterRequestDataNode DataNode { get; set; }
        public class CreateClusterRequestDataNode : TeaModel {
            /// <summary>
            /// The number of data nodes
            /// </summary>
            [NameInMap("number")]
            [Validation(Required=false)]
            public int? Number { get; set; }

        }

        /// <summary>
        /// The description of the cluster
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the node
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The description of the query node
        /// </summary>
        [NameInMap("queryNode")]
        [Validation(Required=false)]
        public CreateClusterRequestQueryNode QueryNode { get; set; }
        public class CreateClusterRequestQueryNode : TeaModel {
            /// <summary>
            /// The number of nodes to query
            /// </summary>
            [NameInMap("number")]
            [Validation(Required=false)]
            public int? Number { get; set; }

        }

    }

}
