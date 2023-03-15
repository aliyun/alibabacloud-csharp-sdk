// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class CancelUpdateStackRequest : TeaModel {
        /// <summary>
        /// The method to cancel the update operation. Valid values:
        /// 
        /// *   Quick: cancels the update of a stack as soon as possible.
        /// *   Safe: cancels the update of a stack as safely as possible.
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
        /// The ID of the stack.
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

    }

}
