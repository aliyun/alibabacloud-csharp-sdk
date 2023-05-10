// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class CreateStackGroupShrinkRequest : TeaModel {
        /// <summary>
        /// The version of the template. If you do not specify this parameter, the latest version is used.
        /// 
        /// >  This parameter takes effect only when the TemplateId parameter is specified.
        /// </summary>
        [NameInMap("AdministrationRoleName")]
        [Validation(Required=false)]
        public string AdministrationRoleName { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("AutoDeployment")]
        [Validation(Required=false)]
        public string AutoDeploymentShrink { get; set; }

        [NameInMap("Capabilities")]
        [Validation(Required=false)]
        public List<string> Capabilities { get; set; }

        /// <summary>
        /// The ID of the template. This parameter applies to shared and private templates.
        /// 
        /// >  You must specify only one of the following parameters: TemplateBody, TemplateURL, and TemplateId.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that the value is unique among different requests.
        /// 
        /// The token can be up to 64 characters in length, and can contain letters, digits, hyphens (-), and underscores (\_).
        /// 
        /// For more information, see [Ensure idempotence](~~134212~~).
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The parameters.
        /// </summary>
        [NameInMap("ExecutionRoleName")]
        [Validation(Required=false)]
        public string ExecutionRoleName { get; set; }

        /// <summary>
        /// The ID of the resource group. If you do not specify this parameter, the stack group is added to the default resource group.
        /// 
        /// For more information about resource groups, see the "Resource Group" section of the [What is Resource Management?](~~94475~~) topic.
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<CreateStackGroupShrinkRequestParameters> Parameters { get; set; }
        public class CreateStackGroupShrinkRequestParameters : TeaModel {
            /// <summary>
            /// The permission model.
            /// 
            /// Default value: SELF_MANAGED. Valid values:
            /// 
            /// *   SELF_MANAGED: the self-managed permission model. If you create a self-managed stack group, you must create RAM roles within the administrator and execution accounts and establish a trust relationship between the accounts. Then, you can deploy stacks within the execution account.
            /// *   SERVICE_MANAGED: the service-managed permission model. If you create a service-managed stack group, ROS creates service-linked roles for the administrator and execution accounts, and the administrator account uses its role to deploy stacks within the execution account.
            /// 
            /// >  When you use the service-managed permission model to deploy stacks, make sure that your account is the management account or a delegated administrator account in the resource directory and the trusted access feature is enabled for your account. For more information, see [Step 1: (Optional) Create a delegated administrator account](~~308253~~) and [Step 2: Enable trusted access](~~298229~~).
            /// </summary>
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            /// <summary>
            /// The tags.
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        /// <summary>
        /// The value of tag N that you want to add to the stack group.
        /// </summary>
        [NameInMap("PermissionModel")]
        [Validation(Required=false)]
        public string PermissionModel { get; set; }

        /// <summary>
        /// The structure that contains the template body. The template body must be 1 to 524,288 bytes in length. If the length of the template body exceeds the upper limit, we recommend that you add parameters to the HTTP POST request body to prevent request failures caused by excessively long URLs.
        /// 
        /// >  You must specify only one of the following parameters: TemplateBody, TemplateURL, and TemplateId.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The key of tag N that you want to add to the stack group.
        /// 
        /// >  The Tags parameter is optional. If you specify the Tags parameter, you must specify the Tags.N.Key parameter.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The URL of the file that contains the template body. The URL must point to a template that is located on an HTTP or HTTPS web server or in an Alibaba Cloud Object Storage Service (OSS) bucket, such as oss://ros/template/demo or oss://ros/template/demo?RegionId=cn-hangzhou. The template body must be 1 to 524,288 bytes in length. If you do not specify the region ID of the OSS bucket, the value of the RegionId parameter is used.
        /// 
        /// >  You must specify only one of the following parameters: TemplateBody, TemplateURL, and TemplateId.
        /// </summary>
        [NameInMap("StackGroupName")]
        [Validation(Required=false)]
        public string StackGroupName { get; set; }

        /// <summary>
        /// The information about automatic deployment settings.
        /// 
        /// >  This parameter is required only if the PermissionModel parameter is set to SERVICE_MANAGED.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateStackGroupShrinkRequestTags> Tags { get; set; }
        public class CreateStackGroupShrinkRequestTags : TeaModel {
            /// <summary>
            /// Specifies whether to enable automatic deployment.
            /// 
            /// Valid values:
            /// 
            /// *   true: enables automatic deployment. If you add a member to the folder to which the stack group belongs after you enable automatic deployment, ROS automatically adds the stacks in the stack group to the member. If you remove a member from the folder, ROS automatically deletes the stacks from the member.
            /// *   false: disables automatic deployment. After you disable automatic deployment, the stacks remain unchanged when you change the members in the folder.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// Specifies whether to retain stacks within a member when you remove the member from the folder.
            /// 
            /// Valid values:
            /// 
            /// *   true: retains the stacks.
            /// *   false: deletes the stacks.
            /// 
            /// >  This parameter is required if the Enabled parameter is set to true.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The name of the RAM role that you specify for the administrator account when you create a self-managed stack group. ROS assumes the administrator role to perform operations. If you do not specify this parameter, the default value AliyunROSStackGroupAdministrationRole is used. ROS uses the administrator role to assume the execution role AliyunROSStackGroupExecutionRole to perform operations on the stacks in the stack group.
        /// 
        /// The name must be 1 to 64 characters in length, and can contain letters, digits, and hyphens (-).
        /// </summary>
        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// The name of parameter N. If you do not specify the name and value of a parameter, ROS uses the default name and value that are defined in the template.
        /// 
        /// Maximum value of N: 200.
        /// 
        /// >  The Parameters parameter is optional. If you specify the Parameters parameter, you must specify the Parameters.N.ParameterKey parameter.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// The name of the RAM role that you specify for the execution account when you create a self-managed stack group. The administrator role AliyunROSStackGroupAdministrationRole assumes the execution role to perform operations. If you do not specify this parameter, the default value AliyunROSStackGroupExecutionRole is used. ROS assumes the execution role to perform operations on the stacks in the stack group.
        /// 
        /// The name must be 1 to 64 characters in length, and can contain letters, digits, and hyphens (-).
        /// </summary>
        [NameInMap("TemplateURL")]
        [Validation(Required=false)]
        public string TemplateURL { get; set; }

        /// <summary>
        /// The value of parameter N.
        /// 
        /// Maximum value of N: 200.
        /// 
        /// >  The Parameters parameter is optional. If you specify the Parameters parameter, you must specify the Parameters.N.ParameterValue parameter.
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

    }

}
