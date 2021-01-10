// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class ConnectAssistDeviceRequest : TeaModel {
        [NameInMap("HardwareId")]
        [Validation(Required=false)]
        public string HardwareId { get; set; }

        [NameInMap("AllowCommandExtension")]
        [Validation(Required=false)]
        public bool? AllowCommandExtension { get; set; }

        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        [NameInMap("SerialNumber")]
        [Validation(Required=false)]
        public string SerialNumber { get; set; }

        [NameInMap("VIN")]
        [Validation(Required=false)]
        public string VIN { get; set; }

        [NameInMap("UUID")]
        [Validation(Required=false)]
        public string UUID { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

    }

}
