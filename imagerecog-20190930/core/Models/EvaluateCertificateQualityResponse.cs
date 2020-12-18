// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imagerecog20190930.Models
{
    public class EvaluateCertificateQualityResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public EvaluateCertificateQualityResponseData Data { get; set; }
        public class EvaluateCertificateQualityResponseData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=true)]
            public List<EvaluateCertificateQualityResponseDataElements> Elements { get; set; }
            public class EvaluateCertificateQualityResponseDataElements : TeaModel {
                public string Value { get; set; }
                public string Pass { get; set; }
                public string Score { get; set; }
            }
        };

    }

}
