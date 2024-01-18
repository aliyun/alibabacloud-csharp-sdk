// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryGuideItemGroupResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("GuideItemGroup")]
        [Validation(Required=false)]
        public QueryGuideItemGroupResponseBodyGuideItemGroup GuideItemGroup { get; set; }
        public class QueryGuideItemGroupResponseBodyGuideItemGroup : TeaModel {
            [NameInMap("ItemInfo")]
            [Validation(Required=false)]
            public List<QueryGuideItemGroupResponseBodyGuideItemGroupItemInfo> ItemInfo { get; set; }
            public class QueryGuideItemGroupResponseBodyGuideItemGroupItemInfo : TeaModel {
                [NameInMap("ItemId")]
                [Validation(Required=false)]
                public long? ItemId { get; set; }

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

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SubCode")]
        [Validation(Required=false)]
        public string SubCode { get; set; }

        [NameInMap("SubMessage")]
        [Validation(Required=false)]
        public string SubMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
