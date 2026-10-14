// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ExecutePeriod : TeaModel {
        /// <summary>
        /// <para>The effective days of the week configuration. Used when ValidType is set to Weekly.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Monday&quot;:true,&quot;Tuesday&quot;:true,&quot;Wednesday&quot;:true,&quot;Thursday&quot;:true,&quot;Friday&quot;:true,&quot;Saturday&quot;:false,&quot;Sunday&quot;:false}</para>
        /// </summary>
        [NameInMap("EffectDay")]
        [Validation(Required=false)]
        public ExecutePeriodEffectDay EffectDay { get; set; }
        public class ExecutePeriodEffectDay : TeaModel {
            /// <summary>
            /// <para>Specifies whether the policy takes effect on Friday when ValidType is set to Weekly. Valid values: true and false. A value of true indicates that the policy takes effect. A value of false indicates that the policy does not take effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Friday")]
            [Validation(Required=false)]
            public bool? Friday { get; set; }

            /// <summary>
            /// <para>Specifies whether the policy takes effect on Monday when ValidType is set to Weekly. Valid values: true and false. A value of true indicates that the policy takes effect. A value of false indicates that the policy does not take effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Monday")]
            [Validation(Required=false)]
            public bool? Monday { get; set; }

            /// <summary>
            /// <para>Specifies whether the policy takes effect on Saturday when ValidType is set to Weekly. Valid values: true and false. A value of true indicates that the policy takes effect. A value of false indicates that the policy does not take effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Saturday")]
            [Validation(Required=false)]
            public bool? Saturday { get; set; }

            /// <summary>
            /// <para>Specifies whether the policy takes effect on Sunday when ValidType is set to Weekly. Valid values: true and false. A value of true indicates that the policy takes effect. A value of false indicates that the policy does not take effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Sunday")]
            [Validation(Required=false)]
            public bool? Sunday { get; set; }

            /// <summary>
            /// <para>Specifies whether the policy takes effect on Thursday when ValidType is set to Weekly. Valid values: true and false. A value of true indicates that the policy takes effect. A value of false indicates that the policy does not take effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Thursday")]
            [Validation(Required=false)]
            public bool? Thursday { get; set; }

            /// <summary>
            /// <para>Specifies whether the policy takes effect on Tuesday when ValidType is set to Weekly. Valid values: true and false. A value of true indicates that the policy takes effect. A value of false indicates that the policy does not take effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Tuesday")]
            [Validation(Required=false)]
            public bool? Tuesday { get; set; }

            /// <summary>
            /// <para>Specifies whether the policy takes effect on Wednesday when ValidType is set to Weekly. Valid values: true and false. A value of true indicates that the policy takes effect. A value of false indicates that the policy does not take effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Wednesday")]
            [Validation(Required=false)]
            public bool? Wednesday { get; set; }

        }

        /// <summary>
        /// <para>The daily effective time range. Both Start and End use the 24-hour HH:mm format and are interpreted based on the current system time zone of the server. The time range cannot span across days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Start&quot;:&quot;00:00&quot;,&quot;End&quot;:&quot;23:59&quot;}</para>
        /// </summary>
        [NameInMap("EffectTime")]
        [Validation(Required=false)]
        public ExecutePeriodEffectTime EffectTime { get; set; }
        public class ExecutePeriodEffectTime : TeaModel {
            /// <summary>
            /// <para>The end time of the daily effective time range. It uses the 24-hour HH:mm format and is interpreted based on the current system time zone of the server. It must not be earlier than Start.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23:59</para>
            /// </summary>
            [NameInMap("End")]
            [Validation(Required=false)]
            public string End { get; set; }

            /// <summary>
            /// <para>The start time of the daily effective time range. It uses the 24-hour HH:mm format and is interpreted based on the current system time zone of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:00</para>
            /// </summary>
            [NameInMap("Start")]
            [Validation(Required=false)]
            public string Start { get; set; }

        }

        /// <summary>
        /// <para>The frequency and interval configuration for periodic execution. Frequency and Interval together specify the execution cycle.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Frequency&quot;:&quot;day&quot;,&quot;Interval&quot;:1}</para>
        /// </summary>
        [NameInMap("ScheduleEffect")]
        [Validation(Required=false)]
        public ExecutePeriodScheduleEffect ScheduleEffect { get; set; }
        public class ExecutePeriodScheduleEffect : TeaModel {
            /// <summary>
            /// <para>The frequency unit for periodic execution. It is used together with Interval to specify the execution cycle. For example, a value of day indicates daily execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>day</para>
            /// </summary>
            [NameInMap("Frequency")]
            [Validation(Required=false)]
            public string Frequency { get; set; }

            /// <summary>
            /// <para>The periodic execution interval. When Frequency is set, valid values are 1 to 10000. The unit is determined by Frequency. For example, if Frequency is set to day and Interval is set to 1, the execution interval is one day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public long? Interval { get; set; }

        }

        /// <summary>
        /// <para>The execution cycle mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Once</b>: The single execution mode. Used in combination with ExecuteMode=Once.</description></item>
        /// <item><description><b>Interval</b>: The periodic execution mode based on a specified frequency. Used in combination with ExecuteMode=Schedule.</description></item>
        /// <item><description><b>Weekly</b>: The weekly execution mode where you can select effective days. Used in combination with ExecuteMode=Schedule and EffectDay.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Interval</para>
        /// </summary>
        [NameInMap("ValidType")]
        [Validation(Required=false)]
        public string ValidType { get; set; }

    }

}
