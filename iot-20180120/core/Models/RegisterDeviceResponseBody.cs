// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class RegisterDeviceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public RegisterDeviceResponseBodyData Data { get; set; }
        public class RegisterDeviceResponseBodyData : TeaModel {
            [NameInMap("IotId")]
            [Validation(Required=false)]
            public string IotId { get; set; }
            [NameInMap("ProductKey")]
            [Validation(Required=false)]
            public string ProductKey { get; set; }
            [NameInMap("DeviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }
            [NameInMap("DeviceSecret")]
            [Validation(Required=false)]
            public string DeviceSecret { get; set; }
            [NameInMap("DevEui")]
            [Validation(Required=false)]
            public string DevEui { get; set; }
            [NameInMap("JoinEui")]
            [Validation(Required=false)]
            public string JoinEui { get; set; }
            [NameInMap("Nickname")]
            [Validation(Required=false)]
            public string Nickname { get; set; }
        };

    }

}
