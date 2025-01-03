// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateMergeRequestResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SYSTEM_UNKNOWN_ERROR</para>
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
        public CreateMergeRequestResponseBodyResult Result { get; set; }
        public class CreateMergeRequestResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
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
            public CreateMergeRequestResponseBodyResultAuthor Author { get; set; }
            public class CreateMergeRequestResponseBodyResultAuthor : TeaModel {
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
                /// <para>19230</para>
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
                /// <para>test-codeup-nickname</para>
                /// </summary>
                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
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
            /// <para>2023-06-02T03:41:22Z</para>
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
            public List<CreateMergeRequestResponseBodyResultReviewers> Reviewers { get; set; }
            public class CreateMergeRequestResponseBodyResultReviewers : TeaModel {
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
                /// <para>false</para>
                /// </summary>
                [NameInMap("hasReviewed")]
                [Validation(Required=false)]
                public bool? HasReviewed { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>7905</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>codeup</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PASS</para>
                /// </summary>
                [NameInMap("reviewOpinionStatus")]
                [Validation(Required=false)]
                public string ReviewOpinionStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>active</para>
                /// </summary>
                [NameInMap("state")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>root-codeup</para>
                /// </summary>
                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sourceBranch</para>
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
            public List<CreateMergeRequestResponseBodyResultSubscribers> Subscribers { get; set; }
            public class CreateMergeRequestResponseBodyResultSubscribers : TeaModel {
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
                /// <para>10092</para>
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
            /// <para>true</para>
            /// </summary>
            [NameInMap("supportMergeFastForwardOnly")]
            [Validation(Required=false)]
            public bool? SupportMergeFastForwardOnly { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>targetBranch</para>
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

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-06-02T03:41:22Z</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://codeup.aliyun.com/xxx/test/test">https://codeup.aliyun.com/xxx/test/test</a></para>
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
