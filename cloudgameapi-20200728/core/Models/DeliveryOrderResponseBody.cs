// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class DeliveryOrderResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DeliveryOrderResponseBodyData Data { get; set; }
        public class DeliveryOrderResponseBodyData : TeaModel {
            [NameInMap("DeliveryStatus")]
            [Validation(Required=false)]
            public string DeliveryStatus { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
