// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateLinkeBahamutVcsmergerequestResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("ErrorMsgParamsMap")]
        [Validation(Required=false)]
        public string ErrorMsgParamsMap { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public CreateLinkeBahamutVcsmergerequestResponseBodyResult Result { get; set; }
        public class CreateLinkeBahamutVcsmergerequestResponseBodyResult : TeaModel {
            [NameInMap("Reviewed")]
            [Validation(Required=false)]
            public bool? Reviewed { get; set; }
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }
            [NameInMap("Author")]
            [Validation(Required=false)]
            public string Author { get; set; }
            [NameInMap("MergeCommitSha")]
            [Validation(Required=false)]
            public string MergeCommitSha { get; set; }
            [NameInMap("Assignee")]
            [Validation(Required=false)]
            public string Assignee { get; set; }
            [NameInMap("SourceBranch")]
            [Validation(Required=false)]
            public string SourceBranch { get; set; }
            [NameInMap("TargetProjectId")]
            [Validation(Required=false)]
            public long? TargetProjectId { get; set; }
            [NameInMap("SourceProjectId")]
            [Validation(Required=false)]
            public long? SourceProjectId { get; set; }
            [NameInMap("WebUrl")]
            [Validation(Required=false)]
            public string WebUrl { get; set; }
            [NameInMap("Review")]
            [Validation(Required=false)]
            public string Review { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("TargetBranch")]
            [Validation(Required=false)]
            public string TargetBranch { get; set; }
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("MergeStatus")]
            [Validation(Required=false)]
            public string MergeStatus { get; set; }
            [NameInMap("Iid")]
            [Validation(Required=false)]
            public long? Iid { get; set; }
        };

    }

}
