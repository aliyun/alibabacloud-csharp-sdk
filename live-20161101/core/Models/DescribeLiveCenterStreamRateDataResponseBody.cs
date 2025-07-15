// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveCenterStreamRateDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of frame rates and bitrates.</para>
        /// </summary>
        [NameInMap("RateDatas")]
        [Validation(Required=false)]
        public List<DescribeLiveCenterStreamRateDataResponseBodyRateDatas> RateDatas { get; set; }
        public class DescribeLiveCenterStreamRateDataResponseBodyRateDatas : TeaModel {
            /// <summary>
            /// <para>The audio frame rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47</para>
            /// </summary>
            [NameInMap("AudioFps")]
            [Validation(Required=false)]
            public string AudioFps { get; set; }

            /// <summary>
            /// <para>The audio bitrate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>600</para>
            /// </summary>
            [NameInMap("AudioRate")]
            [Validation(Required=false)]
            public string AudioRate { get; set; }

            /// <summary>
            /// <para>The time when the data was collected. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-03-05T18:00:53Z</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            /// <summary>
            /// <para>The video frame rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("VideoFps")]
            [Validation(Required=false)]
            public string VideoFps { get; set; }

            /// <summary>
            /// <para>The video bitrate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1953584</para>
            /// </summary>
            [NameInMap("VideoRate")]
            [Validation(Required=false)]
            public string VideoRate { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B6E125BE-E9B8-1103-8684-A3585CB632F1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
