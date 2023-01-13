// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ReBindLicenseDeviceRequest : TeaModel {
        [NameInMap("DeviceNameList")]
        [Validation(Required=true)]
        public List<string> DeviceNameList { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("LicenseCode")]
        [Validation(Required=true)]
        public string LicenseCode { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=true)]
        public string ProductKey { get; set; }

    }

}
