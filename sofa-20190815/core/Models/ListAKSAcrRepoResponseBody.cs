// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListAKSAcrRepoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("RepoList")]
        [Validation(Required=false)]
        public ListAKSAcrRepoResponseBodyRepoList RepoList { get; set; }
        public class ListAKSAcrRepoResponseBodyRepoList : TeaModel {
            [NameInMap("Page")]
            [Validation(Required=false)]
            public long? Page { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }
            [NameInMap("Repos")]
            [Validation(Required=false)]
            public List<ListAKSAcrRepoResponseBodyRepoListRepos> Repos { get; set; }
            public class ListAKSAcrRepoResponseBodyRepoListRepos : TeaModel {
                public string Detail { get; set; }
                public long? GmtCreate { get; set; }
                public long? GmtModified { get; set; }
                public string RegionId { get; set; }
                public string RepoAuthorizeType { get; set; }
                public string RepoBuildType { get; set; }
                public string RepoName { get; set; }
                public string RepoNamespace { get; set; }
                public string RepoStatus { get; set; }
                public string RepoType { get; set; }
                public string Summary { get; set; }
                public List<ListAKSAcrRepoResponseBodyRepoListReposRepoDomainList> RepoDomainList { get; set; }
                public class ListAKSAcrRepoResponseBodyRepoListReposRepoDomainList : TeaModel {
                    public string Domain { get; set; }
                    public string Type { get; set; }
                }
            }
        };

    }

}
