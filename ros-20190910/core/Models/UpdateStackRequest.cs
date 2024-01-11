// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class UpdateStackRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that the value is unique among different requests.
        /// 
        /// The token can be up to 64 characters in length, and can contain letters, digits, hyphens (-), and underscores (\_).
        /// 
        /// For more information, see [Ensure idempotence](~~134212~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to roll back the resources in the stack when the stack fails to be updated.
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
        /// Specifies whether only to validate the stack in the request. Default value: false. Valid values:
        /// 
        /// *   true: only validates the stack.
        /// *   false: validates and updates the stack.
        /// 
        /// >  When no changes are made during the update, the following rules apply: If you set the DryRun parameter to false, the NotSupported error code is returned. If you set the DryRun parameter to true, no error is reported.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The dry run option in the list format. You can specify only one dry run option.
        /// 
        /// > This parameter takes effect only when DryRun is set to true.
        /// </summary>
        [NameInMap("DryRunOptions")]
        [Validation(Required=false)]
        public List<string> DryRunOptions { get; set; }

        /// <summary>
        /// The maximum number of concurrent operations that can be performed on resources.
        /// 
        /// By default, this parameter is empty. You can set this parameter to an integer that is greater than or equal to 0.
        /// 
        /// > - If you set this parameter to an integer that is greater than 0, the integer is used.
        /// > -  If you set this parameter to 0, no limit is imposed on Resource Orchestration Service (ROS) stacks. However, the default value in Terraform is used for Terraform stacks. In most cases, the default value in Terraform is 10.
        /// > -  If you leave this parameter empty, the value that you specified for this parameter in the previous request is used. If you left this parameter empty in the previous request, no limit is imposed on ROS stacks. However, the default value in Terraform is used for Terraform stacks. In most cases, the default value in Terraform is 10.
        /// > - If you set this parameter to a specific value, ROS associates the value with the stack. The value affects subsequent operations on the stack.
        /// </summary>
        [NameInMap("Parallelism")]
        [Validation(Required=false)]
        public long? Parallelism { get; set; }

        /// <summary>
        /// The parameters.
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<UpdateStackRequestParameters> Parameters { get; set; }
        public class UpdateStackRequestParameters : TeaModel {
            /// <summary>
            /// The name of parameter N. If you do not specify the name and value of a parameter, ROS uses the default name and value in the template.
            /// 
            /// Maximum value of N: 200.
            /// 
            /// >  The Parameters parameter is optional. If you specify Parameters, you must specify both Parameters.N.ParameterKey and Parameters.N.ParameterValue.
            /// </summary>
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            /// <summary>
            /// The value of parameter N. Maximum value of N: 200.
            /// 
            /// >  The Parameters parameter is optional. If you specify Parameters, you must specify both Parameters.N.ParameterKey and Parameters.N.ParameterValue.
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        /// <summary>
        /// The name of the RAM role. Resource Orchestration Service (ROS) assumes the RAM role to create the stack and uses the credentials of the role to call the APIs of Alibaba Cloud services.
        /// 
        /// ROS assumes the RAM role to perform operations on the stack. If you have permissions to perform operations on the stack but do not have permissions to use the RAM role, ROS still assumes the RAM role. You must make sure that the least privileges are granted to the RAM role.
        /// 
        /// If you do not specify this parameter, ROS assumes the existing RAM role that is associated with the stack. If no RAM roles are available, ROS uses a temporary credential that is generated from the credentials of your account.
        /// 
        /// The name of the RAM role can be up to 64 bytes in length.
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// The ID of the region in which the stack is deployed. You can call the [DescribeRegions](~~131035~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Specifies whether to enable the replacement update feature. If you cannot change resource properties, you can enable the replacement update feature to replace the resource properties. If the replacement update feature is used, the existing resource is deleted and a new resource is created. The physical ID of the new resource is different from the physical ID of the deleted resource.
        /// 
        /// Default value: Disabled. Valid values:
        /// 
        /// *   Enabled
        /// *   Disabled
        /// 
        /// >  Changes have higher priorities than replacement updates.
        /// </summary>
        [NameInMap("ReplacementOption")]
        [Validation(Required=false)]
        public string ReplacementOption { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The ID of the stack.
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

        /// <summary>
        /// The structure that contains the stack policy body. The policy body must be 1 to 16,384 bytes in length.
        /// 
        /// >  You can specify only one of the StackPolicyBody and StackPolicyURL parameters.
        /// </summary>
        [NameInMap("StackPolicyBody")]
        [Validation(Required=false)]
        public string StackPolicyBody { get; set; }

        /// <summary>
        /// The structure that contains the body of the temporary overriding stack policy. The policy body must be 1 to 16,384 bytes in length.
        /// 
        /// If you want to update protected resources, you must specify a temporary overriding stack policy during the update. If you do not specify a temporary overriding stack policy, the existing policy that is associated with the stack is used.
        /// 
        /// This parameter takes effect only when the ChangeSetType parameter is set to UPDATE. You can specify only one of the following parameters:
        /// 
        /// *   StackPolicyBody
        /// *   StackPolicyURL
        /// *   StackPolicyDuringUpdateBody
        /// *   StackPolicyDuringUpdateURL
        /// </summary>
        [NameInMap("StackPolicyDuringUpdateBody")]
        [Validation(Required=false)]
        public string StackPolicyDuringUpdateBody { get; set; }

        /// <summary>
        /// The URL of the file that contains the temporary overriding stack policy. The URL must point to a policy that is located on an HTTP or HTTPS web server or in an OSS bucket, such as oss://ros/stack-policy/demo or oss://ros/stack-policy/demo?RegionId=cn-hangzhou. The policy file can be up to 16,384 bytes in length.
        /// 
        /// >  If you do not specify the region ID of the OSS bucket, the value of the RegionId parameter is used.
        /// 
        /// The URL can be up to 1,350 bytes in length.
        /// 
        /// If you want to update protected resources, you must specify a temporary overriding stack policy during the update. If you do not specify a temporary overriding stack policy, the existing policy that is associated with the stack is used. This parameter takes effect only when the ChangeSetType parameter is set to UPDATE. You can specify only one of the following parameters:
        /// 
        /// *   StackPolicyBody
        /// *   StackPolicyURL
        /// *   StackPolicyDuringUpdateBody
        /// *   StackPolicyDuringUpdateURL
        /// </summary>
        [NameInMap("StackPolicyDuringUpdateURL")]
        [Validation(Required=false)]
        public string StackPolicyDuringUpdateURL { get; set; }

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
        /// The value of tag N that you want to add to the template.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<UpdateStackRequestTags> Tags { get; set; }
        public class UpdateStackRequestTags : TeaModel {
            /// <summary>
            /// The key of tag N that you want to add to the stack.
            /// 
            /// Valid values of N: 1 to 20.
            /// 
            /// > - The Tags parameter is optional. If you specify Tags, you must specify Tags.N.Key.
            /// > - The tag of a stack is propagated to each resource that supports the tag feature in the stack. For more information, see [Propagate tags](~~201421~~).
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N that you want to add to the stack.
            /// 
            /// Valid values of N: 1 to 20.
            /// 
            /// >  The tag of a stack is propagated to each resource that supports the tag feature in the stack. For more information, see [Propagate tags](~~201421~~).
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// The ID of the template. This parameter applies to shared templates and private templates.
        /// 
        /// >  You must specify only one of the following parameters: TemplateBody, TemplateURL, and TemplateId.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// The URL of the file that contains the template body. The URL must point to a template that is located on an HTTP or HTTPS web server or in an OSS bucket, such as oss://ros/template/demo or oss://ros/template/demo?RegionId=cn-hangzhou. The template body must be 1 to 524,288 bytes in length. If you do not specify the region ID of the OSS bucket, the value of the RegionId parameter is used.
        /// 
        /// >  You must specify only one of the following parameters: TemplateBody, TemplateURL, and TemplateId.
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
        /// The timeout period for the update operation on the stack.
        /// 
        /// *   Default value: 60.
        /// *   Unit: minutes.
        /// </summary>
        [NameInMap("TimeoutInMinutes")]
        [Validation(Required=false)]
        public long? TimeoutInMinutes { get; set; }

        /// <summary>
        /// Specifies whether to use the values specified in the previous request for the parameters that you do not specify in the current request.
        /// 
        /// Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("UsePreviousParameters")]
        [Validation(Required=false)]
        public bool? UsePreviousParameters { get; set; }

    }

}
