// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ResetDesktopsRequest : TeaModel {
        /// <summary>
        /// The ID of the cloud computer pool. If you specify the `DesktopId` parameter, ignore the `DesktopGroupId` parameter. If you do not specify the `DesktopId` parameter, specify the `DesktopGroupId` parameter in the call to request all IDs of the cloud computers in the specified pool.
        /// </summary>
        [NameInMap("DesktopGroupId")]
        [Validation(Required=false)]
        public string DesktopGroupId { get; set; }

        /// <summary>
        /// The IDs of the cloud computer pools.
        /// </summary>
        [NameInMap("DesktopGroupIds")]
        [Validation(Required=false)]
        public List<string> DesktopGroupIds { get; set; }

        /// <summary>
        /// The IDs of the cloud computers. You can specify the IDs of 1 to 100 cloud computers.
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public List<string> DesktopId { get; set; }

        /// <summary>
        /// The ID of the image.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The billing method.
        /// 
        /// > This parameter is available only when you reset cloud computer pools. If you leave this parameter empty, all cloud computers in the specified cloud computer pool are reset, regardless of how the cloud computers are billed.
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/436773.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The reset scope. You can configure this parameter to reset the image or cloud computer.
        /// 
        /// Valid values:
        /// 
        /// *   ALL (default): resets the image and cloud computer.
        /// *   IMAGE: resets only the image.
        /// </summary>
        [NameInMap("ResetScope")]
        [Validation(Required=false)]
        public string ResetScope { get; set; }

        /// <summary>
        /// The disk reset type.
        /// 
        /// Valid values:
        /// 
        /// *   0: does not reset disks.
        /// *   1: resets only the system disk.
        /// *   2: resets only the user disk.
        /// *   3: resets the system disk and the user disk.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResetType")]
        [Validation(Required=false)]
        public string ResetType { get; set; }

    }

}
