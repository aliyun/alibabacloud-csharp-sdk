// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetTemplateResponseBody : TeaModel {
        /// <summary>
        /// The ID of the change set. This parameter is returned only if you specify ChangeSetId.
        /// </summary>
        [NameInMap("ChangeSetId")]
        [Validation(Required=false)]
        public string ChangeSetId { get; set; }

        /// <summary>
        /// The time when the template was created. This parameter is returned only if you specify TemplateId.
        /// 
        /// > - If you specify TemplateVersion, the creation time of the template whose version is specified by TemplateVersion is returned.
        /// > - If you do not specify TemplateVersion, the creation time of the template whose version is the default version is returned.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The description of the template. This parameter is returned only if you specify TemplateId.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The description of the web UI in the ROS console.
        /// </summary>
        [NameInMap("Interface")]
        [Validation(Required=false)]
        public string Interface { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account to which the template belongs. This parameter is returned only if you specify TemplateId.
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Details of the sharing status of the template. This parameter is returned only if you specify TemplateId and set IncludePermission to Enabled.
        /// 
        /// > - If TemplateVersion is not specified or does not take effect, the details of the sharing status of the template whose version is the default version is returned.
        /// > - If TemplateVersion is specified and takes effect, the details of the sharing status of the template whose version is specified by TemplateVersion is returned.
        /// </summary>
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public List<GetTemplateResponseBodyPermissions> Permissions { get; set; }
        public class GetTemplateResponseBodyPermissions : TeaModel {
            /// <summary>
            /// The ID of the Alibaba Cloud account with which the template is shared.
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// The sharing option.
            /// 
            /// The value ShareToAccounts indicates that the template is shared with one or more Alibaba Cloud accounts.
            /// </summary>
            [NameInMap("ShareOption")]
            [Validation(Required=false)]
            public string ShareOption { get; set; }

            /// <summary>
            /// The service that is used for resource sharing. Valid values:
            /// 
            /// - ROS: Resources are shared from ROS by using the ROS console or calling the ROS API.
            /// - ResourceDirectory: Resources are shared with accounts in a resource directory from Resource Management by using the resource sharing feature.
            /// > -  The number of accounts with which resources are shared from ROS is independent of the number of accounts with which resources are shared from the resource directory.
            /// > -  The shared resources from ROS cannot override or overwrite the shared resources from the resource directory.
            /// > -  The shared resources from the resource directory can overwrite the shared resources from ROS.
            /// </summary>
            [NameInMap("ShareSource")]
            [Validation(Required=false)]
            public string ShareSource { get; set; }

            /// <summary>
            /// The version of the shared template. This parameter is returned only if you set ShareOption to ShareToAccounts and set VersionOption to Specified or Current.
            /// 
            /// Valid values: v1 to v100.
            /// </summary>
            [NameInMap("TemplateVersion")]
            [Validation(Required=false)]
            public string TemplateVersion { get; set; }

            /// <summary>
            /// The version option for the shared template. This parameter is returned only if you set ShareOption to ShareToAccounts.
            /// 
            /// Valid values:
            /// 
            /// *   AllVersions: All template versions are shared.
            /// *   Latest: Only the latest template version is shared. When the version of the template is updated, Resource Orchestration Service (ROS) updates the shared version to the latest version.
            /// *   Current: Only the latest template version is shared. When the version of the template is updated, ROS does not update the shared version.
            /// *   Specified: Only the specified template version is shared.
            /// </summary>
            [NameInMap("VersionOption")]
            [Validation(Required=false)]
            public string VersionOption { get; set; }

        }

        /// <summary>
        /// The region ID of the stack or stack group that uses the template. This parameter is returned only if you specify StackId, ChangeSetId, or StackGroupName.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The sharing type of the template. This parameter is returned only if you specify TemplateId.
        /// 
        /// Valid values:
        /// 
        /// *   Private: The template belongs to the template owner.
        /// *   Shared: The template is shared by other users.
        /// </summary>
        [NameInMap("ShareType")]
        [Validation(Required=false)]
        public string ShareType { get; set; }

        /// <summary>
        /// The name of the stack group. This parameter is returned only if you specify StackGroupName.
        /// </summary>
        [NameInMap("StackGroupName")]
        [Validation(Required=false)]
        public string StackGroupName { get; set; }

        /// <summary>
        /// The ID of the stack. This parameter is returned only if you specify StackId.
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

        /// <summary>
        /// The tags of the template.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetTemplateResponseBodyTags> Tags { get; set; }
        public class GetTemplateResponseBodyTags : TeaModel {
            /// <summary>
            /// The tag key of the template.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value of the template.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The Alibaba Cloud Resource Name (ARN) of the template. This parameter is returned only if you specify TemplateId.
        /// </summary>
        [NameInMap("TemplateARN")]
        [Validation(Required=false)]
        public string TemplateARN { get; set; }

        /// <summary>
        /// The content of the template.
        /// </summary>
        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// The ID of the template. This parameter is returned only if you specify TemplateId.
        /// 
        /// If the template is a shared template, the value of this parameter is the same as the value of TemplateARN.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// The name of the template. This parameter is returned only if you specify TemplateId.
        /// 
        /// > -   If you specify TemplateVersion, the name of the template whose version is specified by TemplateVersion is returned.
        /// > -  If you not specify TemplateVersion, the name of the template whose version is the default version is returned.
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// The version of the template. This parameter is returned only if you specify TemplateId.\\
        /// If TemplateVersion is not specified or does not take effect, the default version is used.
        /// 
        /// If the template is a shared template, this parameter is returned only if you set VersionOption to AllVersions.
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

        /// <summary>
        /// The time when the template was last updated. This parameter is returned only if you specify TemplateId.
        /// 
        /// > - If you specify TemplateVersion, the last update time of the template whose version is specified by TemplateVersion is returned.
        /// > - If you do not specify TemplateVersion, the last update time of the template whose version is the default version is returned.
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
