// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetFileLastCommitResponseBody : TeaModel {
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
        public GetFileLastCommitResponseBodyResult Result { get; set; }
        public class GetFileLastCommitResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-08-08 18:09:09</para>
            /// </summary>
            [NameInMap("authorDate")]
            [Validation(Required=false)]
            public string AuthorDate { get; set; }

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
            /// <para>2022-03-18 15:00:02</para>
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
            /// <para>ff4fb5ac6d1f44f452654336d2dba468ae6c8d04</para>
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
            /// <para>ff4fb5ac</para>
            /// </summary>
            [NameInMap("shortId")]
            [Validation(Required=false)]
            public string ShortId { get; set; }

            [NameInMap("signature")]
            [Validation(Required=false)]
            public GetFileLastCommitResponseBodyResultSignature Signature { get; set; }
            public class GetFileLastCommitResponseBodyResultSignature : TeaModel {
                /// <summary>
                /// <para>GPG密钥ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>34d2c47c7ce46a5c4639c5ffe208</para>
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
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
