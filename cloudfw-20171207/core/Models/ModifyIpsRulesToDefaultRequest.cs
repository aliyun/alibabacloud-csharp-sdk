// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyIpsRulesToDefaultRequest : TeaModel {
        /// <summary>
        /// <para>The application that is affected by the attack.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PHP</para>
        /// </summary>
        [NameInMap("AttackApp")]
        [Validation(Required=false)]
        public string AttackApp { get; set; }

        /// <summary>
        /// <para>The type of the Cloud Firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>VpcFirewall</b>: VPC firewall.</para>
        /// </description></item>
        /// <item><description><para><b>InternetFirewall</b> (default): Internet firewall.</para>
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
        /// <para>The type of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>basicRule</b></para>
        /// </description></item>
        /// <item><description><para><b>customize</b></para>
        /// </description></item>
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
        /// <para>The list of rules.</para>
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
        /// <para>The source IP address of the visitor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>140.205.118.XXX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
