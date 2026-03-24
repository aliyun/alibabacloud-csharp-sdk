// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeThreatEventDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D7861F61-5B61-46CE-A47C-6B1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the security event.</para>
        /// </summary>
        [NameInMap("ThreatEventDetail")]
        [Validation(Required=false)]
        public DescribeThreatEventDetailResponseBodyThreatEventDetail ThreatEventDetail { get; set; }
        public class DescribeThreatEventDetailResponseBodyThreatEventDetail : TeaModel {
            /// <summary>
            /// <para>The time of the most recent attack. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1749916800000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The number of attacks that were blocked in the security event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("EventBlock")]
            [Validation(Required=false)]
            public string EventBlock { get; set; }

            /// <summary>
            /// <para>The total number of attacks in the security event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("EventCnt")]
            [Validation(Required=false)]
            public string EventCnt { get; set; }

            /// <summary>
            /// <para>The filter condition for viewing logs. The value is a JSON object in the string format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;end_ts&quot;: 1766637714, &quot;start_ts&quot;: 1764096746, &quot;condition&quot;: {&quot;real_client_ip&quot;: [&quot;78.153.140.179&quot;, &quot;78.153.140.203&quot;, &quot;78.153.140.177&quot;, &quot;78.153.140.178&quot;, &quot;78.153.140.151&quot;]}}</para>
            /// </summary>
            [NameInMap("EventCondition")]
            [Validation(Required=false)]
            public string EventCondition { get; set; }

            /// <summary>
            /// <para>The threat intelligence associated with the event. The value is a JSON array in the string format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;CVE-2020-14882&quot;,&quot;DDoS Attack&quot;]</para>
            /// </summary>
            [NameInMap("EventIntelligence")]
            [Validation(Required=false)]
            public string EventIntelligence { get; set; }

            /// <summary>
            /// <para>The severity level of the event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>critical</b>: Critical severity.</para>
            /// </description></item>
            /// <item><description><para><b>high</b>: High severity.</para>
            /// </description></item>
            /// <item><description><para><b>medium</b>: Medium severity.</para>
            /// </description></item>
            /// <item><description><para><b>low</b>: Low severity.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("EventLevel")]
            [Validation(Required=false)]
            public string EventLevel { get; set; }

            /// <summary>
            /// <para>The source IP address of the attack.</para>
            /// <remarks>
            /// <para>A security event may have multiple source IP addresses. This operation returns only one of them.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>XX.XX.XX.XX</para>
            /// </summary>
            [NameInMap("EventSrc")]
            [Validation(Required=false)]
            public string EventSrc { get; set; }

            /// <summary>
            /// <para>The country of the source IP address of the attack.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GB</para>
            /// </summary>
            [NameInMap("EventSrcCountry")]
            [Validation(Required=false)]
            public string EventSrcCountry { get; set; }

            /// <summary>
            /// <para>The region of the source IP address of the attack.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GB-ENG</para>
            /// </summary>
            [NameInMap("EventSrcRegion")]
            [Validation(Required=false)]
            public string EventSrcRegion { get; set; }

            /// <summary>
            /// <para>The security suggestion. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>ProtectInterface</b>: The attack target appears to be a backend management address. If the address has specific access patterns, configure custom rules in the access control module to restrict access.</para>
            /// </description></item>
            /// <item><description><para><b>BlockArea</b>: Monitor the attack source region. If the attack source region is different from your normal business regions, configure a location blacklist or an IP address blacklist in the access control module to restrict access.</para>
            /// </description></item>
            /// <item><description><para><b>SwitchBlock</b>: The current protection rule is in Alert mode. To ensure business security, switch to Block mode. Before you switch, check for false positives.</para>
            /// </description></item>
            /// <item><description><para><b>FixBug</b>: Check the attack target for security vulnerabilities. If any vulnerabilities exist, fix them promptly to prevent exploitation.</para>
            /// </description></item>
            /// <item><description><para><b>SwitchStrict</b>: If it does not affect your normal business, change the policies of modules, such as protection rules and scan protection, to a stricter mode. Before you change the policies, check for false positives.</para>
            /// </description></item>
            /// <item><description><para><b>ProtectFile</b>: Check the target domain name for sensitive files or paths to prevent them from being detected and exploited.</para>
            /// </description></item>
            /// <item><description><para><b>BlockIP</b>: The source IP address has a high degree of maliciousness. Keep monitoring it. If it does not affect your normal business, use an IP address blacklist to block access from the malicious IP address.</para>
            /// </description></item>
            /// <item><description><para><b>KeepConcerned</b>: No threats are found. Continue to monitor the situation.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FixBug</para>
            /// </summary>
            [NameInMap("EventSuggest")]
            [Validation(Required=false)]
            public string EventSuggest { get; set; }

            /// <summary>
            /// <para>The name of the event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>MultipleDomainDirscan</b>: A directory and file scan for multiple domain names.</para>
            /// </description></item>
            /// <item><description><para><b>SingleDomainDirscan</b>: A directory and file scan for a single domain name.</para>
            /// </description></item>
            /// <item><description><para><b>MultipleDomainWebscan</b>: A web vulnerability scan for multiple domain names.</para>
            /// </description></item>
            /// <item><description><para><b>SingleDomainWebscan</b>: A web vulnerability scan for a single domain name.</para>
            /// </description></item>
            /// <item><description><para><b>MultipleDomainWebattack</b>: A web vulnerability attack on multiple domain names.</para>
            /// </description></item>
            /// <item><description><para><b>SingleDomainWebattack</b>: A web vulnerability attack on a single domain name.</para>
            /// </description></item>
            /// <item><description><para><b>SingleURLWebattack</b>: A web vulnerability attack on a specific URL.</para>
            /// </description></item>
            /// <item><description><para><b>SingleURLSqlattack</b>: An SQL injection attack on a specific URL.</para>
            /// </description></item>
            /// <item><description><para><b>SingleURLXssattack</b>: A cross-site scripting (XSS) attack on a specific URL.</para>
            /// </description></item>
            /// <item><description><para><b>WebshellUpload</b>: An attempt to upload backdoor trojans.</para>
            /// </description></item>
            /// <item><description><para><b>RandomVulnTest</b>: A random web vulnerability probe.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MultipleDomainWebattack</para>
            /// </summary>
            [NameInMap("EventTag")]
            [Validation(Required=false)]
            public string EventTag { get; set; }

            /// <summary>
            /// <para>Indicates whether the event is a persistent attack. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: The event is not a persistent attack.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: The event is a persistent attack.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IsPersistent")]
            [Validation(Required=false)]
            public long? IsPersistent { get; set; }

        }

    }

}
