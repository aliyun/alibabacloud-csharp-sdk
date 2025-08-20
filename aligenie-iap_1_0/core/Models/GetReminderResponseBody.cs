// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieiap_1_0.Models
{
    public class GetReminderResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>参数不合法。</para>
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public GetReminderResponseBodyModel Model { get; set; }
        public class GetReminderResponseBodyModel : TeaModel {
            [NameInMap("RemindResponses")]
            [Validation(Required=false)]
            public List<GetReminderResponseBodyModelRemindResponses> RemindResponses { get; set; }
            public class GetReminderResponseBodyModelRemindResponses : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>宝宝快去刷牙</para>
                /// </summary>
                [NameInMap("ActionTopic")]
                [Validation(Required=false)]
                public string ActionTopic { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>每天</para>
                /// </summary>
                [NameInMap("DayDesc")]
                [Validation(Required=false)]
                public string DayDesc { get; set; }

                [NameInMap("RecurrenceRule")]
                [Validation(Required=false)]
                public GetReminderResponseBodyModelRemindResponsesRecurrenceRule RecurrenceRule { get; set; }
                public class GetReminderResponseBodyModelRemindResponsesRecurrenceRule : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>27</para>
                    /// </summary>
                    [NameInMap("Day")]
                    [Validation(Required=false)]
                    public int? Day { get; set; }

                    [NameInMap("DaysOfMonth")]
                    [Validation(Required=false)]
                    public List<int?> DaysOfMonth { get; set; }

                    [NameInMap("DaysOfWeek")]
                    [Validation(Required=false)]
                    public List<int?> DaysOfWeek { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1661598000000</para>
                    /// </summary>
                    [NameInMap("EndDateTime")]
                    [Validation(Required=false)]
                    public string EndDateTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>WEEKLY</para>
                    /// </summary>
                    [NameInMap("Freq")]
                    [Validation(Required=false)]
                    public string Freq { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>18</para>
                    /// </summary>
                    [NameInMap("Hour")]
                    [Validation(Required=false)]
                    public int? Hour { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Minute")]
                    [Validation(Required=false)]
                    public int? Minute { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>8</para>
                    /// </summary>
                    [NameInMap("Month")]
                    [Validation(Required=false)]
                    public int? Month { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Second")]
                    [Validation(Required=false)]
                    public int? Second { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1630054800000</para>
                    /// </summary>
                    [NameInMap("StartDateTime")]
                    [Validation(Required=false)]
                    public string StartDateTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2021</para>
                    /// </summary>
                    [NameInMap("Year")]
                    [Validation(Required=false)]
                    public int? Year { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20*****1</para>
                /// </summary>
                [NameInMap("RemindId")]
                [Validation(Required=false)]
                public long? RemindId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1629850800000</para>
                /// </summary>
                [NameInMap("RemindTime")]
                [Validation(Required=false)]
                public string RemindTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RepeatCount")]
                [Validation(Required=false)]
                public int? RepeatCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>周三</para>
                /// </summary>
                [NameInMap("Week")]
                [Validation(Required=false)]
                public string Week { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
