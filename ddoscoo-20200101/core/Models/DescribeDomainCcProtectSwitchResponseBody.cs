// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainCcProtectSwitchResponseBody : TeaModel {
        [NameInMap("ProtectSwitchList")]
        [Validation(Required=false)]
        public List<DescribeDomainCcProtectSwitchResponseBodyProtectSwitchList> ProtectSwitchList { get; set; }
        public class DescribeDomainCcProtectSwitchResponseBodyProtectSwitchList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>defense</para>
            /// </summary>
            [NameInMap("AiMode")]
            [Validation(Required=false)]
            public string AiMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AiRuleEnable")]
            [Validation(Required=false)]
            public int? AiRuleEnable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>level60</para>
            /// </summary>
            [NameInMap("AiTemplate")]
            [Validation(Required=false)]
            public string AiTemplate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BlackWhiteListEnable")]
            [Validation(Required=false)]
            public int? BlackWhiteListEnable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CcCustomRuleEnable")]
            [Validation(Required=false)]
            public int? CcCustomRuleEnable { get; set; }

            /// <summary>
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
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("CcTemplate")]
            [Validation(Required=false)]
            public string CcTemplate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyundoc.com">www.aliyundoc.com</a></para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PreciseRuleEnable")]
            [Validation(Required=false)]
            public int? PreciseRuleEnable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RegionBlockEnable")]
            [Validation(Required=false)]
            public int? RegionBlockEnable { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CF33B4C3-196E-4015-AADD-5CAD00057B80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
