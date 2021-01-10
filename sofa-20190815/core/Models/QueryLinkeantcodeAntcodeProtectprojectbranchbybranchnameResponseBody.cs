// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkeantcodeAntcodeProtectprojectbranchbybranchnameResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("MergeAccessLevel")]
        [Validation(Required=false)]
        public string MergeAccessLevel { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Protected")]
        [Validation(Required=false)]
        public bool? Protected { get; set; }

        [NameInMap("ProtectRule")]
        [Validation(Required=false)]
        public string ProtectRule { get; set; }

        [NameInMap("ProtectRuleExactMatched")]
        [Validation(Required=false)]
        public bool? ProtectRuleExactMatched { get; set; }

        [NameInMap("PushAccessLevel")]
        [Validation(Required=false)]
        public string PushAccessLevel { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Commit")]
        [Validation(Required=false)]
        public QueryLinkeantcodeAntcodeProtectprojectbranchbybranchnameResponseBodyCommit Commit { get; set; }
        public class QueryLinkeantcodeAntcodeProtectprojectbranchbybranchnameResponseBodyCommit : TeaModel {
            [NameInMap("AuthoredDate")]
            [Validation(Required=false)]
            public string AuthoredDate { get; set; }
            [NameInMap("AuthorEmail")]
            [Validation(Required=false)]
            public string AuthorEmail { get; set; }
            [NameInMap("AuthorName")]
            [Validation(Required=false)]
            public string AuthorName { get; set; }
            [NameInMap("CommittedDate")]
            [Validation(Required=false)]
            public string CommittedDate { get; set; }
            [NameInMap("CommitterEmail")]
            [Validation(Required=false)]
            public string CommitterEmail { get; set; }
            [NameInMap("CommitterName")]
            [Validation(Required=false)]
            public string CommitterName { get; set; }
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
            [NameInMap("ShortId")]
            [Validation(Required=false)]
            public string ShortId { get; set; }
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }
            [NameInMap("ParentIds")]
            [Validation(Required=false)]
            public List<string> ParentIds { get; set; }
        };

    }

}
