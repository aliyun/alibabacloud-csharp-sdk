// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallDefaultIPSConfigResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether basic policies are enabled. Valid values:
        /// 
        /// *   **1**: yes
        /// *   **0**: no
        /// </summary>
        [NameInMap("BasicRules")]
        [Validation(Required=false)]
        public int? BasicRules { get; set; }

        /// <summary>
        /// Indicates whether virtual patching is enabled. Valid values:
        /// 
        /// *   **1**: yes
        /// *   **0**: no
        /// </summary>
        [NameInMap("EnableAllPatch")]
        [Validation(Required=false)]
        public int? EnableAllPatch { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RuleClass")]
        [Validation(Required=false)]
        public int? RuleClass { get; set; }

        /// <summary>
        /// The mode of the intrusion prevention system (IPS). Valid values:
        /// 
        /// *   **1**: block mode
        /// *   **0**: monitor mode
        /// </summary>
        [NameInMap("RunMode")]
        [Validation(Required=false)]
        public int? RunMode { get; set; }

    }

}
