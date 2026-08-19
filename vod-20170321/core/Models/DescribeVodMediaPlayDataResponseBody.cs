// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodMediaPlayDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The list of returned data.</para>
        /// </summary>
        [NameInMap("QoeInfoList")]
        [Validation(Required=false)]
        public List<DescribeVodMediaPlayDataResponseBodyQoeInfoList> QoeInfoList { get; set; }
        public class DescribeVodMediaPlayDataResponseBodyQoeInfoList : TeaModel {
            /// <summary>
            /// <para>The number of unique visitors for the audio or video file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("DAU")]
            [Validation(Required=false)]
            public float? DAU { get; set; }

            /// <summary>
            /// <para>The media ID, which is the audio or video ID (VideoId).</para>
            /// 
            /// <b>Example:</b>
            /// <para>9ae2af636ca6c10412f44891fc****</para>
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// <para>The total play duration for the audio or video file. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2400</para>
            /// </summary>
            [NameInMap("PlayDuration")]
            [Validation(Required=false)]
            public float? PlayDuration { get; set; }

            /// <summary>
            /// <para>The average play duration per user for the audio or video file. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("PlayDurationPerUv")]
            [Validation(Required=false)]
            public float? PlayDurationPerUv { get; set; }

            /// <summary>
            /// <para>The average number of plays per user for the audio or video file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("PlayPerVv")]
            [Validation(Required=false)]
            public float? PlayPerVv { get; set; }

            /// <summary>
            /// <para>The total number of plays for the audio or video file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PlaySuccessVv")]
            [Validation(Required=false)]
            public float? PlaySuccessVv { get; set; }

            /// <summary>
            /// <para>The duration of the audio or video file. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>246</para>
            /// </summary>
            [NameInMap("VideoDuration")]
            [Validation(Required=false)]
            public float? VideoDuration { get; set; }

            /// <summary>
            /// <para>The title of the audio or video file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba Cloud VOD video title</para>
            /// </summary>
            [NameInMap("VideoTitle")]
            [Validation(Required=false)]
            public string VideoTitle { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4AF6-D7393642CA58****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
