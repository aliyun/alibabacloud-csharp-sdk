// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class MonitorMetricMeasureData : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>youngGcCount</para>
        /// </summary>
        [NameInMap("measure")]
        [Validation(Required=false)]
        public string Measure { get; set; }

        [NameInMap("measurePointData")]
        [Validation(Required=false)]
        public List<MonitorMetricMeasurePointData> MeasurePointData { get; set; }

    }

}
