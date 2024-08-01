// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class RunInstancesResponseBody : TeaModel {
        /// <summary>
        /// The IDs of the instances (`InstanceIdSet`).
        /// </summary>
        [NameInMap("InstanceIdSets")]
        [Validation(Required=false)]
        public RunInstancesResponseBodyInstanceIdSets InstanceIdSets { get; set; }
        public class RunInstancesResponseBodyInstanceIdSets : TeaModel {
            [NameInMap("InstanceIdSet")]
            [Validation(Required=false)]
            public List<string> InstanceIdSet { get; set; }

        }

        /// <summary>
        /// The ID of the order. This parameter is returned only when `InstanceChargeType` is set to PrePaid.
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The transaction price.
        /// </summary>
        [NameInMap("TradePrice")]
        [Validation(Required=false)]
        public float? TradePrice { get; set; }

    }

}
