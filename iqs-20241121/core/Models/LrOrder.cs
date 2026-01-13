// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241121.Models
{
    public class LrOrder : TeaModel {
        [NameInMap("accountCredentials")]
        [Validation(Required=false)]
        public List<AccountCredentialDTO> AccountCredentials { get; set; }

        [NameInMap("aliUid")]
        [Validation(Required=false)]
        public string AliUid { get; set; }

        [NameInMap("commodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        [NameInMap("commodityId")]
        [Validation(Required=false)]
        public string CommodityId { get; set; }

        [NameInMap("commoditySpec")]
        [Validation(Required=false)]
        public string CommoditySpec { get; set; }

        [NameInMap("customerName")]
        [Validation(Required=false)]
        public string CustomerName { get; set; }

        [NameInMap("eventTime")]
        [Validation(Required=false)]
        public string EventTime { get; set; }

        [NameInMap("expirationTime")]
        [Validation(Required=false)]
        public string ExpirationTime { get; set; }

        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("orderCategory")]
        [Validation(Required=false)]
        public string OrderCategory { get; set; }

        [NameInMap("orderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        [NameInMap("qps")]
        [Validation(Required=false)]
        public int? Qps { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
