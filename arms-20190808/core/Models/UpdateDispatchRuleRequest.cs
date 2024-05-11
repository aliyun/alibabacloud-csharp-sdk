// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class UpdateDispatchRuleRequest : TeaModel {
        /// <summary>
        /// ## Additional information about the **DispatchRule** parameter
        /// 
        /// **JSON string example and description**
        /// 
        /// ```
        /// 
        /// {
        ///   "id": 123,           // The ID of the dispatch policy. 
        ///   "system": false,        // Specifies whether the dispatch rule is editable. Valid values: true: not editable. false: editable. 
        ///   "ruleid": 10282,           // The ID of the dispatch rule. 
        ///   "name": "Prometheus Alert",   // The name of the dispatch policy. 
        ///   "labelMatchExpressionGrid": {
        ///     "labelMatchExpressionGroups": [     // Sets the dispatch rule. 
        ///       {
        ///         "labelMatchExpressions": [
        ///           {
        ///             "key": "_aliyun_arms_involvedObject_kind",   // The key of the tag of the dispatch rule. For more information, see the next section. 
        ///             "value": "app",                              // The value of the tag. 
        ///             "operator": "eq"                             // The operator used in the dispatch rule. Valid values: eq: equals to. re: matches a regular expression. 
        ///           }
        ///         ]
        ///       }
        ///     ]
        ///   },
        ///   "dispatchType": "CREATE_ALERT/DISCARD_ALERT",    // The alert handling method. Valid values: CREATE_ALERT: generates an alert. DISCARD_ALERT: discards the alert event and generates no alert.
        ///   "isRecover": true,               // Specifies whether to send the restored alert. Valid values: true: sends the alert. false: does not send the alert. 
        ///   "groupRules": [                  // Sets the event group. 
        ///     {
        ///       "groupId": 1,               // The ID of the group. 
        ///       "groupingFields": [         // The fields that are used to group events. Events with the same field content are assigned to a group. Alerts with the same specified grouping field are sent to the handler in separate notifications. 
        ///         "alertname"
        ///       ],
        ///       "groupWait": 10,                 // The duration for which the system waits after the first alert is sent. After the duration, all alerts are sent in a single notification to the handler. 
        ///       "groupInterval": 15,             // The grouping interval. During the silence period of repeated alerts, if new alerts are generated, they will be sent after the group waiting time. 
        ///       "repeatInterval": 20             // The silence period of repeated alerts. All alerts are repeatedly sent at specified intervals until the alerts are cleared. 
        ///     }
        ///   ],
        ///   "notifyRules": [            // Sets the notification rule. 
        ///     {
        ///       "notifyObjects": [
        ///         {
        ///           "notifyType": "ARMS_CONTACT",     // The type of the alert contact. Valid values: ARMS_CONTACT: contact. ARMS_CONTACT_GROUP: contact group. 
        ///           "name": "JohnDoe",                // The name of the contact or contact group. 
        ///           "notifyObjectId": 1               // The ID of the contact or contact group. 
        ///         },
        ///         {
        ///           "notifyType": "ARMS_CONTACT_GROUP",
        ///           "name": "JohnDoe_group",
        ///           "notifyObjectId": 2
        ///         }
        ///       ],
        ///       "notifyChannels":["dingTalk","wechat","webhook","email"]     // The notification method. Valid values: dingTalk, sms, webhook, email, and wechat. 
        ///     },
        ///   ],
        /// }
        /// ```
        /// 
        /// **Enumerated keys of the tag of the dispatch rule**
        /// 
        /// *   `_aliyun_arms_userid`: user ID
        /// *   `_aliyun_arms_involvedObject_kind`: type of the associated object
        /// *   `_aliyun_arms_involvedObject_id`: ID of the associated object
        /// *   `_aliyun_arms_involvedObject_name`: name of the associated object
        /// *   `_aliyun_arms_alert_name`: alert name
        /// *   `_aliyun_arms_alert_rule_id`: alert rule ID
        /// *   `_aliyun_arms_alert_type`: alert type
        /// *   `_aliyun_arms_alert_level`: alert severity
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DispatchRule")]
        [Validation(Required=false)]
        public string DispatchRule { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
