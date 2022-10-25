// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Codeup20200414.Models
{
    public class DeleteRepositoryWebhookResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DeleteRepositoryWebhookResponseBodyResult Result { get; set; }
        public class DeleteRepositoryWebhookResponseBodyResult : TeaModel {
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("EnableSslVerification")]
            [Validation(Required=false)]
            public bool? EnableSslVerification { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("LastTestResult")]
            [Validation(Required=false)]
            public string LastTestResult { get; set; }

            [NameInMap("MergeRequestsEvents")]
            [Validation(Required=false)]
            public bool? MergeRequestsEvents { get; set; }

            [NameInMap("NoteEvents")]
            [Validation(Required=false)]
            public bool? NoteEvents { get; set; }

            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            [NameInMap("PushEvents")]
            [Validation(Required=false)]
            public bool? PushEvents { get; set; }

            [NameInMap("SecretToken")]
            [Validation(Required=false)]
            public string SecretToken { get; set; }

            [NameInMap("TagPushEvents")]
            [Validation(Required=false)]
            public bool? TagPushEvents { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
