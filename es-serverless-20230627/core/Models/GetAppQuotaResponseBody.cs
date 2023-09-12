// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Es_serverless20230627.Models
{
    public class GetAppQuotaResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetAppQuotaResponseBodyResult Result { get; set; }
        public class GetAppQuotaResponseBodyResult : TeaModel {
            [NameInMap("limiterInfo")]
            [Validation(Required=false)]
            public GetAppQuotaResponseBodyResultLimiterInfo LimiterInfo { get; set; }
            public class GetAppQuotaResponseBodyResultLimiterInfo : TeaModel {
                [NameInMap("limiters")]
                [Validation(Required=false)]
                public List<GetAppQuotaResponseBodyResultLimiterInfoLimiters> Limiters { get; set; }
                public class GetAppQuotaResponseBodyResultLimiterInfoLimiters : TeaModel {
                    [NameInMap("immutable")]
                    [Validation(Required=false)]
                    public bool? Immutable { get; set; }

                    [NameInMap("maxValue")]
                    [Validation(Required=false)]
                    public long? MaxValue { get; set; }

                    [NameInMap("minValue")]
                    [Validation(Required=false)]
                    public long? MinValue { get; set; }

                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            [NameInMap("quotaInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> QuotaInfo { get; set; }

        }

    }

}
