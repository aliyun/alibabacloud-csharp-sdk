// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListScheduleTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. OK indicates that the request is successful.</para>
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
        /// <para>The schedule template list response.</para>
        /// </summary>
        [NameInMap("ListScheduleTemplatesResponse")]
        [Validation(Required=false)]
        public ListScheduleTemplatesResponseBodyListScheduleTemplatesResponse ListScheduleTemplatesResponse { get; set; }
        public class ListScheduleTemplatesResponseBodyListScheduleTemplatesResponse : TeaModel {
            /// <summary>
            /// <para>The total number of schedule templates that meet the specified conditions. This number is not limited by pagination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The schedule templates.</para>
            /// </summary>
            [NameInMap("ResultData")]
            [Validation(Required=false)]
            public List<ListScheduleTemplatesResponseBodyListScheduleTemplatesResponseResultData> ResultData { get; set; }
            public class ListScheduleTemplatesResponseBodyListScheduleTemplatesResponseResultData : TeaModel {
                /// <summary>
                /// <para>The condition-based schedule parameters. This parameter has a value only for condition-based schedule templates.</para>
                /// </summary>
                [NameInMap("ConditionScheduleParamList")]
                [Validation(Required=false)]
                public List<ListScheduleTemplatesResponseBodyListScheduleTemplatesResponseResultDataConditionScheduleParamList> ConditionScheduleParamList { get; set; }
                public class ListScheduleTemplatesResponseBodyListScheduleTemplatesResponseResultDataConditionScheduleParamList : TeaModel {
                    /// <summary>
                    /// <para>The name of the condition.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Rerun on failure condition</para>
                    /// </summary>
                    [NameInMap("ConditionName")]
                    [Validation(Required=false)]
                    public string ConditionName { get; set; }

                    /// <summary>
                    /// <para>The cron expression used after the condition is met.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0 30 * * * ?</para>
                    /// </summary>
                    [NameInMap("CronExpression")]
                    [Validation(Required=false)]
                    public string CronExpression { get; set; }

                    /// <summary>
                    /// <para>Specifies whether the condition is enabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Enable")]
                    [Validation(Required=false)]
                    public bool? Enable { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to follow the main schedule parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("FollowScheduleParam")]
                    [Validation(Required=false)]
                    public bool? FollowScheduleParam { get; set; }

                    /// <summary>
                    /// <para>The node schedule status after the condition is met. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>1: Normal.</description></item>
                    /// <item><description>2: Paused.</description></item>
                    /// <item><description>3: Dry run.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("NodeStatus")]
                    [Validation(Required=false)]
                    public int? NodeStatus { get; set; }

                    /// <summary>
                    /// <para>The conditional expression tree as a JSON character string. The keys are in lower camel case and must be parsed by the caller.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;type&quot;:&quot;EXPRESSION_GROUP&quot;,&quot;operator&quot;:&quot;or&quot;}</para>
                    /// </summary>
                    [NameInMap("ScheduleConditionJson")]
                    [Validation(Required=false)]
                    public string ScheduleConditionJson { get; set; }

                    /// <summary>
                    /// <para>The schedule time used after the condition is met.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>00:30</para>
                    /// </summary>
                    [NameInMap("ScheduleTime")]
                    [Validation(Required=false)]
                    public string ScheduleTime { get; set; }

                }

                /// <summary>
                /// <para>The cron expression for automatic scheduling. Refer to Linux cron expressions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 0 1 * * ?</para>
                /// </summary>
                [NameInMap("CronExpression")]
                [Validation(Required=false)]
                public string CronExpression { get; set; }

                /// <summary>
                /// <para>Specifies whether a custom cron expression is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("CustomCronExpression")]
                [Validation(Required=false)]
                public bool? CustomCronExpression { get; set; }

                /// <summary>
                /// <para>The custom schedule interval configuration. This configuration takes effect only when used together with CustomIntervalConfigType.</para>
                /// </summary>
                [NameInMap("CustomIntervalConfig")]
                [Validation(Required=false)]
                public ListScheduleTemplatesResponseBodyListScheduleTemplatesResponseResultDataCustomIntervalConfig CustomIntervalConfig { get; set; }
                public class ListScheduleTemplatesResponseBodyListScheduleTemplatesResponseResultDataCustomIntervalConfig : TeaModel {
                    /// <summary>
                    /// <para>The end time of the effective period.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>23:59</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <para>The interval value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("Interval")]
                    [Validation(Required=false)]
                    public int? Interval { get; set; }

                    /// <summary>
                    /// <para>The interval unit.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MINUTE</para>
                    /// </summary>
                    [NameInMap("IntervalUnit")]
                    [Validation(Required=false)]
                    public string IntervalUnit { get; set; }

                    /// <summary>
                    /// <para>The schedule period to which the interval belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DAY_INTERVAL</para>
                    /// </summary>
                    [NameInMap("SchedulePeriod")]
                    [Validation(Required=false)]
                    public string SchedulePeriod { get; set; }

                    /// <summary>
                    /// <para>The start time of the effective period.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>00:00</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                }

                /// <summary>
                /// <para>The type of the custom interval configuration. Valid values: TIME_POINT, TIME_PERIOD, CUSTOM_TIME_POINT, and CUSTOM_TIME_PERIOD.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CUSTOM_TIME_PERIOD</para>
                /// </summary>
                [NameInMap("CustomIntervalConfigType")]
                [Validation(Required=false)]
                public string CustomIntervalConfigType { get; set; }

                /// <summary>
                /// <para>The custom schedule interval configurations. This parameter is valid only when CustomIntervalConfigType is set to CUSTOM_TIME_PERIOD.</para>
                /// </summary>
                [NameInMap("CustomIntervalConfigs")]
                [Validation(Required=false)]
                public List<ListScheduleTemplatesResponseBodyListScheduleTemplatesResponseResultDataCustomIntervalConfigs> CustomIntervalConfigs { get; set; }
                public class ListScheduleTemplatesResponseBodyListScheduleTemplatesResponseResultDataCustomIntervalConfigs : TeaModel {
                    /// <summary>
                    /// <para>The end time of the effective period.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>23:59</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <para>The interval value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("Interval")]
                    [Validation(Required=false)]
                    public int? Interval { get; set; }

                    /// <summary>
                    /// <para>The interval unit.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MINUTE</para>
                    /// </summary>
                    [NameInMap("IntervalUnit")]
                    [Validation(Required=false)]
                    public string IntervalUnit { get; set; }

                    /// <summary>
                    /// <para>The schedule period to which the interval belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DAY_INTERVAL</para>
                    /// </summary>
                    [NameInMap("SchedulePeriod")]
                    [Validation(Required=false)]
                    public string SchedulePeriod { get; set; }

                    /// <summary>
                    /// <para>The start time of the effective period.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>00:00</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                }

                /// <summary>
                /// <para>The creation time. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1704153600000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <para>The modification time. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1709516800000</para>
                /// </summary>
                [NameInMap("GmtModify")]
                [Validation(Required=false)]
                public long? GmtModify { get; set; }

                /// <summary>
                /// <para>Specifies whether the schedule template is referenced by a node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("HasReference")]
                [Validation(Required=false)]
                public bool? HasReference { get; set; }

                /// <summary>
                /// <para>The ID of the modifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30001012</para>
                /// </summary>
                [NameInMap("ModifierId")]
                [Validation(Required=false)]
                public string ModifierId { get; set; }

                /// <summary>
                /// <para>The name of the modifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Li Si</para>
                /// </summary>
                [NameInMap("ModifierName")]
                [Validation(Required=false)]
                public string ModifierName { get; set; }

                /// <summary>
                /// <para>The schedule interval type. Valid values: YEARLY, MONTHLY, WEEKLY, DAILY, HOURLY, and MINUTELY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DAILY</para>
                /// </summary>
                [NameInMap("ScheduleIntervalType")]
                [Validation(Required=false)]
                public string ScheduleIntervalType { get; set; }

                /// <summary>
                /// <para>The description of the schedule template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Scheduled at 1:00 AM on weekdays</para>
                /// </summary>
                [NameInMap("ScheduleTemplateDesc")]
                [Validation(Required=false)]
                public string ScheduleTemplateDesc { get; set; }

                /// <summary>
                /// <para>The ID of the schedule template, which is used to bind a schedule template when updating a node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("ScheduleTemplateId")]
                [Validation(Required=false)]
                public long? ScheduleTemplateId { get; set; }

                /// <summary>
                /// <para>The name of the schedule template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1:00 AM every day</para>
                /// </summary>
                [NameInMap("ScheduleTemplateName")]
                [Validation(Required=false)]
                public string ScheduleTemplateName { get; set; }

                /// <summary>
                /// <para>The templatetype. Valid values: BASE_SCHEDULE_TEMPLATE: basic scheduling template, CONDITION_SCHEDULE_TEMPLATE: conditional scheduling template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BASE_SCHEDULE_TEMPLATE</para>
                /// </summary>
                [NameInMap("ScheduleTemplateType")]
                [Validation(Required=false)]
                public string ScheduleTemplateType { get; set; }

                /// <summary>
                /// <para>The schedule type. Valid values: normal scheduling, dry run scheduling, and paused scheduling.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ScheduleType")]
                [Validation(Required=false)]
                public int? ScheduleType { get; set; }

                /// <summary>
                /// <para>The ID of the tenant to which the schedule template belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30001011</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public long? TenantId { get; set; }

                /// <summary>
                /// <para>The ID of the creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30001011</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The name of the creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Zhang San</para>
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

                /// <summary>
                /// <para>The end date of the effective period, in the yyyy-MM-dd format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9999-01-01</para>
                /// </summary>
                [NameInMap("ValidEndDate")]
                [Validation(Required=false)]
                public string ValidEndDate { get; set; }

                /// <summary>
                /// <para>The start date of the effective period, in the yyyy-MM-dd format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-01-01</para>
                /// </summary>
                [NameInMap("ValidStartDate")]
                [Validation(Required=false)]
                public string ValidStartDate { get; set; }

            }

        }

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
        /// <para>The ID of the request.</para>
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
