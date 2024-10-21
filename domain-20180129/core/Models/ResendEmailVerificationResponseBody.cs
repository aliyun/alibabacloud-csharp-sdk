// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class ResendEmailVerificationResponseBody : TeaModel {
        [NameInMap("FailList")]
        [Validation(Required=false)]
        public List<ResendEmailVerificationResponseBodyFailList> FailList { get; set; }
        public class ResendEmailVerificationResponseBodyFailList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>SendTokenQuotaExceeded</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:test1@aliyun.com">test1@aliyun.com</a></para>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>0EA54E99-DB48-4CE3-A099-6ED8E451B8AC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SuccessList")]
        [Validation(Required=false)]
        public List<ResendEmailVerificationResponseBodySuccessList> SuccessList { get; set; }
        public class ResendEmailVerificationResponseBodySuccessList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:test2@aliyun.com">test2@aliyun.com</a></para>
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
