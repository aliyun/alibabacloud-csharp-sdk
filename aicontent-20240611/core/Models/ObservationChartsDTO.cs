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
        public List<TimeSeriesPointDTO> SuccessRate { get; set; }

        [NameInMap("tpm")]
        [Validation(Required=false)]
        public List<TimeSeriesPointDTO> Tpm { get; set; }

    }

}
