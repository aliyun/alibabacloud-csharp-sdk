// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Es_serverless20230627.Models
{
    public class GetAppQuotaResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2C5DAA30-****-5181-9B87-9D6181016197</para>
        /// </summary>
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
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("immutable")]
                    [Validation(Required=false)]
                    public bool? Immutable { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("maxValue")]
                    [Validation(Required=false)]
                    public long? MaxValue { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("minValue")]
                    [Validation(Required=false)]
                    public long? MinValue { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>INDEX_NUMBER_OF_SHARDS</para>
                    /// </summary>
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
