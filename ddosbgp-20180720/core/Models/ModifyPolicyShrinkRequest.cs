// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class ModifyPolicyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The type of the action. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>10</b>: modifies the name. If you specify this value, <c>Name</c> is required.</description></item>
        /// <item><description><b>11</b>: modifies the blacklist validity period. If you specify this value, <c>BlackIpListExpireAt</c> is required. Only IP-specific mitigation policies support this value.</description></item>
        /// <item><description><b>12</b>: changes the status of the feature of adding back-to-origin CIDR blocks of Anti-DDoS Proxy to the whitelist. If you specify this value, <c>WhitenGfbrNets</c> is required. Only IP-specific mitigation policies support this value.</description></item>
        /// <item><description><b>13</b>: changes the status of the ICMP blocking feature. If you specify this value, <c>EnableDropIcmp</c> is required. Only IP-specific mitigation policies support this value.</description></item>
        /// <item><description><b>20</b>: adds IP addresses to the blacklist or the whitelist. If you specify this value, you must specify at least one of <c>WhiteIpList</c> and <c>BlackIpList</c>. Only IP-specific mitigation policies support this value.</description></item>
        /// <item><description><b>21</b>: removes IP addresses from the blacklist or the whitelist. If you specify this value, at least one of <c>WhiteIpList</c> and <c>BlackIpList</c> is required. Only IP-specific mitigation policies support this value.</description></item>
        /// <item><description><b>22</b>: clears the whitelist. Only IP-specific mitigation policies support this value.</description></item>
        /// <item><description><b>23</b>: clears the blacklist. Only IP-specific mitigation policies support this value.</description></item>
        /// <item><description><b>30</b>: modifies the status and level of intelligent protection. If you specify this value, <c>EnableIntelligence</c> and <c>IntelligenceLevel</c> are required. Only IP-specific mitigation policies support this value.</description></item>
        /// <item><description><b>31</b>: modifies the location blacklist settings. If you specify this value, one of <c>RegionBlockCountryList</c> and <c>RegionBlockProvinceList</c> is required. Only IP-specific mitigation policies support this value.</description></item>
        /// <item><description><b>32</b>: modifies the settings for source rate limiting. If you specify this value, <c>SourceLimit</c> and <c>SourceBlockList</c> are required. Only IP-specific mitigation policies support this value.</description></item>
        /// <item><description><b>33</b>: modifies the settings for reflection attack filtering. If you specify this value, <c>ReflectBlockUdpPortList</c> is required. Only IP-specific mitigation policies support this value.</description></item>
        /// <item><description><b>40</b>: creates a port blocking rule. If you specify this value, <c>PortRuleList</c> is required. Only IP-specific mitigation policies support this value.</description></item>
        /// <item><description><b>41</b>: modifies the port blocking rule. If you specify this value, <c>PortRuleList</c> is required. Only IP-specific mitigation policies support this value.</description></item>
        /// <item><description><b>42</b>: deletes the port blocking rule. If you specify this value, <c>PortRuleList</c> is required. Only IP-specific mitigation policies support this value.</description></item>
        /// <item><description><b>50</b>: creates a byte-match filter rule. If you specify this value, <c>FingerPrintRuleList</c> is required. Only IP-specific mitigation policies support this value.</description></item>
        /// <item><description><b>51</b>: modifies the byte-match filter rule. If you specify this value, <c>FingerPrintRuleList</c> is required. Only IP-specific mitigation policies support this value.</description></item>
        /// <item><description><b>52</b>: deletes the byte-match filter rule. If you specify this value, <c>FingerPrintRuleList</c> is required. Only IP-specific mitigation policies support this value.</description></item>
        /// <item><description><b>60</b>: changes the status of the port-specific mitigation feature. If you specify this value, <c>EnableL4Defense</c> is required. Only port-specific mitigation policies support this value.</description></item>
        /// <item><description><b>61</b>: creates a port-specific mitigation rule. If you specify this value, <c>L4RuleList</c> is required. Only port-specific mitigation policies support this value.</description></item>
        /// <item><description><b>62</b>: modifies the port-specific mitigation rule. If you specify this value, <c>L4RuleList</c> is required. Only port-specific mitigation policies support this value.</description></item>
        /// <item><description><b>63</b>: deletes the port-specific mitigation rule. If you specify this value, <c>L4RuleList</c> is required. Only port-specific mitigation policies support this value.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("ActionType")]
        [Validation(Required=false)]
        public int? ActionType { get; set; }

        /// <summary>
        /// <para>The policy content.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string ContentShrink { get; set; }

        /// <summary>
        /// <para>The ID of the policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c52c2fa6-fdac-40c4-8753-be7c********</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The name of the policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo**</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
