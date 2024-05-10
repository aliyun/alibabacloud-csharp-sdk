// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class DetectStackGroupDriftShrinkRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests.
        /// 
        /// The value can be up to 64 characters in length and can contain letters, digits, hyphens (-), and underscores (_).
        /// 
        /// For more information, see [How to ensure idempotence](https://help.aliyun.com/document_detail/134212.html).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The operation settings, in JSON format. The following fields are supported:
        /// 
        /// *   FailureToleranceCount
        /// 
        /// The maximum number of stack group operation failures that can occur. In a stack group operation, if the total number of failures does not exceed the FailureToleranceCount value, the operation succeeds. Otherwise, the operation fails.
        /// 
        /// If FailureToleranceCount is not specified, the default value 0 is used. You can specify one of FailureToleranceCount or FailureTolerancePercentage parameters, but you cannot specify both of them.
        /// 
        /// Valid values: 0 to 20.
        /// 
        /// *   FailureTolerancePercentage
        /// 
        /// The percentage of stack group operation failures that can occur. In a stack group operation, if the percentage of failures does not exceed the FailureTolerancePercentage value, the operation succeeds. Otherwise, the operation fails.
        /// 
        /// You can specify one of FailureToleranceCount or FailureTolerancePercentage parameters, but you cannot specify both of them.
        /// 
        /// Valid values: 0 to 100.
        /// 
        /// *   MaxConcurrentCount
        /// 
        /// The maximum number of target accounts in which a drift detection operation can be performed at a time.
        /// 
        /// You can specify one of MaxConcurrentCount or MaxConcurrentPercentage parameters, but you cannot specify both of them.
        /// 
        /// Valid values: 1 to 20.
        /// 
        /// *   MaxConcurrentPercentage
        /// 
        /// The maximum percentage of target accounts in which a drift detection operation can be performed at a time.
        /// 
        /// You can specify one of MaxConcurrentCount or MaxConcurrentPercentage parameters, but you cannot specify both of them.
        /// 
        /// Valid values: 1 to 100.
        /// </summary>
        [NameInMap("OperationPreferences")]
        [Validation(Required=false)]
        public string OperationPreferencesShrink { get; set; }

        /// <summary>
        /// The region ID of the stack group. You can call the [DescribeRegions](~~131035#doc-api-ROS-DescribeRegions~~ "Queries the DescribeRegions list of a region.") operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The name of the stack group. The name must be unique in a region.
        /// 
        /// The name can be up to 255 characters in length and can contain digits, letters, hyphens (-), and underscores (_). It must start with a digit or letter.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StackGroupName")]
        [Validation(Required=false)]
        public string StackGroupName { get; set; }

    }

}
