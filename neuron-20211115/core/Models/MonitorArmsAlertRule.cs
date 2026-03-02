// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class MonitorArmsAlertRule : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>appstat.jvm.gc.oldgccountinstant</para>
        /// </summary>
        [NameInMap("metricKey")]
        [Validation(Required=false)]
        public string MetricKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>JVM</para>
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
        /// <para>AVG</para>
        /// </summary>
        [NameInMap("triggerAggregate")]
        [Validation(Required=false)]
        public string TriggerAggregate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("triggerInterval")]
        [Validation(Required=false)]
        public long? TriggerInterval { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CURRENT_GTE</para>
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
