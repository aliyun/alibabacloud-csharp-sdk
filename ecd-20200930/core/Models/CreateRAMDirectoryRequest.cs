// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateRAMDirectoryRequest : TeaModel {
        /// <summary>
        /// The method to connect clients to cloud desktops.
        /// 
        /// Valid values:
        /// 
        /// *   VPC: connects to cloud desktops over VPCs.
        /// *   Internet (default): connects to the cloud desktops over the Internet.
        /// *   Any: connects to the cloud desktops over the Internet or VPCs.
        /// </summary>
        [NameInMap("DesktopAccessType")]
        [Validation(Required=false)]
        public string DesktopAccessType { get; set; }

        /// <summary>
        /// The directory name. The name must be 2 to 255 characters in length, and can contain letters, digits, colons (:), underscores (\_), and hyphens (-). It must start with a letter but cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("DirectoryName")]
        [Validation(Required=false)]
        public string DirectoryName { get; set; }

        /// <summary>
        /// Specifies whether to grant the permissions of the local administrator to end users of the cloud desktops that belong to the workspace.
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
        /// Specifies whether to enable Internet access.
        /// 
        /// Valid values:
        /// 
        /// *   true
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   false
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("EnableInternetAccess")]
        [Validation(Required=false)]
        public bool? EnableInternetAccess { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](~~196646~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The vSwitch IDs. You can configure only one vSwitch.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public List<string> VSwitchId { get; set; }

    }

}
