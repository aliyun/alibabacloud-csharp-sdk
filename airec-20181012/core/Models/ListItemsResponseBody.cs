// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20181012.Models
{
    public class ListItemsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListItemsResponseBodyResult Result { get; set; }
        public class ListItemsResponseBodyResult : TeaModel {
            [NameInMap("Total")]
            [Validation(Required=false)]
            public ListItemsResponseBodyResultTotal Total { get; set; }
            public class ListItemsResponseBodyResultTotal : TeaModel {
                [NameInMap("WeightItem")]
                [Validation(Required=false)]
                public long? WeightItem { get; set; }

                [NameInMap("InstanceRecommendItem")]
                [Validation(Required=false)]
                public long? InstanceRecommendItem { get; set; }

                [NameInMap("QueryCount")]
                [Validation(Required=false)]
                public long? QueryCount { get; set; }

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
            public List<ListItemsResponseBodyResultDetail> Detail { get; set; }
            public class ListItemsResponseBodyResultDetail : TeaModel {
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
