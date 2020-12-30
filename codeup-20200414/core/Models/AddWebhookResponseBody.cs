// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Codeup20200414.Models
{
    public class AddWebhookResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public AddWebhookResponseBodyResult Result { get; set; }
        public class AddWebhookResponseBodyResult : TeaModel {
            [NameInMap("PushEvents")]
            [Validation(Required=false)]
            public bool? PushEvents { get; set; }
            [NameInMap("BuildEvents")]
            [Validation(Required=false)]
            public bool? BuildEvents { get; set; }
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }
            [NameInMap("TagPushEvents")]
            [Validation(Required=false)]
            public bool? TagPushEvents { get; set; }
            [NameInMap("IssuesEvents")]
            [Validation(Required=false)]
            public bool? IssuesEvents { get; set; }
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }
            [NameInMap("LastTestResult")]
            [Validation(Required=false)]
            public string LastTestResult { get; set; }
            [NameInMap("MergeRequestsEvents")]
            [Validation(Required=false)]
            public bool? MergeRequestsEvents { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("NoteEvents")]
            [Validation(Required=false)]
            public bool? NoteEvents { get; set; }
            [NameInMap("SecretToken")]
            [Validation(Required=false)]
            public string SecretToken { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("EnableSslVerification")]
            [Validation(Required=false)]
            public bool? EnableSslVerification { get; set; }
        };

    }

}
