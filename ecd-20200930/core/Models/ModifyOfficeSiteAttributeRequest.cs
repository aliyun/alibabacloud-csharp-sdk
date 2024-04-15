// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyOfficeSiteAttributeRequest : TeaModel {
        /// <summary>
        /// The method to connect to cloud computers from WUYING clients.
        /// 
        /// >  VPC connection relies on the Alibaba Cloud PrivateLink service. You can use PrivateLink for free. When you set this parameter to `VPC` or `Any`, the system automatically activates PrivateLink.
        /// 
        /// Valid values:
        /// 
        /// *   INTERNET (default): allows end users to connect to cloud computers over the Internet.
        /// *   VPC: allows end users to connect to cloud computers over VPCs.
        /// *   ANY: allows end users to connect to cloud computers over the Internet and VPCs. When end users connect to cloud computers from WUYING clients, you can choose a connection method based on your business requirements.
        /// </summary>
        [NameInMap("DesktopAccessType")]
        [Validation(Required=false)]
        public string DesktopAccessType { get; set; }

        /// <summary>
        /// Specifies whether to grant the local administrator permissions to users that are authorized to use cloud computers in the office network.
        /// 
        /// Valid values:
        /// 
        /// * true (default)
        /// * false
        /// </summary>
        [NameInMap("EnableAdminAccess")]
        [Validation(Required=false)]
        public bool? EnableAdminAccess { get; set; }

        /// <summary>
        /// Specifies whether to enable two-factor verification when an end user logs on to a WUYING client. This parameter is required only for convenience office networks. If two-factor verification is enabled, the system checks whether security risks exist within the logon account when the end user uses a convenience user to log on to the client. If risks are detected, the system sends a verification code to the email address that is associated with the account of the convenience user. Then, the end user can log on to the client only when the verification code is correct.
        /// </summary>
        [NameInMap("NeedVerifyLoginRisk")]
        [Validation(Required=false)]
        public bool? NeedVerifyLoginRisk { get; set; }

        /// <summary>
        /// Specifies whether to enable device verification. This parameter is required only for convenience office networks. This parameter is left empty for enterprise Active Directory (AD) office networks.
        /// </summary>
        [NameInMap("NeedVerifyZeroDevice")]
        [Validation(Required=false)]
        public bool? NeedVerifyZeroDevice { get; set; }

        /// <summary>
        /// The office network ID.
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// The office network name. The name must be 2 to 255 characters in length. It can contain letters, digits, colons (:), underscores (\_), periods (.), and hyphens (-). It must start with a letter and cannot start with `http://` or `https://`.\
        /// This parameter is empty by default.
        /// </summary>
        [NameInMap("OfficeSiteName")]
        [Validation(Required=false)]
        public string OfficeSiteName { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](~~196646~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
