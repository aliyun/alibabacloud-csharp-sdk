// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class PutEnableFwSwitchRequest : TeaModel {
        /// <summary>
        /// The IP addresses.
        /// 
        /// > You must specify at least one of the IpaddrList, RegionList, and ResourceTypeList parameters.
        /// </summary>
        [NameInMap("IpaddrList")]
        [Validation(Required=false)]
        public List<string> IpaddrList { get; set; }

        /// <summary>
        /// The language of the content within the response.
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The regions.
        /// 
        /// > You must specify at least one of the IpaddrList, RegionList, and ResourceTypeList parameters.
        /// </summary>
        [NameInMap("RegionList")]
        [Validation(Required=false)]
        public List<string> RegionList { get; set; }

        /// <summary>
        /// The types of the assets.
        /// 
        /// Valid values:
        /// 
        /// *   BastionHostIP: the egress IP address of a bastion host
        /// *   BastionHostIngressIP: the ingress IP address of a bastion host
        /// *   EcsEIP: the elastic IP address (EIP) of an Elastic Compute Service (ECS) instance
        /// *   EcsPublicIP: the public IP address of an ECS instance
        /// *   EIP: the EIP
        /// *   EniEIP: the EIP of an elastic network interface (ENI)
        /// *   NatEIP: the EIP of a NAT gateway
        /// *   SlbEIP: the EIP of a Server Load Balancer (SLB) instance
        /// *   SlbPublicIP: the public IP address of an SLB instance
        /// *   NatPublicIP: the public IP address of a NAT gateway
        /// *   HAVIP: the high-availability virtual IP address (HAVIP)
        /// 
        /// > You must specify at least one of the IpaddrList, RegionList, and ResourceTypeList parameters.
        /// </summary>
        [NameInMap("ResourceTypeList")]
        [Validation(Required=false)]
        public List<string> ResourceTypeList { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourceIp { get; set; }

    }

}
