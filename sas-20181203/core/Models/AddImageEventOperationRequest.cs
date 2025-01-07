// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddImageEventOperationRequest : TeaModel {
        /// <summary>
        /// <para>The rule conditions. The value is in the JSON format. Valid values of keys:</para>
        /// <list type="bullet">
        /// <item><description><b>condition</b>: the matching condition.</description></item>
        /// <item><description><b>type</b>: the matching type.</description></item>
        /// <item><description><b>value</b>: the matching value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;condition\&quot;: \&quot;MD5\&quot;, \&quot;type\&quot;: \&quot;equals\&quot;, \&quot;value\&quot;: \&quot;0083a31cc0083a31ccf7c10367a6e783e\&quot;}]</para>
        /// </summary>
        [NameInMap("Conditions")]
        [Validation(Required=false)]
        public string Conditions { get; set; }

        /// <summary>
        /// <para>The keyword of the alert item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PEM</para>
        /// </summary>
        [NameInMap("EventKey")]
        [Validation(Required=false)]
        public string EventKey { get; set; }

        /// <summary>
        /// <para>The name of the alert item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PEM</para>
        /// </summary>
        [NameInMap("EventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// <para>The alert type.</para>
        /// <list type="bullet">
        /// <item><description>Set the value to <b>sensitiveFile</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sensitiveFile</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        [NameInMap("Note")]
        [Validation(Required=false)]
        public string Note { get; set; }

        /// <summary>
        /// <para>The operation code.</para>
        /// <list type="bullet">
        /// <item><description>Set the value to <b>whitelist</b> to add the alert item to the whitelist.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>whitelist</para>
        /// </summary>
        [NameInMap("OperationCode")]
        [Validation(Required=false)]
        public string OperationCode { get; set; }

        /// <summary>
        /// <para>The application scope of the rule. The value is in the JSON format. Valid values of keys:</para>
        /// <list type="bullet">
        /// <item><description><b>type</b></description></item>
        /// <item><description><b>value</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;type\&quot;: \&quot;repo\&quot;, \&quot;value\&quot;: \&quot;test-aaa/shenzhen-repo-01\&quot;}</para>
        /// </summary>
        [NameInMap("Scenarios")]
        [Validation(Required=false)]
        public string Scenarios { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
