// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class PrintByTemplateResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public PrintByTemplateResponseBodyData Data { get; set; }
        public class PrintByTemplateResponseBodyData : TeaModel {
            [NameInMap("DeviceErrorCode")]
            [Validation(Required=false)]
            public string DeviceErrorCode { get; set; }
            [NameInMap("DeviceErrorMessage")]
            [Validation(Required=false)]
            public string DeviceErrorMessage { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("MaxRetryCount")]
            [Validation(Required=false)]
            public int? MaxRetryCount { get; set; }
            [NameInMap("RetryCount")]
            [Validation(Required=false)]
            public int? RetryCount { get; set; }
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }
        };

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
