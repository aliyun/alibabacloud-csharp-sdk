// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetAuthorizationServerResponseBody : TeaModel {
        /// <summary>
        /// <para>The authorization server.</para>
        /// </summary>
        [NameInMap("AuthorizationServer")]
        [Validation(Required=false)]
        public GetAuthorizationServerResponseBodyAuthorizationServer AuthorizationServer { get; set; }
        public class GetAuthorizationServerResponseBodyAuthorizationServer : TeaModel {
            /// <summary>
            /// <para>The authorization server ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>iauths_system</para>
            /// </summary>
            [NameInMap("AuthorizationServerId")]
            [Validation(Required=false)]
            public string AuthorizationServerId { get; set; }

            /// <summary>
            /// <para>The name of the authorization server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>System_Default</para>
            /// </summary>
            [NameInMap("AuthorizationServerName")]
            [Validation(Required=false)]
            public string AuthorizationServerName { get; set; }

            /// <summary>
            /// <para>The time when the authorization server was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1754620108295</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The creation type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>system_init</para>
            /// </summary>
            [NameInMap("CreationType")]
            [Validation(Required=false)]
            public string CreationType { get; set; }

            /// <summary>
            /// <para>The description of the authorization server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>description of authorization server</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_qzljgbhtwnnsywtdbz7yzy2any</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The issuer of the authorization token.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxxx.aliyunidaas.com/api/v2/iauths_system/oauth2">https://xxxx.aliyunidaas.com/api/v2/iauths_system/oauth2</a></para>
            /// </summary>
            [NameInMap("Issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }

            /// <summary>
            /// <para>The domain name used by the issuer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxx.aliyunidaas.com</para>
            /// </summary>
            [NameInMap("IssuerDomain")]
            [Validation(Required=false)]
            public string IssuerDomain { get; set; }

            /// <summary>
            /// <para>The issuer mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>static</para>
            /// </summary>
            [NameInMap("IssuerMode")]
            [Validation(Required=false)]
            public string IssuerMode { get; set; }

            /// <summary>
            /// <para>The time when the authorization server was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1781608572164</para>
            /// </summary>
            [NameInMap("LastUpdateTime")]
            [Validation(Required=false)]
            public long? LastUpdateTime { get; set; }

            /// <summary>
            /// <para>The endpoint configuration of the authorization server.</para>
            /// </summary>
            [NameInMap("ProtocolEndpoint")]
            [Validation(Required=false)]
            public GetAuthorizationServerResponseBodyAuthorizationServerProtocolEndpoint ProtocolEndpoint { get; set; }
            public class GetAuthorizationServerResponseBodyAuthorizationServerProtocolEndpoint : TeaModel {
                /// <summary>
                /// <para>The token endpoint of the authorization server.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://xxxx.aliyunidaas.com/api/v2/iauths_system/oauth2/token">https://xxxx.aliyunidaas.com/api/v2/iauths_system/oauth2/token</a></para>
                /// </summary>
                [NameInMap("Oauth2TokenEndpoint")]
                [Validation(Required=false)]
                public string Oauth2TokenEndpoint { get; set; }

                /// <summary>
                /// <para>The JWKS endpoint of the authorization server.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://xxxx.aliyunidaas.com/api/v2/iauths_system/oauth2/jwks">https://xxxx.aliyunidaas.com/api/v2/iauths_system/oauth2/jwks</a></para>
                /// </summary>
                [NameInMap("OidcJwksEndpoint")]
                [Validation(Required=false)]
                public string OidcJwksEndpoint { get; set; }

            }

            /// <summary>
            /// <para>The status of the authorization server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ENABLE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
