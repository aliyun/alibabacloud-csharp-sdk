// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamDelayConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The latency of FLV-based playback.</para>
        /// </summary>
        [NameInMap("LiveStreamFlvDelayConfig")]
        [Validation(Required=false)]
        public DescribeLiveStreamDelayConfigResponseBodyLiveStreamFlvDelayConfig LiveStreamFlvDelayConfig { get; set; }
        public class DescribeLiveStreamDelayConfigResponseBodyLiveStreamFlvDelayConfig : TeaModel {
            /// <summary>
            /// <para>The playback latency. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Delay")]
            [Validation(Required=false)]
            public int? Delay { get; set; }

            /// <summary>
            /// <para>The latency level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>short</b>: The latency is less than or equal to 4 seconds.</description></item>
            /// <item><description><b>medium</b>: The latency is greater than 4 seconds, and less than or equal to 8 seconds.</description></item>
            /// <item><description><b>long</b>: The latency is greater than 8 seconds.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>medium</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

        }

        /// <summary>
        /// <para>The latency of HLS-based playback.</para>
        /// </summary>
        [NameInMap("LiveStreamHlsDelayConfig")]
        [Validation(Required=false)]
        public DescribeLiveStreamDelayConfigResponseBodyLiveStreamHlsDelayConfig LiveStreamHlsDelayConfig { get; set; }
        public class DescribeLiveStreamDelayConfigResponseBodyLiveStreamHlsDelayConfig : TeaModel {
            /// <summary>
            /// <para>The playback latency. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Delay")]
            [Validation(Required=false)]
            public int? Delay { get; set; }

            /// <summary>
            /// <para>The latency level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>short</b>: The latency is less than or equal to 4 seconds.</description></item>
            /// <item><description><b>medium</b>: The latency is greater than 4 seconds, and less than or equal to 8 seconds.</description></item>
            /// <item><description><b>long</b>: The latency is greater than 8 seconds.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>short</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

        }

        /// <summary>
        /// <para>The latency of RTMP-based playback.</para>
        /// </summary>
        [NameInMap("LiveStreamRtmpDelayConfig")]
        [Validation(Required=false)]
        public DescribeLiveStreamDelayConfigResponseBodyLiveStreamRtmpDelayConfig LiveStreamRtmpDelayConfig { get; set; }
        public class DescribeLiveStreamDelayConfigResponseBodyLiveStreamRtmpDelayConfig : TeaModel {
            /// <summary>
            /// <para>The playback latency. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Delay")]
            [Validation(Required=false)]
            public int? Delay { get; set; }

            /// <summary>
            /// <para>The latency level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>short</b>: The latency is less than or equal to 4 seconds.</description></item>
            /// <item><description><b>medium</b>: The latency is greater than 4 seconds, and less than or equal to 8 seconds.</description></item>
            /// <item><description><b>long</b>: The latency is greater than 8 seconds.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>short</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>785C9CB0-EB8A-4912-BBF2-966BEFD32DC3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
