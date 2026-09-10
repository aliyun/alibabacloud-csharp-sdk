// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class SubscriptionAndNotifyStrategyForModify : TeaModel {
        /// <summary>
        /// <para>The description of the alert policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Used to monitor the CPU utilization of ECS instances</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Read-only. This parameter does not take effect even if specified. The backend forcibly sets this parameter to true during creation and retains the current value during updates. To enable or disable the policy, call the EnableAlertPolicy or DisableAlertPolicy operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>Policy Name of the alert policy. If this parameter is not specified, the backend derives Policy Name from notifyStrategy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-alert-policy</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The notification configuration that defines noise reduction rules, notification channel routing, and templates. This parameter is required for Create operations.</para>
        /// </summary>
        [NameInMap("notifyStrategy")]
        [Validation(Required=false)]
        public NotifyStrategyForSNSModify NotifyStrategy { get; set; }

        /// <summary>
        /// <para>The event management configuration that defines recovery notifications, repeat notifications, automatic recovery, and escalation policies.</para>
        /// </summary>
        [NameInMap("responsePlan")]
        [Validation(Required=false)]
        public IncidentResponsePlanForSNSModify ResponsePlan { get; set; }

        /// <summary>
        /// <para>The single primary subscription configuration that defines event filter conditions. This parameter is mutually exclusive with subscriptions. Do not specify both parameters at the same time.</para>
        /// </summary>
        [NameInMap("subscription")]
        [Validation(Required=false)]
        public SubscriptionForSNSModify Subscription { get; set; }

        /// <summary>
        /// <para>Dedicated to Update operations. Performs batch create, update, or remove adjustments on member subscriptions.</para>
        /// </summary>
        [NameInMap("subscriptions")]
        [Validation(Required=false)]
        public List<SubscriptionOp> Subscriptions { get; set; }

        /// <summary>
        /// <para>The unique identifier of the alert policy. This parameter is required for Update operations. Do not specify this parameter for Create operations because the backend automatically generates the value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7076c75c-c804-461e-975f-c6f9ed5af745</para>
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// <para>The optimistic lock version number. This parameter is required for Update operations and must match the current value on the backend. Otherwise, a 409 VersionConflict error is returned. The version number increments by 1 after each successful update.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public int? Version { get; set; }

    }

}
