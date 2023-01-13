// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class RegisterDeviceRequest : TeaModel {
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        [NameInMap("DevEui")]
        [Validation(Required=false)]
        public string DevEui { get; set; }

        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("JoinEui")]
        [Validation(Required=false)]
        public string JoinEui { get; set; }

        [NameInMap("LoraNodeType")]
        [Validation(Required=false)]
        public string LoraNodeType { get; set; }

        [NameInMap("Nickname")]
        [Validation(Required=false)]
        public string Nickname { get; set; }

        [NameInMap("PinCode")]
        [Validation(Required=false)]
        public string PinCode { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=true)]
        public string ProductKey { get; set; }

    }

}
