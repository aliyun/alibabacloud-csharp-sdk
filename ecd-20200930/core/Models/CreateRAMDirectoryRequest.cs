// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateRAMDirectoryRequest : TeaModel {
        /// <summary>
        /// The method that you use to connect clients to cloud desktops. Valid values:
        /// 
        /// *   Internet: connects clients to cloud desktops only over the Internet.
        /// *   VPC: connects clients to cloud desktops only over a VPC.
        /// *   Any: connects clients to cloud desktops over the Internet or a VPC. You can select a connection method when you connect clients to cloud desktops.
        /// 
        /// Default value: Internet.
        /// 
        /// 
        /// > The VPC connection method is provided by Alibaba Cloud PrivateLink. You are not charged for PrivateLink. If you set this parameter to VPC or Any, PrivateLink is automatically activated.
        /// </summary>
        [NameInMap("DesktopAccessType")]
        [Validation(Required=false)]
        public string DesktopAccessType { get; set; }

        /// <summary>
        /// The name of the directory. The name must be 2 to 255 characters in length and can contain letters, digits, colons (:), underscores (\_), and hyphens (-). It must start with a letter and cannot start with `http://` or `https://`.
        /// 
        /// This parameter is empty by default.
        /// </summary>
        [NameInMap("DirectoryName")]
        [Validation(Required=false)]
        public string DirectoryName { get; set; }

        /// <summary>
        /// Specifies whether to grant the permissions of the local administrator to the desktop users.
        /// 
        /// Default value: true.
        /// </summary>
        [NameInMap("EnableAdminAccess")]
        [Validation(Required=false)]
        public bool? EnableAdminAccess { get; set; }

        /// <summary>
        /// Specifies whether to enable the Internet access feature.
        /// </summary>
        [NameInMap("EnableInternetAccess")]
        [Validation(Required=false)]
        public bool? EnableInternetAccess { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The IDs of vSwitches. You can configure only one vSwitch.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public List<string> VSwitchId { get; set; }

    }

}
