// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyIpsRulesToDefaultRequest : TeaModel {
        /// <summary>
        /// <para>The attack application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PHP</para>
        /// </summary>
        [NameInMap("AttackApp")]
        [Validation(Required=false)]
        public string AttackApp { get; set; }

        /// <summary>
        /// <para>The Cloud Firewall type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VpcFirewall</b>: virtual private cloud (VPC) firewall</description></item>
        /// <item><description><b>InternetFirewall</b> (default): the Internet firewall</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>InternetFirewall</para>
        /// </summary>
        [NameInMap("FirewallType")]
        [Validation(Required=false)]
        public string FirewallType { get; set; }

        /// <summary>
        /// <para>The language type. Valid values:</para>
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
        /// <para>Instance ID of the NAT firewall instance. This parameter is required only when FirewallType is set to <b>NatFirewall</b>. In this case, the scope is the rules under this instance. This parameter is ignored for Internet and VPC firewalls. You can call the <a href="https://help.aliyun.com/document_detail/2879296.html">ListNatFirewallIpsConfigs</a> operation to query instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>proxy-nat53f4bbc233234271a1d7</para>
        /// </summary>
        [NameInMap("ProxyId")]
        [Validation(Required=false)]
        public string ProxyId { get; set; }

        /// <summary>
        /// <para>The rule type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>basicRule</b></description></item>
        /// <item><description><b>customize</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>customize</para>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

        /// <summary>
        /// <para>The list of rules. This parameter is conditionally required: when RuleType is set to customize, you must specify at least one of this parameter or AttackApp. If you specify only RuleType without Rules or AttackApp, the API returns an ErrorParameters error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///   &quot;uuid_1&quot;,
        ///   &quot;uuid_2&quot;
        /// ]</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public string Rules { get; set; }

        /// <summary>
        /// <para>The source IP address of the requester.</para>
        /// 
        /// <b>Example:</b>
        /// <para>140.205.118.XXX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
