// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class CreateOrderRequest : TeaModel {
        [NameInMap("auto_pay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        [NameInMap("auto_renew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("instance_id")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("order_type")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        [NameInMap("package")]
        [Validation(Required=false)]
        public string Package { get; set; }

        [NameInMap("period")]
        [Validation(Required=false)]
        public long? Period { get; set; }

        [NameInMap("period_unit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        [NameInMap("total_size")]
        [Validation(Required=false)]
        public long? TotalSize { get; set; }

        [NameInMap("user_count")]
        [Validation(Required=false)]
        public long? UserCount { get; set; }

    }

}
