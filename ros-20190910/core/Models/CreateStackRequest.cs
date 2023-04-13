// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class CreateStackRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that the value is unique among different requests. The token can be up to 64 characters in length, and can contain letters, digits, hyphens (-), and underscores (\_).
        /// 
        /// For more information, see [Ensure idempotence](~~134212~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The option for the stack after you create the stack. Default value: KeepStackOnCreationComplete. Valid values:
        /// 
        /// *   KeepStackOnCreationComplete: retains the stack and its resources after the stack is created. In this case, your stack quota in ROS is consumed.
        /// *   AbandonStackOnCreationComplete: deletes the stack, but retains its resources after the stack is created. In this case, your stack quota in ROS is not consumed. If the stack fails to be created, the stack is retained.
        /// *   AbandonStackOnCreationRollbackComplete: deletes the stack when its resources are rolled back after the stack fails to be created. In this case, your stack quota in ROS is not consumed. In other rollback scenarios, the stack is retained.
        /// </summary>
        [NameInMap("CreateOption")]
        [Validation(Required=false)]
        public string CreateOption { get; set; }

        [NameInMap("CreateOptions")]
        [Validation(Required=false)]
        public List<string> CreateOptions { get; set; }

        /// <summary>
        /// Specifies whether to enable deletion protection for the stack. Default value: Disabled. Valid values:
        /// 
        /// *   Enabled: enables deletion protection.
        /// *   Disabled: disables deletion protection. You can delete the stack by using the ROS console or by calling the DeleteStack operation.
        /// 
        /// >  The DeletionProtection parameter that you specify for the root stack applies to its nested stacks.
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public string DeletionProtection { get; set; }

        /// <summary>
        /// Specifies whether to disable rollback for the resources when the stack fails to be created.
        /// 
        /// Default value: false. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("DisableRollback")]
        [Validation(Required=false)]
        public bool? DisableRollback { get; set; }

        /// <summary>
        /// The callback URL that is used to receive stack event N.
        /// </summary>
        [NameInMap("NotificationURLs")]
        [Validation(Required=false)]
        public List<string> NotificationURLs { get; set; }

        /// <summary>
        /// The maximum number of concurrent operations that can be performed on resources.
        /// 
        /// By default, this parameter is empty. You can set this parameter to an integer that is greater than or equal to 0.
        /// 
        /// > 
        /// *   If you set this parameter to an integer that is greater than 0, the integer is used. If you set this parameter to 0 or leave this parameter empty, no limit is imposed on ROS stacks. However, the default value in Terraform is used for Terraform stacks. In most cases, the default value in Terraform is 10.
        /// *   If you set this parameter to a specific value, ROS associates the value with the stack. The value affects subsequent operations on the stack, such as an update operation.
        /// </summary>
        [NameInMap("Parallelism")]
        [Validation(Required=false)]
        public long? Parallelism { get; set; }

        /// <summary>
        /// The parameters.
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<CreateStackRequestParameters> Parameters { get; set; }
        public class CreateStackRequestParameters : TeaModel {
            /// <summary>
            /// The name of parameter N that is defined in the template. If you do not specify the name and value of a parameter, ROS uses the default name and value in the template.
            /// 
            /// Maximum value of N: 200.
            /// 
            /// The name must be 1 to 128 characters in length, and cannot contain `http://` or `https://`. The name cannot start with `aliyun` or `acs:`.
            /// 
            /// >  The Parameters parameter is optional. If you specify Parameters, you must specify both Parameters.N.ParameterKey and Parameters.N.ParameterValue.
            /// </summary>
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            /// <summary>
            /// The value of parameter N that is defined in the template.
            /// 
            /// Maximum value of N: 200.
            /// 
            /// The value can be up to 128 characters in length, and cannot contain `http://` or `https://`. The value cannot start with `aliyun` or `acs:`.
            /// 
            /// >  The Parameters parameter is optional. If you specify Parameters, you must specify both Parameters.N.ParameterKey and Parameters.N.ParameterValue.
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        /// <summary>
        /// The name of the RAM role. ROS assumes the RAM role to create the stack and uses credentials of the role to call the APIs of Alibaba Cloud services.
        /// 
        /// ROS assumes the RAM role to perform operations on the stack. If you have permissions to perform operations on the stack but do not have permissions to use the RAM role, ROS still assumes the RAM role. You must make sure that the least privileges are granted to the RAM role.
        /// 
        /// If you do not specify this parameter, ROS assumes the existing role that is associated with the stack. If no roles are available, ROS uses a temporary credential that is generated from the credentials of your account.
        /// 
        /// The name can be up to 64 characters in length.
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// The region ID of the stack. You can call the [DescribeRegions](~~131035~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group. If you do not specify this parameter, the stack is added to the default resource group.
        /// 
        /// For more information about resource groups, see the "Resource Group" section of the [What is Resource Management?](~~94475~~) topic.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The name of the stack.
        /// 
        /// The name can be up to 255 characters in length, and can contain digits, letters, hyphens (-), and underscores (\_). The name must start with a letter.
        /// </summary>
        [NameInMap("StackName")]
        [Validation(Required=false)]
        public string StackName { get; set; }

        /// <summary>
        /// The structure that contains the stack policy body. The stack policy body must be 1 to 16,384 bytes in length.
        /// 
        /// >  You can specify only one of the StackPolicyBody and StackPolicyURL parameters.
        /// </summary>
        [NameInMap("StackPolicyBody")]
        [Validation(Required=false)]
        public string StackPolicyBody { get; set; }

        /// <summary>
        /// The URL of the file that contains the stack policy. The URL must point to a policy that is located on an HTTP or HTTPS web server or in an Object Storage Service (OSS) bucket, such as oss://ros/stack-policy/demo or oss://ros/stack-policy/demo?RegionId=cn-hangzhou. The policy file can be up to 16,384 bytes in length. If you do not specify the region ID of the OSS bucket, the value of the RegionId parameter is used.
        /// 
        /// >  You can specify only one of the StackPolicyBody and StackPolicyURL parameters.
        /// 
        /// The URL can be up to 1,350 bytes in length.
        /// </summary>
        [NameInMap("StackPolicyURL")]
        [Validation(Required=false)]
        public string StackPolicyURL { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateStackRequestTags> Tags { get; set; }
        public class CreateStackRequestTags : TeaModel {
            /// <summary>
            /// The key of tag N that you want to add to the stack.
            /// 
            /// Valid values of N: 1 to 20.
            /// 
            /// > 
            /// *   The Tags parameter is optional. If you specify the Tags parameter, you must specify the Tags.N.Key parameter.
            /// *   The tag of a stack is propagated to each stack resource that supports the tag feature. For more information, see [Propagate tags](~~201421~~).
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N that you want to add to the stack.
            /// 
            /// Valid values of N: 1 to 20.
            /// 
            /// >  The tag of a stack is propagated to each stack resource that supports the tag feature. For more information, see [Propagate tags](~~201421~~).
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The structure that contains the template body. The template body must be 1 to 524,288 bytes in length. If the length of the template body exceeds the upper limit, we recommend that you add parameters to the HTTP POST request body to prevent request failures caused by excessively long URLs.
        /// 
        /// >  You must specify only one of the following parameters: TemplateBody, TemplateURL, TemplateId, and TemplateScratchId.
        /// </summary>
        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// The ID of the template. This parameter applies to shared templates and private templates.
        /// 
        /// >  You must specify only one of the following parameters: TemplateBody, TemplateURL, TemplateId, and TemplateScratchId.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// The ID of the scenario.
        /// 
        /// For more information about how to query the IDs of scenarios, see [ListTemplateScratches](~~363050~~).
        /// 
        /// >  You must specify only one of the following parameters: TemplateBody, TemplateURL, TemplateId, and TemplateScratchId.
        /// </summary>
        [NameInMap("TemplateScratchId")]
        [Validation(Required=false)]
        public string TemplateScratchId { get; set; }

        /// <summary>
        /// The region ID of the scenario. The default value is the same as the value of the RegionId parameter.
        /// 
        /// You can call the [DescribeRegions](~~131035~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("TemplateScratchRegionId")]
        [Validation(Required=false)]
        public string TemplateScratchRegionId { get; set; }

        /// <summary>
        /// The URL of the file that contains the template body. The URL must point to a template that is located on an HTTP or HTTPS web server or in an OSS bucket, such as oss://ros/stack-policy/demo or oss://ros/stack-policy/demo?RegionId=cn-hangzhou. The template body can be up to 524,288 bytes in length. If you do not specify the region ID of the OSS bucket, the value of the RegionId parameter is used.
        /// 
        /// >  You must specify only one of the following parameters: TemplateBody, TemplateURL, TemplateId, and TemplateScratchId.
        /// </summary>
        [NameInMap("TemplateURL")]
        [Validation(Required=false)]
        public string TemplateURL { get; set; }

        /// <summary>
        /// The version of the template. This parameter takes effect only when the TemplateId parameter is specified.
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

        /// <summary>
        /// The timeout period that is allowed to create the stack.
        /// 
        /// *   Default value: 60.
        /// *   Unit: minutes.
        /// *   Valid values: 10 to 1440.
        /// </summary>
        [NameInMap("TimeoutInMinutes")]
        [Validation(Required=false)]
        public long? TimeoutInMinutes { get; set; }

    }

}
