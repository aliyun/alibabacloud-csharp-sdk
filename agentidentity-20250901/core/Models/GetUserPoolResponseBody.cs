// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class GetUserPoolResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AABD6E03-4B3A-5687-88FF-72232670ED0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The user pool information.</para>
        /// </summary>
        [NameInMap("UserPool")]
        [Validation(Required=false)]
        public GetUserPoolResponseBodyUserPool UserPool { get; set; }
        public class GetUserPoolResponseBodyUserPool : TeaModel {
            /// <summary>
            /// <para>The creation time in ISO 8601 format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-05-07T06:19:17Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the user pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sample user pool</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The discovery URL for the OpenID Connect (OIDC) protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://signin-cn-beijing.aliyunagentid.com/up_7b6908bcb9ba4c****c8e187/.well-known/openid-configuration">https://signin-cn-beijing.aliyunagentid.com/up_7b6908bcb9ba4c****c8e187/.well-known/openid-configuration</a></para>
            /// </summary>
            [NameInMap("OIDCDiscoveryURL")]
            [Validation(Required=false)]
            public string OIDCDiscoveryURL { get; set; }

            /// <summary>
            /// <para>The base URL for logon.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://pre-signin-cn-hangzhou.aliyunagentid.com/up_e14d889*****716841">https://pre-signin-cn-hangzhou.aliyunagentid.com/up_e14d889*****716841</a></para>
            /// </summary>
            [NameInMap("SigninBaseURL")]
            [Validation(Required=false)]
            public string SigninBaseURL { get; set; }

            /// <summary>
            /// <para>The source platform.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Manual</para>
            /// </summary>
            [NameInMap("SourcePlatform")]
            [Validation(Required=false)]
            public string SourcePlatform { get; set; }

            /// <summary>
            /// <para>The update time in ISO 8601 format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-05-07T06:19:17Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The ID of the user pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>up_xxxxxxxxxxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("UserPoolId")]
            [Validation(Required=false)]
            public string UserPoolId { get; set; }

            /// <summary>
            /// <para>The name of the user pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-agent-userpool</para>
            /// </summary>
            [NameInMap("UserPoolName")]
            [Validation(Required=false)]
            public string UserPoolName { get; set; }

        }

    }

}
