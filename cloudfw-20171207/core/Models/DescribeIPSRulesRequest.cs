// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeIPSRulesRequest : TeaModel {
        /// <summary>
        /// <para>The attacked application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SMB</para>
        /// </summary>
        [NameInMap("AttackApp")]
        [Validation(Required=false)]
        public string AttackApp { get; set; }

        /// <summary>
        /// <para>The list of categories of the attacked applications. Specify the value in the [&quot;AttackAppCategory1&quot;,&quot;AttackAppCategory2&quot;] format.</para>
        /// </summary>
        [NameInMap("AttackAppCategory")]
        [Validation(Required=false)]
        public List<string> AttackAppCategory { get; set; }

        /// <summary>
        /// <para>The list of attacked applications.</para>
        /// </summary>
        [NameInMap("AttackApps")]
        [Validation(Required=false)]
        public List<string> AttackApps { get; set; }

        /// <summary>
        /// <para>The attack application type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Web attack</para>
        /// </summary>
        [NameInMap("AttackType")]
        [Validation(Required=false)]
        public string AttackType { get; set; }

        /// <summary>
        /// <para>The CVE ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CVE-2026-25253</para>
        /// </summary>
        [NameInMap("Cve")]
        [Validation(Required=false)]
        public string Cve { get; set; }

        /// <summary>
        /// <para>The enabling status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DefaultAction")]
        [Validation(Required=false)]
        public string DefaultAction { get; set; }

        /// <summary>
        /// <para>The Cloud Firewall type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VpcFirewall</para>
        /// </summary>
        [NameInMap("FirewallType")]
        [Validation(Required=false)]
        public string FirewallType { get; set; }

        /// <summary>
        /// <para>The language of the request message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The sorting order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>Specifies whether the rule has been modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("QueryModify")]
        [Validation(Required=false)]
        public string QueryModify { get; set; }

        /// <summary>
        /// <para>The rule action.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alert</para>
        /// </summary>
        [NameInMap("RuleAction")]
        [Validation(Required=false)]
        public string RuleAction { get; set; }

        /// <summary>
        /// <para>The supported engine mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dropStrict</para>
        /// </summary>
        [NameInMap("RuleClass")]
        [Validation(Required=false)]
        public string RuleClass { get; set; }

        /// <summary>
        /// <para>The rule ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f835533b-01ef-49f4-b172-85bbfd0e****</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// <para>The rule level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RuleLevel")]
        [Validation(Required=false)]
        public long? RuleLevel { get; set; }

        /// <summary>
        /// <para>The rule name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Nmap scan detection</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The rule type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>patchRule</para>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

        /// <summary>
        /// <para>The sorting method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UpdateTime</para>
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        /// <summary>
        /// <para>The source IP address of the requester.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8.139.222.XXX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The instance ID of the virtual private cloud (VPC) firewalls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-rnbkqx4a8er21a****</para>
        /// </summary>
        [NameInMap("VpcFirewallId")]
        [Validation(Required=false)]
        public string VpcFirewallId { get; set; }

    }

}
