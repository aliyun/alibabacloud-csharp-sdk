// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class ListAssistDevicesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PerPage")]
        [Validation(Required=false)]
        public int? PerPage { get; set; }

        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        [NameInMap("Devices")]
        [Validation(Required=false)]
        public List<ListAssistDevicesResponseBodyDevices> Devices { get; set; }
        public class ListAssistDevicesResponseBodyDevices : TeaModel {
            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            [NameInMap("HardwareId")]
            [Validation(Required=false)]
            public string HardwareId { get; set; }

            [NameInMap("DeviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            [NameInMap("AccessTime")]
            [Validation(Required=false)]
            public long? AccessTime { get; set; }

            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            [NameInMap("UUID")]
            [Validation(Required=false)]
            public string UUID { get; set; }

            [NameInMap("VIN")]
            [Validation(Required=false)]
            public string VIN { get; set; }

        }

    }

}
