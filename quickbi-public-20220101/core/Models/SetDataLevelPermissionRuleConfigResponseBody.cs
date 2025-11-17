// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class SetDataLevelPermissionRuleConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D8749D65-E80A-433C-AF1B-CE9C180FF3B4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Successfully saved row and column permission information.</para>
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
        [NameInMap("Result")]
        [Validation(Required=false)]
        public string Result { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. The value range is as follows:</para>
        /// <list type="bullet">
        /// <item><description>true: The request succeeded</description></item>
        /// <item><description>false: The request failed</description></item>
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
