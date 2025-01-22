// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateDIAlarmRuleShrinkRequest : TeaModel {
        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>This parameter is deprecated. Use the Id parameter instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34982</para>
        /// </summary>
        [NameInMap("DIAlarmRuleId")]
        [Validation(Required=false)]
        [Obsolete]
        public long? DIAlarmRuleId { get; set; }

        /// <summary>
        /// <para>The ID of the synchronization task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DIJobId")]
        [Validation(Required=false)]
        public long? DIJobId { get; set; }

        /// <summary>
        /// <para>The description of the alert rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The description of the alert rule.</para>
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
        /// <para>The alert rule Id</para>
        /// 
        /// <b>Example:</b>
        /// <para>34982</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The metric type in the alert rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Heartbeat</description></item>
        /// <item><description>FailoverCount</description></item>
        /// <item><description>Delay</description></item>
        /// <item><description>DdlReport</description></item>
        /// <item><description>ResourceUtilization</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Heartbeat</para>
        /// </summary>
        [NameInMap("MetricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        /// <summary>
        /// <para>The name of the alert rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alarm_rule_name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The alert notification settings.</para>
        /// </summary>
        [NameInMap("NotificationSettings")]
        [Validation(Required=false)]
        public string NotificationSettingsShrink { get; set; }

        /// <summary>
        /// <para>The conditions that can trigger the alert rule.</para>
        /// </summary>
        [NameInMap("TriggerConditions")]
        [Validation(Required=false)]
        public string TriggerConditionsShrink { get; set; }

    }

}
