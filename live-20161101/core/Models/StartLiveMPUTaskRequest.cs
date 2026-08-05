// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class StartLiveMPUTaskRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. Only one ID is supported. It can contain uppercase letters, lowercase letters, digits, underscores (_), and hyphens (-). The maximum length is 64 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourAppId</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The channel ID. Only one ID is supported. It can contain uppercase letters, lowercase letters, digits, underscores (_), and hyphens (-). The maximum length is 64 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourChannelId</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// <para>The idle timeout period. Unit: seconds. The value must be in the range of [10, 86400].</para>
        /// <remarks>
        /// <para>If you set this parameter, the task is automatically stopped when it has been idle for a period longer than MaxIdleTime. If you do not set this parameter, the task is stopped immediately after the channel is closed.</para>
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
        /// <item><description><para><b>0</b>: Single-stream ingest. The original single stream is ingested without stream mixing or transcoding. You do not need to configure stream mixing and transcoding parameters.</para>
        /// </description></item>
        /// <item><description><para><b>1</b> (default): Stream mixing and transcoding.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MixMode")]
        [Validation(Required=false)]
        public string MixMode { get; set; }

        /// <summary>
        /// <para>The parameters for ingesting to multiple URLs. You can specify multiple live ingest URLs.</para>
        /// <remarks>
        /// <para>When you set the ingest URL for a task, you must configure either the StreamURL parameter or the MultiStreamURL parameter, but not both.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("MultiStreamURL")]
        [Validation(Required=false)]
        public List<StartLiveMPUTaskRequestMultiStreamURL> MultiStreamURL { get; set; }
        public class StartLiveMPUTaskRequestMultiStreamURL : TeaModel {
            /// <summary>
            /// <para>Specifies whether to ingest the stream to Alibaba Cloud CDN.</para>
            /// <list type="bullet">
            /// <item><description><para>false: Ingest to a non-Alibaba Cloud CDN.</para>
            /// </description></item>
            /// <item><description><para>true: Ingest to Alibaba Cloud CDN.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>The default value is false.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsAliCdn")]
            [Validation(Required=false)]
            public bool? IsAliCdn { get; set; }

            /// <summary>
            /// <para>The live ingest URL. Only the RTMP protocol is supported. The maximum length is 2048 characters. For information about how to generate the URL, see <a href="https://help.aliyun.com/document_detail/199339.html">Ingest URLs and playback URLs</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rtmp://example.com/live/stream****</para>
            /// </summary>
            [NameInMap("URL")]
            [Validation(Required=false)]
            public string URL { get; set; }

        }

        /// <summary>
        /// <para>The region where the stream mixing service is located. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>CN-Shanghai&lt;props=&quot;china&quot;&gt;(default)</b>: Shanghai.</para>
        /// </description></item>
        /// <item><description><para><b>AP-Singapore&lt;props=&quot;intl&quot;&gt;(default)</b>: Singapore.</para>
        /// </description></item>
        /// <item><description><para><b>EMAA-Saudi</b>: Saudi Arabia.</para>
        /// </description></item>
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
        public StartLiveMPUTaskRequestSeiParams SeiParams { get; set; }
        public class StartLiveMPUTaskRequestSeiParams : TeaModel {
            /// <summary>
            /// <para>The layout and volume SEI. The content of this parameter can be empty, which means the default layout and volume SEI is carried.</para>
            /// </summary>
            [NameInMap("LayoutVolume")]
            [Validation(Required=false)]
            public StartLiveMPUTaskRequestSeiParamsLayoutVolume LayoutVolume { get; set; }
            public class StartLiveMPUTaskRequestSeiParamsLayoutVolume : TeaModel {
                /// <summary>
                /// <para>Specifies whether to ensure that SEI is carried when sending an IDR keyframe. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>0</b>: Does not ensure SEI is carried.</para>
                /// </description></item>
                /// <item><description><para><b>1</b>: Ensures SEI is carried.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("FollowIdr")]
                [Validation(Required=false)]
                public string FollowIdr { get; set; }

                /// <summary>
                /// <para>The SEI sending interval. Unit: milliseconds. The value must be in the range of [1000, 5000].</para>
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
            public StartLiveMPUTaskRequestSeiParamsPassThrough PassThrough { get; set; }
            public class StartLiveMPUTaskRequestSeiParamsPassThrough : TeaModel {
                /// <summary>
                /// <para>Specifies whether to ensure that SEI is carried when sending an IDR keyframe. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>0</b>: Does not ensure SEI is carried.</para>
                /// </description></item>
                /// <item><description><para><b>1</b>: Ensures SEI is carried.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("FollowIdr")]
                [Validation(Required=false)]
                public string FollowIdr { get; set; }

                /// <summary>
                /// <para>The SEI sending interval. Unit: milliseconds. The value must be in the range of [1000, 5000].</para>
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
                /// <para>The key corresponding to the payload content of the pass-through SEI. If not set, the default key is \<c>udd\\</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yourPayloadContentKey</para>
                /// </summary>
                [NameInMap("PayloadContentKey")]
                [Validation(Required=false)]
                public string PayloadContentKey { get; set; }

            }

            /// <summary>
            /// <para>The custom payload_type of the SEI message. The value must be in the range of 100-254. If not set, the default payload_type is 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("PayloadType")]
            [Validation(Required=false)]
            public string PayloadType { get; set; }

        }

        /// <summary>
        /// <para>The parameters for single-stream ingest. This parameter is required when MixMode is set to 0. Do not set this parameter for stream mixing and transcoding.</para>
        /// </summary>
        [NameInMap("SingleSubParams")]
        [Validation(Required=false)]
        public StartLiveMPUTaskRequestSingleSubParams SingleSubParams { get; set; }
        public class StartLiveMPUTaskRequestSingleSubParams : TeaModel {
            /// <summary>
            /// <para>The type of video input stream in single-stream ingest mode. This parameter is valid only for video streams (StreamType=2). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>camera</b> (default): Camera stream.</para>
            /// </description></item>
            /// <item><description><para><b>shareScreen</b>: Screen sharing stream.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>camera</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The type of stream to ingest in single-stream ingest mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b> (default): Ingest the original stream.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: Ingest only the audio stream.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: Ingest only the video stream.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("StreamType")]
            [Validation(Required=false)]
            public string StreamType { get; set; }

            /// <summary>
            /// <para>The ID of the user whose stream is ingested. Only one stream can be ingested at a time.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yourSubUserId</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The live ingest URL. Only the RTMP protocol is supported. Only one URL is supported. The maximum length is 2048 characters. For information about how to generate the URL, see <a href="https://help.aliyun.com/document_detail/199339.html">Ingest URLs and playback URLs</a>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>For domain names with hotlink protection enabled, the ingest URL must include an access token.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>Do not use the same StreamURL in different tasks at the same time.</para>
        /// </description></item>
        /// <item><description><para>Do not use the same StreamURL within 10 seconds after a task stops.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>rtmp://example.com/live/stream</para>
        /// </summary>
        [NameInMap("StreamURL")]
        [Validation(Required=false)]
        public string StreamURL { get; set; }

        /// <summary>
        /// <para>The task ID. Only one ID is supported. It can contain uppercase letters, lowercase letters, digits, underscores (_), and hyphens (-). The maximum length is 55 characters. This ID is the unique identifier for the bypass ingest task.
        /// If a task with the same ID still exists and has not been cleared when you start a new task, \<c>InvalidParam\\</c> is returned.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourTaskId</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The parameters for stream mixing and transcoding. This parameter is required when MixMode is set to 1. Do not set this parameter for single-stream ingest.</para>
        /// </summary>
        [NameInMap("TranscodeParams")]
        [Validation(Required=false)]
        public StartLiveMPUTaskRequestTranscodeParams TranscodeParams { get; set; }
        public class StartLiveMPUTaskRequestTranscodeParams : TeaModel {
            /// <summary>
            /// <para>The global background image for the mixed stream.</para>
            /// </summary>
            [NameInMap("Background")]
            [Validation(Required=false)]
            public StartLiveMPUTaskRequestTranscodeParamsBackground Background { get; set; }
            public class StartLiveMPUTaskRequestTranscodeParamsBackground : TeaModel {
                /// <summary>
                /// <para>The display mode of the output video. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>0</b>: Scale and display a black background.</para>
                /// </description></item>
                /// <item><description><para><b>1</b> (default): Clip.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RenderMode")]
                [Validation(Required=false)]
                public string RenderMode { get; set; }

                /// <summary>
                /// <para>The URL of the global background image. The maximum length is 2048 characters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yourImageUrl</para>
                /// </summary>
                [NameInMap("URL")]
                [Validation(Required=false)]
                public string URL { get; set; }

            }

            /// <summary>
            /// <para>The encoding parameters for the output stream.</para>
            /// </summary>
            [NameInMap("EncodeParams")]
            [Validation(Required=false)]
            public StartLiveMPUTaskRequestTranscodeParamsEncodeParams EncodeParams { get; set; }
            public class StartLiveMPUTaskRequestTranscodeParamsEncodeParams : TeaModel {
                /// <summary>
                /// <para>The audio bitrate. Unit: kbps. The value must be in the range of [8, 500].</para>
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
                /// <para>Specifies whether the stream is audio-only. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: Audio-only. You only need to set audio-related parameters.</para>
                /// </description></item>
                /// <item><description><para><b>false</b> (default): Not audio-only. All parameters except VideoCodec and EnhancedParam must be specified.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AudioOnly")]
                [Validation(Required=false)]
                public string AudioOnly { get; set; }

                /// <summary>
                /// <para>The audio sampling rate. Unit: Hz. Valid values: 8000, 16000, 32000, 44100, 48000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>44100</para>
                /// </summary>
                [NameInMap("AudioSampleRate")]
                [Validation(Required=false)]
                public string AudioSampleRate { get; set; }

                /// <summary>
                /// <para>The enhanced encoding parameters. This is a JSON string. The supported optional configurations include \<c>profile\\</c> and \<c>preset\\</c>.</para>
                /// <list type="bullet">
                /// <item><description><para>\<c>profile\\</c>: The encoding profile. If the video encoding format is H.264, valid values for \<c>profile\\</c> include &quot;baseline&quot;, &quot;main&quot;, and &quot;high&quot;. If the video encoding format is H.265, the valid value for \<c>profile\\</c> is &quot;main&quot;.</para>
                /// </description></item>
                /// <item><description><para>\<c>preset\\</c>: Balances encoding speed and quality. Valid values for \<c>preset\\</c> include &quot;ultrafast&quot;, &quot;superfast&quot;, &quot;veryfast&quot;, &quot;faster&quot;, &quot;fast&quot;, &quot;medium&quot;, &quot;slow&quot;, &quot;slower&quot;, &quot;veryslow&quot;, and &quot;placebo&quot;. Each value represents a strategy for balancing encoding speed and output video quality, from &quot;ultrafast&quot; (fastest encoding speed) to &quot;placebo&quot; (highest quality, slowest encoding speed).</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>For example, &quot;superfast&quot; is mainly used for real-time communication. If you are not an expert in encoders, do not set this option.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;profile&quot;: &quot;high&quot;, &quot;preset&quot;: &quot;veryfast&quot;}</para>
                /// </summary>
                [NameInMap("EnhancedParam")]
                [Validation(Required=false)]
                public string EnhancedParam { get; set; }

                /// <summary>
                /// <para>The video bitrate. Unit: kbps. The value must be in the range of [1, 10000].</para>
                /// 
                /// <b>Example:</b>
                /// <para>3500</para>
                /// </summary>
                [NameInMap("VideoBitrate")]
                [Validation(Required=false)]
                public string VideoBitrate { get; set; }

                /// <summary>
                /// <para>The video encoding format. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>H.264 (default).</para>
                /// </description></item>
                /// <item><description><para>H.265.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>H.264</para>
                /// </summary>
                [NameInMap("VideoCodec")]
                [Validation(Required=false)]
                public string VideoCodec { get; set; }

                /// <summary>
                /// <para>The video frame rate. Unit: fps. The value must be in the range of [1, 60].</para>
                /// 
                /// <b>Example:</b>
                /// <para>25</para>
                /// </summary>
                [NameInMap("VideoFramerate")]
                [Validation(Required=false)]
                public string VideoFramerate { get; set; }

                /// <summary>
                /// <para>The video GOP size. The value must be in the range of [1, 60].</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("VideoGop")]
                [Validation(Required=false)]
                public string VideoGop { get; set; }

                /// <summary>
                /// <para>The video height. Unit: pixels. The value must be in the range of [0, 1920].</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("VideoHeight")]
                [Validation(Required=false)]
                public string VideoHeight { get; set; }

                /// <summary>
                /// <para>The video width. Unit: pixels. The value must be in the range of [0, 1920].</para>
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
            /// <para>For video transcoding, you must specify the video layout information, including coordinates (X, Y), pane dimensions (Width, Height), and stacking order (ZOrder). For audio-only transcoding, do not specify video layout information.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Layout")]
            [Validation(Required=false)]
            public StartLiveMPUTaskRequestTranscodeParamsLayout Layout { get; set; }
            public class StartLiveMPUTaskRequestTranscodeParamsLayout : TeaModel {
                /// <summary>
                /// <para>The information about user panes in the mixed stream.</para>
                /// </summary>
                [NameInMap("UserPanes")]
                [Validation(Required=false)]
                public List<StartLiveMPUTaskRequestTranscodeParamsLayoutUserPanes> UserPanes { get; set; }
                public class StartLiveMPUTaskRequestTranscodeParamsLayoutUserPanes : TeaModel {
                    /// <summary>
                    /// <para>The URL of the background image for the video pane. The maximum length is 2048 characters. When a user turns off their camera or has not joined the channel, this image is displayed in their layout position.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>yourImageUrl</para>
                    /// </summary>
                    [NameInMap("BackgroundImageUrl")]
                    [Validation(Required=false)]
                    public string BackgroundImageUrl { get; set; }

                    /// <summary>
                    /// <para>The height of the pane, as a normalized percentage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.2632</para>
                    /// </summary>
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public string Height { get; set; }

                    /// <summary>
                    /// <para>The display mode of the output video pane. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>0</b>: Scale and display a black background.</para>
                    /// </description></item>
                    /// <item><description><para><b>1</b> (default): Clip.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("RenderMode")]
                    [Validation(Required=false)]
                    public string RenderMode { get; set; }

                    /// <summary>
                    /// <para>The information about the user corresponding to this pane. If you do not set this parameter, the system automatically fills it based on the order in which streamers join the channel.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>If you specify user information, that user must already be configured in the \<c>TranscodeParams.UserInfos\\</c> parameter.</description></item>
                    /// </list>
                    /// </remarks>
                    /// <list type="bullet">
                    /// <item><description>This parameter is valid only for original streams and video streams.</description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("UserInfo")]
                    [Validation(Required=false)]
                    public StartLiveMPUTaskRequestTranscodeParamsLayoutUserPanesUserInfo UserInfo { get; set; }
                    public class StartLiveMPUTaskRequestTranscodeParamsLayoutUserPanesUserInfo : TeaModel {
                        /// <summary>
                        /// <para>The ID of the channel where the user is located. You do not need to set this parameter for users in the same channel. For cross-channel stream mixing, set this parameter.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>yourChannelId</para>
                        /// </summary>
                        [NameInMap("ChannelId")]
                        [Validation(Required=false)]
                        public string ChannelId { get; set; }

                        /// <summary>
                        /// <para>The type of video input stream in stream mixing and transcoding mode. This parameter is valid only for video streams (StreamType=2). Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para><b>camera</b> (default): Camera stream.</para>
                        /// </description></item>
                        /// <item><description><para><b>shareScreen</b>: Screen sharing stream.</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>camera</para>
                        /// </summary>
                        [NameInMap("SourceType")]
                        [Validation(Required=false)]
                        public string SourceType { get; set; }

                        /// <summary>
                        /// <para>The user ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>yourSubUserId</para>
                        /// </summary>
                        [NameInMap("UserId")]
                        [Validation(Required=false)]
                        public string UserId { get; set; }

                    }

                    /// <summary>
                    /// <para>The width of the pane, as a normalized percentage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.3564</para>
                    /// </summary>
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public string Width { get; set; }

                    /// <summary>
                    /// <para>The X-coordinate, as a normalized percentage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.2456</para>
                    /// </summary>
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public string X { get; set; }

                    /// <summary>
                    /// <para>The Y-coordinate, as a normalized percentage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.3789</para>
                    /// </summary>
                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public string Y { get; set; }

                    /// <summary>
                    /// <para>The stacking order. 0 is the bottom layer. Layer 1 is on top of layer 0, and so on.</para>
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
            /// <para>The information about the users to subscribe to for stream mixing. If you do not specify users, all users are included in the mixed stream.</para>
            /// </summary>
            [NameInMap("UserInfos")]
            [Validation(Required=false)]
            public List<StartLiveMPUTaskRequestTranscodeParamsUserInfos> UserInfos { get; set; }
            public class StartLiveMPUTaskRequestTranscodeParamsUserInfos : TeaModel {
                /// <summary>
                /// <para>The ID of the channel where the subscribed user is located. You do not need to set this parameter for users in the same channel. For cross-channel stream mixing, set this parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yourChannelId</para>
                /// </summary>
                [NameInMap("ChannelId")]
                [Validation(Required=false)]
                public string ChannelId { get; set; }

                /// <summary>
                /// <para>The type of video input stream to subscribe to for stream mixing. This parameter is valid only for video streams (StreamType=2). Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>camera</b> (default): Camera stream.</para>
                /// </description></item>
                /// <item><description><para><b>shareScreen</b>: Screen sharing stream.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>camera</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The type of stream to subscribe to for stream mixing. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>0</b> (default): Ingest the original stream.</para>
                /// </description></item>
                /// <item><description><para><b>1</b>: Ingest only the audio stream.</para>
                /// </description></item>
                /// <item><description><para><b>2</b>: Ingest only the video stream.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("StreamType")]
                [Validation(Required=false)]
                public string StreamType { get; set; }

                /// <summary>
                /// <para>The ID of the user to subscribe to for stream mixing.</para>
                /// <para>This parameter is required.</para>
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

}
