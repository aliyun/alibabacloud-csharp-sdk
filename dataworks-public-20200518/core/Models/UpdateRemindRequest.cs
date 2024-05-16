// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateRemindRequest : TeaModel {
        /// <summary>
        /// The recipient to whom alert notifications are sent. Valid values: OWNER and OTHER. The value OWNER indicates that alert notifications are sent to the object owner. The value OTHER indicates that alert notifications are sent to a specified user.
        /// </summary>
        [NameInMap("AlertInterval")]
        [Validation(Required=false)]
        public int? AlertInterval { get; set; }

        /// <summary>
        /// Specifies whether to enable the alert rule. Valid values:
        /// 
        /// *   true: enables the alert rule.
        /// *   false: disables the alert rule.
        /// </summary>
        [NameInMap("AlertMethods")]
        [Validation(Required=false)]
        public string AlertMethods { get; set; }

        /// <summary>
        /// The webhook URL of the DingTalk chatbot. You can specify multiple webhook URLs. Separate them with commas (,).
        /// 
        /// If this parameter is set to undefined, the specified webhook URLs are cleared.
        /// </summary>
        [NameInMap("AlertTargets")]
        [Validation(Required=false)]
        public string AlertTargets { get; set; }

        /// <summary>
        /// The value format required by this parameter varies based on the value that you specify for the AlertUnit parameter. Take note of the following items:
        /// 
        /// *   If the AlertUnit parameter is set to OWNER, leave this parameter empty.
        /// *   If the AlertUnit parameter is set to OTHER, set this parameter to the unique ID (UID) of the specified user. You can specify multiple IDs. Separate them with commas (,). You can specify a maximum of 10 IDs.
        /// </summary>
        [NameInMap("AlertUnit")]
        [Validation(Required=false)]
        public string AlertUnit { get; set; }

        /// <summary>
        /// The ID of the workflow to which the custom alert rule is applied.. An alert rule can monitor a maximum of five workflows. Separate multiple IDs with commas (,).
        /// 
        /// This parameter takes effect when you set the RemindUnit parameter to BIZPROCESS.
        /// </summary>
        [NameInMap("BaselineIds")]
        [Validation(Required=false)]
        public string BaselineIds { get; set; }

        /// <summary>
        /// The maximum number of alerts. Valid values: 1 to 10. Default value: 3.
        /// </summary>
        [NameInMap("BizProcessIds")]
        [Validation(Required=false)]
        public string BizProcessIds { get; set; }

        /// <summary>
        /// The notification method. Valid values:
        /// 
        /// *   MAIL: Alert notifications are sent by emails.
        /// *   SMS: Alert notifications are sent by text messages.
        /// *   PHONE: Alert notifications are sent by phone calls. You can use this notification method only in DataWorks Professional Edition or more advanced editions.
        /// *   DINGROBOTS: Alert notifications are sent by DingTalk messages. You can use this notification method only if the RobotUrls parameter is configured.
        /// *   WEBHOOKS (WeCom or Lark chatbot): Alert notifications are sent by WeCom or Lark messages. If you want to use this notification method, you must configure the Webhooks parameter.
        /// 
        /// You can specify multiple notification methods. Separate the specified notification methods with commas (,).
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public string Detail { get; set; }

        /// <summary>
        /// The ID of the node to which the custom alert rule is applied.. An alert rule can monitor a maximum of 50 nodes. Separate multiple IDs with commas (,).
        /// 
        /// This parameter takes effect when you set the RemindUnit parameter to NODE.
        /// </summary>
        [NameInMap("DndEnd")]
        [Validation(Required=false)]
        public string DndEnd { get; set; }

        /// <summary>
        /// The details of the conditions that trigger an alert.
        /// 
        /// *   If the RemindType parameter is set to FINISHED, leave this parameter empty.
        /// 
        /// *   If the RemindType parameter is set to UNFINISHED, set this parameter to key-value pairs. Example: {"hour":23,"minu":59}. Valid values of hour: 0 to 47. Valid values of minu: 0 to 59.
        /// 
        /// *   If the RemindType parameter is set to ERROR, leave this parameter empty.
        /// 
        /// *   If the RemindType parameter is set to CYCLE_UNFINISHED, set this parameter to key-value pairs in the JSON format. Example: {"1":"05:50","2":"06:50","3":"07:50","4":"08:50","5":"09:50","6":"10:50","7":"11:50","8":"12:50","9":"13:50","10":"14:50","11":"15:50","12":"16:50","13":"17:50","14":"18:50","15":"19:50","16":"20:50","17":"21:50","18":"22:50","19":"23:50","20":"24:50","21":"25:50"}.
        /// 
        ///     A key in the JSON string indicates the sequence number of a cycle. Valid values of keys: 1 to 288. A value in the JSON string indicates the time in point when a monitored instance times out in the relevant cycle. Values must be in the format of hh:mm. Valid values of hh: 0 to 47. Valid values of mm: 0 to 59.
        /// 
        /// *   If the RemindType parameter is set to TIMEOUT, set this parameter to the timeout period. Unit: seconds. Example: 1800. This indicates that an alert notification is sent if the duration of a monitored instance exceeds 30 minutes.
        /// </summary>
        [NameInMap("MaxAlertTimes")]
        [Validation(Required=false)]
        public int? MaxAlertTimes { get; set; }

        /// <summary>
        /// The ID of the workspace to which the custom alert rule is applied.. Only one workspace can be specified for a custom alert rule.
        /// 
        /// This parameter takes effect when you set the RemindUnit parameter to PROJECT.
        /// </summary>
        [NameInMap("NodeIds")]
        [Validation(Required=false)]
        public string NodeIds { get; set; }

        /// <summary>
        /// The condition that triggers the alert rule. Valid values:
        /// 
        /// *   FINISHED: The system monitors an instance when it starts to run and sends an alert notification after the running of the instance is complete.
        /// *   UNFINISHED: The system monitors an instance when it starts to run and sends an alert notification if the instance is still running at the specified point in time.
        /// *   ERROR: The system monitors an instance when it starts to run and sends an alert notification if an error occurs.
        /// *   CYCLE_UNFINISHED: The system sends an alert notification if a monitored instance is still running at the end of the specified cycle. In most cases, you can configure this trigger condition for node instances that are scheduled to run by hour.
        /// *   TIMEOUT: The system monitors an instance when it starts to run and sends an alert notification if the instance is still running after the specified period ends. In most cases, you can configure this trigger condition to monitor the duration of node instances.
        /// 
        /// For more information, see [Manage custom alert rules](https://help.aliyun.com/document_detail/138172.html).
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The end of the period during which no alert notifications are sent. Specify the time in the hh:mm format. Valid values of hh: 0 to 23. Valid values of mm: 0 to 59.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RemindId")]
        [Validation(Required=false)]
        public long? RemindId { get; set; }

        /// <summary>
        /// The type of the object to which the custom alert rule is applied.. Valid values:
        /// 
        /// *   NODE: node
        /// *   BASELINE: baseline
        /// *   PROJECT: workspace
        /// *   BIZPROCESS: workflow
        /// </summary>
        [NameInMap("RemindName")]
        [Validation(Required=false)]
        public string RemindName { get; set; }

        /// <summary>
        /// The intervals at which alert notifications are sent. Unit: seconds. Minimum value: 1200. Default value: 1800.
        /// </summary>
        [NameInMap("RemindType")]
        [Validation(Required=false)]
        public string RemindType { get; set; }

        /// <summary>
        /// The ID of the baseline to which the custom alert rule is applied.. An alert rule can monitor a maximum of five baselines. Separate multiple IDs with commas (,).
        /// 
        /// This parameter takes effect when you set the RemindUnit parameter to BASELINE.
        /// </summary>
        [NameInMap("RemindUnit")]
        [Validation(Required=false)]
        public string RemindUnit { get; set; }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("RobotUrls")]
        [Validation(Required=false)]
        public string RobotUrls { get; set; }

        /// <summary>
        /// The webhook URL of the WeCom or Lark chatbot. You can specify multiple webhook URLs. Separate the specified webhook URLs with commas (,). The WEBHOOKS notification method must be specified for alertMethods. If this parameter is set to undefined, the specified webhook URLs are cleared.
        /// 
        /// Only DataWorks Enterprise Edition supports this parameter.
        /// 
        /// The webhook URL-based alerting feature is supported in the following regions: China (Shanghai), China (Chengdu), China (Zhangjiakou), China (Beijing), China (Hangzhou), China (Shenzhen), China (Hong Kong), Germany (Frankfurt), and Singapore.
        /// </summary>
        [NameInMap("UseFlag")]
        [Validation(Required=false)]
        public bool? UseFlag { get; set; }

        /// <summary>
        /// Indicates whether the modification to the custom alert rule succeeds.
        /// </summary>
        [NameInMap("Webhooks")]
        [Validation(Required=false)]
        public string Webhooks { get; set; }

    }

}
