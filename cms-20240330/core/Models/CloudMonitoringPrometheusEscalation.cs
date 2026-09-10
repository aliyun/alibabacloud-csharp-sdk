// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CloudMonitoringPrometheusEscalation : TeaModel {
        /// <summary>
        /// <para>The PromQL query statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rate(http_errors_total[5m]) &gt; 0.1</para>
        /// </summary>
        [NameInMap("promQl")]
        [Validation(Required=false)]
        public string PromQl { get; set; }

        /// <summary>
        /// <para>The severity level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CRITICAL</para>
        /// </summary>
        [NameInMap("severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        /// <summary>
        /// <para>The number of consecutive times the alert is triggered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("times")]
        [Validation(Required=false)]
        public int? Times { get; set; }

    }

}
