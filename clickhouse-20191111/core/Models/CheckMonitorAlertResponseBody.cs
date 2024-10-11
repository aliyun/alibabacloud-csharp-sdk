// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class CheckMonitorAlertResponseBody : TeaModel {
        /// <summary>
        /// <para>The parameters that are used to configure the monitoring and alerting feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{   &quot;monitor&quot;:{     &quot;key1&quot;:&quot;value1&quot;,     &quot;key2&quot;:&quot;value2&quot;   },   &quot;alert&quot;:{     &quot;key1&quot;:&quot;value1&quot;,     &quot;key2&quot;:&quot;value2&quot;   } }</para>
        /// </summary>
        [NameInMap("Parameter")]
        [Validation(Required=false)]
        public string Parameter { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>94F92113-FF63-5E57-8401-6FE123AD11DD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the monitoring and alerting feature is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>enable</b>: The monitoring and alerting feature is enabled.</description></item>
        /// <item><description><b>disable</b>: The monitoring and alerting feature is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enable</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
