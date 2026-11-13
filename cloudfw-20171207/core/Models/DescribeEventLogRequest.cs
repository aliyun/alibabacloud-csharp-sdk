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
        /// <remarks>
        /// <para>If this parameter is not specified, all attack types are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>13</para>
        /// </summary>
        [NameInMap("AttackType")]
        [Validation(Required=false)]
        public long? AttackType { get; set; }

        /// <summary>
        /// <para>The page number for a paged query.</para>
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
        /// <item><description><b>VpcFirewall</b>: virtual private cloud (VPC) firewalls.</description></item>
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
        /// <para>The number of entries to return on each page.</para>
        /// <para>Default value: <b>6</b>, which indicates that 6 entries are returned on each page. Maximum value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

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
