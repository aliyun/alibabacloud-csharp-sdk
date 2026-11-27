// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class UpdateStreamingOutShrinkRequest : TeaModel {
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
        /// <para>The background image.</para>
        /// </summary>
        [NameInMap("Backgrounds")]
        [Validation(Required=false)]
        public List<UpdateStreamingOutShrinkRequestBackgrounds> Backgrounds { get; set; }
        public class UpdateStreamingOutShrinkRequestBackgrounds : TeaModel {
            /// <summary>
            /// <para>The transparency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.9</para>
            /// </summary>
            [NameInMap("Alpha")]
            [Validation(Required=false)]
            public double? Alpha { get; set; }

            /// <summary>
            /// <para>The crop mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Crops the image while maintaining the aspect ratio.</description></item>
            /// <item><description><b>2</b>: Adds padding to the image while maintaining the aspect ratio.</description></item>
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
            /// <para>The Z-axis layer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Layer")]
            [Validation(Required=false)]
            public int? Layer { get; set; }

            /// <summary>
            /// <para>The image URL.</para>
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
            /// <para>The X-coordinate.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("X")]
            [Validation(Required=false)]
            public double? X { get; set; }

            /// <summary>
            /// <para>The Y-coordinate.</para>
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
        /// <para>The global background color.</para>
        /// </summary>
        [NameInMap("BgColor")]
        [Validation(Required=false)]
        public UpdateStreamingOutShrinkRequestBgColor BgColor { get; set; }
        public class UpdateStreamingOutShrinkRequestBgColor : TeaModel {
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
        public List<UpdateStreamingOutShrinkRequestClockWidgets> ClockWidgets { get; set; }
        public class UpdateStreamingOutShrinkRequestClockWidgets : TeaModel {
            /// <summary>
            /// <para>The transparency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.9</para>
            /// </summary>
            [NameInMap("Alpha")]
            [Validation(Required=false)]
            public double? Alpha { get; set; }

            /// <summary>
            /// <para>The transparency of the rectangle.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.6</para>
            /// </summary>
            [NameInMap("BoxAlpha")]
            [Validation(Required=false)]
            public double? BoxAlpha { get; set; }

            /// <summary>
            /// <para>The border width of the rectangle.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("BoxBorderw")]
            [Validation(Required=false)]
            public int? BoxBorderw { get; set; }

            /// <summary>
            /// <para>The color of the rectangle.</para>
            /// </summary>
            [NameInMap("BoxColor")]
            [Validation(Required=false)]
            public UpdateStreamingOutShrinkRequestClockWidgetsBoxColor BoxColor { get; set; }
            public class UpdateStreamingOutShrinkRequestClockWidgetsBoxColor : TeaModel {
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
            public UpdateStreamingOutShrinkRequestClockWidgetsFontColor FontColor { get; set; }
            public class UpdateStreamingOutShrinkRequestClockWidgetsFontColor : TeaModel {
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
            /// <para>Specifies whether to display the rectangle.</para>
            /// </summary>
            [NameInMap("HasBox")]
            [Validation(Required=false)]
            public bool? HasBox { get; set; }

            /// <summary>
            /// <para>The Z-axis layer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Layer")]
            [Validation(Required=false)]
            public int? Layer { get; set; }

            /// <summary>
            /// <para>The X-coordinate.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("X")]
            [Validation(Required=false)]
            public double? X { get; set; }

            /// <summary>
            /// <para>The Y-coordinate.</para>
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
        /// <para>The crop mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Crops the image while maintaining the aspect ratio.</description></item>
        /// <item><description><b>2</b>: Adds padding to the image while maintaining the aspect ratio.</description></item>
        /// <item><description><b>3</b>: Stretches the image to fill the area.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CropMode")]
        [Validation(Required=false)]
        public int? CropMode { get; set; }

        /// <summary>
        /// <para>The global image watermark.</para>
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public List<UpdateStreamingOutShrinkRequestImages> Images { get; set; }
        public class UpdateStreamingOutShrinkRequestImages : TeaModel {
            /// <summary>
            /// <para>The transparency.</para>
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
            /// <para>The crop mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Crops the image while maintaining the aspect ratio.</description></item>
            /// <item><description><b>2</b>: Adds padding to the image while maintaining the aspect ratio.</description></item>
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
            /// <para>The Z-axis layer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Layer")]
            [Validation(Required=false)]
            public int? Layer { get; set; }

            /// <summary>
            /// <para>The image URL. The image content cannot be updated during stream ingest.</para>
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
            /// <para>The X-coordinate.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("X")]
            [Validation(Required=false)]
            public double? X { get; set; }

            /// <summary>
            /// <para>The Y-coordinate.</para>
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
        /// <para>The specified user list for layout generation, which includes two types: blacklist and whitelist.</para>
        /// <para>Whitelist: specifies the users in the room whose video streams are subscribed to.</para>
        /// <list type="bullet">
        /// <item><description>After the setting is applied, automatic padding is performed in sequence based on this list.</description></item>
        /// <item><description>When switching between multiple layouts in a template, only users in the whitelist are considered.</description></item>
        /// </list>
        /// <para>Blacklist: specifies the users in the room whose video streams are not subscribed to.</para>
        /// <list type="bullet">
        /// <item><description>When switching between multiple layouts in a template, only users not in the blacklist are considered.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("LayoutSpecifiedUsers")]
        [Validation(Required=false)]
        public string LayoutSpecifiedUsersShrink { get; set; }

        /// <summary>
        /// <para>The pane settings. You can configure up to 16 panes.</para>
        /// </summary>
        [NameInMap("Panes")]
        [Validation(Required=false)]
        public List<UpdateStreamingOutShrinkRequestPanes> Panes { get; set; }
        public class UpdateStreamingOutShrinkRequestPanes : TeaModel {
            /// <summary>
            /// <para>The background image of the pane.</para>
            /// </summary>
            [NameInMap("Backgrounds")]
            [Validation(Required=false)]
            public List<UpdateStreamingOutShrinkRequestPanesBackgrounds> Backgrounds { get; set; }
            public class UpdateStreamingOutShrinkRequestPanesBackgrounds : TeaModel {
                /// <summary>
                /// <para>The transparency.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.9</para>
                /// </summary>
                [NameInMap("Alpha")]
                [Validation(Required=false)]
                public double? Alpha { get; set; }

                /// <summary>
                /// <para>The condition for displaying the watermark. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>streamOnly: Displayed when the current user has a video stream. This is the default value.</description></item>
                /// <item><description>backup: Displayed when the current user does not have a video stream.</description></item>
                /// <item><description>always: Always displayed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>backup</para>
                /// </summary>
                [NameInMap("Display")]
                [Validation(Required=false)]
                public string Display { get; set; }

                /// <summary>
                /// <para>The height.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.79</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public double? Height { get; set; }

                /// <summary>
                /// <para>The Z-axis layer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Layer")]
                [Validation(Required=false)]
                public int? Layer { get; set; }

                /// <summary>
                /// <para>The crop mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Crops the image while maintaining the aspect ratio.</description></item>
                /// <item><description><b>2</b>: Adds padding to the image while maintaining the aspect ratio.</description></item>
                /// <item><description><b>3</b>: Stretches the image to fill the area.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PaneBackgroundCropMode")]
                [Validation(Required=false)]
                public int? PaneBackgroundCropMode { get; set; }

                /// <summary>
                /// <para>The image URL.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://aliyun.com/123xx.jpg">https://aliyun.com/123xx.jpg</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// <para>The width.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.3</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public double? Width { get; set; }

                /// <summary>
                /// <para>The X-coordinate.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.2</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public double? X { get; set; }

                /// <summary>
                /// <para>The Y-coordinate.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.95</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public double? Y { get; set; }

            }

            /// <summary>
            /// <para>The local image watermarks for the pane.</para>
            /// </summary>
            [NameInMap("Images")]
            [Validation(Required=false)]
            public List<UpdateStreamingOutShrinkRequestPanesImages> Images { get; set; }
            public class UpdateStreamingOutShrinkRequestPanesImages : TeaModel {
                /// <summary>
                /// <para>The transparency.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.9</para>
                /// </summary>
                [NameInMap("Alpha")]
                [Validation(Required=false)]
                public double? Alpha { get; set; }

                /// <summary>
                /// <para>The condition for displaying the watermark. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>streamOnly: Displayed when the current user has a video stream. This is the default value.</description></item>
                /// <item><description>backup: Displayed when the current user does not have a video stream.</description></item>
                /// <item><description>always: Always displayed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>backup</para>
                /// </summary>
                [NameInMap("Display")]
                [Validation(Required=false)]
                public string Display { get; set; }

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
                /// <para>The Z-axis layer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Layer")]
                [Validation(Required=false)]
                public int? Layer { get; set; }

                /// <summary>
                /// <para>The crop mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Crops the image while maintaining the aspect ratio.</description></item>
                /// <item><description><b>2</b>: Adds padding to the image while maintaining the aspect ratio.</description></item>
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
                /// <para>The image URL. The image content cannot be updated during stream ingest.</para>
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
                /// <para>The X-coordinate.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.2</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public double? X { get; set; }

                /// <summary>
                /// <para>The Y-coordinate.</para>
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
            /// <para>The crop mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Crops the image while maintaining the aspect ratio.</description></item>
            /// <item><description><b>2</b>: Adds padding to the image while maintaining the aspect ratio.</description></item>
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
            /// <para>The pane ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PaneId")]
            [Validation(Required=false)]
            public int? PaneId { get; set; }

            /// <summary>
            /// <para>Specifies whether to reserve the pane as a placeholder for offline users. Default value: true. A value of true indicates that the pane is forcibly reserved as a placeholder when the specific user or wildcard user specified for the grid is offline. A value of false indicates that video streams are displayed in the automatic fill order when the specific user or wildcard user specified for the grid is offline.</para>
            /// </summary>
            [NameInMap("ReservePaneForOfflineUser")]
            [Validation(Required=false)]
            public bool? ReservePaneForOfflineUser { get; set; }

            /// <summary>
            /// <para>The media source of the pane. You can specify a userId. To specify a specific user type, you can use wildcard configurations. The following types are supported:</para>
            /// <list type="bullet">
            /// <item><description><b>$ActiveSpeaker</b>: The current speaker in the channel.</description></item>
            /// <item><description><b>$ScreenShare</b>: The user who is sharing their screen. If multiple users are sharing their screens in the channel, the panes are filled in chronological order.</description></item>
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
            /// <item><description><b>video</b>: The user camera or screen sharing stream. This is the default value.</description></item>
            /// <item><description><b>camera</b>: The camera stream.</description></item>
            /// <item><description><b>screen</b>: The screen sharing stream.</description></item>
            /// <item><description><b>whiteboard</b>: The whiteboard.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>video</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The local text watermarks for the pane.</para>
            /// </summary>
            [NameInMap("Texts")]
            [Validation(Required=false)]
            public List<UpdateStreamingOutShrinkRequestPanesTexts> Texts { get; set; }
            public class UpdateStreamingOutShrinkRequestPanesTexts : TeaModel {
                /// <summary>
                /// <para>The transparency of the watermark.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.9</para>
                /// </summary>
                [NameInMap("Alpha")]
                [Validation(Required=false)]
                public double? Alpha { get; set; }

                /// <summary>
                /// <para>The transparency of the rectangle.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.6</para>
                /// </summary>
                [NameInMap("BoxAlpha")]
                [Validation(Required=false)]
                public double? BoxAlpha { get; set; }

                /// <summary>
                /// <para>The border width of the rectangle.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("BoxBorderw")]
                [Validation(Required=false)]
                public int? BoxBorderw { get; set; }

                /// <summary>
                /// <para>The color of the rectangle.</para>
                /// </summary>
                [NameInMap("BoxColor")]
                [Validation(Required=false)]
                public UpdateStreamingOutShrinkRequestPanesTextsBoxColor BoxColor { get; set; }
                public class UpdateStreamingOutShrinkRequestPanesTextsBoxColor : TeaModel {
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
                /// <para>The condition for displaying the watermark. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>streamOnly: Displayed when the current user has a video stream. This is the default value.</description></item>
                /// <item><description>backup: Displayed when the current user does not have a video stream.</description></item>
                /// <item><description>always: Always displayed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>always</para>
                /// </summary>
                [NameInMap("Display")]
                [Validation(Required=false)]
                public string Display { get; set; }

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
                public UpdateStreamingOutShrinkRequestPanesTextsFontColor FontColor { get; set; }
                public class UpdateStreamingOutShrinkRequestPanesTextsFontColor : TeaModel {
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
                /// <para>Specifies whether to display the rectangle.</para>
                /// </summary>
                [NameInMap("HasBox")]
                [Validation(Required=false)]
                public bool? HasBox { get; set; }

                /// <summary>
                /// <para>The Z-axis layer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Layer")]
                [Validation(Required=false)]
                public int? Layer { get; set; }

                /// <summary>
                /// <para>The watermark content.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Text watermark</para>
                /// </summary>
                [NameInMap("Texture")]
                [Validation(Required=false)]
                public string Texture { get; set; }

                /// <summary>
                /// <para>The X-coordinate.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.2</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public double? X { get; set; }

                /// <summary>
                /// <para>The Y-coordinate.</para>
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
            /// <para>The fill order when SourceType is set to video. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>screenFirst: Screen sharing takes precedence. This is the default value.</description></item>
            /// <item><description>cameraFirst: The camera takes precedence.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cameraFirst</para>
            /// </summary>
            [NameInMap("VideoOrder")]
            [Validation(Required=false)]
            public string VideoOrder { get; set; }

            /// <summary>
            /// <para>The whiteboard configurations.</para>
            /// </summary>
            [NameInMap("Whiteboard")]
            [Validation(Required=false)]
            public UpdateStreamingOutShrinkRequestPanesWhiteboard Whiteboard { get; set; }
            public class UpdateStreamingOutShrinkRequestPanesWhiteboard : TeaModel {
                /// <summary>
                /// <para>The whiteboard ID. Default value: default.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("WhiteboardId")]
                [Validation(Required=false)]
                public string WhiteboardId { get; set; }

            }

        }

        /// <summary>
        /// <para>The global region background color.</para>
        /// </summary>
        [NameInMap("RegionColor")]
        [Validation(Required=false)]
        public UpdateStreamingOutShrinkRequestRegionColor RegionColor { get; set; }
        public class UpdateStreamingOutShrinkRequestRegionColor : TeaModel {
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
        /// <para>The list of specified users for audio mixing.</para>
        /// </summary>
        [NameInMap("SpecMixedUserList")]
        [Validation(Required=false)]
        public List<string> SpecMixedUserList { get; set; }

        /// <summary>
        /// <para>The ID of the bypass live streaming task. Only a single ID is supported. The ID can contain uppercase and lowercase letters, digits, underscores (_), and hyphens (-), and can be up to 55 bytes in length.</para>
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
        /// <remarks>
        /// <para>Notice: When you update the template ID, you can only update the layout. The resolution cannot be updated.</para>
        /// </remarks>
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
        public List<UpdateStreamingOutShrinkRequestTexts> Texts { get; set; }
        public class UpdateStreamingOutShrinkRequestTexts : TeaModel {
            /// <summary>
            /// <para>The transparency of the watermark.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.1</para>
            /// </summary>
            [NameInMap("Alpha")]
            [Validation(Required=false)]
            public double? Alpha { get; set; }

            /// <summary>
            /// <para>The transparency of the rectangle.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.6</para>
            /// </summary>
            [NameInMap("BoxAlpha")]
            [Validation(Required=false)]
            public double? BoxAlpha { get; set; }

            /// <summary>
            /// <para>The border width of the rectangle.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("BoxBorderw")]
            [Validation(Required=false)]
            public int? BoxBorderw { get; set; }

            /// <summary>
            /// <para>The color of the rectangle.</para>
            /// </summary>
            [NameInMap("BoxColor")]
            [Validation(Required=false)]
            public UpdateStreamingOutShrinkRequestTextsBoxColor BoxColor { get; set; }
            public class UpdateStreamingOutShrinkRequestTextsBoxColor : TeaModel {
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
            public UpdateStreamingOutShrinkRequestTextsFontColor FontColor { get; set; }
            public class UpdateStreamingOutShrinkRequestTextsFontColor : TeaModel {
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
            /// <para>Specifies whether to display the rectangle.</para>
            /// </summary>
            [NameInMap("HasBox")]
            [Validation(Required=false)]
            public bool? HasBox { get; set; }

            /// <summary>
            /// <para>The Z-axis layer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Layer")]
            [Validation(Required=false)]
            public int? Layer { get; set; }

            /// <summary>
            /// <para>The watermark content.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Text watermark</para>
            /// </summary>
            [NameInMap("Texture")]
            [Validation(Required=false)]
            public string Texture { get; set; }

            /// <summary>
            /// <para>The X-coordinate.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("X")]
            [Validation(Required=false)]
            public double? X { get; set; }

            /// <summary>
            /// <para>The Y-coordinate.</para>
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
