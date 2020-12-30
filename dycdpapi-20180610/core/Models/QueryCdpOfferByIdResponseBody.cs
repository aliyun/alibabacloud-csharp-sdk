// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dycdpapi20180610.Models
{
    public class QueryCdpOfferByIdResponseBody : TeaModel {
        [NameInMap("FlowOffers")]
        [Validation(Required=false)]
        public QueryCdpOfferByIdResponseBodyFlowOffers FlowOffers { get; set; }
        public class QueryCdpOfferByIdResponseBodyFlowOffers : TeaModel {
            [NameInMap("FlowOffer")]
            [Validation(Required=false)]
            public List<QueryCdpOfferByIdResponseBodyFlowOffersFlowOffer> FlowOffer { get; set; }
            public class QueryCdpOfferByIdResponseBodyFlowOffersFlowOffer : TeaModel {
                public string Right { get; set; }
                public string UseEff { get; set; }
                public string ChannelType { get; set; }
                public string UseLimit { get; set; }
                public string UseScene { get; set; }
                public string Vendor { get; set; }
                public string Grade { get; set; }
                public long? OfferId { get; set; }
                public long? Price { get; set; }
                public string FlowType { get; set; }
                public string Discount { get; set; }
                public string Province { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
