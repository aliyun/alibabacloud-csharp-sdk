// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryGuideItemGroupResponseBody : TeaModel {
        [NameInMap("GuideItemGroup")]
        [Validation(Required=false)]
        public QueryGuideItemGroupResponseBodyGuideItemGroup GuideItemGroup { get; set; }
        public class QueryGuideItemGroupResponseBodyGuideItemGroup : TeaModel {
            [NameInMap("ItemInfo")]
            [Validation(Required=false)]
            public List<QueryGuideItemGroupResponseBodyGuideItemGroupItemInfo> ItemInfo { get; set; }
            public class QueryGuideItemGroupResponseBodyGuideItemGroupItemInfo : TeaModel {
                public long? PriceCent { get; set; }
                public string MainPicUrl { get; set; }
                public string ItemTitle { get; set; }
                public string LmItemId { get; set; }
                public long? PointPrice { get; set; }
                public long? ItemId { get; set; }
                public long? Points { get; set; }
                public long? PointsAmount { get; set; }
                public string ReservePrice { get; set; }
                public string ItemUrl { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("SubMessage")]
        [Validation(Required=false)]
        public string SubMessage { get; set; }

        [NameInMap("SubCode")]
        [Validation(Required=false)]
        public string SubCode { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
