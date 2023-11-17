// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20230630.Models
{
    public class UnbindDeviceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public UnbindDeviceResponseBodyData Data { get; set; }
        public class UnbindDeviceResponseBodyData : TeaModel {
            [NameInMap("SubDeviceUnbindResult")]
            [Validation(Required=false)]
            public List<UnbindDeviceResponseBodyDataSubDeviceUnbindResult> SubDeviceUnbindResult { get; set; }
            public class UnbindDeviceResponseBodyDataSubDeviceUnbindResult : TeaModel {
                [NameInMap("DeviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                [NameInMap("IotId")]
                [Validation(Required=false)]
                public string IotId { get; set; }

                [NameInMap("ProductKey")]
                [Validation(Required=false)]
                public string ProductKey { get; set; }

                [NameInMap("UnbindResultCode")]
                [Validation(Required=false)]
                public int? UnbindResultCode { get; set; }

                [NameInMap("UnbindResultMessage")]
                [Validation(Required=false)]
                public string UnbindResultMessage { get; set; }

            }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
