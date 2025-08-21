// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class GetAlarmResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>43<em><b>28C-A810-5</b></em>-8747-EC226A086881</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetAlarmResponseBodyResult Result { get; set; }
        public class GetAlarmResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1234567</para>
            /// </summary>
            [NameInMap("AlarmId")]
            [Validation(Required=false)]
            public long? AlarmId { get; set; }

            [NameInMap("MusicInfo")]
            [Validation(Required=false)]
            public GetAlarmResponseBodyResultMusicInfo MusicInfo { get; set; }
            public class GetAlarmResponseBodyResultMusicInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MusicId")]
                [Validation(Required=false)]
                public long? MusicId { get; set; }

                [NameInMap("MusicName")]
                [Validation(Required=false)]
                public string MusicName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MusicType")]
                [Validation(Required=false)]
                public long? MusicType { get; set; }

                [NameInMap("MusicTypeName")]
                [Validation(Required=false)]
                public string MusicTypeName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://xx">http://xx</a></para>
                /// </summary>
                [NameInMap("MusicUrl")]
                [Validation(Required=false)]
                public string MusicUrl { get; set; }

            }

            [NameInMap("ScheduleInfo")]
            [Validation(Required=false)]
            public GetAlarmResponseBodyResultScheduleInfo ScheduleInfo { get; set; }
            public class GetAlarmResponseBodyResultScheduleInfo : TeaModel {
                [NameInMap("Once")]
                [Validation(Required=false)]
                public GetAlarmResponseBodyResultScheduleInfoOnce Once { get; set; }
                public class GetAlarmResponseBodyResultScheduleInfoOnce : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>29</para>
                    /// </summary>
                    [NameInMap("Day")]
                    [Validation(Required=false)]
                    public int? Day { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
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
                    /// <para>7</para>
                    /// </summary>
                    [NameInMap("Month")]
                    [Validation(Required=false)]
                    public int? Month { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2022</para>
                    /// </summary>
                    [NameInMap("Year")]
                    [Validation(Required=false)]
                    public int? Year { get; set; }

                }

                [NameInMap("StatutoryWorkingDay")]
                [Validation(Required=false)]
                public GetAlarmResponseBodyResultScheduleInfoStatutoryWorkingDay StatutoryWorkingDay { get; set; }
                public class GetAlarmResponseBodyResultScheduleInfoStatutoryWorkingDay : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
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

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ONCE</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Weekly")]
                [Validation(Required=false)]
                public GetAlarmResponseBodyResultScheduleInfoWeekly Weekly { get; set; }
                public class GetAlarmResponseBodyResultScheduleInfoWeekly : TeaModel {
                    [NameInMap("DaysOfWeek")]
                    [Validation(Required=false)]
                    public List<int?> DaysOfWeek { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
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

                }

            }

            [NameInMap("ScheduleTypeDesc")]
            [Validation(Required=false)]
            public string ScheduleTypeDesc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-29</para>
            /// </summary>
            [NameInMap("TriggerDateDesc")]
            [Validation(Required=false)]
            public string TriggerDateDesc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10:00</para>
            /// </summary>
            [NameInMap("TriggerTimeDesc")]
            [Validation(Required=false)]
            public string TriggerTimeDesc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("Volume")]
            [Validation(Required=false)]
            public int? Volume { get; set; }

        }

    }

}
