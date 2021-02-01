// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imagerecog20190930.Models
{
    public class EvaluateCertificateQualityResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public EvaluateCertificateQualityResponseBodyData Data { get; set; }
        public class EvaluateCertificateQualityResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<EvaluateCertificateQualityResponseBodyDataElements> Elements { get; set; }
            public class EvaluateCertificateQualityResponseBodyDataElements : TeaModel {
                public string Value { get; set; }
                public string Pass { get; set; }
                public string Score { get; set; }
            }
        };

    }

}
