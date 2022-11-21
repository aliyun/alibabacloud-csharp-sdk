// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class DeleteRepositoryWebhookResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public DeleteRepositoryWebhookResponseBodyResult Result { get; set; }
        public class DeleteRepositoryWebhookResponseBodyResult : TeaModel {
            [NameInMap("buildEvents")]
            [Validation(Required=false)]
            public bool? BuildEvents { get; set; }

            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("enableSslVerification")]
            [Validation(Required=false)]
            public bool? EnableSslVerification { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("issuesEvents")]
            [Validation(Required=false)]
            public bool? IssuesEvents { get; set; }

            [NameInMap("lastTestResult")]
            [Validation(Required=false)]
            public string LastTestResult { get; set; }

            [NameInMap("mergeRequestsEvents")]
            [Validation(Required=false)]
            public bool? MergeRequestsEvents { get; set; }

            [NameInMap("noteEvents")]
            [Validation(Required=false)]
            public bool? NoteEvents { get; set; }

            [NameInMap("projectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            [NameInMap("pushEvents")]
            [Validation(Required=false)]
            public bool? PushEvents { get; set; }

            [NameInMap("secretToken")]
            [Validation(Required=false)]
            public string SecretToken { get; set; }

            [NameInMap("tagPushEvents")]
            [Validation(Required=false)]
            public bool? TagPushEvents { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
