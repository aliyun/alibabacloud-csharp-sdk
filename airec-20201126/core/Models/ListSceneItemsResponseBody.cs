// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class ListSceneItemsResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public ListSceneItemsResponseBodyResult Result { get; set; }
        public class ListSceneItemsResponseBodyResult : TeaModel {
            [NameInMap("detail")]
            [Validation(Required=false)]
            public List<ListSceneItemsResponseBodyResultDetail> Detail { get; set; }
            public class ListSceneItemsResponseBodyResultDetail : TeaModel {
                [NameInMap("author")]
                [Validation(Required=false)]
                public string Author { get; set; }

                [NameInMap("brandId")]
                [Validation(Required=false)]
                public string BrandId { get; set; }

                [NameInMap("categoryPath")]
                [Validation(Required=false)]
                public string CategoryPath { get; set; }

                [NameInMap("channel")]
                [Validation(Required=false)]
                public string Channel { get; set; }

                [NameInMap("duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                [NameInMap("expireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                [NameInMap("itemId")]
                [Validation(Required=false)]
                public string ItemId { get; set; }

                [NameInMap("itemType")]
                [Validation(Required=false)]
                public string ItemType { get; set; }

                [NameInMap("pubTime")]
                [Validation(Required=false)]
                public string PubTime { get; set; }

                [NameInMap("shopId")]
                [Validation(Required=false)]
                public string ShopId { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("total")]
            [Validation(Required=false)]
            public ListSceneItemsResponseBodyResultTotal Total { get; set; }
            public class ListSceneItemsResponseBodyResultTotal : TeaModel {
                [NameInMap("instanceRecommendItem")]
                [Validation(Required=false)]
                public long? InstanceRecommendItem { get; set; }

                [NameInMap("sceneRecommendItem")]
                [Validation(Required=false)]
                public long? SceneRecommendItem { get; set; }

                [NameInMap("sceneWeightItem")]
                [Validation(Required=false)]
                public long? SceneWeightItem { get; set; }

                [NameInMap("totalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

                [NameInMap("weightItem")]
                [Validation(Required=false)]
                public long? WeightItem { get; set; }

            }

        }

    }

}
