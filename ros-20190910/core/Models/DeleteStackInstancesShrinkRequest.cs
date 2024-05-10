// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class DeleteStackInstancesShrinkRequest : TeaModel {
        /// <summary>
        /// The IDs of the execution accounts within which you want to deploy stacks in self-managed mode. You can specify up to 20 execution account IDs.
        /// </summary>
        [NameInMap("AccountIds")]
        [Validation(Required=false)]
        public string AccountIdsShrink { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests.\\
        /// The token can contain letters, digits, hyphens (-), and underscores (_), and cannot exceed 64 characters in length.\\
        /// For more information, see [How to ensure idempotence](https://help.aliyun.com/document_detail/134212.html).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The folders in which you want to deploy stacks in service-managed mode.
        /// </summary>
        [NameInMap("DeploymentTargets")]
        [Validation(Required=false)]
        public string DeploymentTargetsShrink { get; set; }

        /// <summary>
        /// The description of the delete operation.
        /// 
        /// The description must be 1 to 256 characters in length.
        /// </summary>
        [NameInMap("OperationDescription")]
        [Validation(Required=false)]
        public string OperationDescription { get; set; }

        /// <summary>
        /// The preference settings of the delete operation.
        /// 
        /// The following parameters are available:
        /// 
        /// -  {"FailureToleranceCount": N}
        /// 
        ///     The number of accounts within which stack operation failures are allowed in each region. If the value of this parameter is exceeded in a region, ROS stops the operation in the region. If ROS stops the operation in one region, ROS stops the operation in other regions.
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
        ///     The maximum number of accounts within which multiple stacks are deployed at the same time in each region.
        /// 
        ///     Valid values of N: 1 to 20.
        /// 
        ///     If you do not specify MaxConcurrentCount, 1 is used as the default value.
        /// 
        /// -  {"MaxConcurrentPercentage": N}
        /// 
        ///     The percentage of the maximum number of accounts within which stacks are deployed at the same time to the total number of accounts in each region.
        /// 
        ///     Valid values of N: 1 to 100. If the numeric value in the percentage is not an integer, ROS rounds the number down to the nearest integer.
        /// 
        ///     If you do not specify MaxConcurrentPercentage, 1 is used as the default value.
        /// 
        /// -   {"RegionConcurrencyType": N}
        /// 
        ///     The mode that you want to use to deploy stacks across regions. Valid values:
        ///     - SEQUENTIAL (default): deploys stacks in the specified regions one by one in sequence. This way, ROS deploys stacks in only one region at a time. 
        /// 
        ///      - PARALLEL: deploys stacks in all the specified regions in parallel. 
        /// 
        /// Separate multiple parameters with commas (,).
        /// 
        /// > - You can specify only one of the following parameters: MaxConcurrentCount and MaxConcurrentPercentage.
        /// > - You can specify only one of the following parameters: FailureToleranceCount and FailureTolerancePercentage.
        /// </summary>
        [NameInMap("OperationPreferences")]
        [Validation(Required=false)]
        public string OperationPreferencesShrink { get; set; }

        /// <summary>
        /// The region ID of the stack group. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/131035.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The IDs of the regions where you want to delete the stacks. You can specify up to 20 region IDs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionIds")]
        [Validation(Required=false)]
        public string RegionIdsShrink { get; set; }

        /// <summary>
        /// Specifies whether to delete the stacks.
        /// 
        /// Valid values:
        /// 
        /// *   true: retains the stacks.
        /// *   false: deletes the stacks.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RetainStacks")]
        [Validation(Required=false)]
        public bool? RetainStacks { get; set; }

        /// <summary>
        /// The name of the stack group. The name must be unique within a region.\\
        /// The name can be up to 255 characters in length and can contain digits, letters, hyphens (-), and underscores (_). It must start with a digit or a letter.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StackGroupName")]
        [Validation(Required=false)]
        public string StackGroupName { get; set; }

    }

}
