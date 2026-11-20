// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ObservationChartsDTO : TeaModel {
        /// <summary>
        /// <para>The call volume time series.</para>
        /// </summary>
        [NameInMap("callVolume")]
        [Validation(Required=false)]
        public List<TimeSeriesPointDTO> CallVolume { get; set; }

        /// <summary>
        /// <para>The number of concurrent connections.</para>
        /// </summary>
        [NameInMap("concurrency")]
        [Validation(Required=false)]
        public List<TimeSeriesPointDTO> Concurrency { get; set; }

        /// <summary>
        /// <para>The QPM time series.</para>
        /// </summary>
        [NameInMap("qpm")]
        [Validation(Required=false)]
        public List<TimeSeriesPointDTO> Qpm { get; set; }

        /// <summary>
        /// <para>The response time time series.</para>
        /// </summary>
        [NameInMap("responseTime")]
        [Validation(Required=false)]
        public List<TimeSeriesPointDTO> ResponseTime { get; set; }

        /// <summary>
        /// <para>The success rate time series.</para>
        /// </summary>
        [NameInMap("successRate")]
        [Validation(Required=false)]
        public List<ObservationChartsDTOSuccessRate> SuccessRate { get; set; }
        public class ObservationChartsDTOSuccessRate : TeaModel {
            /// <summary>
            /// <para>The label.</para>
            /// 
            /// <b>Example:</b>
            /// <para>series1</para>
            /// </summary>
            [NameInMap("label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// <para>The timestamp (RFC3339).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

            /// <summary>
            /// <para>The value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>62.37</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public object Value { get; set; }

        }

        /// <summary>
        /// <para>The TPM time series.</para>
        /// </summary>
        [NameInMap("tpm")]
        [Validation(Required=false)]
        public List<TimeSeriesPointDTO> Tpm { get; set; }

    }

}
