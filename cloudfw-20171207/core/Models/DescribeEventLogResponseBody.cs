// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeEventLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of ISPs.</para>
        /// </summary>
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeEventLogResponseBodyDataList> DataList { get; set; }
        public class DescribeEventLogResponseBodyDataList : TeaModel {
            /// <summary>
            /// <para>The application type supported by the access control policy. We recommend that you use ApplicationNameList. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>FTP</b></description></item>
            /// <item><description><b>HTTP</b></description></item>
            /// <item><description><b>HTTPS</b></description></item>
            /// <item><description><b>Memcache</b></description></item>
            /// <item><description><b>MongoDB</b></description></item>
            /// <item><description><b>MQTT</b></description></item>
            /// <item><description><b>MySQL</b></description></item>
            /// <item><description><b>RDP</b></description></item>
            /// <item><description><b>Redis</b></description></item>
            /// <item><description><b>SMTP</b></description></item>
            /// <item><description><b>SMTPS</b></description></item>
            /// <item><description><b>SSH</b></description></item>
            /// <item><description><b>SSL</b></description></item>
            /// <item><description><b>VNC</b></description></item>
            /// <item><description><b>ANY</b>: All application types.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ANY</para>
            /// </summary>
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            /// <summary>
            /// <para>The name of the attacked application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MySql</para>
            /// </summary>
            [NameInMap("AttackApp")]
            [Validation(Required=false)]
            public string AttackApp { get; set; }

            /// <summary>
            /// <para>The attack type of the intrusion prevention event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Abnormal connection.</description></item>
            /// <item><description><b>2</b>: Command execution.</description></item>
            /// <item><description><b>3</b>: Brute-force attack.</description></item>
            /// <item><description><b>4</b>: Scan.</description></item>
            /// <item><description><b>5</b>: Other.</description></item>
            /// <item><description><b>6</b>: Information leakage.</description></item>
            /// <item><description><b>7</b>: DoS attack.</description></item>
            /// <item><description><b>8</b>: Overflow attack.</description></item>
            /// <item><description><b>9</b>: Web attack.</description></item>
            /// <item><description><b>10</b>: Trojan or backdoor.</description></item>
            /// <item><description><b>11</b>: Virus or worm.</description></item>
            /// <item><description><b>12</b>: Mining behavior.</description></item>
            /// <item><description><b>13</b>: Reverse shell.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AttackType")]
            [Validation(Required=false)]
            public long? AttackType { get; set; }

            /// <summary>
            /// <para>The traffic direction of the intrusion prevention event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>in</b>: Inbound.</description></item>
            /// <item><description><b>out</b>: Outbound.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>in</para>
            /// </summary>
            [NameInMap("Direction")]
            [Validation(Required=false)]
            public string Direction { get; set; }

            /// <summary>
            /// <para>The queried destination IP address. This indicates that the intrusion prevention event involves this destination IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.2.2.2</para>
            /// </summary>
            [NameInMap("DstIP")]
            [Validation(Required=false)]
            public string DstIP { get; set; }

            /// <summary>
            /// <para>The destination port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("DstPort")]
            [Validation(Required=false)]
            public int? DstPort { get; set; }

            /// <summary>
            /// <para>The matched content.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.example.com">www.example.com</a></para>
            /// </summary>
            [NameInMap("HitContent")]
            [Validation(Required=false)]
            public string HitContent { get; set; }

            /// <summary>
            /// <para>The match type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>domain</para>
            /// </summary>
            [NameInMap("HitType")]
            [Validation(Required=false)]
            public string HitType { get; set; }

            /// <summary>
            /// <para>The protocol type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tcp</para>
            /// </summary>
            [NameInMap("IpProtocol")]
            [Validation(Required=false)]
            public string IpProtocol { get; set; }

            /// <summary>
            /// <para>The UID of the Cloud Firewall member account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>14151892****7022</para>
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public long? MemberUid { get; set; }

            /// <summary>
            /// <para>The ID of the protection rule for the intrusion prevention event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00000000-0000-0000-0000-000000000000</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The name of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The defense status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Alert.</description></item>
            /// <item><description><b>2</b>: Block.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RuleResult")]
            [Validation(Required=false)]
            public int? RuleResult { get; set; }

            /// <summary>
            /// <para>The source of the detection rule for the intrusion prevention event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Basic protection.</description></item>
            /// <item><description><b>2</b>: Virtual Patches.</description></item>
            /// <item><description><b>4</b>: Threat intelligence.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RuleSource")]
            [Validation(Required=false)]
            public long? RuleSource { get; set; }

            /// <summary>
            /// <para>The SNI used when the TLS connection is established.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.example.com">www.example.com</a></para>
            /// </summary>
            [NameInMap("Sni")]
            [Validation(Required=false)]
            public string Sni { get; set; }

            /// <summary>
            /// <para>The queried source IP address. This indicates that the intrusion prevention event involves this source IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.0.XX.XX</para>
            /// </summary>
            [NameInMap("SrcIP")]
            [Validation(Required=false)]
            public string SrcIP { get; set; }

            /// <summary>
            /// <para>The source port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20206</para>
            /// </summary>
            [NameInMap("SrcPort")]
            [Validation(Required=false)]
            public int? SrcPort { get; set; }

            /// <summary>
            /// <para>The cipher suite used for TLS handshake negotiation, such as TLS_AES_128_GCM_SHA256.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TLS_AES_128_GCM_SHA256</para>
            /// </summary>
            [NameInMap("SslCipher")]
            [Validation(Required=false)]
            public string SslCipher { get; set; }

            /// <summary>
            /// <para>The phase in which the TLS handshake fails, such as Certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Certificate</para>
            /// </summary>
            [NameInMap("SslErrorIndex")]
            [Validation(Required=false)]
            public string SslErrorIndex { get; set; }

            /// <summary>
            /// <para>The reason for the TLS handshake failure, such as BAD_PACKET_LENGTH.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BAD_PACKET_LENGTH</para>
            /// </summary>
            [NameInMap("SslErrorMsg")]
            [Validation(Required=false)]
            public string SslErrorMsg { get; set; }

            /// <summary>
            /// <para>The TLS handshake result. For example, success indicates that the handshake is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("SslHandshakeRes")]
            [Validation(Required=false)]
            public string SslHandshakeRes { get; set; }

            /// <summary>
            /// <para>The TLS version, such as TLSv1.3.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TLSv1.3</para>
            /// </summary>
            [NameInMap("SslProtocol")]
            [Validation(Required=false)]
            public string SslProtocol { get; set; }

            /// <summary>
            /// <para>The start time of the data. The value is a timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1751423362</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The URL path.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://example.com/task3%DF%5C%5C">http://example.com/task3%DF\\</a>&quot;</para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            /// <summary>
            /// <para>The severity level of the intrusion prevention event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Low.</description></item>
            /// <item><description><b>2</b>: Medium.</description></item>
            /// <item><description><b>3</b>: High.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("VulLevel")]
            [Validation(Required=false)]
            public long? VulLevel { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D19D8F70-D64B-5A95-905A-6073BF4A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
