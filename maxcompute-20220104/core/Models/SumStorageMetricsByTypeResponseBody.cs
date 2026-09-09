// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class SumStorageMetricsByTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<SumStorageMetricsByTypeResponseBodyData> Data { get; set; }
        public class SumStorageMetricsByTypeResponseBodyData : TeaModel {
            /// <summary>
            /// <para>A list of daily storage usage metrics.</para>
            /// </summary>
            [NameInMap("dailyStorageMetrics")]
            [Validation(Required=false)]
            public List<SumStorageMetricsByTypeResponseBodyDataDailyStorageMetrics> DailyStorageMetrics { get; set; }
            public class SumStorageMetricsByTypeResponseBodyDataDailyStorageMetrics : TeaModel {
                /// <summary>
                /// <para>The date of the metric, in <c>yyyyMMdd</c> format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20260410</para>
                /// </summary>
                [NameInMap("dateTime")]
                [Validation(Required=false)]
                public string DateTime { get; set; }

                /// <summary>
                /// <para>The percentage of total daily storage that this storage type accounts for.</para>
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
                /// <item><description><para><c>Storage</c>: standard storage.</para>
                /// </description></item>
                /// <item><description><para><c>LowFreqStorage</c>: infrequent access storage.</para>
                /// </description></item>
                /// <item><description><para><c>ColdStorage</c>: archive storage.</para>
                /// </description></item>
                /// <item><description><para><c>$sum</c>: total storage.</para>
                /// </description></item>
                /// <item><description><para><c>RecycleBinStorage</c>: recycle bin storage.</para>
                /// </description></item>
                /// <item><description><para><c>DRStorage</c>: multi-AZ storage.</para>
                /// </description></item>
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
                /// <para>The storage usage for this day.</para>
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
            /// <item><description><para><c>Storage</c>: standard storage.</para>
            /// </description></item>
            /// <item><description><para><c>LowFreqStorage</c>: infrequent access storage.</para>
            /// </description></item>
            /// <item><description><para><c>ColdStorage</c>: archive storage.</para>
            /// </description></item>
            /// <item><description><para><c>$sum</c>: total storage.</para>
            /// </description></item>
            /// <item><description><para><c>RecycleBinStorage</c>: recycle bin storage.</para>
            /// </description></item>
            /// <item><description><para><c>DRStorage</c>: multi-AZ storage.</para>
            /// </description></item>
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
        /// <item><description><para><c>1xx</c>: Informational response - The request has been received and is being processed.</para>
        /// </description></item>
        /// <item><description><para><c>2xx</c>: Success - The request was successfully received, understood, and accepted.</para>
        /// </description></item>
        /// <item><description><para><c>3xx</c>: Redirection - Further action is needed to complete the request.</para>
        /// </description></item>
        /// <item><description><para><c>4xx</c>: Client error - The request contains invalid syntax or cannot be fulfilled.</para>
        /// </description></item>
        /// <item><description><para><c>5xx</c>: Server error - The server failed to fulfill a valid request.</para>
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
        /// <para>0a06dc0917476202205161986edbbc</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
