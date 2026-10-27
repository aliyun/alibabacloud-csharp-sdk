// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddImageEventOperationRequest : TeaModel {
        /// <summary>
        /// <para>The rule conditions. The value is in JSON format. Valid keys:</para>
        /// <list type="bullet">
        /// <item><description><b>condition</b>: The matching condition.</description></item>
        /// <item><description><b>type</b>: The matching type.</description></item>
        /// <item><description><b>value</b>: The matching value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;condition\&quot;: \&quot;MD5\&quot;, \&quot;type\&quot;: \&quot;equals\&quot;, \&quot;value\&quot;: \&quot;0083a31cc0083a31ccf7c10367a6e783e\&quot;}]</para>
        /// </summary>
        [NameInMap("Conditions")]
        [Validation(Required=false)]
        public string Conditions { get; set; }

        /// <summary>
        /// <para>The alert metric keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PEM</para>
        /// </summary>
        [NameInMap("EventKey")]
        [Validation(Required=false)]
        public string EventKey { get; set; }

        /// <summary>
        /// <para>The alert metric name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PEM</para>
        /// </summary>
        [NameInMap("EventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// <para>The Alarm Metric for alerting. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>sensitiveFile</b>: Sensitive file.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sensitiveFile</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>The note to add.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Note")]
        [Validation(Required=false)]
        public string Note { get; set; }

        /// <summary>
        /// <para>The operation code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>whitelist</b>: Whitelist.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>whitelist</para>
        /// </summary>
        [NameInMap("OperationCode")]
        [Validation(Required=false)]
        public string OperationCode { get; set; }

        /// <summary>
        /// <para>The rule scope. The value is in JSON format. Valid keys:</para>
        /// <list type="bullet">
        /// <item><description><b>type</b>: The scope type.</description></item>
        /// <item><description><b>value</b>: The scope value.<remarks>
        /// <para>This parameter and <b>Source</b> cannot be empty at the same time. If <b>Source</b> is set to <b>agentless</b>, this parameter does not take effect.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;type\&quot;: \&quot;repo\&quot;, \&quot;value\&quot;: \&quot;test-aaa/shenzhen-repo-01\&quot;}</para>
        /// </summary>
        [NameInMap("Scenarios")]
        [Validation(Required=false)]
        public string Scenarios { get; set; }

        /// <summary>
        /// <para>The source of the whitelist. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>image</b>: Image.</description></item>
        /// <item><description><b>agentless</b>: Agentless detection.<remarks>
        /// <para>This parameter and <b>Scenarios</b> cannot be empty at the same time. If this parameter is set to <b>agentless</b>, the <b>Scenarios</b> parameter does not take effect.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>agentless</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
