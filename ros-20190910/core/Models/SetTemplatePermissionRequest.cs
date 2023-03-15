// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class SetTemplatePermissionRequest : TeaModel {
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
        /// </summary>
        [NameInMap("ShareOption")]
        [Validation(Required=false)]
        public string ShareOption { get; set; }

        /// <summary>
        /// The ID of the template.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// The version of the template that you want to share. This parameter takes effect when the ShareOption parameter is set to ShareToAccounts and the VersionOption parameter is set to Specified.
        /// 
        /// Valid values: v1 to v100.
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

        /// <summary>
        /// The version option for template sharing. This parameter takes effect when the ShareOption parameter is set to ShareToAccounts.
        /// 
        /// Default value: AllVersions. Valid values:
        /// 
        /// *   AllVersions: shares all versions of the template.
        /// *   Latest: shares only the latest version of the template. If the shared template is updated, the latest version of the template is shared with the destination account.
        /// *   Current: shares only the current version of the template. The current version of the template is shared with the destination account even if the template is updated.
        /// *   Specified: shares only one specific version of the template.
        /// </summary>
        [NameInMap("VersionOption")]
        [Validation(Required=false)]
        public string VersionOption { get; set; }

    }

}
