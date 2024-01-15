// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateADConnectorOfficeSiteRequest : TeaModel {
        /// <summary>
        /// The hostname of the domain controller. The hostname must comply with the naming conventions for Windows hosts.
        /// </summary>
        [NameInMap("AdHostname")]
        [Validation(Required=false)]
        public string AdHostname { get; set; }

        /// <summary>
        /// The maximum public bandwidth of the Internet access package. Valid values: 0 to 200.\
        /// If you do not specify this parameter or you set this parameter to 0, Internet access is disabled.
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// The ID of the CEN instance.
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account to which the Cloud Enterprise Network (CEN) instance belongs.
        /// 
        /// *   If you do not specify CenId or the CEN instance that is specified by CenId belongs to the current Alibaba Cloud account, leave this parameter empty.
        /// *   If you specify CenId and the CEN instance that is specified by CenId belongs to another Alibaba Cloud account, enter the ID of the Alibaba Cloud account.
        /// </summary>
        [NameInMap("CenOwnerId")]
        [Validation(Required=false)]
        public long? CenOwnerId { get; set; }

        /// <summary>
        /// The IPv4 CIDR block in the secure office network of the workspace. The IPv4 CIDR block that the system uses to create a virtual private cloud (VPC) for the workspace. We recommend that you set the IPv4 CIDR block to 10.0.0.0/12, 172.16.0.0/12, 192.168.0.0/16, or a subnet of these CIDR blocks. If you set the IPv4 CIDR block to 10.0.0.0/12 or 172.16.0.0/12, the mask is 1224 bits in length. If you set the IPv4 CIDR block to 192.168.0.0/16, the mask is 1624 bits in length.
        /// </summary>
        [NameInMap("CidrBlock")]
        [Validation(Required=false)]
        public string CidrBlock { get; set; }

        /// <summary>
        /// The connection method that is used to connect clients to cloud desktops. Valid values:
        /// 
        /// *   Internet: connects clients to cloud desktops only over the Internet.
        /// *   VPC: connects clients to cloud desktops only over a VPC.
        /// *   Any: connects clients to cloud desktops over the Internet or a VPC. You can select a connection method based on your business requirements when you connect to your cloud desktop from a client.
        /// 
        /// Default value: Internet
        /// 
        /// > VPC connections are established by using Alibaba Cloud PrivateLink. You can use PrivateLink free of charge. If you set this parameter to VPC or Any, PrivateLink is automatically activated.
        /// </summary>
        [NameInMap("DesktopAccessType")]
        [Validation(Required=false)]
        public string DesktopAccessType { get; set; }

        /// <summary>
        /// The IP address of the DNS server of the enterprise AD system. You can specify only one IP address.
        /// </summary>
        [NameInMap("DnsAddress")]
        [Validation(Required=false)]
        public List<string> DnsAddress { get; set; }

        /// <summary>
        /// The domain name of the enterprise AD system. You can register each domain name only once.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The password of the domain administrator. The password can be up to 64 characters in length.
        /// </summary>
        [NameInMap("DomainPassword")]
        [Validation(Required=false)]
        public string DomainPassword { get; set; }

        /// <summary>
        /// The username of the domain administrator. The username can be up to 64 characters in length.
        /// 
        /// > Specify the username by using sAMAccountName instead of userPrincipalName.
        /// </summary>
        [NameInMap("DomainUserName")]
        [Validation(Required=false)]
        public string DomainUserName { get; set; }

        /// <summary>
        /// Specifies whether to grant the permissions of the local administrator to end users of the cloud desktops that belong to the workspace. Default value: `true`
        /// </summary>
        [NameInMap("EnableAdminAccess")]
        [Validation(Required=false)]
        public bool? EnableAdminAccess { get; set; }

        /// <summary>
        /// Specifies whether to enable Internet access.
        /// </summary>
        [NameInMap("EnableInternetAccess")]
        [Validation(Required=false)]
        public bool? EnableInternetAccess { get; set; }

        /// <summary>
        /// Specifies whether to enable multi-factor authentication (MFA).
        /// </summary>
        [NameInMap("MfaEnabled")]
        [Validation(Required=false)]
        public bool? MfaEnabled { get; set; }

        /// <summary>
        /// The name of the workspace. The name must be 2 to 255 characters in length. The name must start with a letter but cannot start with `http://` or `https://`. The name can contain letters, digits, colons (:), underscores (\_), and hyphens (-).\
        /// Default value: null
        /// </summary>
        [NameInMap("OfficeSiteName")]
        [Validation(Required=false)]
        public string OfficeSiteName { get; set; }

        /// <summary>
        /// The type of the protocol. Set the value to ASP.
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// The region ID of the workspace.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The type of the AD connector.
        /// 
        /// *   1: General
        /// *   2: Advanced
        /// </summary>
        [NameInMap("Specification")]
        [Validation(Required=false)]
        public long? Specification { get; set; }

        /// <summary>
        /// The DNS address of the enterprise AD subdomain. If you specify `SubDomainName` but do not specify this parameter, the DNS address of the subdomain is the same as the DNS address of the parent domain.
        /// </summary>
        [NameInMap("SubDomainDnsAddress")]
        [Validation(Required=false)]
        public List<string> SubDomainDnsAddress { get; set; }

        /// <summary>
        /// The domain name of the enterprise AD subdomain.
        /// </summary>
        [NameInMap("SubDomainName")]
        [Validation(Required=false)]
        public string SubDomainName { get; set; }

        /// <summary>
        /// The verification code. If the CEN instance that is specified by CenId belongs to another Alibaba Cloud account, you must call the SendVerifyCode operation to obtain the verification code.
        /// </summary>
        [NameInMap("VerifyCode")]
        [Validation(Required=false)]
        public string VerifyCode { get; set; }

    }

}
