// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeWebCcProtectSwitchResponseBody : TeaModel {
        /// <summary>
        /// <para>The status of each mitigation policy for the website.</para>
        /// </summary>
        [NameInMap("ProtectSwitchList")]
        [Validation(Required=false)]
        public List<DescribeWebCcProtectSwitchResponseBodyProtectSwitchList> ProtectSwitchList { get; set; }
        public class DescribeWebCcProtectSwitchResponseBodyProtectSwitchList : TeaModel {
            /// <summary>
            /// <para>The mode of Intelligent Protection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>watch</b>: Warning</description></item>
            /// <item><description><b>defense</b>: Defense</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>defense</para>
            /// </summary>
            [NameInMap("AiMode")]
            [Validation(Required=false)]
            public string AiMode { get; set; }

            /// <summary>
            /// <para>The status of Intelligent Protection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: turned off</description></item>
            /// <item><description><b>1:</b> turned on</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AiRuleEnable")]
            [Validation(Required=false)]
            public int? AiRuleEnable { get; set; }

            /// <summary>
            /// <para>The level of Intelligent Protection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>level30</b>: Loose</description></item>
            /// <item><description><b>level60</b>: Normal</description></item>
            /// <item><description><b>level90</b>: Strict</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>level60</para>
            /// </summary>
            [NameInMap("AiTemplate")]
            [Validation(Required=false)]
            public string AiTemplate { get; set; }

            /// <summary>
            /// <para>The status of Blacklist/Whitelist (Domain Names). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: turned off</description></item>
            /// <item><description><b>1:</b> turned on</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BlackWhiteListEnable")]
            [Validation(Required=false)]
            public int? BlackWhiteListEnable { get; set; }

            /// <summary>
            /// <para>The status of the Custom Rules switch for Frequency Control. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: turned off</description></item>
            /// <item><description><b>1:</b> turned on</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CcCustomRuleEnable")]
            [Validation(Required=false)]
            public int? CcCustomRuleEnable { get; set; }

            /// <summary>
            /// <para>The status of Frequency Control. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: turned off</description></item>
            /// <item><description><b>1:</b> turned on</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CcEnable")]
            [Validation(Required=false)]
            public int? CcEnable { get; set; }

            [NameInMap("CcGlobalSwitch")]
            [Validation(Required=false)]
            public string CcGlobalSwitch { get; set; }

            /// <summary>
            /// <para>The mode of Frequency Control. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>default</b>: Normal</description></item>
            /// <item><description><b>gf_under_attack</b>: Emergency</description></item>
            /// <item><description><b>gf_sos_verify</b>: Strict</description></item>
            /// <item><description><b>gf_sos_enhance</b>: Super Strict</description></item>
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
            /// <para><a href="http://www.aliyun.com">www.aliyun.com</a></para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The status of Accurate Access Control. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: turned off</description></item>
            /// <item><description><b>1:</b> turned on</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PreciseRuleEnable")]
            [Validation(Required=false)]
            public int? PreciseRuleEnable { get; set; }

            /// <summary>
            /// <para>The status of Location Blacklist (Domain Names). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: turned off</description></item>
            /// <item><description><b>1:</b> turned on</description></item>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3ADD9EED-CA4B-488C-BC82-01B0B899363D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
