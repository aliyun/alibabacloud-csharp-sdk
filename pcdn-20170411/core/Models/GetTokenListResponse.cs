// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pcdn20170411.Models
{
    public class GetTokenListResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public int? Code { get; set; }

        [NameInMap("TokenList")]
        [Validation(Required=true)]
        public GetTokenListResponseTokenList TokenList { get; set; }
        public class GetTokenListResponseTokenList : TeaModel {
            [NameInMap("Token")]
            [Validation(Required=true)]
            public List<GetTokenListResponseTokenListToken> Token { get; set; }
            public class GetTokenListResponseTokenListToken : TeaModel {
                public string ClientId { get; set; }
                public string ResourceId { get; set; }
                public string PlatformName { get; set; }
                public string PlatformType { get; set; }
                public string Token { get; set; }
                public string CreatedAt { get; set; }
                public string UpdatedAt { get; set; }
            }
        };

    }

}
