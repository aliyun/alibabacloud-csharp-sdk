// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetRulesCountResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of system defense rules.
        /// </summary>
        [NameInMap("TotalSystemClientRuleCount")]
        [Validation(Required=false)]
        public long? TotalSystemClientRuleCount { get; set; }

        /// <summary>
        /// The total number of custom defense rules.
        /// </summary>
        [NameInMap("TotalUserDefineRuleCount")]
        [Validation(Required=false)]
        public long? TotalUserDefineRuleCount { get; set; }

    }

}
