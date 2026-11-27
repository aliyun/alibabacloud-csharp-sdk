// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class ModifyViewLayoutShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. You can create and query the ID in the console. Only a single ID is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eo85****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The background images.</para>
        /// </summary>
        [NameInMap("Backgrounds")]
        [Validation(Required=false)]
        public List<ModifyViewLayoutShrinkRequestBackgrounds> Backgrounds { get; set; }
        public class ModifyViewLayoutShrinkRequestBackgrounds : TeaModel {
            /// <summary>
            /// <para>The opacity of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.9</para>
            /// </summary>
            [NameInMap("Alpha")]
            [Validation(Required=false)]
            public double? Alpha { get; set; }

            /// <summary>
            /// <para>The crop mode of the image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Crops the image while maintaining the aspect ratio.</description></item>
            /// <item><description><b>2</b>: Maintains the aspect ratio and adds padding.</description></item>
            /// <item><description><b>3</b>: Stretches the image to fill the area.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("BackgroundCropMode")]
            [Validation(Required=false)]
            public int? BackgroundCropMode { get; set; }

            /// <summary>
            /// <para>The height.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public double? Height { get; set; }

            /// <summary>
            /// <para>The z-axis layer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Layer")]
            [Validation(Required=false)]
            public int? Layer { get; set; }

            /// <summary>
            /// <para>The URL of the image.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://aliyun.com/123.jpg">https://aliyun.com/123.jpg</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            /// <summary>
            /// <para>The width.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public double? Width { get; set; }

            /// <summary>
            /// <para>The x-coordinate.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("X")]
            [Validation(Required=false)]
            public double? X { get; set; }

            /// <summary>
            /// <para>The y-coordinate.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("Y")]
            [Validation(Required=false)]
            public double? Y { get; set; }

        }

        /// <summary>
        /// <para>The ID of an existing channel. Only a single ID is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testid</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// <para>The global clock watermark.</para>
        /// </summary>
        [NameInMap("ClockWidgets")]
        [Validation(Required=false)]
        public List<ModifyViewLayoutShrinkRequestClockWidgets> ClockWidgets { get; set; }
        public class ModifyViewLayoutShrinkRequestClockWidgets : TeaModel {
            /// <summary>
            /// <para>The opacity of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.9</para>
            /// </summary>
            [NameInMap("Alpha")]
            [Validation(Required=false)]
            public double? Alpha { get; set; }

            /// <summary>
            /// <para>The opacity of the text box.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.6</para>
            /// </summary>
            [NameInMap("BoxAlpha")]
            [Validation(Required=false)]
            public double? BoxAlpha { get; set; }

            /// <summary>
            /// <para>The border width of the text box.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("BoxBorderw")]
            [Validation(Required=false)]
            public int? BoxBorderw { get; set; }

            /// <summary>
            /// <para>The border color of the text box.</para>
            /// </summary>
            [NameInMap("BoxColor")]
            [Validation(Required=false)]
            public ModifyViewLayoutShrinkRequestClockWidgetsBoxColor BoxColor { get; set; }
            public class ModifyViewLayoutShrinkRequestClockWidgetsBoxColor : TeaModel {
                /// <summary>
                /// <para>The blue component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("B")]
                [Validation(Required=false)]
                public int? B { get; set; }

                /// <summary>
                /// <para>The green component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("G")]
                [Validation(Required=false)]
                public int? G { get; set; }

                /// <summary>
                /// <para>The red component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("R")]
                [Validation(Required=false)]
                public int? R { get; set; }

            }

            /// <summary>
            /// <para>The font. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Alibaba PuHuiTi Regular</description></item>
            /// <item><description><b>1</b>: Alibaba PuHuiTi Light</description></item>
            /// <item><description><b>2</b>: Alibaba PuHuiTi Medium</description></item>
            /// <item><description><b>3</b>: Alibaba PuHuiTi Bold</description></item>
            /// <item><description><b>4</b>: Alibaba PuHuiTi Heavy</description></item>
            /// <item><description><b>5</b>: Alimama ShuHeiTi</description></item>
            /// <item><description><b>6</b>: DingTalk JinBuTi</description></item>
            /// <item><description><b>7</b>: Alimama DaoLiTi</description></item>
            /// <item><description><b>8</b>: Alimama DongFangDaKai</description></item>
            /// <item><description><b>9</b>: Alimama FangYuanTi</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Font")]
            [Validation(Required=false)]
            public int? Font { get; set; }

            /// <summary>
            /// <para>The font color.</para>
            /// </summary>
            [NameInMap("FontColor")]
            [Validation(Required=false)]
            public ModifyViewLayoutShrinkRequestClockWidgetsFontColor FontColor { get; set; }
            public class ModifyViewLayoutShrinkRequestClockWidgetsFontColor : TeaModel {
                /// <summary>
                /// <para>The blue component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("B")]
                [Validation(Required=false)]
                public int? B { get; set; }

                /// <summary>
                /// <para>The green component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("G")]
                [Validation(Required=false)]
                public int? G { get; set; }

                /// <summary>
                /// <para>The red component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("R")]
                [Validation(Required=false)]
                public int? R { get; set; }

            }

            /// <summary>
            /// <para>The clock font size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("FontSize")]
            [Validation(Required=false)]
            public int? FontSize { get; set; }

            /// <summary>
            /// <para>Specifies whether to display a text box.</para>
            /// </summary>
            [NameInMap("HasBox")]
            [Validation(Required=false)]
            public bool? HasBox { get; set; }

            /// <summary>
            /// <para>The z-axis layer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Layer")]
            [Validation(Required=false)]
            public int? Layer { get; set; }

            /// <summary>
            /// <para>The x-coordinate.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("X")]
            [Validation(Required=false)]
            public double? X { get; set; }

            /// <summary>
            /// <para>The y-coordinate.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("Y")]
            [Validation(Required=false)]
            public double? Y { get; set; }

            /// <summary>
            /// <para>The time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("Zone")]
            [Validation(Required=false)]
            public int? Zone { get; set; }

        }

        /// <summary>
        /// <para>The global image watermark.</para>
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public List<ModifyViewLayoutShrinkRequestImages> Images { get; set; }
        public class ModifyViewLayoutShrinkRequestImages : TeaModel {
            /// <summary>
            /// <para>The opacity of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.9</para>
            /// </summary>
            [NameInMap("Alpha")]
            [Validation(Required=false)]
            public double? Alpha { get; set; }

            /// <summary>
            /// <para>The height.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public double? Height { get; set; }

            /// <summary>
            /// <para>The crop mode of the image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Crops the image while maintaining the aspect ratio.</description></item>
            /// <item><description><b>2</b>: Maintains the aspect ratio and adds padding.</description></item>
            /// <item><description><b>3</b>: Stretches the image to fill the area.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ImageCropMode")]
            [Validation(Required=false)]
            public int? ImageCropMode { get; set; }

            /// <summary>
            /// <para>The z-axis layer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Layer")]
            [Validation(Required=false)]
            public int? Layer { get; set; }

            /// <summary>
            /// <para>The URL of the image.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://aliyun.com/123xxx.jpg">https://aliyun.com/123xxx.jpg</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            /// <summary>
            /// <para>The width.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public double? Width { get; set; }

            /// <summary>
            /// <para>The x-coordinate.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("X")]
            [Validation(Required=false)]
            public double? X { get; set; }

            /// <summary>
            /// <para>The y-coordinate.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("Y")]
            [Validation(Required=false)]
            public double? Y { get; set; }

        }

        /// <summary>
        /// <para>The blacklists and whitelists settings.</para>
        /// </summary>
        [NameInMap("LayoutSpecifiedUsers")]
        [Validation(Required=false)]
        public string LayoutSpecifiedUsersShrink { get; set; }

        /// <summary>
        /// <para>The pane settings. You can configure up to 16 panes.</para>
        /// </summary>
        [NameInMap("Panes")]
        [Validation(Required=false)]
        public List<ModifyViewLayoutShrinkRequestPanes> Panes { get; set; }
        public class ModifyViewLayoutShrinkRequestPanes : TeaModel {
            /// <summary>
            /// <para>The image watermarks for the pane.</para>
            /// </summary>
            [NameInMap("Images")]
            [Validation(Required=false)]
            public List<ModifyViewLayoutShrinkRequestPanesImages> Images { get; set; }
            public class ModifyViewLayoutShrinkRequestPanesImages : TeaModel {
                /// <summary>
                /// <para>The opacity of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.9</para>
                /// </summary>
                [NameInMap("Alpha")]
                [Validation(Required=false)]
                public double? Alpha { get; set; }

                /// <summary>
                /// <para>The height.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.2</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public double? Height { get; set; }

                /// <summary>
                /// <para>The z-axis layer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Layer")]
                [Validation(Required=false)]
                public int? Layer { get; set; }

                /// <summary>
                /// <para>The crop mode of the image. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Crops the image while maintaining the aspect ratio.</description></item>
                /// <item><description><b>2</b>: Maintains the aspect ratio and adds padding.</description></item>
                /// <item><description><b>3</b>: Stretches the image to fill the area.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("PaneImageCropMode")]
                [Validation(Required=false)]
                public int? PaneImageCropMode { get; set; }

                /// <summary>
                /// <para>The URL of the image.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://aliyun.com/123xxx.jpg">https://aliyun.com/123xxx.jpg</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// <para>The width.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.2</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public double? Width { get; set; }

                /// <summary>
                /// <para>The x-coordinate.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.2</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public double? X { get; set; }

                /// <summary>
                /// <para>The y-coordinate.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.3</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public double? Y { get; set; }

            }

            /// <summary>
            /// <para>The crop mode of the image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Crops the image while maintaining the aspect ratio.</description></item>
            /// <item><description><b>2</b>: Maintains the aspect ratio and adds padding.</description></item>
            /// <item><description><b>3</b>: Stretches the image to fill the area.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("PaneCropMode")]
            [Validation(Required=false)]
            public int? PaneCropMode { get; set; }

            /// <summary>
            /// <para>The ID of the pane. The ID starts from 0.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PaneId")]
            [Validation(Required=false)]
            public string PaneId { get; set; }

            /// <summary>
            /// <para>The media source of the pane. You can specify a userId. To specify a specific user type, you can use wildcard configurations. The following types are supported:</para>
            /// <list type="bullet">
            /// <item><description><b>$ActiveSpeaker</b>: The active speaker in the current channel.</description></item>
            /// <item><description><b>$ScreenShare</b>: The user who is sharing the screen. If multiple users are sharing their screens in the channel, the panes are filled in chronological order.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The media type of the pane. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>video</b>: The camera or screen sharing stream of the user. This is the default value.</description></item>
            /// <item><description><b>camera</b>: The camera stream.</description></item>
            /// <item><description><b>screen</b>: The screen sharing stream.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>video</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The text watermarks for the pane.</para>
            /// </summary>
            [NameInMap("Texts")]
            [Validation(Required=false)]
            public List<ModifyViewLayoutShrinkRequestPanesTexts> Texts { get; set; }
            public class ModifyViewLayoutShrinkRequestPanesTexts : TeaModel {
                /// <summary>
                /// <para>The opacity of the watermark.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.9</para>
                /// </summary>
                [NameInMap("Alpha")]
                [Validation(Required=false)]
                public double? Alpha { get; set; }

                /// <summary>
                /// <para>The opacity of the text box.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.6</para>
                /// </summary>
                [NameInMap("BoxAlpha")]
                [Validation(Required=false)]
                public double? BoxAlpha { get; set; }

                /// <summary>
                /// <para>The border width of the text box.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("BoxBorderw")]
                [Validation(Required=false)]
                public int? BoxBorderw { get; set; }

                /// <summary>
                /// <para>The border color of the text box.</para>
                /// </summary>
                [NameInMap("BoxColor")]
                [Validation(Required=false)]
                public ModifyViewLayoutShrinkRequestPanesTextsBoxColor BoxColor { get; set; }
                public class ModifyViewLayoutShrinkRequestPanesTextsBoxColor : TeaModel {
                    /// <summary>
                    /// <para>The blue component.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>255</para>
                    /// </summary>
                    [NameInMap("B")]
                    [Validation(Required=false)]
                    public int? B { get; set; }

                    /// <summary>
                    /// <para>The green component.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>255</para>
                    /// </summary>
                    [NameInMap("G")]
                    [Validation(Required=false)]
                    public int? G { get; set; }

                    /// <summary>
                    /// <para>The red component.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>255</para>
                    /// </summary>
                    [NameInMap("R")]
                    [Validation(Required=false)]
                    public int? R { get; set; }

                }

                /// <summary>
                /// <para>The font. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: Alibaba PuHuiTi Regular</description></item>
                /// <item><description><b>1</b>: Alibaba PuHuiTi Light</description></item>
                /// <item><description><b>2</b>: Alibaba PuHuiTi Medium</description></item>
                /// <item><description><b>3</b>: Alibaba PuHuiTi Bold</description></item>
                /// <item><description><b>4</b>: Alibaba PuHuiTi Heavy</description></item>
                /// <item><description><b>5</b>: Alimama ShuHeiTi</description></item>
                /// <item><description><b>6</b>: DingTalk JinBuTi</description></item>
                /// <item><description><b>7</b>: Alimama DaoLiTi</description></item>
                /// <item><description><b>8</b>: Alimama DongFangDaKai</description></item>
                /// <item><description><b>9</b>: Alimama FangYuanTi</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Font")]
                [Validation(Required=false)]
                public int? Font { get; set; }

                /// <summary>
                /// <para>The font color.</para>
                /// </summary>
                [NameInMap("FontColor")]
                [Validation(Required=false)]
                public ModifyViewLayoutShrinkRequestPanesTextsFontColor FontColor { get; set; }
                public class ModifyViewLayoutShrinkRequestPanesTextsFontColor : TeaModel {
                    /// <summary>
                    /// <para>The blue component.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>255</para>
                    /// </summary>
                    [NameInMap("B")]
                    [Validation(Required=false)]
                    public int? B { get; set; }

                    /// <summary>
                    /// <para>The green component.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>255</para>
                    /// </summary>
                    [NameInMap("G")]
                    [Validation(Required=false)]
                    public int? G { get; set; }

                    /// <summary>
                    /// <para>The red component.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>255</para>
                    /// </summary>
                    [NameInMap("R")]
                    [Validation(Required=false)]
                    public int? R { get; set; }

                }

                /// <summary>
                /// <para>The font size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>36</para>
                /// </summary>
                [NameInMap("FontSize")]
                [Validation(Required=false)]
                public int? FontSize { get; set; }

                /// <summary>
                /// <para>Specifies whether to display a text box.</para>
                /// </summary>
                [NameInMap("HasBox")]
                [Validation(Required=false)]
                public bool? HasBox { get; set; }

                /// <summary>
                /// <para>The z-axis layer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Layer")]
                [Validation(Required=false)]
                public int? Layer { get; set; }

                /// <summary>
                /// <para>The content of the watermark.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Text watermark</para>
                /// </summary>
                [NameInMap("Texture")]
                [Validation(Required=false)]
                public string Texture { get; set; }

                /// <summary>
                /// <para>The x-coordinate.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.2</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public double? X { get; set; }

                /// <summary>
                /// <para>The y-coordinate.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.2</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public double? Y { get; set; }

            }

        }

        /// <summary>
        /// <para>The task ID. Only a single ID is supported. The ID can contain letters, digits, underscores (_), and hyphens (-), and can be up to 55 bytes in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The template ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>567</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The global text watermark.</para>
        /// </summary>
        [NameInMap("Texts")]
        [Validation(Required=false)]
        public List<ModifyViewLayoutShrinkRequestTexts> Texts { get; set; }
        public class ModifyViewLayoutShrinkRequestTexts : TeaModel {
            /// <summary>
            /// <para>The opacity of the watermark.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.1</para>
            /// </summary>
            [NameInMap("Alpha")]
            [Validation(Required=false)]
            public double? Alpha { get; set; }

            /// <summary>
            /// <para>The opacity of the text box.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.6</para>
            /// </summary>
            [NameInMap("BoxAlpha")]
            [Validation(Required=false)]
            public double? BoxAlpha { get; set; }

            /// <summary>
            /// <para>The border width of the text box.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("BoxBorderw")]
            [Validation(Required=false)]
            public int? BoxBorderw { get; set; }

            /// <summary>
            /// <para>The border color of the text box.</para>
            /// </summary>
            [NameInMap("BoxColor")]
            [Validation(Required=false)]
            public ModifyViewLayoutShrinkRequestTextsBoxColor BoxColor { get; set; }
            public class ModifyViewLayoutShrinkRequestTextsBoxColor : TeaModel {
                /// <summary>
                /// <para>The blue component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("B")]
                [Validation(Required=false)]
                public int? B { get; set; }

                /// <summary>
                /// <para>The green component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("G")]
                [Validation(Required=false)]
                public int? G { get; set; }

                /// <summary>
                /// <para>The red component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("R")]
                [Validation(Required=false)]
                public int? R { get; set; }

            }

            /// <summary>
            /// <para>The font. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Alibaba PuHuiTi Regular</description></item>
            /// <item><description><b>1</b>: Alibaba PuHuiTi Light</description></item>
            /// <item><description><b>2</b>: Alibaba PuHuiTi Medium</description></item>
            /// <item><description><b>3</b>: Alibaba PuHuiTi Bold</description></item>
            /// <item><description><b>4</b>: Alibaba PuHuiTi Heavy</description></item>
            /// <item><description><b>5</b>: Alimama ShuHeiTi</description></item>
            /// <item><description><b>6</b>: DingTalk JinBuTi</description></item>
            /// <item><description><b>7</b>: Alimama DaoLiTi</description></item>
            /// <item><description><b>8</b>: Alimama DongFangDaKai</description></item>
            /// <item><description><b>9</b>: Alimama FangYuanTi</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Font")]
            [Validation(Required=false)]
            public int? Font { get; set; }

            /// <summary>
            /// <para>The font color.</para>
            /// </summary>
            [NameInMap("FontColor")]
            [Validation(Required=false)]
            public ModifyViewLayoutShrinkRequestTextsFontColor FontColor { get; set; }
            public class ModifyViewLayoutShrinkRequestTextsFontColor : TeaModel {
                /// <summary>
                /// <para>The blue component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("B")]
                [Validation(Required=false)]
                public int? B { get; set; }

                /// <summary>
                /// <para>The green component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("G")]
                [Validation(Required=false)]
                public int? G { get; set; }

                /// <summary>
                /// <para>The red component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("R")]
                [Validation(Required=false)]
                public int? R { get; set; }

            }

            /// <summary>
            /// <para>The font size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>36</para>
            /// </summary>
            [NameInMap("FontSize")]
            [Validation(Required=false)]
            public int? FontSize { get; set; }

            /// <summary>
            /// <para>Specifies whether to display a text box.</para>
            /// </summary>
            [NameInMap("HasBox")]
            [Validation(Required=false)]
            public bool? HasBox { get; set; }

            /// <summary>
            /// <para>The z-axis layer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Layer")]
            [Validation(Required=false)]
            public int? Layer { get; set; }

            /// <summary>
            /// <para>The content of the watermark.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Text watermark</para>
            /// </summary>
            [NameInMap("Texture")]
            [Validation(Required=false)]
            public string Texture { get; set; }

            /// <summary>
            /// <para>The x-coordinate.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("X")]
            [Validation(Required=false)]
            public double? X { get; set; }

            /// <summary>
            /// <para>The y-coordinate.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("Y")]
            [Validation(Required=false)]
            public double? Y { get; set; }

        }

    }

}
