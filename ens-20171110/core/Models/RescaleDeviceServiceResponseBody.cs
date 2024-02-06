// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RescaleDeviceServiceResponseBody : TeaModel {
        /// <summary>
        /// The IDs of the devices.
        /// </summary>
        [NameInMap("DeviceIds")]
        [Validation(Required=false)]
        public List<string> DeviceIds { get; set; }

        /// <summary>
        /// The ID of the order.
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The key properties of the device.
        /// </summary>
        [NameInMap("ResourceDetailInfos")]
        [Validation(Required=false)]
        public List<RescaleDeviceServiceResponseBodyResourceDetailInfos> ResourceDetailInfos { get; set; }
        public class RescaleDeviceServiceResponseBodyResourceDetailInfos : TeaModel {
            /// <summary>
            /// The ID of the device.
            /// </summary>
            [NameInMap("ID")]
            [Validation(Required=false)]
            public string ID { get; set; }

            /// <summary>
            /// The IP address of the device.
            /// </summary>
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            /// <summary>
            /// The Internet service provider (ISP) to which the device belongs.
            /// </summary>
            [NameInMap("ISP")]
            [Validation(Required=false)]
            public string ISP { get; set; }

            /// <summary>
            /// The media access control (MAC) address of the device.
            /// </summary>
            [NameInMap("Mac")]
            [Validation(Required=false)]
            public string Mac { get; set; }

            /// <summary>
            /// The ID of the edge node to which the device belongs.
            /// </summary>
            [NameInMap("RegionID")]
            [Validation(Required=false)]
            public string RegionID { get; set; }

            /// <summary>
            /// The name of the server on which the device is deployed.
            /// </summary>
            [NameInMap("Server")]
            [Validation(Required=false)]
            public string Server { get; set; }

            /// <summary>
            /// The status of the device.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The type of the instance.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
