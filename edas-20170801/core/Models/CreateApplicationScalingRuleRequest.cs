// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class CreateApplicationScalingRuleRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. To get this ID, call the <a href="https://help.aliyun.com/document_detail/149390.html">ListApplication</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>78194c76-3dca-418e-a263-cccd1ab4****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The configuration for custom scaling behaviors. For more information about the data structure, see the example.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;scaleUp&quot;: {
        ///             &quot;stabilizationWindowSeconds&quot;: &quot;0&quot;,
        ///             &quot;selectPolicy&quot;: &quot;Max&quot;,
        ///             &quot;policies&quot;: [
        ///                   {
        ///                         &quot;type&quot;: &quot;Pods&quot;,
        ///                         &quot;value&quot;: 5,
        ///                         &quot;periodSeconds&quot;: 15
        ///                   }
        ///             ]
        ///       },
        ///       &quot;scaleDown&quot;: {
        ///             &quot;stabilizationWindowSeconds&quot;: &quot;300&quot;,
        ///             &quot;selectPolicy&quot;: &quot;Max&quot;,
        ///             &quot;policies&quot;: [
        ///                   {
        ///                         &quot;type&quot;: &quot;Percent&quot;,
        ///                         &quot;value&quot;: 200,
        ///                         &quot;periodSeconds&quot;: 15
        ///                   }
        ///             ]
        ///       }
        /// }</para>
        /// </summary>
        [NameInMap("ScalingBehaviour")]
        [Validation(Required=false)]
        public string ScalingBehaviour { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the Auto Scaling rule.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enables the rule.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disables the rule.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ScalingRuleEnable")]
        [Validation(Required=false)]
        public bool? ScalingRuleEnable { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScalingRuleMetric")]
        [Validation(Required=false)]
        public string ScalingRuleMetric { get; set; }

        /// <summary>
        /// <para>The name of the Auto Scaling rule. The name must start with a lowercase letter. It can contain lowercase letters, digits, and hyphens (-). The name must be 1 to 32 characters long.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpu-trigger</para>
        /// </summary>
        [NameInMap("ScalingRuleName")]
        [Validation(Required=false)]
        public string ScalingRuleName { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScalingRuleTimer")]
        [Validation(Required=false)]
        public string ScalingRuleTimer { get; set; }

        /// <summary>
        /// <para>The trigger policy. Set this parameter to a JSON string of the ScalingRuleTriggerDTO object. For more information about the format, see Additional information about request parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ScalingRuleTriggerDTO{......}</para>
        /// </summary>
        [NameInMap("ScalingRuleTrigger")]
        [Validation(Required=false)]
        public string ScalingRuleTrigger { get; set; }

        /// <summary>
        /// <para>The type of the Auto Scaling rule. Only the <b>trigger</b> type is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>trigger</para>
        /// </summary>
        [NameInMap("ScalingRuleType")]
        [Validation(Required=false)]
        public string ScalingRuleType { get; set; }

    }

}
