// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class DeleteEmailVerificationResponseBody : TeaModel {
        [NameInMap("FailList")]
        [Validation(Required=false)]
        public List<DeleteEmailVerificationResponseBodyFailList> FailList { get; set; }
        public class DeleteEmailVerificationResponseBodyFailList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ParameterIllegall</para>
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
            /// <para>Parameter error</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7A3D0E4A-0D4B-4BD0-90D7-A61DF8DD26AE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SuccessList")]
        [Validation(Required=false)]
        public List<DeleteEmailVerificationResponseBodySuccessList> SuccessList { get; set; }
        public class DeleteEmailVerificationResponseBodySuccessList : TeaModel {
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
