// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class CreateOrderResponseBody : TeaModel {
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public CreateOrderResponseBodyInstanceIds InstanceIds { get; set; }
        public class CreateOrderResponseBodyInstanceIds : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public List<string> InstanceId { get; set; }

        }

        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
