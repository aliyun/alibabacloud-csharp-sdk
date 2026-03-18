// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class SumStorageMetricsByDateResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<SumStorageMetricsByDateResponseBodyData> Data { get; set; }
        public class SumStorageMetricsByDateResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The date of the statistics. The format is yyyyMMdd.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20250719</para>
            /// </summary>
            [NameInMap("dateTime")]
            [Validation(Required=false)]
            public string DateTime { get; set; }

            /// <summary>
            /// <para>A list of storage usage for the specified type.</para>
            /// </summary>
            [NameInMap("itemStorageMetrics")]
            [Validation(Required=false)]
            public List<SumStorageMetricsByDateResponseBodyDataItemStorageMetrics> ItemStorageMetrics { get; set; }
            public class SumStorageMetricsByDateResponseBodyDataItemStorageMetrics : TeaModel {
                /// <summary>
                /// <para>If the specified type is PROJECT, this parameter indicates the project name. If the specified type is STORAGE_TYPE, this parameter indicates the storage class.</para>
                /// 
                /// <b>Example:</b>
                /// <para>prj</para>
                /// </summary>
                [NameInMap("itemName")]
                [Validation(Required=false)]
                public string ItemName { get; set; }

                /// <summary>
                /// <para>The percentage of the storage usage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>91.22</para>
                /// </summary>
                [NameInMap("percentage")]
                [Validation(Required=false)]
                public double? Percentage { get; set; }

                /// <summary>
                /// <para>The storage usage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300.560392</para>
                /// </summary>
                [NameInMap("usage")]
                [Validation(Required=false)]
                public string Usage { get; set; }

            }

            /// <summary>
            /// <para>The storage class. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Storage. Standard storage.</description></item>
            /// <item><description>LowFreqStorage. IA storage class.</description></item>
            /// <item><description>ColdStorage. Archive storage.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Storage</para>
            /// </summary>
            [NameInMap("storageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// <para>The unit of the total storage usage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GB</para>
            /// </summary>
            [NameInMap("unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

            /// <summary>
            /// <para>The total storage usage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>329.503338</para>
            /// </summary>
            [NameInMap("usage")]
            [Validation(Required=false)]
            public string Usage { get; set; }

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
        /// <para>this quota is not exist.</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <list type="bullet">
        /// <item><description>1xx: Informational response. The request has been received and is being processed.</description></item>
        /// <item><description>2xx: Success. The action was successfully received, understood, and accepted by the server.</description></item>
        /// <item><description>3xx: Redirection. The request was redirected, and further action is required to complete the request.</description></item>
        /// <item><description>4xx: Client error. The request contains invalid request parameters or syntax, or specific request conditions cannot be met.</description></item>
        /// <item><description>5xx: Server error. The server failed to fulfill the request for other reasons.</description></item>
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
        /// <para>0abb781a17411408145995819e0dae</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
