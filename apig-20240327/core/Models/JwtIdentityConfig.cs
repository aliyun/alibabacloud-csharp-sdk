// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class JwtIdentityConfig : TeaModel {
        /// <summary>
        /// <para>The claims-to-headers configurations.</para>
        /// </summary>
        [NameInMap("claimsToHeadersConfigs")]
        [Validation(Required=false)]
        public List<JwtIdentityConfigClaimsToHeadersConfigs> ClaimsToHeadersConfigs { get; set; }
        public class JwtIdentityConfigClaimsToHeadersConfigs : TeaModel {
            /// <summary>
            /// <para>The claim.</para>
            /// </summary>
            [NameInMap("claim")]
            [Validation(Required=false)]
            public string Claim { get; set; }

            /// <summary>
            /// <para>The header.</para>
            /// </summary>
            [NameInMap("header")]
            [Validation(Required=false)]
            public string Header { get; set; }

            /// <summary>
            /// <para>The override.</para>
            /// </summary>
            [NameInMap("override")]
            [Validation(Required=false)]
            public bool? Override { get; set; }

        }

        /// <summary>
        /// <para>The JWKS configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("jwks")]
        [Validation(Required=false)]
        public string Jwks { get; set; }

        /// <summary>
        /// <para>The JWT payload configuration.</para>
        /// </summary>
        [NameInMap("jwtPayloadConfig")]
        [Validation(Required=false)]
        public JwtIdentityConfigJwtPayloadConfig JwtPayloadConfig { get; set; }
        public class JwtIdentityConfigJwtPayloadConfig : TeaModel {
            /// <summary>
            /// <para>The JWT payload key configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>uid</para>
            /// </summary>
            [NameInMap("payloadKeyName")]
            [Validation(Required=false)]
            public string PayloadKeyName { get; set; }

            /// <summary>
            /// <para>The JWT payload value configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2222</para>
            /// </summary>
            [NameInMap("payloadKeyValue")]
            [Validation(Required=false)]
            public string PayloadKeyValue { get; set; }

        }

        /// <summary>
        /// <para>The JWT token configuration.</para>
        /// </summary>
        [NameInMap("jwtTokenConfig")]
        [Validation(Required=false)]
        public JwtIdentityConfigJwtTokenConfig JwtTokenConfig { get; set; }
        public class JwtIdentityConfigJwtTokenConfig : TeaModel {
            /// <summary>
            /// <para>The JWT key configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Authorization</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>Specifies whether to pass through.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("pass")]
            [Validation(Required=false)]
            public bool? Pass { get; set; }

            /// <summary>
            /// <para>The storage location of the JWT.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HEADER</para>
            /// </summary>
            [NameInMap("position")]
            [Validation(Required=false)]
            public string Position { get; set; }

            /// <summary>
            /// <para>The prefix configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("prefix")]
            [Validation(Required=false)]
            public string Prefix { get; set; }

        }

        /// <summary>
        /// <para>The remote JWKS.</para>
        /// </summary>
        [NameInMap("remoteJwks")]
        [Validation(Required=false)]
        public string RemoteJwks { get; set; }

        /// <summary>
        /// <para>The secret type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Symmetry</para>
        /// </summary>
        [NameInMap("secretType")]
        [Validation(Required=false)]
        public string SecretType { get; set; }

        /// <summary>
        /// <para>The type of authentication configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Jwt</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
