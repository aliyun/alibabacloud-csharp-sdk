// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyAntiBruteForceRuleRequest : TeaModel {
        [NameInMap("DefaultRule")]
        [Validation(Required=false)]
        public bool? DefaultRule { get; set; }

        [NameInMap("FailCount")]
        [Validation(Required=false)]
        public int? FailCount { get; set; }

        [NameInMap("ForbiddenTime")]
        [Validation(Required=false)]
        public int? ForbiddenTime { get; set; }

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
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Modifies a defense rule against brute-force attacks.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// ModifyAntiBruteForceRule
        /// </summary>
        [NameInMap("Span")]
        [Validation(Required=false)]
        public int? Span { get; set; }

        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public List<string> UuidList { get; set; }

    }

}
