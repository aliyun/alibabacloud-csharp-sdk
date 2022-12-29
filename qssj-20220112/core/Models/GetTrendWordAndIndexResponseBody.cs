// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qssj20220112.Models
{
    public class GetTrendWordAndIndexResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetTrendWordAndIndexResponseBodyData> Data { get; set; }
        public class GetTrendWordAndIndexResponseBodyData : TeaModel {
            [NameInMap("BrandIndex")]
            [Validation(Required=false)]
            public float? BrandIndex { get; set; }

            [NameInMap("CateId")]
            [Validation(Required=false)]
            public long? CateId { get; set; }

            [NameInMap("CateName")]
            [Validation(Required=false)]
            public string CateName { get; set; }

            [NameInMap("EcommerceIndex")]
            [Validation(Required=false)]
            public float? EcommerceIndex { get; set; }

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

            [NameInMap("TrendWord")]
            [Validation(Required=false)]
            public string TrendWord { get; set; }

            [NameInMap("YearMonth")]
            [Validation(Required=false)]
            public string YearMonth { get; set; }

        }

        [NameInMap("Massage")]
        [Validation(Required=false)]
        public string Massage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SuccessResponse")]
        [Validation(Required=false)]
        public string SuccessResponse { get; set; }

    }

}
