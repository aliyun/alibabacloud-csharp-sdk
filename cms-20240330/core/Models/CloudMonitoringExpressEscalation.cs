// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CloudMonitoringExpressEscalation : TeaModel {
        /// <summary>
        /// <para>The raw expression.</para>
        /// </summary>
        [NameInMap("rawExpression")]
        [Validation(Required=false)]
        public string RawExpression { get; set; }

        /// <summary>
        /// <para>The severity level.</para>
        /// </summary>
        [NameInMap("severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        /// <summary>
        /// <para>The number of consecutive times the alert is triggered.</para>
        /// </summary>
        [NameInMap("times")]
        [Validation(Required=false)]
        public int? Times { get; set; }

    }

}
