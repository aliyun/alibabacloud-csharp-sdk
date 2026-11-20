// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeThreatEventResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>98106632-6865-5600-A834-3D909***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of noteworthy security events.</para>
        /// </summary>
        [NameInMap("ThreatEvents")]
        [Validation(Required=false)]
        public List<DescribeThreatEventResponseBodyThreatEvents> ThreatEvents { get; set; }
        public class DescribeThreatEventResponseBodyThreatEvents : TeaModel {
            /// <summary>
            /// <para>The percentage of blocked requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100%</para>
            /// </summary>
            [NameInMap("BlockRate")]
            [Validation(Required=false)]
            public string BlockRate { get; set; }

            /// <summary>
            /// <para>The most recent Attack Time. The format is a UNIX timestamp in UTC. Unit: seconds.</para>
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
            /// <para>The Attack Source IP Addresses.</para>
            /// <remarks>
            /// <para>A security event may involve multiple source IP addresses. This operation returns only one source IP address.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>3.3.3.3</para>
            /// </summary>
            [NameInMap("EventSrc")]
            [Validation(Required=false)]
            public string EventSrc { get; set; }

            /// <summary>
            /// <para>The name of the event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>MultipleDomainDirscan</b>: folder and file scanning targeting multiple domain names.</description></item>
            /// <item><description><b>SingleDomainDirscan</b>: folder and file scanning targeting a single domain name.</description></item>
            /// <item><description><b>MultipleDomainWebscan</b>: web vulnerability scanning targeting multiple domain names.</description></item>
            /// <item><description><b>SingleDomainWebscan</b>: web vulnerability scanning targeting a single domain name.</description></item>
            /// <item><description><b>MultipleDomainWebattack</b>: web vulnerability attacks targeting multiple domain names.</description></item>
            /// <item><description><b>SingleDomainWebattack</b>: web vulnerability attacks targeting a single domain name.</description></item>
            /// <item><description><b>SingleURLWebattack</b>: web vulnerability attacks targeting a specific URL.</description></item>
            /// <item><description><b>SingleURLSqlattack</b>: SQL injection attacks targeting a specific URL.</description></item>
            /// <item><description><b>SingleURLXssattack</b>: XSS attacks targeting a specific URL.</description></item>
            /// <item><description><b>WebshellUpload</b>: attempts to upload backdoor trojans.</description></item>
            /// <item><description><b>RandomVulnTest</b>: random web vulnerability probing.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Event_InternalLoginWeakPasswd</para>
            /// </summary>
            [NameInMap("EventTag")]
            [Validation(Required=false)]
            public string EventTag { get; set; }

            /// <summary>
            /// <para>The protected object of the Attack Target.</para>
            /// <remarks>
            /// <para>A security event may involve multiple protected objects targeted by the attack. This operation returns only one protected object.</para>
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
        /// <para>The total number of queried events.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
