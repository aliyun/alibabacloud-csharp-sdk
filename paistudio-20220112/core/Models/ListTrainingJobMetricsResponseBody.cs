// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ListTrainingJobMetricsResponseBody : TeaModel {
        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public List<ListTrainingJobMetricsResponseBodyMetrics> Metrics { get; set; }
        public class ListTrainingJobMetricsResponseBodyMetrics : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// Use the UTC time format: yyyy-MM-ddTHH:mmZ
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public double? Value { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
