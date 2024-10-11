// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribePlayVideoStatisResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A92D3600-A3E7-43D6-****-B6E3B4A1FE6B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The daily playback statistics on the video.</para>
        /// </summary>
        [NameInMap("VideoPlayStatisDetails")]
        [Validation(Required=false)]
        public DescribePlayVideoStatisResponseBodyVideoPlayStatisDetails VideoPlayStatisDetails { get; set; }
        public class DescribePlayVideoStatisResponseBodyVideoPlayStatisDetails : TeaModel {
            [NameInMap("VideoPlayStatisDetail")]
            [Validation(Required=false)]
            public List<DescribePlayVideoStatisResponseBodyVideoPlayStatisDetailsVideoPlayStatisDetail> VideoPlayStatisDetail { get; set; }
            public class DescribePlayVideoStatisResponseBodyVideoPlayStatisDetailsVideoPlayStatisDetail : TeaModel {
                /// <summary>
                /// <para>The date. The time follows the ISO 8601 standard in the <em>YYYY-MM-DD</em>T<em>hh:mm:ss</em> format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20170120</para>
                /// </summary>
                [NameInMap("Date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                /// <summary>
                /// <para>The total playback duration. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>967277</para>
                /// </summary>
                [NameInMap("PlayDuration")]
                [Validation(Required=false)]
                public string PlayDuration { get; set; }

                /// <summary>
                /// <para>The distribution of the playback duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&lt;=1m:79.2%;&gt;1&lt;=5m:16.7%;&gt;5&lt;=10m:4.2%</para>
                /// </summary>
                [NameInMap("PlayRange")]
                [Validation(Required=false)]
                public string PlayRange { get; set; }

                /// <summary>
                /// <para>The video title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Four streams (one stream encrypted): LD-HLS + SD-MP4 + HD-HLS-encrypted + UHD-MP4</para>
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
                /// <para>24</para>
                /// </summary>
                [NameInMap("VV")]
                [Validation(Required=false)]
                public string VV { get; set; }

            }

        }

    }

}
