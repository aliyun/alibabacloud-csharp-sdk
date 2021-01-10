// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class CreateDeviceModelRequest : TeaModel {
        [NameInMap("InitUsageType")]
        [Validation(Required=false)]
        public string InitUsageType { get; set; }

        [NameInMap("CanCreateDeviceId")]
        [Validation(Required=false)]
        public string CanCreateDeviceId { get; set; }

        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        [NameInMap("HardwareType")]
        [Validation(Required=false)]
        public string HardwareType { get; set; }

        [NameInMap("BrandName")]
        [Validation(Required=false)]
        public string BrandName { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DeviceType")]
        [Validation(Required=false)]
        public string DeviceType { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("SecurityChip")]
        [Validation(Required=false)]
        public string SecurityChip { get; set; }

        [NameInMap("OsPlatform")]
        [Validation(Required=false)]
        public string OsPlatform { get; set; }

        [NameInMap("ObjectKey")]
        [Validation(Required=false)]
        public string ObjectKey { get; set; }

        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

    }

}
