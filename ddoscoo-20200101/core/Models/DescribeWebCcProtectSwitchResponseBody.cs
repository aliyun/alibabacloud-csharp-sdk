// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeWebCcProtectSwitchResponseBody : TeaModel {
        /// <summary>
        /// The status of each mitigation policy for the website.
        /// </summary>
        [NameInMap("ProtectSwitchList")]
        [Validation(Required=false)]
        public List<DescribeWebCcProtectSwitchResponseBodyProtectSwitchList> ProtectSwitchList { get; set; }
        public class DescribeWebCcProtectSwitchResponseBodyProtectSwitchList : TeaModel {
            /// <summary>
            /// The mode of Intelligent Protection. Valid values:
            /// 
            /// *   **watch**: Warning
            /// *   **defense**: Defense
            /// </summary>
            [NameInMap("AiMode")]
            [Validation(Required=false)]
            public string AiMode { get; set; }

            /// <summary>
            /// The status of Intelligent Protection. Valid values:
            /// 
            /// *   **0**: turned off
            /// *   **1:** turned on
            /// </summary>
            [NameInMap("AiRuleEnable")]
            [Validation(Required=false)]
            public int? AiRuleEnable { get; set; }

            /// <summary>
            /// The level of Intelligent Protection. Valid values:
            /// 
            /// *   **level30**: Loose
            /// *   **level60**: Normal
            /// *   **level90**: Strict
            /// </summary>
            [NameInMap("AiTemplate")]
            [Validation(Required=false)]
            public string AiTemplate { get; set; }

            /// <summary>
            /// The status of Blacklist/Whitelist (Domain Names). Valid values:
            /// 
            /// *   **0**: turned off
            /// *   **1:** turned on
            /// </summary>
            [NameInMap("BlackWhiteListEnable")]
            [Validation(Required=false)]
            public int? BlackWhiteListEnable { get; set; }

            /// <summary>
            /// The status of the Custom Rules switch for Frequency Control. Valid values:
            /// 
            /// *   **0**: turned off
            /// *   **1:** turned on
            /// </summary>
            [NameInMap("CcCustomRuleEnable")]
            [Validation(Required=false)]
            public int? CcCustomRuleEnable { get; set; }

            /// <summary>
            /// The status of Frequency Control. Valid values:
            /// 
            /// *   **0**: turned off
            /// *   **1:** turned on
            /// </summary>
            [NameInMap("CcEnable")]
            [Validation(Required=false)]
            public int? CcEnable { get; set; }

            [NameInMap("CcGlobalSwitch")]
            [Validation(Required=false)]
            public string CcGlobalSwitch { get; set; }

            /// <summary>
            /// The mode of Frequency Control. Valid values:
            /// 
            /// *   **default**: Normal
            /// *   **gf_under_attack**: Emergency
            /// *   **gf_sos_verify**: Strict
            /// *   **gf_sos_enhance**: Super Strict
            /// </summary>
            [NameInMap("CcTemplate")]
            [Validation(Required=false)]
            public string CcTemplate { get; set; }

            /// <summary>
            /// The domain name of the website.
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// The status of Accurate Access Control. Valid values:
            /// 
            /// *   **0**: turned off
            /// *   **1:** turned on
            /// </summary>
            [NameInMap("PreciseRuleEnable")]
            [Validation(Required=false)]
            public int? PreciseRuleEnable { get; set; }

            /// <summary>
            /// The status of Location Blacklist (Domain Names). Valid values:
            /// 
            /// *   **0**: turned off
            /// *   **1:** turned on
            /// </summary>
            [NameInMap("RegionBlockEnable")]
            [Validation(Required=false)]
            public int? RegionBlockEnable { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
