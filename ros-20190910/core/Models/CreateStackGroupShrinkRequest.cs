// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class CreateStackGroupShrinkRequest : TeaModel {
        /// <summary>
        /// The name of the RAM role that you specify for the administrator account when you create a self-managed stack group. ROS assumes the administrator role to perform operations. If you do not specify this parameter, AliyunROSStackGroupAdministrationRole is used as the default value. ROS uses the administrator role to assume the execution role AliyunROSStackGroupExecutionRole to perform operations on the stacks in the stack group.
        /// 
        /// The name must be 1 to 64 characters in length and can contain letters, digits, and hyphens (-).
        /// </summary>
        [NameInMap("AdministrationRoleName")]
        [Validation(Required=false)]
        public string AdministrationRoleName { get; set; }

        /// <summary>
        /// The information about automatic deployment settings.
        /// 
        /// > You must specify this parameter if PermissionModel is set to SERVICE_MANAGED.
        /// </summary>
        [NameInMap("AutoDeployment")]
        [Validation(Required=false)]
        public string AutoDeploymentShrink { get; set; }

        /// <summary>
        /// The options for the stack group. You can specify up to one option.
        /// </summary>
        [NameInMap("Capabilities")]
        [Validation(Required=false)]
        public List<string> Capabilities { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests.\
        /// The token can contain letters, digits, underscores (\_), and hyphens (-) and cannot exceed 64 characters in length.\
        /// For more information, see [How to ensure idempotence](~~134212~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the stack group.\
        /// The description must be 1 to 256 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the RAM role that you specify for the execution account when you create a self-managed stack group. The administrator role AliyunROSStackGroupAdministrationRole assumes the execution role to perform operations. If you do not specify this parameter, AliyunROSStackGroupExecutionRole is used as the default value. ROS assumes the execution role to perform operations on the stacks in the stack group.
        /// 
        /// The name must be 1 to 64 characters in length and can contain letters, digits, and hyphens (-).
        /// </summary>
        [NameInMap("ExecutionRoleName")]
        [Validation(Required=false)]
        public string ExecutionRoleName { get; set; }

        /// <summary>
        /// The parameters of the stack group.
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<CreateStackGroupShrinkRequestParameters> Parameters { get; set; }
        public class CreateStackGroupShrinkRequestParameters : TeaModel {
            /// <summary>
            /// The key of parameter N. If you do not specify the key and value of a parameter, ROS uses the default name and value that are defined in the template.
            /// 
            /// Maximum value of N: 200.
            /// 
            /// > Parameters is optional. If you specify Parameters, you must also specify Parameters.N.ParameterKey.
            /// </summary>
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            /// <summary>
            /// The value of parameter N.
            /// 
            /// Maximum value of N: 200.
            /// 
            /// > Parameters is optional. If you specify Parameters, you must also specify Parameters.N.ParameterValue.
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        /// <summary>
        /// The permission model of the stack group.
        /// 
        /// Valid values:
        /// 
        /// *   SELF_MANAGED (default): the self-managed permission model. If you create a self-managed stack group, you must create RAM roles within the administrator and execution accounts and establish a trust relationship between the accounts. Then, you can deploy stacks within the execution account.
        /// *   SERVICE_MANAGED: the service-managed permission model. If you create a service-managed stack group, ROS creates service-linked roles for the administrator and execution accounts, and the administrator account uses its role to deploy stacks within the execution account.
        /// 
        /// > If you want to use the service-managed permission model to deploy stacks, your account must be the management account or a delegated administrator account of your resource directory and the trusted access feature is enabled for the account. For more information, see [Manage a delegated administrator account](~~308253~~) and [Enable trusted access](~~298229~~).
        /// </summary>
        [NameInMap("PermissionModel")]
        [Validation(Required=false)]
        public string PermissionModel { get; set; }

        /// <summary>
        /// The region ID of the stack group. You can call the [DescribeRegions](~~131035~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group. If you do not specify this parameter, the stack group is added to the default resource group.\
        /// For more information about resource groups, see [Resource groups](~~94475~~).
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The name of the stack group. The name must be unique within a region.\
        /// The name can be up to 255 characters in length, and can contain digits, letters, hyphens (-), and underscores (\_). It must start with a digit or a letter.
        /// </summary>
        [NameInMap("StackGroupName")]
        [Validation(Required=false)]
        public string StackGroupName { get; set; }

        /// <summary>
        /// The tags of the stack group.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateStackGroupShrinkRequestTags> Tags { get; set; }
        public class CreateStackGroupShrinkRequestTags : TeaModel {
            /// <summary>
            /// The tag key of the stack group.
            /// 
            /// > Tags is optional. If you want to specify Tags, you must also specify Tags.N.Key.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value of the stack group.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// The ID of the template. This parameter applies to shared and private templates.
        /// 
        /// > You must and can specify only one of the following parameters: TemplateBody, TemplateURL, and TemplateId.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// The URL of the file that contains the template body. The URL must point to a template that is located on an HTTP or HTTPS web server or in an Alibaba Cloud Object Storage Service (OSS) bucket. The template body must be 1 to 524,288 bytes in length. Examples: oss://ros/template/demo and oss://ros/template/demo?RegionId=cn-hangzhou. If you do not specify the region ID of the OSS bucket, the value of RegionId is used.
        /// 
        /// > You must and can specify only one of the following parameters: TemplateBody, TemplateURL, and TemplateId.
        /// </summary>
        [NameInMap("TemplateURL")]
        [Validation(Required=false)]
        public string TemplateURL { get; set; }

        /// <summary>
        /// The version of the template. If you do not specify this parameter, the latest version is used.
        /// 
        /// > TemplateVersion takes effect only if you specify TemplateId.
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

    }

}
