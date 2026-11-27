// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class UpdateMPUTaskRequest : TeaModel {
        /// <summary>
        /// <para>Application ID. Only a single ID can be passed.</para>
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
        /// <para>Background color RGB. The default is <b>0</b> (black).</para>
        /// <para>The calculation formula is <c>R + G × 256 + B × 65536</c>. Values of R (red), G (green), and B (blue): <b>0</b> to <b>255</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("BackgroundColor")]
        [Validation(Required=false)]
        public int? BackgroundColor { get; set; }

        /// <summary>
        /// <para>The list of canvas background image pane positions.</para>
        /// </summary>
        [NameInMap("Backgrounds")]
        [Validation(Required=false)]
        public List<UpdateMPUTaskRequestBackgrounds> Backgrounds { get; set; }
        public class UpdateMPUTaskRequestBackgrounds : TeaModel {
            /// <summary>
            /// <para>Image display. Values:</para>
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
            /// <para>Pane height, normalized percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2456</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public float? Height { get; set; }

            /// <summary>
            /// <para>HTTP or HTTPS address of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.example.com/image.jpg">https://www.example.com/image.jpg</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            /// <summary>
            /// <para>Pane width, normalized percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2456</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public float? Width { get; set; }

            /// <summary>
            /// <para>X coordinate, normalized percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.7576</para>
            /// </summary>
            [NameInMap("X")]
            [Validation(Required=false)]
            public float? X { get; set; }

            /// <summary>
            /// <para>Y coordinate, normalized percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.7576</para>
            /// </summary>
            [NameInMap("Y")]
            [Validation(Required=false)]
            public float? Y { get; set; }

            /// <summary>
            /// <para>Stacking order. 0 is the bottom layer, layer 1 is above layer 0, and so on.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ZOrder")]
            [Validation(Required=false)]
            public int? ZOrder { get; set; }

        }

        /// <summary>
        /// <para>Clock widget.</para>
        /// </summary>
        [NameInMap("ClockWidgets")]
        [Validation(Required=false)]
        public List<UpdateMPUTaskRequestClockWidgets> ClockWidgets { get; set; }
        public class UpdateMPUTaskRequestClockWidgets : TeaModel {
            /// <summary>
            /// <para>Transparency of the text box and text. 0.0 indicates transparent, and 1.0 indicates completely opaque.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Alpha")]
            [Validation(Required=false)]
            public float? Alpha { get; set; }

            /// <summary>
            /// <para>Text border color.
            /// The calculation formula is <c>R + G × 256 + B × 65536</c>. Values of R (red), G (green), and B (blue): <b>0</b> to <b>255</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("BorderColor")]
            [Validation(Required=false)]
            public long? BorderColor { get; set; }

            /// <summary>
            /// <para>Text border width (unit: pixels). The default value is 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BorderWidth")]
            [Validation(Required=false)]
            public int? BorderWidth { get; set; }

            /// <summary>
            /// <para>Whether to display a text box. Values:</para>
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
            /// <para>Text box width (unit: pixels). The default value is 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("BoxBorderWidth")]
            [Validation(Required=false)]
            public int? BoxBorderWidth { get; set; }

            /// <summary>
            /// <para>Text box color.
            /// The calculation formula is <c>R + G × 256 + B × 65536</c>. Values of R (red), G (green), and B (blue): <b>0</b> to <b>255</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("BoxColor")]
            [Validation(Required=false)]
            public long? BoxColor { get; set; }

            /// <summary>
            /// <para>Text color (RGB).</para>
            /// <para>The calculation formula is <c>R + G × 256 + B × 65536</c>. Values of R (red), G (green), and B (blue): <b>0</b> to <b>255</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("FontColor")]
            [Validation(Required=false)]
            public int? FontColor { get; set; }

            /// <summary>
            /// <para>Font size. Value range: <b>0</b> to <b>72</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FontSize")]
            [Validation(Required=false)]
            public int? FontSize { get; set; }

            /// <summary>
            /// <para>Font type. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b> (default): NOTO_SERIF_CJKSC_REGULAR</description></item>
            /// <item><description><b>1</b>: ALIBABA_PUHUITI_REGULAR</description></item>
            /// <item><description><b>2</b>: ALIBABA_PUHUITI_BOLD</description></item>
            /// <item><description><b>3</b>: ALIBABA_PUHUITI_Heavy</description></item>
            /// <item><description><b>4</b>: ALIBABA_PUHUITI_LIGHT</description></item>
            /// <item><description><b>5</b>: ALIBABA_PUHUITI_MEDIUM</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("FontType")]
            [Validation(Required=false)]
            public int? FontType { get; set; }

            /// <summary>
            /// <para>X coordinate, normalized percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.7576</para>
            /// </summary>
            [NameInMap("X")]
            [Validation(Required=false)]
            public float? X { get; set; }

            /// <summary>
            /// <para>Y coordinate, normalized percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.7576</para>
            /// </summary>
            [NameInMap("Y")]
            [Validation(Required=false)]
            public float? Y { get; set; }

            /// <summary>
            /// <para>Stacking order. 0 is the bottom layer, layer 1 is above layer 0, and so on.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ZOrder")]
            [Validation(Required=false)]
            public int? ZOrder { get; set; }

        }

        /// <summary>
        /// <para>Video cropping mode. Values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: crop while maintaining ratio.</para>
        /// </description></item>
        /// <item><description><para><b>2</b> (default): keep margins while maintaining ratio.</para>
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
        /// <para>Layout ID data.</para>
        /// </summary>
        [NameInMap("LayoutIds")]
        [Validation(Required=false)]
        public List<long?> LayoutIds { get; set; }

        /// <summary>
        /// <para>Encoding option. See the MediaEncode enumeration values below.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MediaEncode")]
        [Validation(Required=false)]
        public int? MediaEncode { get; set; }

        /// <summary>
        /// <para>Stream mixing mode. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: single-stream relay. No stream mixing or transcoding. Only the original single stream is relayed. No need to configure stream mixing and transcoding parameters.</description></item>
        /// <item><description><b>1</b>: stream mixing and transcoding (default). Supports stream mixing and transcoding output.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Valid parameters in single-stream relay mode: <b>StreamType</b>, <b>SourceType</b>.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Valid parameters in stream mixing and transcoding mode: <b>MediaEncode</b>, <b>LayoutIds</b>, <b>BackgroundColor</b>, <b>SubSpecUsers</b>, <b>CropMode</b>, <b>UserPanes</b>, <b>Backgrounds</b>, <b>Watermarks</b>.</description></item>
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
        /// <para>User video input stream in single-stream relay mode. Values:</para>
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
        /// <para>Audio stream relayed in single-stream relay mode. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b> (default): relay the original stream.</description></item>
        /// <item><description><b>1</b>: relay only the audio stream.</description></item>
        /// <item><description><b>2</b>: relay only the video stream.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("StreamType")]
        [Validation(Required=false)]
        public int? StreamType { get; set; }

        /// <summary>
        /// <para>Specifies the users in the room whose audio streams are subscribed to.</para>
        /// </summary>
        [NameInMap("SubSpecAudioUsers")]
        [Validation(Required=false)]
        public List<string> SubSpecAudioUsers { get; set; }

        /// <summary>
        /// <para>Specifies the users in the room whose camera video streams are subscribed to.</para>
        /// </summary>
        [NameInMap("SubSpecCameraUsers")]
        [Validation(Required=false)]
        public List<string> SubSpecCameraUsers { get; set; }

        /// <summary>
        /// <para>Specifies the users in the room whose shared video streams are subscribed to.</para>
        /// </summary>
        [NameInMap("SubSpecShareScreenUsers")]
        [Validation(Required=false)]
        public List<string> SubSpecShareScreenUsers { get; set; }

        /// <summary>
        /// <para>The list of users subscribed to by this task.</para>
        /// </summary>
        [NameInMap("SubSpecUsers")]
        [Validation(Required=false)]
        public List<string> SubSpecUsers { get; set; }

        /// <summary>
        /// <para>Task ID. Only a single ID can be passed. It is consistent with the input parameter TaskId in <a href="https://help.aliyun.com/document_detail/93183.html">StartMpuTask</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testId</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>Specifies the users in the room whose audio streams are not subscribed to.</para>
        /// </summary>
        [NameInMap("UnsubSpecAudioUsers")]
        [Validation(Required=false)]
        public List<string> UnsubSpecAudioUsers { get; set; }

        /// <summary>
        /// <para>Specifies the users in the room whose camera video streams are not subscribed to.</para>
        /// </summary>
        [NameInMap("UnsubSpecCameraUsers")]
        [Validation(Required=false)]
        public List<string> UnsubSpecCameraUsers { get; set; }

        /// <summary>
        /// <para>Specifies the users in the room whose shared video streams are not subscribed to.</para>
        /// </summary>
        [NameInMap("UnsubSpecShareScreenUsers")]
        [Validation(Required=false)]
        public List<string> UnsubSpecShareScreenUsers { get; set; }

        /// <summary>
        /// <para>Layout parameters.</para>
        /// </summary>
        [NameInMap("UserPanes")]
        [Validation(Required=false)]
        public List<UpdateMPUTaskRequestUserPanes> UserPanes { get; set; }
        public class UpdateMPUTaskRequestUserPanes : TeaModel {
            /// <summary>
            /// <para>The list of image pane positions for the current layout.</para>
            /// </summary>
            [NameInMap("Images")]
            [Validation(Required=false)]
            public List<UpdateMPUTaskRequestUserPanesImages> Images { get; set; }
            public class UpdateMPUTaskRequestUserPanesImages : TeaModel {
                /// <summary>
                /// <para>Image display. Values:</para>
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
                /// <para>Pane height, normalized percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.2456</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public float? Height { get; set; }

                /// <summary>
                /// <para>HTTP or HTTPS address of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://www.example.com/image.jpg">https://www.example.com/image.jpg</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// <para>Pane width, normalized percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.2456</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public float? Width { get; set; }

                /// <summary>
                /// <para>X coordinate, normalized percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.7576</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public float? X { get; set; }

                /// <summary>
                /// <para>Y coordinate, normalized percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.7576</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public float? Y { get; set; }

                /// <summary>
                /// <para>Stacking order. 0 is the bottom layer, layer 1 is above layer 0, and so on.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ZOrder")]
                [Validation(Required=false)]
                public int? ZOrder { get; set; }

            }

            /// <summary>
            /// <para>Pane ID. Value range: <b>0</b> to <b>15</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("PaneId")]
            [Validation(Required=false)]
            public int? PaneId { get; set; }

            /// <summary>
            /// <para>Portrait segmentation type. Values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: no portrait segmentation (default).</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: portrait segmentation. Only effective after the enhancement parameter (portrait segmentation feature) is enabled.</para>
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
            /// <para>User video input corresponding to the layout. Values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>camera</b>: camera stream.</para>
            /// </description></item>
            /// <item><description><para><b>shareScreen</b>: shared screen stream.</para>
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
            /// <para>The list of text pane positions for the current layout.</para>
            /// </summary>
            [NameInMap("Texts")]
            [Validation(Required=false)]
            public List<UpdateMPUTaskRequestUserPanesTexts> Texts { get; set; }
            public class UpdateMPUTaskRequestUserPanesTexts : TeaModel {
                /// <summary>
                /// <para>Transparency of the text box and text. 0.0 indicates transparent, and 1.0 indicates completely opaque.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Alpha")]
                [Validation(Required=false)]
                public float? Alpha { get; set; }

                /// <summary>
                /// <para>Text border color.
                /// The calculation formula is <c>R + G × 256 + B × 65536</c>. Values of R (red), G (green), and B (blue): <b>0</b> to <b>255</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("BorderColor")]
                [Validation(Required=false)]
                public long? BorderColor { get; set; }

                /// <summary>
                /// <para>Text border width (unit: pixels). The default value is 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("BorderWidth")]
                [Validation(Required=false)]
                public int? BorderWidth { get; set; }

                /// <summary>
                /// <para>Whether to display a text box. Values:</para>
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
                /// <para>Text box width (unit: pixels). The default value is 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("BoxBorderWidth")]
                [Validation(Required=false)]
                public int? BoxBorderWidth { get; set; }

                /// <summary>
                /// <para>Text box color.
                /// The calculation formula is <c>R + G × 256 + B × 65536</c>. Values of R (red), G (green), and B (blue): <b>0</b> to <b>255</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("BoxColor")]
                [Validation(Required=false)]
                public long? BoxColor { get; set; }

                /// <summary>
                /// <para>Text color (RGB).</para>
                /// <para>The calculation formula is <c>R + G × 256 + B × 65536</c>. Values of R (red), G (green), and B (blue): <b>0</b> to <b>255</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("FontColor")]
                [Validation(Required=false)]
                public int? FontColor { get; set; }

                /// <summary>
                /// <para>Font size. Value range: <b>0</b> to <b>72</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("FontSize")]
                [Validation(Required=false)]
                public int? FontSize { get; set; }

                /// <summary>
                /// <para>Font type. Values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b> (default): NOTO_SERIF_CJKSC_REGULAR</description></item>
                /// <item><description><b>1</b>: ALIBABA_PUHUITI_REGULAR</description></item>
                /// <item><description><b>2</b>: ALIBABA_PUHUITI_BOLD</description></item>
                /// <item><description><b>3</b>: ALIBABA_PUHUITI_Heavy</description></item>
                /// <item><description><b>4</b>: ALIBABA_PUHUITI_LIGHT</description></item>
                /// <item><description><b>5</b>: ALIBABA_PUHUITI_MEDIUM</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("FontType")]
                [Validation(Required=false)]
                public int? FontType { get; set; }

                /// <summary>
                /// <para>Text content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <para>X coordinate, normalized percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.7576</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public float? X { get; set; }

                /// <summary>
                /// <para>Y coordinate, normalized percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.7576</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public float? Y { get; set; }

                /// <summary>
                /// <para>Stacking order. 0 is the bottom layer, layer 1 is above layer 0, and so on.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ZOrder")]
                [Validation(Required=false)]
                public int? ZOrder { get; set; }

            }

            /// <summary>
            /// <para>The user ID corresponding to the layout pane. Values: <b>1</b> to <b>16</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestUserID</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The list of watermark image pane positions.</para>
        /// </summary>
        [NameInMap("Watermarks")]
        [Validation(Required=false)]
        public List<UpdateMPUTaskRequestWatermarks> Watermarks { get; set; }
        public class UpdateMPUTaskRequestWatermarks : TeaModel {
            /// <summary>
            /// <para>Transparency. 0.0 indicates transparent, and 1.0 indicates completely opaque.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Alpha")]
            [Validation(Required=false)]
            public float? Alpha { get; set; }

            /// <summary>
            /// <para>Image display. Values:</para>
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
            /// <para>Pane height, normalized percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2456</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public float? Height { get; set; }

            /// <summary>
            /// <para>HTTP or HTTPS address of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.example.com/image.jpg">https://www.example.com/image.jpg</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            /// <summary>
            /// <para>Pane width, normalized percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2456</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public float? Width { get; set; }

            /// <summary>
            /// <para>X coordinate, normalized percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.7576</para>
            /// </summary>
            [NameInMap("X")]
            [Validation(Required=false)]
            public float? X { get; set; }

            /// <summary>
            /// <para>Y coordinate, normalized percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.7576</para>
            /// </summary>
            [NameInMap("Y")]
            [Validation(Required=false)]
            public float? Y { get; set; }

            /// <summary>
            /// <para>Stacking order. 0 is the bottom layer, layer 1 is above layer 0, and so on.</para>
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
