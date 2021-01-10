// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class GetGuidePageResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("MiniShopInfo")]
        [Validation(Required=false)]
        public List<GetGuidePageResponseBodyMiniShopInfo> MiniShopInfo { get; set; }
        public class GetGuidePageResponseBodyMiniShopInfo : TeaModel {
            [NameInMap("LiteShopId")]
            [Validation(Required=false)]
            public string LiteShopId { get; set; }

            [NameInMap("Src")]
            [Validation(Required=false)]
            public string Src { get; set; }

            [NameInMap("BizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
