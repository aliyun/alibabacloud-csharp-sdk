// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class ModifyScalingRuleRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TIME_TRIGGER</para>
        /// </summary>
        [NameInMap("NewTriggerType")]
        [Validation(Required=false)]
        public string NewTriggerType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ng-3d5ce6454354****</para>
        /// </summary>
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TIME_TRIGGER</para>
        /// </summary>
        [NameInMap("OldTriggerType")]
        [Validation(Required=false)]
        public string OldTriggerType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;nodeNumber&quot;: 1,
        ///   &quot;scalingRuleName&quot;: &quot;test1&quot;,
        ///   &quot;scalingOutRule&quot;: {
        ///     &quot;year&quot;: 2026,
        ///     &quot;month&quot;: 3,
        ///     &quot;day&quot;: 2,
        ///     &quot;hour&quot;: 5,
        ///     &quot;minute&quot;: 50,
        ///     &quot;second&quot;: 0,
        ///     &quot;recurrenceInterval&quot;: 1,
        ///     &quot;recurrenceType&quot;: &quot;DAILY&quot;,
        ///     &quot;recurrenceValues&quot;: null
        ///   },
        ///   &quot;scalingInRule&quot;: {
        ///     &quot;year&quot;: 2026,
        ///     &quot;month&quot;: 3,
        ///     &quot;day&quot;: 2,
        ///     &quot;hour&quot;: 6,
        ///     &quot;minute&quot;: 50,
        ///     &quot;second&quot;: 0,
        ///     &quot;recurrenceInterval&quot;: 1,
        ///     &quot;recurrenceType&quot;: &quot;DAILY&quot;,
        ///     &quot;recurrenceValues&quot;: null
        ///   }
        /// }</para>
        /// </summary>
        [NameInMap("Rule")]
        [Validation(Required=false)]
        public string Rule { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asr-bp10s4t9l21u9qtyrtco</para>
        /// </summary>
        [NameInMap("ScalingRuleId")]
        [Validation(Required=false)]
        public string ScalingRuleId { get; set; }

    }

}
