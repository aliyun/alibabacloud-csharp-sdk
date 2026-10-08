// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SubmitEmailVerificationResponseBody : TeaModel {
        /// <summary>
        /// <para>List of emails for which verification messages already exist.</para>
        /// </summary>
        [NameInMap("ExistList")]
        [Validation(Required=false)]
        public List<SubmitEmailVerificationResponseBodyExistList> ExistList { get; set; }
        public class SubmitEmailVerificationResponseBodyExistList : TeaModel {
            /// <summary>
            /// <para>Returned code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SendTokenQuotaExceeded</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>Email address for verification.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:username@example.com">username@example.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>Returned message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The maximum number of attempts allowed to send the email verification link is exceeded.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        /// <summary>
        /// <para>List of emails for which verification messages failed to send.</para>
        /// </summary>
        [NameInMap("FailList")]
        [Validation(Required=false)]
        public List<SubmitEmailVerificationResponseBodyFailList> FailList { get; set; }
        public class SubmitEmailVerificationResponseBodyFailList : TeaModel {
            /// <summary>
            /// <para>The returned code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SendTokenQuotaExceeded</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>Email address for verification.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:username@example.com">username@example.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>The returned message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The maximum number of attempts allowed to send the email verification link is exceeded</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E2A8A5EF-DF8A-4C48-8FD4-9F6BD71AB26D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>List of emails for which verification messages were sent successfully.</para>
        /// </summary>
        [NameInMap("SuccessList")]
        [Validation(Required=false)]
        public List<SubmitEmailVerificationResponseBodySuccessList> SuccessList { get; set; }
        public class SubmitEmailVerificationResponseBodySuccessList : TeaModel {
            /// <summary>
            /// <para>Returned code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>Email address for verification.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:username@example.com">username@example.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>Returned message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

    }

}
