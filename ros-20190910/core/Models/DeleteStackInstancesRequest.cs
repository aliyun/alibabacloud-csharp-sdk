// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class DeleteStackInstancesRequest : TeaModel {
        /// <summary>
        /// The IDs of the accounts within the self-managed permission model is used to deploy stacks. You can specify up to 20 account IDs.
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
        /// </summary>
        [NameInMap("DeploymentTargets")]
        [Validation(Required=false)]
        public DeleteStackInstancesRequestDeploymentTargets DeploymentTargets { get; set; }
        public class DeleteStackInstancesRequestDeploymentTargets : TeaModel {
            /// <summary>
            /// The IDs of the folders in the resource directory. You can specify up to five folder IDs.
            /// 
            /// You can create stacks within all members in the specified folders. If you create stacks in the Root folder, the stacks are created within all members in the resource directory.
            /// 
            /// >  To view the folder IDs, go to the **Overview** page in the **Resource Management** console. For more information, see [View the basic information of a folder](~~111223~~).
            /// </summary>
            [NameInMap("RdFolderIds")]
            [Validation(Required=false)]
            public List<string> RdFolderIds { get; set; }

        }

        /// <summary>
        /// The description of the operation that you want to perform to delete the stacks.
        /// 
        /// The description must be 1 to 256 characters in length.
        /// </summary>
        [NameInMap("OperationDescription")]
        [Validation(Required=false)]
        public string OperationDescription { get; set; }

        /// <summary>
        /// The settings that you configure to delete the stacks.
        /// 
        /// The following parameters are included:
        /// 
        /// *   {"FailureToleranceCount": N}
        /// 
        ///     The number of accounts within which stack operation failures can occur in each region. If the value of this parameter is exceeded in a region, Resource Orchestration Service (ROS) stops the operation in the region. If the operation is stopped in one region, the operation is no longer performed in other regions.
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
        ///     If you do not specify the FailureTolerancePercentage parameter, the default value 0 is used.
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
        ///     Valid values of N: 1 to 100. If the numeric value in the percentage is not an integer, ROS rounds the value down to the nearest integer.
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
        /// *   You can specify only one of the FailureToleranceCount and FailureTolerancePercentage parameters.
        /// </summary>
        [NameInMap("OperationPreferences")]
        [Validation(Required=false)]
        public Dictionary<string, object> OperationPreferences { get; set; }

        /// <summary>
        /// The ID of the region to which the stack group belongs. You can call the [DescribeRegions](~~131035~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The IDs of the regions from which you want to delete the stacks. You can specify up to 20 region IDs.
        /// </summary>
        [NameInMap("RegionIds")]
        [Validation(Required=false)]
        public List<string> RegionIds { get; set; }

        /// <summary>
        /// Specifies whether to retain the stacks.
        /// 
        /// Valid values:
        /// 
        /// *   true: retains the stacks.
        /// *   false: deletes the stacks.
        /// </summary>
        [NameInMap("RetainStacks")]
        [Validation(Required=false)]
        public bool? RetainStacks { get; set; }

        /// <summary>
        /// The name of the stack group. The name must be unique in a region.
        /// 
        /// The name can be up to 255 characters in length, and can contain digits, letters, hyphens (-), and underscores (\_). The name must start with a digit or letter.
        /// </summary>
        [NameInMap("StackGroupName")]
        [Validation(Required=false)]
        public string StackGroupName { get; set; }

    }

}
