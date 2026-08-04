// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ListSubAlbumResponseBody : TeaModel {
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
        /// <para>CB13B8D7-37FB-1B3E-8EB9-65BB413267E1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Result</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListSubAlbumResponseBodyResult Result { get; set; }
        public class ListSubAlbumResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Album List</para>
            /// </summary>
            [NameInMap("DataList")]
            [Validation(Required=false)]
            public List<ListSubAlbumResponseBodyResultDataList> DataList { get; set; }
            public class ListSubAlbumResponseBodyResultDataList : TeaModel {
                /// <summary>
                /// <para>Album ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>4476001</para>
                /// </summary>
                [NameInMap("AlbumId")]
                [Validation(Required=false)]
                public string AlbumId { get; set; }

                /// <summary>
                /// <para>Album category ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>80011</para>
                /// </summary>
                [NameInMap("CategoryId")]
                [Validation(Required=false)]
                public int? CategoryId { get; set; }

                /// <summary>
                /// <para>Album thumbnail</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://ailabs.alibabausercontent.com/images/17825/jknoamc2.jpg">https://ailabs.alibabausercontent.com/images/17825/jknoamc2.jpg</a></para>
                /// </summary>
                [NameInMap("CoverUrl")]
                [Validation(Required=false)]
                public string CoverUrl { get; set; }

                /// <summary>
                /// <para>Record ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Is subscribed</para>
                /// </summary>
                [NameInMap("IsAdded")]
                [Validation(Required=false)]
                public bool? IsAdded { get; set; }

                /// <summary>
                /// <para>Schedule information</para>
                /// </summary>
                [NameInMap("ScheduleInfo")]
                [Validation(Required=false)]
                public ListSubAlbumResponseBodyResultDataListScheduleInfo ScheduleInfo { get; set; }
                public class ListSubAlbumResponseBodyResultDataListScheduleInfo : TeaModel {
                    /// <summary>
                    /// <para>trigger epoch</para>
                    /// </summary>
                    [NameInMap("DaysOfWeek")]
                    [Validation(Required=false)]
                    public List<int?> DaysOfWeek { get; set; }

                    /// <summary>
                    /// <para>trigger hour</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12</para>
                    /// </summary>
                    [NameInMap("Hour")]
                    [Validation(Required=false)]
                    public int? Hour { get; set; }

                    /// <summary>
                    /// <para>trigger minute</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>23</para>
                    /// </summary>
                    [NameInMap("Minute")]
                    [Validation(Required=false)]
                    public int? Minute { get; set; }

                    /// <summary>
                    /// <para>scheduled task ID</para>
                    /// </summary>
                    [NameInMap("ScheduleId")]
                    [Validation(Required=false)]
                    public long? ScheduleId { get; set; }

                }

                /// <summary>
                /// <para>Sorting</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public long? Sequence { get; set; }

                /// <summary>
                /// <para>Album title</para>
                /// 
                /// <b>Example:</b>
                /// <para>睡前故事</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>Total number of episodes</para>
                /// 
                /// <b>Example:</b>
                /// <para>23</para>
                /// </summary>
                [NameInMap("TotalEpisode")]
                [Validation(Required=false)]
                public int? TotalEpisode { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether there is a next page.</para>
            /// </summary>
            [NameInMap("HasNext")]
            [Validation(Required=false)]
            public bool? HasNext { get; set; }

            /// <summary>
            /// <para>total number of entries</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

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
