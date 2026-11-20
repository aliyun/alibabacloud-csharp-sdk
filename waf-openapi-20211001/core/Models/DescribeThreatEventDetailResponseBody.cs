// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeThreatEventDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
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
            /// <para>The most recent attack time. The value is a UNIX timestamp in UTC. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1749916800000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The number of blocked attacks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("EventBlock")]
            [Validation(Required=false)]
            public string EventBlock { get; set; }

            /// <summary>
            /// <para>The total number of attacks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("EventCnt")]
            [Validation(Required=false)]
            public string EventCnt { get; set; }

            /// <summary>
            /// <para>The filter condition for the log query feature. The value is a string converted from a <b>JSON</b> structure constructed with a series of parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;end_ts&quot;: 1766637714, &quot;start_ts&quot;: 1764096746, &quot;condition&quot;: {&quot;real_client_ip&quot;: [&quot;78.153.140.179&quot;, &quot;78.153.140.203&quot;, &quot;78.153.140.177&quot;, &quot;78.153.140.178&quot;, &quot;78.153.140.151&quot;]}}</para>
            /// </summary>
            [NameInMap("EventCondition")]
            [Validation(Required=false)]
            public string EventCondition { get; set; }

            /// <summary>
            /// <para>The threat intelligence associated with the event. The value is a string converted from a <b>JSON</b> array.</para>
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
            /// <item><description><b>critical</b>: critical.</description></item>
            /// <item><description><b>high</b>: high.</description></item>
            /// <item><description><b>medium</b>: medium.</description></item>
            /// <item><description><b>low</b>: low.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("EventLevel")]
            [Validation(Required=false)]
            public string EventLevel { get; set; }

            /// <summary>
            /// <para>The attack source IP addresses.</para>
            /// <remarks>
            /// <para>A security event may have multiple attack source IP addresses. This operation returns only one.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>XX.XX.XX.XX</para>
            /// </summary>
            [NameInMap("EventSrc")]
            [Validation(Required=false)]
            public string EventSrc { get; set; }

            /// <summary>
            /// <para>The country to which the attack source IP addresses belong.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GB</para>
            /// </summary>
            [NameInMap("EventSrcCountry")]
            [Validation(Required=false)]
            public string EventSrcCountry { get; set; }

            /// <summary>
            /// <para>The region to which the attack source IP addresses belong.</para>
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
            /// <item><description><b>ProtectInterface</b>: The Attack Target is suspected to be a backend management address. If the address has fixed access characteristics, configure custom rules in the access control module to restrict access.</description></item>
            /// <item><description><b>BlockArea</b>: Monitor the source region of the attack. If the attack source differs from the normal regional distribution of your service, configure Location Blacklist or IP blacklist rules in the access control module to restrict access.</description></item>
            /// <item><description><b>SwitchBlock</b>: The current rule protection is in alerting mode. To ensure service security, switch to block mode. Before switching, check for false positives.</description></item>
            /// <item><description><b>FixBug</b>: Check whether the Attack Target has a security vulnerability. If the security vulnerability exists, fix it promptly to prevent exploitation by attackers.</description></item>
            /// <item><description><b>SwitchStrict</b>: If normal service is not affected, adjust the policy of modules such as rule protection and scan protection to a stricter pattern. Before adjusting the policy, check for false positives.</description></item>
            /// <item><description><b>ProtectFile</b>: Check whether sensitive files or paths exist under the target domain name to prevent detection and exploitation by attackers.</description></item>
            /// <item><description><b>BlockIP</b>: The source IP address of the attack is highly malicious. Monitor the IP address. If normal service is not affected, block access from the malicious IP address by using an IP blacklist.</description></item>
            /// <item><description><b>KeepConcerned</b>: No risks are detected. Continue to monitor the event.</description></item>
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
            /// <item><description><b>MultipleDomainDirscan</b>: directory and file scanning targeting multiple domain names</description></item>
            /// <item><description><b>SingleDomainDirscan</b>: directory and file scanning targeting a single domain name</description></item>
            /// <item><description><b>MultipleDomainWebscan</b>: web vulnerability scanning targeting multiple domain names</description></item>
            /// <item><description><b>SingleDomainWebscan</b>: web vulnerability scanning targeting a single domain name</description></item>
            /// <item><description><b>MultipleDomainWebattack</b>: web vulnerability attacks targeting multiple domain names</description></item>
            /// <item><description><b>SingleDomainWebattack</b>: web vulnerability attacks targeting a single domain name</description></item>
            /// <item><description><b>SingleURLWebattack</b>: web vulnerability attacks targeting a specific URL</description></item>
            /// <item><description><b>SingleURLSqlattack</b>: SQL injection attacks targeting a specific URL</description></item>
            /// <item><description><b>SingleURLXssattack</b>: XSS attacks targeting a specific URL</description></item>
            /// <item><description><b>WebshellUpload</b>: attack behavior attempting to upload backdoor trojans</description></item>
            /// <item><description><b>RandomVulnTest</b>: random web vulnerability detection behavior</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MultipleDomainWebattack</para>
            /// </summary>
            [NameInMap("EventTag")]
            [Validation(Required=false)]
            public string EventTag { get; set; }

            /// <summary>
            /// <para>Indicates whether the attack event is a targeted persistent attack event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: non-persistent attack.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: persistent attack.</para>
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
