// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class ListHotelSceneItemResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public ListHotelSceneItemResponseBodyPage Page { get; set; }
        public class ListHotelSceneItemResponseBodyPage : TeaModel {
            [NameInMap("HasNext")]
            [Validation(Required=false)]
            public bool? HasNext { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public int? TotalPage { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CEADB586-51CB-1B6B-95BD-AB85A7A08E97</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListHotelSceneItemResponseBodyResult Result { get; set; }
        public class ListHotelSceneItemResponseBodyResult : TeaModel {
            [NameInMap("SecondCategoryList")]
            [Validation(Required=false)]
            public List<ListHotelSceneItemResponseBodyResultSecondCategoryList> SecondCategoryList { get; set; }
            public class ListHotelSceneItemResponseBodyResultSecondCategoryList : TeaModel {
                [NameInMap("ItemList")]
                [Validation(Required=false)]
                public List<ListHotelSceneItemResponseBodyResultSecondCategoryListItemList> ItemList { get; set; }
                public class ListHotelSceneItemResponseBodyResultSecondCategoryListItemList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>客用品类</para>
                    /// </summary>
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="https://ailabsaicloudservice.alicdn.com/hotel/icon/jiudianmianban_fuwushangpintu/wupin/keyongpinlei/mianqian.png">https://ailabsaicloudservice.alicdn.com/hotel/icon/jiudianmianban_fuwushangpintu/wupin/keyongpinlei/mianqian.png</a></para>
                    /// </summary>
                    [NameInMap("Icon")]
                    [Validation(Required=false)]
                    public string Icon { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>152860</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>棉签</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Price")]
                    [Validation(Required=false)]
                    public long? Price { get; set; }

                    [NameInMap("ResidueLimit")]
                    [Validation(Required=false)]
                    public long? ResidueLimit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>已添加</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>GOODS</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>客用品类</para>
                /// </summary>
                [NameInMap("SecondCategoryName")]
                [Validation(Required=false)]
                public string SecondCategoryName { get; set; }

            }

        }

    }

}
