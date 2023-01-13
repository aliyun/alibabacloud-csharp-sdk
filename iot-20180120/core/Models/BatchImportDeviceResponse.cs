// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchImportDeviceResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public BatchImportDeviceResponseData Data { get; set; }
        public class BatchImportDeviceResponseData : TeaModel {
            [NameInMap("ApplyId")]
            [Validation(Required=true)]
            public long? ApplyId { get; set; }

            [NameInMap("InvalidDeviceNameList")]
            [Validation(Required=true)]
            public BatchImportDeviceResponseDataInvalidDeviceNameList InvalidDeviceNameList { get; set; }
            public class BatchImportDeviceResponseDataInvalidDeviceNameList : TeaModel {
                /// <summary>
                /// invalidDeviceName
                /// </summary>
                [NameInMap("invalidDeviceName")]
                [Validation(Required=true)]
                public List<string> InvalidDeviceName { get; set; }

            }

            [NameInMap("InvalidDeviceSecretList")]
            [Validation(Required=true)]
            public BatchImportDeviceResponseDataInvalidDeviceSecretList InvalidDeviceSecretList { get; set; }
            public class BatchImportDeviceResponseDataInvalidDeviceSecretList : TeaModel {
                /// <summary>
                /// invalidDeviceSecret
                /// </summary>
                [NameInMap("invalidDeviceSecret")]
                [Validation(Required=true)]
                public List<string> InvalidDeviceSecret { get; set; }

            }

            [NameInMap("InvalidSnList")]
            [Validation(Required=true)]
            public BatchImportDeviceResponseDataInvalidSnList InvalidSnList { get; set; }
            public class BatchImportDeviceResponseDataInvalidSnList : TeaModel {
                /// <summary>
                /// invalidSn
                /// </summary>
                [NameInMap("invalidSn")]
                [Validation(Required=true)]
                public List<string> InvalidSn { get; set; }

            }

            [NameInMap("RepeatedDeviceNameList")]
            [Validation(Required=true)]
            public BatchImportDeviceResponseDataRepeatedDeviceNameList RepeatedDeviceNameList { get; set; }
            public class BatchImportDeviceResponseDataRepeatedDeviceNameList : TeaModel {
                /// <summary>
                /// repeatedDeviceName
                /// </summary>
                [NameInMap("repeatedDeviceName")]
                [Validation(Required=true)]
                public List<string> RepeatedDeviceName { get; set; }

            }

        }

    }

}
