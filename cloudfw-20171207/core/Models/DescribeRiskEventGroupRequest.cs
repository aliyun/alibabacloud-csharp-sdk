// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeRiskEventGroupRequest : TeaModel {
        /// <summary>
        /// <para>A list of names of the attacked applications. Use the <c>[&quot;AttackApp1&quot;,&quot;AttackApp2&quot;]</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;MySql&quot;,&quot;DNS&quot;]</para>
        /// </summary>
        [NameInMap("AttackApp")]
        [Validation(Required=false)]
        public List<string> AttackApp { get; set; }

        /// <summary>
        /// <para>A list of categories of the attacked applications. Use the [&quot;AttackAppCategory1&quot;,&quot;AttackAppCategory2&quot;] format.</para>
        /// </summary>
        [NameInMap("AttackAppCategory")]
        [Validation(Required=false)]
        public List<string> AttackAppCategory { get; set; }

        /// <summary>
        /// <para>The type of the attack. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: abnormal connection</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: command execution</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: brute-force attack</para>
        /// </description></item>
        /// <item><description><para><b>4</b>: scan</para>
        /// </description></item>
        /// <item><description><para><b>5</b>: other</para>
        /// </description></item>
        /// <item><description><para><b>6</b>: information leakage</para>
        /// </description></item>
        /// <item><description><para><b>7</b>: DoS attack</para>
        /// </description></item>
        /// <item><description><para><b>8</b>: overflow attack</para>
        /// </description></item>
        /// <item><description><para><b>9</b>: web attack</para>
        /// </description></item>
        /// <item><description><para><b>10</b>: backdoor trojan</para>
        /// </description></item>
        /// <item><description><para><b>11</b>: virus or worm</para>
        /// </description></item>
        /// <item><description><para><b>12</b>: mining behavior</para>
        /// </description></item>
        /// <item><description><para><b>13</b>: reverse shell</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not set this parameter, events of all attack types are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AttackType")]
        [Validation(Required=false)]
        public string AttackType { get; set; }

        /// <summary>
        /// <para>The edition of Cloud Firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>2</b>: Premium Edition</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: Enterprise Edition</para>
        /// </description></item>
        /// <item><description><para><b>4</b>: Ultimate Edition</para>
        /// </description></item>
        /// <item><description><para><b>10</b>: pay-as-you-go</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("BuyVersion")]
        [Validation(Required=false)]
        public long? BuyVersion { get; set; }

        /// <summary>
        /// <para>The page number of the returned data.
        /// Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <para>The type of the risk event.<br>
        /// Set the value to <b>session</b>, which indicates intrusion prevention events.<br></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>session</para>
        /// </summary>
        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>The traffic direction of the intrusion prevention event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>in</b>: inbound</para>
        /// </description></item>
        /// <item><description><para><b>out</b>: outbound</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not set this parameter, events in all traffic directions are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>in</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The destination IP address to query. If you set this parameter, only intrusion prevention events that contain the specified destination IP address are queried.</para>
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
        /// <para>This parameter is required only when \<c>FirewallType\\</c> is set to \<c>VpcFirewall\\</c>.</para>
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
        /// <para>The name of the intrusion prevention event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wooden horse rear door communication</para>
        /// </summary>
        [NameInMap("EventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// <para>The type of the firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>VpcFirewall</b>: VPC firewall</para>
        /// </description></item>
        /// <item><description><para><b>InternetFirewall</b> (default): Internet firewall</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>InternetFirewall</para>
        /// </summary>
        [NameInMap("FirewallType")]
        [Validation(Required=false)]
        public string FirewallType { get; set; }

        /// <summary>
        /// <para>Specifies whether to query only the data that is traced to private IP addresses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsOnlyPrivateAssoc")]
        [Validation(Required=false)]
        public string IsOnlyPrivateAssoc { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Specifies whether to query the IP address location information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Does not query the IP geolocation information.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): Queries the IP geolocation information.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NoLocation")]
        [Validation(Required=false)]
        public string NoLocation { get; set; }

        /// <summary>
        /// <para>The sorting order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>asc</b>: ascending</para>
        /// </description></item>
        /// <item><description><para><b>desc</b> (default): descending</para>
        /// </description></item>
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
        /// <para>The handling status of Cloud Firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: Alert</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: Block</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not set this parameter, events in all handling statuses are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RuleResult")]
        [Validation(Required=false)]
        public string RuleResult { get; set; }

        /// <summary>
        /// <para>The source of the rule that is used to detect the intrusion prevention event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: basic protection</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: virtual patching</para>
        /// </description></item>
        /// <item><description><para><b>4</b>: threat intelligence</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not set this parameter, events detected based on all types of rules are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RuleSource")]
        [Validation(Required=false)]
        public string RuleSource { get; set; }

        /// <summary>
        /// <para>The field to use for sorting. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>VulLevel</b> (default): Sorts by risk level.</para>
        /// </description></item>
        /// <item><description><para><b>LastTime</b>: Sorts by the most recent occurrence time.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>LastTime</para>
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        /// <summary>
        /// <para>The source IP address to query. If you set this parameter, only intrusion prevention events that contain the specified source IP address are queried.</para>
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
        /// <para>This parameter is required only when \<c>FirewallType\\</c> is set to \<c>VpcFirewall\\</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-uf6e9a9zyokj2ywuo****</para>
        /// </summary>
        [NameInMap("SrcNetworkInstanceId")]
        [Validation(Required=false)]
        public string SrcNetworkInstanceId { get; set; }

        /// <summary>
        /// <para>The start of the time range to query. The value is a UNIX timestamp. Unit: seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1534408189</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The risk level of the intrusion prevention event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: low</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: medium</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: high</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not set this parameter, events of all risk levels are queried.</para>
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
