// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class MonitorMetricMeasurePointData : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>youngGcCount</para>
        /// </summary>
        [NameInMap("measure")]
        [Validation(Required=false)]
        public string Measure { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>08-22 17:25</para>
        /// </summary>
        [NameInMap("timeStamp")]
        [Validation(Required=false)]
        public string TimeStamp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1M</para>
        /// </summary>
        [NameInMap("valueWithUnit")]
        [Validation(Required=false)]
        public string ValueWithUnit { get; set; }

    }

}
