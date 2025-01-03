// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListMergeRequestsResponseBody : TeaModel {
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
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>ASSDS-ASSASX-XSAXSA-XSAXSAXS</para>
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
            /// <para>2022-03-18 14:24:54</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>WEB</para>
            /// </summary>
            [NameInMap("creationMethod")]
            [Validation(Required=false)]
            public string CreationMethod { get; set; }

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
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("iid")]
            [Validation(Required=false)]
            public long? Iid { get; set; }

            [NameInMap("labels")]
            [Validation(Required=false)]
            public List<ListMergeRequestsResponseBodyResultLabels> Labels { get; set; }
            public class ListMergeRequestsResponseBodyResultLabels : TeaModel {
                [NameInMap("color")]
                [Validation(Required=false)]
                public string Color { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
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

            [NameInMap("nameWithNamespace")]
            [Validation(Required=false)]
            public string NameWithNamespace { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("newMergeRequestIdentifier")]
            [Validation(Required=false)]
            public bool? NewMergeRequestIdentifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>UNDER_REVIEW</para>
            /// </summary>
            [NameInMap("newVersionState")]
            [Validation(Required=false)]
            public string NewVersionState { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2369234</para>
            /// </summary>
            [NameInMap("projectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            [NameInMap("reviewers")]
            [Validation(Required=false)]
            public List<ListMergeRequestsResponseBodyResultReviewers> Reviewers { get; set; }
            public class ListMergeRequestsResponseBodyResultReviewers : TeaModel {
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

                [NameInMap("hasReviewed")]
                [Validation(Required=false)]
                public bool? HasReviewed { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>43127</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test-review-user</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

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
                /// <para>approved</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>root-test-review-user</para>
                /// </summary>
                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test-merge-source-branch</para>
            /// </summary>
            [NameInMap("sourceBranch")]
            [Validation(Required=false)]
            public string SourceBranch { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2876119</para>
            /// </summary>
            [NameInMap("sourceProjectId")]
            [Validation(Required=false)]
            public long? SourceProjectId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>BRANCH</para>
            /// </summary>
            [NameInMap("sourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>git@xxx:xxx/test/test.git</para>
            /// </summary>
            [NameInMap("sshUrl")]
            [Validation(Required=false)]
            public string SshUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>opened</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("subscribers")]
            [Validation(Required=false)]
            public List<ListMergeRequestsResponseBodyResultSubscribers> Subscribers { get; set; }
            public class ListMergeRequestsResponseBodyResultSubscribers : TeaModel {
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
                /// <para>1876119</para>
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
                /// <para>root-test-subscriber</para>
                /// </summary>
                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("supportMergeFFOnly")]
            [Validation(Required=false)]
            public bool? SupportMergeFFOnly { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test-merge-target-branch</para>
            /// </summary>
            [NameInMap("targetBranch")]
            [Validation(Required=false)]
            public string TargetBranch { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2876119</para>
            /// </summary>
            [NameInMap("targetProjectId")]
            [Validation(Required=false)]
            public long? TargetProjectId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>BRANCH</para>
            /// </summary>
            [NameInMap("targetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-03-18 14:24:54</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("webUrl")]
            [Validation(Required=false)]
            public string WebUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("workInProgress")]
            [Validation(Required=false)]
            public bool? WorkInProgress { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
