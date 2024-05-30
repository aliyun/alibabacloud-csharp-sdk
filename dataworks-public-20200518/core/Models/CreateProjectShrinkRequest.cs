// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateProjectShrinkRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. We recommend that you set this parameter to a UUID.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to disable the Development role. Valid values:
        /// 
        /// *   false: enables the Development role.
        /// *   true: disables the Development role.
        /// *   Default value: false.
        /// </summary>
        [NameInMap("DisableDevelopment")]
        [Validation(Required=false)]
        public bool? DisableDevelopment { get; set; }

        /// <summary>
        /// Specifies whether query result download from DataStudio is allowed. Valid values:
        /// 
        /// *   1: allowed
        /// *   0: not allowed
        /// *   Default value: 1.
        /// </summary>
        [NameInMap("IsAllowDownload")]
        [Validation(Required=false)]
        public int? IsAllowDownload { get; set; }

        /// <summary>
        /// The description of the workspace.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectDescription")]
        [Validation(Required=false)]
        public string ProjectDescription { get; set; }

        /// <summary>
        /// The name of the workspace. The name can contain letters, digits, and underscores (_) and must start with a letter or digit.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectIdentifier")]
        [Validation(Required=false)]
        public string ProjectIdentifier { get; set; }

        /// <summary>
        /// The mode of the workspace. For more information about the differences between the modes of workspaces, see [Differences between workspaces in basic mode and workspaces in standard mode](https://help.aliyun.com/document_detail/85772.html). Valid values:
        /// 
        /// *   2: basic mode
        /// *   3: standard mode
        /// *   Default value: 2.
        /// </summary>
        [NameInMap("ProjectMode")]
        [Validation(Required=false)]
        public int? ProjectMode { get; set; }

        /// <summary>
        /// The display name of the workspace.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// The resource group ID.
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

    }

}
