// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateBaselineRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the alerting feature. Valid values: true and false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AlertEnabled")]
        [Validation(Required=false)]
        public bool? AlertEnabled { get; set; }

        /// <summary>
        /// <para>The alert margin threshold of the baseline. Unit: minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("AlertMarginThreshold")]
        [Validation(Required=false)]
        public int? AlertMarginThreshold { get; set; }

        /// <summary>
        /// <para>The alert settings of the baseline.</para>
        /// </summary>
        [NameInMap("AlertSettings")]
        [Validation(Required=false)]
        public List<UpdateBaselineRequestAlertSettings> AlertSettings { get; set; }
        public class UpdateBaselineRequestAlertSettings : TeaModel {
            /// <summary>
            /// <para>The interval at which an event alert notification is sent. Unit: minutes. Minimum value: 5. Maximum value: 1,440.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1800</para>
            /// </summary>
            [NameInMap("AlertInterval")]
            [Validation(Required=false)]
            public int? AlertInterval { get; set; }

            /// <summary>
            /// <para>The maximum number of times an event alert notification is sent. Maximum value: 24.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AlertMaximum")]
            [Validation(Required=false)]
            public int? AlertMaximum { get; set; }

            /// <summary>
            /// <para>The alert notification methods. Valid values: MAIL, SMS, PHONE, DINGROBOTS, and Webhooks. The value MAIL indicates that alert notifications are sent by email. The value SMS indicates that alert notifications are sent by text message. The value PHONE indicates that alert notifications are sent by phone call. You can use this notification method only in DataWorks Professional Edition or a more advanced edition. The value DINGROBOTS indicates that alert notifications are sent by using a DingTalk chatbot. You can use this notification method only if the RobotUrls parameter is configured. The value Webhooks indicates that alert notifications are sent by WeCom or Lark. You can use this notification method only if the Webhooks parameter is configured.</para>
            /// </summary>
            [NameInMap("AlertMethods")]
            [Validation(Required=false)]
            public List<string> AlertMethods { get; set; }

            /// <summary>
            /// <para>The details of the alert recipient. If you set AlertRecipientType to OWNER, leave this parameter empty. If you set AlertRecipientType to SHIFT_SCHEDULE, set this parameter to the name of the shift schedule. If you set AlertRecipientType to OTHER, set this parameter to the employee IDs of specified personnel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123123</para>
            /// </summary>
            [NameInMap("AlertRecipient")]
            [Validation(Required=false)]
            public string AlertRecipient { get; set; }

            /// <summary>
            /// <para>The type of the alert recipient. Valid values: OWNER, OTHER, and SHIFT_SCHEDULE. The value OWNER indicates the node owner. The value OTHER indicates specified personnel. The value SHIFT_SCHEDULE indicates personnel in a shift schedule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OWNER</para>
            /// </summary>
            [NameInMap("AlertRecipientType")]
            [Validation(Required=false)]
            public string AlertRecipientType { get; set; }

            /// <summary>
            /// <para>The type of the alert. Valid values: BASELINE and TOPIC. The value BASELINE indicates a baseline alert. The value TOPIC indicates an event alert.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BASELINE</para>
            /// </summary>
            [NameInMap("AlertType")]
            [Validation(Required=false)]
            public string AlertType { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the baseline alerting feature. This feature is specific to baselines. Valid values: true and false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("BaselineAlertEnabled")]
            [Validation(Required=false)]
            public bool? BaselineAlertEnabled { get; set; }

            /// <summary>
            /// <para>The DingTalk chatbots.</para>
            /// </summary>
            [NameInMap("DingRobots")]
            [Validation(Required=false)]
            public List<UpdateBaselineRequestAlertSettingsDingRobots> DingRobots { get; set; }
            public class UpdateBaselineRequestAlertSettingsDingRobots : TeaModel {
                /// <summary>
                /// <para>Specifies whether to remind all members by using the at sign (@). Valid values: true and false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AtAll")]
                [Validation(Required=false)]
                public bool? AtAll { get; set; }

                /// <summary>
                /// <para>The webhook URL of the DingTalk chatbot.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://oapi.dingtalk.com/robot/send?access_token=xxx">https://oapi.dingtalk.com/robot/send?access_token=xxx</a></para>
                /// </summary>
                [NameInMap("WebUrl")]
                [Validation(Required=false)]
                public string WebUrl { get; set; }

            }

            /// <summary>
            /// <para>The end time of silence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:00:00</para>
            /// </summary>
            [NameInMap("SilenceEndTime")]
            [Validation(Required=false)]
            public string SilenceEndTime { get; set; }

            /// <summary>
            /// <para>The start time of silence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:00:00</para>
            /// </summary>
            [NameInMap("SilenceStartTime")]
            [Validation(Required=false)]
            public string SilenceStartTime { get; set; }

            /// <summary>
            /// <para>The types of event alerts, which are event-specific configurations.</para>
            /// </summary>
            [NameInMap("TopicTypes")]
            [Validation(Required=false)]
            public List<string> TopicTypes { get; set; }

            /// <summary>
            /// <para>The webhook URLs.</para>
            /// </summary>
            [NameInMap("Webhooks")]
            [Validation(Required=false)]
            public List<string> Webhooks { get; set; }

        }

        /// <summary>
        /// <para>The baseline ID. You can call the <a href="https://help.aliyun.com/document_detail/2261507.html">ListBaselines</a> operation to query the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000010800007</para>
        /// </summary>
        [NameInMap("BaselineId")]
        [Validation(Required=false)]
        public long? BaselineId { get; set; }

        /// <summary>
        /// <para>The name of the baseline.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BaselineName</para>
        /// </summary>
        [NameInMap("BaselineName")]
        [Validation(Required=false)]
        public string BaselineName { get; set; }

        /// <summary>
        /// <para>The type of the baseline. Valid values: DAILY and HOURLY.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DAILY</para>
        /// </summary>
        [NameInMap("BaselineType")]
        [Validation(Required=false)]
        public string BaselineType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the baseline. Valid values: true and false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The ancestor nodes of nodes in the baseline. Separate the ancestor nodes with commas (,). If a large number of ancestor nodes exist, we recommend that you create a zero load node and configure the zero load node as the descendant node of nodes in the baseline to facilitate node management.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3</para>
        /// </summary>
        [NameInMap("NodeIds")]
        [Validation(Required=false)]
        public string NodeIds { get; set; }

        /// <summary>
        /// <para>The settings of the committed completion time of the baseline.</para>
        /// </summary>
        [NameInMap("OvertimeSettings")]
        [Validation(Required=false)]
        public List<UpdateBaselineRequestOvertimeSettings> OvertimeSettings { get; set; }
        public class UpdateBaselineRequestOvertimeSettings : TeaModel {
            /// <summary>
            /// <para>The cycle that corresponds to the committed completion time. For a day-level baseline, set this parameter to 1. For an hour-level baseline, set this parameter to a value that is no more than 24.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Cycle")]
            [Validation(Required=false)]
            public int? Cycle { get; set; }

            /// <summary>
            /// <para>The committed completion time in the hh:mm format. Valid values of hh: [0,47]. Valid values of mm: [0,59].</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:00</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

        }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account used by the baseline owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3726346****</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The priority of the baseline. Valid values: {1,3,5,7,8}.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The workspace ID. You can call the <a href="https://help.aliyun.com/document_detail/2261507.html">ListBaselines</a> operation to query the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2043</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The ID of the node that you want to disassociate from the baseline. You can specify multiple node IDs. Separate multiple node IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>123,456</para>
        /// </summary>
        [NameInMap("RemoveNodeIds")]
        [Validation(Required=false)]
        public string RemoveNodeIds { get; set; }

    }

}
