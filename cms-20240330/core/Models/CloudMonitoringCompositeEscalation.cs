// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CloudMonitoringCompositeEscalation : TeaModel {
        /// <summary>
        /// <para>A single entry in the escalation policy. See the <c>CloudMonitoringCompositeEscalationEntry</c> object for details.</para>
        /// </summary>
        [NameInMap("escalations")]
        [Validation(Required=false)]
        public List<CloudMonitoringCompositeEscalationEntry> Escalations { get; set; }

        /// <summary>
        /// <para>Specifies the logical relationship for evaluating the conditions of the composite alert rule. Valid values: <c>and</c> and <c>or</c>.</para>
        /// </summary>
        [NameInMap("relation")]
        [Validation(Required=false)]
        public string Relation { get; set; }

        /// <summary>
        /// <para>Specifies the severity level of the alert. For example: <c>Critical</c>, <c>Warning</c>, and <c>Info</c>.</para>
        /// </summary>
        [NameInMap("severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        /// <summary>
        /// <para>Specifies the number of times the alert conditions must be met to trigger this escalation policy.</para>
        /// </summary>
        [NameInMap("times")]
        [Validation(Required=false)]
        public int? Times { get; set; }

    }

}
