// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListGitRepositoriesResponseBody : TeaModel {
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("GitRepos")]
        [Validation(Required=false)]
        public List<ListGitRepositoriesResponseBodyGitRepos> GitRepos { get; set; }
        public class ListGitRepositoriesResponseBodyGitRepos : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("FullName")]
            [Validation(Required=false)]
            public string FullName { get; set; }

            [NameInMap("HtmlUrl")]
            [Validation(Required=false)]
            public string HtmlUrl { get; set; }

            [NameInMap("IsPrivate")]
            [Validation(Required=false)]
            public bool? IsPrivate { get; set; }

            [NameInMap("RepoId")]
            [Validation(Required=false)]
            public long? RepoId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
