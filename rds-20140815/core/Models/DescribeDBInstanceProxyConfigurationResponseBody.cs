// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceProxyConfigurationResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether brute-force attacks protection is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enable</b>: Enabled.</description></item>
        /// <item><description><b>Disable</b>: Disabled.</description></item>
        /// </list>
        /// <para>The return value is a JSON character string in the following format:</para>
        /// <pre><c>{&quot;status&quot;:&quot;Disable&quot;, &quot;check_interval_seconds&quot;: 60,
        ///           &quot;max_failed_login_attempts&quot;: 60, &quot;blocking_seconds&quot;: 600}
        /// </c></pre>
        /// <para>Parameter description and value ranges:</para>
        /// <list type="bullet">
        /// <item><description>For each client, a maximum of max_failed_login_attempts fault password logon attempts are allowed within check_interval_seconds seconds. If the limit is exceeded, the client IP address is blocked for blocking_seconds seconds.</description></item>
        /// <item><description>Value ranges:<list type="bullet">
        /// <item><description>check_interval_seconds: <b>30 to 600</b>. Unit: seconds.</description></item>
        /// <item><description>max_failed_login_attempts: <b>10 to 5000</b>. Unit: attempts.</description></item>
        /// <item><description>blocking_seconds: <b>30 to 3600</b>. Unit: seconds.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;check_interval_seconds\&quot;:\&quot;0\&quot;,\&quot;max_failed_login_attempts\&quot;:\&quot;0\&quot;,\&quot;blocking_seconds\&quot;:\&quot;0\&quot;,\&quot;status\&quot;:\&quot;Disable\&quot;}</para>
        /// </summary>
        [NameInMap("AttacksProtectionConfiguration")]
        [Validation(Required=false)]
        public string AttacksProtectionConfiguration { get; set; }

        /// <summary>
        /// <para>Indicates whether short-lived connection optimization is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enable</b>: Enabled.</description></item>
        /// <item><description><b>Disable</b>: Disabled.</description></item>
        /// </list>
        /// <para>The return value is a JSON string in the following format:</para>
        /// <pre><c>{&quot;status&quot;:&quot;Disable&quot;}.
        /// </c></pre>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;status\&quot;:\&quot;Disable\&quot;}</para>
        /// </summary>
        [NameInMap("PersistentConnectionsConfiguration")]
        [Validation(Required=false)]
        public string PersistentConnectionsConfiguration { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E9DD55F4-1A5F-48CA-BA57-DFB3CA8C4C34</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether transparent switchover is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enable</b>: Enabled.</description></item>
        /// <item><description><b>Disable</b>: Disabled.</description></item>
        /// </list>
        /// <para>The return value is a JSON string in the following format:</para>
        /// <pre><c>{&quot;status&quot;:&quot;Enable&quot;}.
        /// </c></pre>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;status\&quot;:\&quot;Enable\&quot;}</para>
        /// </summary>
        [NameInMap("TransparentSwitchConfiguration")]
        [Validation(Required=false)]
        public string TransparentSwitchConfiguration { get; set; }

    }

}
