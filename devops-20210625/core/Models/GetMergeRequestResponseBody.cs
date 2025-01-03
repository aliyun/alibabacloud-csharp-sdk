// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetMergeRequestResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Openapi.RequestError</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F7B85D1B-D1C2-140F-A039-341859F130B9</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetMergeRequestResponseBodyResult Result { get; set; }
        public class GetMergeRequestResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ahead")]
            [Validation(Required=false)]
            public int? Ahead { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("allRequirementsPass")]
            [Validation(Required=false)]
            public bool? AllRequirementsPass { get; set; }

            [NameInMap("author")]
            [Validation(Required=false)]
            public GetMergeRequestResponseBodyResultAuthor Author { get; set; }
            public class GetMergeRequestResponseBodyResultAuthor : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://tcs-devops.aliyuncs.com/thumbnail/112afcb7a6a35c3f67f1bea827c4/w/100/h/100">https://tcs-devops.aliyuncs.com/thumbnail/112afcb7a6a35c3f67f1bea827c4/w/100/h/100</a></para>
                /// </summary>
                [NameInMap("avatarUrl")]
                [Validation(Required=false)]
                public string AvatarUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="mailto:username@example.com">username@example.com</a></para>
                /// </summary>
                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>19927</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test-codeup</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>active</para>
                /// </summary>
                [NameInMap("state")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>root-test-codeup</para>
                /// </summary>
                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("behind")]
            [Validation(Required=false)]
            public int? Behind { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>WEB</para>
            /// </summary>
            [NameInMap("createFrom")]
            [Validation(Required=false)]
            public string CreateFrom { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-05-30T02:53:36Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("detailUrl")]
            [Validation(Required=false)]
            public string DetailUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("localId")]
            [Validation(Required=false)]
            public long? LocalId { get; set; }

            [NameInMap("mergedRevision")]
            [Validation(Required=false)]
            public string MergedRevision { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>bca90244c4b749e0b109df52ac0eb570</para>
            /// </summary>
            [NameInMap("mrBizId")]
            [Validation(Required=false)]
            public string MrBizId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CODE_REVIEW</para>
            /// </summary>
            [NameInMap("mrType")]
            [Validation(Required=false)]
            public string MrType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2369234</para>
            /// </summary>
            [NameInMap("projectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            [NameInMap("reviewers")]
            [Validation(Required=false)]
            public List<GetMergeRequestResponseBodyResultReviewers> Reviewers { get; set; }
            public class GetMergeRequestResponseBodyResultReviewers : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://tcs-devops.aliyuncs.com/thumbnail/112afcb7a6a35c3f67f1bea827c4/w/100/h/100">https://tcs-devops.aliyuncs.com/thumbnail/112afcb7a6a35c3f67f1bea827c4/w/100/h/100</a></para>
                /// </summary>
                [NameInMap("avatarUrl")]
                [Validation(Required=false)]
                public string AvatarUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="mailto:username@example.com">username@example.com</a></para>
                /// </summary>
                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("hasCommented")]
                [Validation(Required=false)]
                public bool? HasCommented { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("hasReviewed")]
                [Validation(Required=false)]
                public bool? HasReviewed { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>90452</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test-codeup</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NOT_PASS</para>
                /// </summary>
                [NameInMap("reviewOpinionStatus")]
                [Validation(Required=false)]
                public string ReviewOpinionStatus { get; set; }

                [NameInMap("reviewTime")]
                [Validation(Required=false)]
                public string ReviewTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>active</para>
                /// </summary>
                [NameInMap("state")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>root-test-codeup</para>
                /// </summary>
                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test-merge-request</para>
            /// </summary>
            [NameInMap("sourceBranch")]
            [Validation(Required=false)]
            public string SourceBranch { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2369234</para>
            /// </summary>
            [NameInMap("sourceProjectId")]
            [Validation(Required=false)]
            public long? SourceProjectId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>UNDER_REVIEW</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("subscribers")]
            [Validation(Required=false)]
            public List<GetMergeRequestResponseBodyResultSubscribers> Subscribers { get; set; }
            public class GetMergeRequestResponseBodyResultSubscribers : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://tcs-devops.aliyuncs.com/thumbnail/112afcb7a6a35c3f67f1bea827c4/w/100/h/100">https://tcs-devops.aliyuncs.com/thumbnail/112afcb7a6a35c3f67f1bea827c4/w/100/h/100</a></para>
                /// </summary>
                [NameInMap("avatarUrl")]
                [Validation(Required=false)]
                public string AvatarUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="mailto:username@example.com">username@example.com</a></para>
                /// </summary>
                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>90452</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test-subscriber</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>active</para>
                /// </summary>
                [NameInMap("state")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test-subscriber</para>
                /// </summary>
                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("supportMergeFastForwardOnly")]
            [Validation(Required=false)]
            public bool? SupportMergeFastForwardOnly { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>master</para>
            /// </summary>
            [NameInMap("targetBranch")]
            [Validation(Required=false)]
            public string TargetBranch { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2369234</para>
            /// </summary>
            [NameInMap("targetProjectId")]
            [Validation(Required=false)]
            public long? TargetProjectId { get; set; }

            [NameInMap("targetProjectNameWithNamespace")]
            [Validation(Required=false)]
            public string TargetProjectNameWithNamespace { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>orgId/test-group/test-target-repo</para>
            /// </summary>
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
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>COMMENTS_CHECK</para>
                    /// </summary>
                    [NameInMap("itemType")]
                    [Validation(Required=false)]
                    public string ItemType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("pass")]
                    [Validation(Required=false)]
                    public bool? Pass { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-05-30T02:53:36Z</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("webUrl")]
            [Validation(Required=false)]
            public string WebUrl { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
