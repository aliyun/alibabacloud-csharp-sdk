// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class GetAccessTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code of the response. A value of <c>SUCCESS</c> indicates that the request was successful. For failures, this parameter returns an error code, such as <c>ERR_BAD_REQUEST</c>, <c>ERR_VALIDATION_FAILED</c>, or <c>ERR_INTERNAL_SERVER_ERROR</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetAccessTokenResponseBodyData Data { get; set; }
        public class GetAccessTokenResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The personal access token. You can use this token to authenticate subsequent API calls. This authentication method is an alternative to using an Alibaba Cloud AccessKey pair or temporary credentials provided by the Security Token Service (STS).</para>
            /// 
            /// <b>Example:</b>
            /// <para>accessToken</para>
            /// </summary>
            [NameInMap("accessToken")]
            [Validation(Required=false)]
            public string AccessToken { get; set; }

        }

        /// <summary>
        /// <para>The unique request ID. This ID is used for troubleshooting purposes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F8A0F5F3-0C3E-4C82-9D4F-5E4B6A7C8D9E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
