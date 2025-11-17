// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class SetDataLevelPermissionRuleConfigRequest : TeaModel {
        /// <summary>
        /// <para>{
        ///     &quot;rule&quot;: &quot;a5bb24da-<b><b>-a891683e14da&quot;,   // ID of the row and column permission rule; when provided, it modifies the row-level permission rule, otherwise, it adds a new one
        ///     &quot;cubeId&quot;: &quot;7c7223ae-</b></b>-3c744528014b&quot;,  // Dataset ID
        ///     &quot;ruleName&quot;: &quot;Test Row-Level Permission&quot;, // Name of the row-level permission rule
        ///     &quot;ruleLevelType&quot;: &quot;ROW_LEVEL&quot;, // Type of row-level permission: ROW_LEVEL: Row-level permission, COLUMN_LEVEL: Column-level permission
        ///     &quot;ruleTargetScope&quot;: &quot;ALL&quot;, // Target audience for the row-level permission rule: 1: Everyone, 2: Specific people
        ///     &quot;hitTakeEffect&quot;: 1, // Whether the rule takes effect after being hit (for column-level permissions): 1: Takes effect (default), 0: Does not take effect
        ///     &quot;ruleUsersModel&quot;: {
        ///         &quot;userGroups&quot;: [
        ///             &quot;9bd2c6440ac542<b><b>589f16bf12ca8178dd&quot;, // User group IDs for the target user groups
        ///             &quot;0d5fb19b-</b></b>-1248fc27ca51&quot;,
        ///             &quot;3d2c23d4-<b><b>-f6390f325c2d&quot;
        ///         ],
        ///         &quot;users&quot;: [
        ///             &quot;43342</b></b>3784358&quot;, // User IDs for the target users
        ///             &quot;Huang<em><em><b>2e3fa822&quot;
        ///         ]
        ///     },
        ///     &quot;ruleContentModel&quot;: {
        ///         &quot;ruleContentType&quot;: &quot;ROW_FIELD&quot;, // Type of the row and column permission rule
        ///         &quot;ruleContentJson&quot;: &quot;{\&quot;conditionNode\&quot;:{\&quot;caption\&quot;:\&quot;Period\&quot;,\&quot;isMeasure\&quot;:false,\&quot;pathId\&quot;:\&quot;7d3b</b></em>bc6\&quot;,\&quot;relationOperator\&quot;:\&quot;not-null\&quot;,\&quot;name\&quot;:\&quot;7d3b</em><b>bc6\&quot;,\&quot;value\&quot;:{\&quot;value\&quot;:[\&quot;\&quot;],\&quot;valueType\&quot;:\&quot;ENUM\&quot;}}}&quot;, // JSON string of the rule
        ///         &quot;ruleOriginConfigJson&quot;: &quot;{\&quot;operator\&quot;:\&quot;and\&quot;,\&quot;operands\&quot;:[{\&quot;labelName\&quot;:\&quot;Period\&quot;,\&quot;isValid\&quot;:true,\&quot;uniqueId\&quot;:\&quot;5\&quot;,\&quot;fieldId\&quot;:\&quot;7d3b</b>*bc6\&quot;,\&quot;error\&quot;:false,\&quot;fieldType\&quot;:\&quot;string\&quot;,\&quot;defaultValue\&quot;:{\&quot;selectType\&quot;:\&quot;condition\&quot;,\&quot;value\&quot;:{\&quot;conditionOp\&quot;:\&quot;not-null\&quot;,\&quot;conditionValue\&quot;:\&quot;\&quot;},\&quot;valueType\&quot;:\&quot;ENUM\&quot;}}],\&quot;isRelation\&quot;:true}&quot; // JSON result used by the frontend template (specific to row-level permissions)
        ///     }
        /// }</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;cubeId&quot;: &quot;aa574353-41cf-<b><b>-8d0d-455176c101fa&quot;,
        ///     &quot;hitTakeEffect&quot;: 1,
        ///     &quot;isOpen&quot;: 1,
        ///     &quot;permissionMode&quot;: &quot;COMPLEX&quot;,
        ///     &quot;ruleContentModel&quot;: {
        ///         &quot;ruleContent&quot;: {
        ///             &quot;pathId&quot;: [
        ///                 &quot;264b7a970b&quot;
        ///             ]
        ///         },
        ///         &quot;ruleContentJson&quot;: &quot;{\&quot;pathId\&quot;:[\&quot;264b7a970b\&quot;]}&quot;,
        ///         &quot;ruleContentType&quot;: &quot;COLUMN_FORBID&quot;
        ///     },
        ///     &quot;ruleId&quot;: &quot;3971fa8e-f7e0-</b></b>-b6e3-5b3167dd7247&quot;,
        ///     &quot;ruleLevelType&quot;: &quot;COLUMN_LEVEL&quot;,
        ///     &quot;ruleName&quot;: &quot;test&quot;,
        ///     &quot;ruleTargetScope&quot;: &quot;ALL&quot;
        /// }</para>
        /// </summary>
        [NameInMap("RuleModel")]
        [Validation(Required=false)]
        public string RuleModel { get; set; }

    }

}
