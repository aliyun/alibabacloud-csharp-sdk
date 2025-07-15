// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeCasterStreamUrlResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the production studio.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a2b8e671-2fe5-4642-a2ec-bf93880e****</para>
        /// </summary>
        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        /// <summary>
        /// <para>The information about the streams of the production studio.</para>
        /// </summary>
        [NameInMap("CasterStreams")]
        [Validation(Required=false)]
        public DescribeCasterStreamUrlResponseBodyCasterStreams CasterStreams { get; set; }
        public class DescribeCasterStreamUrlResponseBodyCasterStreams : TeaModel {
            [NameInMap("CasterStream")]
            [Validation(Required=false)]
            public List<DescribeCasterStreamUrlResponseBodyCasterStreamsCasterStream> CasterStream { get; set; }
            public class DescribeCasterStreamUrlResponseBodyCasterStreamsCasterStream : TeaModel {
                /// <summary>
                /// <para>Indicates whether the output stream is in preview mode or program mode.</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: indicates that the output videos of the scene are in preview mode.</description></item>
                /// <item><description><b>1</b>: indicates that the output videos of the scene are in program mode.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("OutputType")]
                [Validation(Required=false)]
                public int? OutputType { get; set; }

                /// <summary>
                /// <para>The Real Time Messaging Protocol (RTMP) URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rtmp://live/caster/example.edu</para>
                /// </summary>
                [NameInMap("RtmpUrl")]
                [Validation(Required=false)]
                public string RtmpUrl { get; set; }

                /// <summary>
                /// <para>The ID of the scene.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23ca74e0-aca3-4e7a-8561-9d96f525****</para>
                /// </summary>
                [NameInMap("SceneId")]
                [Validation(Required=false)]
                public string SceneId { get; set; }

                /// <summary>
                /// <para>The information about the stream.</para>
                /// </summary>
                [NameInMap("StreamInfos")]
                [Validation(Required=false)]
                public DescribeCasterStreamUrlResponseBodyCasterStreamsCasterStreamStreamInfos StreamInfos { get; set; }
                public class DescribeCasterStreamUrlResponseBodyCasterStreamsCasterStreamStreamInfos : TeaModel {
                    [NameInMap("StreamInfo")]
                    [Validation(Required=false)]
                    public List<DescribeCasterStreamUrlResponseBodyCasterStreamsCasterStreamStreamInfosStreamInfo> StreamInfo { get; set; }
                    public class DescribeCasterStreamUrlResponseBodyCasterStreamsCasterStreamStreamInfosStreamInfo : TeaModel {
                        /// <summary>
                        /// <para>The streaming URL.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="http://out/caster/example.net">http://out/caster/example.net</a></para>
                        /// </summary>
                        [NameInMap("OutputStreamUrl")]
                        [Validation(Required=false)]
                        public string OutputStreamUrl { get; set; }

                        /// <summary>
                        /// <para>The resolution to which the scene transcodes the stream for playback. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>lsd</b>: standard definition.</description></item>
                        /// <item><description><b>lld</b>: low definition.</description></item>
                        /// <item><description><b>lud</b>: ultra high definition.</description></item>
                        /// <item><description><b>lhd</b>: high definition.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>lld</para>
                        /// </summary>
                        [NameInMap("TranscodeConfig")]
                        [Validation(Required=false)]
                        public string TranscodeConfig { get; set; }

                        /// <summary>
                        /// <para>The format to which the scene transcodes the stream for playback. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>flv</b>.</description></item>
                        /// <item><description><b>rtmp</b>.</description></item>
                        /// <item><description><b>m3u8</b>.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>flv</para>
                        /// </summary>
                        [NameInMap("VideoFormat")]
                        [Validation(Required=false)]
                        public string VideoFormat { get; set; }

                    }

                }

                /// <summary>
                /// <para>The streaming URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://live/caster/example.org">http://live/caster/example.org</a></para>
                /// </summary>
                [NameInMap("StreamUrl")]
                [Validation(Required=false)]
                public string StreamUrl { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of streams that were returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
