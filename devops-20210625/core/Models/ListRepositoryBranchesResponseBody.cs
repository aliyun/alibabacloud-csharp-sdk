// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListRepositoryBranchesResponseBody : TeaModel {
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
        /// <para>1F4F342D-493A-5B2C-B133-BA78B30FF834</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListRepositoryBranchesResponseBodyResult> Result { get; set; }
        public class ListRepositoryBranchesResponseBodyResult : TeaModel {
            [NameInMap("commit")]
            [Validation(Required=false)]
            public ListRepositoryBranchesResponseBodyResultCommit Commit { get; set; }
            public class ListRepositoryBranchesResponseBodyResultCommit : TeaModel {
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
                /// <para>2022-03-18 10:00:00</para>
                /// </summary>
                [NameInMap("authoredDate")]
                [Validation(Required=false)]
                public string AuthoredDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-03-18 11:00:00</para>
                /// </summary>
                [NameInMap("committedDate")]
                [Validation(Required=false)]
                public string CommittedDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="mailto:username@example.com">username@example.com</a></para>
                /// </summary>
                [NameInMap("committerEmail")]
                [Validation(Required=false)]
                public string CommitterEmail { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>commit-codeup</para>
                /// </summary>
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
                /// <para>e0297d8f</para>
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
            /// <para>testBranch</para>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
