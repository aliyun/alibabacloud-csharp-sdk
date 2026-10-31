// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CreateScheduleMonitorRequest : TeaModel {
        /// <summary>
        /// <para>The request body for creating a scheduling monitoring configuration.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CreateCommand")]
        [Validation(Required=false)]
        public CreateScheduleMonitorRequestCreateCommand CreateCommand { get; set; }
        public class CreateScheduleMonitorRequestCreateCommand : TeaModel {
            /// <summary>
            /// <para>The monitored object configuration.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("MonitoredItemConfig")]
            [Validation(Required=false)]
            public CreateScheduleMonitorRequestCreateCommandMonitoredItemConfig MonitoredItemConfig { get; set; }
            public class CreateScheduleMonitorRequestCreateCommandMonitoredItemConfig : TeaModel {
                /// <summary>
                /// <para>The business unit ID. Specify this parameter when the summary logical table does not have a project ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100001</para>
                /// </summary>
                [NameInMap("BizUnitId")]
                [Validation(Required=false)]
                public long? BizUnitId { get; set; }

                /// <summary>
                /// <para>The logical table ID. Specify this parameter when the monitored object type is LOGICAL_FIELD or LOGICAL_TABLE_NODE.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6812345678901234</para>
                /// </summary>
                [NameInMap("LogicalTableId")]
                [Validation(Required=false)]
                public long? LogicalTableId { get; set; }

                /// <summary>
                /// <para>The name of the logical table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dwd_order_detail</para>
                /// </summary>
                [NameInMap("LogicalTableName")]
                [Validation(Required=false)]
                public string LogicalTableName { get; set; }

                /// <summary>
                /// <para>The monitored object type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>LOGICAL_FIELD: logical field.</description></item>
                /// <item><description>OND_ID_NODE: logical table node.</description></item>
                /// <item><description>SCHEDULE_PHYSICAL_NODE: physical task with epoch scheduling.</description></item>
                /// <item><description>MANUAL_PHYSICAL_NODE: physical task with manual scheduling.</description></item>
                /// <item><description>ODM_NODE: source data path task.</description></item>
                /// <item><description>LOGICAL_TABLE_NODE: logical table task.</description></item>
                /// <item><description>PROJECT: project.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SCHEDULE_PHYSICAL_NODE</para>
                /// </summary>
                [NameInMap("MonitoredItemType")]
                [Validation(Required=false)]
                public string MonitoredItemType { get; set; }

                /// <summary>
                /// <para>The scope of monitored tasks, which serves as the filtering rule for project-level monitoring. Specify this parameter when the monitored object type is PROJECT.</para>
                /// </summary>
                [NameInMap("MonitoredNodeRange")]
                [Validation(Required=false)]
                public CreateScheduleMonitorRequestCreateCommandMonitoredItemConfigMonitoredNodeRange MonitoredNodeRange { get; set; }
                public class CreateScheduleMonitorRequestCreateCommandMonitoredItemConfigMonitoredNodeRange : TeaModel {
                    /// <summary>
                    /// <para>The list of filter rules. If this parameter is left empty, all tasks are monitored by default.</para>
                    /// </summary>
                    [NameInMap("FilterRuleList")]
                    [Validation(Required=false)]
                    public List<CreateScheduleMonitorRequestCreateCommandMonitoredItemConfigMonitoredNodeRangeFilterRuleList> FilterRuleList { get; set; }
                    public class CreateScheduleMonitorRequestCreateCommandMonitoredItemConfigMonitoredNodeRangeFilterRuleList : TeaModel {
                        /// <summary>
                        /// <para>The filter key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>NODE_NAME</para>
                        /// </summary>
                        [NameInMap("FilterKey")]
                        [Validation(Required=false)]
                        public string FilterKey { get; set; }

                        /// <summary>
                        /// <para>The list of filter values. Multiple values are supported.</para>
                        /// </summary>
                        [NameInMap("FilterValueList")]
                        [Validation(Required=false)]
                        public List<string> FilterValueList { get; set; }

                        /// <summary>
                        /// <para>Specifies whether to invert the selection.</para>
                        /// </summary>
                        [NameInMap("IsExclude")]
                        [Validation(Required=false)]
                        public bool? IsExclude { get; set; }

                    }

                }

                /// <summary>
                /// <para>The ID of the monitored task, which is the node ID. This parameter is required when the monitored object type is not PROJECT.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345678</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The name of the monitored task, which is the node name. This parameter is required when the monitored object type is not PROJECT.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dwd_order_detail_daily</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// <para>The subtype of the node. This parameter is required when the monitored object type is not PROJECT or LOGICAL_FIELD.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MAX_COMPUTE_SQL</para>
                /// </summary>
                [NameInMap("NodeSubType")]
                [Validation(Required=false)]
                public string NodeSubType { get; set; }

                /// <summary>
                /// <para>The list of O&amp;M owner IDs for the node. This serves as the source for the OWNER recipient type.</para>
                /// </summary>
                [NameInMap("OpsOwnerIdList")]
                [Validation(Required=false)]
                public List<string> OpsOwnerIdList { get; set; }

                /// <summary>
                /// <para>The project ID. This parameter is required when the monitored object type is PROJECT. For other types, it specifies the project to which the monitored object belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7086194564164288</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

            }

            /// <summary>
            /// <para>The list of monitoring rule configurations. You can configure multiple rules for different alert causes.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("MonitoredRuleConfigList")]
            [Validation(Required=false)]
            public List<CreateScheduleMonitorRequestCreateCommandMonitoredRuleConfigList> MonitoredRuleConfigList { get; set; }
            public class CreateScheduleMonitorRequestCreateCommandMonitoredRuleConfigList : TeaModel {
                /// <summary>
                /// <para>The alert cause type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>FAILED: The task execution failed.</description></item>
                /// <item><description>TIME_OUT: The task execution timed out.</description></item>
                /// <item><description>UNFINISHED: The task is not completed.</description></item>
                /// <item><description>SUCCESS: The task execution succeeded.</description></item>
                /// <item><description>DATA_DELAY: The data is delayed.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TIME_OUT</para>
                /// </summary>
                [NameInMap("AlertReasonType")]
                [Validation(Required=false)]
                public string AlertReasonType { get; set; }

                /// <summary>
                /// <para>The alert strategy.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("AlertStrategy")]
                [Validation(Required=false)]
                public CreateScheduleMonitorRequestCreateCommandMonitoredRuleConfigListAlertStrategy AlertStrategy { get; set; }
                public class CreateScheduleMonitorRequestCreateCommandMonitoredRuleConfigListAlertStrategy : TeaModel {
                    /// <summary>
                    /// <para>The alert trigger frequency.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("AlertFrequency")]
                    [Validation(Required=false)]
                    public int? AlertFrequency { get; set; }

                    /// <summary>
                    /// <para>The monitored time range.</para>
                    /// </summary>
                    [NameInMap("MonitoredTimeRange")]
                    [Validation(Required=false)]
                    public CreateScheduleMonitorRequestCreateCommandMonitoredRuleConfigListAlertStrategyMonitoredTimeRange MonitoredTimeRange { get; set; }
                    public class CreateScheduleMonitorRequestCreateCommandMonitoredRuleConfigListAlertStrategyMonitoredTimeRange : TeaModel {
                        /// <summary>
                        /// <para>The end time in HH:mm format. Set this parameter to 0 to indicate no limit.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>11:00</para>
                        /// </summary>
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        /// <summary>
                        /// <para>The start time in HH:mm format. Set this parameter to 0 to indicate no limit.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>07:00</para>
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                    }

                    /// <summary>
                    /// <para>The list of recipient configurations.</para>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("ReceiverConfigList")]
                    [Validation(Required=false)]
                    public List<CreateScheduleMonitorRequestCreateCommandMonitoredRuleConfigListAlertStrategyReceiverConfigList> ReceiverConfigList { get; set; }
                    public class CreateScheduleMonitorRequestCreateCommandMonitoredRuleConfigListAlertStrategyReceiverConfigList : TeaModel {
                        /// <summary>
                        /// <para>The list of custom alert channel IDs.</para>
                        /// </summary>
                        [NameInMap("CustomAlertChannelIdList")]
                        [Validation(Required=false)]
                        public List<string> CustomAlertChannelIdList { get; set; }

                        /// <summary>
                        /// <para>The list of on-duty table IDs. This parameter is required when ReceiverType is set to ON_DUTY_TABLE.</para>
                        /// </summary>
                        [NameInMap("OnDutyTableIdList")]
                        [Validation(Required=false)]
                        public List<string> OnDutyTableIdList { get; set; }

                        /// <summary>
                        /// <para>The list of notification methods. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>PHONE: Phone call.</description></item>
                        /// <item><description>MESSAGE: Text message.</description></item>
                        /// <item><description>EMAIL: Email.</description></item>
                        /// <item><description>DING_TALK: DingTalk.</description></item>
                        /// <item><description>FEISHU: Lark.</description></item>
                        /// <item><description>WECHAT: WeChat.</description></item>
                        /// <item><description>CUSTOM: Custom channel.</description></item>
                        /// </list>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("ReceivedWayList")]
                        [Validation(Required=false)]
                        public List<string> ReceivedWayList { get; set; }

                        /// <summary>
                        /// <para>The recipient type. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>OWNER: The owner.</description></item>
                        /// <item><description>USER_CUSTOM: A custom user.</description></item>
                        /// <item><description>ON_DUTY_TABLE: An on-duty table.</description></item>
                        /// </list>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>OWNER</para>
                        /// </summary>
                        [NameInMap("ReceiverType")]
                        [Validation(Required=false)]
                        public string ReceiverType { get; set; }

                        /// <summary>
                        /// <para>The list of recipient user IDs. This parameter is required when ReceiverType is set to USER_CUSTOM.</para>
                        /// </summary>
                        [NameInMap("ReceiverUserIdList")]
                        [Validation(Required=false)]
                        public List<string> ReceiverUserIdList { get; set; }

                    }

                    /// <summary>
                    /// <para>The maximum number of alert notifications to send.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("SendTimes")]
                    [Validation(Required=false)]
                    public int? SendTimes { get; set; }

                }

                /// <summary>
                /// <para>The timeout period in minutes. Specify this parameter only when AlertReasonType is set to TIME_OUT.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("FixedElapsedTime")]
                [Validation(Required=false)]
                public long? FixedElapsedTime { get; set; }

                /// <summary>
                /// <para>The daily time to check for unfinished tasks in HH:mm format. Specify this parameter only when AlertReasonType is set to UNFINISHED.</para>
                /// 
                /// <b>Example:</b>
                /// <para>07:00</para>
                /// </summary>
                [NameInMap("FixedUnfinishedTime")]
                [Validation(Required=false)]
                public string FixedUnfinishedTime { get; set; }

                /// <summary>
                /// <para>The detailed configuration for the unfinished rule. Specify this parameter only when AlertReasonType is set to UNFINISHED.</para>
                /// </summary>
                [NameInMap("UnfinishedRuleDetailConfig")]
                [Validation(Required=false)]
                public CreateScheduleMonitorRequestCreateCommandMonitoredRuleConfigListUnfinishedRuleDetailConfig UnfinishedRuleDetailConfig { get; set; }
                public class CreateScheduleMonitorRequestCreateCommandMonitoredRuleConfigListUnfinishedRuleDetailConfig : TeaModel {
                    /// <summary>
                    /// <para>The daily unfinished configuration.</para>
                    /// </summary>
                    [NameInMap("DailyUnfinishedConfig")]
                    [Validation(Required=false)]
                    public CreateScheduleMonitorRequestCreateCommandMonitoredRuleConfigListUnfinishedRuleDetailConfigDailyUnfinishedConfig DailyUnfinishedConfig { get; set; }
                    public class CreateScheduleMonitorRequestCreateCommandMonitoredRuleConfigListUnfinishedRuleDetailConfigDailyUnfinishedConfig : TeaModel {
                        /// <summary>
                        /// <para>The daily time to check for unfinished tasks in HH:mm format.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>07:00</para>
                        /// </summary>
                        [NameInMap("FixedUnfinishedTime")]
                        [Validation(Required=false)]
                        public string FixedUnfinishedTime { get; set; }

                    }

                    /// <summary>
                    /// <para>The multi-period unfinished configuration.</para>
                    /// </summary>
                    [NameInMap("MultiPeriodUnfinishedConfig")]
                    [Validation(Required=false)]
                    public CreateScheduleMonitorRequestCreateCommandMonitoredRuleConfigListUnfinishedRuleDetailConfigMultiPeriodUnfinishedConfig MultiPeriodUnfinishedConfig { get; set; }
                    public class CreateScheduleMonitorRequestCreateCommandMonitoredRuleConfigListUnfinishedRuleDetailConfigMultiPeriodUnfinishedConfig : TeaModel {
                        /// <summary>
                        /// <para>The list of custom monitoring periods. Specify this parameter when MonitorPeriodType is set to CUSTOM.</para>
                        /// </summary>
                        [NameInMap("CustomPeriodList")]
                        [Validation(Required=false)]
                        public List<CreateScheduleMonitorRequestCreateCommandMonitoredRuleConfigListUnfinishedRuleDetailConfigMultiPeriodUnfinishedConfigCustomPeriodList> CustomPeriodList { get; set; }
                        public class CreateScheduleMonitorRequestCreateCommandMonitoredRuleConfigListUnfinishedRuleDetailConfigMultiPeriodUnfinishedConfigCustomPeriodList : TeaModel {
                            /// <summary>
                            /// <para>The time to check for unfinished tasks in HH:mm format.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>07:00</para>
                            /// </summary>
                            [NameInMap("FixedUnfinishedTime")]
                            [Validation(Required=false)]
                            public string FixedUnfinishedTime { get; set; }

                            /// <summary>
                            /// <para>The number of periods.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("PeriodNum")]
                            [Validation(Required=false)]
                            public int? PeriodNum { get; set; }

                        }

                        /// <summary>
                        /// <para>The interval time value. This parameter is used together with IntervalUnit.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("IntervalAfterDueTime")]
                        [Validation(Required=false)]
                        public int? IntervalAfterDueTime { get; set; }

                        /// <summary>
                        /// <para>The interval unit. Valid values: SECONDS, MINUTES, and HOURS.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MINUTES</para>
                        /// </summary>
                        [NameInMap("IntervalUnit")]
                        [Validation(Required=false)]
                        public string IntervalUnit { get; set; }

                        /// <summary>
                        /// <para>The monitoring period type. Valid values: ALL, FIRST, LAST, and CUSTOM.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ALL</para>
                        /// </summary>
                        [NameInMap("MonitorPeriodType")]
                        [Validation(Required=false)]
                        public string MonitorPeriodType { get; set; }

                        /// <summary>
                        /// <para>The trigger rule type. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>INTERVAL_AFTER_DUE_TIME: Triggered at an interval after the due time.</description></item>
                        /// <item><description>FIX_TIME: Triggered at a fixed time.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>INTERVAL_AFTER_DUE_TIME</para>
                        /// </summary>
                        [NameInMap("TriggerRuleType")]
                        [Validation(Required=false)]
                        public string TriggerRuleType { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The operator user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
