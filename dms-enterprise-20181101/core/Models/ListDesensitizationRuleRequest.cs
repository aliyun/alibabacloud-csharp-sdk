// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListDesensitizationRuleRequest : TeaModel {
        /// <summary>
        /// The description of the rule.
        /// </summary>
        [NameInMap("FuncType")]
        [Validation(Required=false)]
        public string FuncType { get; set; }

        /// <summary>
        /// The name of the masking rule.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The ID of the masking rule.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the masking rule.
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public int? RuleId { get; set; }

        /// <summary>
        /// The example.
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

        /// <summary>
        /// The name of the masking rule.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
