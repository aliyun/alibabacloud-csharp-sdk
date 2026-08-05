// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ListRtcMPUTaskDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The task parameter details. The parameter format is the same as the parameter format used when you call the operation to create a stream mixing task.</para>
        /// </summary>
        [NameInMap("MPUTasks")]
        [Validation(Required=false)]
        public List<ListRtcMPUTaskDetailResponseBodyMPUTasks> MPUTasks { get; set; }
        public class ListRtcMPUTaskDetailResponseBodyMPUTasks : TeaModel {
            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yourAppId</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The channel ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yourChannelId</para>
            /// </summary>
            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

            /// <summary>
            /// <para>The idle timeout period. Unit: seconds.</para>
            /// <remarks>
            /// <para>If this parameter is set, the task is automatically stopped when the task has been idle for a period longer than MaxIdleTime. If this parameter is not set, the task is stopped immediately after the channel is closed.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxIdleTime")]
            [Validation(Required=false)]
            public string MaxIdleTime { get; set; }

            /// <summary>
            /// <para>The stream mixing mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: single-stream relaying without stream mixing or transcoding. Only the original single stream is relayed. You do not need to configure stream mixing and transcoding parameters.</description></item>
            /// <item><description>1 (default): stream mixing, transcoding, and relaying.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MixMode")]
            [Validation(Required=false)]
            public string MixMode { get; set; }

            /// <summary>
            /// <para>The multi-address relaying parameters.</para>
            /// </summary>
            [NameInMap("MultiStreamURL")]
            [Validation(Required=false)]
            public List<ListRtcMPUTaskDetailResponseBodyMPUTasksMultiStreamURL> MultiStreamURL { get; set; }
            public class ListRtcMPUTaskDetailResponseBodyMPUTasksMultiStreamURL : TeaModel {
                /// <summary>
                /// <para>Indicates whether the stream is relayed to Content Delivery Network (CDN). Valid values:</para>
                /// <list type="bullet">
                /// <item><description>false: The stream is relayed to a non-Alibaba Cloud CDN.</description></item>
                /// <item><description>true: The stream is relayed to Content Delivery Network (CDN).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsAliCdn")]
                [Validation(Required=false)]
                public bool? IsAliCdn { get; set; }

                /// <summary>
                /// <para>The live stream ingest URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rtmp://example.com/live/stream****</para>
                /// </summary>
                [NameInMap("URL")]
                [Validation(Required=false)]
                public string URL { get; set; }

            }

            /// <summary>
            /// <para>The region where the requested stream mixing service resides. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CN-Shanghai&lt;props=&quot;china&quot;&gt;<ph> (default)</ph></b>: Shanghai.</description></item>
            /// <item><description><b>AP-Singapore&lt;props=&quot;intl&quot;&gt;<ph> (default)</ph></b>: Singapore.</description></item>
            /// <item><description><b>EMAA-Saudi</b>: Saudi Arabia.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CN-Shanghai</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The SEI configuration parameters.</para>
            /// </summary>
            [NameInMap("SeiParams")]
            [Validation(Required=false)]
            public ListRtcMPUTaskDetailResponseBodyMPUTasksSeiParams SeiParams { get; set; }
            public class ListRtcMPUTaskDetailResponseBodyMPUTasksSeiParams : TeaModel {
                /// <summary>
                /// <para>The layout and volume SEI. If this parameter is empty, the default layout and volume SEI is carried.</para>
                /// </summary>
                [NameInMap("LayoutVolume")]
                [Validation(Required=false)]
                public ListRtcMPUTaskDetailResponseBodyMPUTasksSeiParamsLayoutVolume LayoutVolume { get; set; }
                public class ListRtcMPUTaskDetailResponseBodyMPUTasksSeiParamsLayoutVolume : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to ensure that SEI is carried when sending IDR keyframes. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>0: does not ensure SEI is carried.</description></item>
                    /// <item><description>1: ensures SEI is carried.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("FollowIdr")]
                    [Validation(Required=false)]
                    public string FollowIdr { get; set; }

                    /// <summary>
                    /// <para>The SEI sending interval. Unit: milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Interval")]
                    [Validation(Required=false)]
                    public string Interval { get; set; }

                }

                /// <summary>
                /// <para>The pass-through SEI.</para>
                /// </summary>
                [NameInMap("PassThrough")]
                [Validation(Required=false)]
                public ListRtcMPUTaskDetailResponseBodyMPUTasksSeiParamsPassThrough PassThrough { get; set; }
                public class ListRtcMPUTaskDetailResponseBodyMPUTasksSeiParamsPassThrough : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to ensure that SEI is carried when sending IDR keyframes. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>0: does not ensure SEI is carried.</description></item>
                    /// <item><description>1: ensures SEI is carried.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("FollowIdr")]
                    [Validation(Required=false)]
                    public string FollowIdr { get; set; }

                    /// <summary>
                    /// <para>The SEI sending interval. Unit: milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Interval")]
                    [Validation(Required=false)]
                    public string Interval { get; set; }

                    /// <summary>
                    /// <para>The payload content of the pass-through SEI.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>yourPayloadContent</para>
                    /// </summary>
                    [NameInMap("PayloadContent")]
                    [Validation(Required=false)]
                    public string PayloadContent { get; set; }

                    /// <summary>
                    /// <para>The key value corresponding to the payload content of the pass-through SEI. If not set, the key defaults to udd.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>yourPayloadContentKey</para>
                    /// </summary>
                    [NameInMap("PayloadContentKey")]
                    [Validation(Required=false)]
                    public string PayloadContentKey { get; set; }

                }

                /// <summary>
                /// <para>The custom payload_type of the SEI message. Valid values: 100 to 254. If not set, the SEI payload_type defaults to 5.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("PayloadType")]
                [Validation(Required=false)]
                public string PayloadType { get; set; }

            }

            /// <summary>
            /// <para>The single-stream relaying parameters.</para>
            /// </summary>
            [NameInMap("SingleSubParams")]
            [Validation(Required=false)]
            public ListRtcMPUTaskDetailResponseBodyMPUTasksSingleSubParams SingleSubParams { get; set; }
            public class ListRtcMPUTaskDetailResponseBodyMPUTasksSingleSubParams : TeaModel {
                /// <summary>
                /// <para>The video input stream type in single-stream relaying mode. This parameter is valid only when the stream type is video (StreamType=2). Valid values:</para>
                /// <list type="bullet">
                /// <item><description>camera (default): camera.</description></item>
                /// <item><description>shareScreen: screen sharing.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>camera</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The stream type for relaying in single-stream relaying mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0 (default): relay the original stream.</description></item>
                /// <item><description>1: relay only the audio stream.</description></item>
                /// <item><description>2: relay only the video stream.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("StreamType")]
                [Validation(Required=false)]
                public string StreamType { get; set; }

                /// <summary>
                /// <para>The user ID for relaying. Only one stream can be relayed at a time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yourSubUserId</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The live stream ingest URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rtmp://example.com/live/stream****</para>
            /// </summary>
            [NameInMap("StreamURL")]
            [Validation(Required=false)]
            public string StreamURL { get; set; }

            /// <summary>
            /// <para>The task ID. This ID is the identifier of the stream mixing and relaying task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yourTaskId</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The stream mixing, transcoding, and relaying parameters.</para>
            /// </summary>
            [NameInMap("TranscodeParams")]
            [Validation(Required=false)]
            public ListRtcMPUTaskDetailResponseBodyMPUTasksTranscodeParams TranscodeParams { get; set; }
            public class ListRtcMPUTaskDetailResponseBodyMPUTasksTranscodeParams : TeaModel {
                /// <summary>
                /// <para>The global background image for stream mixing.</para>
                /// </summary>
                [NameInMap("Background")]
                [Validation(Required=false)]
                public ListRtcMPUTaskDetailResponseBodyMPUTasksTranscodeParamsBackground Background { get; set; }
                public class ListRtcMPUTaskDetailResponseBodyMPUTasksTranscodeParamsBackground : TeaModel {
                    /// <summary>
                    /// <para>The display mode for the sub-image output. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>0: scales the image and displays a black background.</description></item>
                    /// <item><description>1 (default): crops the image.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("RenderMode")]
                    [Validation(Required=false)]
                    public string RenderMode { get; set; }

                    /// <summary>
                    /// <para>The URL of the global background image.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>yourImageUrl</para>
                    /// </summary>
                    [NameInMap("URL")]
                    [Validation(Required=false)]
                    public string URL { get; set; }

                }

                /// <summary>
                /// <para>The encoding parameters for the relayed output.</para>
                /// </summary>
                [NameInMap("EncodeParams")]
                [Validation(Required=false)]
                public ListRtcMPUTaskDetailResponseBodyMPUTasksTranscodeParamsEncodeParams EncodeParams { get; set; }
                public class ListRtcMPUTaskDetailResponseBodyMPUTasksTranscodeParamsEncodeParams : TeaModel {
                    /// <summary>
                    /// <para>The audio bitrate. Unit: kbps.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>128</para>
                    /// </summary>
                    [NameInMap("AudioBitrate")]
                    [Validation(Required=false)]
                    public string AudioBitrate { get; set; }

                    /// <summary>
                    /// <para>The number of audio channels. Valid values: 1, 2.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("AudioChannels")]
                    [Validation(Required=false)]
                    public string AudioChannels { get; set; }

                    /// <summary>
                    /// <para>Specifies whether the output is audio-only. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true: audio-only.</description></item>
                    /// <item><description>false (default): not audio-only.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("AudioOnly")]
                    [Validation(Required=false)]
                    public string AudioOnly { get; set; }

                    /// <summary>
                    /// <para>The audio sample rate. Unit: Hz.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>44100</para>
                    /// </summary>
                    [NameInMap("AudioSampleRate")]
                    [Validation(Required=false)]
                    public string AudioSampleRate { get; set; }

                    /// <summary>
                    /// <para>The enhanced encoding parameters in JSON string format. The supported optional configurations include profile and preset.</para>
                    /// <list type="bullet">
                    /// <item><description>profile: the encoding level. When the video encoding format is H.264, the supported values for profile include: &quot;baseline&quot;, &quot;main&quot;, &quot;high&quot;.</description></item>
                    /// <item><description>preset: adjusts the balance between encoding speed and quality. The supported values for preset include: &quot;ultrafast&quot;, &quot;superfast&quot;, &quot;veryfast&quot;, &quot;faster&quot;, &quot;fast&quot;, &quot;medium&quot;, &quot;slow&quot;, &quot;slower&quot;, &quot;veryslow&quot;, &quot;placebo&quot;. Each value represents a strategy for encoding speed versus output video quality, ranging from &quot;ultrafast&quot; (extremely fast, encoding speed prioritized) to &quot;placebo&quot; (pursuing ultimate quality, extremely slow encoding).</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;profile&quot;: &quot;high&quot;, &quot;preset&quot;: &quot;veryfast&quot;}</para>
                    /// </summary>
                    [NameInMap("EnhancedParam")]
                    [Validation(Required=false)]
                    public string EnhancedParam { get; set; }

                    /// <summary>
                    /// <para>The video bitrate. Unit: kbps.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3500</para>
                    /// </summary>
                    [NameInMap("VideoBitrate")]
                    [Validation(Required=false)]
                    public string VideoBitrate { get; set; }

                    /// <summary>
                    /// <para>The video encoding format. Default value: H.264.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>H.264</para>
                    /// </summary>
                    [NameInMap("VideoCodec")]
                    [Validation(Required=false)]
                    public string VideoCodec { get; set; }

                    /// <summary>
                    /// <para>The video frame rate. Unit: fps.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>25</para>
                    /// </summary>
                    [NameInMap("VideoFramerate")]
                    [Validation(Required=false)]
                    public string VideoFramerate { get; set; }

                    /// <summary>
                    /// <para>The video GOP.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("VideoGop")]
                    [Validation(Required=false)]
                    public string VideoGop { get; set; }

                    /// <summary>
                    /// <para>The video height. Unit: px.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("VideoHeight")]
                    [Validation(Required=false)]
                    public string VideoHeight { get; set; }

                    /// <summary>
                    /// <para>The video width. Unit: px.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1920</para>
                    /// </summary>
                    [NameInMap("VideoWidth")]
                    [Validation(Required=false)]
                    public string VideoWidth { get; set; }

                }

                /// <summary>
                /// <para>The video layout information.</para>
                /// <remarks>
                /// <para>For video transcoding, the video layout information includes layout coordinates (X, Y), layout pane dimensions (Width, Height), and stacking order (ZOrder). For audio-only transcoding, no video layout information is included.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("Layout")]
                [Validation(Required=false)]
                public ListRtcMPUTaskDetailResponseBodyMPUTasksTranscodeParamsLayout Layout { get; set; }
                public class ListRtcMPUTaskDetailResponseBodyMPUTasksTranscodeParamsLayout : TeaModel {
                    /// <summary>
                    /// <para>The stream mixing user pane information.</para>
                    /// </summary>
                    [NameInMap("UserPanes")]
                    [Validation(Required=false)]
                    public List<ListRtcMPUTaskDetailResponseBodyMPUTasksTranscodeParamsLayoutUserPanes> UserPanes { get; set; }
                    public class ListRtcMPUTaskDetailResponseBodyMPUTasksTranscodeParamsLayoutUserPanes : TeaModel {
                        /// <summary>
                        /// <para>The background image URL of the sub-image. When the user turns off the camera or has not entered the channel, this image fills the layout position.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>yourImageUrl</para>
                        /// </summary>
                        [NameInMap("BackgroundImageUrl")]
                        [Validation(Required=false)]
                        public string BackgroundImageUrl { get; set; }

                        /// <summary>
                        /// <para>The pane height, as a normalized percentage.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.2632</para>
                        /// </summary>
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public string Height { get; set; }

                        /// <summary>
                        /// <para>The display mode for the sub-image output. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>0: scales the image and displays a black background.</description></item>
                        /// <item><description>1 (default): crops the image.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("RenderMode")]
                        [Validation(Required=false)]
                        public string RenderMode { get; set; }

                        /// <summary>
                        /// <para>The stream mixing user information.</para>
                        /// </summary>
                        [NameInMap("UserInfo")]
                        [Validation(Required=false)]
                        public ListRtcMPUTaskDetailResponseBodyMPUTasksTranscodeParamsLayoutUserPanesUserInfo UserInfo { get; set; }
                        public class ListRtcMPUTaskDetailResponseBodyMPUTasksTranscodeParamsLayoutUserPanesUserInfo : TeaModel {
                            /// <summary>
                            /// <para>The channel ID where the stream mixing user resides.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>yourChannelId</para>
                            /// </summary>
                            [NameInMap("ChannelId")]
                            [Validation(Required=false)]
                            public string ChannelId { get; set; }

                            /// <summary>
                            /// <para>The video input stream type in stream mixing and transcoding mode. This parameter is valid only for video streams (StreamType=2). Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>camera (default): camera.</description></item>
                            /// <item><description>shareScreen: screen sharing.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>camera</para>
                            /// </summary>
                            [NameInMap("SourceType")]
                            [Validation(Required=false)]
                            public string SourceType { get; set; }

                            /// <summary>
                            /// <para>The stream mixing user ID.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>yourSubUserId</para>
                            /// </summary>
                            [NameInMap("UserId")]
                            [Validation(Required=false)]
                            public string UserId { get; set; }

                        }

                        /// <summary>
                        /// <para>The pane width, as a normalized percentage.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.3564</para>
                        /// </summary>
                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public string Width { get; set; }

                        /// <summary>
                        /// <para>The X coordinate, as a normalized percentage.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.2456</para>
                        /// </summary>
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public string X { get; set; }

                        /// <summary>
                        /// <para>The Y coordinate, as a normalized percentage.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.3789</para>
                        /// </summary>
                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public string Y { get; set; }

                        /// <summary>
                        /// <para>The stacking order. 0 is the bottom layer, layer 1 is above layer 0, and so on.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("ZOrder")]
                        [Validation(Required=false)]
                        public string ZOrder { get; set; }

                    }

                }

                /// <summary>
                /// <para>The stream mixing user information. If no user is specified, all users are mixed.</para>
                /// </summary>
                [NameInMap("UserInfos")]
                [Validation(Required=false)]
                public List<ListRtcMPUTaskDetailResponseBodyMPUTasksTranscodeParamsUserInfos> UserInfos { get; set; }
                public class ListRtcMPUTaskDetailResponseBodyMPUTasksTranscodeParamsUserInfos : TeaModel {
                    /// <summary>
                    /// <para>The channel ID where the stream mixing user resides.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>yourChannelId</para>
                    /// </summary>
                    [NameInMap("ChannelId")]
                    [Validation(Required=false)]
                    public string ChannelId { get; set; }

                    /// <summary>
                    /// <para>The video input stream type in stream mixing and transcoding mode. This parameter is valid only for video streams (StreamType=2). Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>camera (default): camera.</description></item>
                    /// <item><description>shareScreen: screen sharing.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>camera</para>
                    /// </summary>
                    [NameInMap("SourceType")]
                    [Validation(Required=false)]
                    public string SourceType { get; set; }

                    /// <summary>
                    /// <para>The stream type for relaying in stream mixing and transcoding mode. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>0 (default): relay the original stream.</description></item>
                    /// <item><description>1: relay only the audio stream.</description></item>
                    /// <item><description>2: relay only the video stream.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("StreamType")]
                    [Validation(Required=false)]
                    public string StreamType { get; set; }

                    /// <summary>
                    /// <para>The stream mixing user ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>yourSubUserId</para>
                    /// </summary>
                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>3B-0E1A-586A-AC29-742247</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
