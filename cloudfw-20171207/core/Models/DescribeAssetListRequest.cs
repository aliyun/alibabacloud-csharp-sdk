// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAssetListRequest : TeaModel {
        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// The IP version of the asset that is protected by Cloud Firewall. Valid values:
        /// 
        /// *   **4**: IPv4 (default)
        /// *   **6**: IPv6
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        /// <summary>
        /// The language of the content within the response. Valid values:
        /// 
        /// *   **zh**: Chinese (default)
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The UID of the member that is added in Cloud Firewall.
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public long? MemberUid { get; set; }

        [NameInMap("NewResourceTag")]
        [Validation(Required=false)]
        public string NewResourceTag { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The ID of the region in which Cloud Firewall is supported.
        /// 
        /// >  For more information about the regions in which Cloud Firewall is supported, see [Supported regions](~~195657~~).
        /// </summary>
        [NameInMap("RegionNo")]
        [Validation(Required=false)]
        public string RegionNo { get; set; }

        /// <summary>
        /// The type of the asset. Valid values:
        /// 
        /// *   **BastionHostEgressIP**: the egress IP address of a bastion host
        /// *   **BastionHostIngressIP**: the ingress IP address of a bastion host
        /// *   **EcsEIP**: the elastic IP address (EIP) of an Elastic Compute Service (ECS) instance
        /// *   **EcsPublicIP**: the public IP address of an ECS instance
        /// *   **EIP**: the EIP
        /// *   **EniEIP**: the EIP of an elastic network interface (ENI)
        /// *   **NatEIP**: the EIP of a Network Address Translation (NAT) gateway
        /// *   **SlbEIP**: the EIP of a Server Load Balancer (SLB) instance
        /// *   **SlbPublicIP**: the public IP address of an SLB instance
        /// *   **NatPublicIP**: the public IP address of a NAT gateway
        /// *   **HAVIP**: the high-availability virtual IP address (HAVIP)
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The instance ID or the IP address of the asset.
        /// </summary>
        [NameInMap("SearchItem")]
        [Validation(Required=false)]
        public string SearchItem { get; set; }

        /// <summary>
        /// The status of the security group policy. Valid values:
        /// 
        /// *   **pass**: delivered
        /// 
        /// *   **block**: undelivered
        /// 
        /// *   **unsupport**: unsupported
        /// 
        /// > If you do not specify this parameter, the assets on which security group policies in all states take effect are queried.
        /// </summary>
        [NameInMap("SgStatus")]
        [Validation(Required=false)]
        public string SgStatus { get; set; }

        /// <summary>
        /// The status of the firewall. Valid values:
        /// 
        /// *   **open**: The firewall is enabled.
        /// *   **opening**: The firewall is being enabled.
        /// *   **closed**: The firewall is disabled.
        /// *   **closing**: The firewall is being disabled.
        /// 
        /// >  If you do not specify this parameter, the assets that are configured for firewalls in all states are queried.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// This parameter is deprecated.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The edition of Cloud Firewall. Valid values:
        /// 
        /// *   **buy**: a paid edition (default)
        /// *   **free**: a free edition
        /// </summary>
        [NameInMap("UserType")]
        [Validation(Required=false)]
        public string UserType { get; set; }

    }

}
