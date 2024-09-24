// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AdvanceSecurityEventOperationsRequest : TeaModel {
        /// <summary>
        /// <para>The alert name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Execution of malicious script code</para>
        /// </summary>
        [NameInMap("EventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// <para>The alert event type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Suspicious process</description></item>
        /// <item><description>Webshell</description></item>
        /// <item><description>Unusual logon</description></item>
        /// <item><description>Exception</description></item>
        /// <item><description>Sensitive file tampering</description></item>
        /// <item><description>Malicious process (cloud threat detection)</description></item>
        /// <item><description>Unusual network connection</description></item>
        /// <item><description>Abnormal account</description></item>
        /// <item><description>Application intrusion event</description></item>
        /// <item><description>Cloud threat detection</description></item>
        /// <item><description>Precision defense</description></item>
        /// <item><description>Application whitelist</description></item>
        /// <item><description>Persistent webshell</description></item>
        /// <item><description>Web application threat detection</description></item>
        /// <item><description>Malicious script</description></item>
        /// <item><description>Threat intelligence</description></item>
        /// <item><description>Malicious network activity</description></item>
        /// <item><description>Cluster exception</description></item>
        /// <item><description>Webshell (on-premises threat detection)</description></item>
        /// <item><description>Vulnerability exploitation</description></item>
        /// <item><description>Malicious process (on-premises threat detection)</description></item>
        /// <item><description>Trusted exception</description></item>
        /// <item><description>Others</description></item>
        /// </list>
        /// <para>For more information about alert types, see <a href="https://help.aliyun.com/document_detail/68388.html">Alerts</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Malicious script</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

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
