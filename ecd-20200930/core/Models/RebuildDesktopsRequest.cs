// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class RebuildDesktopsRequest : TeaModel {
        /// <summary>
        /// The IDs of the cloud computers. You can specify 1 to 20 IDs.
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public List<string> DesktopId { get; set; }

        /// <summary>
        /// The ID of the new image.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The operation type on the data disk.
        /// 
        /// >  This parameter is empty by default regardless of whether data disks are attached to the cloud computer.
        /// 
        /// *   No data disks are attached to the cloud computer:\
        ///     No operation is performed on the data disks of the cloud computer regardless of the value of this parameter.
        /// 
        /// *   Data disks are attached to the cloud computer:
        /// 
        ///     1.  The OS of the cloud computer is the same as the OS of the destination image:
        /// 
        ///         *   If you set the OperateType parameter to `replace`, the data in the data disks of the cloud computer is replaced.
        ///         *   If you leave the OperateType parameter empty, the data in the data disks of the cloud computer is retained.
        /// 
        ///     2.  The OS of the cloud computer is different from the OS of the destination image:
        /// 
        ///         *   If you set the OperateType parameter to `replace`, the data in the data disks of the cloud computer is replaced.
        ///         *   If you leave the OperateType parameter empty, the data in the data disks of the cloud computer is cleared.
        /// </summary>
        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](~~196646~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
