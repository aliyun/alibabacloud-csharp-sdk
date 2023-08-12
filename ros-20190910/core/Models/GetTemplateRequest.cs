// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetTemplateRequest : TeaModel {
        /// <summary>
        /// The ID of the change set.
        /// 
        /// > You must specify one of the following parameters: StackId, ChangeSetId, StackGroupName, and TemplateId.
        /// </summary>
        [NameInMap("ChangeSetId")]
        [Validation(Required=false)]
        public string ChangeSetId { get; set; }

        /// <summary>
        /// Specifies whether to query the shared information about the template. Valid values:
        /// 
        /// *   Enabled
        /// *   Disabled (default)
        /// 
        /// > Only the template owner can query the shared information of a template.
        /// </summary>
        [NameInMap("IncludePermission")]
        [Validation(Required=false)]
        public string IncludePermission { get; set; }

        /// <summary>
        /// Specifies whether to query the information about tags. Valid values:
        /// 
        /// *   Enabled
        /// *   Disabled (default)
        /// 
        /// > This parameter takes effect only if you specify TemplateId.
        /// </summary>
        [NameInMap("IncludeTags")]
        [Validation(Required=false)]
        public string IncludeTags { get; set; }

        /// <summary>
        /// The region ID of the stack or stack group that uses the template. You can call the [DescribeRegions](~~131035~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The name of the stack group.
        /// 
        /// > You must specify one of the following parameters: StackId, ChangeSetId, StackGroupName, and TemplateId.
        /// </summary>
        [NameInMap("StackGroupName")]
        [Validation(Required=false)]
        public string StackGroupName { get; set; }

        /// <summary>
        /// The ID of the stack.
        /// 
        /// > You must specify one of the following parameters: StackId, ChangeSetId, StackGroupName, and TemplateId.
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

        /// <summary>
        /// The ID of the template.
        /// 
        /// This parameter applies to shared and private templates. If the template is a shared template, the value of TemplateId is the same as the value of TemplateARN. You can use the template ID to query a shared template.
        /// 
        /// > You must specify one of the following parameters: StackId, ChangeSetId, StackGroupName, and TemplateId.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// The stage of the template. This parameter takes effect only if you specify StackId, ChangeSetId, or StackGroupName.
        /// 
        /// Valid values:
        /// 
        /// *   Processed (default): returns the processed template.
        /// *   Original: returns the original template.
        /// </summary>
        [NameInMap("TemplateStage")]
        [Validation(Required=false)]
        public string TemplateStage { get; set; }

        /// <summary>
        /// The version of the template. This parameter takes effect only if you specify TemplateId.\
        /// If the template is a shared template, you can specify this parameter only if VersionOption is set to AllVersions. For more information, see [SetTemplatePermission](~~194768~~).
        /// 
        /// Valid values: v1 to v100.
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

    }

}
