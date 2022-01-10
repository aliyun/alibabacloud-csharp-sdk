// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.UniMkt20181212.Models
{
    public class SyncUnionOrderRequest : TeaModel {
        [NameInMap("Age")]
        [Validation(Required=false)]
        public int? Age { get; set; }

        [NameInMap("ApplyPrice")]
        [Validation(Required=false)]
        public long? ApplyPrice { get; set; }

        [NameInMap("BizSerialNumber")]
        [Validation(Required=false)]
        public string BizSerialNumber { get; set; }

        [NameInMap("BrandName")]
        [Validation(Required=false)]
        public string BrandName { get; set; }

        [NameInMap("BrandUserId")]
        [Validation(Required=false)]
        public long? BrandUserId { get; set; }

        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        [NameInMap("ExtendInfo")]
        [Validation(Required=false)]
        public string ExtendInfo { get; set; }

        [NameInMap("HolderId")]
        [Validation(Required=false)]
        public string HolderId { get; set; }

        [NameInMap("IndustryLabelBagId")]
        [Validation(Required=false)]
        public int? IndustryLabelBagId { get; set; }

        [NameInMap("ProxyChannelId")]
        [Validation(Required=false)]
        public string ProxyChannelId { get; set; }

        [NameInMap("ProxyUserId")]
        [Validation(Required=false)]
        public long? ProxyUserId { get; set; }

        [NameInMap("RealCostAmount")]
        [Validation(Required=false)]
        public long? RealCostAmount { get; set; }

        [NameInMap("Sex")]
        [Validation(Required=false)]
        public string Sex { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("TaskBizType")]
        [Validation(Required=false)]
        public string TaskBizType { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        [NameInMap("TaskRuleType")]
        [Validation(Required=false)]
        public string TaskRuleType { get; set; }

        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        [NameInMap("TradeTimeString")]
        [Validation(Required=false)]
        public string TradeTimeString { get; set; }

        [NameInMap("V")]
        [Validation(Required=false)]
        public string V { get; set; }

    }

}
