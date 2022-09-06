// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeJobDataParsingTaskProgressResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Progress")]
        [Validation(Required=false)]
        public DescribeJobDataParsingTaskProgressResponseBodyProgress Progress { get; set; }
        public class DescribeJobDataParsingTaskProgressResponseBodyProgress : TeaModel {
            [NameInMap("FailErrorCode")]
            [Validation(Required=false)]
            public string FailErrorCode { get; set; }

            [NameInMap("FailReason")]
            [Validation(Required=false)]
            public string FailReason { get; set; }

            [NameInMap("FeedbackUrl")]
            [Validation(Required=false)]
            public string FeedbackUrl { get; set; }

            [NameInMap("HandledJobCount")]
            [Validation(Required=false)]
            public int? HandledJobCount { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TotalJobCount")]
            [Validation(Required=false)]
            public int? TotalJobCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
