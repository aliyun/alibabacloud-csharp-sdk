// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetFileDetectReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code that is returned. The status code <b>200</b> indicates that the request was successful. Other status codes indicate that the request failed. You can identify the cause of the failure based on the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetFileDetectReportResponseBodyData Data { get; set; }
        public class GetFileDetectReportResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The basic information about the detected file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///         &quot;sha256&quot;: &quot;&quot;,
            ///         &quot;sha512&quot;: &quot;&quot;,
            ///         &quot;source&quot;: &quot;aegis&quot;,
            ///         &quot;gmt_first_submit&quot;: &quot;&quot;,
            ///         &quot;sha1&quot;: &quot;&quot;,
            ///         &quot;virus_result&quot;: &quot;&quot;,
            ///         &quot;webshell_result&quot;: &quot;&quot;,
            ///         &quot;gmt_update&quot;: &quot;&quot;,
            ///         &quot;sandbox_result&quot;: &quot;2&quot;,
            ///         &quot;fileSize&quot;: &quot;363752&quot;,
            ///         &quot;virus_name&quot;: &quot;&quot;,
            ///     }</para>
            /// </summary>
            [NameInMap("Basic")]
            [Validation(Required=false)]
            public string Basic { get; set; }

            /// <summary>
            /// <para>The hash value of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c42b5f6bde0b730ece2923266333****</para>
            /// </summary>
            [NameInMap("FileHash")]
            [Validation(Required=false)]
            public string FileHash { get; set; }

            /// <summary>
            /// <para>The name of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.zip</para>
            /// </summary>
            [NameInMap("Filename")]
            [Validation(Required=false)]
            public string Filename { get; set; }

            /// <summary>
            /// <para>Indicates whether the file data exists in the cloud sandbox. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasData")]
            [Validation(Required=false)]
            public bool? HasData { get; set; }

            /// <summary>
            /// <para>The threat intelligence event, which is a JSON array.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>The threat type. The value is an array. The elements in the array can be DDoS trojans, mining programs, network layer intrusions, network service scans, network sharing and discovery, mining pools, exploits, dark webs, malicious logons, malicious download sources, C\&amp;C servers, webshells, and web attacks.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;The threat type&quot;]</para>
            /// </summary>
            [NameInMap("Intelligences")]
            [Validation(Required=false)]
            public string Intelligences { get; set; }

            /// <summary>
            /// <para>The details of the cloud sandbox check results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;BehaviorData\&quot;: {}, \&quot;ProcessData\&quot;: {}, \&quot;SandboxData\&quot;: {}, \&quot;AttackData\&quot;: [], \&quot;NetworkData\&quot;: {}, \&quot;SolutionData\&quot;: {}, \&quot;FileData\&quot;: {}}</para>
            /// </summary>
            [NameInMap("Sandbox")]
            [Validation(Required=false)]
            public string Sandbox { get; set; }

            /// <summary>
            /// <para>Indicates whether the check report is displayed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ShowTab")]
            [Validation(Required=false)]
            public bool? ShowTab { get; set; }

            /// <summary>
            /// <para>The threat level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: normal</description></item>
            /// <item><description><b>1</b>: suspicious</description></item>
            /// <item><description><b>2</b>: high</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ThreatLevel")]
            [Validation(Required=false)]
            public long? ThreatLevel { get; set; }

            /// <summary>
            /// <para>The risk tags and server tags that are generated by analyzing threat intelligence and security events. The value is a string array. The array includes the following elements:</para>
            /// <list type="bullet">
            /// <item><description><b>threat_type_desc</b>: the threat type.</description></item>
            /// <item><description><b>last_find_time</b>: the last time the threat was detected.</description></item>
            /// <item><description><b>risk_type</b>: indicates whether the tag is malicious. The value 0 indicates that the tag is not malicious. The value 1 indicates that the tag is malicious. The value -1 indicates that whether the tag type is malicious is unknown.</description></item>
            /// <item><description><b>threat_type</b>: the threat type. The value is an array. The elements in the array can be network layer intrusion, network service scanning, network sharing and discovery, mining pool, exploits, darknet, malicious logon, malicious download source, central control, web shell, and web attack.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;threat_type_desc&quot;: &quot;test&quot;,&quot;risk_type&quot;: 1,&quot;threat_type&quot;: &quot;&quot;}]</para>
            /// </summary>
            [NameInMap("ThreatTypes")]
            [Validation(Required=false)]
            public string ThreatTypes { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A4EB8B1C-1DEC-5E18-BCD0-D1BBB393XXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
