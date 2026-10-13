// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class SumStorageMetricsByTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<SumStorageMetricsByTypeResponseBodyData> Data { get; set; }
        public class SumStorageMetricsByTypeResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of daily storage usage statistics.</para>
            /// </summary>
            [NameInMap("dailyStorageMetrics")]
            [Validation(Required=false)]
            public List<SumStorageMetricsByTypeResponseBodyDataDailyStorageMetrics> DailyStorageMetrics { get; set; }
            public class SumStorageMetricsByTypeResponseBodyDataDailyStorageMetrics : TeaModel {
                /// <summary>
                /// <para>The statistics date. Format: yyyyMMdd.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20260410</para>
                /// </summary>
                [NameInMap("dateTime")]
                [Validation(Required=false)]
                public string DateTime { get; set; }

                /// <summary>
                /// <para>The storage usage percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("percentage")]
                [Validation(Required=false)]
                public double? Percentage { get; set; }

                /// <summary>
                /// <para>The storage type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Storage: standard storage.</description></item>
                /// <item><description>LowFreqStorage: infrequent access storage.</description></item>
                /// <item><description>ColdStorage: long-term storage.</description></item>
                /// <item><description>$sum: total storage.</description></item>
                /// <item><description>RecycleBinStorage: backup storage.</description></item>
                /// <item><description>DRStorage: multi-AZ storage.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Storage</para>
                /// </summary>
                [NameInMap("storageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

                /// <summary>
                /// <para>The unit of the storage metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GB</para>
                /// </summary>
                [NameInMap("unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

                /// <summary>
                /// <para>The storage usage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("usage")]
                [Validation(Required=false)]
                public double? Usage { get; set; }

            }

            /// <summary>
            /// <para>The storage type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Storage: standard storage.</description></item>
            /// <item><description>LowFreqStorage: infrequent access storage.</description></item>
            /// <item><description>ColdStorage: long-term storage.</description></item>
            /// <item><description>$sum: total storage.</description></item>
            /// <item><description>RecycleBinStorage: backup storage.</description></item>
            /// <item><description>DRStorage: multi-AZ storage.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Storage</para>
            /// </summary>
            [NameInMap("storageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// <para>The unit of the storage metric.</para>
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
            public double? Usage { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <list type="bullet">
        /// <item><description>1xx: Informational response. The request has been received and is being processed.</description></item>
        /// <item><description>2xx: Success. The request has been successfully received, understood, and accepted by the server.</description></item>
        /// <item><description>3xx: Redirection. The request is redirected. Further action is required to complete the request.</description></item>
        /// <item><description>4xx: Client error. The request contains invalid parameters, bad syntax, or specific request conditions cannot be fulfilled.</description></item>
        /// <item><description>5xx: Server error. The server cannot fulfill the request due to other reasons.</description></item>
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
        /// <para>0a06dc0917476202205161986edbbc</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
