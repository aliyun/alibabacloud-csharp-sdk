// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class PrintByTemplateResponse : TeaModel {
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
        public PrintByTemplateResponseData Data { get; set; }
        public class PrintByTemplateResponseData : TeaModel {
            [NameInMap("DeviceErrorCode")]
            [Validation(Required=true)]
            public string DeviceErrorCode { get; set; }

            [NameInMap("DeviceErrorMessage")]
            [Validation(Required=true)]
            public string DeviceErrorMessage { get; set; }

            [NameInMap("Id")]
            [Validation(Required=true)]
            public string Id { get; set; }

            [NameInMap("MaxRetryCount")]
            [Validation(Required=true)]
            public int? MaxRetryCount { get; set; }

            [NameInMap("RetryCount")]
            [Validation(Required=true)]
            public int? RetryCount { get; set; }

            [NameInMap("Success")]
            [Validation(Required=true)]
            public bool? Success { get; set; }

        }

    }

}
