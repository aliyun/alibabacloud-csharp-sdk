// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class SetLoadBalancerStatusRequest : TeaModel {
        /// <summary>
        /// The ID of the ELB instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// The status of the ELB instance. Valid values:
        /// 
        /// *   **Active** (default): The listener for the instance can forward the received traffic based on the rule.
        /// *   **InActive**: The listener for the instance does not forward the received traffic.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("LoadBalancerStatus")]
        [Validation(Required=false)]
        public string LoadBalancerStatus { get; set; }

    }

}
