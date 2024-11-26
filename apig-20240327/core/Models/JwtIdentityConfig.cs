// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class JwtIdentityConfig : TeaModel {
        [NameInMap("jwks")]
        [Validation(Required=false)]
        public string Jwks { get; set; }

        [NameInMap("jwtPayloadConfig")]
        [Validation(Required=false)]
        public JwtIdentityConfigJwtPayloadConfig JwtPayloadConfig { get; set; }
        public class JwtIdentityConfigJwtPayloadConfig : TeaModel {
            [NameInMap("payloadKeyName")]
            [Validation(Required=false)]
            public string PayloadKeyName { get; set; }

            [NameInMap("payloadKeyValue")]
            [Validation(Required=false)]
            public string PayloadKeyValue { get; set; }

        }

        [NameInMap("jwtTokenConfig")]
        [Validation(Required=false)]
        public JwtIdentityConfigJwtTokenConfig JwtTokenConfig { get; set; }
        public class JwtIdentityConfigJwtTokenConfig : TeaModel {
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("pass")]
            [Validation(Required=false)]
            public bool? Pass { get; set; }

            [NameInMap("position")]
            [Validation(Required=false)]
            public string Position { get; set; }

            [NameInMap("prefix")]
            [Validation(Required=false)]
            public string Prefix { get; set; }

        }

        [NameInMap("secretType")]
        [Validation(Required=false)]
        public string SecretType { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
