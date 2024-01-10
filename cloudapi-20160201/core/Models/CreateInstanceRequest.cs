// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160201.Models
{
    public class CreateInstanceRequest : TeaModel {
        [NameInMap("AccountQuantity")]
        [Validation(Required=false)]
        public long? AccountQuantity { get; set; }

        [NameInMap("AlarmQuota")]
        [Validation(Required=false)]
        public long? AlarmQuota { get; set; }

        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public long? AliUid { get; set; }

        [NameInMap("AppId")]
        [Validation(Required=false)]
        public long? AppId { get; set; }

        [NameInMap("BillingType")]
        [Validation(Required=false)]
        public string BillingType { get; set; }

        [NameInMap("CloudMarketInstanceId")]
        [Validation(Required=false)]
        public string CloudMarketInstanceId { get; set; }

        [NameInMap("ExpiredOn")]
        [Validation(Required=false)]
        public string ExpiredOn { get; set; }

        [NameInMap("InstanceAttributes")]
        [Validation(Required=false)]
        public string InstanceAttributes { get; set; }

        [NameInMap("SkuId")]
        [Validation(Required=false)]
        public string SkuId { get; set; }

        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
