// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class StartStreamingOutRequest : TeaModel {
        /// <summary>
        /// <para>The annotation switch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>disable</para>
        /// </summary>
        [NameInMap("Annotation")]
        [Validation(Required=false)]
        public string Annotation { get; set; }

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
        public List<StartStreamingOutRequestBackgrounds> Backgrounds { get; set; }
        public class StartStreamingOutRequestBackgrounds : TeaModel {
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
            /// <item><description><b>1</b>: Crop while maintaining the aspect ratio.</description></item>
            /// <item><description><b>2</b>: Maintain the aspect ratio and add borders.</description></item>
            /// <item><description><b>3</b>: Stretch to fill.</description></item>
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
        /// <para>The global background color.</para>
        /// </summary>
        [NameInMap("BgColor")]
        [Validation(Required=false)]
        public StartStreamingOutRequestBgColor BgColor { get; set; }
        public class StartStreamingOutRequestBgColor : TeaModel {
            /// <summary>
            /// <para>The B value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>255</para>
            /// </summary>
            [NameInMap("B")]
            [Validation(Required=false)]
            public int? B { get; set; }

            /// <summary>
            /// <para>The G value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>255</para>
            /// </summary>
            [NameInMap("G")]
            [Validation(Required=false)]
            public int? G { get; set; }

            /// <summary>
            /// <para>The R value.</para>
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
        public List<StartStreamingOutRequestClockWidgets> ClockWidgets { get; set; }
        public class StartStreamingOutRequestClockWidgets : TeaModel {
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
            /// <para>The transparency of the rectangle box.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.6</para>
            /// </summary>
            [NameInMap("BoxAlpha")]
            [Validation(Required=false)]
            public double? BoxAlpha { get; set; }

            /// <summary>
            /// <para>The border width of the rectangle box.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("BoxBorderw")]
            [Validation(Required=false)]
            public int? BoxBorderw { get; set; }

            /// <summary>
            /// <para>The color of the rectangle box.</para>
            /// </summary>
            [NameInMap("BoxColor")]
            [Validation(Required=false)]
            public StartStreamingOutRequestClockWidgetsBoxColor BoxColor { get; set; }
            public class StartStreamingOutRequestClockWidgetsBoxColor : TeaModel {
                /// <summary>
                /// <para>The B value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("B")]
                [Validation(Required=false)]
                public int? B { get; set; }

                /// <summary>
                /// <para>The G value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("G")]
                [Validation(Required=false)]
                public int? G { get; set; }

                /// <summary>
                /// <para>The R value.</para>
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
            public StartStreamingOutRequestClockWidgetsFontColor FontColor { get; set; }
            public class StartStreamingOutRequestClockWidgetsFontColor : TeaModel {
                /// <summary>
                /// <para>The B value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("B")]
                [Validation(Required=false)]
                public int? B { get; set; }

                /// <summary>
                /// <para>The G value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("G")]
                [Validation(Required=false)]
                public int? G { get; set; }

                /// <summary>
                /// <para>The R value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("R")]
                [Validation(Required=false)]
                public int? R { get; set; }

            }

            /// <summary>
            /// <para>The font size of the clock.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("FontSize")]
            [Validation(Required=false)]
            public int? FontSize { get; set; }

            /// <summary>
            /// <para>Specifies whether a rectangle box is required.</para>
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
        /// <para>The crop mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Crop the image while maintaining the aspect ratio.</description></item>
        /// <item><description><b>2</b>: Maintain the aspect ratio and add borders (default).</description></item>
        /// <item><description><b>3</b>: Stretch the image to fill the pane.</description></item>
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
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public List<StartStreamingOutRequestImages> Images { get; set; }
        public class StartStreamingOutRequestImages : TeaModel {
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
            /// <item><description><b>1</b>: Crop while maintaining the aspect ratio.</description></item>
            /// <item><description><b>2</b>: Maintain the aspect ratio and add borders.</description></item>
            /// <item><description><b>3</b>: Stretch to fill.</description></item>
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
            /// <para>The image URL. The image content cannot be updated during stream ingest.</para>
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
        /// <para>The specified user list for layout generation, including Blacklist/Whitelist.</para>
        /// <para>Whitelist: specifies the users whose video streams are subscribed to in the channel.</para>
        /// <list type="bullet">
        /// <item><description>After the settings are applied, automatic padding is performed in sequence based on this list.</description></item>
        /// <item><description>When switching between multiple layouts in a template, only users in the whitelist are considered.</description></item>
        /// </list>
        /// <para>Blacklist: specifies the users whose video streams are not subscribed to in the channel.</para>
        /// <list type="bullet">
        /// <item><description>When switching between multiple layouts in a template, only users not in the blacklist are considered.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("LayoutSpecifiedUsers")]
        [Validation(Required=false)]
        public StartStreamingOutRequestLayoutSpecifiedUsers LayoutSpecifiedUsers { get; set; }
        public class StartStreamingOutRequestLayoutSpecifiedUsers : TeaModel {
            /// <summary>
            /// <para>The list of specified user IDs.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Ids")]
            [Validation(Required=false)]
            public List<string> Ids { get; set; }

            /// <summary>
            /// <para>The type of the user list. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>black: Blacklist.</description></item>
            /// <item><description>white: Whitelist.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>white</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The pane settings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eo85****</para>
        /// </summary>
        [NameInMap("Panes")]
        [Validation(Required=false)]
        public List<StartStreamingOutRequestPanes> Panes { get; set; }
        public class StartStreamingOutRequestPanes : TeaModel {
            /// <summary>
            /// <para>The local background images.</para>
            /// </summary>
            [NameInMap("Backgrounds")]
            [Validation(Required=false)]
            public List<StartStreamingOutRequestPanesBackgrounds> Backgrounds { get; set; }
            public class StartStreamingOutRequestPanesBackgrounds : TeaModel {
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
                /// <para>The display condition. Valid values:</para>
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
                /// <para>The z-axis layer.</para>
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
                /// <item><description><b>1</b>: Crop while maintaining the aspect ratio.</description></item>
                /// <item><description><b>2</b>: Maintain the aspect ratio and add borders.</description></item>
                /// <item><description><b>3</b>: Stretch to fill.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
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
            /// <para>The local image watermarks for the pane.</para>
            /// </summary>
            [NameInMap("Images")]
            [Validation(Required=false)]
            public List<StartStreamingOutRequestPanesImages> Images { get; set; }
            public class StartStreamingOutRequestPanesImages : TeaModel {
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
                /// <para>The z-axis layer.</para>
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
                /// <item><description><b>1</b>: Crop while maintaining the aspect ratio.</description></item>
                /// <item><description><b>2</b>: Maintain the aspect ratio and add borders.</description></item>
                /// <item><description><b>3</b>: Stretch to fill.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("PaneImageCropMode")]
                [Validation(Required=false)]
                public int? PaneImageCropMode { get; set; }

                /// <summary>
                /// <para>The corresponding image content cannot be updated while streaming.</para>
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
            /// <para>The crop mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Crop while maintaining the aspect ratio.</description></item>
            /// <item><description><b>2</b>: Maintain the aspect ratio and add borders.</description></item>
            /// <item><description><b>3</b>: Stretch to fill.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("PaneCropMode")]
            [Validation(Required=false)]
            public int? PaneCropMode { get; set; }

            /// <summary>
            /// <para>The pane ID. The value starts from 0.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PaneId")]
            [Validation(Required=false)]
            public string PaneId { get; set; }

            /// <summary>
            /// <para>Specifies whether to reserve the pane for users who have not joined the meeting.
            /// Default value: true. This value indicates that when the specific user or wildcard user specified for the grid is offline, the pane is forcibly reserved.
            /// A value of false indicates that when the specific user or wildcard user specified for the grid is offline, video streams are displayed based on the automatic fill order.</para>
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
            public List<StartStreamingOutRequestPanesTexts> Texts { get; set; }
            public class StartStreamingOutRequestPanesTexts : TeaModel {
                /// <summary>
                /// <para>The watermark transparency.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.9</para>
                /// </summary>
                [NameInMap("Alpha")]
                [Validation(Required=false)]
                public double? Alpha { get; set; }

                /// <summary>
                /// <para>The transparency of the rectangle box.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.6</para>
                /// </summary>
                [NameInMap("BoxAlpha")]
                [Validation(Required=false)]
                public double? BoxAlpha { get; set; }

                /// <summary>
                /// <para>The border width of the rectangle box.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("BoxBorderw")]
                [Validation(Required=false)]
                public int? BoxBorderw { get; set; }

                /// <summary>
                /// <para>The color of the rectangle box.</para>
                /// </summary>
                [NameInMap("BoxColor")]
                [Validation(Required=false)]
                public StartStreamingOutRequestPanesTextsBoxColor BoxColor { get; set; }
                public class StartStreamingOutRequestPanesTextsBoxColor : TeaModel {
                    /// <summary>
                    /// <para>The B value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>255</para>
                    /// </summary>
                    [NameInMap("B")]
                    [Validation(Required=false)]
                    public int? B { get; set; }

                    /// <summary>
                    /// <para>The G value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>255</para>
                    /// </summary>
                    [NameInMap("G")]
                    [Validation(Required=false)]
                    public int? G { get; set; }

                    /// <summary>
                    /// <para>The R value.</para>
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
                /// <para>backup</para>
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
                public StartStreamingOutRequestPanesTextsFontColor FontColor { get; set; }
                public class StartStreamingOutRequestPanesTextsFontColor : TeaModel {
                    /// <summary>
                    /// <para>The B value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>255</para>
                    /// </summary>
                    [NameInMap("B")]
                    [Validation(Required=false)]
                    public int? B { get; set; }

                    /// <summary>
                    /// <para>The G value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>255</para>
                    /// </summary>
                    [NameInMap("G")]
                    [Validation(Required=false)]
                    public int? G { get; set; }

                    /// <summary>
                    /// <para>The R value.</para>
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
                /// <para>Specifies whether a rectangle box is required.</para>
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
            public StartStreamingOutRequestPanesWhiteboard Whiteboard { get; set; }
            public class StartStreamingOutRequestPanesWhiteboard : TeaModel {
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
        /// <para>The global pane background color.</para>
        /// </summary>
        [NameInMap("RegionColor")]
        [Validation(Required=false)]
        public StartStreamingOutRequestRegionColor RegionColor { get; set; }
        public class StartStreamingOutRequestRegionColor : TeaModel {
            /// <summary>
            /// <para>The B value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>255</para>
            /// </summary>
            [NameInMap("B")]
            [Validation(Required=false)]
            public int? B { get; set; }

            /// <summary>
            /// <para>The G value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>255</para>
            /// </summary>
            [NameInMap("G")]
            [Validation(Required=false)]
            public int? G { get; set; }

            /// <summary>
            /// <para>The R value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>255</para>
            /// </summary>
            [NameInMap("R")]
            [Validation(Required=false)]
            public int? R { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to reserve a pane placeholder for users who do not push camera streams. Default value: true. A value of true indicates that a pane is reserved when a user does not push a camera stream. A value of false indicates that no pane is reserved.</para>
        /// </summary>
        [NameInMap("ReservePaneForNoCameraUser")]
        [Validation(Required=false)]
        public bool? ReservePaneForNoCameraUser { get; set; }

        /// <summary>
        /// <para>Specifies whether to display the default background image of a pane when the user is muted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Displays the default background image (default).</description></item>
        /// <item><description>false: Does not display the default background image, but the configured local pane background image is still displayed.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ShowDefaultBackgroundOnMute")]
        [Validation(Required=false)]
        public bool? ShowDefaultBackgroundOnMute { get; set; }

        /// <summary>
        /// <para>The list of specified users for audio mixing.</para>
        /// </summary>
        [NameInMap("SpecMixedUserList")]
        [Validation(Required=false)]
        public List<string> SpecMixedUserList { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow starting the task when the channel does not exist. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Yes.</description></item>
        /// <item><description>false: No (default).</description></item>
        /// </list>
        /// </summary>
        [NameInMap("StartWithoutChannel")]
        [Validation(Required=false)]
        public bool? StartWithoutChannel { get; set; }

        /// <summary>
        /// <para>The wait time for the task when the channel is not started, in seconds. This parameter is valid only when the StartWithoutChannel parameter is set to true. Valid values: 30 to 120.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("StartWithoutChannelWaitTime")]
        [Validation(Required=false)]
        public int? StartWithoutChannelWaitTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to subscribe to high resolution streams. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false: Subscribes to streams of different resolutions based on the pane area (default).</description></item>
        /// <item><description>true: Uses the highest resolution stream pushed by the client for padding by default.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("SubHighResolutionStream")]
        [Validation(Required=false)]
        public bool? SubHighResolutionStream { get; set; }

        /// <summary>
        /// <para>The task ID of the bypass streaming task. Only a single ID is supported. The ID can contain uppercase and lowercase letters, digits, underscores (_), and hyphens (-), and can be up to 55 bytes in length. If you do not specify this parameter, the system automatically generates a task ID.</para>
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
        public List<StartStreamingOutRequestTexts> Texts { get; set; }
        public class StartStreamingOutRequestTexts : TeaModel {
            /// <summary>
            /// <para>The watermark transparency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.1</para>
            /// </summary>
            [NameInMap("Alpha")]
            [Validation(Required=false)]
            public double? Alpha { get; set; }

            /// <summary>
            /// <para>The transparency of the rectangle box.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.6</para>
            /// </summary>
            [NameInMap("BoxAlpha")]
            [Validation(Required=false)]
            public double? BoxAlpha { get; set; }

            /// <summary>
            /// <para>The border width of the rectangle box.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("BoxBorderw")]
            [Validation(Required=false)]
            public int? BoxBorderw { get; set; }

            /// <summary>
            /// <para>The color of the rectangle box.</para>
            /// </summary>
            [NameInMap("BoxColor")]
            [Validation(Required=false)]
            public StartStreamingOutRequestTextsBoxColor BoxColor { get; set; }
            public class StartStreamingOutRequestTextsBoxColor : TeaModel {
                /// <summary>
                /// <para>The B value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("B")]
                [Validation(Required=false)]
                public int? B { get; set; }

                /// <summary>
                /// <para>The G value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("G")]
                [Validation(Required=false)]
                public int? G { get; set; }

                /// <summary>
                /// <para>The R value.</para>
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
            public StartStreamingOutRequestTextsFontColor FontColor { get; set; }
            public class StartStreamingOutRequestTextsFontColor : TeaModel {
                /// <summary>
                /// <para>The B value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("B")]
                [Validation(Required=false)]
                public int? B { get; set; }

                /// <summary>
                /// <para>The G value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("G")]
                [Validation(Required=false)]
                public int? G { get; set; }

                /// <summary>
                /// <para>The R value.</para>
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
            /// <para>Specifies whether a rectangle box is required.</para>
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
        /// <para>The live stream ingest URL. Only a single URL is supported. This URL cannot be used by multiple tasks at the same time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rtmp://example.com/live/stream</para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
