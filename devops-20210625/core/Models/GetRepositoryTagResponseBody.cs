// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetRepositoryTagResponseBody : TeaModel {
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
        /// <para>CE7353E3-F989-56A9-B97C-897ABBDB9A01</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetRepositoryTagResponseBodyResult Result { get; set; }
        public class GetRepositoryTagResponseBodyResult : TeaModel {
            [NameInMap("commit")]
            [Validation(Required=false)]
            public GetRepositoryTagResponseBodyResultCommit Commit { get; set; }
            public class GetRepositoryTagResponseBodyResultCommit : TeaModel {
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
                /// <para>2022-03-18 09:00:00</para>
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
                public GetRepositoryTagResponseBodyResultCommitSignature Signature { get; set; }
                public class GetRepositoryTagResponseBodyResultCommitSignature : TeaModel {
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
            /// <para>9a494e7b88ca35cde00579af2df4ab46136c022e</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tag v1.0</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

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
