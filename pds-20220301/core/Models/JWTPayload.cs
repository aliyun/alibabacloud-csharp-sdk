// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class JWTPayload : TeaModel {
        [NameInMap("aud")]
        [Validation(Required=false)]
        public string Aud { get; set; }

        [NameInMap("auto_create")]
        [Validation(Required=false)]
        public bool? AutoCreate { get; set; }

        [NameInMap("exp")]
        [Validation(Required=false)]
        public long? Exp { get; set; }

        [NameInMap("iat")]
        [Validation(Required=false)]
        public long? Iat { get; set; }

        [NameInMap("iss")]
        [Validation(Required=false)]
        public string Iss { get; set; }

        [NameInMap("jti")]
        [Validation(Required=false)]
        public string Jti { get; set; }

        [NameInMap("nbf")]
        [Validation(Required=false)]
        public long? Nbf { get; set; }

        [NameInMap("sub")]
        [Validation(Required=false)]
        public string Sub { get; set; }

        [NameInMap("sub_type")]
        [Validation(Required=false)]
        public string SubType { get; set; }

    }

}
