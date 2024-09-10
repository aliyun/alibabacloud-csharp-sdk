// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateOrUpdateAutoTagRuleRequest : TeaModel {
        /// <summary>
        /// Specifies whether to check the rule on the backend. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("CheckAll")]
        [Validation(Required=false)]
        public bool? CheckAll { get; set; }

        /// <summary>
        /// The expression of the rule.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Expression")]
        [Validation(Required=false)]
        public string Expression { get; set; }

        /// <summary>
        /// The description of the rule.
        /// </summary>
        [NameInMap("RuleDesc")]
        [Validation(Required=false)]
        public string RuleDesc { get; set; }

        /// <summary>
        /// The ID of the rule.
        /// 
        /// >  You can call the [ListAutoTagRules](~~ListAutoTagRules~~) operation to query the ID.
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        /// <summary>
        /// The name of the rule.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// The tag specified by the operation type of the rule.
        /// 
        /// *   If TagType is set to group, set this parameter to {"groupId":XXX}. XXX specifies the ID of the group. You can call the [DescribeGroupStruct](~~DescribeGroupStruct~~) operation to query the ID.
        /// *   If TagType is set to tag, set this parameter to {"tagId":XXX}. XXX specifies the ID of the tag. You can call the [DescribeGroupedTags](~~DescribeGroupedTags~~) operation to query the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TagContext")]
        [Validation(Required=false)]
        public string TagContext { get; set; }

        /// <summary>
        /// The operation type of the rule. Valid values:
        /// 
        /// *   **group**
        /// *   **tag**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TagType")]
        [Validation(Required=false)]
        public string TagType { get; set; }

    }

}
