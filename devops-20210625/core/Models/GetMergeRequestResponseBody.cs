// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetMergeRequestResponseBody : TeaModel {
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
        public GetMergeRequestResponseBodyResult Result { get; set; }
        public class GetMergeRequestResponseBodyResult : TeaModel {
            [NameInMap("ahead")]
            [Validation(Required=false)]
            public int? Ahead { get; set; }

            [NameInMap("allRequirementsPass")]
            [Validation(Required=false)]
            public bool? AllRequirementsPass { get; set; }

            [NameInMap("author")]
            [Validation(Required=false)]
            public GetMergeRequestResponseBodyResultAuthor Author { get; set; }
            public class GetMergeRequestResponseBodyResultAuthor : TeaModel {
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

            [NameInMap("behind")]
            [Validation(Required=false)]
            public int? Behind { get; set; }

            [NameInMap("createFrom")]
            [Validation(Required=false)]
            public string CreateFrom { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("detailUrl")]
            [Validation(Required=false)]
            public string DetailUrl { get; set; }

            [NameInMap("localId")]
            [Validation(Required=false)]
            public long? LocalId { get; set; }

            [NameInMap("mrBizId")]
            [Validation(Required=false)]
            public string MrBizId { get; set; }

            [NameInMap("mrType")]
            [Validation(Required=false)]
            public string MrType { get; set; }

            [NameInMap("projectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            [NameInMap("reviewers")]
            [Validation(Required=false)]
            public List<GetMergeRequestResponseBodyResultReviewers> Reviewers { get; set; }
            public class GetMergeRequestResponseBodyResultReviewers : TeaModel {
                [NameInMap("avatarUrl")]
                [Validation(Required=false)]
                public string AvatarUrl { get; set; }

                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("hasReviewed")]
                [Validation(Required=false)]
                public bool? HasReviewed { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("reviewOpinionStatus")]
                [Validation(Required=false)]
                public string ReviewOpinionStatus { get; set; }

                [NameInMap("reviewTime")]
                [Validation(Required=false)]
                public string ReviewTime { get; set; }

                [NameInMap("state")]
                [Validation(Required=false)]
                public string State { get; set; }

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

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("subscribers")]
            [Validation(Required=false)]
            public List<GetMergeRequestResponseBodyResultSubscribers> Subscribers { get; set; }
            public class GetMergeRequestResponseBodyResultSubscribers : TeaModel {
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

            [NameInMap("supportMergeFastForwardOnly")]
            [Validation(Required=false)]
            public bool? SupportMergeFastForwardOnly { get; set; }

            [NameInMap("targetBranch")]
            [Validation(Required=false)]
            public string TargetBranch { get; set; }

            [NameInMap("targetProjectId")]
            [Validation(Required=false)]
            public long? TargetProjectId { get; set; }

            [NameInMap("targetProjectNameWithNamespace")]
            [Validation(Required=false)]
            public string TargetProjectNameWithNamespace { get; set; }

            [NameInMap("targetProjectPathWithNamespace")]
            [Validation(Required=false)]
            public string TargetProjectPathWithNamespace { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("todoList")]
            [Validation(Required=false)]
            public GetMergeRequestResponseBodyResultTodoList TodoList { get; set; }
            public class GetMergeRequestResponseBodyResultTodoList : TeaModel {
                [NameInMap("requirementCheckItems")]
                [Validation(Required=false)]
                public List<GetMergeRequestResponseBodyResultTodoListRequirementCheckItems> RequirementCheckItems { get; set; }
                public class GetMergeRequestResponseBodyResultTodoListRequirementCheckItems : TeaModel {
                    [NameInMap("itemType")]
                    [Validation(Required=false)]
                    public string ItemType { get; set; }

                    [NameInMap("pass")]
                    [Validation(Required=false)]
                    public bool? Pass { get; set; }

                }

            }

            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            [NameInMap("webUrl")]
            [Validation(Required=false)]
            public string WebUrl { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
