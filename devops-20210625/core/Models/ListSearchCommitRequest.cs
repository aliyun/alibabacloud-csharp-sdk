// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListSearchCommitRequest : TeaModel {
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        [NameInMap("order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("repoPath")]
        [Validation(Required=false)]
        public ListSearchCommitRequestRepoPath RepoPath { get; set; }
        public class ListSearchCommitRequestRepoPath : TeaModel {
            [NameInMap("matchType")]
            [Validation(Required=false)]
            public string MatchType { get; set; }

            [NameInMap("operatorType")]
            [Validation(Required=false)]
            public string OperatorType { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        [NameInMap("sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

    }

}
