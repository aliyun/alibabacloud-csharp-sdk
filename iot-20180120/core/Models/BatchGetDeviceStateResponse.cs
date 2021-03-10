// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchGetDeviceStateResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("DeviceStatusList")]
        [Validation(Required=true)]
        public BatchGetDeviceStateResponseDeviceStatusList DeviceStatusList { get; set; }
        public class BatchGetDeviceStateResponseDeviceStatusList : TeaModel {
            [NameInMap("DeviceStatus")]
            [Validation(Required=true)]
            public List<BatchGetDeviceStateResponseDeviceStatusListDeviceStatus> DeviceStatus { get; set; }
            public class BatchGetDeviceStateResponseDeviceStatusListDeviceStatus : TeaModel {
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
