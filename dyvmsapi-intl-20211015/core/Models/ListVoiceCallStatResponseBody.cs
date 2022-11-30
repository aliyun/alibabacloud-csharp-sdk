// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi_intl20211015.Models
{
    public class ListVoiceCallStatResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListVoiceCallStatResponseBodyList> List { get; set; }
        public class ListVoiceCallStatResponseBodyList : TeaModel {
            [NameInMap("AnsweredCalls")]
            [Validation(Required=false)]
            public long? AnsweredCalls { get; set; }

            [NameInMap("AnsweredRate")]
            [Validation(Required=false)]
            public long? AnsweredRate { get; set; }

            [NameInMap("AverageDuration")]
            [Validation(Required=false)]
            public long? AverageDuration { get; set; }

            [NameInMap("Billing")]
            [Validation(Required=false)]
            public long? Billing { get; set; }

            [NameInMap("BusinessType")]
            [Validation(Required=false)]
            public long? BusinessType { get; set; }

            [NameInMap("FailedCalls")]
            [Validation(Required=false)]
            public long? FailedCalls { get; set; }

            [NameInMap("TotalCalls")]
            [Validation(Required=false)]
            public long? TotalCalls { get; set; }

            [NameInMap("TotalDuration")]
            [Validation(Required=false)]
            public long? TotalDuration { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
