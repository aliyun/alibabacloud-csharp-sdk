// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetCompareDetailResponseBody : TeaModel {
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
        /// <para>ASSDS-ASSASX-XSAXSA-XSAXSAXS</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetCompareDetailResponseBodyResult Result { get; set; }
        public class GetCompareDetailResponseBodyResult : TeaModel {
            [NameInMap("commits")]
            [Validation(Required=false)]
            public List<GetCompareDetailResponseBodyResultCommits> Commits { get; set; }
            public class GetCompareDetailResponseBodyResultCommits : TeaModel {
                [NameInMap("author")]
                [Validation(Required=false)]
                public GetCompareDetailResponseBodyResultCommitsAuthor Author { get; set; }
                public class GetCompareDetailResponseBodyResultCommitsAuthor : TeaModel {
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
                    /// <para>21396</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

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
                    /// <para>Codeup</para>
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
                /// <para>2023-01-03T15:41:26+08:00</para>
                /// </summary>
                [NameInMap("authoredDate")]
                [Validation(Required=false)]
                public string AuthoredDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("commentsCount")]
                [Validation(Required=false)]
                public long? CommentsCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-01-03T15:41:26+08:00</para>
                /// </summary>
                [NameInMap("committedDate")]
                [Validation(Required=false)]
                public string CommittedDate { get; set; }

                [NameInMap("committer")]
                [Validation(Required=false)]
                public GetCompareDetailResponseBodyResultCommitsCommitter Committer { get; set; }
                public class GetCompareDetailResponseBodyResultCommitsCommitter : TeaModel {
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
                    /// <para>43910</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

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
                    /// <para>Codeup-commiter</para>
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
                /// <para>2023-01-03T15:41:26+08:00</para>
                /// </summary>
                [NameInMap("createdAt")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>b8f6f28520b1936aafe2e638373e19ccafa42b02</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("parentIds")]
                [Validation(Required=false)]
                public List<string> ParentIds { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>b8f6f285</para>
                /// </summary>
                [NameInMap("shortId")]
                [Validation(Required=false)]
                public string ShortId { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("diffs")]
            [Validation(Required=false)]
            public List<GetCompareDetailResponseBodyResultDiffs> Diffs { get; set; }
            public class GetCompareDetailResponseBodyResultDiffs : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>100644</para>
                /// </summary>
                [NameInMap("aMode")]
                [Validation(Required=false)]
                public string AMode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100644</para>
                /// </summary>
                [NameInMap("bMode")]
                [Validation(Required=false)]
                public string BMode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("deletedFile")]
                [Validation(Required=false)]
                public bool? DeletedFile { get; set; }

                [NameInMap("diff")]
                [Validation(Required=false)]
                public string Diff { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("isBinary")]
                [Validation(Required=false)]
                public bool? IsBinary { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("isNewLfs")]
                [Validation(Required=false)]
                public bool? IsNewLfs { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("isOldLfs")]
                [Validation(Required=false)]
                public bool? IsOldLfs { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("newFile")]
                [Validation(Required=false)]
                public bool? NewFile { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cb75846da2df3d3d7f290c3569236fcf3dd17224</para>
                /// </summary>
                [NameInMap("newId")]
                [Validation(Required=false)]
                public string NewId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>new_test.txt</para>
                /// </summary>
                [NameInMap("newPath")]
                [Validation(Required=false)]
                public string NewPath { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>6c268061a546378276559c713d0ad377d4dsjfh</para>
                /// </summary>
                [NameInMap("oldId")]
                [Validation(Required=false)]
                public string OldId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test.txt</para>
                /// </summary>
                [NameInMap("oldPath")]
                [Validation(Required=false)]
                public string OldPath { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("renamedFile")]
                [Validation(Required=false)]
                public bool? RenamedFile { get; set; }

            }

            [NameInMap("messages")]
            [Validation(Required=false)]
            public List<string> Messages { get; set; }

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
