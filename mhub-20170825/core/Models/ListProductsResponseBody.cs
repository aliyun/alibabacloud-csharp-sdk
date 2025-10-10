// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mhub20170825.Models
{
    public class ListProductsResponseBody : TeaModel {
        [NameInMap("ProductInfos")]
        [Validation(Required=false)]
        public ListProductsResponseBodyProductInfos ProductInfos { get; set; }
        public class ListProductsResponseBodyProductInfos : TeaModel {
            [NameInMap("ProductInfo")]
            [Validation(Required=false)]
            public List<ListProductsResponseBodyProductInfosProductInfo> ProductInfo { get; set; }
            public class ListProductsResponseBodyProductInfosProductInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-12-16T06:25:52Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxxx</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>图片 base64</para>
                /// </summary>
                [NameInMap("EncodedIcon")]
                [Validation(Required=false)]
                public string EncodedIcon { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IndustryId")]
                [Validation(Required=false)]
                public int? IndustryId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>我的项目</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>iOS</para>
                /// </summary>
                [NameInMap("Platforms")]
                [Validation(Required=false)]
                public string Platforms { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("ProductId")]
                [Validation(Required=false)]
                public int? ProductId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Readonly")]
                [Validation(Required=false)]
                public bool? Readonly { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>126D4DDD-05A5-49B1-B18C-39C4A929BFB2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("UbsmsStatus")]
        [Validation(Required=false)]
        public string UbsmsStatus { get; set; }

    }

}
