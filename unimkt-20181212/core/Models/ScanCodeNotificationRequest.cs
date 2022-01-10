// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.UniMkt20181212.Models
{
    public class ScanCodeNotificationRequest : TeaModel {
        [NameInMap("Age")]
        [Validation(Required=false)]
        public int? Age { get; set; }

        [NameInMap("AlipayOpenId")]
        [Validation(Required=false)]
        public string AlipayOpenId { get; set; }

        [NameInMap("ApplyPrice")]
        [Validation(Required=false)]
        public int? ApplyPrice { get; set; }

        [NameInMap("BizResult")]
        [Validation(Required=false)]
        public string BizResult { get; set; }

        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("BrandNick")]
        [Validation(Required=false)]
        public string BrandNick { get; set; }

        [NameInMap("BrandUserId")]
        [Validation(Required=false)]
        public string BrandUserId { get; set; }

        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        [NameInMap("ChargeTag")]
        [Validation(Required=false)]
        public string ChargeTag { get; set; }

        [NameInMap("Cid")]
        [Validation(Required=false)]
        public string Cid { get; set; }

        [NameInMap("CommodityId")]
        [Validation(Required=false)]
        public string CommodityId { get; set; }

        [NameInMap("CostDetail")]
        [Validation(Required=false)]
        public string CostDetail { get; set; }

        [NameInMap("DeviceCode")]
        [Validation(Required=false)]
        public string DeviceCode { get; set; }

        [NameInMap("DeviceType")]
        [Validation(Required=false)]
        public string DeviceType { get; set; }

        [NameInMap("HolderId")]
        [Validation(Required=false)]
        public string HolderId { get; set; }

        [NameInMap("OuterCode")]
        [Validation(Required=false)]
        public string OuterCode { get; set; }

        [NameInMap("Phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        [NameInMap("ProxyUserId")]
        [Validation(Required=false)]
        public string ProxyUserId { get; set; }

        [NameInMap("QueryStr")]
        [Validation(Required=false)]
        public string QueryStr { get; set; }

        [NameInMap("RealCostAmount")]
        [Validation(Required=false)]
        public string RealCostAmount { get; set; }

        [NameInMap("SalePrice")]
        [Validation(Required=false)]
        public int? SalePrice { get; set; }

        [NameInMap("Sex")]
        [Validation(Required=false)]
        public string Sex { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        [NameInMap("TradeTimeStr")]
        [Validation(Required=false)]
        public string TradeTimeStr { get; set; }

        [NameInMap("V")]
        [Validation(Required=false)]
        public string V { get; set; }

    }

}
