// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GenerateWebAuthnAuthenticatorRegistrationUrlResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("WebAuthnAuthenticatorRegistrationUrl")]
        [Validation(Required=false)]
        public GenerateWebAuthnAuthenticatorRegistrationUrlResponseBodyWebAuthnAuthenticatorRegistrationUrl WebAuthnAuthenticatorRegistrationUrl { get; set; }
        public class GenerateWebAuthnAuthenticatorRegistrationUrlResponseBodyWebAuthnAuthenticatorRegistrationUrl : TeaModel {
            /// <summary>
            /// <para>注册WebAuthn认证器URL</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://012cnaliyunidaas..com./login/webauthn/registration">https://012cnaliyunidaas..com./login/webauthn/registration</a></para>
            /// </summary>
            [NameInMap("RegistrationUrl")]
            [Validation(Required=false)]
            public string RegistrationUrl { get; set; }

            /// <summary>
            /// <para>注册WebAuthn认证器URL参数</para>
            /// 
            /// <b>Example:</b>
            /// <para>eyJhbGciOiJkaXIiLCJlbmMiOiJBMjU2R0NNIiwia2lkIjoia2V5X29ueWNzbXNib3Y1bmV2anlncHgyZnlsbjdhIn0</para>
            /// </summary>
            [NameInMap("RegistrationUrlParameters")]
            [Validation(Required=false)]
            public string RegistrationUrlParameters { get; set; }

        }

    }

}
