// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpdateScheduleMonitorRequest : TeaModel {
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
        /// <para>The ID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <para>The request body for updating scheduling monitoring.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpdateCommand")]
        [Validation(Required=false)]
        public UpdateScheduleMonitorRequestUpdateCommand UpdateCommand { get; set; }
        public class UpdateScheduleMonitorRequestUpdateCommand : TeaModel {
            /// <summary>
            /// <para>The monitored object configuration.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("MonitoredItemConfig")]
            [Validation(Required=false)]
            public UpdateScheduleMonitorRequestUpdateCommandMonitoredItemConfig MonitoredItemConfig { get; set; }
            public class UpdateScheduleMonitorRequestUpdateCommandMonitoredItemConfig : TeaModel {
                /// <summary>
                /// <para>The business unit ID. Required when the summary logical table does not have a project ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100001</para>
                /// </summary>
                [NameInMap("BizUnitId")]
                [Validation(Required=false)]
                public long? BizUnitId { get; set; }

                /// <summary>
                /// <para>The logical table ID. Required for the LOGICAL_FIELD and LOGICAL_TABLE_NODE types.</para>
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
                /// <para>The monitored object type. Valid values: LOGICAL_FIELD (logical field), OND_ID_NODE (logical table node), SCHEDULE_PHYSICAL_NODE (periodically scheduled physical task), MANUAL_PHYSICAL_NODE (manually scheduled physical task), ODM_NODE (source path task), LOGICAL_TABLE_NODE (logical table task), and PROJECT (project).</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SCHEDULE_PHYSICAL_NODE</para>
                /// </summary>
                [NameInMap("MonitoredItemType")]
                [Validation(Required=false)]
                public string MonitoredItemType { get; set; }

                /// <summary>
                /// <para>The monitored task scope, which specifies project-level monitoring filter rules. Required for the PROJECT type.</para>
                /// </summary>
                [NameInMap("MonitoredNodeRange")]
                [Validation(Required=false)]
                public UpdateScheduleMonitorRequestUpdateCommandMonitoredItemConfigMonitoredNodeRange MonitoredNodeRange { get; set; }
                public class UpdateScheduleMonitorRequestUpdateCommandMonitoredItemConfigMonitoredNodeRange : TeaModel {
                    /// <summary>
                    /// <para>The list of filter rules. If left empty, all rules are applied by default.</para>
                    /// </summary>
                    [NameInMap("FilterRuleList")]
                    [Validation(Required=false)]
                    public List<UpdateScheduleMonitorRequestUpdateCommandMonitoredItemConfigMonitoredNodeRangeFilterRuleList> FilterRuleList { get; set; }
                    public class UpdateScheduleMonitorRequestUpdateCommandMonitoredItemConfigMonitoredNodeRangeFilterRuleList : TeaModel {
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
                        /// <para>Specifies whether to exclude the selection.</para>
                        /// </summary>
                        [NameInMap("IsExclude")]
                        [Validation(Required=false)]
                        public bool? IsExclude { get; set; }

                    }

                }

                /// <summary>
                /// <para>The monitored task ID, which is the node ID. Required for types other than PROJECT.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345678</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The monitored task name, which is the node name. Required for types other than PROJECT.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dwd_order_detail_daily</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// <para>The node subtype. Required for types other than PROJECT and LOGICAL_FIELD.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MAX_COMPUTE_SQL</para>
                /// </summary>
                [NameInMap("NodeSubType")]
                [Validation(Required=false)]
                public string NodeSubType { get; set; }

                /// <summary>
                /// <para>The list of node O&amp;M owner IDs. This serves as the source for OWNER recipients.</para>
                /// </summary>
                [NameInMap("OpsOwnerIdList")]
                [Validation(Required=false)]
                public List<string> OpsOwnerIdList { get; set; }

                /// <summary>
                /// <para>The project ID. Required for the PROJECT type. For other types, it specifies the project to which the monitored object belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7086194564164288</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

            }

            /// <summary>
            /// <para>The monitored object ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6912345678901234</para>
            /// </summary>
            [NameInMap("MonitoredItemId")]
            [Validation(Required=false)]
            public long? MonitoredItemId { get; set; }

            /// <summary>
            /// <para>The list of monitored rule configurations. You can configure multiple rules with different alert causes.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("MonitoredRuleConfigList")]
            [Validation(Required=false)]
            public List<UpdateScheduleMonitorRequestUpdateCommandMonitoredRuleConfigList> MonitoredRuleConfigList { get; set; }
            public class UpdateScheduleMonitorRequestUpdateCommandMonitoredRuleConfigList : TeaModel {
                /// <summary>
                /// <para>The alert cause type. Valid values: FAILED: The node fails to run. TIME_OUT: The node execution times out. UNFINISHED: The node does not generate data. SUCCESS: The node runs successfully. DATA_DELAY: Data is delayed.</para>
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
                public UpdateScheduleMonitorRequestUpdateCommandMonitoredRuleConfigListAlertStrategy AlertStrategy { get; set; }
                public class UpdateScheduleMonitorRequestUpdateCommandMonitoredRuleConfigListAlertStrategy : TeaModel {
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
                    public UpdateScheduleMonitorRequestUpdateCommandMonitoredRuleConfigListAlertStrategyMonitoredTimeRange MonitoredTimeRange { get; set; }
                    public class UpdateScheduleMonitorRequestUpdateCommandMonitoredRuleConfigListAlertStrategyMonitoredTimeRange : TeaModel {
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
                    public List<UpdateScheduleMonitorRequestUpdateCommandMonitoredRuleConfigListAlertStrategyReceiverConfigList> ReceiverConfigList { get; set; }
                    public class UpdateScheduleMonitorRequestUpdateCommandMonitoredRuleConfigListAlertStrategyReceiverConfigList : TeaModel {
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
                        /// <para>The list of receiving methods. Valid values: PHONE: Phone call. MESSAGE: Text message. EMAIL: Email. DING_TALK: DingTalk. FEISHU: Lark. WECHAT: WeChat. CUSTOM: Custom channel.</para>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("ReceivedWayList")]
                        [Validation(Required=false)]
                        public List<string> ReceivedWayList { get; set; }

                        /// <summary>
                        /// <para>The recipient type. Valid values: OWNER: Owner. USER_CUSTOM: Custom user. ON_DUTY_TABLE: On-duty table.</para>
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
                    /// <para>The maximum number of times an alert can be sent.</para>
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
                /// <para>The daily check time for unfinished nodes in HH:mm format. Specify this parameter only when AlertReasonType is set to UNFINISHED.</para>
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
                public UpdateScheduleMonitorRequestUpdateCommandMonitoredRuleConfigListUnfinishedRuleDetailConfig UnfinishedRuleDetailConfig { get; set; }
                public class UpdateScheduleMonitorRequestUpdateCommandMonitoredRuleConfigListUnfinishedRuleDetailConfig : TeaModel {
                    /// <summary>
                    /// <para>The daily unfinished configuration.</para>
                    /// </summary>
                    [NameInMap("DailyUnfinishedConfig")]
                    [Validation(Required=false)]
                    public UpdateScheduleMonitorRequestUpdateCommandMonitoredRuleConfigListUnfinishedRuleDetailConfigDailyUnfinishedConfig DailyUnfinishedConfig { get; set; }
                    public class UpdateScheduleMonitorRequestUpdateCommandMonitoredRuleConfigListUnfinishedRuleDetailConfigDailyUnfinishedConfig : TeaModel {
                        /// <summary>
                        /// <para>The daily check time for unfinished nodes in HH:mm format.</para>
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
                    public UpdateScheduleMonitorRequestUpdateCommandMonitoredRuleConfigListUnfinishedRuleDetailConfigMultiPeriodUnfinishedConfig MultiPeriodUnfinishedConfig { get; set; }
                    public class UpdateScheduleMonitorRequestUpdateCommandMonitoredRuleConfigListUnfinishedRuleDetailConfigMultiPeriodUnfinishedConfig : TeaModel {
                        /// <summary>
                        /// <para>The list of custom monitoring periods. Specify this parameter when MonitorPeriodType is set to CUSTOM.</para>
                        /// </summary>
                        [NameInMap("CustomPeriodList")]
                        [Validation(Required=false)]
                        public List<UpdateScheduleMonitorRequestUpdateCommandMonitoredRuleConfigListUnfinishedRuleDetailConfigMultiPeriodUnfinishedConfigCustomPeriodList> CustomPeriodList { get; set; }
                        public class UpdateScheduleMonitorRequestUpdateCommandMonitoredRuleConfigListUnfinishedRuleDetailConfigMultiPeriodUnfinishedConfigCustomPeriodList : TeaModel {
                            /// <summary>
                            /// <para>The check time for unfinished nodes in HH:mm format.</para>
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
                        /// <para>The trigger rule type. Valid values: INTERVAL_AFTER_DUE_TIME: Triggered at an interval after the due time. FIX_TIME: Triggered at a fixed time.</para>
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

    }

}
