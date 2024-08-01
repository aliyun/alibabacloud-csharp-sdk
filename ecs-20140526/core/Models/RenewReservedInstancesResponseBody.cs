// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class RenewReservedInstancesResponseBody : TeaModel {
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// The IDs of the reserved instances.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the reserved instance.
        /// </summary>
        [NameInMap("ReservedInstanceIdSets")]
        [Validation(Required=false)]
        public RenewReservedInstancesResponseBodyReservedInstanceIdSets ReservedInstanceIdSets { get; set; }
        public class RenewReservedInstancesResponseBodyReservedInstanceIdSets : TeaModel {
            [NameInMap("ReservedInstanceId")]
            [Validation(Required=false)]
            public List<string> ReservedInstanceId { get; set; }

        }

    }

}
