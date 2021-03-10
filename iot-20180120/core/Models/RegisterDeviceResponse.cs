// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class RegisterDeviceResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public RegisterDeviceResponseData Data { get; set; }
        public class RegisterDeviceResponseData : TeaModel {
            [NameInMap("IotId")]
            [Validation(Required=true)]
            public string IotId { get; set; }
            [NameInMap("ProductKey")]
            [Validation(Required=true)]
            public string ProductKey { get; set; }
            [NameInMap("DeviceName")]
            [Validation(Required=true)]
            public string DeviceName { get; set; }
            [NameInMap("DeviceSecret")]
            [Validation(Required=true)]
            public string DeviceSecret { get; set; }
            [NameInMap("DevEui")]
            [Validation(Required=true)]
            public string DevEui { get; set; }
            [NameInMap("JoinEui")]
            [Validation(Required=true)]
            public string JoinEui { get; set; }
            [NameInMap("Nickname")]
            [Validation(Required=true)]
            public string Nickname { get; set; }
        };

    }

}
