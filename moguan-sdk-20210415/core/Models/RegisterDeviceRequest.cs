/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Moguan_sdk20210415.Models
{
    public class RegisterDeviceRequest : TeaModel {
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        [NameInMap("Extend")]
        [Validation(Required=false)]
        public Dictionary<string, object> Extend { get; set; }

        [NameInMap("SdkCode")]
        [Validation(Required=false)]
        public string SdkCode { get; set; }

        [NameInMap("UserDeviceId")]
        [Validation(Required=false)]
        public string UserDeviceId { get; set; }

    }

}
