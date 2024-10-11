// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribePlayTopVideosResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
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
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4B0BCF9F-2FD5-4817-****-7BEBBE3AF90B&quot;</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The daily playback statistics on each top video.</para>
        /// </summary>
        [NameInMap("TopPlayVideos")]
        [Validation(Required=false)]
        public DescribePlayTopVideosResponseBodyTopPlayVideos TopPlayVideos { get; set; }
        public class DescribePlayTopVideosResponseBodyTopPlayVideos : TeaModel {
            [NameInMap("TopPlayVideoStatis")]
            [Validation(Required=false)]
            public List<DescribePlayTopVideosResponseBodyTopPlayVideosTopPlayVideoStatis> TopPlayVideoStatis { get; set; }
            public class DescribePlayTopVideosResponseBodyTopPlayVideosTopPlayVideoStatis : TeaModel {
                /// <summary>
                /// <para>The total playback duration. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4640369</para>
                /// </summary>
                [NameInMap("PlayDuration")]
                [Validation(Required=false)]
                public string PlayDuration { get; set; }

                /// <summary>
                /// <para>The title of the video.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Four streams (two streams encrypted): LD-HLS-encrypted + SD-MP4 + HD-H</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The number of unique visitors.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("UV")]
                [Validation(Required=false)]
                public string UV { get; set; }

                /// <summary>
                /// <para>The number of video views.</para>
                /// 
                /// <b>Example:</b>
                /// <para>107</para>
                /// </summary>
                [NameInMap("VV")]
                [Validation(Required=false)]
                public string VV { get; set; }

                /// <summary>
                /// <para>The ID of the video.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2a8d4cb9ecbb487681473a15****8fda</para>
                /// </summary>
                [NameInMap("VideoId")]
                [Validation(Required=false)]
                public string VideoId { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of entries that were collected in playback statistics on top videos.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public long? TotalNum { get; set; }

    }

}
