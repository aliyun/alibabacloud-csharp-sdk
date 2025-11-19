// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wuying_personal_pc20251111.Models
{
    public class CreateOrderResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateOrderResponseBodyData Data { get; set; }
        public class CreateOrderResponseBodyData : TeaModel {
            [NameInMap("OrderDetailList")]
            [Validation(Required=false)]
            public List<CreateOrderResponseBodyDataOrderDetailList> OrderDetailList { get; set; }
            public class CreateOrderResponseBodyDataOrderDetailList : TeaModel {
                [NameInMap("InstanceIds")]
                [Validation(Required=false)]
                public List<string> InstanceIds { get; set; }

                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public long? OrderId { get; set; }

            }

            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            [NameInMap("PayLink")]
            [Validation(Required=false)]
            public string PayLink { get; set; }

            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
