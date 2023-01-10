// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListSearchSourceCodeRequest : TeaModel {
        [NameInMap("filePath")]
        [Validation(Required=false)]
        public ListSearchSourceCodeRequestFilePath FilePath { get; set; }
        public class ListSearchSourceCodeRequestFilePath : TeaModel {
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

        [NameInMap("isCodeBlock")]
        [Validation(Required=false)]
        public bool? IsCodeBlock { get; set; }

        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

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
        public ListSearchSourceCodeRequestRepoPath RepoPath { get; set; }
        public class ListSearchSourceCodeRequestRepoPath : TeaModel {
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
