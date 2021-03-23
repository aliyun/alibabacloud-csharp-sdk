// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class DescribeDeviceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public DescribeDeviceResponseBodyDeviceInfo DeviceInfo { get; set; }
        public class DescribeDeviceResponseBodyDeviceInfo : TeaModel {
            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }
            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }
            [NameInMap("UsageType")]
            [Validation(Required=false)]
            public int? UsageType { get; set; }
            [NameInMap("UsageTypeDesc")]
            [Validation(Required=false)]
            public string UsageTypeDesc { get; set; }
            [NameInMap("DeviceModel")]
            [Validation(Required=false)]
            public string DeviceModel { get; set; }
            [NameInMap("DeviceModelId")]
            [Validation(Required=false)]
            public long? DeviceModelId { get; set; }
            [NameInMap("DeviceProduct")]
            [Validation(Required=false)]
            public string DeviceProduct { get; set; }
            [NameInMap("DeviceBrandId")]
            [Validation(Required=false)]
            public long? DeviceBrandId { get; set; }
            [NameInMap("DeviceBrand")]
            [Validation(Required=false)]
            public string DeviceBrand { get; set; }
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }
            [NameInMap("Vin")]
            [Validation(Required=false)]
            public string Vin { get; set; }
            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }
            [NameInMap("MacAddress")]
            [Validation(Required=false)]
            public string MacAddress { get; set; }
            [NameInMap("HardwareId")]
            [Validation(Required=false)]
            public string HardwareId { get; set; }
            [NameInMap("SoftwareId")]
            [Validation(Required=false)]
            public string SoftwareId { get; set; }
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public string Attributes { get; set; }
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }
            [NameInMap("OsPlatform")]
            [Validation(Required=false)]
            public string OsPlatform { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
        };

    }

}
