// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class UpdateApplicationCustomRulesRequest : TeaModel {
        /// <summary>
        /// <para>The list of custom application rules to be modified. You can specify up to 20 rules at a time. Rule IDs in the list must be unique.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<UpdateApplicationCustomRulesRequestRules> Rules { get; set; }
        public class UpdateApplicationCustomRulesRequestRules : TeaModel {
            /// <summary>
            /// <para>The list of application IDs to be associated. You can specify up to 200 IDs. The IDs cannot be 0 and must exist in the built-in application signature library. The IDs must not overlap with those in RemoveApplicationIds. The combined list of added and removed IDs cannot be empty and cannot exceed 200.</para>
            /// </summary>
            [NameInMap("AddApplicationIds")]
            [Validation(Required=false)]
            public List<long?> AddApplicationIds { get; set; }

            /// <summary>
            /// <para>The ID of the custom application rule to be modified. The rule must exist within the current Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acr-7d2e4f6a8b0c1d3e</para>
            /// </summary>
            [NameInMap("ApplicationCustomRuleId")]
            [Validation(Required=false)]
            public string ApplicationCustomRuleId { get; set; }

            /// <summary>
            /// <para>The name of the custom rule. The name can be up to 64 characters in length and can contain Chinese characters, English letters, digits, hyphens (-), underscores (_), and periods (.). If this parameter is not specified or is left empty, the original value is retained.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Custom rule 02</para>
            /// </summary>
            [NameInMap("ApplicationCustomRuleName")]
            [Validation(Required=false)]
            public string ApplicationCustomRuleName { get; set; }

            /// <summary>
            /// <para>The priority of the rule. This parameter is required in actual calls. Valid values: integers from 1 to 200. A smaller value indicates a higher priority. Priorities must be unique within the same template. You can swap priorities by deleting and then re-inserting rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public long? Priority { get; set; }

            /// <summary>
            /// <para>The list of application IDs to be disassociated. You can specify up to 200 IDs. The IDs must not overlap with those in AddApplicationIds. The combined list of added and removed IDs cannot be empty and cannot exceed 200.</para>
            /// </summary>
            [NameInMap("RemoveApplicationIds")]
            [Validation(Required=false)]
            public List<long?> RemoveApplicationIds { get; set; }

            /// <summary>
            /// <para>The action to perform after a rule is matched. This parameter is required in actual calls. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Allow</b>: Allows the traffic.</description></item>
            /// <item><description><b>Alert</b>: Monitors the traffic.</description></item>
            /// <item><description><b>Deny</b>: Blocks the traffic.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Alert</para>
            /// </summary>
            [NameInMap("RuleAction")]
            [Validation(Required=false)]
            public string RuleAction { get; set; }

        }

    }

}
