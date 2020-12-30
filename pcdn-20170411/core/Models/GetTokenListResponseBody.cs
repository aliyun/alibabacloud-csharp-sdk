// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pcdn20170411.Models
{
    public class GetTokenListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TokenList")]
        [Validation(Required=false)]
        public GetTokenListResponseBodyTokenList TokenList { get; set; }
        public class GetTokenListResponseBodyTokenList : TeaModel {
            [NameInMap("Token")]
            [Validation(Required=false)]
            public List<GetTokenListResponseBodyTokenListToken> Token { get; set; }
            public class GetTokenListResponseBodyTokenListToken : TeaModel {
                public string PlatformName { get; set; }
                public string Token { get; set; }
                public string PlatformType { get; set; }
                public string CreatedAt { get; set; }
                public string UpdatedAt { get; set; }
                public string ResourceId { get; set; }
                public string ClientId { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

    }

}
