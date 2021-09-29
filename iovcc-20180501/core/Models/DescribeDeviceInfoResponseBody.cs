// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class DescribeDeviceInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public DescribeDeviceInfoResponseBodyDeviceInfo DeviceInfo { get; set; }
        public class DescribeDeviceInfoResponseBodyDeviceInfo : TeaModel {
            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("DeviceModelId")]
            [Validation(Required=false)]
            public long? DeviceModelId { get; set; }
            [NameInMap("MacAddress")]
            [Validation(Required=false)]
            public string MacAddress { get; set; }
            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }
            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }
            [NameInMap("DeviceModel")]
            [Validation(Required=false)]
            public string DeviceModel { get; set; }
            [NameInMap("UsageType")]
            [Validation(Required=false)]
            public int? UsageType { get; set; }
            [NameInMap("Vin")]
            [Validation(Required=false)]
            public string Vin { get; set; }
            [NameInMap("UsageTypeDesc")]
            [Validation(Required=false)]
            public string UsageTypeDesc { get; set; }
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }
            [NameInMap("HardwareId")]
            [Validation(Required=false)]
            public string HardwareId { get; set; }
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }
            [NameInMap("SoftwareId")]
            [Validation(Required=false)]
            public string SoftwareId { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("DeviceBrand")]
            [Validation(Required=false)]
            public string DeviceBrand { get; set; }
        };

    }

}
