// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchCheckImportDeviceResponse : TeaModel {
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
        public BatchCheckImportDeviceResponseData Data { get; set; }
        public class BatchCheckImportDeviceResponseData : TeaModel {
            [NameInMap("InvalidDeviceNameList")]
            [Validation(Required=true)]
            public List<string> InvalidDeviceNameList { get; set; }

            [NameInMap("InvalidDeviceSecretList")]
            [Validation(Required=true)]
            public List<string> InvalidDeviceSecretList { get; set; }

            [NameInMap("InvalidSnList")]
            [Validation(Required=true)]
            public List<string> InvalidSnList { get; set; }

            [NameInMap("RepeatedDeviceNameList")]
            [Validation(Required=true)]
            public List<string> RepeatedDeviceNameList { get; set; }

        }

    }

}
