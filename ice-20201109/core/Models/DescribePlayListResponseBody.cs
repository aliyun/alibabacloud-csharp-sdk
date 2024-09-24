// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DescribePlayListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("PlayList")]
        [Validation(Required=false)]
        public List<DescribePlayListResponseBodyPlayList> PlayList { get; set; }
        public class DescribePlayListResponseBodyPlayList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("FirstFrameDuration")]
            [Validation(Required=false)]
            public string FirstFrameDuration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("PlayDuration")]
            [Validation(Required=false)]
            public string PlayDuration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1675922209572</para>
            /// </summary>
            [NameInMap("PlayTs")]
            [Validation(Required=false)]
            public string PlayTs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vod</para>
            /// </summary>
            [NameInMap("PlayType")]
            [Validation(Required=false)]
            public string PlayType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>91488be2-8381-40c9-8494-e8afe22c4a2d</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>complete</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("StuckDuration")]
            [Validation(Required=false)]
            public string StuckDuration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0b736abf16724820210842673d9543</para>
            /// </summary>
            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("VideoDuration")]
            [Validation(Required=false)]
            public string VideoDuration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>250314203f0171eebff17035d0b20102</para>
            /// </summary>
            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }

        }

        /// <summary>
        /// <para>Id</para>
        /// 
        /// <b>Example:</b>
        /// <para>B960580D-26FA-5547-8AFC-3CDC812DBF27</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>49</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public long? TotalNum { get; set; }

    }

}
