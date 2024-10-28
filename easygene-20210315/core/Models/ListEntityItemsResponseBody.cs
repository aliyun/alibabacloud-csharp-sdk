// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class ListEntityItemsResponseBody : TeaModel {
        [NameInMap("EntityItems")]
        [Validation(Required=false)]
        public List<ListEntityItemsResponseBodyEntityItems> EntityItems { get; set; }
        public class ListEntityItemsResponseBodyEntityItems : TeaModel {
            [NameInMap("EntityData")]
            [Validation(Required=false)]
            public Dictionary<string, string> EntityData { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>s1</para>
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
        /// <para>MTIzNDU2P1dvcmtzcGFjZT93cy1mMDE4OTgxNGU1ZTkK</para>
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
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
