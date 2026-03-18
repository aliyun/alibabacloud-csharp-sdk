// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetStorageSummaryComparedResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetStorageSummaryComparedResponseBodyData Data { get; set; }
        public class GetStorageSummaryComparedResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The start date.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20250601</para>
            /// </summary>
            [NameInMap("beginDate")]
            [Validation(Required=false)]
            public string BeginDate { get; set; }

            /// <summary>
            /// <para>The end date.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20250604</para>
            /// </summary>
            [NameInMap("endDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            /// <summary>
            /// <para>The year-on-year (YoY) change rate of the storage usage from the start date to the end date. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>lowFreqStorageRate</para>
            /// </description></item>
            /// <item><description><para>totalStorageRate</para>
            /// </description></item>
            /// <item><description><para>standardStorageRate</para>
            /// </description></item>
            /// <item><description><para>longTermStorageRate</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("rate")]
            [Validation(Required=false)]
            public Dictionary<string, double?> Rate { get; set; }

            /// <summary>
            /// <para>The unit of the change in the storage usage from the start date to the end date. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>lowFreqStorageUnit</para>
            /// </description></item>
            /// <item><description><para>totalStorageUnit</para>
            /// </description></item>
            /// <item><description><para>standardStorageUnit</para>
            /// </description></item>
            /// <item><description><para>longTermStorageUnit</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("unit")]
            [Validation(Required=false)]
            public Dictionary<string, string> Unit { get; set; }

            /// <summary>
            /// <para>The change in the storage usage from the start date to the end date. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>lowFreqStorage</para>
            /// </description></item>
            /// <item><description><para>totalStorage</para>
            /// </description></item>
            /// <item><description><para>standardStorage</para>
            /// </description></item>
            /// <item><description><para>longTermStorage</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public Dictionary<string, double?> Value { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
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
        /// <para>plan \&quot;***\&quot; does not exist</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <list type="bullet">
        /// <item><description><para>1xx: informational response. The request is received and is being processed.</para>
        /// </description></item>
        /// <item><description><para>2xx: success. The request is successfully received, understood, and accepted by the server.</para>
        /// </description></item>
        /// <item><description><para>3xx: redirection. The request is redirected. You must take further action to complete the request.</para>
        /// </description></item>
        /// <item><description><para>4xx: client error. The request contains invalid parameters or syntax, or fails to meet specific conditions.</para>
        /// </description></item>
        /// <item><description><para>5xx: server error. The server cannot fulfill the request for other reasons.</para>
        /// </description></item>
        /// </list>
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
        /// <para>0bc3b4b016674434996033675e71ee</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
