// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20181012.Models
{
    public class ListSceneItemsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListSceneItemsResponseBodyResult Result { get; set; }
        public class ListSceneItemsResponseBodyResult : TeaModel {
            [NameInMap("Total")]
            [Validation(Required=false)]
            public ListSceneItemsResponseBodyResultTotal Total { get; set; }
            public class ListSceneItemsResponseBodyResultTotal : TeaModel {
                [NameInMap("WeightItem")]
                [Validation(Required=false)]
                public long? WeightItem { get; set; }

                [NameInMap("InstanceRecommendItem")]
                [Validation(Required=false)]
                public long? InstanceRecommendItem { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

                [NameInMap("SceneRecommendItem")]
                [Validation(Required=false)]
                public long? SceneRecommendItem { get; set; }

                [NameInMap("SceneWeightItem")]
                [Validation(Required=false)]
                public long? SceneWeightItem { get; set; }

            }
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public List<ListSceneItemsResponseBodyResultDetail> Detail { get; set; }
            public class ListSceneItemsResponseBodyResultDetail : TeaModel {
                public string Status { get; set; }
                public string PubTime { get; set; }
                public string ExpireTime { get; set; }
                public string ItemType { get; set; }
                public string Author { get; set; }
                public string CategoryPath { get; set; }
                public string ItemId { get; set; }
                public string ShopId { get; set; }
                public string BrandId { get; set; }
                public string Channel { get; set; }
                public string Duration { get; set; }
                public string Title { get; set; }
            }
        };

    }

}
