// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class UpdateRecordTaskRequest : TeaModel {
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

        [NameInMap("CropMode")]
        [Validation(Required=false)]
        public long? CropMode { get; set; }

        /// <summary>
        /// <para>The array of layout IDs.</para>
        /// </summary>
        [NameInMap("LayoutIds")]
        [Validation(Required=false)]
        public List<long?> LayoutIds { get; set; }

        [NameInMap("MediaEncode")]
        [Validation(Required=false)]
        public long? MediaEncode { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Specifies the users whose audio streams are subscribed to in the channel.</para>
        /// </summary>
        [NameInMap("SubSpecAudioUsers")]
        [Validation(Required=false)]
        public List<string> SubSpecAudioUsers { get; set; }

        /// <summary>
        /// <para>Specifies the users whose camera streams are subscribed to in the channel.</para>
        /// </summary>
        [NameInMap("SubSpecCameraUsers")]
        [Validation(Required=false)]
        public List<string> SubSpecCameraUsers { get; set; }

        /// <summary>
        /// <para>Specifies the users whose screen sharing streams are subscribed to in the channel.</para>
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
        /// <para>The task ID. Only a single ID is supported. The value must be the same as the TaskId request parameter of <a href="https://help.aliyun.com/document_detail/193528.html">StartRecordTask</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourTaskId</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

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
        /// </summary>
        [NameInMap("UnsubSpecAudioUsers")]
        [Validation(Required=false)]
        public List<string> UnsubSpecAudioUsers { get; set; }

        /// <summary>
        /// <para>Specifies the users whose camera streams are not subscribed to in the channel.</para>
        /// </summary>
        [NameInMap("UnsubSpecCameraUsers")]
        [Validation(Required=false)]
        public List<string> UnsubSpecCameraUsers { get; set; }

        /// <summary>
        /// <para>Specifies the users whose screen sharing streams are not subscribed to in the channel.</para>
        /// </summary>
        [NameInMap("UnsubSpecShareScreenUsers")]
        [Validation(Required=false)]
        public List<string> UnsubSpecShareScreenUsers { get; set; }

        /// <summary>
        /// <para>The list of layout parameters.</para>
        /// </summary>
        [NameInMap("UserPanes")]
        [Validation(Required=false)]
        public List<UpdateRecordTaskRequestUserPanes> UserPanes { get; set; }
        public class UpdateRecordTaskRequestUserPanes : TeaModel {
            /// <summary>
            /// <para>The list of image panes in the current layout.</para>
            /// </summary>
            [NameInMap("Images")]
            [Validation(Required=false)]
            public List<UpdateRecordTaskRequestUserPanesImages> Images { get; set; }
            public class UpdateRecordTaskRequestUserPanesImages : TeaModel {
                /// <summary>
                /// <para>Specifies whether to display the image. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b> (None): Not displayed.</description></item>
                /// <item><description><b>1</b> (Always): Always displayed.</description></item>
                /// <item><description><b>2</b> (Backup): Displayed when the current user has no video stream.</description></item>
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
                /// <para>The Z-order. 0 indicates the bottom layer, 1 indicates the layer above 0, and so on.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ZOrder")]
                [Validation(Required=false)]
                public int? ZOrder { get; set; }

            }

            /// <summary>
            /// <para>The pane ID. Valid values of N: <b>1 to 16</b>. Valid values of PaneId: <b>0 to 15</b>.</para>
            /// <remarks>
            /// <para>If the user specified by PaneId is not found, other streams are displayed by default. The streams are determined based on the order in which users join the channel.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PaneId")]
            [Validation(Required=false)]
            public int? PaneId { get; set; }

            /// <summary>
            /// <para>The video input source of the user corresponding to the layout. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>camera</b> (default): the video stream.</description></item>
            /// <item><description><b>shareScreen</b>: the screen sharing stream.</description></item>
            /// </list>
            /// <para>Valid values of N: <b>1 to 16</b>.</para>
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
            public List<UpdateRecordTaskRequestUserPanesTexts> Texts { get; set; }
            public class UpdateRecordTaskRequestUserPanesTexts : TeaModel {
                /// <summary>
                /// <para>The text color in RGB format. The calculation formula is R + G × 256 + B × 65536. Valid values of R (red), G (green), and B (blue): <b>0 to 255</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
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
                /// <para>The Z-order. 0 indicates the bottom layer, 1 indicates the layer above 0, and so on.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ZOrder")]
                [Validation(Required=false)]
                public int? ZOrder { get; set; }

            }

            /// <summary>
            /// <para>The ID of the user corresponding to the layout pane. Valid values of N: <b>1 to 16</b>.</para>
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
