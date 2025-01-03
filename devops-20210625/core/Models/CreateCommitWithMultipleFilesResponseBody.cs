// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateCommitWithMultipleFilesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>error</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A7586FEB-E48D-5579-983F-74981FBFF627</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateCommitWithMultipleFilesResponseBodyResult Result { get; set; }
        public class CreateCommitWithMultipleFilesResponseBodyResult : TeaModel {
            [NameInMap("author")]
            [Validation(Required=false)]
            public CreateCommitWithMultipleFilesResponseBodyResultAuthor Author { get; set; }
            public class CreateCommitWithMultipleFilesResponseBodyResultAuthor : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>284692704493684695</para>
                /// </summary>
                [NameInMap("aliyunPk")]
                [Validation(Required=false)]
                public string AliyunPk { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://tcs-devops.aliyuncs.com/thumbnail/112afcb7a6a35c4ef67f1bea827c4/w/100/h/100">https://tcs-devops.aliyuncs.com/thumbnail/112afcb7a6a35c4ef67f1bea827c4/w/100/h/100</a></para>
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
                /// <para>test-codeup</para>
                /// </summary>
                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("websiteUrl")]
                [Validation(Required=false)]
                public string WebsiteUrl { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:username@example.com">username@example.com</a></para>
            /// </summary>
            [NameInMap("authorEmail")]
            [Validation(Required=false)]
            public string AuthorEmail { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test-codeup</para>
            /// </summary>
            [NameInMap("authorName")]
            [Validation(Required=false)]
            public string AuthorName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-03-18 15:00:00</para>
            /// </summary>
            [NameInMap("authoredDate")]
            [Validation(Required=false)]
            public string AuthoredDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-03-18 16:00:00</para>
            /// </summary>
            [NameInMap("committedDate")]
            [Validation(Required=false)]
            public string CommittedDate { get; set; }

            [NameInMap("committer")]
            [Validation(Required=false)]
            public CreateCommitWithMultipleFilesResponseBodyResultCommitter Committer { get; set; }
            public class CreateCommitWithMultipleFilesResponseBodyResultCommitter : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>235671547828975455</para>
                /// </summary>
                [NameInMap("aliyunPk")]
                [Validation(Required=false)]
                public string AliyunPk { get; set; }

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
                /// <para>24661</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>committer-codeup</para>
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
                /// <para>committer-codeup</para>
                /// </summary>
                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("websiteUrl")]
                [Validation(Required=false)]
                public string WebsiteUrl { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:username@example.com">username@example.com</a></para>
            /// </summary>
            [NameInMap("committerEmail")]
            [Validation(Required=false)]
            public string CommitterEmail { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>committer-codeup</para>
            /// </summary>
            [NameInMap("committerName")]
            [Validation(Required=false)]
            public string CommitterName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-03-18 14:24:54</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>de02b625ba8488f92eb204bcb3773a40c1b4ddac</para>
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
            /// <para>de02b625</para>
            /// </summary>
            [NameInMap("shortId")]
            [Validation(Required=false)]
            public string ShortId { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

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
