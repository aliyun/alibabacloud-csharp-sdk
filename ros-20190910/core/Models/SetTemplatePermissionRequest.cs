// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class SetTemplatePermissionRequest : TeaModel {
        /// <summary>
        /// The Alibaba Cloud accounts with or from which you want to share or unshare the template.\\
        /// Valid values of N: 1, 2, 3, 4, and 5.
        /// 
        /// > - This parameter cannot be set to the ID of the Alibaba Cloud account that owns the template, or the RAM users of this Alibaba Cloud account.
        /// > - When ShareOption is set to CancelSharing, you can unshare the template from all the specified Alibaba Cloud accounts by using an asterisk (\\*).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AccountIds")]
        [Validation(Required=false)]
        public List<string> AccountIds { get; set; }

        /// <summary>
        /// The sharing option.
        /// 
        /// Valid values:
        /// 
        /// *   ShareToAccounts: shares the template with other Alibaba Cloud accounts.
        /// *   CancelSharing: unshares the template.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ShareOption")]
        [Validation(Required=false)]
        public string ShareOption { get; set; }

        /// <summary>
        /// The ID of the template.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// The version of the shared template. This parameter takes effect only if you set ShareOption to ShareToAccounts and set VersionOption to Specified.
        /// 
        /// Valid values: v1 to v100.
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

        /// <summary>
        /// The version option for the shared template. This parameter takes effect only if you set ShareOption to ShareToAccounts.
        /// 
        /// Valid values:
        /// 
        /// *   AllVersions (default): shares all versions of the template.
        /// *   Latest: shares only the latest version of template. When the version of the template is updated, ROS updates the shared version to the latest version.
        /// *   Current: shares only the current version of the template. When the version of the template is updated, ROS does not update the shared version.
        /// *   Specified: shares only the specified version of the template.
        /// </summary>
        [NameInMap("VersionOption")]
        [Validation(Required=false)]
        public string VersionOption { get; set; }

    }

}
