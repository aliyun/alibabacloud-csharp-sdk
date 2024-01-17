// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeWebCcProtectSwitchResponseBody : TeaModel {
        /// <summary>
        /// The status of each protection policy for a website.
        /// </summary>
        [NameInMap("ProtectSwitchList")]
        [Validation(Required=false)]
        public List<DescribeWebCcProtectSwitchResponseBodyProtectSwitchList> ProtectSwitchList { get; set; }
        public class DescribeWebCcProtectSwitchResponseBodyProtectSwitchList : TeaModel {
            /// <summary>
            /// The mode of the Intelligent Protection policy. Valid values:
            /// 
            /// *   **watch**: the Warning mode
            /// *   **defense**: the Defense mode
            /// </summary>
            [NameInMap("AiMode")]
            [Validation(Required=false)]
            public string AiMode { get; set; }

            /// <summary>
            /// The status of the Intelligent Protection policy. Valid values:
            /// 
            /// *   **0**: disabled
            /// *   **1**: enabled
            /// </summary>
            [NameInMap("AiRuleEnable")]
            [Validation(Required=false)]
            public int? AiRuleEnable { get; set; }

            /// <summary>
            /// The level of the Intelligent Protection policy. Valid values:
            /// 
            /// *   **level30**: the Low level
            /// *   **level60**: the Normal level
            /// *   **level90**: the Strict level
            /// </summary>
            [NameInMap("AiTemplate")]
            [Validation(Required=false)]
            public string AiTemplate { get; set; }

            /// <summary>
            /// The status of the Black Lists and White Lists (Domain Names) policy. Valid values:
            /// 
            /// *   **0**: disabled
            /// *   **1**: enabled
            /// </summary>
            [NameInMap("BlackWhiteListEnable")]
            [Validation(Required=false)]
            public int? BlackWhiteListEnable { get; set; }

            /// <summary>
            /// The status of the Custom Rule switch for the Frequency Control policy. Valid values:
            /// 
            /// *   **0**: disabled
            /// *   **1**: enabled
            /// </summary>
            [NameInMap("CcCustomRuleEnable")]
            [Validation(Required=false)]
            public int? CcCustomRuleEnable { get; set; }

            /// <summary>
            /// The status of the Frequency Control policy. Valid values:
            /// 
            /// *   **0**: disabled
            /// *   **1**: enabled
            /// </summary>
            [NameInMap("CcEnable")]
            [Validation(Required=false)]
            public int? CcEnable { get; set; }

            [NameInMap("CcGlobalSwitch")]
            [Validation(Required=false)]
            public string CcGlobalSwitch { get; set; }

            /// <summary>
            /// The mode of the Frequency Control policy. Valid values:
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
            /// The status of the Accurate Access Control policy. Valid values:
            /// 
            /// *   **0**: disabled
            /// *   **1**: enabled
            /// </summary>
            [NameInMap("PreciseRuleEnable")]
            [Validation(Required=false)]
            public int? PreciseRuleEnable { get; set; }

            /// <summary>
            /// The status of the Location Blacklist (Domain Names) policy. Valid values:
            /// 
            /// *   **0**: disabled
            /// *   **1**: enabled
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
