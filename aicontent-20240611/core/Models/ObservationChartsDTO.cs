// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ObservationChartsDTO : TeaModel {
        [NameInMap("callVolume")]
        [Validation(Required=false)]
        public List<TimeSeriesPointDTO> CallVolume { get; set; }

        [NameInMap("concurrency")]
        [Validation(Required=false)]
        public List<TimeSeriesPointDTO> Concurrency { get; set; }

        [NameInMap("qpm")]
        [Validation(Required=false)]
        public List<TimeSeriesPointDTO> Qpm { get; set; }

        [NameInMap("responseTime")]
        [Validation(Required=false)]
        public List<TimeSeriesPointDTO> ResponseTime { get; set; }

        [NameInMap("successRate")]
        [Validation(Required=false)]
        public List<ObservationChartsDTOSuccessRate> SuccessRate { get; set; }
        public class ObservationChartsDTOSuccessRate : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>series1</para>
            /// </summary>
            [NameInMap("label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-01-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public object Value { get; set; }

        }

        [NameInMap("tpm")]
        [Validation(Required=false)]
        public List<TimeSeriesPointDTO> Tpm { get; set; }

    }

}
