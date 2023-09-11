// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class CreateLoadBalancerResponseBody : TeaModel {
        /// <summary>
        /// The ID of the NLB instance.
        /// </summary>
        [NameInMap("LoadbalancerId")]
        [Validation(Required=false)]
        public string LoadbalancerId { get; set; }

        /// <summary>
        /// The ID of the order for the NLB instance.
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
