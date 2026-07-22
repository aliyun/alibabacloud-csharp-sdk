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
        /// <para>The type of the cloud firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VpcFirewall</b>: virtual private cloud (VPC) firewalls.</description></item>
        /// <item><description><b>InternetFirewall</b> (default): the Internet border firewall.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>InternetFirewall</para>
        /// </summary>
        [NameInMap("FirewallType")]
        [Validation(Required=false)]
        public string FirewallType { get; set; }

        /// <summary>
        /// <para>The language of the content. Valid values:</para>
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
        /// <para>The rule type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>basicRule</b></description></item>
        /// <item><description><b>customize</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>customize</para>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

        /// <summary>
        /// <para>The rule list. Conditional requirement: when RuleType is set to customize, you must specify at least one of this parameter or AttackApp. If you specify only RuleType without Rules or AttackApp, the API returns ErrorParameters.</para>
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
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>140.205.118.XXX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
