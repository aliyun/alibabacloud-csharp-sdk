// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class UpdateRtcCloudRecordingRequest : TeaModel {
        /// <summary>
        /// <para>The updated layout parameters. Leave this parameter empty in single-stream recording mode. This parameter is required in stream mixing recording mode when the transcoding output is not audio-only.</para>
        /// </summary>
        [NameInMap("MixLayoutParams")]
        [Validation(Required=false)]
        public UpdateRtcCloudRecordingRequestMixLayoutParams MixLayoutParams { get; set; }
        public class UpdateRtcCloudRecordingRequestMixLayoutParams : TeaModel {
            /// <summary>
            /// <para>The global background image for stream mixing.</para>
            /// </summary>
            [NameInMap("MixBackground")]
            [Validation(Required=false)]
            public UpdateRtcCloudRecordingRequestMixLayoutParamsMixBackground MixBackground { get; set; }
            public class UpdateRtcCloudRecordingRequestMixLayoutParamsMixBackground : TeaModel {
                /// <summary>
                /// <para>The display mode for the output. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: crop. (Default)</description></item>
                /// <item><description>1: scale and display with black borders.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RenderMode")]
                [Validation(Required=false)]
                public int? RenderMode { get; set; }

                /// <summary>
                /// <para>The URL of the background image. The maximum length is 2048 characters.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://xxxx.com/photos/my-test-picture.png">https://xxxx.com/photos/my-test-picture.png</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The window layout information of the subscribed users. Only UserIds with layout information configured are placed in the output. This parameter is required in stream mixing mode when recording non-audio-only files.</para>
            /// </summary>
            [NameInMap("UserPanes")]
            [Validation(Required=false)]
            public List<UpdateRtcCloudRecordingRequestMixLayoutParamsUserPanes> UserPanes { get; set; }
            public class UpdateRtcCloudRecordingRequestMixLayoutParamsUserPanes : TeaModel {
                /// <summary>
                /// <para>The pane height as a normalized percentage. The value must be in the range of [0, 1]. (Default: 0)</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public string Height { get; set; }

                /// <summary>
                /// <para>The video input stream type of the UserId. This parameter is invalid if UserId is not specified. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: camera. (Default)</description></item>
                /// <item><description>1: screen sharing.</description></item>
                /// </list>
                /// <para>The combination of UserId and SourceType specified here must be included in SubscribeUserIdList.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public int? SourceType { get; set; }

                /// <summary>
                /// <para>The sub-pane background image. When a user turns off the camera, has not started stream ingest after joining, or leaves the channel midway, the corresponding image is displayed at the layout position.</para>
                /// </summary>
                [NameInMap("SubBackground")]
                [Validation(Required=false)]
                public UpdateRtcCloudRecordingRequestMixLayoutParamsUserPanesSubBackground SubBackground { get; set; }
                public class UpdateRtcCloudRecordingRequestMixLayoutParamsUserPanesSubBackground : TeaModel {
                    /// <summary>
                    /// <para>The display mode for the sub-pane output. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>0: crop. (Default)</description></item>
                    /// <item><description>1: scale and display with black borders.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("RenderMode")]
                    [Validation(Required=false)]
                    public int? RenderMode { get; set; }

                    /// <summary>
                    /// <para>The URL of the background image. The maximum length is 2048 characters.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://xxxx.com/photos/my-test-pane-picture.png">https://xxxx.com/photos/my-test-pane-picture.png</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <para>The UserId corresponding to this window.</para>
                /// <list type="bullet">
                /// <item><description>If UserId is not specified, windows are filled in the order in which subscribed users join the channel.</description></item>
                /// <item><description>The combination of UserId and SourceType specified here must be included in SubscribeUserIdList.</description></item>
                /// <item><description>Audio-only streams cannot be added to the layout.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>userA</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The pane width as a normalized percentage. The value must be in the range of [0, 1]. (Default: 0)</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public string Width { get; set; }

                /// <summary>
                /// <para>The X coordinate as a normalized percentage. The value must be in the range of [0, 1]. (Default: 0)</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public string X { get; set; }

                /// <summary>
                /// <para>The Y coordinate as a normalized percentage. The value must be in the range of [0, 1]. (Default: 0)</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public string Y { get; set; }

                /// <summary>
                /// <para>The stacking order. 0 is the bottom layer, layer 1 is above layer 0, and so on. (Default: 0)</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ZOrder")]
                [Validation(Required=false)]
                public int? ZOrder { get; set; }

            }

        }

        /// <summary>
        /// <para>The updated subscription parameters.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SubscribeParams")]
        [Validation(Required=false)]
        public UpdateRtcCloudRecordingRequestSubscribeParams SubscribeParams { get; set; }
        public class UpdateRtcCloudRecordingRequestSubscribeParams : TeaModel {
            /// <summary>
            /// <para>The list of subscribed UserId entries. In single-stream recording mode, each UserId is recorded separately. In stream mixing recording mode, the audio and video of all UserIds are mixed into a single set of audio and video.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>The array supports a maximum of 17 elements.</description></item>
            /// </list>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("SubscribeUserIdList")]
            [Validation(Required=false)]
            public List<UpdateRtcCloudRecordingRequestSubscribeParamsSubscribeUserIdList> SubscribeUserIdList { get; set; }
            public class UpdateRtcCloudRecordingRequestSubscribeParamsSubscribeUserIdList : TeaModel {
                /// <summary>
                /// <para>The video input stream type of the UserId. This parameter takes effect only when the video stream is subscribed (StreamType=2). Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>0: camera. (Default)</para>
                /// </description></item>
                /// <item><description><para>1: screen sharing.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public int? SourceType { get; set; }

                /// <summary>
                /// <para>The media type of the subscribed UserId. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>0: original stream, which includes both audio and video. (Default)</para>
                /// </description></item>
                /// <item><description><para>1: audio-only stream.</para>
                /// </description></item>
                /// <item><description><para>2: video-only stream.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("StreamType")]
                [Validation(Required=false)]
                public int? StreamType { get; set; }

                /// <summary>
                /// <para>The subscribed UserId.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>userA</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        /// <summary>
        /// <para>The task ID. This ID is returned by StartRtcCloudRecording. Only tasks in the running or abnormal state can be updated.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>73-8501-</b></b>-8ac1-72295a</b>****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
