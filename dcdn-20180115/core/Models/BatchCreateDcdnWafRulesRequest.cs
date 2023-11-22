// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class BatchCreateDcdnWafRulesRequest : TeaModel {
        /// <summary>
        /// The ID of the protection policy.
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public long? PolicyId { get; set; }

        /// <summary>
        /// The configuration of the protection rule.
        /// </summary>
        [NameInMap("RuleConfigs")]
        [Validation(Required=false)]
        public string RuleConfigs { get; set; }

    }

}
