// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateDIAlarmRuleShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The alert rule ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34982</para>
        /// </summary>
        [NameInMap("DIAlarmRuleId")]
        [Validation(Required=false)]
        public long? DIAlarmRuleId { get; set; }

        /// <summary>
        /// <para>The description of the alert rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysql synchronizes to hologres heartbeat alert</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the alert rule. By default, the alert rule is disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The metric type in the alert rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Heartbeat</description></item>
        /// <item><description>FailoverCount</description></item>
        /// <item><description>Delay</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Heartbeat</para>
        /// </summary>
        [NameInMap("MetricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        /// <summary>
        /// <para>The alert notification settings.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NotificationSettings")]
        [Validation(Required=false)]
        public string NotificationSettingsShrink { get; set; }

        /// <summary>
        /// <para>The conditions that are used to trigger the alert rule.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TriggerConditions")]
        [Validation(Required=false)]
        public string TriggerConditionsShrink { get; set; }

    }

}
