// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class CreateStackInstancesRequest : TeaModel {
        /// <summary>
        /// The IDs of the execution accounts within which you want to deploy stacks in self-managed mode. You can specify up to 20 execution account IDs.
        /// 
        /// > You must specify one of the following parameters: `AccountIds` and `DeploymentTargets`.
        /// </summary>
        [NameInMap("AccountIds")]
        [Validation(Required=false)]
        public List<string> AccountIds { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests.\
        /// The token can contain letters, digits, hyphens (-), and underscores (\_), and cannot exceed 64 characters in length.\
        /// For more information, see [How to ensure idempotence](~~134212~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The folders in which ROS deploy stacks in service-managed permission model.
        /// 
        /// > You must specify one of the following parameters: `AccountIds` and `DeploymentTargets`.
        /// </summary>
        [NameInMap("DeploymentTargets")]
        [Validation(Required=false)]
        public CreateStackInstancesRequestDeploymentTargets DeploymentTargets { get; set; }
        public class CreateStackInstancesRequestDeploymentTargets : TeaModel {
            /// <summary>
            /// The folder IDs of the resource directory. You can add up to five folder IDs.
            /// 
            /// You can create stacks within all the member accounts in the specified folders. If you create stacks in the Root folder, the stacks are created within all member accounts in the resource directory.
            /// 
            /// > To view the folder IDs, go to the **Overview** page in the **Resource Management** console. For more information, see [View the basic information about a folder](~~111223~~).
            /// </summary>
            [NameInMap("RdFolderIds")]
            [Validation(Required=false)]
            public List<string> RdFolderIds { get; set; }

        }

        /// <summary>
        /// Specifies whether to disable rollback when the stack fails to be created.
        /// 
        /// Valid values:
        /// 
        /// *   true
        /// *   false (default)
        /// </summary>
        [NameInMap("DisableRollback")]
        [Validation(Required=false)]
        public bool? DisableRollback { get; set; }

        /// <summary>
        /// The description of the stack creation operation.
        /// 
        /// The description must be 1 to 256 characters in length.
        /// </summary>
        [NameInMap("OperationDescription")]
        [Validation(Required=false)]
        public string OperationDescription { get; set; }

        /// <summary>
        /// The preference settings of the stack creation operation.
        /// 
        /// The following parameters are available:
        /// 
        /// -  {"FailureToleranceCount": N}
        /// 
        ///     The number of accounts within which stack operation failures are allowed in each region. If the value of this parameter is exceeded in a region, Resource Orchestration Service (ROS) stops the operation in the region. If ROS stops the operation in one region, ROS stops the operation in other regions.
        /// 
        ///     Valid values of N: 0 to 20.
        /// 
        ///     If you do not specify FailureToleranceCount, 0 is used as the default value.
        /// 
        /// -  {"FailureTolerancePercentage": N}
        /// 
        ///     The percentage of the number of accounts within which stack operation failures are allowed to the total number of accounts in each region. If the value of this parameter is exceeded, ROS stops the operation in the region.
        /// 
        ///     Valid values of N: 0 to 100. If the numeric value in the percentage is not an integer, ROS rounds the value down to the nearest integer.
        /// 
        ///     If you do not specify FailureTolerancePercentage, 0 is used as the default value.
        /// 
        /// -  {"MaxConcurrentCount": N}
        /// 
        ///    The maximum number of accounts within which multiple stacks are deployed at the same time in each region.
        /// 
        ///    Valid values of N: 1 to 20.
        /// 
        ///    If you do not specify MaxConcurrentCount, 1 is used as the default value.
        /// 
        /// -  {"MaxConcurrentPercentage": N}
        /// 
        ///     The percentage of the maximum number of accounts within which multiple stacks are deployed at the same time to the total number of accounts in each region.
        /// 
        ///     Valid values: 1 to 100. If the numeric value in the percentage is not an integer, ROS rounds the number down to the nearest integer.
        /// 
        ///     If you do not specify MaxConcurrentPercentage, 1 is used as the default value.
        /// 
        /// -  {"RegionConcurrencyType": N}\
        ///     The mode that you want to use to deploy stacks across regions. Valid values: 
        ///    - SEQUENTIAL (default): deploys stacks in each specified region based on the specified sequence of regions. ROS deploys stacks in one region at a time. 
        ///    - PARALLEL: deploys stacks in parallel across all specified regions.
        /// 
        /// Separate multiple parameters with commas (,).
        /// 
        /// >-  You can specify only one of the following parameters: MaxConcurrentCount and MaxConcurrentPercentage.
        /// >-  You can specify only one of the following parameters: FailureToleranceCount and FailureTolerancePercentage.
        /// </summary>
        [NameInMap("OperationPreferences")]
        [Validation(Required=false)]
        public Dictionary<string, object> OperationPreferences { get; set; }

        /// <summary>
        /// The parameters that are used to override specific parameters.
        /// </summary>
        [NameInMap("ParameterOverrides")]
        [Validation(Required=false)]
        public List<CreateStackInstancesRequestParameterOverrides> ParameterOverrides { get; set; }
        public class CreateStackInstancesRequestParameterOverrides : TeaModel {
            /// <summary>
            /// The key of parameter N that you want to use to override a specific parameter. If you do not specify this parameter, ROS uses the name that you specified when you created the stack group.
            /// 
            /// Maximum value of N: 200.
            /// 
            /// >-   ParameterOverrides is optional.
            /// >-   If you specify ParameterOverrides, you must specify ParameterOverrides.N.ParameterKey and ParameterOverrides.N.ParameterValue.
            /// </summary>
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            /// <summary>
            /// The value of parameter N that you want to use to override a specific parameter. If you do not specify this parameter, ROS uses the value that you specify when you create the stack group.
            /// 
            /// Maximum value of N: 200.
            /// 
            /// >-  ParameterOverrides is optional.
            /// >-  If you specify ParameterOverrides, you must specify ParameterOverrides.N.ParameterKey and ParameterOverrides.N.ParameterValue.
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        /// <summary>
        /// The region ID of the stack group. You can call the [DescribeRegions](~~131035~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The IDs of the regions where you want to create the stacks. You can specify up to 20 region IDs.
        /// </summary>
        [NameInMap("RegionIds")]
        [Validation(Required=false)]
        public List<string> RegionIds { get; set; }

        /// <summary>
        /// The name of the stack group. The name must be unique within a region.\
        /// The name can be up to 255 characters in length and can contain digits, letters, hyphens (-), and underscores (\_). It must start with a digit or a letter.
        /// </summary>
        [NameInMap("StackGroupName")]
        [Validation(Required=false)]
        public string StackGroupName { get; set; }

        /// <summary>
        /// The timeout period within which you can create the stack.
        /// 
        /// *   Default value: 60.
        /// *   Unit: minutes.
        /// </summary>
        [NameInMap("TimeoutInMinutes")]
        [Validation(Required=false)]
        public long? TimeoutInMinutes { get; set; }

    }

}
