// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imagerecog20190930.Models
{
    public class EvaluateCertificateQualityResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public EvaluateCertificateQualityResponseBodyData Data { get; set; }
        public class EvaluateCertificateQualityResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<EvaluateCertificateQualityResponseBodyDataElements> Elements { get; set; }
            public class EvaluateCertificateQualityResponseBodyDataElements : TeaModel {
                [NameInMap("Pass")]
                [Validation(Required=false)]
                public string Pass { get; set; }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
