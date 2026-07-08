// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeThreatEventResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>98106632-6865-5600-A834-3D909***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of notable security events.</para>
        /// </summary>
        [NameInMap("ThreatEvents")]
        [Validation(Required=false)]
        public List<DescribeThreatEventResponseBodyThreatEvents> ThreatEvents { get; set; }
        public class DescribeThreatEventResponseBodyThreatEvents : TeaModel {
            /// <summary>
            /// <para>The percentage of attack requests that were blocked by WAF.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100%</para>
            /// </summary>
            [NameInMap("BlockRate")]
            [Validation(Required=false)]
            public string BlockRate { get; set; }

            /// <summary>
            /// <para>The time when the last attack occurred. This value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1768406400000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The ID of the security event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f439994c8ab39f84eced33490f0c4388</para>
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            /// <summary>
            /// <para>The severity level of the security event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>critical</b></para>
            /// </description></item>
            /// <item><description><para><b>high</b></para>
            /// </description></item>
            /// <item><description><para><b>medium</b></para>
            /// </description></item>
            /// <item><description><para><b>low</b></para>
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
            /// <para>3.3.3.3</para>
            /// </summary>
            [NameInMap("EventSrc")]
            [Validation(Required=false)]
            public string EventSrc { get; set; }

            /// <summary>
            /// <para>The type of the security event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>MultipleDomainDirscan</b>: a directory and file scan against multiple domain names.</para>
            /// </description></item>
            /// <item><description><para><b>SingleDomainDirscan</b>: a directory and file scan against a single domain name.</para>
            /// </description></item>
            /// <item><description><para><b>MultipleDomainWebscan</b>: a web vulnerability scan against multiple domain names.</para>
            /// </description></item>
            /// <item><description><para><b>SingleDomainWebscan</b>: a web vulnerability scan against a single domain name.</para>
            /// </description></item>
            /// <item><description><para><b>MultipleDomainWebattack</b>: a web vulnerability attack against multiple domain names.</para>
            /// </description></item>
            /// <item><description><para><b>SingleDomainWebattack</b>: a web vulnerability attack against a single domain name.</para>
            /// </description></item>
            /// <item><description><para><b>SingleURLWebattack</b>: a web vulnerability attack against a specific URL.</para>
            /// </description></item>
            /// <item><description><para><b>SingleURLSqlattack</b>: an SQL injection attack against a specific URL.</para>
            /// </description></item>
            /// <item><description><para><b>SingleURLXssattack</b>: an XSS attack against a specific URL.</para>
            /// </description></item>
            /// <item><description><para><b>WebshellUpload</b>: an attack that attempts to upload backdoor trojans.</para>
            /// </description></item>
            /// <item><description><para><b>RandomVulnTest</b>: a random web vulnerability probe.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Event_InternalLoginWeakPasswd</para>
            /// </summary>
            [NameInMap("EventTag")]
            [Validation(Required=false)]
            public string EventTag { get; set; }

            /// <summary>
            /// <para>The protected object that is the target of the attack.</para>
            /// <remarks>
            /// <para>A security event may have multiple protected objects as targets. This operation returns only one of them.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test.aliyundemo.com-waf</para>
            /// </summary>
            [NameInMap("EventTarget")]
            [Validation(Required=false)]
            public string EventTarget { get; set; }

        }

        /// <summary>
        /// <para>The total number of security events that match the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
