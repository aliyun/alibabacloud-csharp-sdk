// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CloudMonitoringExpressEscalation : TeaModel {
        /// <summary>
        /// <para>The expression that defines the alert condition.</para>
        /// </summary>
        [NameInMap("rawExpression")]
        [Validation(Required=false)]
        public string RawExpression { get; set; }

        /// <summary>
        /// <para>The alert severity that triggers the escalation.</para>
        /// </summary>
        [NameInMap("severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        /// <summary>
        /// <para>The number of alert occurrences required to trigger the escalation.</para>
        /// </summary>
        [NameInMap("times")]
        [Validation(Required=false)]
        public int? Times { get; set; }

    }

}
