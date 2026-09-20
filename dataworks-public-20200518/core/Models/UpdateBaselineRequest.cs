// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateBaselineRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether alerting is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enabled.</description></item>
        /// <item><description>false: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AlertEnabled")]
        [Validation(Required=false)]
        public bool? AlertEnabled { get; set; }

        /// <summary>
        /// <para>The baseline alert margin. Unit: minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("AlertMarginThreshold")]
        [Validation(Required=false)]
        public int? AlertMarginThreshold { get; set; }

        /// <summary>
        /// <para>The baseline alert configurations.</para>
        /// </summary>
        [NameInMap("AlertSettings")]
        [Validation(Required=false)]
        public List<UpdateBaselineRequestAlertSettings> AlertSettings { get; set; }
        public class UpdateBaselineRequestAlertSettings : TeaModel {
            /// <summary>
            /// <para>The event alerting interval. Unit: minutes. Minimum value: 5. Maximum value: 1440.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("AlertInterval")]
            [Validation(Required=false)]
            public int? AlertInterval { get; set; }

            /// <summary>
            /// <para>The maximum number of event alerting notifications. Maximum value: 288.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AlertMaximum")]
            [Validation(Required=false)]
            public int? AlertMaximum { get; set; }

            /// <summary>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>MAIL: email.</description></item>
            /// <item><description>SMS: text message.</description></item>
            /// <item><description>PHONE: phone call. Only DataWorks Professional Edition and higher support phone call alerts.</description></item>
            /// <item><description>DINGROBOTS: DingTalk chatbot. This alert method takes effect only after the RobotUrls parameter is configured.</description></item>
            /// <item><description>Webhooks: WeCom or Lark chatbot. This alert method takes effect only after the Webhooks parameter is configured.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("AlertMethods")]
            [Validation(Required=false)]
            public List<string> AlertMethods { get; set; }

            /// <summary>
            /// <para>The alert recipient details. For specified users: a list of employee IDs. For on-duty schedule: the schedule name. For owner: leave empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123123</para>
            /// </summary>
            [NameInMap("AlertRecipient")]
            [Validation(Required=false)]
            public string AlertRecipient { get; set; }

            /// <summary>
            /// <para>The alert recipient type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>OWNER: node owner.</description></item>
            /// <item><description>OTHER: specified users.</description></item>
            /// <item><description>SHIFT_SCHEDULE: on-duty schedule.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OWNER</para>
            /// </summary>
            [NameInMap("AlertRecipientType")]
            [Validation(Required=false)]
            public string AlertRecipientType { get; set; }

            /// <summary>
            /// <para>The alert type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>BASELINE: baseline alerting.</description></item>
            /// <item><description>TOPIC: event alerting.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BASELINE</para>
            /// </summary>
            [NameInMap("AlertType")]
            [Validation(Required=false)]
            public string AlertType { get; set; }

            /// <summary>
            /// <para>Specifies whether baseline alerting is enabled. This is a baseline-specific configuration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enabled.</description></item>
            /// <item><description>false: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("BaselineAlertEnabled")]
            [Validation(Required=false)]
            public bool? BaselineAlertEnabled { get; set; }

            /// <summary>
            /// <para>The list of DingTalk chatbots.</para>
            /// </summary>
            [NameInMap("DingRobots")]
            [Validation(Required=false)]
            public List<UpdateBaselineRequestAlertSettingsDingRobots> DingRobots { get; set; }
            public class UpdateBaselineRequestAlertSettingsDingRobots : TeaModel {
                /// <summary>
                /// <para>Specifies whether to @all members. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Yes.</description></item>
                /// <item><description>false: No.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AtAll")]
                [Validation(Required=false)]
                public bool? AtAll { get; set; }

                /// <summary>
                /// <para>The webhook URL of the DingTalk group chatbot.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://oapi.dingtalk.com/robot/send?access_token=xxx">https://oapi.dingtalk.com/robot/send?access_token=xxx</a></para>
                /// </summary>
                [NameInMap("WebUrl")]
                [Validation(Required=false)]
                public string WebUrl { get; set; }

            }

            /// <summary>
            /// <para>The silence end time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:00</para>
            /// </summary>
            [NameInMap("SilenceEndTime")]
            [Validation(Required=false)]
            public string SilenceEndTime { get; set; }

            /// <summary>
            /// <para>The silence start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:00</para>
            /// </summary>
            [NameInMap("SilenceStartTime")]
            [Validation(Required=false)]
            public string SilenceStartTime { get; set; }

            /// <summary>
            /// <para>The threshold configuration for event slowdown alerts.</para>
            /// </summary>
            [NameInMap("TopicSlowConfig")]
            [Validation(Required=false)]
            public UpdateBaselineRequestAlertSettingsTopicSlowConfig TopicSlowConfig { get; set; }
            public class UpdateBaselineRequestAlertSettingsTopicSlowConfig : TeaModel {
                /// <summary>
                /// <para>The minimum slowdown threshold. Unit: seconds. Valid values: 300 to 18000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3600</para>
                /// </summary>
                [NameInMap("MinOver")]
                [Validation(Required=false)]
                public int? MinOver { get; set; }

                /// <summary>
                /// <para>The ratio used to calculate the slowdown threshold based on the historical average execution duration of the node. Valid values: 0.1 to 2.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.2</para>
                /// </summary>
                [NameInMap("OverFactor")]
                [Validation(Required=false)]
                public double? OverFactor { get; set; }

            }

            /// <summary>
            /// <para>The event alerting type. This is an event-specific configuration.</para>
            /// </summary>
            [NameInMap("TopicTypes")]
            [Validation(Required=false)]
            public List<string> TopicTypes { get; set; }

            /// <summary>
            /// <para>The webhook list.</para>
            /// </summary>
            [NameInMap("Webhooks")]
            [Validation(Required=false)]
            public List<string> Webhooks { get; set; }

        }

        /// <summary>
        /// <para>The ID of the baseline. You can call <a href="https://help.aliyun.com/document_detail/2261507.html">ListBaselines</a> to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000010800007</para>
        /// </summary>
        [NameInMap("BaselineId")]
        [Validation(Required=false)]
        public long? BaselineId { get; set; }

        /// <summary>
        /// <para>The baseline name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BaselineName</para>
        /// </summary>
        [NameInMap("BaselineName")]
        [Validation(Required=false)]
        public string BaselineName { get; set; }

        /// <summary>
        /// <para>The baseline type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DAILY: daily baseline.</description></item>
        /// <item><description>HOURLY: hourly baseline.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DAILY</para>
        /// </summary>
        [NameInMap("BaselineType")]
        [Validation(Required=false)]
        public string BaselineType { get; set; }

        /// <summary>
        /// <para>Specifies whether the baseline is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enabled.</description></item>
        /// <item><description>false: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The list of upstream node IDs for the baseline, separated by commas. If there are many nodes, we recommend that you add a virtual node downstream for easier management.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3</para>
        /// </summary>
        [NameInMap("NodeIds")]
        [Validation(Required=false)]
        public string NodeIds { get; set; }

        /// <summary>
        /// <para>The baseline committed time configurations.</para>
        /// </summary>
        [NameInMap("OvertimeSettings")]
        [Validation(Required=false)]
        public List<UpdateBaselineRequestOvertimeSettings> OvertimeSettings { get; set; }
        public class UpdateBaselineRequestOvertimeSettings : TeaModel {
            /// <summary>
            /// <para>The epoch corresponding to the committed time. For daily baselines, the value is 1. For hourly baselines, you can configure up to 24 epochs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Cycle")]
            [Validation(Required=false)]
            public int? Cycle { get; set; }

            /// <summary>
            /// <para>The committed time in hh:mm format. Valid values of hh: 0 to 47. Valid values of mm: 0 to 59.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:00</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

        }

        /// <summary>
        /// <para>The Alibaba Cloud UID of the baseline owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3726346****</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The priority of the baseline. Valid values: 1, 3, 5, 7, and 8.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The project ID. You can call <a href="https://help.aliyun.com/document_detail/2261507.html">ListBaselines</a> to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2043</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The IDs of nodes to remove from the baseline. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>123,456</para>
        /// </summary>
        [NameInMap("RemoveNodeIds")]
        [Validation(Required=false)]
        public string RemoveNodeIds { get; set; }

    }

}
