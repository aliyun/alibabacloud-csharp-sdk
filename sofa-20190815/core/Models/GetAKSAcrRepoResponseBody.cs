// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetAKSAcrRepoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Repo")]
        [Validation(Required=false)]
        public GetAKSAcrRepoResponseBodyRepo Repo { get; set; }
        public class GetAKSAcrRepoResponseBodyRepo : TeaModel {
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }
            [NameInMap("RepoAuthorizeType")]
            [Validation(Required=false)]
            public string RepoAuthorizeType { get; set; }
            [NameInMap("RepoBuildType")]
            [Validation(Required=false)]
            public string RepoBuildType { get; set; }
            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }
            [NameInMap("RepoNamespace")]
            [Validation(Required=false)]
            public string RepoNamespace { get; set; }
            [NameInMap("RepoStatus")]
            [Validation(Required=false)]
            public string RepoStatus { get; set; }
            [NameInMap("RepoType")]
            [Validation(Required=false)]
            public string RepoType { get; set; }
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }
            [NameInMap("RepoDomainList")]
            [Validation(Required=false)]
            public List<GetAKSAcrRepoResponseBodyRepoRepoDomainList> RepoDomainList { get; set; }
            public class GetAKSAcrRepoResponseBodyRepoRepoDomainList : TeaModel {
                public string Domain { get; set; }
                public string Type { get; set; }
            }
        };

    }

}
