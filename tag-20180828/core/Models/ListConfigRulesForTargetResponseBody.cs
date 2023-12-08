// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class ListConfigRulesForTargetResponseBody : TeaModel {
        /// <summary>
        /// The tag detection tasks.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListConfigRulesForTargetResponseBodyData> Data { get; set; }
        public class ListConfigRulesForTargetResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the account group.
            /// 
            /// You can use the ID to query the content of the related resource non-compliance report in Cloud Config.
            /// 
            /// >  This parameter is returned only if you use the Tag Policy feature in multi-account mode.
            /// </summary>
            [NameInMap("AggregatorId")]
            [Validation(Required=false)]
            public string AggregatorId { get; set; }

            /// <summary>
            /// The ID of the rule.
            /// </summary>
            [NameInMap("ConfigRuleId")]
            [Validation(Required=false)]
            public string ConfigRuleId { get; set; }

            /// <summary>
            /// The use scenario of the tag policy. Valid values:
            /// 
            /// *   tags: enables tags with specified tag values to be added to resources.
            /// *   rg_inherit: enables resources in a resource group to automatically inherit tags from the resource group.
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

            /// <summary>
            /// Indicates whether automatic remediation is enabled. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("Remediation")]
            [Validation(Required=false)]
            public bool? Remediation { get; set; }

            /// <summary>
            /// The tag key.
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// The tag value for automatic remediation.
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

            /// <summary>
            /// The ID of the object.
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            /// <summary>
            /// The type of the object. Valid values:
            /// 
            /// *   USER: the current logon account. This value is available if you use the Tag Policy feature in single-account mode.
            /// *   ROOT: the Root folder in the resource directory. This value is available if you use the Tag Policy feature in multi-account mode.
            /// *   FOLDER: a folder other than the Root folder in the resource directory. This value is available if you use the Tag Policy feature in multi-account mode.
            /// *   ACCOUNT: a member in the resource directory. This value is available if you use the Tag Policy feature in multi-account mode.
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

        }

        /// <summary>
        /// Indicates whether the next query is required.
        /// 
        /// *   If the value of this parameter is empty (`"NextToken": ""`), all results are returned, and the next query is not required.
        /// *   If the value of this parameter is not empty, the next query is required, and the value is the token used to start the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
