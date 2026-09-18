// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetStorageAmountSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetStorageAmountSummaryResponseBodyData Data { get; set; }
        public class GetStorageAmountSummaryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The date for statistics collection, in the YYYYMMdd format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20241205</para>
            /// </summary>
            [NameInMap("date")]
            [Validation(Required=false)]
            public string Date { get; set; }

            /// <summary>
            /// <para>The timestamp. This API operation does not return this field.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

            /// <summary>
            /// <para>The unit of the storage metric. This API operation does not return this field.</para>
            /// </summary>
            [NameInMap("unit")]
            [Validation(Required=false)]
            public Dictionary<string, string> Unit { get; set; }

            /// <summary>
            /// <para>The storage metrics. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>projectAmount</description></item>
            /// <item><description>schemaAmount</description></item>
            /// <item><description>tableAmount</description></item>
            /// <item><description>partitionAmount</description></item>
            /// </list>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public Dictionary<string, long?> Value { get; set; }

        }

        /// <summary>
        /// <para>The business error code, or an empty value.</para>
        /// <list type="bullet">
        /// <item><description><para>If success is false, a business error code is returned.</para>
        /// </description></item>
        /// <item><description><para>If success is true, an empty value is returned.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this quota is not exist.</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>The HTTP status code that indicates whether the business request was successful. A non-empty value other than 200 indicates a business processing failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>688003E1-D1B4-5468-957E-2FFB3AC8D79B</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
