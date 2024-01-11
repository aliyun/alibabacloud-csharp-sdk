// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class CreateChangeSetRequest : TeaModel {
        /// <summary>
        /// The name of the change set.\
        /// The name can be up to 255 characters in length and can contain digits, letters, hyphens (-), and underscores (\_). The name must start with a digit or a letter.
        /// 
        /// > Make sure that the name is unique among all names of change sets that are associated with the specified stack.
        /// </summary>
        [NameInMap("ChangeSetName")]
        [Validation(Required=false)]
        public string ChangeSetName { get; set; }

        /// <summary>
        /// The type of the change set. Valid values:
        /// 
        /// *   CREATE: creates a change set for a new stack.
        /// *   UPDATE (default): creates a change set for an existing stack.
        /// *   IMPORT: creates a change set for a new stack or an existing stack to import resources that are not managed by ROS.
        /// 
        /// If you create a change set for a new stack, ROS generates a unique stack ID for the stack. The stack remains in the REVIEW_IN_PROGRESS state until you execute the change set.\
        /// If you want to create a change set for a new stack, do not set ChangeSetType to UPDATE. If you want to create a change set for an existing stack, do not set ChangeSetType to CREATE.
        /// </summary>
        [NameInMap("ChangeSetType")]
        [Validation(Required=false)]
        public string ChangeSetType { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that the value is unique among different requests.\
        /// The token can contain letters, digits, hyphens (-), and underscores (\_) and cannot exceed 64 characters in length.\
        /// For more information, see [How to ensure idempotence](~~134212~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the change set. The description can be up to 1,024 bytes in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies whether to disable rollback when the stack fails to be created.\
        /// Valid values:
        /// 
        /// *   true: disables rollback for the stack when the stack fails to be created.
        /// *   false (default): enables rollback for the stack when the stack fails to be created.
        /// 
        /// > This parameter takes effect only if you set ChangeSetType to CREATE or IMPORT.
        /// </summary>
        [NameInMap("DisableRollback")]
        [Validation(Required=false)]
        public bool? DisableRollback { get; set; }

        /// <summary>
        /// The callback URLs that are used to receive stack events.
        /// </summary>
        [NameInMap("NotificationURLs")]
        [Validation(Required=false)]
        public List<string> NotificationURLs { get; set; }

        /// <summary>
        /// The maximum number of concurrent operations that can be performed on resources. By default, this parameter is empty. You can set this parameter to an integer that is greater than or equal to 0. If you set this parameter to a specific value, ROS associates the value with the stack. The value can affect subsequent operations on the stack.
        /// 
        /// This parameter takes effect only if you set ChangeSetType to CREATE or UPDATE.
        /// 
        /// *   Valid values for change sets of the CREATE type:
        /// 
        ///     *   If you set this parameter to an integer that is greater than 0, the integer is used.
        ///     *   If you set this parameter to 0 or leave this parameter empty, no limit is imposed on ROS stacks. However, the default value in Terraform is used for Terraform stacks. In most cases, the default value in Terraform is 10.
        /// 
        /// *   Valid values for change sets of the UPDATE type:
        /// 
        ///     *   If you set this parameter to an integer that is greater than 0, the integer is used.
        ///     *   If you set this parameter to 0, no limit is imposed on ROS stacks. However, the default value in Terraform is used for Terraform stacks. In most cases, the default value in Terraform is 10.
        ///     *   If you leave this parameter empty, the value that you specified for this parameter in the previous request is used. If you left this parameter empty in the previous request, no limit is imposed on ROS stacks. However, the default value in Terraform is used for Terraform stacks. In most cases, the default value in Terraform is 10.
        /// </summary>
        [NameInMap("Parallelism")]
        [Validation(Required=false)]
        public long? Parallelism { get; set; }

        /// <summary>
        /// The parameters that are defined in the template.
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<CreateChangeSetRequestParameters> Parameters { get; set; }
        public class CreateChangeSetRequestParameters : TeaModel {
            /// <summary>
            /// The key of parameter N that is defined in the template. If you do not specify the key and value of a parameter, ROS uses the default name and value that are defined in the template. Maximum value of N: 200.
            /// 
            /// >  Parameters is optional. If you specify Parameters, you must also specify Parameters.N.ParameterKey.
            /// </summary>
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            /// <summary>
            /// The value of parameter N that is defined in the template. Maximum value of N: 200.
            /// 
            /// >  Parameters is optional. If you specify Parameters, you must also specify Parameters.N.ParameterValue.
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        /// <summary>
        /// The name of the Resource Access Management (RAM) role. Resource Orchestration Service (ROS) assumes the RAM role to create the stack and uses the credentials of the role to call the APIs of Alibaba Cloud services.\
        /// ROS assumes the role to perform operations on the stack. If you have permissions to perform operations on the stack but do not have permissions to use the RAM role, ROS still assumes the RAM role. You must make sure that the least privileges are granted to the RAM role.\
        /// If you do not specify this parameter, ROS uses the existing role that is associated with the stack. If no roles are available for ROS to assume, ROS uses a temporary credential that is generated from the credentials of your Alibaba Cloud account.\
        /// The name of the RAM role can be up to 64 bytes in length.
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// The region ID of the change set. You can call the [DescribeRegions](~~131035~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Specifies whether to enable replacement update if a resource property is changed and you cannot modify the new resource property. For a change, the physical ID of the resource remains unchanged. For a replacement update, the existing resource is deleted, a new resource is created, and the physical ID of the resource is changed. Valid values:
        /// 
        /// *   Enabled
        /// *   Disabled (default)
        /// 
        /// > Operations that you perform to modify the resource properties for an update take precedence over operations you perform to replace the resource properties for an update. This parameter takes effect only if you set ChangeSetType to UPDATE.
        /// </summary>
        [NameInMap("ReplacementOption")]
        [Validation(Required=false)]
        public string ReplacementOption { get; set; }

        /// <summary>
        /// The resources that you want to import into the stack.
        /// </summary>
        [NameInMap("ResourcesToImport")]
        [Validation(Required=false)]
        public List<CreateChangeSetRequestResourcesToImport> ResourcesToImport { get; set; }
        public class CreateChangeSetRequestResourcesToImport : TeaModel {
            /// <summary>
            /// The logical ID of resource N that you want to import. The logical ID specifies the name of resource N that is defined in the template.
            /// 
            /// > This parameter takes effect only if you set ChangeSetType to IMPORT. ResourcesToImport is optional. If you specify ResourcesToImport, you must also specify ResourcesToImport.N.LogicalResourceId.
            /// </summary>
            [NameInMap("LogicalResourceId")]
            [Validation(Required=false)]
            public string LogicalResourceId { get; set; }

            /// <summary>
            /// The key-value mapping between strings. The value is a JSON string that identifies resource N that you want to import.\
            /// A key is an identifier for a resource and a value is an assignment of data to the key. For example, VpcId is a key that indicates the ID of a virtual private cloud (VPC), and `vpc-2zevx9ios****` is a value that is assigned to VpcId. You can call the [GetTemplateSummary](~~172485~~) operation to obtain the key of a resource.
            /// 
            /// > This parameter takes effect only if you set ChangeSetType to IMPORT. ResourcesToImport is optional. If you specify ResourcesToImport, you must also specify ResourcesToImport.N.ResourceIdentifier.
            /// </summary>
            [NameInMap("ResourceIdentifier")]
            [Validation(Required=false)]
            public string ResourceIdentifier { get; set; }

            /// <summary>
            /// The type of resource N that you want to import. The resource type must be the same as the resource type that is defined in the template.
            /// 
            /// > This parameter takes effect only if you set ChangeSetType to IMPORT. ResourcesToImport is optional. If you specify ResourcesToImport, you must also specify ResourcesToImport.N.ResourceType.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// The ID of the stack for which you want to create a change set. ROS compares the stack information with the information that you submit, such as a modified template or a changed parameter value, to generate the change set.
        /// 
        /// > This parameter takes effect only for change sets of the UPDATE or IMPORT.
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

        /// <summary>
        /// The name of the stack for which you want to create the change set.\
        /// The name can be up to 255 characters in length and can contain digits, letters, hyphens (-), and underscores (\_). The name must start with a digit or a letter.
        /// 
        /// > This parameter takes effect only if you set ChangeSetType to CREATE or IMPORT.
        /// </summary>
        [NameInMap("StackName")]
        [Validation(Required=false)]
        public string StackName { get; set; }

        /// <summary>
        /// The structure of the stack policy body. The policy body must be 1 to 16,384 bytes in length. If you set ChangeSetType to CREATE, you can specify StackPolicyBody or StackPolicyURL. If you set ChangeSetType to UPDATE, you can specify only one of the following parameters:
        /// 
        /// *   StackPolicyBody
        /// *   StackPolicyURL
        /// *   StackPolicyDuringUpdateBody
        /// *   StackPolicyDuringUpdateURL
        /// </summary>
        [NameInMap("StackPolicyBody")]
        [Validation(Required=false)]
        public string StackPolicyBody { get; set; }

        /// <summary>
        /// The structure of the temporary overriding stack policy. The policy body must be 1 to 16,384 bytes in length.\
        /// If you need to update protected resources, specify a temporary overriding stack policy for the resources during the update. If you do not specify a temporary overriding stack policy, the existing stack policy that is associated with the stack is used.\
        /// This parameter takes effect only if you set ChangeSetType to UPDATE. You can specify only one of the following parameters:
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
        /// The URL of the stack policy based on which the stack is updated. The URL must point to a policy that is located on an HTTP or HTTPS web server or in an OSS bucket, such as oss://ros/stack-policy/demo and oss://ros/stack-policy/demo?RegionId=cn-hangzhou. The policy file can be up to 16,384 bytes in length.
        /// 
        /// > If you do not specify the region of the OSS bucket, the value of RegionId is used.
        /// 
        /// The URL can be up to 1,350 bytes in length.\
        /// If you need to update protected resources, specify a temporary overriding stack policy for the resources during the update. If you do not specify a stack policy, the existing policy that is associated with the stack is used. This parameter takes effect only if you set ChangeSetType to UPDATE. You can specify only one of the following parameters:
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
        /// The URL of the file that contains the stack policy. The URL must point to a policy that is located on an HTTP or HTTPS web server or in an Object Storage Service (OSS) bucket, such as oss://ros/stack-policy/demo and oss://ros/stack-policy/demo?RegionId=cn-hangzhou. The policy file can be up to 16,384 bytes in length.
        /// 
        /// > If you do not specify the region of the OSS bucket, the value of RegionId is used.
        /// 
        /// You can specify only one of the following parameters: StackPolicyBody and StackPolicyURL.\
        /// The URL can be up to 1,350 bytes in length.
        /// 
        /// If you set ChangeSetType to CREATE, you can specify StackPolicyBody or StackPolicyURL. If you set ChangeSetType to UPDATE, you can specify only one of the following parameters:
        /// 
        /// *   StackPolicyBody
        /// *   StackPolicyURL
        /// *   StackPolicyDuringUpdateBody
        /// *   StackPolicyDuringUpdateURL
        /// </summary>
        [NameInMap("StackPolicyURL")]
        [Validation(Required=false)]
        public string StackPolicyURL { get; set; }

        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// The ID of the template. This parameter applies to shared and private templates.
        /// 
        /// You can specify only one of the following parameters: TemplateBody, TemplateURL, and TemplateId.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// The ID of the scenario template.
        /// </summary>
        [NameInMap("TemplateScratchId")]
        [Validation(Required=false)]
        public string TemplateScratchId { get; set; }

        /// <summary>
        /// The URL of the file that contains the template body. The URL must point to a template that is located on an HTTP or HTTPS web server or in an OSS bucket, such as oss://ros/template/demo and oss://ros/template/demo?RegionId=cn-hangzhou. The template body can be up to 524,288 bytes in length.
        /// 
        /// > If you do not specify the region of the OSS bucket, the value of RegionId is used.
        /// 
        /// You can specify only one of the following parameters: TemplateBody, TemplateURL, and TemplateId.
        /// 
        /// The URL can be up to 1,024 bytes in length.
        /// </summary>
        [NameInMap("TemplateURL")]
        [Validation(Required=false)]
        public string TemplateURL { get; set; }

        /// <summary>
        /// The version of the template.
        /// 
        /// > This parameter takes effect only if you specify TemplateId.
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

        /// <summary>
        /// The amount of time that can elapse before the stack enters the CREATE_FAILED or UPDATE_FAILED state.\
        /// If you set ChangeSetType to CREATE, this parameter is required. If you set ChangeSetType to UPDATE, this parameter is optional.
        /// 
        /// *   Unit: minutes.
        /// *   Valid values: 10 to 1440.
        /// *   Default value: 60.
        /// </summary>
        [NameInMap("TimeoutInMinutes")]
        [Validation(Required=false)]
        public long? TimeoutInMinutes { get; set; }

        /// <summary>
        /// Specifies whether to use the values that were passed last time for the parameters that you do not specify in the current request. Valid values:
        /// 
        /// *   true
        /// *   false (default)
        /// 
        /// > This parameter takes effect only if you set ChangeSetType to UPDATE or IMPORT.
        /// </summary>
        [NameInMap("UsePreviousParameters")]
        [Validation(Required=false)]
        public bool? UsePreviousParameters { get; set; }

    }

}
