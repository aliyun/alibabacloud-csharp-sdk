// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class CheckDevicesResponseBody : TeaModel {
        [NameInMap("DeviceCheckInfos")]
        [Validation(Required=false)]
        public CheckDevicesResponseBodyDeviceCheckInfos DeviceCheckInfos { get; set; }
        public class CheckDevicesResponseBodyDeviceCheckInfos : TeaModel {
            [NameInMap("DeviceCheckInfo")]
            [Validation(Required=false)]
            public List<CheckDevicesResponseBodyDeviceCheckInfosDeviceCheckInfo> DeviceCheckInfo { get; set; }
            public class CheckDevicesResponseBodyDeviceCheckInfosDeviceCheckInfo : TeaModel {
                public bool? Available { get; set; }
                public string DeviceId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
