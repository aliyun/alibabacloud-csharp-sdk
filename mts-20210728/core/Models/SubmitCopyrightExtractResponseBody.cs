// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20210728.Models
{
    public class SubmitCopyrightExtractResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SubmitCopyrightExtractResponseBodyData Data { get; set; }
        public class SubmitCopyrightExtractResponseBodyData : TeaModel {
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestID")]
        [Validation(Required=false)]
        public string RequestID { get; set; }

        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public long? StatusCode { get; set; }

    }

}
