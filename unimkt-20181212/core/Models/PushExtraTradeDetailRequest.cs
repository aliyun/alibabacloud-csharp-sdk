// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.UniMkt20181212.Models
{
    public class PushExtraTradeDetailRequest : TeaModel {
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        [NameInMap("CommodityId")]
        [Validation(Required=false)]
        public string CommodityId { get; set; }

        [NameInMap("CommodityName")]
        [Validation(Required=false)]
        public string CommodityName { get; set; }

        [NameInMap("DeviceSn")]
        [Validation(Required=false)]
        public string DeviceSn { get; set; }

        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("SalePrice")]
        [Validation(Required=false)]
        public float? SalePrice { get; set; }

        [NameInMap("TradePrice")]
        [Validation(Required=false)]
        public float? TradePrice { get; set; }

        [NameInMap("TradeStatus")]
        [Validation(Required=false)]
        public int? TradeStatus { get; set; }

        [NameInMap("TradeTime")]
        [Validation(Required=false)]
        public long? TradeTime { get; set; }

    }

}
