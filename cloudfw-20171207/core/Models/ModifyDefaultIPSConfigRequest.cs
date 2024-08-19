// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyDefaultIPSConfigRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable basic protection. Valid values:
        /// 
        /// *   **1**: yes
        /// *   **0**: no
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BasicRules")]
        [Validation(Required=false)]
        public string BasicRules { get; set; }

        /// <summary>
        /// Specifies whether to enable threat intelligence. Valid values:
        /// 
        /// *   **1**: yes
        /// *   **0**: no
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CtiRules")]
        [Validation(Required=false)]
        public string CtiRules { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Valid values:
        /// 
        /// *   **zh** (default)
        /// *   **en**
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// Specifies whether to enable virtual patching. Valid values:
        /// 
        /// *   **1**: yes
        /// *   **0**: no
        /// </summary>
        [NameInMap("PatchRules")]
        [Validation(Required=false)]
        public string PatchRules { get; set; }

        /// <summary>
        /// The level of the rule group for the IPS. Valid values:
        /// 
        /// *   **1**: loose
        /// *   **2**: medium
        /// *   **3**: strict
        /// </summary>
        [NameInMap("RuleClass")]
        [Validation(Required=false)]
        public string RuleClass { get; set; }

        /// <summary>
        /// The mode of the IPS. Valid values:
        /// 
        /// *   **1**: block mode
        /// *   **0**: monitor mode
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RunMode")]
        [Validation(Required=false)]
        public string RunMode { get; set; }

    }

}
