// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SubmitEmailVerificationResponseBody : TeaModel {
        [NameInMap("ExistList")]
        [Validation(Required=false)]
        public List<SubmitEmailVerificationResponseBodyExistList> ExistList { get; set; }
        public class SubmitEmailVerificationResponseBodyExistList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>SendTokenQuotaExceeded</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:username@example.com">username@example.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>The maximum number of attempts allowed to send the email verification link is exceeded.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        [NameInMap("FailList")]
        [Validation(Required=false)]
        public List<SubmitEmailVerificationResponseBodyFailList> FailList { get; set; }
        public class SubmitEmailVerificationResponseBodyFailList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>SendTokenQuotaExceeded</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:username@example.com">username@example.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>The maximum number of attempts allowed to send the email verification link is exceeded</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E2A8A5EF-DF8A-4C48-8FD4-9F6BD71AB26D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SuccessList")]
        [Validation(Required=false)]
        public List<SubmitEmailVerificationResponseBodySuccessList> SuccessList { get; set; }
        public class SubmitEmailVerificationResponseBodySuccessList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:username@example.com">username@example.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

    }

}
