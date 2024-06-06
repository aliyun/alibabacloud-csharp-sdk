// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class PushDeviceDataRequest : TeaModel {
        /// <summary>
        /// The type of the device. [View device type definitions](https://carbon-doc.oss-cn-hangzhou.aliyuncs.com/Deviceappendixes-en.pdf)
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("deviceType")]
        [Validation(Required=false)]
        public string DeviceType { get; set; }

        /// <summary>
        /// List of devices to which data is pushed.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("devices")]
        [Validation(Required=false)]
        public List<PushDeviceDataRequestDevices> Devices { get; set; }
        public class PushDeviceDataRequestDevices : TeaModel {
            /// <summary>
            /// Measuring point information To avoid accuracy problems, the measurement point data is uniformly transmitted to the string. The function of missing required fields cannot be used normally. Some functions may be affected due to the lack of recommend fields. For details, please refer to the notes of equipment measuring points in the appendix. [Reference Point Definition](https://carbon-doc.oss-cn-hangzhou.aliyuncs.com/Deviceappendixes-en.pdf
            /// )
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("data")]
            [Validation(Required=false)]
            public Dictionary<string, object> Data { get; set; }

            /// <summary>
            /// If the deviceType parameter is set to 12, 13, or 17, you must set the system_id parameter. The field name is still device_id. If the deviceType parameter is set to 15 or 16, no Other situations will be transmitted.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("deviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            /// <summary>
            /// Data generation time of measuring point.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("recordTime")]
            [Validation(Required=false)]
            public string RecordTime { get; set; }

        }

    }

}
