// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class MonitorSlsAlertRule : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>规则1</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description>| select status, count(*) as total group by status</description></item>
        /// </list>
        /// </summary>
        [NameInMap("queryCondition")]
        [Validation(Required=false)]
        public string QueryCondition { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("triggerInterval")]
        [Validation(Required=false)]
        public long? TriggerInterval { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MINUTE</para>
        /// </summary>
        [NameInMap("triggerIntervalUnit")]
        [Validation(Required=false)]
        public string TriggerIntervalUnit { get; set; }

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

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("triggerThresholdUpper")]
        [Validation(Required=false)]
        public long? TriggerThresholdUpper { get; set; }

    }

}
