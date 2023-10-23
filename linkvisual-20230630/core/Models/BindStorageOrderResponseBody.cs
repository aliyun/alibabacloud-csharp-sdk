// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20230630.Models
{
    public class BindStorageOrderResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public BindStorageOrderResponseBodyData Data { get; set; }
        public class BindStorageOrderResponseBodyData : TeaModel {
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            [NameInMap("Copies")]
            [Validation(Required=false)]
            public int? Copies { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("EndTimeUTC")]
            [Validation(Required=false)]
            public string EndTimeUTC { get; set; }

            [NameInMap("IdentityId")]
            [Validation(Required=false)]
            public string IdentityId { get; set; }

            [NameInMap("IotId")]
            [Validation(Required=false)]
            public string IotId { get; set; }

            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            [NameInMap("OrderType")]
            [Validation(Required=false)]
            public int? OrderType { get; set; }

            [NameInMap("OutOrderNo")]
            [Validation(Required=false)]
            public string OutOrderNo { get; set; }

            [NameInMap("PaymentStatus")]
            [Validation(Required=false)]
            public int? PaymentStatus { get; set; }

            [NameInMap("PreConsume")]
            [Validation(Required=false)]
            public int? PreConsume { get; set; }

            [NameInMap("Price")]
            [Validation(Required=false)]
            public string Price { get; set; }

            [NameInMap("RecordType")]
            [Validation(Required=false)]
            public int? RecordType { get; set; }

            [NameInMap("Specification")]
            [Validation(Required=false)]
            public string Specification { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("StartTimeUTC")]
            [Validation(Required=false)]
            public string StartTimeUTC { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
