// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class RefreshDeviceCredentialResponseBody : TeaModel {
        /// <summary>
        /// The access credential of the device.
        /// </summary>
        [NameInMap("DeviceCredential")]
        [Validation(Required=false)]
        public RefreshDeviceCredentialResponseBodyDeviceCredential DeviceCredential { get; set; }
        public class RefreshDeviceCredentialResponseBodyDeviceCredential : TeaModel {
            /// <summary>
            /// The client ID of the device.
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// The timestamp that indicates when the access credential of the device was created. The value of this parameter is a UNIX timestamp in milliseconds.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The AccessKey ID of the device.
            /// </summary>
            [NameInMap("DeviceAccessKeyId")]
            [Validation(Required=false)]
            public string DeviceAccessKeyId { get; set; }

            /// <summary>
            /// The AccessKey secret of the device.
            /// </summary>
            [NameInMap("DeviceAccessKeySecret")]
            [Validation(Required=false)]
            public string DeviceAccessKeySecret { get; set; }

            /// <summary>
            /// The ID of the ApsaraMQ for MQTT instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The timestamp that indicates when the access credential of the device was last updated. The value of this parameter is a UNIX timestamp in milliseconds.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// The request ID. This parameter is a common parameter.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
