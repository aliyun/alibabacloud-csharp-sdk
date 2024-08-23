// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateOrUpdateNotificationPolicyRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable simple mode.
        /// </summary>
        [NameInMap("DirectedMode")]
        [Validation(Required=false)]
        public bool? DirectedMode { get; set; }

        /// <summary>
        /// The ID of the escalation policy.
        /// </summary>
        [NameInMap("EscalationPolicyId")]
        [Validation(Required=false)]
        public long? EscalationPolicyId { get; set; }

        /// <summary>
        /// An array of alert event group objects.
        /// 
        /// *   If you do not specify the groupingFields field, all alerts will be sent to contacts based on `alertname`.
        /// *   If you specify the groupingFields field, alerts with the same field will be sent to contacts in one notification.
        /// 
        /// Sample statement:
        /// 
        ///     { 
        ///     "groupWait":5,    // The waiting time for grouping. 
        ///     "groupInterval":30,     // The time interval of grouping. 
        ///     "groupingFields":["alertname"]       // The field that is used to group alert events. 
        ///     }
        /// </summary>
        [NameInMap("GroupRule")]
        [Validation(Required=false)]
        public string GroupRule { get; set; }

        /// <summary>
        /// The ID of the notification policy.
        /// 
        /// *   If you do not specify this parameter, a new notification policy is created.
        /// *   If you specify this parameter, the specified notification policy is modified.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The integration ID of the ticket system to which alerts are pushed.
        /// </summary>
        [NameInMap("IntegrationId")]
        [Validation(Required=false)]
        public long? IntegrationId { get; set; }

        /// <summary>
        /// The matching rules. Format:
        /// 
        ///     [
        ///      {
        ///      "matchingConditions": [
        ///      { 
        ///      "value": "test",    // The value of the matching condition. 
        ///      "key": "alertname",     // The key of the matching condition. 
        ///      "operator": "eq"   // The logical operator of the matching condition, including eq (equal to), neq (not equal to), in (contains), nin (does not contain), re (regular expression match), and nre (regular expression mismatch).   
        ///      }
        ///      ]
        ///      } 
        ///      ]
        /// </summary>
        [NameInMap("MatchingRules")]
        [Validation(Required=false)]
        public string MatchingRules { get; set; }

        /// <summary>
        /// The name of the notification policy.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// An array of notification rule objects. Format:
        /// 
        ///     { 
        ///      "notifyStartTime":"00:00",      // The start time of the notification window. 
        ///      "notifyEndTime":"23:59",       // The end time of the notification window. 
        ///      "notifyChannels":["dingTalk", "email", "sms", "tts", "webhook"],       // The notification methods. Valid values: dingTalk, email, sms, tts, and webhook. 
        ///      "notifyObjects":[{       // An array of notification objects. 
        ///      "notifyObjectType":"CONTACT",       // The type of the notification object. Valid values: CONTACT (contact), CONTACT_GROUP (contact group), ARMS_CONTACT (ARMS contact), ARMS_CONTACT_GROUP (ARMS contact group), DING_ROBOT_GROUP (DingTalk, Lark, WeCom, or IM robot), and CONTACT_SCHEDULE (user on duty defined by a schedule). 
        ///      "notifyObjectId":123,       // The ID of the notification object. 
        ///      "notifyObjectName":"test"       // The name of the notification object. 
        ///      }]
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NotifyRule")]
        [Validation(Required=false)]
        public string NotifyRule { get; set; }

        /// <summary>
        /// The notification template. The default notification template is provided below the table.
        /// </summary>
        [NameInMap("NotifyTemplate")]
        [Validation(Required=false)]
        public string NotifyTemplate { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Specifies whether to resend a notification for a long-lasting unresolved alert. Default value: true. Valid values:
        /// 
        /// *   `true`: If you set this parameter to `true`, you must set **RepeatInterval**.
        /// *   `false`: If you set this parameter to `false`, you must set **EscalationPolicyId**.
        /// </summary>
        [NameInMap("Repeat")]
        [Validation(Required=false)]
        public bool? Repeat { get; set; }

        /// <summary>
        /// The time interval at which a notification is resent for a long-lasting unresolved alert. Unit: seconds.
        /// </summary>
        [NameInMap("RepeatInterval")]
        [Validation(Required=false)]
        public long? RepeatInterval { get; set; }

        /// <summary>
        /// Specifies whether the status of an alert automatically changes to Resolved when all events related to the alert change to the Restored state. ARMS notifies contacts when the alert status changes to Resolved.
        /// 
        /// *   `true`: The system sends a notification.
        /// *   `false`: The system does not send a notification.
        /// </summary>
        [NameInMap("SendRecoverMessage")]
        [Validation(Required=false)]
        public bool? SendRecoverMessage { get; set; }

        /// <summary>
        /// Specifies whether to enable the notification policy. Valid values: enable and disable.
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
