// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class JwtIdentityConfig : TeaModel {
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
            /// <para>The key in the JWT payload.</para>
            /// 
            /// <b>Example:</b>
            /// <para>uid</para>
            /// </summary>
            [NameInMap("payloadKeyName")]
            [Validation(Required=false)]
            public string PayloadKeyName { get; set; }

            /// <summary>
            /// <para>The value for the JWT payload key.</para>
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
            /// <para>The key used for the JWT.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Authorization</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>Indicates whether acceptance is granted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("pass")]
            [Validation(Required=false)]
            public bool? Pass { get; set; }

            /// <summary>
            /// <para>The location where the JWT is stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HEADER</para>
            /// </summary>
            [NameInMap("position")]
            [Validation(Required=false)]
            public string Position { get; set; }

            /// <summary>
            /// <para>The token prefix configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("prefix")]
            [Validation(Required=false)]
            public string Prefix { get; set; }

        }

        /// <summary>
        /// <para>The type of the secret used.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Asymmetry: asymmetric encryption.</description></item>
        /// <item><description>Symmetry: symmetric encryption.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Symmetry</para>
        /// </summary>
        [NameInMap("secretType")]
        [Validation(Required=false)]
        public string SecretType { get; set; }

        /// <summary>
        /// <para>The authentication configuration type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Jwt</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
