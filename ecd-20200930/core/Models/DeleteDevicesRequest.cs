// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DeleteDevicesRequest : TeaModel {
        /// <summary>
        /// The type of the device.
        /// 
        /// *   1: the hardware client device
        /// *   2: the software client device
        /// </summary>
        [NameInMap("ClientType")]
        [Validation(Required=false)]
        public int? ClientType { get; set; }

        /// <summary>
        /// The list of universally unique identifiers (UUIDs) of devices.
        /// </summary>
        [NameInMap("DeviceIds")]
        [Validation(Required=false)]
        public List<string> DeviceIds { get; set; }

        /// <summary>
        /// Specifies whether to forcefully delete the device.
        /// 
        /// *   1: forcefully deletes the device.
        /// *   0: does not forcefully delete the device. (You cannot delete a device to which a user is bound.)
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public int? Force { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
