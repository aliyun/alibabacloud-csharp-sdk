// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class AddDesensitizationRuleRequest : TeaModel {
        [NameInMap("FunctionParams")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> FunctionParams { get; set; }

        /// <summary>
        /// The name of the rule.
        /// </summary>
        [NameInMap("FunctionType")]
        [Validation(Required=false)]
        public string FunctionType { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// 
        /// >  To view the ID of the tenant, go to the Data Management (DMS) console and move the pointer over the profile picture in the upper-right corner. For more information, see [View information about the current tenant](~~181330~~).
        /// </summary>
        [NameInMap("RuleDescription")]
        [Validation(Required=false)]
        public string RuleDescription { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **AddDesensitizationRule**.
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

        /// <summary>
        /// The ID generated for the masking rule.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
