// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeRiskEventGroupRequest : TeaModel {
        /// <summary>
        /// <para>The list of names of the attacked applications. Specify the value in the <c>[&quot;AttackApp1&quot;,&quot;AttackApp2&quot;]</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;MySql&quot;,&quot;DNS&quot;]</para>
        /// </summary>
        [NameInMap("AttackApp")]
        [Validation(Required=false)]
        public List<string> AttackApp { get; set; }

        /// <summary>
        /// <para>The list of categories of the attacked applications. Specify the value in the <c>[&quot;AttackAppCategory1&quot;,&quot;AttackAppCategory2&quot;]</c> format.</para>
        /// </summary>
        [NameInMap("AttackAppCategory")]
        [Validation(Required=false)]
        public List<string> AttackAppCategory { get; set; }

        /// <summary>
        /// <para>The attack type of the intrusion prevention events. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: abnormal connection.</description></item>
        /// <item><description><b>2</b>: command execute.</description></item>
        /// <item><description><b>3</b>: brute-force attacks.</description></item>
        /// <item><description><b>4</b>: scan.</description></item>
        /// <item><description><b>5</b>: other.</description></item>
        /// <item><description><b>6</b>: information leak.</description></item>
        /// <item><description><b>7</b>: DoS attack.</description></item>
        /// <item><description><b>8</b>: overflow attack.</description></item>
        /// <item><description><b>9</b>: web attack.</description></item>
        /// <item><description><b>10</b>: trojan backdoor.</description></item>
        /// <item><description><b>11</b>: virus worm.</description></item>
        /// <item><description><b>12</b>: mining behavior.</description></item>
        /// <item><description><b>13</b>: reverse shell.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If the Settings for this parameter are not specified, events of all attack types are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AttackType")]
        [Validation(Required=false)]
        public string AttackType { get; set; }

        /// <summary>
        /// <para>The purchased edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2</b>: Premium Edition.</description></item>
        /// <item><description><b>3</b>: Enterprise Edition.</description></item>
        /// <item><description><b>4</b>: Ultimate Edition.</description></item>
        /// <item><description><b>10</b>: Pay-as-you-go Edition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("BuyVersion")]
        [Validation(Required=false)]
        public long? BuyVersion { get; set; }

        /// <summary>
        /// <para>The paging Settings for the page number to return in a paged query.
        /// Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <para>The risk event type. Valid value:  </para>
        /// <list type="bullet">
        /// <item><description><b>session</b>: intrusion prevention event.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>session</para>
        /// </summary>
        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>The traffic direction of the intrusion prevention events. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>in</b>: inbound.</description></item>
        /// <item><description><b>out</b>: outbound.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is not specified, events in all traffic directions are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>in</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The destination IP address to query. If you specify this parameter, intrusion prevention events that involve the specified destination IP address are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("DstIP")]
        [Validation(Required=false)]
        public string DstIP { get; set; }

        /// <summary>
        /// <para>The instance ID of the destination VPC-connected instance.</para>
        /// <remarks>
        /// <para>This parameter is required only when the FirewallType Settings is VpcFirewall.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-uf6e9a9zyokj2ywuo****</para>
        /// </summary>
        [NameInMap("DstNetworkInstanceId")]
        [Validation(Required=false)]
        public string DstNetworkInstanceId { get; set; }

        /// <summary>
        /// <para>The end time of the query. The value is a UNIX timestamp in seconds.</para>
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
        /// <para>The type of the cloud firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VpcFirewall</b>: virtual private cloud (VPC) firewalls.</description></item>
        /// <item><description><b>InternetFirewall</b> (default): the Internet Border firewall.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>InternetFirewall</para>
        /// </summary>
        [NameInMap("FirewallType")]
        [Validation(Required=false)]
        public string FirewallType { get; set; }

        /// <summary>
        /// <para>Specifies whether to query only the data for which private IP tracing is completed.</para>
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
        /// <item><description><b>zh</b> (default): Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Specifies whether to query IP geolocation information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: IP geolocation information is not queried.</description></item>
        /// <item><description><b>false</b> (default): IP geolocation information is queried.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NoLocation")]
        [Validation(Required=false)]
        public string NoLocation { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>asc</b>: ascending order.</para>
        /// </description></item>
        /// <item><description><para><b>desc</b> (default): descending order.</para>
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
        /// <para>The paging Settings for the number of entries to return on each page in a paged query.</para>
        /// <para>Default value: <b>6</b>. Maximum value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The defense status of Cloud Firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: alert.</description></item>
        /// <item><description><b>2</b>: block.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is not specified, events in all defense statuses are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RuleResult")]
        [Validation(Required=false)]
        public string RuleResult { get; set; }

        /// <summary>
        /// <para>The source of the detection rule for the intrusion prevention events. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: basic protection.</description></item>
        /// <item><description><b>2</b>: virtual patches.</description></item>
        /// <item><description><b>4</b>: threat intelligence.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is not specified, events detected by rules from all sources are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RuleSource")]
        [Validation(Required=false)]
        public string RuleSource { get; set; }

        /// <summary>
        /// <para>The field by which to sort the results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>VulLevel</b> (default): sort by severity level.</para>
        /// </description></item>
        /// <item><description><para><b>LastTime</b>: sort by the most recent occurrence time.</para>
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
        /// <para>The source IP address to query. If you specify this parameter, intrusion prevention events that involve the specified source IP address are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("SrcIP")]
        [Validation(Required=false)]
        public string SrcIP { get; set; }

        /// <summary>
        /// <para>The instance ID of the source VPC-connected instance.</para>
        /// <remarks>
        /// <para>This parameter is required only when the FirewallType Settings is VpcFirewall.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-uf6e9a9zyokj2ywuo****</para>
        /// </summary>
        [NameInMap("SrcNetworkInstanceId")]
        [Validation(Required=false)]
        public string SrcNetworkInstanceId { get; set; }

        /// <summary>
        /// <para>The start time of the query. The value is a UNIX timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1534408189</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The severity level of the intrusion prevention events. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: low.</description></item>
        /// <item><description><b>2</b>: medium.</description></item>
        /// <item><description><b>3</b>: high.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is not specified, events at all severity levels are queried.</para>
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
