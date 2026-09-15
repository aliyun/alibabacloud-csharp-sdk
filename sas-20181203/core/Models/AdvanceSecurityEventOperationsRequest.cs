// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AdvanceSecurityEventOperationsRequest : TeaModel {
        /// <summary>
        /// <para>The alert name. The EventName and EventType parameters must be specified together. If only one of them is specified, the API returns a 400 error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Malicious script code execution</para>
        /// </summary>
        [NameInMap("EventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// <para>The type of the alerting event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Abnormal process behavior</description></item>
        /// <item><description>Web shell</description></item>
        /// <item><description>Unusual logon</description></item>
        /// <item><description>Abnormal event</description></item>
        /// <item><description>Sensitive file tampering</description></item>
        /// <item><description>Malicious process (cloud scan)</description></item>
        /// <item><description>Suspicious network connection</description></item>
        /// <item><description>Abnormal account</description></item>
        /// <item><description>Application intrusion event</description></item>
        /// <item><description>Cloud service threat detection</description></item>
        /// <item><description>Precise defense</description></item>
        /// <item><description>Application whitelist</description></item>
        /// <item><description>Persistent backdoor</description></item>
        /// <item><description>Web application threat detection</description></item>
        /// <item><description>Malicious script</description></item>
        /// <item><description>Threat intelligence</description></item>
        /// <item><description>Malicious network behavior</description></item>
        /// <item><description>Container cluster exception</description></item>
        /// <item><description>Web shell (local scan)</description></item>
        /// <item><description>Vulnerability exploits</description></item>
        /// <item><description>Malicious process (local scan)</description></item>
        /// <item><description>Trusted exception</description></item>
        /// <item><description>Other</description></item>
        /// </list>
        /// <para>For more information about alert types, see <a href="https://help.aliyun.com/document_detail/68388.html">Security alert check items</a>.</para>
        /// <para>The EventName and EventType parameters must be specified together. If only one of them is specified, the API returns a 400 error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Malicious script</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>The member account ID in the resource directory (Alibaba Cloud account).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1232428423234****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The rule ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public int? RuleId { get; set; }

    }

}
