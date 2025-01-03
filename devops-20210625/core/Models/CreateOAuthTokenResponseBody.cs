// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateOAuthTokenResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Openapi.RequestError</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>”“</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C2F153F6-BB43-50C4-9F4F-40593203E19A</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateOAuthTokenResponseBodyResult Result { get; set; }
        public class CreateOAuthTokenResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2aeb4cd012af879e54f0d37dfa526f51</para>
            /// </summary>
            [NameInMap("accessToken")]
            [Validation(Required=false)]
            public string AccessToken { get; set; }

            /// <summary>
            /// <para>id</para>
            /// 
            /// <b>Example:</b>
            /// <para>30815</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>read:repo</para>
            /// </summary>
            [NameInMap("scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>code</para>
            /// </summary>
            [NameInMap("tokenType")]
            [Validation(Required=false)]
            public string TokenType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
