// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CloudMonitoringPrometheusEscalation : TeaModel {
        /// <summary>
        /// <para>The PromQL expression that defines the alert condition. This parameter is required.</para>
        /// </summary>
        [NameInMap("promQl")]
        [Validation(Required=false)]
        public string PromQl { get; set; }

        /// <summary>
        /// <para>The severity of the alert that triggers the escalation. This parameter is required.</para>
        /// </summary>
        [NameInMap("severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        /// <summary>
        /// <para>The number of consecutive times the condition must be met to trigger an escalation. This parameter is required.</para>
        /// </summary>
        [NameInMap("times")]
        [Validation(Required=false)]
        public int? Times { get; set; }

    }

}
