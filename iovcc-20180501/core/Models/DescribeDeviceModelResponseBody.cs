// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class DescribeDeviceModelResponseBody : TeaModel {
        [NameInMap("DeviceModel")]
        [Validation(Required=false)]
        public DescribeDeviceModelResponseBodyDeviceModel DeviceModel { get; set; }
        public class DescribeDeviceModelResponseBodyDeviceModel : TeaModel {
            [NameInMap("DeviceModelId")]
            [Validation(Required=false)]
            public long? DeviceModelId { get; set; }
            [NameInMap("HardwareType")]
            [Validation(Required=false)]
            public string HardwareType { get; set; }
            [NameInMap("DeviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }
            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }
            [NameInMap("CanCreateDeviceId")]
            [Validation(Required=false)]
            public int? CanCreateDeviceId { get; set; }
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }
            [NameInMap("OsPlatform")]
            [Validation(Required=false)]
            public string OsPlatform { get; set; }
            [NameInMap("DeviceModel")]
            [Validation(Required=false)]
            public string DeviceModel { get; set; }
            [NameInMap("SecurityChip")]
            [Validation(Required=false)]
            public string SecurityChip { get; set; }
            [NameInMap("DeviceLogoUrl")]
            [Validation(Required=false)]
            public string DeviceLogoUrl { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("ObjectKey")]
            [Validation(Required=false)]
            public string ObjectKey { get; set; }
            [NameInMap("InitUsageTypeDesc")]
            [Validation(Required=false)]
            public string InitUsageTypeDesc { get; set; }
            [NameInMap("InitUsageType")]
            [Validation(Required=false)]
            public int? InitUsageType { get; set; }
            [NameInMap("DeviceBrand")]
            [Validation(Required=false)]
            public string DeviceBrand { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
