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
        /// 
        /// <b>Example:</b>
        /// <para>cpu_usage &gt; 90</para>
        /// </summary>
        [NameInMap("rawExpression")]
        [Validation(Required=false)]
        public string RawExpression { get; set; }

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
