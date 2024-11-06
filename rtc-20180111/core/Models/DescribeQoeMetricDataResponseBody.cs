// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeQoeMetricDataResponseBody : TeaModel {
        [NameInMap("AudioData")]
        [Validation(Required=false)]
        public List<DescribeQoeMetricDataResponseBodyAudioData> AudioData { get; set; }
        public class DescribeQoeMetricDataResponseBodyAudioData : TeaModel {
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<DescribeQoeMetricDataResponseBodyAudioDataNodes> Nodes { get; set; }
            public class DescribeQoeMetricDataResponseBodyAudioDataNodes : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1548670256</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public string X { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public string Y { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AUDIO</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testuserid</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>231470C1-ACFB-4C9F-844F-4CFE1E3804C5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VideoData")]
        [Validation(Required=false)]
        public List<DescribeQoeMetricDataResponseBodyVideoData> VideoData { get; set; }
        public class DescribeQoeMetricDataResponseBodyVideoData : TeaModel {
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<DescribeQoeMetricDataResponseBodyVideoDataNodes> Nodes { get; set; }
            public class DescribeQoeMetricDataResponseBodyVideoDataNodes : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1548670256</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public string X { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public string Y { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>VIDEO_CAMERA</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testuserid</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
