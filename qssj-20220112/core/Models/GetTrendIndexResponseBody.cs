// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qssj20220112.Models
{
    public class GetTrendIndexResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetTrendIndexResponseBodyData> Data { get; set; }
        public class GetTrendIndexResponseBodyData : TeaModel {
            [NameInMap("BrandIndex")]
            [Validation(Required=false)]
            public float? BrandIndex { get; set; }

            [NameInMap("ECommerceIndex")]
            [Validation(Required=false)]
            public float? ECommerceIndex { get; set; }

            [NameInMap("InstitutionalIndex")]
            [Validation(Required=false)]
            public float? InstitutionalIndex { get; set; }

            [NameInMap("MediaIndex")]
            [Validation(Required=false)]
            public float? MediaIndex { get; set; }

            [NameInMap("SocialIndex")]
            [Validation(Required=false)]
            public float? SocialIndex { get; set; }

            [NameInMap("TrendIndex")]
            [Validation(Required=false)]
            public float? TrendIndex { get; set; }

            [NameInMap("YearMonth")]
            [Validation(Required=false)]
            public string YearMonth { get; set; }

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
