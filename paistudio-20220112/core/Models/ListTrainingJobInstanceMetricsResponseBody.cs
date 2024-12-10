// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ListTrainingJobInstanceMetricsResponseBody : TeaModel {
        [NameInMap("InstanceMetrics")]
        [Validation(Required=false)]
        public List<ListTrainingJobInstanceMetricsResponseBodyInstanceMetrics> InstanceMetrics { get; set; }
        public class ListTrainingJobInstanceMetricsResponseBodyInstanceMetrics : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public List<ListTrainingJobInstanceMetricsResponseBodyInstanceMetricsMetrics> Metrics { get; set; }
            public class ListTrainingJobInstanceMetricsResponseBodyInstanceMetricsMetrics : TeaModel {
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public double? Value { get; set; }

            }

            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F082BD0D-21E1-5F9B-81A0-AB07485B03CD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
