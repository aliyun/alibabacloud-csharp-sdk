// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class RebuildDesktopsRequest : TeaModel {
        /// <summary>
        /// The IDs of the cloud desktops.
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
        /// > For cloud desktops that do not have data disks, when you call this operation, you do not need to configure this parameter.
        /// 
        /// *   Cloud desktops do not have data disks\
        ///     The values that you configured have no impacts.
        /// 
        /// *   Cloud desktops have data disks
        /// 
        ///     1.  If the OS of the cloud desktop is the same as the OS of a destination image:
        /// 
        ///         *   The value replace indicates that the data disk of the cloud desktop is replaced.
        ///         *   If you do not specify this parameter, the data disk of the cloud desktop is retained.
        /// 
        ///     2.  If the OS of the cloud desktop is the different from the OS of a destination image:
        /// 
        ///         *   The value replace indicates that the data disk of the cloud desktop is replaced.
        ///         *   If you do not specify this parameter, the data disk of the cloud desktop is cleared.
        /// </summary>
        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
