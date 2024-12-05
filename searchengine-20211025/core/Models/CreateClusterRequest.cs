// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class CreateClusterRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("autoLoad")]
        [Validation(Required=false)]
        public bool? AutoLoad { get; set; }

        /// <summary>
        /// <para>The details of the Searcher workers.</para>
        /// </summary>
        [NameInMap("dataNode")]
        [Validation(Required=false)]
        public CreateClusterRequestDataNode DataNode { get; set; }
        public class CreateClusterRequestDataNode : TeaModel {
            /// <summary>
            /// <para>The number of Searcher workers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("number")]
            [Validation(Required=false)]
            public int? Number { get; set; }

            /// <summary>
            /// <para>The number of shards.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("partition")]
            [Validation(Required=false)]
            public string Partition { get; set; }

        }

        /// <summary>
        /// <para>The description of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;ha-tets&quot;</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The cluster name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ha-cn-zvp2qr1sk01_qrs</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The details of the Query Result Searcher (QRS) workers.</para>
        /// </summary>
        [NameInMap("queryNode")]
        [Validation(Required=false)]
        public CreateClusterRequestQueryNode QueryNode { get; set; }
        public class CreateClusterRequestQueryNode : TeaModel {
            /// <summary>
            /// <para>The number of QRS workers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("number")]
            [Validation(Required=false)]
            public int? Number { get; set; }

        }

    }

}
