// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class UpdateStackInstancesRequest : TeaModel {
        /// <summary>
        /// The IDs of the accounts within which the self-managed permission model is used to deploy stacks. You can specify up to 20 account IDs.
        /// 
        /// >  This parameter is required if you use the self-managed permission model to update the stacks.
        /// </summary>
        [NameInMap("AccountIds")]
        [Validation(Required=false)]
        public List<string> AccountIds { get; set; }

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
        /// The folders in which the service-managed permission model is used to deploy stacks.
        /// 
        /// >  This parameter is required if you use the service-managed permission model to update the stacks.
        /// </summary>
        [NameInMap("DeploymentTargets")]
        [Validation(Required=false)]
        public UpdateStackInstancesRequestDeploymentTargets DeploymentTargets { get; set; }
        public class UpdateStackInstancesRequestDeploymentTargets : TeaModel {
            /// <summary>
            /// The IDs of the members in the resource directory. You can specify up to 20 member IDs.
            /// 
            /// >  To view the member IDs, go to the **Overview** page in the **Resource Management** console. For more information, see [View the detailed information of a member](~~111624~~).
            /// </summary>
            [NameInMap("AccountIds")]
            [Validation(Required=false)]
            public List<string> AccountIds { get; set; }

            /// <summary>
            /// The IDs of the folders in the resource directory. You can specify up to five folder IDs.
            /// 
            /// You must specify at least one of the RdFolderIds and AccountIds parameters. The parameters are subject to the following rules:
            /// 
            /// *   If you specify only the RdFolderIds parameter, stacks are deployed within all members in the specified folders. If you select the Root folder, stacks are deployed within all members in the resource directory.
            /// *   If you specify only the AccountIds parameter, stacks are deployed within the specified members.
            /// *   If you specify both parameters, the accounts specified by using the AccountIds parameter must be contained in the folders specified by using the RdFolderIds parameter. In this case, stacks are deployed within the specified members that are contained in the specified folders.
            /// 
            /// >  To view the folder IDs, go to the **Overview** page in the **Resource Management** console. For more information, see [View the basic information of a folder](~~111223~~).
            /// </summary>
            [NameInMap("RdFolderIds")]
            [Validation(Required=false)]
            public List<string> RdFolderIds { get; set; }

        }

        /// <summary>
        /// The description of the operation that you want to perform to update the stacks.
        /// 
        /// The description must be 1 to 256 characters in length.
        /// </summary>
        [NameInMap("OperationDescription")]
        [Validation(Required=false)]
        public string OperationDescription { get; set; }

        /// <summary>
        /// The custom preferences on how Resource Orchestration Service (ROS) updates the stacks.
        /// 
        /// The following parameters are included:
        /// 
        /// *   {"FailureToleranceCount": N}
        /// 
        ///     The number of accounts within which stack operation failures can occur in each region. If the value of this parameter is exceeded in a region, ROS stops the operation in the region. If the operation is stopped in one region, the operation is no longer performed in other regions.
        /// 
        ///     Valid values of N: 0 to 20.
        /// 
        ///     If you do not specify the FailureToleranceCount parameter, the default value 0 is used.
        /// 
        /// *   {"FailureTolerancePercentage": N}
        /// 
        ///     The percentage of the number of accounts within which stack operation failures can occur to the total number of accounts in each region. If the value of this parameter is exceeded in a region, ROS stops the operation in the region.
        /// 
        ///     Valid values of N: 0 to 100. If the numeric value in the percentage is not an integer, ROS rounds the value down to the nearest integer.
        /// 
        ///     If you do not specify a value for the FailureTolerancePercentage parameter, the default value 0 is used.
        /// 
        /// *   {"MaxConcurrentCount": N}
        /// 
        ///     The maximum number of accounts within which stacks are deployed at the same time in each region.
        /// 
        ///     Valid values of N: 1 to 20.
        /// 
        ///     If you do not specify the MaxConcurrentCount parameter, the default value 1 is used.
        /// 
        /// *   {"MaxConcurrentPercentage": N}
        /// 
        ///     The percentage of the maximum number of accounts within which stacks are deployed at the same time to the total number of accounts in each region.
        /// 
        ///     Valid values: 1 to 100. If the numeric value in the percentage is not an integer, ROS rounds the value down to the nearest integer.
        /// 
        ///     If you do not specify the MaxConcurrentPercentage parameter, the default value 1 is used.
        /// 
        /// *   {"RegionConcurrencyType": N}
        /// 
        ///     The mode that you want to use to deploy stacks across regions. Default value: SEQUENTIAL. Valid values:
        /// 
        ///     *   SEQUENTIAL: deploys stacks in each specified region based on the specified sequence of regions. ROS deploys stacks in one region at a time.
        ///     *   PARALLEL: deploys stacks in parallel in all specified regions.
        /// 
        /// Separate multiple parameters with commas (,).
        /// 
        /// > 
        /// *   You can specify only one of the MaxConcurrentCount and MaxConcurrentPercentage parameters.
        /// *   You can specify one of the FailureToleranceCount and FailureTolerancePercentage parameters.
        /// </summary>
        [NameInMap("OperationPreferences")]
        [Validation(Required=false)]
        public Dictionary<string, object> OperationPreferences { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [NameInMap("ParameterOverrides")]
        [Validation(Required=false)]
        public List<UpdateStackInstancesRequestParameterOverrides> ParameterOverrides { get; set; }
        public class UpdateStackInstancesRequestParameterOverrides : TeaModel {
            /// <summary>
            /// The name of parameter N that you want to use to override a specific parameter. If you do not specify the name of parameter N, ROS uses the name that you specify when you create the stack group.
            /// 
            /// Maximum value of N: 200.
            /// 
            /// > 
            /// *   The ParameterOverrides parameter is optional.
            /// *   If you specify the ParameterOverrides parameter, you must specify the ParameterOverrides.N.ParameterKey and ParameterOverrides.N.ParameterValue parameters.
            /// </summary>
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            /// <summary>
            /// The value of parameter N that you want to use to override a specific parameter. If you do not specify the name and value of parameter N, ROS uses the name and value that you specify when you create the stack group.
            /// 
            /// Maximum value of N: 200.
            /// 
            /// > 
            /// *   The ParameterOverrides parameter is optional.
            /// *   If you specify the ParameterOverrides parameter, you must specify the ParameterOverrides.N.ParameterKey and ParameterOverrides.N.ParameterValue parameters.
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        /// <summary>
        /// The ID of the region to which the stack group belongs. You can call the [DescribeRegions](~~131035~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The IDs of the regions in which you want to update the stacks. You can specify up to 20 region IDs.
        /// </summary>
        [NameInMap("RegionIds")]
        [Validation(Required=false)]
        public List<string> RegionIds { get; set; }

        /// <summary>
        /// The name of the stack group. The name must be unique in a region.
        /// 
        /// The name can be up to 255 characters in length, and can contain digits, letters, hyphens (-), and underscores (\_). The name must start with a digit or letter.
        /// </summary>
        [NameInMap("StackGroupName")]
        [Validation(Required=false)]
        public string StackGroupName { get; set; }

        /// <summary>
        /// The timeout period for the update operation on the stack.
        /// 
        /// *   Default value: 60.
        /// *   Unit: minutes.
        /// </summary>
        [NameInMap("TimeoutInMinutes")]
        [Validation(Required=false)]
        public long? TimeoutInMinutes { get; set; }

    }

}
