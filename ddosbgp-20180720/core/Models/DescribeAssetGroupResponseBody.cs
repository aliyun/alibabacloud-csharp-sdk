// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeAssetGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the asset.</para>
        /// </summary>
        [NameInMap("AssetGroupList")]
        [Validation(Required=false)]
        public List<DescribeAssetGroupResponseBodyAssetGroupList> AssetGroupList { get; set; }
        public class DescribeAssetGroupResponseBodyAssetGroupList : TeaModel {
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
            /// <para>The region to which the asset belongs.</para>
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
        /// <para>487EC0F7-8D14-504E-914E-3A1BC314B581</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
