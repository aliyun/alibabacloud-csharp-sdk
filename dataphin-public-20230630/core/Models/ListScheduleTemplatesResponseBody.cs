// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListScheduleTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("ListScheduleTemplatesResponse")]
        [Validation(Required=false)]
        public ListScheduleTemplatesResponseBodyListScheduleTemplatesResponse ListScheduleTemplatesResponse { get; set; }
        public class ListScheduleTemplatesResponseBodyListScheduleTemplatesResponse : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("ResultData")]
            [Validation(Required=false)]
            public List<ListScheduleTemplatesResponseBodyListScheduleTemplatesResponseResultData> ResultData { get; set; }
            public class ListScheduleTemplatesResponseBodyListScheduleTemplatesResponseResultData : TeaModel {
                [NameInMap("ConditionScheduleParamList")]
                [Validation(Required=false)]
                public List<ListScheduleTemplatesResponseBodyListScheduleTemplatesResponseResultDataConditionScheduleParamList> ConditionScheduleParamList { get; set; }
                public class ListScheduleTemplatesResponseBodyListScheduleTemplatesResponseResultDataConditionScheduleParamList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>失败重跑条件</para>
                    /// </summary>
                    [NameInMap("ConditionName")]
                    [Validation(Required=false)]
                    public string ConditionName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0 30 * * * ?</para>
                    /// </summary>
                    [NameInMap("CronExpression")]
                    [Validation(Required=false)]
                    public string CronExpression { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Enable")]
                    [Validation(Required=false)]
                    public bool? Enable { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("FollowScheduleParam")]
                    [Validation(Required=false)]
                    public bool? FollowScheduleParam { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("NodeStatus")]
                    [Validation(Required=false)]
                    public int? NodeStatus { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>{&quot;type&quot;:&quot;EXPRESSION_GROUP&quot;,&quot;operator&quot;:&quot;or&quot;}</para>
                    /// </summary>
                    [NameInMap("ScheduleConditionJson")]
                    [Validation(Required=false)]
                    public string ScheduleConditionJson { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>00:30</para>
                    /// </summary>
                    [NameInMap("ScheduleTime")]
                    [Validation(Required=false)]
                    public string ScheduleTime { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0 0 1 * * ?</para>
                /// </summary>
                [NameInMap("CronExpression")]
                [Validation(Required=false)]
                public string CronExpression { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("CustomCronExpression")]
                [Validation(Required=false)]
                public bool? CustomCronExpression { get; set; }

                [NameInMap("CustomIntervalConfig")]
                [Validation(Required=false)]
                public ListScheduleTemplatesResponseBodyListScheduleTemplatesResponseResultDataCustomIntervalConfig CustomIntervalConfig { get; set; }
                public class ListScheduleTemplatesResponseBodyListScheduleTemplatesResponseResultDataCustomIntervalConfig : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>23:59</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("Interval")]
                    [Validation(Required=false)]
                    public int? Interval { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>MINUTE</para>
                    /// </summary>
                    [NameInMap("IntervalUnit")]
                    [Validation(Required=false)]
                    public string IntervalUnit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>DAY_INTERVAL</para>
                    /// </summary>
                    [NameInMap("SchedulePeriod")]
                    [Validation(Required=false)]
                    public string SchedulePeriod { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>00:00</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CUSTOM_TIME_PERIOD</para>
                /// </summary>
                [NameInMap("CustomIntervalConfigType")]
                [Validation(Required=false)]
                public string CustomIntervalConfigType { get; set; }

                [NameInMap("CustomIntervalConfigs")]
                [Validation(Required=false)]
                public List<ListScheduleTemplatesResponseBodyListScheduleTemplatesResponseResultDataCustomIntervalConfigs> CustomIntervalConfigs { get; set; }
                public class ListScheduleTemplatesResponseBodyListScheduleTemplatesResponseResultDataCustomIntervalConfigs : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>23:59</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("Interval")]
                    [Validation(Required=false)]
                    public int? Interval { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>MINUTE</para>
                    /// </summary>
                    [NameInMap("IntervalUnit")]
                    [Validation(Required=false)]
                    public string IntervalUnit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>DAY_INTERVAL</para>
                    /// </summary>
                    [NameInMap("SchedulePeriod")]
                    [Validation(Required=false)]
                    public string SchedulePeriod { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>00:00</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1704153600000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1709516800000</para>
                /// </summary>
                [NameInMap("GmtModify")]
                [Validation(Required=false)]
                public long? GmtModify { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("HasReference")]
                [Validation(Required=false)]
                public bool? HasReference { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>30001012</para>
                /// </summary>
                [NameInMap("ModifierId")]
                [Validation(Required=false)]
                public string ModifierId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>李四</para>
                /// </summary>
                [NameInMap("ModifierName")]
                [Validation(Required=false)]
                public string ModifierName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DAILY</para>
                /// </summary>
                [NameInMap("ScheduleIntervalType")]
                [Validation(Required=false)]
                public string ScheduleIntervalType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>工作日每天凌晨1点调度</para>
                /// </summary>
                [NameInMap("ScheduleTemplateDesc")]
                [Validation(Required=false)]
                public string ScheduleTemplateDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("ScheduleTemplateId")]
                [Validation(Required=false)]
                public long? ScheduleTemplateId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>每天凌晨1点</para>
                /// </summary>
                [NameInMap("ScheduleTemplateName")]
                [Validation(Required=false)]
                public string ScheduleTemplateName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>BASE_SCHEDULE_TEMPLATE</para>
                /// </summary>
                [NameInMap("ScheduleTemplateType")]
                [Validation(Required=false)]
                public string ScheduleTemplateType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ScheduleType")]
                [Validation(Required=false)]
                public int? ScheduleType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>30001011</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public long? TenantId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>30001011</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>9999-01-01</para>
                /// </summary>
                [NameInMap("ValidEndDate")]
                [Validation(Required=false)]
                public string ValidEndDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-01-01</para>
                /// </summary>
                [NameInMap("ValidStartDate")]
                [Validation(Required=false)]
                public string ValidStartDate { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
