// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class StartMPUTaskRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. Only a single ID is supported.</para>
        /// <para>You can create and query it in the console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourAppId</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The RGB value of the background color. Default value: <b>0</b> (black).</para>
        /// <para>The formula is <c>R + G × 256 + B × 65536</c>. Valid values for R (red), G (green), and B (blue): 0 to 255.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("BackgroundColor")]
        [Validation(Required=false)]
        public int? BackgroundColor { get; set; }

        /// <summary>
        /// <para>The canvas background image panes.</para>
        /// </summary>
        [NameInMap("Backgrounds")]
        [Validation(Required=false)]
        public List<StartMPUTaskRequestBackgrounds> Backgrounds { get; set; }
        public class StartMPUTaskRequestBackgrounds : TeaModel {
            /// <summary>
            /// <para>Specifies whether to display the image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0 (None)</b>: not displayed.</description></item>
            /// <item><description><b>1 (Always)</b>: always displayed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Display")]
            [Validation(Required=false)]
            public int? Display { get; set; }

            /// <summary>
            /// <para>The height of the pane, as a normalized percentage.</para>
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
            /// <para>The width of the pane, as a normalized percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2456</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public float? Width { get; set; }

            /// <summary>
            /// <para>The X-coordinate, as a normalized percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.7576</para>
            /// </summary>
            [NameInMap("X")]
            [Validation(Required=false)]
            public float? X { get; set; }

            /// <summary>
            /// <para>The Y-coordinate, as a normalized percentage.</para>
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
        /// <para>The clock widgets.</para>
        /// </summary>
        [NameInMap("ClockWidgets")]
        [Validation(Required=false)]
        public List<StartMPUTaskRequestClockWidgets> ClockWidgets { get; set; }
        public class StartMPUTaskRequestClockWidgets : TeaModel {
            /// <summary>
            /// <para>The transparency of the text box and text. A value of 0.0 indicates fully transparent, and 1.0 indicates fully opaque.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Alpha")]
            [Validation(Required=false)]
            public float? Alpha { get; set; }

            /// <summary>
            /// <para>The text stroke color in RGB format.
            /// The formula is <c>R + G × 256 + B × 65536</c>. Valid values for R (red), G (green), and B (blue): <b>0</b> to <b>255</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("BorderColor")]
            [Validation(Required=false)]
            public long? BorderColor { get; set; }

            /// <summary>
            /// <para>The text stroke width, in pixels. Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BorderWidth")]
            [Validation(Required=false)]
            public int? BorderWidth { get; set; }

            /// <summary>
            /// <para>Specifies whether to display the text box. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>false (default): not displayed.</description></item>
            /// <item><description>true: displayed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Box")]
            [Validation(Required=false)]
            public bool? Box { get; set; }

            /// <summary>
            /// <para>The text box border width, in pixels. Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("BoxBorderWidth")]
            [Validation(Required=false)]
            public int? BoxBorderWidth { get; set; }

            /// <summary>
            /// <para>The text box color in RGB format.
            /// The formula is <c>R + G × 256 + B × 65536</c>. Valid values for R (red), G (green), and B (blue): <b>0</b> to <b>255</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("BoxColor")]
            [Validation(Required=false)]
            public long? BoxColor { get; set; }

            /// <summary>
            /// <para>The text color in RGB format.</para>
            /// <para>The formula is <c>R + G × 256 + B × 65536</c>. Valid values for R (red), G (green), and B (blue): <b>0</b> to <b>255</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("FontColor")]
            [Validation(Required=false)]
            public int? FontColor { get; set; }

            /// <summary>
            /// <para>The font size. Valid values: <b>0</b> to <b>72</b>.</para>
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
            /// <item><description><b>0</b>: NOTO_SERIF_CJKSC_REGULAR (default).</description></item>
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
            /// <para>The X-coordinate, as a normalized percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.7576</para>
            /// </summary>
            [NameInMap("X")]
            [Validation(Required=false)]
            public float? X { get; set; }

            /// <summary>
            /// <para>The Y-coordinate, as a normalized percentage.</para>
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
        /// <para>The video cropping mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: crop while keeping the aspect ratio.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: keep the aspect ratio and add padding (default).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CropMode")]
        [Validation(Required=false)]
        public int? CropMode { get; set; }

        /// <summary>
        /// <para>The enhanced parameters.</para>
        /// </summary>
        [NameInMap("EnhancedParam")]
        [Validation(Required=false)]
        public StartMPUTaskRequestEnhancedParam EnhancedParam { get; set; }
        public class StartMPUTaskRequestEnhancedParam : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable the portrait segmentation feature (in closed beta). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: enabled.</description></item>
            /// <item><description><b>false</b> (default): disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnablePortraitSegmentation")]
            [Validation(Required=false)]
            public bool? EnablePortraitSegmentation { get; set; }

        }

        /// <summary>
        /// <para>The layout IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("LayoutIds")]
        [Validation(Required=false)]
        public List<long?> LayoutIds { get; set; }

        /// <summary>
        /// <para>The encoding options. For more information, see the MediaEncode enum values below.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MediaEncode")]
        [Validation(Required=false)]
        public int? MediaEncode { get; set; }

        /// <summary>
        /// <para>The mixed streaming mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: single-stream relay. The original single stream is relayed without mixed-stream transcoding. You do not need to configure mixed-stream transcoding parameters.</description></item>
        /// <item><description><b>1</b>: mixed-stream transcoding (default). Mixed-stream transcoding output is supported.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Valid parameters in single-stream relay mode: <b>StreamType</b>, <b>SourceType</b>, and <b>SubSpecUsers</b>.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Valid parameters in mixed-stream transcoding mode: <b>MediaEncode</b>, <b>LayoutIds</b>, <b>BackgroundColor</b>, <b>SubSpecUsers</b>, <b>CropMode</b>, <b>UserPanes</b>, <b>Backgrounds</b>, and <b>Watermarks</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MixMode")]
        [Validation(Required=false)]
        public int? MixMode { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The payload type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: do not use a payload.</description></item>
        /// <item><description><b>1</b>: use VideoSEI.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PayloadType")]
        [Validation(Required=false)]
        public int? PayloadType { get; set; }

        /// <summary>
        /// <para>The voice activity detection (VAD) flag. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: do not pass VAD information.</description></item>
        /// <item><description><b>1</b>: pass VAD information.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ReportVad")]
        [Validation(Required=false)]
        public int? ReportVad { get; set; }

        /// <summary>
        /// <para>The RTP extension header information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: do not pass.</description></item>
        /// <item><description><b>1</b>: pass.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RtpExtInfo")]
        [Validation(Required=false)]
        public int? RtpExtInfo { get; set; }

        /// <summary>
        /// <para>The user video input stream in single-stream relay mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>camera</b>: camera.</description></item>
        /// <item><description><b>shareScreen</b>: screen sharing.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>camera</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The stream type to relay in single-stream relay mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: relay the original stream.</description></item>
        /// <item><description><b>1</b>: relay only the audio stream.</description></item>
        /// <item><description><b>2</b>: relay only the video stream.</description></item>
        /// </list>
        /// <para>By default, the original stream is relayed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("StreamType")]
        [Validation(Required=false)]
        public int? StreamType { get; set; }

        /// <summary>
        /// <para>The live streaming ingest URL. Only a single URL is supported. For more information about the generation rules, see <a href="https://help.aliyun.com/document_detail/199339.html">Ingest and streaming URLs</a>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>For domain names with hotlink protection authentication enabled, the ingest URL must include an authentication string.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The same StreamURL cannot be used simultaneously in different tasks.</description></item>
        /// <item><description>The same StreamURL cannot be used within 10 seconds after a task is stopped.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>rtmp://example.com/live/stream</para>
        /// </summary>
        [NameInMap("StreamURL")]
        [Validation(Required=false)]
        public string StreamURL { get; set; }

        /// <summary>
        /// <para>Specifies the users whose audio streams are subscribed to in the channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>audioUserID</para>
        /// </summary>
        [NameInMap("SubSpecAudioUsers")]
        [Validation(Required=false)]
        public List<string> SubSpecAudioUsers { get; set; }

        /// <summary>
        /// <para>Specifies the users whose camera video streams are subscribed to in the channel.</para>
        /// </summary>
        [NameInMap("SubSpecCameraUsers")]
        [Validation(Required=false)]
        public List<string> SubSpecCameraUsers { get; set; }

        /// <summary>
        /// <para>Specifies the users whose screen sharing video streams are subscribed to in the channel.</para>
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
        /// <para>The task ID. Only a single ID is supported. The ID can contain letters, digits, underscores (_), and hyphens (-), and can be up to 55 bytes in length.</para>
        /// <remarks>
        /// <para>This ID identifies the bypass live streaming task and must be unique.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourTaskId</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The media processing type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: bypass live streaming task.</description></item>
        /// <item><description><b>1</b>: MCU mixed-stream low-latency distribution task.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public int? TaskType { get; set; }

        /// <summary>
        /// <para>The timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15273582735</para>
        /// </summary>
        [NameInMap("TimeStampRef")]
        [Validation(Required=false)]
        public long? TimeStampRef { get; set; }

        /// <summary>
        /// <para>Specifies the users whose audio streams are not subscribed to in the channel.</para>
        /// </summary>
        [NameInMap("UnsubSpecAudioUsers")]
        [Validation(Required=false)]
        public List<string> UnsubSpecAudioUsers { get; set; }

        /// <summary>
        /// <para>Specifies the users whose camera video streams are not subscribed to in the channel.</para>
        /// </summary>
        [NameInMap("UnsubSpecCameraUsers")]
        [Validation(Required=false)]
        public List<string> UnsubSpecCameraUsers { get; set; }

        /// <summary>
        /// <para>Specifies the users whose screen sharing video streams are not subscribed to in the channel.</para>
        /// </summary>
        [NameInMap("UnsubSpecShareScreenUsers")]
        [Validation(Required=false)]
        public List<string> UnsubSpecShareScreenUsers { get; set; }

        /// <summary>
        /// <para>The layout parameters.</para>
        /// </summary>
        [NameInMap("UserPanes")]
        [Validation(Required=false)]
        public List<StartMPUTaskRequestUserPanes> UserPanes { get; set; }
        public class StartMPUTaskRequestUserPanes : TeaModel {
            /// <summary>
            /// <para>The image panes in the current layout.</para>
            /// </summary>
            [NameInMap("Images")]
            [Validation(Required=false)]
            public List<StartMPUTaskRequestUserPanesImages> Images { get; set; }
            public class StartMPUTaskRequestUserPanesImages : TeaModel {
                /// <summary>
                /// <para>Specifies whether to display the image. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0 (None)</b>: not displayed.</description></item>
                /// <item><description><b>1 (Always)</b>: always displayed.</description></item>
                /// <item><description><b>2 (Backup)</b>: displayed when the current user has no video stream.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Display")]
                [Validation(Required=false)]
                public int? Display { get; set; }

                /// <summary>
                /// <para>The height of the pane, as a normalized percentage.</para>
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
                /// <para>The width of the pane, as a normalized percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.2456</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public float? Width { get; set; }

                /// <summary>
                /// <para>The X-coordinate, as a normalized percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.7576</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public float? X { get; set; }

                /// <summary>
                /// <para>The Y-coordinate, as a normalized percentage.</para>
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
            /// <para>If the user specified by PaneId is not found, the system displays other streams by default. The streams are determined based on the order in which users join the channel.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("PaneId")]
            [Validation(Required=false)]
            public int? PaneId { get; set; }

            /// <summary>
            /// <para>The portrait segmentation type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: no portrait segmentation (default).</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: portrait segmentation. This value takes effect only after the portrait segmentation feature is enabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SegmentType")]
            [Validation(Required=false)]
            public int? SegmentType { get; set; }

            /// <summary>
            /// <para>The user video input corresponding to the layout. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>camera</b>: video stream (default).</description></item>
            /// <item><description><b>shareScreen</b>: screen sharing stream.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>camera</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The text panes in the current layout.</para>
            /// </summary>
            [NameInMap("Texts")]
            [Validation(Required=false)]
            public List<StartMPUTaskRequestUserPanesTexts> Texts { get; set; }
            public class StartMPUTaskRequestUserPanesTexts : TeaModel {
                /// <summary>
                /// <para>The transparency of the text box and text. A value of 0.0 indicates fully transparent, and 1.0 indicates fully opaque.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Alpha")]
                [Validation(Required=false)]
                public float? Alpha { get; set; }

                /// <summary>
                /// <para>The text stroke color in RGB format.
                /// The formula is <c>R + G × 256 + B × 65536</c>. Valid values for R (red), G (green), and B (blue): <b>0</b> to <b>255</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("BorderColor")]
                [Validation(Required=false)]
                public long? BorderColor { get; set; }

                /// <summary>
                /// <para>The text stroke width, in pixels. Default value: 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("BorderWidth")]
                [Validation(Required=false)]
                public int? BorderWidth { get; set; }

                /// <summary>
                /// <para>Specifies whether to display the text box. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>false (default): not displayed.</description></item>
                /// <item><description>true: displayed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Box")]
                [Validation(Required=false)]
                public bool? Box { get; set; }

                /// <summary>
                /// <para>The text box border width, in pixels. Default value: 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("BoxBorderWidth")]
                [Validation(Required=false)]
                public int? BoxBorderWidth { get; set; }

                /// <summary>
                /// <para>The text box color in RGB format.
                /// The formula is <c>R + G × 256 + B × 65536</c>. Valid values for R (red), G (green), and B (blue): <b>0</b> to <b>255</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("BoxColor")]
                [Validation(Required=false)]
                public long? BoxColor { get; set; }

                /// <summary>
                /// <para>The text color in RGB format.</para>
                /// <para>The formula is <c>R + G × 256 + B × 65536</c>. Valid values for R (red), G (green), and B (blue): <b>0</b> to <b>255</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("FontColor")]
                [Validation(Required=false)]
                public int? FontColor { get; set; }

                /// <summary>
                /// <para>The font size. Valid values: <b>0</b> to <b>72</b>.</para>
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
                /// <item><description><b>0</b>: NOTO_SERIF_CJKSC_REGULAR (default).</description></item>
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
                /// <para>The X-coordinate, as a normalized percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.7576</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public float? X { get; set; }

                /// <summary>
                /// <para>The Y-coordinate, as a normalized percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.2456</para>
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
            /// <para>The ID of the user corresponding to the layout pane. Valid values: <b>1</b> to <b>16</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestId</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The callback interval for voice activity detection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86400</para>
        /// </summary>
        [NameInMap("VadInterval")]
        [Validation(Required=false)]
        public long? VadInterval { get; set; }

        /// <summary>
        /// <para>The watermark image panes.</para>
        /// </summary>
        [NameInMap("Watermarks")]
        [Validation(Required=false)]
        public List<StartMPUTaskRequestWatermarks> Watermarks { get; set; }
        public class StartMPUTaskRequestWatermarks : TeaModel {
            /// <summary>
            /// <para>The transparency. A value of 0.0 indicates fully transparent, and 1.0 indicates fully opaque.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Alpha")]
            [Validation(Required=false)]
            public float? Alpha { get; set; }

            /// <summary>
            /// <para>Specifies whether to display the image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0 (None)</b>: not displayed.</description></item>
            /// <item><description><b>1 (Always)</b>: always displayed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Display")]
            [Validation(Required=false)]
            public int? Display { get; set; }

            /// <summary>
            /// <para>The height of the pane, as a normalized percentage.</para>
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
            /// <para>The width of the pane, as a normalized percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2456</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public float? Width { get; set; }

            /// <summary>
            /// <para>The X-coordinate, as a normalized percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.7576</para>
            /// </summary>
            [NameInMap("X")]
            [Validation(Required=false)]
            public float? X { get; set; }

            /// <summary>
            /// <para>The Y-coordinate, as a normalized percentage.</para>
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

    }

}
