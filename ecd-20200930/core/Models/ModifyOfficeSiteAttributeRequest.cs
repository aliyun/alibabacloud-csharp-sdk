// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyOfficeSiteAttributeRequest : TeaModel {
        /// <summary>
        /// The method that you want to use to connect the Alibaba Cloud Workspace client to cloud desktops. Valid values:
        /// 
        /// *   INTERNET: connects the client to cloud desktops only over the Internet.
        /// *   VPC: connects the client to cloud desktops only over a VPC.
        /// *   Any: connects clients to cloud desktops over the Internet or a VPC. You can select a connection method based on your business requirements when you connect to a cloud desktop from the client.
        /// 
        /// Default value: INTERNET.
        /// 
        /// > VPC connections are established by using Alibaba Cloud PrivateLink. You can use PrivateLink for free. When you set this parameter to VPC or Any, PrivateLink is automatically activated.
        /// </summary>
        [NameInMap("DesktopAccessType")]
        [Validation(Required=false)]
        public string DesktopAccessType { get; set; }

        /// <summary>
        /// Specifies whether to grant the local administrator permissions to end users.
        /// </summary>
        [NameInMap("EnableAdminAccess")]
        [Validation(Required=false)]
        public bool? EnableAdminAccess { get; set; }

        /// <summary>
        /// This parameter is only applicable to a workspace of the convenience account type, which indicates whether to require two-factor verification when you log on to the client. If two-factor verification is enabled, the system checks whether security risks exist within the logon account when a convenience user logs on to the client. If risks are detected, the system sends a verification code to the email address that is associated with the account. Then, the convenience user can log on to the client only after the verification code is correctly entered.
        /// </summary>
        [NameInMap("NeedVerifyLoginRisk")]
        [Validation(Required=false)]
        public bool? NeedVerifyLoginRisk { get; set; }

        /// <summary>
        /// This parameter is only applicable to a workspace of the convenience account type, which indicates whether to require device verification when you log on to the client. For a workspace of the enterprise Active Directory (AD) account type, the value of this parameter is empty.
        /// </summary>
        [NameInMap("NeedVerifyZeroDevice")]
        [Validation(Required=false)]
        public bool? NeedVerifyZeroDevice { get; set; }

        /// <summary>
        /// The ID of the workspace.
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// The name of the workspace. We recommend that you specify a name that is easy to identify. The name must be 2 to 255 characters in length. The name can contain letters, digits, colons (:), underscores (\_), and hyphens (-). It must start with a letter but cannot start with http:// or https://.
        /// </summary>
        [NameInMap("OfficeSiteName")]
        [Validation(Required=false)]
        public string OfficeSiteName { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
