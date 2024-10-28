// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class ListPublicDatasetEntityItemsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>西蒙斯基因组多样性计划</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        [NameInMap("EntityItems")]
        [Validation(Required=false)]
        public List<ListPublicDatasetEntityItemsResponseBodyEntityItems> EntityItems { get; set; }
        public class ListPublicDatasetEntityItemsResponseBodyEntityItems : TeaModel {
            [NameInMap("EntityData")]
            [Validation(Required=false)]
            public Dictionary<string, string> EntityData { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sample</para>
            /// </summary>
            [NameInMap("EntityName")]
            [Validation(Required=false)]
            public string EntityName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>easygene.cn-beijing.aliyuncs.com</para>
        /// </summary>
        [NameInMap("HostId")]
        [Validation(Required=false)]
        public string HostId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ba6d88e2-a6f2-4d2c-a2ae-68b76b078445</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DA980AD0-158F-44F3-847D-5EAB96C0EB6B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
