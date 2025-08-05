// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeRiskEventGroupRequest : TeaModel {
        /// <summary>
        /// <para>The names of the attacked applications. Set the value in the <c>[&quot;AttackApp1&quot;,&quot;AttackApp2&quot;]</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;MySql&quot;,&quot;DNS&quot;]</para>
        /// </summary>
        [NameInMap("AttackApp")]
        [Validation(Required=false)]
        public List<string> AttackApp { get; set; }

        /// <summary>
        /// <para>A list of categories of attacked applications, expressed in the format [&quot;AttackAppCategory1&quot;,&quot;AttackAppCategory2&quot;].</para>
        /// </summary>
        [NameInMap("AttackAppCategory")]
        [Validation(Required=false)]
        public List<string> AttackAppCategory { get; set; }

        /// <summary>
        /// <para>The attack type of the intrusion events. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: suspicious connection</description></item>
        /// <item><description><b>2</b>: command execution</description></item>
        /// <item><description><b>3</b>: brute-force attack</description></item>
        /// <item><description><b>4</b>: scanning</description></item>
        /// <item><description><b>5</b>: others</description></item>
        /// <item><description><b>6</b>: information leak</description></item>
        /// <item><description><b>7</b>: DoS attack</description></item>
        /// <item><description><b>8</b>: buffer overflow attack</description></item>
        /// <item><description><b>9</b>: web attack</description></item>
        /// <item><description><b>10</b>: trojan backdoor</description></item>
        /// <item><description><b>11</b>: computer worm</description></item>
        /// <item><description><b>12</b>: mining</description></item>
        /// <item><description><b>13</b>: reverse shell</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, the intrusion events of all attack types are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AttackType")]
        [Validation(Required=false)]
        public string AttackType { get; set; }

        /// <summary>
        /// <para>The edition of Cloud Firewall that you purchase. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2</b>: Premium Edition</description></item>
        /// <item><description><b>3</b>: Enterprise Edition</description></item>
        /// <item><description><b>4</b>: Ultimate Edition</description></item>
        /// <item><description><b>10</b>: Cloud Firewall that uses the pay-as-you-go billing method</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("BuyVersion")]
        [Validation(Required=false)]
        public long? BuyVersion { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <para>The type of the risk events.\
        /// Set the value to <b>session</b>, which indicates intrusion events.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>session</para>
        /// </summary>
        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>The direction of the traffic for the intrusion events. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>in</b>: inbound</description></item>
        /// <item><description><b>out</b>: outbound</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, the intrusion events that are recorded for both inbound and outbound traffic are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>in</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The destination IP address to query. If you specify this parameter, all intrusion events with the specified destination IP address are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("DstIP")]
        [Validation(Required=false)]
        public string DstIP { get; set; }

        /// <summary>
        /// <para>The ID of the destination VPC.</para>
        /// <remarks>
        /// <para>If the FirewallType parameter is set to VpcFirewall, you must specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-uf6e9a9zyokj2ywuo****</para>
        /// </summary>
        [NameInMap("DstNetworkInstanceId")]
        [Validation(Required=false)]
        public string DstNetworkInstanceId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The value is a UNIX timestamp. Unit: seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1534408267</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The name of the intrusion event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Webshell communication</para>
        /// </summary>
        [NameInMap("EventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// <para>The type of the firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VpcFirewall</b>: virtual private cloud (VPC) firewall</description></item>
        /// <item><description><b>InternetFirewall</b>: Internet firewall (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>InternetFirewall</para>
        /// </summary>
        [NameInMap("FirewallType")]
        [Validation(Required=false)]
        public string FirewallType { get; set; }

        /// <summary>
        /// <para>Whether to query only the data that has completed private network tracing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsOnlyPrivateAssoc")]
        [Validation(Required=false)]
        public string IsOnlyPrivateAssoc { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese (default)</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Specifies whether to query the information about the geographical locations of IP addresses.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: does not query the information about the geographical locations of IP addresses.</description></item>
        /// <item><description><b>false</b>: queries the information about the geographical locations of IP addresses. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NoLocation")]
        [Validation(Required=false)]
        public string NoLocation { get; set; }

        /// <summary>
        /// <para>The order in which you want to sort the results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>asc</b>: the ascending order.</description></item>
        /// <item><description><b>desc</b>: the descending order. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <para>Default value: <b>6</b>. Maximum value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The status of the firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: alerting</description></item>
        /// <item><description><b>2</b>: blocking</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, all intrusion events that are detected by the firewall are queried, regardless of the firewall status.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RuleResult")]
        [Validation(Required=false)]
        public string RuleResult { get; set; }

        /// <summary>
        /// <para>The module of the rule that is used to detect the intrusion events. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: basic protection</description></item>
        /// <item><description><b>2</b>: virtual patching</description></item>
        /// <item><description><b>4</b>: threat intelligence</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, the intrusion events that are detected by all rules are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RuleSource")]
        [Validation(Required=false)]
        public string RuleSource { get; set; }

        /// <summary>
        /// <para>The field based on which you want to sort the results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VulLevel</b>: The results are sorted based on the risk level field. This is the default value.</description></item>
        /// <item><description><b>LastTime</b>: The results are sorted based on the most recent occurrence time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>LastTime</para>
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        /// <summary>
        /// <para>The source IP address to query. If you specify this parameter, all intrusion events with the specified source IP address are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("SrcIP")]
        [Validation(Required=false)]
        public string SrcIP { get; set; }

        /// <summary>
        /// <para>The ID of the source VPC.</para>
        /// <remarks>
        /// <para>If the FirewallType parameter is set to VpcFirewall, you must specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-uf6e9a9zyokj2ywuo****</para>
        /// </summary>
        [NameInMap("SrcNetworkInstanceId")]
        [Validation(Required=false)]
        public string SrcNetworkInstanceId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The value is a UNIX timestamp. Unit: seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1534408189</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The risk level of the intrusion events. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: low</description></item>
        /// <item><description><b>2</b>: medium</description></item>
        /// <item><description><b>3</b>: high</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, the intrusion events that are at all risk levels are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("VulLevel")]
        [Validation(Required=false)]
        public string VulLevel { get; set; }

    }

}
