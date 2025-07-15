// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class UpdateLiveMPUTaskRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. You can specify only one application ID. The ID can be up to 64 characters in length and can contain letters, digits, underscores (_), and hyphens (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourAppId</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The channel ID. You can specify only one channel ID. The ID can be up to 64 characters in length and can contain letters, digits, underscores (_), and hyphens (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourChannelId</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// <para>The stream mixing mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: the single-stream relay mode. In this mode, the service only relays the original single stream, but does not transcode mixed streams. You do not need to set parameters for mixed-stream transcoding.</description></item>
        /// <item><description><b>1</b> (default): the mixed-stream relay mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MixMode")]
        [Validation(Required=false)]
        public string MixMode { get; set; }

        /// <summary>
        /// <para>The multiple ingest URLs to relay. This parameter allows you to specify multiple ingest URLs.</para>
        /// </summary>
        [NameInMap("MultiStreamURL")]
        [Validation(Required=false)]
        public List<UpdateLiveMPUTaskRequestMultiStreamURL> MultiStreamURL { get; set; }
        public class UpdateLiveMPUTaskRequestMultiStreamURL : TeaModel {
            /// <summary>
            /// <para>Specifies whether to perform stream relay by using Alibaba Cloud CDN. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>false: performs stream relay by using a CDN service that is not Alibaba Cloud CDN.</description></item>
            /// <item><description>true: performs stream relay by using Alibaba Cloud CDN.</description></item>
            /// </list>
            /// <remarks>
            /// <para> The default value of this parameter is false.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsAliCdn")]
            [Validation(Required=false)]
            public bool? IsAliCdn { get; set; }

            /// <summary>
            /// <para>The ingest URL. Only the RTMP format is supported. The URL can be up to 2,048 characters in length. For information about the generation rules of ingest URLs, see <a href="https://help.aliyun.com/document_detail/199339.html">Ingest and streaming URLs</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rtmp://example.com/live/stream****</para>
            /// </summary>
            [NameInMap("URL")]
            [Validation(Required=false)]
            public string URL { get; set; }

        }

        /// <summary>
        /// <para>The supplemental enhancement information (SEI) parameters.</para>
        /// </summary>
        [NameInMap("SeiParams")]
        [Validation(Required=false)]
        public UpdateLiveMPUTaskRequestSeiParams SeiParams { get; set; }
        public class UpdateLiveMPUTaskRequestSeiParams : TeaModel {
            /// <summary>
            /// <para>The layout and volume SEI. If you leave this parameter empty, the default layout and volume SEI is used.</para>
            /// </summary>
            [NameInMap("LayoutVolume")]
            [Validation(Required=false)]
            public UpdateLiveMPUTaskRequestSeiParamsLayoutVolume LayoutVolume { get; set; }
            public class UpdateLiveMPUTaskRequestSeiParamsLayoutVolume : TeaModel {
                /// <summary>
                /// <para>Specifies whether to include the SEI in an Instantaneous Decoder Refresh (IDR) frame. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: does not include the SEI.</description></item>
                /// <item><description><b>1</b>: includes the SEI.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("FollowIdr")]
                [Validation(Required=false)]
                public string FollowIdr { get; set; }

                /// <summary>
                /// <para>The interval at which the SEI is sent. Valid values: [1000,5000]. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public string Interval { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to pass through the SEI.</para>
            /// </summary>
            [NameInMap("PassThrough")]
            [Validation(Required=false)]
            public UpdateLiveMPUTaskRequestSeiParamsPassThrough PassThrough { get; set; }
            public class UpdateLiveMPUTaskRequestSeiParamsPassThrough : TeaModel {
                /// <summary>
                /// <para>Specifies whether to include the SEI in an IDR frame. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: does not include the SEI.</description></item>
                /// <item><description><b>1</b>: includes the SEI.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("FollowIdr")]
                [Validation(Required=false)]
                public string FollowIdr { get; set; }

                /// <summary>
                /// <para>The interval at which the SEI is sent. Valid values: [1000,5000]. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public string Interval { get; set; }

                /// <summary>
                /// <para>The payload content of the SEI.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yourPayloadContent</para>
                /// </summary>
                [NameInMap("PayloadContent")]
                [Validation(Required=false)]
                public string PayloadContent { get; set; }

                /// <summary>
                /// <para>The key of the payload content of the SEI. If you do not specify this parameter, the default value udd is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yourPayloadContentKey</para>
                /// </summary>
                [NameInMap("PayloadContentKey")]
                [Validation(Required=false)]
                public string PayloadContentKey { get; set; }

            }

        }

        /// <summary>
        /// <para>The single-stream relay parameters. These parameters are required if you set MixMode to 0.</para>
        /// </summary>
        [NameInMap("SingleSubParams")]
        [Validation(Required=false)]
        public UpdateLiveMPUTaskRequestSingleSubParams SingleSubParams { get; set; }
        public class UpdateLiveMPUTaskRequestSingleSubParams : TeaModel {
            /// <summary>
            /// <para>The type of the video source. This parameter is valid only when you set StreamType to 2. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>camera</b> (default)</description></item>
            /// <item><description><b>shareScreen</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>camera</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The type of the stream that you want to relay. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b> (default): original stream</description></item>
            /// <item><description><b>1</b>: only the audio track</description></item>
            /// <item><description><b>2</b>: only the video track</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("StreamType")]
            [Validation(Required=false)]
            public string StreamType { get; set; }

            /// <summary>
            /// <para>The user ID. In the single-stream relay mode, you can relay only one stream in a request.</para>
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
        /// <para>The ingest URL. You can specify only one ingest URL in the Real-Time Messaging Protocol (RTMP) format. The URL can be up to 2,048 characters in length. For information about the generation rules of ingest URLs, see <a href="https://help.aliyun.com/document_detail/199339.html">Ingest and streaming URLs</a>.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If the ingest URL is under a domain name for which hotlink protection is enabled, you must include an access token in the URL.</description></item>
        /// <item><description>You cannot use the same ingest URL in different tasks.</description></item>
        /// <item><description>You cannot use the same ingest URL within 10 seconds after a task is stopped.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>rtmp://example.com/live/stream</para>
        /// </summary>
        [NameInMap("StreamURL")]
        [Validation(Required=false)]
        public string StreamURL { get; set; }

        /// <summary>
        /// <para>The task ID. You can specify only one task ID. The ID can be up to 55 characters in length and can contain letters, digits, underscores (_), and hyphens (-). The ID must be unique.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourTaskId</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The mixed-stream relay parameters. These parameters are required if you set MixMode to 1.</para>
        /// </summary>
        [NameInMap("TranscodeParams")]
        [Validation(Required=false)]
        public UpdateLiveMPUTaskRequestTranscodeParams TranscodeParams { get; set; }
        public class UpdateLiveMPUTaskRequestTranscodeParams : TeaModel {
            /// <summary>
            /// <para>The global background image.</para>
            /// </summary>
            [NameInMap("Background")]
            [Validation(Required=false)]
            public UpdateLiveMPUTaskRequestTranscodeParamsBackground Background { get; set; }
            public class UpdateLiveMPUTaskRequestTranscodeParamsBackground : TeaModel {
                /// <summary>
                /// <para>The display mode of the global background image.</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: scales the background image proportionally to fit the view, with black bars displayed.</description></item>
                /// <item><description><b>1</b> (default): crops the background image to fit the view.</description></item>
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
            /// <para>The encoding parameters for the output stream.</para>
            /// </summary>
            [NameInMap("EncodeParams")]
            [Validation(Required=false)]
            public UpdateLiveMPUTaskRequestTranscodeParamsEncodeParams EncodeParams { get; set; }
            public class UpdateLiveMPUTaskRequestTranscodeParamsEncodeParams : TeaModel {
                /// <summary>
                /// <para>The bitrate of the audio. Valid values: [8,500]. Unit: Kbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>128</para>
                /// </summary>
                [NameInMap("AudioBitrate")]
                [Validation(Required=false)]
                public string AudioBitrate { get; set; }

                /// <summary>
                /// <para>The number of sound channels. Valid values: 1 and 2.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("AudioChannels")]
                [Validation(Required=false)]
                public string AudioChannels { get; set; }

                /// <summary>
                /// <para>Specifies whether the output stream is an audio-only stream. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The output stream is an audio-only stream. If you set this parameter to true, you need to configure only audio-related parameters under EncodeParams.</description></item>
                /// <item><description><b>false</b> (default): The output stream is not an audio-only stream. If you set this parameter to false, you need to configure all parameters under EncodeParams, except the VideoCodec and EnhancedParam parameters.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AudioOnly")]
                [Validation(Required=false)]
                public string AudioOnly { get; set; }

                /// <summary>
                /// <para>The audio sampling rate. Valid values: 8000, 16000, 32000, 44100, and 48000. Unit: Hz.</para>
                /// 
                /// <b>Example:</b>
                /// <para>44100</para>
                /// </summary>
                [NameInMap("AudioSampleRate")]
                [Validation(Required=false)]
                public string AudioSampleRate { get; set; }

                /// <summary>
                /// <para>The parameter used for encoding enhancement, which is a JSON string. The parameter includes the optional profile and preset fields.</para>
                /// <list type="bullet">
                /// <item><description>profile: the encoding level. If the video codec is H.264, the valid values of this field are baseline, main, and high. If the video codec is H.265, the valid value of this field is main.</description></item>
                /// <item><description>preset: adjusts the trade-off between encoding speed and video quality. The valid values of this field are ultrafast, superfast, veryfast, faster, fast, medium, slow, slower, veryslow, and placebo. Each value specifies a level of trade-off between encoding speed and video quality. For example, the ultrafast preset has the fastest encoding speed but the lowest video quality, while the placebo preset sacrifices the encoding speed for the best video quality.</description></item>
                /// </list>
                /// <remarks>
                /// <para> A value of superfast for the preset field is suitable for real-time communication scenarios. We recommend that you not set the field if you are not a professional encoding engineer.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;profile&quot;: &quot;high&quot;, &quot;preset&quot;: &quot;veryfast&quot;}</para>
                /// </summary>
                [NameInMap("EnhancedParam")]
                [Validation(Required=false)]
                public string EnhancedParam { get; set; }

                /// <summary>
                /// <para>The bitrate of the video. Valid values: [1,10000]. Unit: Kbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3500</para>
                /// </summary>
                [NameInMap("VideoBitrate")]
                [Validation(Required=false)]
                public string VideoBitrate { get; set; }

                /// <summary>
                /// <para>The video codec. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>H.264 (default)</description></item>
                /// <item><description>H.265</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>H.264</para>
                /// </summary>
                [NameInMap("VideoCodec")]
                [Validation(Required=false)]
                public string VideoCodec { get; set; }

                /// <summary>
                /// <para>The frame rate of the video. Valid values: [1,60]. Unit: frames per second (FPS).</para>
                /// 
                /// <b>Example:</b>
                /// <para>25</para>
                /// </summary>
                [NameInMap("VideoFramerate")]
                [Validation(Required=false)]
                public string VideoFramerate { get; set; }

                /// <summary>
                /// <para>The group of pictures (GOP) size of the video. Valid values: [1,60].</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("VideoGop")]
                [Validation(Required=false)]
                public string VideoGop { get; set; }

                /// <summary>
                /// <para>The height of the video. Valid values: [0,1920]. Unit: pixels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("VideoHeight")]
                [Validation(Required=false)]
                public string VideoHeight { get; set; }

                /// <summary>
                /// <para>The width of the video. Valid values: [0,1920]. Unit: pixels.</para>
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
            /// <para> If video transcoding is required, you must specify the video layout information, including the x-coordinate and y-coordinate, the width and height, and the layer. For audio-only transcoding, leave the video layout information empty.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Layout")]
            [Validation(Required=false)]
            public UpdateLiveMPUTaskRequestTranscodeParamsLayout Layout { get; set; }
            public class UpdateLiveMPUTaskRequestTranscodeParamsLayout : TeaModel {
                /// <summary>
                /// <para>The information about the panes.</para>
                /// </summary>
                [NameInMap("UserPanes")]
                [Validation(Required=false)]
                public List<UpdateLiveMPUTaskRequestTranscodeParamsLayoutUserPanes> UserPanes { get; set; }
                public class UpdateLiveMPUTaskRequestTranscodeParamsLayoutUserPanes : TeaModel {
                    /// <summary>
                    /// <para>The URL of the background image of the pane. This image is displayed if the user turns off the camera or is not present in the channel.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>yourImageUrl</para>
                    /// </summary>
                    [NameInMap("BackgroundImageUrl")]
                    [Validation(Required=false)]
                    public string BackgroundImageUrl { get; set; }

                    /// <summary>
                    /// <para>The height of the pane. The value is normalized.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.2632</para>
                    /// </summary>
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public string Height { get; set; }

                    /// <summary>
                    /// <para>The display mode of the pane. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>0</b>: scales the video proportionally to fit the view, with black bars displayed.</description></item>
                    /// <item><description><b>1 (default)</b>: crops the video to fit the view.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("RenderMode")]
                    [Validation(Required=false)]
                    public string RenderMode { get; set; }

                    /// <summary>
                    /// <para>The information about the user whose stream is played in the pane. If you leave this parameter empty, the system automatically sets this parameter based on the order in which streamers join the channel.</para>
                    /// <remarks>
                    /// </remarks>
                    /// <list type="bullet">
                    /// <item><description><para>If you specify the information about a user by using this parameter, the information about the user must also be specified by using the TranscodeParams.UserInfos parameter.</para>
                    /// </description></item>
                    /// <item><description><para>This parameter is valid only when you set StreamType to 0 or 2.</para>
                    /// </description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("UserInfo")]
                    [Validation(Required=false)]
                    public UpdateLiveMPUTaskRequestTranscodeParamsLayoutUserPanesUserInfo UserInfo { get; set; }
                    public class UpdateLiveMPUTaskRequestTranscodeParamsLayoutUserPanesUserInfo : TeaModel {
                        /// <summary>
                        /// <para>The ID of the channel where the user is. If the user is in the same channel, you can leave this parameter empty. We recommend that you specify this parameter when you perform stream mixing across channels.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>yourChannelId</para>
                        /// </summary>
                        [NameInMap("ChannelId")]
                        [Validation(Required=false)]
                        public string ChannelId { get; set; }

                        /// <summary>
                        /// <para>The type of the video source. This parameter is valid only when you set StreamType to 2. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>camera</b> (default)</description></item>
                        /// <item><description><b>shareScreen</b></description></item>
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
                    /// <para>The width of the pane. The value is normalized.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.3564</para>
                    /// </summary>
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public string Width { get; set; }

                    /// <summary>
                    /// <para>The x-coordinate of the pane. The value is normalized.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.2456</para>
                    /// </summary>
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public string X { get; set; }

                    /// <summary>
                    /// <para>The y-coordinate of the pane. The value is normalized.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.3789</para>
                    /// </summary>
                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public string Y { get; set; }

                    /// <summary>
                    /// <para>The layer in which the pane resides. A value of 0 indicates the bottom layer. Each increment of the value by 1 indicates the next upper layer.</para>
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
            /// <para>The information about the users whose streams are subscribed to. If you leave this parameter empty, streams from all users are mixed.</para>
            /// </summary>
            [NameInMap("UserInfos")]
            [Validation(Required=false)]
            public List<UpdateLiveMPUTaskRequestTranscodeParamsUserInfos> UserInfos { get; set; }
            public class UpdateLiveMPUTaskRequestTranscodeParamsUserInfos : TeaModel {
                /// <summary>
                /// <para>The ID of the channel where the subscribed user is. If the user is in the same channel, you can leave this parameter empty. We recommend that you specify this parameter when you perform stream mixing across channels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yourChannelId</para>
                /// </summary>
                [NameInMap("ChannelId")]
                [Validation(Required=false)]
                public string ChannelId { get; set; }

                /// <summary>
                /// <para>The type of the video source that is subscribed to. This parameter is valid only when you set StreamType to 2. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>camera</b> (default)</description></item>
                /// <item><description><b>shareScreen</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>camera</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The type of the relayed stream that is subscribed to. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b> (default): original stream</description></item>
                /// <item><description><b>1</b>: only the audio track</description></item>
                /// <item><description><b>2</b>: only the video track</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("StreamType")]
                [Validation(Required=false)]
                public string StreamType { get; set; }

                /// <summary>
                /// <para>The ID of the subscribed user.</para>
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
