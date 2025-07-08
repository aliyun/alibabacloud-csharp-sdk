// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class BatchCreateSmsSignResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public BatchCreateSmsSignResponseBodyData Data { get; set; }
        public class BatchCreateSmsSignResponseBodyData : TeaModel {
            [NameInMap("AppliedNum")]
            [Validation(Required=false)]
            public int? AppliedNum { get; set; }

            [NameInMap("AvailableNum")]
            [Validation(Required=false)]
            public int? AvailableNum { get; set; }

            [NameInMap("BatchCreateSmsSignResult")]
            [Validation(Required=false)]
            public string BatchCreateSmsSignResult { get; set; }

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
