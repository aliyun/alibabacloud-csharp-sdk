// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryGuideItemGroupWithOutInventoryResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ItemList")]
        [Validation(Required=false)]
        public List<QueryGuideItemGroupWithOutInventoryResponseBodyItemList> ItemList { get; set; }
        public class QueryGuideItemGroupWithOutInventoryResponseBodyItemList : TeaModel {
            [NameInMap("CustomizedAttributeMap")]
            [Validation(Required=false)]
            public Dictionary<string, object> CustomizedAttributeMap { get; set; }

            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public string ItemId { get; set; }

            [NameInMap("ItemTitle")]
            [Validation(Required=false)]
            public string ItemTitle { get; set; }

            [NameInMap("ItemUrl")]
            [Validation(Required=false)]
            public string ItemUrl { get; set; }

            [NameInMap("LmItemId")]
            [Validation(Required=false)]
            public string LmItemId { get; set; }

            [NameInMap("MainPicUrl")]
            [Validation(Required=false)]
            public string MainPicUrl { get; set; }

            [NameInMap("PointPrice")]
            [Validation(Required=false)]
            public long? PointPrice { get; set; }

            [NameInMap("Points")]
            [Validation(Required=false)]
            public long? Points { get; set; }

            [NameInMap("PointsAmount")]
            [Validation(Required=false)]
            public long? PointsAmount { get; set; }

            [NameInMap("PriceCent")]
            [Validation(Required=false)]
            public long? PriceCent { get; set; }

            [NameInMap("ReservePrice")]
            [Validation(Required=false)]
            public string ReservePrice { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<string> Tags { get; set; }

            [NameInMap("WhitePicUrl")]
            [Validation(Required=false)]
            public string WhitePicUrl { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
