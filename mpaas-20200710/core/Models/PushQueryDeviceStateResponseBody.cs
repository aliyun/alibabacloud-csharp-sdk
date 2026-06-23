// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20200710.Models
{
    public class PushQueryDeviceStateResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public PushQueryDeviceStateResponseBodyData Data { get; set; }
        public class PushQueryDeviceStateResponseBodyData : TeaModel {
            [NameInMap("DeliveryToken")]
            [Validation(Required=false)]
            public string DeliveryToken { get; set; }

            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            [NameInMap("Manufacturer")]
            [Validation(Required=false)]
            public string Manufacturer { get; set; }

            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            [NameInMap("Statue")]
            [Validation(Required=false)]
            public string Statue { get; set; }

            [NameInMap("ThirdToken")]
            [Validation(Required=false)]
            public string ThirdToken { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
