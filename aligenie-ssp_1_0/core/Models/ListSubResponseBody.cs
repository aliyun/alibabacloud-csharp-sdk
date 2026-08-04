// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ListSubResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>Additional information</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>0D0C09C2-ADC1-198B-964D-24F4FAD967DB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Result</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListSubResponseBodyResult Result { get; set; }
        public class ListSubResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Subscription list</para>
            /// </summary>
            [NameInMap("DataList")]
            [Validation(Required=false)]
            public List<ListSubResponseBodyResultDataList> DataList { get; set; }
            public class ListSubResponseBodyResultDataList : TeaModel {
                /// <summary>
                /// <para>Album ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>51999575</para>
                /// </summary>
                [NameInMap("AlbumId")]
                [Validation(Required=false)]
                public string AlbumId { get; set; }

                /// <summary>
                /// <para>Album thumbnail</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://ailabs.alibabausercontent.com/images/8838/1600839452498.jpg">https://ailabs.alibabausercontent.com/images/8838/1600839452498.jpg</a></para>
                /// </summary>
                [NameInMap("CoverUrl")]
                [Validation(Required=false)]
                public string CoverUrl { get; set; }

                /// <summary>
                /// <para>Daily study quantity</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("DailyStudyCnt")]
                [Validation(Required=false)]
                public int? DailyStudyCnt { get; set; }

                /// <summary>
                /// <para>Device ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>5874DBCCA3038FAA1A70A8060F07F26D</para>
                /// </summary>
                [NameInMap("DeviceId")]
                [Validation(Required=false)]
                public string DeviceId { get; set; }

                /// <summary>
                /// <para>Subscription record ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Playback mode</para>
                /// 
                /// <b>Example:</b>
                /// <para>sequence</para>
                /// </summary>
                [NameInMap("PlayMode")]
                [Validation(Required=false)]
                public string PlayMode { get; set; }

                /// <summary>
                /// <para>Schedule information</para>
                /// </summary>
                [NameInMap("ScheduleInfo")]
                [Validation(Required=false)]
                public ListSubResponseBodyResultDataListScheduleInfo ScheduleInfo { get; set; }
                public class ListSubResponseBodyResultDataListScheduleInfo : TeaModel {
                    /// <summary>
                    /// <para>Trigger epoch</para>
                    /// </summary>
                    [NameInMap("DaysOfWeek")]
                    [Validation(Required=false)]
                    public List<int?> DaysOfWeek { get; set; }

                    /// <summary>
                    /// <para>Trigger hour</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12</para>
                    /// </summary>
                    [NameInMap("Hour")]
                    [Validation(Required=false)]
                    public int? Hour { get; set; }

                    /// <summary>
                    /// <para>Trigger minute</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>23</para>
                    /// </summary>
                    [NameInMap("Minute")]
                    [Validation(Required=false)]
                    public int? Minute { get; set; }

                }

                /// <summary>
                /// <para>Album title</para>
                /// 
                /// <b>Example:</b>
                /// <para>小科学家探索</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>User ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>1152893538998276761</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

            }

            /// <summary>
            /// <para>Is there a next page</para>
            /// </summary>
            [NameInMap("HasNext")]
            [Validation(Required=false)]
            public bool? HasNext { get; set; }

            /// <summary>
            /// <para>Total number of data entries</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            /// <summary>
            /// <para>Total number of pages</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalPageCount")]
            [Validation(Required=false)]
            public int? TotalPageCount { get; set; }

        }

    }

}
