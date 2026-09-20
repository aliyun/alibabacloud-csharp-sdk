// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class ModifyPolicyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The action type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>10</b>: modifies the name (Name is required).</description></item>
        /// <item><description><b>11</b>: modifies the blacklist timeout period (BlackIpListExpireAt is required). Only IP-specific mitigation policy is supported.</description></item>
        /// <item><description><b>12</b>: modifies the switch for whitelisting back-to-origin IP addresses of Anti-DDoS Pro and Anti-DDoS Premium (WhitenGfbrNets is required). Only IP-specific mitigation policy is supported.</description></item>
        /// <item><description><b>13</b>: modifies the switch for ICMP Blocking (EnableDropIcmp is required). Only IP-specific mitigation policy is supported.</description></item>
        /// <item><description><b>20</b>: adds entries to blacklists and whitelists (WhiteIpList and BlackIpList are optional). Only IP-specific mitigation policy is supported.</description></item>
        /// <item><description><b>21</b>: deletes entries from blacklists and whitelists (WhiteIpList and BlackIpList are optional). Only IP-specific mitigation policy is supported.</description></item>
        /// <item><description><b>22</b>: clears the whitelist. Only IP-specific mitigation policy is supported.</description></item>
        /// <item><description><b>23</b>: clears the blacklist. Only IP-specific mitigation policy is supported.</description></item>
        /// <item><description><b>30</b>: modifies the AI-based intelligent protection switch and level (EnableIntelligence and IntelligenceLevel are required). Only IP-specific mitigation policy is supported.</description></item>
        /// <item><description><b>31</b>: modifies the Location Blacklist configuration (RegionBlockCountryList and RegionBlockProvinceList are optional). Only IP-specific mitigation policy is supported.</description></item>
        /// <item><description><b>32</b>: modifies the source rate limiting configuration (SourceLimit and SourceBlockList are required). Only IP-specific mitigation policy is supported.</description></item>
        /// <item><description><b>33</b>: modifies the reflection attack port filtering (ReflectBlockUdpPortList is required). Only IP-specific mitigation policy is supported.</description></item>
        /// <item><description><b>40</b>: creates a port blocking rule (PortRuleList is required). Only IP-specific mitigation policy is supported.</description></item>
        /// <item><description><b>41</b>: modifies a port blocking rule (PortRuleList is required). Only IP-specific mitigation policy is supported.</description></item>
        /// <item><description><b>42</b>: deletes a port blocking rule (PortRuleList is required). Only IP-specific mitigation policy is supported.</description></item>
        /// <item><description><b>50</b>: creates a byte-match filter rule (FingerPrintRuleList is required). Only IP-specific mitigation policy is supported.</description></item>
        /// <item><description><b>51</b>: modifies a byte-match filter rule (FingerPrintRuleList is required). Only IP-specific mitigation policy is supported.</description></item>
        /// <item><description><b>52</b>: deletes a byte-match filter rule (FingerPrintRuleList is required). Only IP-specific mitigation policy is supported.</description></item>
        /// <item><description><b>60</b>: modifies the port-specific mitigation switch (EnableL4Defense is required). Only port-specific mitigation policy is supported.</description></item>
        /// <item><description><b>61</b>: creates a port-specific mitigation rule (L4RuleList is required). Only port-specific mitigation policy is supported.</description></item>
        /// <item><description><b>62</b>: modifies a port-specific mitigation rule (L4RuleList is required). Only port-specific mitigation policy is supported.</description></item>
        /// <item><description><b>63</b>: deletes a port-specific mitigation rule (L4RuleList is required). Only port-specific mitigation policy is supported.</description></item>
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
        /// <para>The policy ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c52c2fa6-fdac-40c4-8753-be7c********</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The policy name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo**</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The version of the port-specific mitigation policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Not specified</b>: Modifies the default surf mitigation engine policy.</description></item>
        /// <item><description><b>2</b>: Modifies the new stream mitigation engine policy.<remarks>
        /// <para>Only port-specific mitigation policies are supported.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PortVersion")]
        [Validation(Required=false)]
        public string PortVersion { get; set; }

    }

}
