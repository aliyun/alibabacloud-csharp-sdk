// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class JWTAuthConfig : TeaModel {
        [NameInMap("blackList")]
        [Validation(Required=false)]
        public string BlackList { get; set; }

        [NameInMap("claimPassBy")]
        [Validation(Required=false)]
        public List<string> ClaimPassBy { get; set; }

        [NameInMap("jwks")]
        [Validation(Required=false)]
        public string Jwks { get; set; }

        [NameInMap("tokenLookup")]
        [Validation(Required=false)]
        public List<string> TokenLookup { get; set; }

        [NameInMap("whiteList")]
        [Validation(Required=false)]
        public List<string> WhiteList { get; set; }

    }

}
