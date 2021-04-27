// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchGetDeviceStateResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("DeviceStatusList")]
        [Validation(Required=false)]
        public BatchGetDeviceStateResponseBodyDeviceStatusList DeviceStatusList { get; set; }
        public class BatchGetDeviceStateResponseBodyDeviceStatusList : TeaModel {
            [NameInMap("DeviceStatus")]
            [Validation(Required=false)]
            public List<BatchGetDeviceStateResponseBodyDeviceStatusListDeviceStatus> DeviceStatus { get; set; }
            public class BatchGetDeviceStateResponseBodyDeviceStatusListDeviceStatus : TeaModel {
                public string DeviceId { get; set; }
                public string DeviceName { get; set; }
                public string Status { get; set; }
                public string AsAddress { get; set; }
                public string LastOnlineTime { get; set; }
                public string IotId { get; set; }
            }
        };

    }

}
