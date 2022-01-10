// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.UniMkt20181212.Models
{
    public class SaveCpmTradeRequest : TeaModel {
        [NameInMap("AdvertType")]
        [Validation(Required=false)]
        public string AdvertType { get; set; }

        [NameInMap("Age")]
        [Validation(Required=false)]
        public int? Age { get; set; }

        [NameInMap("ApplyPrice")]
        [Validation(Required=false)]
        public string ApplyPrice { get; set; }

        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        [NameInMap("CostDetail")]
        [Validation(Required=false)]
        public string CostDetail { get; set; }

        [NameInMap("DeviceCode")]
        [Validation(Required=false)]
        public string DeviceCode { get; set; }

        [NameInMap("ExtendString")]
        [Validation(Required=false)]
        public string ExtendString { get; set; }

        [NameInMap("HoldId")]
        [Validation(Required=false)]
        public string HoldId { get; set; }

        [NameInMap("OuterCode")]
        [Validation(Required=false)]
        public string OuterCode { get; set; }

        [NameInMap("RealCostAmount")]
        [Validation(Required=false)]
        public string RealCostAmount { get; set; }

        [NameInMap("Sex")]
        [Validation(Required=false)]
        public string Sex { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("TaskTag")]
        [Validation(Required=false)]
        public string TaskTag { get; set; }

        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        [NameInMap("TradeTime")]
        [Validation(Required=false)]
        public long? TradeTime { get; set; }

        [NameInMap("V")]
        [Validation(Required=false)]
        public string V { get; set; }

    }

}
