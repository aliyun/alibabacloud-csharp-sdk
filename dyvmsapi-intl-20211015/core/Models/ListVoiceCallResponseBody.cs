// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi_intl20211015.Models
{
    public class ListVoiceCallResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListVoiceCallResponseBodyList> List { get; set; }
        public class ListVoiceCallResponseBodyList : TeaModel {
            [NameInMap("AnsweredCalls")]
            [Validation(Required=false)]
            public long? AnsweredCalls { get; set; }

            [NameInMap("BusinessType")]
            [Validation(Required=false)]
            public long? BusinessType { get; set; }

            [NameInMap("CalledCalls")]
            [Validation(Required=false)]
            public long? CalledCalls { get; set; }

            [NameInMap("CallingNumber")]
            [Validation(Required=false)]
            public string CallingNumber { get; set; }

            [NameInMap("CommitTs")]
            [Validation(Required=false)]
            public string CommitTs { get; set; }

            [NameInMap("CountryId")]
            [Validation(Required=false)]
            public string CountryId { get; set; }

            [NameInMap("FailedCalls")]
            [Validation(Required=false)]
            public long? FailedCalls { get; set; }

            [NameInMap("GroupCallType")]
            [Validation(Required=false)]
            public long? GroupCallType { get; set; }

            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("SendType")]
            [Validation(Required=false)]
            public long? SendType { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            [NameInMap("TemplateContent")]
            [Validation(Required=false)]
            public string TemplateContent { get; set; }

            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            [NameInMap("TickerTs")]
            [Validation(Required=false)]
            public string TickerTs { get; set; }

            [NameInMap("TotalCalls")]
            [Validation(Required=false)]
            public long? TotalCalls { get; set; }

            [NameInMap("TotalDuration")]
            [Validation(Required=false)]
            public long? TotalDuration { get; set; }

            [NameInMap("UserUuid")]
            [Validation(Required=false)]
            public string UserUuid { get; set; }

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
