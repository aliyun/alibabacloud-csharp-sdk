// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetStackInstanceRequest : TeaModel {
        /// <summary>
        /// Specifies whether to return the Outputs parameter. The Outputs parameter specifies the outputs of the stack. Valid values:
        /// 
        /// *   Enabled: returns the Outputs parameter.
        /// *   Disabled (default): does not return the Outputs parameter.
        /// 
        /// >  The Outputs parameter requires a long period of time to calculate. If you do not require the outputs of the stack, we recommend that you set OutputOption to Disabled to improve the response speed of the API operation.
        /// </summary>
        [NameInMap("OutputOption")]
        [Validation(Required=false)]
        public string OutputOption { get; set; }

        /// <summary>
        /// The region ID of the stack group. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/131035.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The name of the stack group. The name must be unique within a region.\\
        /// The name can be up to 255 characters in length, and can contain digits, letters, hyphens (-), and underscores (_). It must start with a digit or letter.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StackGroupName")]
        [Validation(Required=false)]
        public string StackGroupName { get; set; }

        /// <summary>
        /// The ID of the destination account to which the stack belongs.
        /// 
        /// *   If the stack group is granted self-managed permissions, the stack belongs to an Alibaba Cloud account.
        /// *   If the stack group is granted service-managed permissions, the stack belongs to a member in a resource directory.
        /// 
        /// > For more information about the destination account, see [Overview](https://help.aliyun.com/document_detail/154578.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StackInstanceAccountId")]
        [Validation(Required=false)]
        public string StackInstanceAccountId { get; set; }

        /// <summary>
        /// The region ID of the stack.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StackInstanceRegionId")]
        [Validation(Required=false)]
        public string StackInstanceRegionId { get; set; }

    }

}
