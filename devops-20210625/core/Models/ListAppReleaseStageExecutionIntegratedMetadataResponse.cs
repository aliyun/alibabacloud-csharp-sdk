// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListAppReleaseStageExecutionIntegratedMetadataResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=false)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public List<ListAppReleaseStageExecutionIntegratedMetadataResponseBody> Body { get; set; }
        public class ListAppReleaseStageExecutionIntegratedMetadataResponseBody : TeaModel {
            [NameInMap("releaseBranch")]
            [Validation(Required=false)]
            public string ReleaseBranch { get; set; }

            [NameInMap("releaseRevision")]
            [Validation(Required=false)]
            public string ReleaseRevision { get; set; }

            [NameInMap("repoUrl")]
            [Validation(Required=false)]
            public string RepoUrl { get; set; }

            [NameInMap("repoType")]
            [Validation(Required=false)]
            public string RepoType { get; set; }

            [NameInMap("changeRequests")]
            [Validation(Required=false)]
            public List<ListAppReleaseStageExecutionIntegratedMetadataResponseBodyChangeRequests> ChangeRequests { get; set; }
            public class ListAppReleaseStageExecutionIntegratedMetadataResponseBodyChangeRequests : TeaModel {
                [NameInMap("sn")]
                [Validation(Required=false)]
                public string Sn { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("branchName")]
                [Validation(Required=false)]
                public string BranchName { get; set; }

                [NameInMap("commitId")]
                [Validation(Required=false)]
                public string CommitId { get; set; }

                [NameInMap("ownerAccountId")]
                [Validation(Required=false)]
                public string OwnerAccountId { get; set; }

            }

        }

    }

}
