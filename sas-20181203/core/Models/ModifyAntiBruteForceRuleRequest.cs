// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyAntiBruteForceRuleRequest : TeaModel {
        /// <summary>
        /// Specifies whether to set the defense rule as the default rule. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// </summary>
        [NameInMap("DefaultRule")]
        [Validation(Required=false)]
        public bool? DefaultRule { get; set; }

        /// <summary>
        /// The threshold of logon failures that you specify. Valid values:
        /// 
        /// *   **2**
        /// *   **3**
        /// *   **4**
        /// *   **5**
        /// *   **10**
        /// *   **50**
        /// *   **80**
        /// *   **100**
        /// </summary>
        [NameInMap("FailCount")]
        [Validation(Required=false)]
        public int? FailCount { get; set; }

        /// <summary>
        /// The period of time during which logons from an account are not allowed. Unit: minutes. Valid values:
        /// 
        /// *   **5**
        /// *   **15**
        /// *   **30**
        /// *   **60**
        /// *   **120**
        /// *   **360**
        /// *   **720**
        /// *   **1440**
        /// *   **10080**
        /// *   **52560000**: permanent
        /// </summary>
        [NameInMap("ForbiddenTime")]
        [Validation(Required=false)]
        public int? ForbiddenTime { get; set; }

        /// <summary>
        /// The ID of the defense rule.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The name of the defense rule.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The period of time during which logon failures from an account are measured. Unit: minutes. Valid values:
        /// 
        /// *   **1**
        /// *   **2**
        /// *   **5**
        /// *   **10**
        /// *   **15**
        /// </summary>
        [NameInMap("Span")]
        [Validation(Required=false)]
        public int? Span { get; set; }

        /// <summary>
        /// An array consisting of the UUIDs of the servers to which the defense rule is applied.
        /// </summary>
        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public List<string> UuidList { get; set; }

    }

}
