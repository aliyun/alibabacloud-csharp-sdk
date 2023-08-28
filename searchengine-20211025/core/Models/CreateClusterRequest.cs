// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class CreateClusterRequest : TeaModel {
        /// <summary>
        /// Specifies whether to automatically balance the load between QRS workers.
        /// </summary>
        [NameInMap("autoLoad")]
        [Validation(Required=false)]
        public bool? AutoLoad { get; set; }

        /// <summary>
        /// The information about Searcher workers.
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

        }

        /// <summary>
        /// The description of the cluster.
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the cluster.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The information about Query Result Searcher (QRS) workers.
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
