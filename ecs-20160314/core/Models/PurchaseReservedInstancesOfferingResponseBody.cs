// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class PurchaseReservedInstancesOfferingResponseBody : TeaModel {
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ReservedInstanceIdSets")]
        [Validation(Required=false)]
        public PurchaseReservedInstancesOfferingResponseBodyReservedInstanceIdSets ReservedInstanceIdSets { get; set; }
        public class PurchaseReservedInstancesOfferingResponseBodyReservedInstanceIdSets : TeaModel {
            [NameInMap("ReservedInstanceId")]
            [Validation(Required=false)]
            public List<string> ReservedInstanceId { get; set; }

        }

    }

}
