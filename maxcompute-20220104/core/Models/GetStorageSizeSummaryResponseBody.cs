// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetStorageSizeSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetStorageSizeSummaryResponseBodyData Data { get; set; }
        public class GetStorageSizeSummaryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The date of statistics.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20241205</para>
            /// </summary>
            [NameInMap("date")]
            [Validation(Required=false)]
            public string Date { get; set; }

            /// <summary>
            /// <para>The timestamp of the last data update.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1749090705919</para>
            /// </summary>
            [NameInMap("timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

            /// <summary>
            /// <para>The unit of the storage metric usage. It includes:</para>
            /// <list type="bullet">
            /// <item><description><para>lowFreqStorage</para>
            /// </description></item>
            /// <item><description><para>standardStorage</para>
            /// </description></item>
            /// <item><description><para>longTermStorage</para>
            /// </description></item>
            /// <item><description><para>totalStorage</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("unit")]
            [Validation(Required=false)]
            public Dictionary<string, string> Unit { get; set; }

            /// <summary>
            /// <para>The storage metrics. It includes:</para>
            /// <list type="bullet">
            /// <item><description><para>lowFreqStorage</para>
            /// </description></item>
            /// <item><description><para>standardStorage</para>
            /// </description></item>
            /// <item><description><para>longTermStorage</para>
            /// </description></item>
            /// <item><description><para>totalStorage</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public Dictionary<string, double?> Value { get; set; }

        }

        /// <summary>
        /// <para>The business error code or an empty value.</para>
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
        /// <para>The description of the error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this quota is not exist.</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>Indicates whether the business is successful. If this parameter is not empty and the value is not 200, the business fails.</para>
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
        /// <para>0be3e0aa16667684362147582e038f</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
