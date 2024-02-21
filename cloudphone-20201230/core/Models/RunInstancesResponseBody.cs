// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudphone20201230.Models
{
    public class RunInstancesResponseBody : TeaModel {
        /// <summary>
        /// The IDs of the ECP instances.
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public RunInstancesResponseBodyInstanceIds InstanceIds { get; set; }
        public class RunInstancesResponseBodyInstanceIds : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public List<string> InstanceId { get; set; }

        }

        /// <summary>
        /// The ID of the order.
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
        /// The price of the ECP resource.
        /// </summary>
        [NameInMap("TradePrice")]
        [Validation(Required=false)]
        public float? TradePrice { get; set; }

    }

}
