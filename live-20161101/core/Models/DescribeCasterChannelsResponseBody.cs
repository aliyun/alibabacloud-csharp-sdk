// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeCasterChannelsResponseBody : TeaModel {
        /// <summary>
        /// <para>The channels.</para>
        /// </summary>
        [NameInMap("Channels")]
        [Validation(Required=false)]
        public DescribeCasterChannelsResponseBodyChannels Channels { get; set; }
        public class DescribeCasterChannelsResponseBodyChannels : TeaModel {
            [NameInMap("Channel")]
            [Validation(Required=false)]
            public List<DescribeCasterChannelsResponseBodyChannelsChannel> Channel { get; set; }
            public class DescribeCasterChannelsResponseBodyChannelsChannel : TeaModel {
                /// <summary>
                /// <para>The ID of the channel.</para>
                /// <para>The layout references the channel ID when the channel is enabled. You can specify up to one video resource for the channel. The value of this parameter must be in the RV[Number] format, such as RV01 and RV12.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RV01</para>
                /// </summary>
                [NameInMap("ChannelId")]
                [Validation(Required=false)]
                public string ChannelId { get; set; }

                /// <summary>
                /// <para>The face retouching effect. Valid values: 0 (all effects), 1 (skin smoothing), 2 (skin whitening), 3 (dark circles removal), and 4 (nasolabial folds removal).</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("FaceBeauty")]
                [Validation(Required=false)]
                public string FaceBeauty { get; set; }

                /// <summary>
                /// <para>The ID of the video resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>87642866-281E-4AEA-9582-B124879****</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The URL in the Real-Time Messaging Protocol (RTMP) format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rtmp://demo.aliyundoc.com/caster/rtmperf?auth_key=****</para>
                /// </summary>
                [NameInMap("RtmpUrl")]
                [Validation(Required=false)]
                public string RtmpUrl { get; set; }

                /// <summary>
                /// <para>The URL of the output content in the channel.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://demo.aliyundoc.com/caster/streamwsx.flv?auth_key=YYYYY">http://demo.aliyundoc.com/caster/streamwsx.flv?auth_key=YYYYY</a></para>
                /// </summary>
                [NameInMap("StreamUrl")]
                [Validation(Required=false)]
                public string StreamUrl { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>83C52866-281E-4AEA-9582-B124********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of channels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
