// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qssj20220112.Models
{
    public class GetOpportunityMarketResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetOpportunityMarketResponseBodyData> Data { get; set; }
        public class GetOpportunityMarketResponseBodyData : TeaModel {
            [NameInMap("CateName")]
            [Validation(Required=false)]
            public string CateName { get; set; }

            [NameInMap("OpportunityIndex")]
            [Validation(Required=false)]
            public double? OpportunityIndex { get; set; }

            [NameInMap("RelativeCommodity")]
            [Validation(Required=false)]
            public double? RelativeCommodity { get; set; }

            [NameInMap("RelativeDischarge")]
            [Validation(Required=false)]
            public double? RelativeDischarge { get; set; }

            [NameInMap("TimeUnit")]
            [Validation(Required=false)]
            public string TimeUnit { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SuccessResponse")]
        [Validation(Required=false)]
        public bool? SuccessResponse { get; set; }

    }

}
