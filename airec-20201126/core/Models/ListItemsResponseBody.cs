// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class ListItemsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>6839AE7C-A984-48C1-AC17-331BAC6D97BC</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public ListItemsResponseBodyResult Result { get; set; }
        public class ListItemsResponseBodyResult : TeaModel {
            [NameInMap("detail")]
            [Validation(Required=false)]
            public List<ListItemsResponseBodyResultDetail> Detail { get; set; }
            public class ListItemsResponseBodyResultDetail : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("author")]
                [Validation(Required=false)]
                public string Author { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("brandId")]
                [Validation(Required=false)]
                public string BrandId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1_2</para>
                /// </summary>
                [NameInMap("categoryPath")]
                [Validation(Required=false)]
                public string CategoryPath { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>news</para>
                /// </summary>
                [NameInMap("channel")]
                [Validation(Required=false)]
                public string Channel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1647998107012</para>
                /// </summary>
                [NameInMap("expireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("itemId")]
                [Validation(Required=false)]
                public string ItemId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>item</para>
                /// </summary>
                [NameInMap("itemType")]
                [Validation(Required=false)]
                public string ItemType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1647998107012</para>
                /// </summary>
                [NameInMap("pubTime")]
                [Validation(Required=false)]
                public string PubTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("shopId")]
                [Validation(Required=false)]
                public string ShopId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("total")]
            [Validation(Required=false)]
            public ListItemsResponseBodyResultTotal Total { get; set; }
            public class ListItemsResponseBodyResultTotal : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("instanceRecommendItem")]
                [Validation(Required=false)]
                public long? InstanceRecommendItem { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3000</para>
                /// </summary>
                [NameInMap("queryCount")]
                [Validation(Required=false)]
                public long? QueryCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("sceneRecommendItem")]
                [Validation(Required=false)]
                public long? SceneRecommendItem { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("sceneWeightItem")]
                [Validation(Required=false)]
                public long? SceneWeightItem { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5000</para>
                /// </summary>
                [NameInMap("totalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("weightItem")]
                [Validation(Required=false)]
                public long? WeightItem { get; set; }

            }

        }

    }

}
