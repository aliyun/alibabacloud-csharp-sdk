// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FaRui20240628.Models
{
    public class RunLegalAdviceConsultationResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResponseMarkdown")]
        [Validation(Required=false)]
        public string ResponseMarkdown { get; set; }

        [NameInMap("Round")]
        [Validation(Required=false)]
        public int? Round { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Usage")]
        [Validation(Required=false)]
        public RunLegalAdviceConsultationResponseBodyUsage Usage { get; set; }
        public class RunLegalAdviceConsultationResponseBodyUsage : TeaModel {
            [NameInMap("InputTokens")]
            [Validation(Required=false)]
            public int? InputTokens { get; set; }

            [NameInMap("OutputTokens")]
            [Validation(Required=false)]
            public int? OutputTokens { get; set; }

            [NameInMap("TotalTokens")]
            [Validation(Required=false)]
            public int? TotalTokens { get; set; }

        }

        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

    }

}
