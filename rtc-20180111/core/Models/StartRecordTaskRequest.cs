// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class StartRecordTaskRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. You can create and query the ID in the console. Only a single ID is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourAppId</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The channel ID. Only a single ID is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourChannelId</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// <para>The cropping mode of the video. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: crops the video while maintaining the aspect ratio.</description></item>
        /// <item><description><b>2</b> (default): adds padding to the video while maintaining the aspect ratio.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CropMode")]
        [Validation(Required=false)]
        public long? CropMode { get; set; }

        /// <summary>
        /// <para>The list of layout IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1111</para>
        /// </summary>
        [NameInMap("LayoutIds")]
        [Validation(Required=false)]
        public List<long?> LayoutIds { get; set; }

        /// <summary>
        /// <para>The encoding option. For more information, see the MediaEncode enum values below.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MediaEncode")]
        [Validation(Required=false)]
        public int? MediaEncode { get; set; }

        /// <summary>
        /// <para>The recording mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: single-stream recording. Task parameters cannot be modified during the recording process. You cannot call the UpdateRecordTask operation to modify task parameters.</description></item>
        /// <item><description><b>1</b> (default): mixed-stream recording. Multiple video streams are mixed and output.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Valid parameters in single-stream recording mode: StreamType and SourceType.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Valid parameters in mixed-stream recording mode: TaskProfile, MediaEncode, LayoutIds, BackgroundColor, SubSpecUsers, CropMode, UserPanes, Backgrounds, Watermarks, and ClockWidgets.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MixMode")]
        [Validation(Required=false)]
        public int? MixMode { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The video source in single-stream recording mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>camera</b>: the camera.</description></item>
        /// <item><description><b>shareScreen</b>: screen sharing.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If the video source is shareScreen and only the camera stream is ingested, the camera stream is recorded. If both the camera stream and the screen sharing stream are ingested, the screen sharing stream is recorded.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>camera</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The single-stream recording mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b> (default): records the original stream.</description></item>
        /// <item><description><b>1</b>: records only the audio stream.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("StreamType")]
        [Validation(Required=false)]
        public int? StreamType { get; set; }

        /// <summary>
        /// <para>Specifies the users whose audio streams are subscribed to in the channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SubSpecAudioUsers")]
        [Validation(Required=false)]
        public List<string> SubSpecAudioUsers { get; set; }

        /// <summary>
        /// <para>Specifies the users whose camera streams are subscribed to in the channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SubSpecCameraUsers")]
        [Validation(Required=false)]
        public List<string> SubSpecCameraUsers { get; set; }

        /// <summary>
        /// <para>Specifies the users whose screen sharing streams are subscribed to in the channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SubSpecShareScreenUsers")]
        [Validation(Required=false)]
        public List<string> SubSpecShareScreenUsers { get; set; }

        /// <summary>
        /// <para>Specifies the list of users to which the task subscribes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>userID</para>
        /// </summary>
        [NameInMap("SubSpecUsers")]
        [Validation(Required=false)]
        public List<string> SubSpecUsers { get; set; }

        /// <summary>
        /// <para>The task ID. Only a single ID is supported and the ID must be unique. The ID must be 1 to 55 characters in length and can contain letters, digits, underscores (_), and hyphens (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourTaskId</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The billing configuration of the task. You are charged based on your settings. For more information, see the TaskProfile enum values below.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The resolution of the MediaEncode encoding option must be less than or equal to the resolution of TaskProfile.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The maximum number of panes in the layout must be less than or equal to the number of input streams specified by TaskProfile.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>4IN_1080P</para>
        /// </summary>
        [NameInMap("TaskProfile")]
        [Validation(Required=false)]
        public string TaskProfile { get; set; }

        /// <summary>
        /// <para>The configuration template ID. For more information about how to obtain the template ID, see <a href="https://help.aliyun.com/document_detail/193625.html">AddRecordTemplate</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>76dasgb****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>Specifies the users whose audio streams are not subscribed to in the channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UnsubSpecAudioUsers")]
        [Validation(Required=false)]
        public List<string> UnsubSpecAudioUsers { get; set; }

        /// <summary>
        /// <para>Specifies the users whose camera streams are not subscribed to in the channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UnsubSpecCameraUsers")]
        [Validation(Required=false)]
        public List<string> UnsubSpecCameraUsers { get; set; }

        /// <summary>
        /// <para>Specifies the users whose screen sharing streams are not subscribed to in the channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UnsubSpecShareScreenUsers")]
        [Validation(Required=false)]
        public List<string> UnsubSpecShareScreenUsers { get; set; }

        /// <summary>
        /// <para>The list of layout parameters.</para>
        /// </summary>
        [NameInMap("UserPanes")]
        [Validation(Required=false)]
        public List<StartRecordTaskRequestUserPanes> UserPanes { get; set; }
        public class StartRecordTaskRequestUserPanes : TeaModel {
            /// <summary>
            /// <para>The list of image panes in the current layout.</para>
            /// </summary>
            [NameInMap("Images")]
            [Validation(Required=false)]
            public List<StartRecordTaskRequestUserPanesImages> Images { get; set; }
            public class StartRecordTaskRequestUserPanesImages : TeaModel {
                /// <summary>
                /// <para>The display mode of the image. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b> (None): The image is not displayed.</description></item>
                /// <item><description><b>1</b> (Always): The image is always displayed.</description></item>
                /// <item><description><b>2</b> (Backup): The image is displayed when the current user has no video stream.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Display")]
                [Validation(Required=false)]
                public int? Display { get; set; }

                /// <summary>
                /// <para>The height of the pane, represented as a normalized percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.2456</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public float? Height { get; set; }

                /// <summary>
                /// <para>The HTTP or HTTPS URL of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://www.example.com/image.jpg">https://www.example.com/image.jpg</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// <para>The width of the pane, represented as a normalized percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.2456</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public float? Width { get; set; }

                /// <summary>
                /// <para>The X coordinate, represented as a normalized percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.7576</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public float? X { get; set; }

                /// <summary>
                /// <para>The Y coordinate, represented as a normalized percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.7576</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public float? Y { get; set; }

                /// <summary>
                /// <para>The stacking order. 0 indicates the bottom layer, 1 indicates the layer above 0, and so on.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ZOrder")]
                [Validation(Required=false)]
                public int? ZOrder { get; set; }

            }

            /// <summary>
            /// <para>The pane ID. Valid values: <b>0</b> to <b>15</b>.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>If the user specified by PaneId is not found, other streams are displayed by default. The streams are determined based on the order in which users join the channel.</description></item>
            /// </list>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>If a parameter related to UserPanes is required, all other related parameters are also required. Otherwise, none of them are required.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("PaneId")]
            [Validation(Required=false)]
            public int? PaneId { get; set; }

            /// <summary>
            /// <para>The user video input that corresponds to the layout. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>camera</b> (default): the video stream.</description></item>
            /// <item><description><b>shareScreen</b>: the screen sharing stream.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>camera</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The list of text panes in the current layout.</para>
            /// </summary>
            [NameInMap("Texts")]
            [Validation(Required=false)]
            public List<StartRecordTaskRequestUserPanesTexts> Texts { get; set; }
            public class StartRecordTaskRequestUserPanesTexts : TeaModel {
                /// <summary>
                /// <para>The text color in RGB format. The calculation formula is R + G × 256 + B × 65536. Valid values of R (red), G (green), and B (blue): <b>0 to 255</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("FontColor")]
                [Validation(Required=false)]
                public int? FontColor { get; set; }

                /// <summary>
                /// <para>The font size. Valid values: <b>(0, 72]</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("FontSize")]
                [Validation(Required=false)]
                public int? FontSize { get; set; }

                /// <summary>
                /// <para>The font type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b> (default): NOTO_SERIF_CJKSC_REGULAR.</description></item>
                /// <item><description><b>1</b>: ALIBABA_PUHUITI_REGULAR.</description></item>
                /// <item><description><b>2</b>: ALIBABA_PUHUITI_BOLD.</description></item>
                /// <item><description><b>3</b>: ALIBABA_PUHUITI_Heavy.</description></item>
                /// <item><description><b>4</b>: ALIBABA_PUHUITI_LIGHT.</description></item>
                /// <item><description><b>5</b>: ALIBABA_PUHUITI_MEDIUM.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("FontType")]
                [Validation(Required=false)]
                public int? FontType { get; set; }

                /// <summary>
                /// <para>The text content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <para>The X coordinate, represented as a normalized percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.7576</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public float? X { get; set; }

                /// <summary>
                /// <para>The Y coordinate, represented as a normalized percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.7576</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public float? Y { get; set; }

                /// <summary>
                /// <para>The stacking order. 0 indicates the bottom layer, 1 indicates the layer above 0, and so on.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ZOrder")]
                [Validation(Required=false)]
                public int? ZOrder { get; set; }

            }

            /// <summary>
            /// <para>The ID of the user that corresponds to the layout pane. Valid values of N: <b>1 to 16</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestId</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
