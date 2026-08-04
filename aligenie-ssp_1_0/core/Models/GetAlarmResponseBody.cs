// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class GetAlarmResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code returned by the alarm service</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>error message</para>
        /// 
        /// <b>Example:</b>
        /// <para>id为空</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>43<em><b>28C-A810-5</b></em>-8747-EC226A086881</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Alarm details</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetAlarmResponseBodyResult Result { get; set; }
        public class GetAlarmResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Alarm ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567</para>
            /// </summary>
            [NameInMap("AlarmId")]
            [Validation(Required=false)]
            public long? AlarmId { get; set; }

            /// <summary>
            /// <para>Ringtone Information</para>
            /// </summary>
            [NameInMap("MusicInfo")]
            [Validation(Required=false)]
            public GetAlarmResponseBodyResultMusicInfo MusicInfo { get; set; }
            public class GetAlarmResponseBodyResultMusicInfo : TeaModel {
                /// <summary>
                /// <para>Ringtone ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MusicId")]
                [Validation(Required=false)]
                public long? MusicId { get; set; }

                /// <summary>
                /// <para>Ringtone Name</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx铃声</para>
                /// </summary>
                [NameInMap("MusicName")]
                [Validation(Required=false)]
                public string MusicName { get; set; }

                /// <summary>
                /// <para>Ringtone Category ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MusicType")]
                [Validation(Required=false)]
                public long? MusicType { get; set; }

                /// <summary>
                /// <para>Ringtone Category Name</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx音乐</para>
                /// </summary>
                [NameInMap("MusicTypeName")]
                [Validation(Required=false)]
                public string MusicTypeName { get; set; }

                /// <summary>
                /// <para>Ringtone URL</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://xx">http://xx</a></para>
                /// </summary>
                [NameInMap("MusicUrl")]
                [Validation(Required=false)]
                public string MusicUrl { get; set; }

            }

            /// <summary>
            /// <para>Schedule Information</para>
            /// </summary>
            [NameInMap("ScheduleInfo")]
            [Validation(Required=false)]
            public GetAlarmResponseBodyResultScheduleInfo ScheduleInfo { get; set; }
            public class GetAlarmResponseBodyResultScheduleInfo : TeaModel {
                /// <summary>
                /// <para>One-time: This property is active when the loop type is ONCE.</para>
                /// </summary>
                [NameInMap("Once")]
                [Validation(Required=false)]
                public GetAlarmResponseBodyResultScheduleInfoOnce Once { get; set; }
                public class GetAlarmResponseBodyResultScheduleInfoOnce : TeaModel {
                    /// <summary>
                    /// <para>Trigger time: Day</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>29</para>
                    /// </summary>
                    [NameInMap("Day")]
                    [Validation(Required=false)]
                    public int? Day { get; set; }

                    /// <summary>
                    /// <para>Trigger Time: Hour</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Hour")]
                    [Validation(Required=false)]
                    public int? Hour { get; set; }

                    /// <summary>
                    /// <para>Trigger Time: Minute</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Minute")]
                    [Validation(Required=false)]
                    public int? Minute { get; set; }

                    /// <summary>
                    /// <para>Trigger Time: Month</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7</para>
                    /// </summary>
                    [NameInMap("Month")]
                    [Validation(Required=false)]
                    public int? Month { get; set; }

                    /// <summary>
                    /// <para>Trigger Time: Year</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2022</para>
                    /// </summary>
                    [NameInMap("Year")]
                    [Validation(Required=false)]
                    public int? Year { get; set; }

                }

                /// <summary>
                /// <para>Statutory working day: This property is active when the loop Type is STATUTORYWORKINGDAY.</para>
                /// </summary>
                [NameInMap("StatutoryWorkingDay")]
                [Validation(Required=false)]
                public GetAlarmResponseBodyResultScheduleInfoStatutoryWorkingDay StatutoryWorkingDay { get; set; }
                public class GetAlarmResponseBodyResultScheduleInfoStatutoryWorkingDay : TeaModel {
                    /// <summary>
                    /// <para>Trigger Time: Hour</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Hour")]
                    [Validation(Required=false)]
                    public int? Hour { get; set; }

                    /// <summary>
                    /// <para>Trigger Time: Minute</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Minute")]
                    [Validation(Required=false)]
                    public int? Minute { get; set; }

                }

                /// <summary>
                /// <para>Schedule Type / Loop Type: ONCE -&gt; One-time, WEEKLY -&gt; Weekly loop, STATUTORYWORKINGDAY -&gt; Statutory working day</para>
                /// 
                /// <b>Example:</b>
                /// <para>ONCE</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>Weekly loop: This property is active when the loop Type is WEEKLY.</para>
                /// </summary>
                [NameInMap("Weekly")]
                [Validation(Required=false)]
                public GetAlarmResponseBodyResultScheduleInfoWeekly Weekly { get; set; }
                public class GetAlarmResponseBodyResultScheduleInfoWeekly : TeaModel {
                    /// <summary>
                    /// <para>Collection of days of the week to trigger: Numeric values between 1 and 7, where each number corresponds to a specific day of the week. If triggered every day, include all numbers.</para>
                    /// </summary>
                    [NameInMap("DaysOfWeek")]
                    [Validation(Required=false)]
                    public List<int?> DaysOfWeek { get; set; }

                    /// <summary>
                    /// <para>Trigger time: Hour</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Hour")]
                    [Validation(Required=false)]
                    public int? Hour { get; set; }

                    /// <summary>
                    /// <para>Trigger time: Minute</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Minute")]
                    [Validation(Required=false)]
                    public int? Minute { get; set; }

                }

            }

            /// <summary>
            /// <para>Chinese description of the loop type</para>
            /// 
            /// <b>Example:</b>
            /// <para>单次</para>
            /// </summary>
            [NameInMap("ScheduleTypeDesc")]
            [Validation(Required=false)]
            public string ScheduleTypeDesc { get; set; }

            /// <summary>
            /// <para>status: 0 Normal, 1 deleted, 2 shutdown</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>Trigger date description (one-time)</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-29</para>
            /// </summary>
            [NameInMap("TriggerDateDesc")]
            [Validation(Required=false)]
            public string TriggerDateDesc { get; set; }

            /// <summary>
            /// <para>Trigger time description</para>
            /// 
            /// <b>Example:</b>
            /// <para>10:00</para>
            /// </summary>
            [NameInMap("TriggerTimeDesc")]
            [Validation(Required=false)]
            public string TriggerTimeDesc { get; set; }

            /// <summary>
            /// <para>Ringtone volume</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("Volume")]
            [Validation(Required=false)]
            public int? Volume { get; set; }

        }

    }

}
