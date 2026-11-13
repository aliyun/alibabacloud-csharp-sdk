// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateApplicationCustomRulesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application template to which the custom rules belong. The template must exist within the current Alibaba Cloud account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ati-4f0691c56b8d4f06</para>
        /// </summary>
        [NameInMap("ApplicationTemplateId")]
        [Validation(Required=false)]
        public string ApplicationTemplateId { get; set; }

        /// <summary>
        /// <para>The list of custom rules for the application. You can pass up to 100 rules at a time, and the total number of rules in the template after creation cannot exceed 100.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<CreateApplicationCustomRulesRequestRules> Rules { get; set; }
        public class CreateApplicationCustomRulesRequestRules : TeaModel {
            /// <summary>
            /// <para>The name of the custom rule. It cannot be empty and can be up to 64 characters in length. It supports Chinese characters, English letters, digits, hyphens (-), underscores (_), and half-width periods (.).</para>
            /// 
            /// <b>Example:</b>
            /// <para>CustomRule01</para>
            /// </summary>
            [NameInMap("ApplicationCustomRuleName")]
            [Validation(Required=false)]
            public string ApplicationCustomRuleName { get; set; }

            /// <summary>
            /// <para>The list of application IDs associated with the rule. A single rule can be associated with 1 to 200 applications. The IDs cannot be 0, must be unique, and must exist in the built-in application signature library. You can call the ListApplications operation to query the IDs.</para>
            /// </summary>
            [NameInMap("ApplicationIds")]
            [Validation(Required=false)]
            public List<long?> ApplicationIds { get; set; }

            /// <summary>
            /// <para>The priority of the rule. Valid values: integers from 1 to 200. A smaller value indicates a higher priority. Priorities must be unique within the same batch and the same template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public long? Priority { get; set; }

            /// <summary>
            /// <para>The action to perform when the rule is triggered. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Allow</b>: allows the traffic.</description></item>
            /// <item><description><b>Alert</b>: monitors the traffic.</description></item>
            /// <item><description><b>Deny</b>: blocks the traffic.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Deny</para>
            /// </summary>
            [NameInMap("RuleAction")]
            [Validation(Required=false)]
            public string RuleAction { get; set; }

        }

    }

}
