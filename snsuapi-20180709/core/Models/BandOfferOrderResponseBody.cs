// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Snsuapi20180709.Models
{
    public class BandOfferOrderResponseBody : TeaModel {
        [NameInMap("ResultModule")]
        [Validation(Required=false)]
        public BandOfferOrderResponseBodyResultModule ResultModule { get; set; }
        public class BandOfferOrderResponseBodyResultModule : TeaModel {
            [NameInMap("LxOrderId")]
            [Validation(Required=false)]
            public long? LxOrderId { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
