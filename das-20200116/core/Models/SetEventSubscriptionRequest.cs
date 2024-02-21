// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class SetEventSubscriptionRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable the event subscription feature. Valid values:
        /// 
        /// *   **0**: disables the event subscription feature.
        /// *   **1**: enables the event subscription feature.
        /// </summary>
        [NameInMap("Active")]
        [Validation(Required=false)]
        public string Active { get; set; }

        /// <summary>
        /// The notification method. Valid values:
        /// 
        /// *   **hdm_alarm_sms**: text message.
        /// *   **dingtalk**: DingTalk chatbot.
        /// *   **hdm_alarm_sms_and_email**: text message and email.
        /// *   **hdm_alarm_sms,dingtalk**: text message and DingTalk chatbot.
        /// </summary>
        [NameInMap("ChannelType")]
        [Validation(Required=false)]
        public string ChannelType { get; set; }

        /// <summary>
        /// The name of the contact group that receives alert notifications. Separate multiple names with commas (,).
        /// </summary>
        [NameInMap("ContactGroupName")]
        [Validation(Required=false)]
        public string ContactGroupName { get; set; }

        /// <summary>
        /// The name of the contact who receives alert notifications. Separate multiple names with commas (,).
        /// </summary>
        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        /// <summary>
        /// The notification rules based on the event type. If you leave this parameter empty, the values of **MinInterval** and **ChannelType** prevail.
        /// 
        /// Specify this parameter in the following format: `{"silenced": {"Event type 1":Specifies whether to enable adaptive silence, "Event type 2":Specify whether to enable adaptive silence},"min_interval": {"Event type 1":Minimum interval between event notifications, "Event type 2":Minimum interval between event notifications},"alert_type": {"Event type 1":"Notification method", "Event type 2":"Notification method"}}`.
        /// 
        /// *   **silenced**: specifies whether to enable adaptive silence. After you enable adaptive silence, the interval between consecutive alert notifications for an event is the greater one of the minimum interval specified by **min_interval** and one third of the event duration. Valid values:
        /// 
        ///     *   1: enables adaptive silence.
        ///     *   2: disables adaptive silence.
        /// 
        /// *   **min_interval**: the minimum interval between event notifications. Unit: seconds.
        /// 
        /// *   **alert_type**: the notification method. Valid values:
        /// 
        ///     *   **hdm_alarm_sms**: text message.
        ///     *   **dingtalk**: DingTalk chatbot.
        ///     *   **hdm_alarm_sms_and_email**: text message and email.
        ///     *   **hdm_alarm_sms,dingtalk**: text message and DingTalk chatbot.
        /// </summary>
        [NameInMap("DispatchRule")]
        [Validation(Required=false)]
        public string DispatchRule { get; set; }

        /// <summary>
        /// The supported event scenarios. You can set the value to **AllContext**, which indicates that all scenarios are supported.
        /// </summary>
        [NameInMap("EventContext")]
        [Validation(Required=false)]
        public string EventContext { get; set; }

        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The language of event notifications. You can set the value to **zh-CN**, which indicates that event notifications are sent in Chinese.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The risk level of the events. Valid values:
        /// 
        /// *   **Notice**: events that trigger notifications, including events at the **Notice**, **Optimization**, **Warn**, and **Critical** levels.
        /// *   **Optimization**: events that trigger optimizations, including events at the **Optimization**, **Warn**, and **Critical** levels.
        /// *   **Warn**: events that trigger warnings, including events at the **Warn** and **Critical** levels.
        /// *   **Critical**: events that trigger critical warnings.****
        /// 
        /// The following content describes the events at each level in detail:
        /// 
        /// *   Notice: events that are related to database exceptions for which no suggestions are generated.
        /// *   Optimization: events for which optimization suggestions are generated based on the status of the database.
        /// *   Warn: events that may affect the running of the database.
        /// *   Critical: events that affect the running of the database.
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// The minimum interval between consecutive event notifications. Unit: seconds.
        /// </summary>
        [NameInMap("MinInterval")]
        [Validation(Required=false)]
        public string MinInterval { get; set; }

        /// <summary>
        /// The alert severity based on the event type.
        /// 
        /// Specify this parameter in the following format: `{"Event type 1":"Alert severity", "Event type 2":"Alert severity"}`.
        /// 
        /// Valid values of event types:
        /// 
        /// *   **AutoScale**: auto scaling event.
        /// *   **SQLThrottle**: throttling event.
        /// *   **TimeSeriesAbnormal**: event for detecting time series anomalies.
        /// *   **SQLOptimize**: SQL optimization event.
        /// *   **ResourceOptimize**: storage optimization event.
        /// 
        /// Valid values of alert severities:
        /// 
        /// *   **info**
        /// *   **noticed**
        /// *   **warning**
        /// *   **critical**
        /// </summary>
        [NameInMap("Severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

    }

}
