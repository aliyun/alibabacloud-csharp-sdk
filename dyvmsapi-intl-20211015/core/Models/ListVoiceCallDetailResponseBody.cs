// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi_intl20211015.Models
{
    public class ListVoiceCallDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListVoiceCallDetailResponseBodyList> List { get; set; }
        public class ListVoiceCallDetailResponseBodyList : TeaModel {
            [NameInMap("Billing")]
            [Validation(Required=false)]
            public long? Billing { get; set; }

            [NameInMap("BusinessType")]
            [Validation(Required=false)]
            public long? BusinessType { get; set; }

            [NameInMap("CalledNumber")]
            [Validation(Required=false)]
            public string CalledNumber { get; set; }

            [NameInMap("CallingNumber")]
            [Validation(Required=false)]
            public string CallingNumber { get; set; }

            [NameInMap("CommitTs")]
            [Validation(Required=false)]
            public string CommitTs { get; set; }

            [NameInMap("CountryId")]
            [Validation(Required=false)]
            public string CountryId { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            [NameInMap("EndTs")]
            [Validation(Required=false)]
            public string EndTs { get; set; }

            [NameInMap("HangupType")]
            [Validation(Required=false)]
            public long? HangupType { get; set; }

            [NameInMap("SendType")]
            [Validation(Required=false)]
            public long? SendType { get; set; }

            [NameInMap("StartTs")]
            [Validation(Required=false)]
            public string StartTs { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

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
