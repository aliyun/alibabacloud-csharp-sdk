// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CloudMonitoringSimpleEscalationEntry : TeaModel {
        /// <summary>
        /// <para>The comparison operator.</para>
        /// </summary>
        [NameInMap("comparisonOperator")]
        [Validation(Required=false)]
        public string ComparisonOperator { get; set; }

        /// <summary>
        /// <para>The precondition.</para>
        /// </summary>
        [NameInMap("preCondition")]
        [Validation(Required=false)]
        public string PreCondition { get; set; }

        /// <summary>
        /// <para>The severity level.</para>
        /// </summary>
        [NameInMap("severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        /// <summary>
        /// <para>The statistics method.</para>
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

        /// <summary>
        /// <para>The number of consecutive times the condition is triggered.</para>
        /// </summary>
        [NameInMap("times")]
        [Validation(Required=false)]
        public int? Times { get; set; }

    }

}
