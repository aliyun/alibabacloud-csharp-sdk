// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ListAlarmsResponseBody : TeaModel {
        /// <summary>
        /// <para>status code returned by the alarm service</para>
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
        /// <para>设备账号未关联</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>43<em><b>28C-A810-5</b></em>-8747-EC226A086881</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>collection of alarm list results</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListAlarmsResponseBodyResult Result { get; set; }
        public class ListAlarmsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>current page</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>alarm list</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public List<ListAlarmsResponseBodyResultModel> Model { get; set; }
            public class ListAlarmsResponseBodyResultModel : TeaModel {
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
                /// <para>Music information</para>
                /// </summary>
                [NameInMap("MusicInfo")]
                [Validation(Required=false)]
                public ListAlarmsResponseBodyResultModelMusicInfo MusicInfo { get; set; }
                public class ListAlarmsResponseBodyResultModelMusicInfo : TeaModel {
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
                    /// <para>Music URL</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://xx">http://xx</a></para>
                    /// </summary>
                    [NameInMap("MusicUrl")]
                    [Validation(Required=false)]
                    public string MusicUrl { get; set; }

                }

                /// <summary>
                /// <para>Schedule information</para>
                /// </summary>
                [NameInMap("ScheduleInfo")]
                [Validation(Required=false)]
                public ListAlarmsResponseBodyResultModelScheduleInfo ScheduleInfo { get; set; }
                public class ListAlarmsResponseBodyResultModelScheduleInfo : TeaModel {
                    /// <summary>
                    /// <para>One-time: This property is active when the loop type is ONCE.</para>
                    /// </summary>
                    [NameInMap("Once")]
                    [Validation(Required=false)]
                    public ListAlarmsResponseBodyResultModelScheduleInfoOnce Once { get; set; }
                    public class ListAlarmsResponseBodyResultModelScheduleInfoOnce : TeaModel {
                        /// <summary>
                        /// <para>Trigger time: day</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>29</para>
                        /// </summary>
                        [NameInMap("Day")]
                        [Validation(Required=false)]
                        public int? Day { get; set; }

                        /// <summary>
                        /// <para>Trigger time: hour</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Hour")]
                        [Validation(Required=false)]
                        public int? Hour { get; set; }

                        /// <summary>
                        /// <para>Trigger time: minute</para>
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
                    public ListAlarmsResponseBodyResultModelScheduleInfoStatutoryWorkingDay StatutoryWorkingDay { get; set; }
                    public class ListAlarmsResponseBodyResultModelScheduleInfoStatutoryWorkingDay : TeaModel {
                        /// <summary>
                        /// <para>Trigger time: hour</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Hour")]
                        [Validation(Required=false)]
                        public int? Hour { get; set; }

                        /// <summary>
                        /// <para>Trigger time: minute</para>
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
                    public ListAlarmsResponseBodyResultModelScheduleInfoWeekly Weekly { get; set; }
                    public class ListAlarmsResponseBodyResultModelScheduleInfoWeekly : TeaModel {
                        /// <summary>
                        /// <para>Collection of days of the week to trigger</para>
                        /// </summary>
                        [NameInMap("DaysOfWeek")]
                        [Validation(Required=false)]
                        public List<int?> DaysOfWeek { get; set; }

                        /// <summary>
                        /// <para>Trigger time: hour</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Hour")]
                        [Validation(Required=false)]
                        public int? Hour { get; set; }

                        /// <summary>
                        /// <para>Trigger time: minute</para>
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
                /// <para>Chinese description of loop type</para>
                /// 
                /// <b>Example:</b>
                /// <para>单次</para>
                /// </summary>
                [NameInMap("ScheduleTypeDesc")]
                [Validation(Required=false)]
                public string ScheduleTypeDesc { get; set; }

                /// <summary>
                /// <para>Status: 0 Normal, 1 Deleted, 2 Shutdown</para>
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
                /// <para>Ringtone volume, default 40</para>
                /// 
                /// <b>Example:</b>
                /// <para>40</para>
                /// </summary>
                [NameInMap("Volume")]
                [Validation(Required=false)]
                public int? Volume { get; set; }

            }

            /// <summary>
            /// <para>total number of pages</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageCount")]
            [Validation(Required=false)]
            public int? PageCount { get; set; }

            /// <summary>
            /// <para>number of entries per page: maximum is 100; values exceeding 100 are treated as 100</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>total number of entries</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

    }

}
