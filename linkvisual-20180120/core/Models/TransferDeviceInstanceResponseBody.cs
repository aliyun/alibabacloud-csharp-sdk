// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class TransferDeviceInstanceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public TransferDeviceInstanceResponseBodyData Data { get; set; }
        public class TransferDeviceInstanceResponseBodyData : TeaModel {
            [NameInMap("FailedList")]
            [Validation(Required=false)]
            public List<TransferDeviceInstanceResponseBodyDataFailedList> FailedList { get; set; }
            public class TransferDeviceInstanceResponseBodyDataFailedList : TeaModel {
                [NameInMap("DeviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            [NameInMap("SuccessList")]
            [Validation(Required=false)]
            public List<TransferDeviceInstanceResponseBodyDataSuccessList> SuccessList { get; set; }
            public class TransferDeviceInstanceResponseBodyDataSuccessList : TeaModel {
                [NameInMap("DeviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

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
