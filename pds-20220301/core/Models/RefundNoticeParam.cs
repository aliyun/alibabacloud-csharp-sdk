// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class RefundNoticeParam : TeaModel {
        [NameInMap("aliuid")]
        [Validation(Required=false)]
        public long? Aliuid { get; set; }

        [NameInMap("aliyunProduceCode")]
        [Validation(Required=false)]
        public string AliyunProduceCode { get; set; }

        [NameInMap("commodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("newExpireTime")]
        [Validation(Required=false)]
        public object NewExpireTime { get; set; }

        [NameInMap("orderIds")]
        [Validation(Required=false)]
        public List<long?> OrderIds { get; set; }

        [NameInMap("refundParamMap")]
        [Validation(Required=false)]
        public Dictionary<string, string> RefundParamMap { get; set; }

        [NameInMap("refundType")]
        [Validation(Required=false)]
        public string RefundType { get; set; }

    }

}
