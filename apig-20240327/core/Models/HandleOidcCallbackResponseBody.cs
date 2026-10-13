// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HandleOidcCallbackResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public HandleOidcCallbackResponseBodyData Data { get; set; }
        public class HandleOidcCallbackResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The access token returned for the current OIDC logon. The API definition marks this field as sensitive.</para>
            /// 
            /// <b>Example:</b>
            /// <para>access-token-xxxxxxxx</para>
            /// </summary>
            [NameInMap("accessToken")]
            [Validation(Required=false)]
            public string AccessToken { get; set; }

            /// <summary>
            /// <para>The validity period value of the access token. The unit is not specified in the API definition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("expiresIn")]
            [Validation(Required=false)]
            public long? ExpiresIn { get; set; }

            /// <summary>
            /// <para>The type identifier of the access token. The valid values are not specified in the API definition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>token-type-xxxxxxxx</para>
            /// </summary>
            [NameInMap("tokenType")]
            [Validation(Required=false)]
            public string TokenType { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>393E2630-DBE7-5221-AB35-9E740675491A</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
