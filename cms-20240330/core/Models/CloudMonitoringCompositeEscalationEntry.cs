// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CloudMonitoringCompositeEscalationEntry : TeaModel {
        /// <summary>
        /// <para>The comparison operator.</para>
        /// </summary>
        [NameInMap("comparisonOperator")]
        [Validation(Required=false)]
        public string ComparisonOperator { get; set; }

        /// <summary>
        /// <para>The metric name.</para>
        /// </summary>
        [NameInMap("metricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>The collection period, in seconds.</para>
        /// </summary>
        [NameInMap("period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The precondition.</para>
        /// </summary>
        [NameInMap("preCondition")]
        [Validation(Required=false)]
        public string PreCondition { get; set; }

        /// <summary>
        /// <para>The statistical method.</para>
        /// </summary>
        [NameInMap("statistics")]
        [Validation(Required=false)]
        public string Statistics { get; set; }

        /// <summary>
        /// <para>The threshold.</para>
        /// </summary>
        [NameInMap("threshold")]
        [Validation(Required=false)]
        public string Threshold { get; set; }

    }

}
