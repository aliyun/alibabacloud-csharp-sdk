// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class UpdateStackGroupShrinkRequest : TeaModel {
        /// <summary>
        /// The IDs of the accounts within which you want to use self-managed permissions to deploy stacks. You can specify a maximum of 20 account IDs.
        /// </summary>
        [NameInMap("AccountIds")]
        [Validation(Required=false)]
        public string AccountIdsShrink { get; set; }

        /// <summary>
        /// The name of the RAM role to be assumed by the administrator account in ROS. This parameter is required if you want to grant self-managed permissions to the stack group. If you do not specify a value for this parameter, the default value AliyunROSStackGroupAdministrationRole is used. You can use the administrator role in ROS to assume the execution role AliyunROSStackGroupExecutionRole to perform operations on the stacks that correspond to stack instances in the stack group.
        /// 
        /// The name must be 1 to 64 characters in length, and can contain letters, digits, and hyphens (-).
        /// </summary>
        [NameInMap("AdministrationRoleName")]
        [Validation(Required=false)]
        public string AdministrationRoleName { get; set; }

        /// <summary>
        /// The information about automatic deployment settings.
        /// 
        /// >  This parameter is required only if the PermissionModel parameter is set to SERVICE_MANAGED.
        /// </summary>
        [NameInMap("AutoDeployment")]
        [Validation(Required=false)]
        public string AutoDeploymentShrink { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that the token is unique among different requests.
        /// 
        /// The token can be up to 64 characters in length and can contain letters, digits, hyphens (-), and underscores (\_).
        /// 
        /// For more information, see [Ensure idempotence](~~134212~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The folders in which you want to use service-managed permissions to update stacks.
        /// </summary>
        [NameInMap("DeploymentTargets")]
        [Validation(Required=false)]
        public string DeploymentTargetsShrink { get; set; }

        /// <summary>
        /// The description of the stack group.
        /// 
        /// The description must be 1 to 256 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the RAM role to be assumed by the administrator role AliyunROSStackGroupAdministrationRole. This parameter is required if you want to grant self-managed permissions to the stack group. If you do not specify a value for this parameter, the default value AliyunROSStackGroupExecutionRole is used. You can use this role in ROS to perform operations on the stacks that correspond to stack instances in the stack group.
        /// 
        /// The name must be 1 to 64 characters in length, and can contain letters, digits, and hyphens (-).
        /// </summary>
        [NameInMap("ExecutionRoleName")]
        [Validation(Required=false)]
        public string ExecutionRoleName { get; set; }

        /// <summary>
        /// The description of the operation to update the stack group.
        /// </summary>
        [NameInMap("OperationDescription")]
        [Validation(Required=false)]
        public string OperationDescription { get; set; }

        /// <summary>
        /// The preferences of the operation to update the stack group.
        /// 
        /// The following parameters are available:
        /// 
        /// *   {"FailureToleranceCount": N}
        /// 
        ///     The maximum number of accounts within which stack operation failures are allowed in each region. If the value is exceeded in a region, ROS stops the operation in the region. If ROS stops the operation in one region, the operation is not performed in other regions.
        /// 
        ///     Valid values of N: 0 to 20.
        /// 
        ///     If you do not specify a value for the FailureToleranceCount parameter, the default value 0 is used.
        /// 
        /// *   {"FailureTolerancePercentage": N}
        /// 
        ///     The percentage of accounts within which stack operation failures are allowed in each region. If the value is exceeded in a region, ROS stops the operation in the region.
        /// 
        ///     Valid values of N: 0 to 100. If the number of accounts specified by the percentage is not a whole number, ROS rounds down the number.
        /// 
        ///     If you do not specify a value for the FailureTolerancePercentage parameter, the default value 0 is used.
        /// 
        /// *   {"MaxConcurrentCount": N}
        /// 
        ///     The maximum number of accounts within which stacks can be deployed at a time in each region.
        /// 
        ///     Valid values of N: 1 to 20.
        /// 
        ///     If you do not specify a value for the MaxConcurrentCount parameter, the default value 1 is used.
        /// 
        /// *   {"MaxConcurrentPercentage": N}
        /// 
        ///     The percentage of accounts within which stacks can be deployed at a time in each region.
        /// 
        ///     Valid values of N: 1 to 100. If the number of accounts specified by the percentage is not a whole number, ROS rounds down the number.
        /// 
        ///     If you do not specify a value for the MaxConcurrentPercentage parameter, the default value 1 is used.
        /// 
        /// *   {"RegionConcurrencyType": N}
        /// 
        ///     Specifies whether stacks can be deployed in multiple regions in parallel. Valid values:
        /// 
        ///     *   SEQUENTIAL: deploys stacks in the specified regions one by one in sequence. This way, stacks are deployed in only one region at a time. This is the default value.
        ///     *   PARALLEL: deploys stacks in all the specified regions in parallel.
        /// 
        /// Separate multiple parameters with commas (,).
        /// 
        /// > 
        /// *   You can specify only one of the MaxConcurrentCount and MaxConcurrentPercentage parameters.
        /// *   You can specify only one of the FailureToleranceCount and FailureTolerancePercentage parameters.
        /// </summary>
        [NameInMap("OperationPreferences")]
        [Validation(Required=false)]
        public string OperationPreferencesShrink { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<UpdateStackGroupShrinkRequestParameters> Parameters { get; set; }
        public class UpdateStackGroupShrinkRequestParameters : TeaModel {
            /// <summary>
            /// The key of parameter N. If you do not specify the key and value of the parameter, ROS uses the default key and value in the template.
            /// 
            /// Maximum value of N: 200.
            /// 
            /// >  The Parameters parameter is optional. If you set the Parameters parameter, you must set the Parameters.N.ParameterKey parameter.
            /// </summary>
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            /// <summary>
            /// The value of parameter N.
            /// 
            /// Maximum value of N: 200.
            /// 
            /// >  The Parameters parameter is optional. If you set the Parameters parameter, you must set the Parameters.N.ParameterValue parameter.
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        /// <summary>
        /// The permission model.
        /// 
        /// Valid values:
        /// 
        /// *   SELF_MANAGED: the self-managed permission model. This is the default value. If you use the self-managed model for the stack group, you must create RAM roles for the administrator and execution accounts, and establish a trust relationship between the accounts to deploy stacks within the execution account.
        /// *   SERVICE_MANAGED: the service-managed permission model. If you use the service-managed model for the stack group, ROS creates service-linked roles for the administrator and execution accounts, and the administrator account uses its role to deploy stacks within the execution account.
        /// 
        /// > 
        /// *   If stack instances have been created in the stack group, you cannot switch the permission mode of the stack group.
        /// *   If you want to use the service-managed permission model to deploy stacks, your account must be the management account or a delegated administrator account of your resource directory and the trusted access feature is enabled for the account. For more information, see [Step 1: (Optional) Create a delegated administrator account](~~308253~~) and [Step 2: Enable trusted access](~~298229~~).
        /// </summary>
        [NameInMap("PermissionModel")]
        [Validation(Required=false)]
        public string PermissionModel { get; set; }

        /// <summary>
        /// The region ID of the stack group. You can call the [DescribeRegions](~~131035~~) operation to query the latest list of Alibaba Cloud regions.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The region IDs of stack instances. You can specify a maximum of 20 region IDs.
        /// </summary>
        [NameInMap("RegionIds")]
        [Validation(Required=false)]
        public string RegionIdsShrink { get; set; }

        /// <summary>
        /// The name of the stack group. The name must be unique within a region.
        /// 
        /// The name can be up to 255 characters in length and can contain digits, letters, hyphens (-), and underscores (\_). The name must start with a digit or a letter.
        /// </summary>
        [NameInMap("StackGroupName")]
        [Validation(Required=false)]
        public string StackGroupName { get; set; }

        /// <summary>
        /// The structure that contains the template body. The template body must be 1 to 524,288 bytes in length. If the length of the template body exceeds the upper limit, we recommend that you add parameters to the HTTP POST request body to prevent request failures caused by excessively long URLs.
        /// 
        /// >  You must specify only one of the TemplateBody, TemplateURL, and TemplateId parameters.
        /// </summary>
        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// The ID of the template. This parameter applies to shared and private templates.
        /// 
        /// >  You must specify only one of the TemplateBody, TemplateURL, and TemplateId parameters.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// The URL of the file that contains the template body. The URL must point to a template that is located on an HTTP or HTTPS web server or in an Alibaba Cloud Object Storage Service (OSS) bucket. The template body must be 1 to 524,288 bytes in length. Examples: oss://ros/template/demo and oss://ros/template/demo?RegionId=cn-hangzhou. If you do not specify the region ID of the OSS bucket, the value of the RegionId parameter is used.
        /// 
        /// >  You must specify only one of the TemplateBody, TemplateURL, and TemplateId parameters.
        /// </summary>
        [NameInMap("TemplateURL")]
        [Validation(Required=false)]
        public string TemplateURL { get; set; }

        /// <summary>
        /// The version of the template. If you do not specify a version, the latest version is used.
        /// 
        /// >  This parameter takes effect only if the TemplateId parameter is set.
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

    }

}
