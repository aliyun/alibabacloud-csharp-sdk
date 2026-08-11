// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class CreateClusterRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically mount the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("autoLoad")]
        [Validation(Required=false)]
        public bool? AutoLoad { get; set; }

        /// <summary>
        /// <para>The details of the data node.</para>
        /// </summary>
        [NameInMap("dataNode")]
        [Validation(Required=false)]
        public CreateClusterRequestDataNode DataNode { get; set; }
        public class CreateClusterRequestDataNode : TeaModel {
            /// <summary>
            /// <para>The number of data nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("number")]
            [Validation(Required=false)]
            public int? Number { get; set; }

            /// <summary>
            /// <para>The number of partitions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("partition")]
            [Validation(Required=false)]
            public string Partition { get; set; }

        }

        /// <summary>
        /// <para>The cluster description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Custom description</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The cluster name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hz_pre_vpc_domain_1</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The details of the query node.</para>
        /// </summary>
        [NameInMap("queryNode")]
        [Validation(Required=false)]
        public CreateClusterRequestQueryNode QueryNode { get; set; }
        public class CreateClusterRequestQueryNode : TeaModel {
            /// <summary>
            /// <para>The number of query nodes.</para>
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
