// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateLoadBalancerRequest : TeaModel {
        /// <summary>
        /// The ID of the Edge Node Service (ENS) node.
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// The name of the ELB instance. The name must be 1 to 80 characters in length. If you leave this parameter empty, the system randomly allocates a name as the value of this parameter.
        /// 
        /// >  The value cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("LoadBalancerName")]
        [Validation(Required=false)]
        public string LoadBalancerName { get; set; }

        /// <summary>
        /// The specification of the ELB instance.
        /// </summary>
        [NameInMap("LoadBalancerSpec")]
        [Validation(Required=false)]
        public string LoadBalancerSpec { get; set; }

        /// <summary>
        /// The network ID of the created ELB instance.
        /// </summary>
        [NameInMap("NetworkId")]
        [Validation(Required=false)]
        public string NetworkId { get; set; }

        /// <summary>
        /// The billing method of the instance. Valid value: PostPaid. PostPaid specifies the pay-as-you-go billing method.
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// The ID of the vSwitch to which the internal-facing ELB instance belongs.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
