// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchImportDeviceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public BatchImportDeviceResponseBodyData Data { get; set; }
        public class BatchImportDeviceResponseBodyData : TeaModel {
            [NameInMap("ApplyId")]
            [Validation(Required=false)]
            public long? ApplyId { get; set; }

            [NameInMap("InvalidDeviceNameList")]
            [Validation(Required=false)]
            public BatchImportDeviceResponseBodyDataInvalidDeviceNameList InvalidDeviceNameList { get; set; }
            public class BatchImportDeviceResponseBodyDataInvalidDeviceNameList : TeaModel {
                [NameInMap("invalidDeviceName")]
                [Validation(Required=false)]
                public List<string> InvalidDeviceName { get; set; }

            }

            [NameInMap("InvalidDeviceSecretList")]
            [Validation(Required=false)]
            public BatchImportDeviceResponseBodyDataInvalidDeviceSecretList InvalidDeviceSecretList { get; set; }
            public class BatchImportDeviceResponseBodyDataInvalidDeviceSecretList : TeaModel {
                [NameInMap("invalidDeviceSecret")]
                [Validation(Required=false)]
                public List<string> InvalidDeviceSecret { get; set; }

            }

            [NameInMap("InvalidSnList")]
            [Validation(Required=false)]
            public BatchImportDeviceResponseBodyDataInvalidSnList InvalidSnList { get; set; }
            public class BatchImportDeviceResponseBodyDataInvalidSnList : TeaModel {
                [NameInMap("invalidSn")]
                [Validation(Required=false)]
                public List<string> InvalidSn { get; set; }

            }

            [NameInMap("RepeatedDeviceNameList")]
            [Validation(Required=false)]
            public BatchImportDeviceResponseBodyDataRepeatedDeviceNameList RepeatedDeviceNameList { get; set; }
            public class BatchImportDeviceResponseBodyDataRepeatedDeviceNameList : TeaModel {
                [NameInMap("repeatedDeviceName")]
                [Validation(Required=false)]
                public List<string> RepeatedDeviceName { get; set; }

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
