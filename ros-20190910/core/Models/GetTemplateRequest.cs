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
        /// >  You must specify only one of the following parameters: StackId, ChangeSetId, StackGroupName, and TemplateId.
        /// </summary>
        [NameInMap("ChangeSetId")]
        [Validation(Required=false)]
        public string ChangeSetId { get; set; }

        /// <summary>
        /// Specifies whether to query the template sharing information. Default value: Disabled. Valid values:
        /// 
        /// *   Enabled
        /// *   Disabled
        /// 
        /// >  Only the template owner can query the template sharing information.
        /// </summary>
        [NameInMap("IncludePermission")]
        [Validation(Required=false)]
        public string IncludePermission { get; set; }

        /// <summary>
        /// Specifies whether to query the information about tags. Default value: Disabled. Valid values:
        /// 
        /// *   Enabled
        /// *   Disabled
        /// 
        /// >  This parameter only takes effect when you specify the TemplateId parameter.
        /// </summary>
        [NameInMap("IncludeTags")]
        [Validation(Required=false)]
        public string IncludeTags { get; set; }

        /// <summary>
        /// The ID of the region to which the stack or stack group defined in the template belongs. You can call the [DescribeRegions](~~131035~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The name of the stack group.
        /// 
        /// >  You must specify only one of the following parameters: StackId, ChangeSetId, StackGroupName, and TemplateId.
        /// </summary>
        [NameInMap("StackGroupName")]
        [Validation(Required=false)]
        public string StackGroupName { get; set; }

        /// <summary>
        /// The ID of the stack.
        /// 
        /// >  You must specify only one of the following parameters: StackId, ChangeSetId, StackGroupName, and TemplateId.
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

        /// <summary>
        /// The ID of the template.
        /// 
        /// This parameter applies to shared and private templates. If the template is a shared template, the value of the TemplateId parameter is the same as the value of the TemplateARN parameter. You can use the template ID to query a shared template.
        /// 
        /// >  You must specify only one of the following parameters: StackId, ChangeSetId, StackGroupName, and TemplateId.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// The stage of the template. This parameter only takes effect when you specify the StackId, ChangeSetId, or StackGroupName parameter.
        /// 
        /// Default value: Processed. Valid values:
        /// 
        /// *   Processed: returns the processed template that contains transforms.
        /// *   Original: returns the original template that you specify.
        /// </summary>
        [NameInMap("TemplateStage")]
        [Validation(Required=false)]
        public string TemplateStage { get; set; }

        /// <summary>
        /// The version of the template. This parameter only takes effect when you specify the TemplateId parameter.
        /// 
        /// If the template is a shared template, you can specify this parameter only if you set the VersionOption parameter to AllVersions.
        /// 
        /// Valid values: v1 to v100.
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

    }

}
