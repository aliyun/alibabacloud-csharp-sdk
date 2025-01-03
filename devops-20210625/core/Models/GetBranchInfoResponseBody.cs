// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetBranchInfoResponseBody : TeaModel {
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
        /// <para>6177543A-8D54-5736-A93B-E0195A1512CB</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetBranchInfoResponseBodyResult Result { get; set; }
        public class GetBranchInfoResponseBodyResult : TeaModel {
            [NameInMap("commit")]
            [Validation(Required=false)]
            public GetBranchInfoResponseBodyResultCommit Commit { get; set; }
            public class GetBranchInfoResponseBodyResultCommit : TeaModel {
                [NameInMap("author")]
                [Validation(Required=false)]
                public GetBranchInfoResponseBodyResultCommitAuthor Author { get; set; }
                public class GetBranchInfoResponseBodyResultCommitAuthor : TeaModel {
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
                    /// <para>28056</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>codeup-test</para>
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
                    /// <para>testtest</para>
                    /// </summary>
                    [NameInMap("username")]
                    [Validation(Required=false)]
                    public string Username { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="mailto:username@example.com">username@example.com</a></para>
                /// </summary>
                [NameInMap("authorEmail")]
                [Validation(Required=false)]
                public string AuthorEmail { get; set; }

                [NameInMap("authorName")]
                [Validation(Required=false)]
                public string AuthorName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-03-18 08:00:00</para>
                /// </summary>
                [NameInMap("authoredDate")]
                [Validation(Required=false)]
                public string AuthoredDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("commentsCount")]
                [Validation(Required=false)]
                public long? CommentsCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-03-18 09:00:00</para>
                /// </summary>
                [NameInMap("committedDate")]
                [Validation(Required=false)]
                public string CommittedDate { get; set; }

                [NameInMap("committer")]
                [Validation(Required=false)]
                public GetBranchInfoResponseBodyResultCommitCommitter Committer { get; set; }
                public class GetBranchInfoResponseBodyResultCommitCommitter : TeaModel {
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
                    /// <para>5035</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>codeup-commit</para>
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
                    /// <para>commitcommit</para>
                    /// </summary>
                    [NameInMap("username")]
                    [Validation(Required=false)]
                    public string Username { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="mailto:username@example.com">username@example.com</a></para>
                /// </summary>
                [NameInMap("committerEmail")]
                [Validation(Required=false)]
                public string CommitterEmail { get; set; }

                [NameInMap("committerName")]
                [Validation(Required=false)]
                public string CommitterName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-03-18 10:00:00</para>
                /// </summary>
                [NameInMap("createdAt")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>e0297d8fb0393c833a8531e7cc8832739e3cba6d</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("parentIds")]
                [Validation(Required=false)]
                public List<string> ParentIds { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>e0297d8f</para>
                /// </summary>
                [NameInMap("shortId")]
                [Validation(Required=false)]
                public string ShortId { get; set; }

                [NameInMap("signature")]
                [Validation(Required=false)]
                public GetBranchInfoResponseBodyResultCommitSignature Signature { get; set; }
                public class GetBranchInfoResponseBodyResultCommitSignature : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("gpgKeyId")]
                    [Validation(Required=false)]
                    public string GpgKeyId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>verified</para>
                    /// </summary>
                    [NameInMap("verificationStatus")]
                    [Validation(Required=false)]
                    public string VerificationStatus { get; set; }

                }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>master</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("protected")]
            [Validation(Required=false)]
            public string Protected { get; set; }

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
