// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeAssetGroupToInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeAssetGroupToInstanceResponseBodyDataList> DataList { get; set; }
        public class DescribeAssetGroupToInstanceResponseBodyDataList : TeaModel {
            /// <summary>
            /// <para>The ID of the Anti-DDoS Origin instance of a paid edition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ddosbgp-cn-7212zaa5v***</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The UID of the member to which the asset belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>170858869679****</para>
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public string MemberUid { get; set; }

            /// <summary>
            /// <para>The ID of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>waf_v2_public_cn-lbj382l****</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The region ID of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The type of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>waf</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C73C59B9-9F5C-57FF-A394-13EC8FC3B2FF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
