// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class MonitorMqAlertRule : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PBC_Topic1</para>
        /// </summary>
        [NameInMap("metricDimension")]
        [Validation(Required=false)]
        public string MetricDimension { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>appstat.jvm.gc.oldgccountinstant</para>
        /// </summary>
        [NameInMap("metricKey")]
        [Validation(Required=false)]
        public string MetricKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TOPIC</para>
        /// </summary>
        [NameInMap("metricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>规则1</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("triggerInterval")]
        [Validation(Required=false)]
        public long? TriggerInterval { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>GreaterThanOrEqualToThreshold</para>
        /// </summary>
        [NameInMap("triggerOperator")]
        [Validation(Required=false)]
        public string TriggerOperator { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("triggerThreshold")]
        [Validation(Required=false)]
        public long? TriggerThreshold { get; set; }

    }

}
