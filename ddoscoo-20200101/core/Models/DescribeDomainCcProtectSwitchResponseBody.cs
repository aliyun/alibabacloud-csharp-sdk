// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainCcProtectSwitchResponseBody : TeaModel {
        /// <summary>
        /// <para>The status of each protection feature for the website.</para>
        /// </summary>
        [NameInMap("ProtectSwitchList")]
        [Validation(Required=false)]
        public List<DescribeDomainCcProtectSwitchResponseBodyProtectSwitchList> ProtectSwitchList { get; set; }
        public class DescribeDomainCcProtectSwitchResponseBodyProtectSwitchList : TeaModel {
            /// <summary>
            /// <para>The mode of AI-powered protection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>watch</b>: Warning mode</para>
            /// </description></item>
            /// <item><description><para><b>defense</b>: Defense mode</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>defense</para>
            /// </summary>
            [NameInMap("AiMode")]
            [Validation(Required=false)]
            public string AiMode { get; set; }

            /// <summary>
            /// <para>The status of the AI-powered protection feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: Disabled</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: Enabled</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AiRuleEnable")]
            [Validation(Required=false)]
            public int? AiRuleEnable { get; set; }

            /// <summary>
            /// <para>The level of AI-powered protection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>level30</b>: Loose</para>
            /// </description></item>
            /// <item><description><para><b>level60</b>: Normal</para>
            /// </description></item>
            /// <item><description><para><b>level90</b>: Strict</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>level60</para>
            /// </summary>
            [NameInMap("AiTemplate")]
            [Validation(Required=false)]
            public string AiTemplate { get; set; }

            /// <summary>
            /// <para>The status of the blacklists and whitelists feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: Disabled</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: Enabled</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BlackWhiteListEnable")]
            [Validation(Required=false)]
            public int? BlackWhiteListEnable { get; set; }

            /// <summary>
            /// <para>The status of custom CC rules. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: Disabled</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: Enabled</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CcCustomRuleEnable")]
            [Validation(Required=false)]
            public int? CcCustomRuleEnable { get; set; }

            /// <summary>
            /// <para>The status of the rate limiting (CC protection) feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: Disabled</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: Enabled</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CcEnable")]
            [Validation(Required=false)]
            public int? CcEnable { get; set; }

            /// <summary>
            /// <para>The status of the global switch for custom and precise CC protection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>open</b>: Enabled</para>
            /// </description></item>
            /// <item><description><para><b>close</b>: Disabled</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>close</para>
            /// </summary>
            [NameInMap("CcGlobalSwitch")]
            [Validation(Required=false)]
            public string CcGlobalSwitch { get; set; }

            /// <summary>
            /// <para>The CC protection mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>default</b>: Normal</para>
            /// </description></item>
            /// <item><description><para><b>gf_under_attack</b>: Emergency</para>
            /// </description></item>
            /// <item><description><para><b>gf_sos_verify</b>: Strict</para>
            /// </description></item>
            /// <item><description><para><b>gf_sos_enhance</b>: Very Strict</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("CcTemplate")]
            [Validation(Required=false)]
            public string CcTemplate { get; set; }

            /// <summary>
            /// <para>The domain name of the website.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyundoc.com">www.aliyundoc.com</a></para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The status of the precise access control feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: Disabled</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: Enabled</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PreciseRuleEnable")]
            [Validation(Required=false)]
            public int? PreciseRuleEnable { get; set; }

            /// <summary>
            /// <para>The status of the Location Blacklist (Domain Names) feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: Disabled</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: Enabled</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RegionBlockEnable")]
            [Validation(Required=false)]
            public int? RegionBlockEnable { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. This ID is unique to the request. Use the request ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CF33B4C3-196E-4015-AADD-5CAD00057B80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
