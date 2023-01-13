// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ImportDeviceRequest : TeaModel {
        [NameInMap("DeviceName")]
        [Validation(Required=true)]
        public string DeviceName { get; set; }

        [NameInMap("DeviceSecret")]
        [Validation(Required=true)]
        public string DeviceSecret { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("Nickname")]
        [Validation(Required=false)]
        public string Nickname { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=true)]
        public string ProductKey { get; set; }

        [NameInMap("Sn")]
        [Validation(Required=false)]
        public string Sn { get; set; }

    }

}
