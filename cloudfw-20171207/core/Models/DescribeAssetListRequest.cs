// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAssetListRequest : TeaModel {
        /// <summary>
        /// The page number. Valid values: 1 to 50.
        /// 
        /// This parameter is required.
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
        /// The UID of the member that is added to Cloud Firewall.
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public long? MemberUid { get; set; }

        /// <summary>
        /// The time when the asset was added. Valid values:
        /// 
        /// *   **discovered in 1 hour**: within one hour.
        /// *   **discovered in 1 day**: within one day.
        /// *   **discovered in 7 days**: within seven days.
        /// </summary>
        [NameInMap("NewResourceTag")]
        [Validation(Required=false)]
        public string NewResourceTag { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values: 1 to 50.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The region ID of your Cloud Firewall.
        /// 
        /// > For more information about the regions, see [Supported regions](https://help.aliyun.com/document_detail/195657.html).
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
        /// *   **NatEIP**: the EIP of a NAT gateway
        /// *   **SlbEIP**: the EIP of a Server Load Balancer (SLB) instance or a Classic Load Balancer (CLB) instance
        /// *   **SlbPublicIP**: the public IP address of an SLB instance or a CLB instance
        /// *   **NatPublicIP**: the public IP address of a NAT gateway
        /// *   **HAVIP**: the high-availability virtual IP address (HAVIP)
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The instance ID or IP address of the asset.
        /// </summary>
        [NameInMap("SearchItem")]
        [Validation(Required=false)]
        public string SearchItem { get; set; }

        /// <summary>
        /// The status of the security group policy. Valid values:
        /// 
        /// *   **pass**: delivered
        /// *   **block**: undelivered
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
        /// > If you do not specify this parameter, the assets that are configured for firewalls in all states are queried.
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
        /// *   **free**: Free Edition
        /// </summary>
        [NameInMap("UserType")]
        [Validation(Required=false)]
        public string UserType { get; set; }

    }

}
