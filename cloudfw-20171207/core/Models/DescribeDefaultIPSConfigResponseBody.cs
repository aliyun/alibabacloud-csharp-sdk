// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeDefaultIPSConfigResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether basic protection is enabled. Valid values:
        /// 
        /// *   **1**: yes
        /// *   **0**: no
        /// </summary>
        [NameInMap("BasicRules")]
        [Validation(Required=false)]
        public int? BasicRules { get; set; }

        /// <summary>
        /// Indicates whether threat intelligence is enabled. Valid values:
        /// 
        /// *   **1**: yes
        /// *   **0**: no
        /// </summary>
        [NameInMap("CtiRules")]
        [Validation(Required=false)]
        public int? CtiRules { get; set; }

        /// <summary>
        /// Indicates whether virtual patching is enabled. Valid values:
        /// 
        /// *   **1**: yes
        /// *   **0**: no
        /// </summary>
        [NameInMap("PatchRules")]
        [Validation(Required=false)]
        public int? PatchRules { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The level of the rule group for the IPS. Valid values:
        /// 
        /// *   **1**: loose
        /// *   **2**: medium
        /// *   **3**: strict
        /// </summary>
        [NameInMap("RuleClass")]
        [Validation(Required=false)]
        public int? RuleClass { get; set; }

        /// <summary>
        /// The mode of the IPS. Valid values:
        /// 
        /// *   **1**: block mode
        /// *   **0**: monitor mode
        /// </summary>
        [NameInMap("RunMode")]
        [Validation(Required=false)]
        public int? RunMode { get; set; }

    }

}
