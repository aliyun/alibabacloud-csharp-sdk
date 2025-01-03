// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListSearchCommitResponseBody : TeaModel {
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
        public List<ListSearchCommitResponseBodyResult> Result { get; set; }
        public class ListSearchCommitResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>60d54f3daccf2bbd6659f3ad/gitlabhq/master/config/environments/test.rb</para>
            /// </summary>
            [NameInMap("docId")]
            [Validation(Required=false)]
            public string DocId { get; set; }

            [NameInMap("highlightTextMap")]
            [Validation(Required=false)]
            public ListSearchCommitResponseBodyResultHighlightTextMap HighlightTextMap { get; set; }
            public class ListSearchCommitResponseBodyResultHighlightTextMap : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>df1b701cb0f3f7ca92320d49d31995821f2d045c</para>
                /// </summary>
                [NameInMap("commitId")]
                [Validation(Required=false)]
                public string CommitId { get; set; }

                [NameInMap("commitMessage")]
                [Validation(Required=false)]
                public string CommitMessage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>60de7a6852743a5162b5f957</para>
                /// </summary>
                [NameInMap("organizationId")]
                [Validation(Required=false)]
                public string OrganizationId { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("source")]
            [Validation(Required=false)]
            public ListSearchCommitResponseBodyResultSource Source { get; set; }
            public class ListSearchCommitResponseBodyResultSource : TeaModel {
                [NameInMap("author")]
                [Validation(Required=false)]
                public ListSearchCommitResponseBodyResultSourceAuthor Author { get; set; }
                public class ListSearchCommitResponseBodyResultSourceAuthor : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="mailto:username@example.com">username@example.com</a></para>
                    /// </summary>
                    [NameInMap("email")]
                    [Validation(Required=false)]
                    public string Email { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-11-11 11:11:11</para>
                /// </summary>
                [NameInMap("authorTime")]
                [Validation(Required=false)]
                public string AuthorTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>a748f5ecb17a93900d4808944bfcc96dc158ee2d</para>
                /// </summary>
                [NameInMap("commitId")]
                [Validation(Required=false)]
                public string CommitId { get; set; }

                [NameInMap("commitMessage")]
                [Validation(Required=false)]
                public string CommitMessage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>61133b011bd96aa110f1b500</para>
                /// </summary>
                [NameInMap("organizationId")]
                [Validation(Required=false)]
                public string OrganizationId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>codeup/test-repo</para>
                /// </summary>
                [NameInMap("repoPath")]
                [Validation(Required=false)]
                public string RepoPath { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

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
        /// <para>10</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
