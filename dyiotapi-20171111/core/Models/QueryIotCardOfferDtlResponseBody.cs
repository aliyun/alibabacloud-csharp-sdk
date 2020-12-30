// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyiotapi20171111.Models
{
    public class QueryIotCardOfferDtlResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("CardOfferDetail")]
        [Validation(Required=false)]
        public QueryIotCardOfferDtlResponseBodyCardOfferDetail CardOfferDetail { get; set; }
        public class QueryIotCardOfferDtlResponseBodyCardOfferDetail : TeaModel {
            [NameInMap("detail")]
            [Validation(Required=false)]
            public List<QueryIotCardOfferDtlResponseBodyCardOfferDetailDetail> Detail { get; set; }
            public class QueryIotCardOfferDtlResponseBodyCardOfferDetailDetail : TeaModel {
                public string EffectiveTime { get; set; }
                public string OfferId { get; set; }
                public string OfferName { get; set; }
                public string ExpireTime { get; set; }
                public string OrderTime { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
