// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DeleteDevicesRequest : TeaModel {
        /// <summary>
        /// The type of the client.
        /// 
        /// Valid values:
        /// 
        /// *   1: hardware client.
        /// *   2: software client.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClientType")]
        [Validation(Required=false)]
        public int? ClientType { get; set; }

        /// <summary>
        /// The IDs of the devices. You can specify up to 200 IDs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DeviceIds")]
        [Validation(Required=false)]
        public List<string> DeviceIds { get; set; }

        /// <summary>
        /// Specifies whether to forcefully delete the device if the device is bound to a user.
        /// 
        /// Valid values:
        /// 
        /// *   0: do not forcefully delete the device.
        /// *   1: forcefully delete the device.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public int? Force { get; set; }

        /// <summary>
        /// The ID of the region. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/196646.html) operation to query the regions supported by WUYING Workspace.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
