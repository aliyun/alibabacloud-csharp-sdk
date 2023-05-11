// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchAddDeviceGroupRelationsRequest : TeaModel {
        [NameInMap("Device")]
        [Validation(Required=false)]
        public List<BatchAddDeviceGroupRelationsRequestDevice> Device { get; set; }
        public class BatchAddDeviceGroupRelationsRequestDevice : TeaModel {
            /// <summary>
            /// The error message returned if the call fails.
            /// </summary>
            [NameInMap("DeviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            /// <summary>
            /// The names of the devices to be added. You can specify a maximum of 200 devices.
            /// </summary>
            [NameInMap("ProductKey")]
            [Validation(Required=false)]
            public string ProductKey { get; set; }

        }

        /// <summary>
        /// The ProductKeys of the products to which the devices belong. You can specify a maximum of 200 ProductKeys.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The ID of the group. The ID is the globally unique identifier (GUID) for the group.
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

    }

}
