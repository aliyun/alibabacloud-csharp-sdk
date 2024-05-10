// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetStackRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests.\\
        /// The token can be up to 64 characters in length.\\
        /// For more information, see [Ensure idempotence](https://help.aliyun.com/document_detail/134212.html).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The option for returning logs. Valid values:
        /// 
        /// *   None: does not return logs.
        /// *   Stack (default): returns the logs of the stack.
        /// *   Resource: returns the logs of resources in the stack.
        /// *   All: returns all logs.
        /// </summary>
        [NameInMap("LogOption")]
        [Validation(Required=false)]
        public string LogOption { get; set; }

        /// <summary>
        /// Specifies whether to return Outputs. Valid values:
        /// 
        /// *   Enabled (default)
        /// *   Disabled
        /// 
        /// >  The Outputs parameter requires a long period of time to calculate. If you do not require Outputs of the stack, we recommend that you set OutputOption to Disabled to improve the response speed of the GetStack operation.
        /// </summary>
        [NameInMap("OutputOption")]
        [Validation(Required=false)]
        public string OutputOption { get; set; }

        /// <summary>
        /// The region ID of the stack. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/131035.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Specifies whether to return information about ResourceProgress. Valid values:
        /// 
        /// *   Disabled (default): does not return information about ResourceProgress.
        /// *   PercentageOnly: returns StackOperationProgress and StackActionProgress of ResourceProgress.
        /// 
        /// >  ROS and Terraform stacks are supported. Creation, resumed creation, update, deletion, import, and rollback operations on stacks are supported.
        /// 
        /// *   EnabledIfCreateStack (not recommend): returns \\*Count and InProgressResourceDetails of ResourceProgress only during a stack creation operation.
        /// 
        /// >  During a creation operation, a stack is in one of the following states: CREATE_IN_PROGRESS, CREATE_COMPLETE, CREATE_FAILED, CREATE_ROLLBACK_IN_PROGRESS, CREATE_ROLLBACK_COMPLETE, and CREATE_ROLLBACK_FAILED.
        /// </summary>
        [NameInMap("ShowResourceProgress")]
        [Validation(Required=false)]
        public string ShowResourceProgress { get; set; }

        /// <summary>
        /// The stack ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

    }

}
