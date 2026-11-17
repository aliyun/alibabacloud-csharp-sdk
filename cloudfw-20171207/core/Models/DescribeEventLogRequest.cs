// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeEventLogRequest : TeaModel {
        /// <summary>
        /// <para>The attack type of the intrusion prevention event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Abnormal connection.</description></item>
        /// <item><description><b>2</b>: execute commands.</description></item>
        /// <item><description><b>3</b>: brute-force attacks.</description></item>
        /// <item><description><b>4</b>: Scan.</description></item>
        /// <item><description><b>5</b>: Other.</description></item>
        /// <item><description><b>6</b>: Information leak.</description></item>
        /// <item><description><b>7</b>: DoS attack.</description></item>
        /// <item><description><b>8</b>: Overflow attack.</description></item>
        /// <item><description><b>9</b>: Web attack.</description></item>
        /// <item><description><b>10</b>: Trojan backdoor.</description></item>
        /// <item><description><b>11</b>: Virus and worm.</description></item>
        /// <item><description><b>12</b>: Mining behavior.</description></item>
        /// <item><description><b>13</b>: Reverse shell.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify the Settings for this parameter, events of all attack types are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>13</para>
        /// </summary>
        [NameInMap("AttackType")]
        [Validation(Required=false)]
        public long? AttackType { get; set; }

        /// <summary>
        /// <para>The page number for paging in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <para>The destination IP address to query. If you specify this parameter, the intrusion prevention events that involve this destination IP address are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.XX.XX</para>
        /// </summary>
        [NameInMap("DstIP")]
        [Validation(Required=false)]
        public string DstIP { get; set; }

        /// <summary>
        /// <para>The end time of the query. The value is a UNIX timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1731551104</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The type of Cloud Firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VpcFirewall</b>: virtual private cloud (VPC) firewalls at the border.</description></item>
        /// <item><description><b>InternetFirewall</b> (default): the Internet Border firewall.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///   &quot;internet&quot;,
        ///   &quot;vpc&quot;,
        ///   &quot;nat&quot;
        /// ]</para>
        /// </summary>
        [NameInMap("FirewallType")]
        [Validation(Required=false)]
        public string FirewallType { get; set; }

        /// <summary>
        /// <para>The language for receiving messages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The log type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("LogType")]
        [Validation(Required=false)]
        public string LogType { get; set; }

        /// <summary>
        /// <para>Specifies the number of results per page for a paginated query.</para>
        /// <para>Default value: <b>6</b>, which indicates that 6 results are returned per page. Maximum value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>Filters event logs by rule hits. The value must be the same as the RuleId value in the response. If LogType is set to ips, pass the UUID of the IPS rule (the RuleUuid value returned by DescribeIPSRules) instead of the numeric format (font style) of the RuleId. If both RuleId and AttackType are specified, records that meet both conditions are returned. This parameter takes effect for ips, app_ctl, web_filter, and threat_intelligence. If LogType is set to tls and this parameter is specified, a parameter fault is returned. If no matching records are found, TotalCount is 0. If you do not specify this parameter, event logs are not filtered by rule hit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c0f5caed-d6a5-11e8-8298-00163e109533</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// <para>The defense status of Cloud Firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Alert.</description></item>
        /// <item><description><b>2</b>: Block.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, events of all defense statuses are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RuleResult")]
        [Validation(Required=false)]
        public string RuleResult { get; set; }

        /// <summary>
        /// <para>The tracing code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yundun</para>
        /// </summary>
        [NameInMap("SourceCode")]
        [Validation(Required=false)]
        public string SourceCode { get; set; }

        /// <summary>
        /// <para>The source IP address of the visitor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60.182.79.XXX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The source IP address to query. If you specify this parameter, the intrusion prevention events that involve this source IP address are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47.92.x.x</para>
        /// </summary>
        [NameInMap("SrcIP")]
        [Validation(Required=false)]
        public string SrcIP { get; set; }

        /// <summary>
        /// <para>Filters by the exact TLS handshake result. This parameter takes effect only when LogType is set to tls and is ignored for other types. Valid values: bypass, alert, and failed (handshake failure). If this parameter is not specified, records of the bypass, alert, and failed types are returned, and normal traffic with successful handshakes (success) is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>failed</para>
        /// </summary>
        [NameInMap("SslHandshakeRes")]
        [Validation(Required=false)]
        public string SslHandshakeRes { get; set; }

        /// <summary>
        /// <para>The start time of the query. The value is a UNIX timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1692504764000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
