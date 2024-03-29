// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateADConnectorDirectoryRequest : TeaModel {
        /// <summary>
        /// The method that is used to connect the client to cloud desktops.
        /// 
        /// Valid values:
        /// - VPC (Only connect through VPC)
        /// - Internet (Only connect through the Internet [Default])
        /// - Any (Both VPC and Internet are supported)
        /// </summary>
        [NameInMap("DesktopAccessType")]
        [Validation(Required=false)]
        public string DesktopAccessType { get; set; }

        /// <summary>
        /// The directory name. The name must be 2 to 255 characters in length, and can contain letters, digits, colons (:), underscores (\_), and hyphens (-). It must start with a letter and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("DirectoryName")]
        [Validation(Required=false)]
        public string DirectoryName { get; set; }

        /// <summary>
        /// Details of the IP addresses of the Domain Name System (DNS) servers of the enterprise AD system. You can specify only one IP address. Make sure that the specified IP address is accessible in the network of the selected vSwitch.
        /// </summary>
        [NameInMap("DnsAddress")]
        [Validation(Required=false)]
        public List<string> DnsAddress { get; set; }

        /// <summary>
        /// The fully qualified domain name (FQDN) of the enterprise AD system. The value must contain the hostname and the domain name. You can register each FQDN only once.
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
        /// </summary>
        [NameInMap("DomainUserName")]
        [Validation(Required=false)]
        public string DomainUserName { get; set; }

        /// <summary>
        /// Specifies whether to grant the permissions of the local administrator to the regular user of the cloud desktop.
        /// 
        /// Valid values:
        /// - true (To grant the local administrator permission [Default])
        /// - false (Not to grant the local administrator permission)
        /// </summary>
        [NameInMap("EnableAdminAccess")]
        [Validation(Required=false)]
        public bool? EnableAdminAccess { get; set; }

        /// <summary>
        /// Specifies whether to enable multi-factor authentication (MFA). If you enable MFA, all AD users in the AD directory must enter the password and the dynamic verification code generated by the MFA device when they log on to a cloud desktop.
        /// 
        /// >  The first time you log on to the Elastic Desktop Service (EDS) client as a regular user, you must bind an MFA device.
        /// 
        /// Valid values:
        /// - true (To enable MFA)
        /// - false (To disable MFA [Default])
        /// </summary>
        [NameInMap("MfaEnabled")]
        [Validation(Required=false)]
        public bool? MfaEnabled { get; set; }

        /// <summary>
        /// The ID of the region. You can call the [DescribeRegions](~~196646~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The type of the AD connector.
        /// 
        /// Valid values:
        /// - 1 (General)
        /// - 2 (Advanced)
        /// </summary>
        [NameInMap("Specification")]
        [Validation(Required=false)]
        public long? Specification { get; set; }

        /// <summary>
        /// The DNS address of the enterprise AD subdomain.\
        /// If you specify the `SubDomainName` parameter but you do not specify this parameter, the DNS address of the subdomain is the same as the DNS address of the parent domain.
        /// </summary>
        [NameInMap("SubDomainDnsAddress")]
        [Validation(Required=false)]
        public List<string> SubDomainDnsAddress { get; set; }

        /// <summary>
        /// The FQDN of the enterprise AD subdomain. The value must contain the hostname and the subdomain name.
        /// </summary>
        [NameInMap("SubDomainName")]
        [Validation(Required=false)]
        public string SubDomainName { get; set; }

        /// <summary>
        /// Details of the vSwitch IDs. You can specify only one vSwitch ID.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public List<string> VSwitchId { get; set; }

    }

}
