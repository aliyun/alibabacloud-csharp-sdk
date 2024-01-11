// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListMergeRequestsResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListMergeRequestsResponseBodyResult> Result { get; set; }
        public class ListMergeRequestsResponseBodyResult : TeaModel {
            [NameInMap("author")]
            [Validation(Required=false)]
            public ListMergeRequestsResponseBodyResultAuthor Author { get; set; }
            public class ListMergeRequestsResponseBodyResultAuthor : TeaModel {
                [NameInMap("avatarUrl")]
                [Validation(Required=false)]
                public string AvatarUrl { get; set; }

                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("state")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("creationMethod")]
            [Validation(Required=false)]
            public string CreationMethod { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("detailUrl")]
            [Validation(Required=false)]
            public string DetailUrl { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("iid")]
            [Validation(Required=false)]
            public long? Iid { get; set; }

            [NameInMap("localId")]
            [Validation(Required=false)]
            public long? LocalId { get; set; }

            [NameInMap("mrBizId")]
            [Validation(Required=false)]
            public string MrBizId { get; set; }

            [NameInMap("nameWithNamespace")]
            [Validation(Required=false)]
            public string NameWithNamespace { get; set; }

            [NameInMap("newMergeRequestIdentifier")]
            [Validation(Required=false)]
            public bool? NewMergeRequestIdentifier { get; set; }

            [NameInMap("newVersionState")]
            [Validation(Required=false)]
            public string NewVersionState { get; set; }

            [NameInMap("projectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            [NameInMap("reviewers")]
            [Validation(Required=false)]
            public List<ListMergeRequestsResponseBodyResultReviewers> Reviewers { get; set; }
            public class ListMergeRequestsResponseBodyResultReviewers : TeaModel {
                [NameInMap("avatarUrl")]
                [Validation(Required=false)]
                public string AvatarUrl { get; set; }

                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("reviewTime")]
                [Validation(Required=false)]
                public string ReviewTime { get; set; }

                [NameInMap("state")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            [NameInMap("sourceBranch")]
            [Validation(Required=false)]
            public string SourceBranch { get; set; }

            [NameInMap("sourceProjectId")]
            [Validation(Required=false)]
            public long? SourceProjectId { get; set; }

            [NameInMap("sourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            [NameInMap("sshUrl")]
            [Validation(Required=false)]
            public string SshUrl { get; set; }

            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("subscribers")]
            [Validation(Required=false)]
            public List<ListMergeRequestsResponseBodyResultSubscribers> Subscribers { get; set; }
            public class ListMergeRequestsResponseBodyResultSubscribers : TeaModel {
                [NameInMap("avatarUrl")]
                [Validation(Required=false)]
                public string AvatarUrl { get; set; }

                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("state")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            [NameInMap("supportMergeFFOnly")]
            [Validation(Required=false)]
            public bool? SupportMergeFFOnly { get; set; }

            [NameInMap("targetBranch")]
            [Validation(Required=false)]
            public string TargetBranch { get; set; }

            [NameInMap("targetProjectId")]
            [Validation(Required=false)]
            public long? TargetProjectId { get; set; }

            [NameInMap("targetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            [NameInMap("webUrl")]
            [Validation(Required=false)]
            public string WebUrl { get; set; }

            [NameInMap("workInProgress")]
            [Validation(Required=false)]
            public bool? WorkInProgress { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
