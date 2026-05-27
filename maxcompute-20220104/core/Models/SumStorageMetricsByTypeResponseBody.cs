// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class SumStorageMetricsByTypeResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<SumStorageMetricsByTypeResponseBodyData> Data { get; set; }
        public class SumStorageMetricsByTypeResponseBodyData : TeaModel {
            [NameInMap("dailyStorageMetrics")]
            [Validation(Required=false)]
            public List<SumStorageMetricsByTypeResponseBodyDataDailyStorageMetrics> DailyStorageMetrics { get; set; }
            public class SumStorageMetricsByTypeResponseBodyDataDailyStorageMetrics : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>20260410</para>
                /// </summary>
                [NameInMap("dateTime")]
                [Validation(Required=false)]
                public string DateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("percentage")]
                [Validation(Required=false)]
                public double? Percentage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Storage</para>
                /// </summary>
                [NameInMap("storageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>GB</para>
                /// </summary>
                [NameInMap("unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("usage")]
                [Validation(Required=false)]
                public double? Usage { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Storage</para>
            /// </summary>
            [NameInMap("storageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>GB</para>
            /// </summary>
            [NameInMap("unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>329.503338</para>
            /// </summary>
            [NameInMap("usage")]
            [Validation(Required=false)]
            public double? Usage { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0a06dc0917476202205161986edbbc</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
