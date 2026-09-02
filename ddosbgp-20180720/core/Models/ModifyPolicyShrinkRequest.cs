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
        /// <item><description><b>10</b>: Modifies the name (Name is required).</description></item>
        /// <item><description><b>11</b>: Modifies the blacklist timeout period (BlackIpListExpireAt is required). Only IP-specific mitigation policies are supported.</description></item>
        /// <item><description><b>12</b>: Modifies the switch for whitelisting back-to-origin IP addresses of Anti-DDoS Pro and Anti-DDoS Premium (WhitenGfbrNets is required). Only IP-specific mitigation policies are supported.</description></item>
        /// <item><description><b>13</b>: Modifies the switch for ICMP Blocking (EnableDropIcmp is required). Only IP-specific mitigation policies are supported.</description></item>
        /// <item><description><b>20</b>: Adds blacklist and whitelist entries (WhiteIpList and BlackIpList are optional). Only IP-specific mitigation policies are supported.</description></item>
        /// <item><description><b>21</b>: Deletes blacklist and whitelist entries (WhiteIpList and BlackIpList are optional). Only IP-specific mitigation policies are supported.</description></item>
        /// <item><description><b>22</b>: Clears the whitelist. Only IP-specific mitigation policies are supported.</description></item>
        /// <item><description><b>23</b>: Clears the blacklist. Only IP-specific mitigation policies are supported.</description></item>
        /// <item><description><b>30</b>: Modifies the AI-based intelligent protection switch and level (EnableIntelligence and IntelligenceLevel are required). Only IP-specific mitigation policies are supported.</description></item>
        /// <item><description><b>31</b>: Modifies the Location Blacklist configuration (RegionBlockCountryList and RegionBlockProvinceList are optional). Only IP-specific mitigation policies are supported.</description></item>
        /// <item><description><b>32</b>: Modifies the Source Rate Limiting configuration (SourceLimit and SourceBlockList are required). Only IP-specific mitigation policies are supported.</description></item>
        /// <item><description><b>33</b>: Modifies the Reflection Attack Filtering (ReflectBlockUdpPortList is required). Only IP-specific mitigation policies are supported.</description></item>
        /// <item><description><b>40</b>: Creates a Port Blocking rule (PortRuleList is required). Only IP-specific mitigation policies are supported.</description></item>
        /// <item><description><b>41</b>: Modifies a Port Blocking rule (PortRuleList is required). Only IP-specific mitigation policies are supported.</description></item>
        /// <item><description><b>42</b>: Deletes a Port Blocking rule (PortRuleList is required). Only IP-specific mitigation policies are supported.</description></item>
        /// <item><description><b>50</b>: Creates a Byte-Match Filter rule (FingerPrintRuleList is required). Only IP-specific mitigation policies are supported.</description></item>
        /// <item><description><b>51</b>: Modifies a Byte-Match Filter rule (FingerPrintRuleList is required). Only IP-specific mitigation policies are supported.</description></item>
        /// <item><description><b>52</b>: Deletes a Byte-Match Filter rule (FingerPrintRuleList is required). Only IP-specific mitigation policies are supported.</description></item>
        /// <item><description><b>60</b>: Modifies the port-specific mitigation switch (EnableL4Defense is required). Only port-specific mitigation policies are supported.</description></item>
        /// <item><description><b>61</b>: Creates a port-specific mitigation rule (L4RuleList is required). Only port-specific mitigation policies are supported.</description></item>
        /// <item><description><b>62</b>: Modifies a port-specific mitigation rule (L4RuleList is required). Only port-specific mitigation policies are supported.</description></item>
        /// <item><description><b>63</b>: Deletes a port-specific mitigation rule (L4RuleList is required). Only port-specific mitigation policies are supported.</description></item>
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
        /// <para>The port-specific mitigation policy version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Empty</b>: Modifies the default surf DPI engine policy.</description></item>
        /// <item><description><b>2</b>: Modifies the new stream DPI engine policy.<remarks>
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
