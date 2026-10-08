// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateApplicationScalingRuleRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application. Call the <a href="https://help.aliyun.com/document_detail/149390.html">ListApplication</a> operation to obtain this ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>78194c76-3dca-418e-a263-cccd1ab4****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The configuration of custom scaling behaviors. For more information about the data structure, see the example.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;scaleUp&quot;:{&quot;stabilizationWindowSeconds&quot;:&quot;0&quot;,&quot;selectPolicy&quot;:&quot;Max&quot;,&quot;policies&quot;:[{&quot;type&quot;:&quot;Pods&quot;,&quot;value&quot;:5,&quot;periodSeconds&quot;:15}]},&quot;scaleDown&quot;:{&quot;stabilizationWindowSeconds&quot;:&quot;300&quot;,&quot;selectPolicy&quot;:&quot;Max&quot;,&quot;policies&quot;:[{&quot;type&quot;:&quot;Percent&quot;,&quot;value&quot;:200,&quot;periodSeconds&quot;:15}]}}</para>
        /// </summary>
        [NameInMap("ScalingBehaviour")]
        [Validation(Required=false)]
        public string ScalingBehaviour { get; set; }

        /// <summary>
        /// <para>The status of the Auto Scaling policy.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enabled</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disabled</para>
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
        /// <para>The name of the Auto Scaling policy.</para>
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
        /// <para>The trigger policy, which is a JSON string of a ScalingRuleTriggerDTO object. For more information about the format, see the Additional information about request parameters section.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ScalingRuleTriggerDTO{......}</para>
        /// </summary>
        [NameInMap("ScalingRuleTrigger")]
        [Validation(Required=false)]
        public string ScalingRuleTrigger { get; set; }

        /// <summary>
        /// <para>The type of the Auto Scaling policy. Only the following type is supported:</para>
        /// <list type="bullet">
        /// <item><description>trigger: a trigger-based policy.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>trigger</para>
        /// </summary>
        [NameInMap("ScalingRuleType")]
        [Validation(Required=false)]
        public string ScalingRuleType { get; set; }

    }

}
