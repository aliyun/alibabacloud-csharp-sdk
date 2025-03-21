// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListCubeDataLevelPermissionConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D8749D65-E80A-433C-AF1B-CE9C180FF3B4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>{ &quot;isOpen&quot;: 1, &quot;extraConfigModel&quot;: { // Additional configuration information &quot;ruleType&quot;: &quot;ROW_LEVEL&quot;, // The row-level permission type. &quot;missHitPolicy&quot;: &quot;NONE&quot;, // The hit rule policy: NONE has no permissions, and ALL has permissions. &quot;cubeId&quot;: &quot;7c7223 ae-31d1-4d2f-b11f-3c744528014b&quot; // The ID of the dataset. }, &quot;ruleType&quot;: &quot;ROW_LEVEL&quot;, // Row-column permission type\
        /// &quot;ruleModels&quot;: [ { &quot;ruleUsersModel&quot;: { // The target population. &quot;userGroups&quot;: [ &quot;0d5fb19b- <b><b>-1248 fc27ca51&quot;, // The ID of the user group. &quot;4aa3f089-</b></b>-85f0-0e8ac7c2dee9&quot; ], &quot;users&quot;: [ &quot;HuangJia <em><b>2e3fa822&quot;, // The ID of the user. &quot;4334</b></em>84358&quot; ] }, &quot;ruleContentModel&quot;: { &quot;ruleContentType&quot;: &quot;ROW_FIELD&quot;, // The row-column permission type. &quot;ruleContentJson&quot;: &quot;{&quot;conditionNode&quot;:{&quot;caption&quot;: &quot; Period &quot;,&quot;isMeasure&quot;:false,&quot;pathId&quot;:&quot;7d3b073bc6&quot;,&quot;relationOperator&quot;:&quot;not-null&quot;,&quot;name&quot;:&quot;7d3b073bc6&quot;,&quot;value&quot;:{&quot;value&quot;:[&quot;&quot;}UM],&quot; ENueType &quot;} // The JSON string of the row-column permission rule. &quot;ruleOriginConfigJson&quot;: &quot;{&quot;operator&quot;:&quot;and&quot;,&quot;operands&quot;:[{&quot;labelName&quot;: &quot; Period &quot;,&quot;isValid&quot;:true,&quot;uniqueId&quot;:&quot;5&quot;,&quot;fieldId&quot;:&quot;7d3b073bc6&quot;,&quot;error&quot;:false,&quot;fieldType&quot;:&quot;string&quot;,&quot;: default &quot;&quot; value&quot;:{&quot;conditionOp&quot;:&quot;not-null&quot;,&quot;conditionValue&quot;:&quot;&quot;},&quot;valueType&quot;:&quot;ENUM&quot;}}],&quot;isRelation&quot;:true}&quot; }, // The fixed-format JSON string required by the frontend &quot;isOpen&quot;: 1, // The status of the row-column permission configuration. 1. On. 0. Off. &quot;hitTakeEffect&quot;: 1, // Specifies whether the rule takes effect after a column-level permission is hit. 1 takes effect and 0 takes effect. &quot;ruleName&quot;: &quot;Test row-level permission_Do not delete&quot;, // The name of the row-column permission rule. &quot;ruleLevelType&quot;: &quot;ROW_LEVEL&quot;, // The row-column permission type. &quot;ruleId&quot;: &quot;a5bb24 da-772f-45e8-a43c-a891683e14da&quot;, // The ID of the row-column permission rule. &quot;cubeId&quot;: &quot;7c7223 ae-31d1-4d2f-b11f-3c744528014b&quot;, // The ID of the dataset. &quot;ruleTargetScope&quot;: &quot;OTHERS&quot; rule takes effect: ALL owner and OTHERS designated owner. } ], &quot;cubeId&quot;: &quot;7c7223 ae-31d1-4d2f-b11f-3c744528014b&quot; // The ID of the dataset. }</para>
        /// 
        /// <b>Example:</b>
        /// <para>The JSON string of the row-column permission list. For more information, see the description.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public string Result { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
