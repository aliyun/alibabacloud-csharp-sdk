// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class SetDeletionProtectionRequest : TeaModel {
        /// <summary>
        /// Indicates whether stack deletion protection is enabled. Valid values:
        /// 
        /// *   Enabled: enables the stack deletion protection.
        /// *   Disabled (default): Resource stack deletion protection is Disabled. You can use the console or API(DeleteStack) to release the stack resources.
        /// 
        /// >  The deletion of nested stacks is the same as the root stack.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public string DeletionProtection { get; set; }

        /// <summary>
        /// The region ID of the stack. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/131035.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the stack.
        /// 
        /// The delete protection attribute of a nested stack is determined by the root stack and remains unchanged from the root stack.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

    }

}
