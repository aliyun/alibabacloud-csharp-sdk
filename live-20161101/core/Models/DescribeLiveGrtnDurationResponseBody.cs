// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveGrtnDurationResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4B460F8B-993C-4F48-B98A-910811DEBFEB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the co-streaming usage data.</para>
        /// </summary>
        [NameInMap("StreamDetailData")]
        [Validation(Required=false)]
        public DescribeLiveGrtnDurationResponseBodyStreamDetailData StreamDetailData { get; set; }
        public class DescribeLiveGrtnDurationResponseBodyStreamDetailData : TeaModel {
            [NameInMap("StreamData")]
            [Validation(Required=false)]
            public List<DescribeLiveGrtnDurationResponseBodyStreamDetailDataStreamData> StreamData { get; set; }
            public class DescribeLiveGrtnDurationResponseBodyStreamDetailDataStreamData : TeaModel {
                /// <summary>
                /// <para>The ID of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4346289a-a790-4869-9e23-22766d5e****</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The co-streaming duration. Unit: minutes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public long? Duration { get; set; }

                /// <summary>
                /// <para>The media specification. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: audio-only. This is a basic specification.</description></item>
                /// <item><description>480P: standard definition (SD). The video resolution is 640 × 480 or lower.</description></item>
                /// <item><description>720P: high definition (HD). The video resolution is 1280 × 720 or lower.</description></item>
                /// <item><description>1080P: full HD. The video resolution is 1920 × 1080 or lower.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>480P</para>
                /// </summary>
                [NameInMap("MediaProfile")]
                [Validation(Required=false)]
                public string MediaProfile { get; set; }

                /// <summary>
                /// <para>The media type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>audio</description></item>
                /// <item><description>video</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>audio</para>
                /// </summary>
                [NameInMap("MediaType")]
                [Validation(Required=false)]
                public string MediaType { get; set; }

                /// <summary>
                /// <para>The timestamp of the returned data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-12-10T20:00:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

    }

}
