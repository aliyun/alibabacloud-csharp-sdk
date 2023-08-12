/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class CancelStackOperationRequest : TeaModel {
        /// <summary>
        /// The operations that you want to cancel on the stack.
        /// </summary>
        [NameInMap("AllowedStackOperations")]
        [Validation(Required=false)]
        public List<string> AllowedStackOperations { get; set; }

        /// <summary>
        /// The method that you want to use to cancel the operations. Valid values:
        /// 
        /// *   Quick: cancels the operations on the stack at the earliest opportunity. In this case, Resource Orchestration Service (ROS) stops scheduling new resources and stops running resources at the earliest opportunity. If you use this method, the resource status may become invalid and subsequent stack operations may be affected.
        /// *   Safe (default): cancels the operations on the stack in a secure manner. In this case, ROS stops scheduling new resources and waits for running resources to be stopped.
        /// </summary>
        [NameInMap("CancelType")]
        [Validation(Required=false)]
        public string CancelType { get; set; }

        /// <summary>
        /// The region ID of the stack. You can call the [DescribeRegions](~~131035~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The stack ID.
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

    }

}
