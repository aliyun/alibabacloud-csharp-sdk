// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class CreateClusterRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable automatic connection.
        /// </summary>
        [NameInMap("autoLoad")]
        [Validation(Required=false)]
        public bool? AutoLoad { get; set; }

        /// <summary>
        /// The details of the Searcher workers.
        /// </summary>
        [NameInMap("dataNode")]
        [Validation(Required=false)]
        public CreateClusterRequestDataNode DataNode { get; set; }
        public class CreateClusterRequestDataNode : TeaModel {
            /// <summary>
            /// The number of Searcher workers.
            /// </summary>
            [NameInMap("number")]
            [Validation(Required=false)]
            public int? Number { get; set; }

            /// <summary>
            /// The number of shards.
            /// </summary>
            [NameInMap("partition")]
            [Validation(Required=false)]
            public string Partition { get; set; }

        }

        /// <summary>
        /// The description of the cluster.
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The cluster name.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The details of the Query Result Searcher (QRS) workers.
        /// </summary>
        [NameInMap("queryNode")]
        [Validation(Required=false)]
        public CreateClusterRequestQueryNode QueryNode { get; set; }
        public class CreateClusterRequestQueryNode : TeaModel {
            /// <summary>
            /// The number of QRS workers.
            /// </summary>
            [NameInMap("number")]
            [Validation(Required=false)]
            public int? Number { get; set; }

        }

    }

}
