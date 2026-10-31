// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListScheduleMonitorResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code of the request. A value of OK indicates that the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned by the backend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The paginated result of the scheduling monitoring alert query.</para>
        /// </summary>
        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListScheduleMonitorResponseBodyPageResult PageResult { get; set; }
        public class ListScheduleMonitorResponseBodyPageResult : TeaModel {
            /// <summary>
            /// <para>The list of monitored objects on the current page.</para>
            /// </summary>
            [NameInMap("MonitorItemList")]
            [Validation(Required=false)]
            public List<ListScheduleMonitorResponseBodyPageResultMonitorItemList> MonitorItemList { get; set; }
            public class ListScheduleMonitorResponseBodyPageResultMonitorItemList : TeaModel {
                /// <summary>
                /// <para>The business segment information.</para>
                /// </summary>
                [NameInMap("BizUnit")]
                [Validation(Required=false)]
                public ListScheduleMonitorResponseBodyPageResultMonitorItemListBizUnit BizUnit { get; set; }
                public class ListScheduleMonitorResponseBodyPageResultMonitorItemListBizUnit : TeaModel {
                    /// <summary>
                    /// <para>The display name of the business segment.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Test segment</para>
                    /// </summary>
                    [NameInMap("DisplayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    /// <summary>
                    /// <para>The ID of the business segment.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>6612345678901234</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The name of the business segment.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>bd_demo</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-09-10 15:30:00</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The logical table information.</para>
                /// </summary>
                [NameInMap("LogicTable")]
                [Validation(Required=false)]
                public ListScheduleMonitorResponseBodyPageResultMonitorItemListLogicTable LogicTable { get; set; }
                public class ListScheduleMonitorResponseBodyPageResultMonitorItemListLogicTable : TeaModel {
                    /// <summary>
                    /// <para>The ID of the business segment.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>6612345678901234</para>
                    /// </summary>
                    [NameInMap("BizUnitId")]
                    [Validation(Required=false)]
                    public long? BizUnitId { get; set; }

                    /// <summary>
                    /// <para>The ID of the monitoring task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>6812345678901234</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The name of the monitoring task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dim_user</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The subtype of the node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MAX_COMPUTE_SQL</para>
                    /// </summary>
                    [NameInMap("NodeSubType")]
                    [Validation(Required=false)]
                    public string NodeSubType { get; set; }

                    /// <summary>
                    /// <para>The list of O&amp;M owner IDs.</para>
                    /// </summary>
                    [NameInMap("OwnerIdList")]
                    [Validation(Required=false)]
                    public List<string> OwnerIdList { get; set; }

                    /// <summary>
                    /// <para>The name of the project to which the task belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ds_demo</para>
                    /// </summary>
                    [NameInMap("ProjectName")]
                    [Validation(Required=false)]
                    public string ProjectName { get; set; }

                    /// <summary>
                    /// <para>The type of the scheduling period.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DAILY</para>
                    /// </summary>
                    [NameInMap("SchedulePeriodType")]
                    [Validation(Required=false)]
                    public string SchedulePeriodType { get; set; }

                    /// <summary>
                    /// <para>Specifies whether data delay is supported.</para>
                    /// </summary>
                    [NameInMap("SupportDataDelay")]
                    [Validation(Required=false)]
                    public bool? SupportDataDelay { get; set; }

                }

                /// <summary>
                /// <para>The last modification time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-09-10 15:30:00</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// <para>The scope of the monitoring task.</para>
                /// </summary>
                [NameInMap("MonitorNodeRange")]
                [Validation(Required=false)]
                public ListScheduleMonitorResponseBodyPageResultMonitorItemListMonitorNodeRange MonitorNodeRange { get; set; }
                public class ListScheduleMonitorResponseBodyPageResultMonitorItemListMonitorNodeRange : TeaModel {
                    /// <summary>
                    /// <para>The list of filter rules.</para>
                    /// </summary>
                    [NameInMap("FilterRuleList")]
                    [Validation(Required=false)]
                    public List<ListScheduleMonitorResponseBodyPageResultMonitorItemListMonitorNodeRangeFilterRuleList> FilterRuleList { get; set; }
                    public class ListScheduleMonitorResponseBodyPageResultMonitorItemListMonitorNodeRangeFilterRuleList : TeaModel {
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
                        /// <para>The list of filter values.</para>
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
                /// <para>The ID of the monitored object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6912345678901234</para>
                /// </summary>
                [NameInMap("MonitoredItemId")]
                [Validation(Required=false)]
                public long? MonitoredItemId { get; set; }

                /// <summary>
                /// <para>The list of monitoring rules.</para>
                /// </summary>
                [NameInMap("MonitoredRuleList")]
                [Validation(Required=false)]
                public List<ListScheduleMonitorResponseBodyPageResultMonitorItemListMonitoredRuleList> MonitoredRuleList { get; set; }
                public class ListScheduleMonitorResponseBodyPageResultMonitorItemListMonitoredRuleList : TeaModel {
                    /// <summary>
                    /// <para>The reason for the alert.</para>
                    /// </summary>
                    [NameInMap("AlertReason")]
                    [Validation(Required=false)]
                    public ListScheduleMonitorResponseBodyPageResultMonitorItemListMonitoredRuleListAlertReason AlertReason { get; set; }
                    public class ListScheduleMonitorResponseBodyPageResultMonitorItemListMonitoredRuleListAlertReason : TeaModel {
                        /// <summary>
                        /// <para>The type of the alert reason. Valid values: FAILED, TIME_OUT, UNFINISHED, SUCCESS, and DATA_DELAY.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TIME_OUT</para>
                        /// </summary>
                        [NameInMap("AlertReasonType")]
                        [Validation(Required=false)]
                        public string AlertReasonType { get; set; }

                        /// <summary>
                        /// <para>The timeout period in minutes. This parameter is returned only when the alert reason type is TIME_OUT.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>60</para>
                        /// </summary>
                        [NameInMap("FixedElapsedTime")]
                        [Validation(Required=false)]
                        public long? FixedElapsedTime { get; set; }

                        /// <summary>
                        /// <para>The daily check time for unfinished tasks in HH:mm format. This parameter is returned only when the alert reason type is UNFINISHED.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>07:00</para>
                        /// </summary>
                        [NameInMap("FixedUnfinishedTime")]
                        [Validation(Required=false)]
                        public string FixedUnfinishedTime { get; set; }

                        /// <summary>
                        /// <para>The detailed configuration of the unfinished rule. This parameter is returned only when the alert reason type is UNFINISHED.</para>
                        /// </summary>
                        [NameInMap("UnfinishedRuleDetailConfig")]
                        [Validation(Required=false)]
                        public ListScheduleMonitorResponseBodyPageResultMonitorItemListMonitoredRuleListAlertReasonUnfinishedRuleDetailConfig UnfinishedRuleDetailConfig { get; set; }
                        public class ListScheduleMonitorResponseBodyPageResultMonitorItemListMonitoredRuleListAlertReasonUnfinishedRuleDetailConfig : TeaModel {
                            /// <summary>
                            /// <para>The daily configuration for unfinished tasks.</para>
                            /// </summary>
                            [NameInMap("DailyUnfinishedConfig")]
                            [Validation(Required=false)]
                            public ListScheduleMonitorResponseBodyPageResultMonitorItemListMonitoredRuleListAlertReasonUnfinishedRuleDetailConfigDailyUnfinishedConfig DailyUnfinishedConfig { get; set; }
                            public class ListScheduleMonitorResponseBodyPageResultMonitorItemListMonitoredRuleListAlertReasonUnfinishedRuleDetailConfigDailyUnfinishedConfig : TeaModel {
                                /// <summary>
                                /// <para>The time of day for the unfinished check, in HH:mm format.</para>
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
                            public ListScheduleMonitorResponseBodyPageResultMonitorItemListMonitoredRuleListAlertReasonUnfinishedRuleDetailConfigMultiPeriodUnfinishedConfig MultiPeriodUnfinishedConfig { get; set; }
                            public class ListScheduleMonitorResponseBodyPageResultMonitorItemListMonitoredRuleListAlertReasonUnfinishedRuleDetailConfigMultiPeriodUnfinishedConfig : TeaModel {
                                /// <summary>
                                /// <para>The list of custom monitoring periods.</para>
                                /// </summary>
                                [NameInMap("CustomPeriodList")]
                                [Validation(Required=false)]
                                public List<ListScheduleMonitorResponseBodyPageResultMonitorItemListMonitoredRuleListAlertReasonUnfinishedRuleDetailConfigMultiPeriodUnfinishedConfigCustomPeriodList> CustomPeriodList { get; set; }
                                public class ListScheduleMonitorResponseBodyPageResultMonitorItemListMonitoredRuleListAlertReasonUnfinishedRuleDetailConfigMultiPeriodUnfinishedConfigCustomPeriodList : TeaModel {
                                    /// <summary>
                                    /// <para>The time for the unfinished check, in HH:mm format.</para>
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
                                /// <para>The interval value.</para>
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
                                /// <para>The trigger rule type.</para>
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

                    /// <summary>
                    /// <para>The alert strategy.</para>
                    /// </summary>
                    [NameInMap("AlertStrategy")]
                    [Validation(Required=false)]
                    public ListScheduleMonitorResponseBodyPageResultMonitorItemListMonitoredRuleListAlertStrategy AlertStrategy { get; set; }
                    public class ListScheduleMonitorResponseBodyPageResultMonitorItemListMonitoredRuleListAlertStrategy : TeaModel {
                        /// <summary>
                        /// <para>The alert trigger frequency.</para>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("AlertFrequency")]
                        [Validation(Required=false)]
                        public int? AlertFrequency { get; set; }

                        /// <summary>
                        /// <para>The monitored time range.</para>
                        /// </summary>
                        [NameInMap("MonitoredTimeRange")]
                        [Validation(Required=false)]
                        public ListScheduleMonitorResponseBodyPageResultMonitorItemListMonitoredRuleListAlertStrategyMonitoredTimeRange MonitoredTimeRange { get; set; }
                        public class ListScheduleMonitorResponseBodyPageResultMonitorItemListMonitoredRuleListAlertStrategyMonitoredTimeRange : TeaModel {
                            /// <summary>
                            /// <para>The end time in HH:mm format. A value of 0 indicates no limit.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>11:00</para>
                            /// </summary>
                            [NameInMap("EndTime")]
                            [Validation(Required=false)]
                            public string EndTime { get; set; }

                            /// <summary>
                            /// <para>The start time in HH:mm format. A value of 0 indicates no limit.</para>
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
                        public List<ListScheduleMonitorResponseBodyPageResultMonitorItemListMonitoredRuleListAlertStrategyReceiverConfigList> ReceiverConfigList { get; set; }
                        public class ListScheduleMonitorResponseBodyPageResultMonitorItemListMonitoredRuleListAlertStrategyReceiverConfigList : TeaModel {
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
                            /// <para>The list of notification methods. Valid values: PHONE, MESSAGE, EMAIL, DING_TALK, FEISHU, WECHAT, and CUSTOM.</para>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("ReceivedWayList")]
                            [Validation(Required=false)]
                            public List<string> ReceivedWayList { get; set; }

                            /// <summary>
                            /// <para>The recipient type. Valid values: OWNER (owner), USER_CUSTOM (custom user), and ON_DUTY_TABLE (on-duty table).</para>
                            /// <para>This parameter is required.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>USER_CUSTOM</para>
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
                    /// <para>The creation time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-09-10 15:30:00</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    /// <summary>
                    /// <para>The creator.</para>
                    /// </summary>
                    [NameInMap("Creator")]
                    [Validation(Required=false)]
                    public ListScheduleMonitorResponseBodyPageResultMonitorItemListMonitoredRuleListCreator Creator { get; set; }
                    public class ListScheduleMonitorResponseBodyPageResultMonitorItemListMonitoredRuleListCreator : TeaModel {
                        /// <summary>
                        /// <para>The user ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>200012345</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>The username.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Zhang San</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// <para>The monitoring rule ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>6912345678909876</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The last modification time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-09-10 15:30:00</para>
                    /// </summary>
                    [NameInMap("ModifiedTime")]
                    [Validation(Required=false)]
                    public string ModifiedTime { get; set; }

                    /// <summary>
                    /// <para>The last modifier.</para>
                    /// </summary>
                    [NameInMap("Modifier")]
                    [Validation(Required=false)]
                    public ListScheduleMonitorResponseBodyPageResultMonitorItemListMonitoredRuleListModifier Modifier { get; set; }
                    public class ListScheduleMonitorResponseBodyPageResultMonitorItemListMonitoredRuleListModifier : TeaModel {
                        /// <summary>
                        /// <para>The user ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>200012345</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>The username.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Li Si</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// <para>The ID of the associated monitoring item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>6912345678901234</para>
                    /// </summary>
                    [NameInMap("MonitoredItemId")]
                    [Validation(Required=false)]
                    public long? MonitoredItemId { get; set; }

                    /// <summary>
                    /// <para>The project ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7086194564164288</para>
                    /// </summary>
                    [NameInMap("ProjectId")]
                    [Validation(Required=false)]
                    public long? ProjectId { get; set; }

                    /// <summary>
                    /// <para>The enablement status of the rule.</para>
                    /// </summary>
                    [NameInMap("SwitchStatus")]
                    [Validation(Required=false)]
                    public bool? SwitchStatus { get; set; }

                    /// <summary>
                    /// <para>The tenant ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30001011</para>
                    /// </summary>
                    [NameInMap("TenantId")]
                    [Validation(Required=false)]
                    public string TenantId { get; set; }

                }

                /// <summary>
                /// <para>The monitored task information.</para>
                /// </summary>
                [NameInMap("MonitoredTask")]
                [Validation(Required=false)]
                public ListScheduleMonitorResponseBodyPageResultMonitorItemListMonitoredTask MonitoredTask { get; set; }
                public class ListScheduleMonitorResponseBodyPageResultMonitorItemListMonitoredTask : TeaModel {
                    /// <summary>
                    /// <para>The ID of the monitoring task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>6712345678901234</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The name of the monitoring task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dwd_order_detail</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The name of the project to which the task belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ds_demo</para>
                    /// </summary>
                    [NameInMap("ProjectName")]
                    [Validation(Required=false)]
                    public string ProjectName { get; set; }

                    /// <summary>
                    /// <para>The schedule period type. Valid values: MINUTELY, HOURLY, DAILY, WEEKLY, MONTHLY, and YEARLY.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DAILY</para>
                    /// </summary>
                    [NameInMap("SchedulePeriodType")]
                    [Validation(Required=false)]
                    public string SchedulePeriodType { get; set; }

                }

                /// <summary>
                /// <para>The project ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7086194564164288</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The project information.</para>
                /// </summary>
                [NameInMap("ProjectInfo")]
                [Validation(Required=false)]
                public ListScheduleMonitorResponseBodyPageResultMonitorItemListProjectInfo ProjectInfo { get; set; }
                public class ListScheduleMonitorResponseBodyPageResultMonitorItemListProjectInfo : TeaModel {
                    /// <summary>
                    /// <para>The project ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7086194564164288</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The project name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ds_demo</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The business subtype.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MAX_COMPUTE_SQL</para>
                /// </summary>
                [NameInMap("SubType")]
                [Validation(Required=false)]
                public string SubType { get; set; }

                /// <summary>
                /// <para>The tenant ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30001011</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                /// <summary>
                /// <para>The monitored object type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SCHEDULE_PHYSICAL_NODE</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The total number of monitored objects that meet the conditions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>128</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
