// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class StartPlaylistResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the episode list. You can use the ID as a request parameter in the API operation that is used to stop playing the episode list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>445409ec-7eaa-461d-8f29-4bec2eb9****</para>
        /// </summary>
        [NameInMap("ProgramId")]
        [Validation(Required=false)]
        public string ProgramId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5c6a2a0d-f228-4a64-af62-20e91b96****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the live stream.</para>
        /// </summary>
        [NameInMap("StreamInfo")]
        [Validation(Required=false)]
        public StartPlaylistResponseBodyStreamInfo StreamInfo { get; set; }
        public class StartPlaylistResponseBodyStreamInfo : TeaModel {
            /// <summary>
            /// <para>The name of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>liveApp****</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The main streaming domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>The name of the live stream.</para>
            /// 
            /// <b>Example:</b>
            /// <para>liveStream****</para>
            /// </summary>
            [NameInMap("StreamName")]
            [Validation(Required=false)]
            public string StreamName { get; set; }

            /// <summary>
            /// <para>The streaming URLs.</para>
            /// </summary>
            [NameInMap("Streams")]
            [Validation(Required=false)]
            public StartPlaylistResponseBodyStreamInfoStreams Streams { get; set; }
            public class StartPlaylistResponseBodyStreamInfoStreams : TeaModel {
                [NameInMap("Stream")]
                [Validation(Required=false)]
                public List<StartPlaylistResponseBodyStreamInfoStreamsStream> Stream { get; set; }
                public class StartPlaylistResponseBodyStreamInfoStreamsStream : TeaModel {
                    /// <summary>
                    /// <para>The streaming URL in the Flash Video (FLV) format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://aliyundoc.com/caster/liveStream****.flv?auth_key=1612772224-0-0-3632be7cd9907169e8b09e91099c">http://aliyundoc.com/caster/liveStream****.flv?auth_key=1612772224-0-0-3632be7cd9907169e8b09e91099c</a>****</para>
                    /// </summary>
                    [NameInMap("PullFlvUrl")]
                    [Validation(Required=false)]
                    public string PullFlvUrl { get; set; }

                    /// <summary>
                    /// <para>The streaming URL in the Real-Time Messaging Protocol (RTMP) format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rtmp:///aliyundoc.com/caster/liveStream****?auth_key=1612772224-0-0-4404ca59c0246226d49d01f734b1****</para>
                    /// </summary>
                    [NameInMap("PullM3U8Url")]
                    [Validation(Required=false)]
                    public string PullM3U8Url { get; set; }

                    /// <summary>
                    /// <para>The streaming URL in the M3U8 format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://aliyundoc.com/caster/liveStream****.m3u8?auth_key=1612772224-0-0-919a023a127156fe82e3562c3b3b">http://aliyundoc.com/caster/liveStream****.m3u8?auth_key=1612772224-0-0-919a023a127156fe82e3562c3b3b</a>****</para>
                    /// </summary>
                    [NameInMap("PullRtmpUrl")]
                    [Validation(Required=false)]
                    public string PullRtmpUrl { get; set; }

                    /// <summary>
                    /// <para>The video quality of the live stream. Valid values: <b>original</b>: original quality</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>original</para>
                    /// </summary>
                    [NameInMap("Quality")]
                    [Validation(Required=false)]
                    public string Quality { get; set; }

                }

            }

        }

    }

}
