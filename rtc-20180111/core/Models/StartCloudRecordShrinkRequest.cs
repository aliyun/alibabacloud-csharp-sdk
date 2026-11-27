// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class StartCloudRecordShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the annotation feature.</para>
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
        /// <para>The local background images for the pane.</para>
        /// </summary>
        [NameInMap("Backgrounds")]
        [Validation(Required=false)]
        public List<StartCloudRecordShrinkRequestBackgrounds> Backgrounds { get; set; }
        public class StartCloudRecordShrinkRequestBackgrounds : TeaModel {
            /// <summary>
            /// <para>The transparency of the image.</para>
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
            /// <item><description><b>2</b>: Maintains the aspect ratio and adds borders.</description></item>
            /// <item><description><b>3</b>: Stretches the image to fill the pane.</description></item>
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
        /// <para>The global background color.</para>
        /// </summary>
        [NameInMap("BgColor")]
        [Validation(Required=false)]
        public StartCloudRecordShrinkRequestBgColor BgColor { get; set; }
        public class StartCloudRecordShrinkRequestBgColor : TeaModel {
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
        public List<StartCloudRecordShrinkRequestClockWidgets> ClockWidgets { get; set; }
        public class StartCloudRecordShrinkRequestClockWidgets : TeaModel {
            /// <summary>
            /// <para>The transparency of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.9</para>
            /// </summary>
            [NameInMap("Alpha")]
            [Validation(Required=false)]
            public double? Alpha { get; set; }

            /// <summary>
            /// <para>The transparency of the text box.</para>
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
            /// <para>The color of the text box.</para>
            /// </summary>
            [NameInMap("BoxColor")]
            [Validation(Required=false)]
            public StartCloudRecordShrinkRequestClockWidgetsBoxColor BoxColor { get; set; }
            public class StartCloudRecordShrinkRequestClockWidgetsBoxColor : TeaModel {
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
            public StartCloudRecordShrinkRequestClockWidgetsFontColor FontColor { get; set; }
            public class StartCloudRecordShrinkRequestClockWidgetsFontColor : TeaModel {
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
            /// <para>The font size of the clock.</para>
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
        /// <para>The crop mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Crops the video while keeping the aspect ratio.</description></item>
        /// <item><description><b>2</b>: Keeps the aspect ratio and adds padding (default).</description></item>
        /// <item><description><b>3</b>: Stretches the video to fill the pane.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CropMode")]
        [Validation(Required=false)]
        public int? CropMode { get; set; }

        /// <summary>
        /// <para>The global image watermarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>disable</para>
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public List<StartCloudRecordShrinkRequestImages> Images { get; set; }
        public class StartCloudRecordShrinkRequestImages : TeaModel {
            /// <summary>
            /// <para>The transparency of the image.</para>
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
            /// <item><description><b>2</b>: Maintains the aspect ratio and adds borders.</description></item>
            /// <item><description><b>3</b>: Stretches the image to fill the pane.</description></item>
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
            /// <para>0.3</para>
            /// </summary>
            [NameInMap("Y")]
            [Validation(Required=false)]
            public double? Y { get; set; }

        }

        /// <summary>
        /// <para>The specified user list for layout generation, which includes Blacklist/Whitelist.</para>
        /// <para>Whitelist: specifies the users whose video streams are subscribed to in the room.</para>
        /// <list type="bullet">
        /// <item><description>After the settings are applied, padding is automatically performed in sequence based on this list.</description></item>
        /// <item><description>When switching between multiple layouts in a template, only users in the whitelist are calculated.</description></item>
        /// </list>
        /// <para>Blacklist: specifies the users whose video streams are not subscribed to in the room.</para>
        /// <list type="bullet">
        /// <item><description>When switching between multiple layouts in a template, only users not in the blacklist are calculated.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("LayoutSpecifiedUsers")]
        [Validation(Required=false)]
        public string LayoutSpecifiedUsersShrink { get; set; }

        /// <summary>
        /// <para>The pane settings. You can configure up to 16 panes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eo85****</para>
        /// </summary>
        [NameInMap("Panes")]
        [Validation(Required=false)]
        public List<StartCloudRecordShrinkRequestPanes> Panes { get; set; }
        public class StartCloudRecordShrinkRequestPanes : TeaModel {
            /// <summary>
            /// <para>The local background images for the pane.</para>
            /// </summary>
            [NameInMap("Backgrounds")]
            [Validation(Required=false)]
            public List<StartCloudRecordShrinkRequestPanesBackgrounds> Backgrounds { get; set; }
            public class StartCloudRecordShrinkRequestPanesBackgrounds : TeaModel {
                /// <summary>
                /// <para>The transparency of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.9</para>
                /// </summary>
                [NameInMap("Alpha")]
                [Validation(Required=false)]
                public double? Alpha { get; set; }

                /// <summary>
                /// <para>The condition for displaying the background image. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>streamOnly: The background image is displayed when the current user has a video stream. This is the default value.</description></item>
                /// <item><description>backup: The background image is displayed when the current user does not have a video stream.</description></item>
                /// <item><description>always: The background image is always displayed.</description></item>
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
                /// <para>The crop mode of the image. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Crops the image while maintaining the aspect ratio.</description></item>
                /// <item><description><b>2</b>: Maintains the aspect ratio and adds borders.</description></item>
                /// <item><description><b>3</b>: Stretches the image to fill the pane.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("PaneBackgroundCropMode")]
                [Validation(Required=false)]
                public int? PaneBackgroundCropMode { get; set; }

                /// <summary>
                /// <para>The URL of the image.</para>
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
            public List<StartCloudRecordShrinkRequestPanesImages> Images { get; set; }
            public class StartCloudRecordShrinkRequestPanesImages : TeaModel {
                /// <summary>
                /// <para>The transparency of the image.</para>
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
                /// <item><description>streamOnly: The watermark is displayed when the current user has a video stream. This is the default value.</description></item>
                /// <item><description>backup: The watermark is displayed when the current user does not have a video stream.</description></item>
                /// <item><description>always: The watermark is always displayed.</description></item>
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
                /// <para>The crop mode of the image. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Crops the image while maintaining the aspect ratio.</description></item>
                /// <item><description><b>2</b>: Maintains the aspect ratio and adds borders.</description></item>
                /// <item><description><b>3</b>: Stretches the image to fill the pane.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("PaneImageCropMode")]
                [Validation(Required=false)]
                public int? PaneImageCropMode { get; set; }

                /// <summary>
                /// <para>The URL of the image. The image content cannot be updated during stream ingest.</para>
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
            /// <para>The crop mode of the image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Crops the image while maintaining the aspect ratio.</description></item>
            /// <item><description><b>2</b>: Maintains the aspect ratio and adds borders.</description></item>
            /// <item><description><b>3</b>: Stretches the image to fill the pane.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("PaneCropMode")]
            [Validation(Required=false)]
            public int? PaneCropMode { get; set; }

            /// <summary>
            /// <para>The ID of the pane. The value starts from 0.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PaneId")]
            [Validation(Required=false)]
            public int? PaneId { get; set; }

            /// <summary>
            /// <para>Specifies whether to reserve the pane as a placeholder for users who have not joined the meeting.
            /// Default value: true. A value of true indicates that if the specific user or wildcard user specified for the pane is offline, the pane is forcibly reserved as a placeholder. A value of false indicates that if the specific user or wildcard user specified for the pane is offline, video streams are displayed based on the automatic fill order.</para>
            /// </summary>
            [NameInMap("ReservePaneForOfflineUser")]
            [Validation(Required=false)]
            public bool? ReservePaneForOfflineUser { get; set; }

            /// <summary>
            /// <para>The media source of the pane. You can specify a user ID. To specify a specific user type, you can use wildcard configurations. The following wildcard types are supported:</para>
            /// <list type="bullet">
            /// <item><description><b>$ActiveSpeaker</b>: the current speaker in the channel.</description></item>
            /// <item><description><b>$ScreenShare</b>: the user who is sharing the screen. If multiple users are sharing their screens in the channel, the panes are filled in chronological order.</description></item>
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
            public List<StartCloudRecordShrinkRequestPanesTexts> Texts { get; set; }
            public class StartCloudRecordShrinkRequestPanesTexts : TeaModel {
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
                /// <para>The transparency of the text box.</para>
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
                /// <para>The color of the text box.</para>
                /// </summary>
                [NameInMap("BoxColor")]
                [Validation(Required=false)]
                public StartCloudRecordShrinkRequestPanesTextsBoxColor BoxColor { get; set; }
                public class StartCloudRecordShrinkRequestPanesTextsBoxColor : TeaModel {
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
                /// <item><description>streamOnly: The watermark is displayed when the current user has a video stream. This is the default value.</description></item>
                /// <item><description>backup: The watermark is displayed when the current user does not have a video stream.</description></item>
                /// <item><description>always: The watermark is always displayed.</description></item>
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
                public StartCloudRecordShrinkRequestPanesTextsFontColor FontColor { get; set; }
                public class StartCloudRecordShrinkRequestPanesTextsFontColor : TeaModel {
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
            public StartCloudRecordShrinkRequestPanesWhiteboard Whiteboard { get; set; }
            public class StartCloudRecordShrinkRequestPanesWhiteboard : TeaModel {
                /// <summary>
                /// <para>The ID of the whiteboard. Default value: default.</para>
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
        /// <para>The recording mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Mixed-stream recording. This is the default value.</description></item>
        /// <item><description>1: Single-stream recording. Single-stream recording does not support updates.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RecordMode")]
        [Validation(Required=false)]
        public int? RecordMode { get; set; }

        /// <summary>
        /// <para>The global frame background color.</para>
        /// </summary>
        [NameInMap("RegionColor")]
        [Validation(Required=false)]
        public StartCloudRecordShrinkRequestRegionColor RegionColor { get; set; }
        public class StartCloudRecordShrinkRequestRegionColor : TeaModel {
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
        /// <para>Specifies whether to reserve a pane for a user who does not publish a camera stream. Default value: true. A value of true indicates that a pane is reserved. A value of false indicates that no pane is reserved.</para>
        /// </summary>
        [NameInMap("ReservePaneForNoCameraUser")]
        [Validation(Required=false)]
        public bool? ReservePaneForNoCameraUser { get; set; }

        /// <summary>
        /// <para>Specifies whether to display the default background image of the pane when the user is muted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Displays the default background image (default).</description></item>
        /// <item><description>false: Does not display the default background image. The custom background image of the pane is still displayed.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ShowDefaultBackgroundOnMute")]
        [Validation(Required=false)]
        public bool? ShowDefaultBackgroundOnMute { get; set; }

        /// <summary>
        /// <para>The parameters for single-stream recording.</para>
        /// </summary>
        [NameInMap("SingleStreamingRecord")]
        [Validation(Required=false)]
        public string SingleStreamingRecordShrink { get; set; }

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
        /// <para>The wait time for the task when the channel is not started, in seconds. This parameter takes effect only when the StartWithoutChannel parameter is set to true. Valid values: 30 to 120.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("StartWithoutChannelWaitTime")]
        [Validation(Required=false)]
        public int? StartWithoutChannelWaitTime { get; set; }

        /// <summary>
        /// <para>The storage configuration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testid</para>
        /// </summary>
        [NameInMap("StorageConfig")]
        [Validation(Required=false)]
        public StartCloudRecordShrinkRequestStorageConfig StorageConfig { get; set; }
        public class StartCloudRecordShrinkRequestStorageConfig : TeaModel {
            /// <summary>
            /// <para>The AccessKey. Make sure that the RAM user associated with the AccessKey pair is granted the <b>write</b> permissions on the object storage service of the corresponding cloud provider. Otherwise, the result files fail to be written.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LTAX***</para>
            /// </summary>
            [NameInMap("AccessKey")]
            [Validation(Required=false)]
            public string AccessKey { get; set; }

            /// <summary>
            /// <para>The name of the bucket.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-bucket-for-recording</para>
            /// </summary>
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            /// <summary>
            /// <para>The private endpoint for Apsara Stack.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://aliyuns.dalian.oss.com">https://aliyuns.dalian.oss.com</a></para>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The storage region.</para>
            /// <table>
            /// <thead>
            /// <tr>
            /// <th>Region</th>
            /// <th>Alibaba Cloud OSS</th>
            /// </tr>
            /// </thead>
            /// <tbody><tr>
            /// <td>0</td>
            /// <td>CN_Hangzhou</td>
            /// </tr>
            /// <tr>
            /// <td>1</td>
            /// <td>CN_Shanghai</td>
            /// </tr>
            /// <tr>
            /// <td>2</td>
            /// <td>CN_Qingdao</td>
            /// </tr>
            /// <tr>
            /// <td>3</td>
            /// <td>CN_Beijing</td>
            /// </tr>
            /// <tr>
            /// <td>4</td>
            /// <td>CN_Zhangjiakou</td>
            /// </tr>
            /// <tr>
            /// <td>5</td>
            /// <td>CN_Huhehaote</td>
            /// </tr>
            /// <tr>
            /// <td>6</td>
            /// <td>CN_Shenzhen</td>
            /// </tr>
            /// <tr>
            /// <td>7</td>
            /// <td>CN_Hongkong</td>
            /// </tr>
            /// <tr>
            /// <td>8</td>
            /// <td>US_West_1</td>
            /// </tr>
            /// <tr>
            /// <td>9</td>
            /// <td>US_East_1</td>
            /// </tr>
            /// <tr>
            /// <td>10</td>
            /// <td>AP_Southeast_1</td>
            /// </tr>
            /// <tr>
            /// <td>11</td>
            /// <td>AP_Southeast_2 (Deprecated. Do not use.)</td>
            /// </tr>
            /// <tr>
            /// <td>12</td>
            /// <td>AP_Southeast_3</td>
            /// </tr>
            /// <tr>
            /// <td>13</td>
            /// <td>AP_Southeast_5</td>
            /// </tr>
            /// <tr>
            /// <td>14</td>
            /// <td>AP_Northeast_1</td>
            /// </tr>
            /// <tr>
            /// <td>15</td>
            /// <td>AP_South_1 (Deprecated. Do not use.)</td>
            /// </tr>
            /// <tr>
            /// <td>16</td>
            /// <td>EU_Central_1</td>
            /// </tr>
            /// <tr>
            /// <td>17</td>
            /// <td>EU_West_1</td>
            /// </tr>
            /// <tr>
            /// <td>18</td>
            /// <td>EU_East_1(ME_East_1)</td>
            /// </tr>
            /// <tr>
            /// <td>19</td>
            /// <td>AP_Southeast_6</td>
            /// </tr>
            /// <tr>
            /// <td>20</td>
            /// <td>CN_Heyuan</td>
            /// </tr>
            /// <tr>
            /// <td>21</td>
            /// <td>CN_Guangzhou</td>
            /// </tr>
            /// <tr>
            /// <td>22</td>
            /// <td>CN_Chengdu</td>
            /// </tr>
            /// <tr>
            /// <td>23</td>
            /// <td>CN_Nanjing</td>
            /// </tr>
            /// <tr>
            /// <td>24</td>
            /// <td>CN_Fuzhou</td>
            /// </tr>
            /// <tr>
            /// <td>25</td>
            /// <td>CN_Wulanchabu</td>
            /// </tr>
            /// <tr>
            /// <td>26</td>
            /// <td>CN_Northeast_2</td>
            /// </tr>
            /// <tr>
            /// <td>27</td>
            /// <td>CN_Southeast_7</td>
            /// </tr>
            /// <tr>
            /// <td>28</td>
            /// <td>CN_Wuhan_LR</td>
            /// </tr>
            /// <tr>
            /// <td>100</td>
            /// <td>oss-cn-hzjbp</td>
            /// </tr>
            /// <tr>
            /// <td>101</td>
            /// <td>oss-cn-shanghai-finance-1</td>
            /// </tr>
            /// <tr>
            /// <td>102</td>
            /// <td>oss-cn-shenzhen-finance-1</td>
            /// </tr>
            /// <tr>
            /// <td>103</td>
            /// <td>oss-cn-beijing-finance-1</td>
            /// </tr>
            /// <tr>
            /// <td>104</td>
            /// <td>oss-cn-hzfinance</td>
            /// </tr>
            /// <tr>
            /// <td>105</td>
            /// <td>oss-cn-shanghai-finance-1-pub</td>
            /// </tr>
            /// <tr>
            /// <td>106</td>
            /// <td>oss-cn-szfinance</td>
            /// </tr>
            /// <tr>
            /// <td>107</td>
            /// <td>oss-cn-beijing-finance-1-pub</td>
            /// </tr>
            /// </tbody></table>
            /// <table>
            /// <thead>
            /// <tr>
            /// <th>Region</th>
            /// <th>Apsara Stack OSS</th>
            /// </tr>
            /// </thead>
            /// <tbody><tr>
            /// <td>0</td>
            /// <td>default</td>
            /// </tr>
            /// </tbody></table>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public int? Region { get; set; }

            /// <summary>
            /// <para>secretKey</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>APb6qWYEzKtYxE***</para>
            /// </summary>
            [NameInMap("SecretKey")]
            [Validation(Required=false)]
            public string SecretKey { get; set; }

            /// <summary>
            /// <para>The storage platform. Valid values:</para>
            /// <table>
            /// <thead>
            /// <tr>
            /// <th>vendor</th>
            /// <th>Object storage service</th>
            /// <th>Remarks</th>
            /// </tr>
            /// </thead>
            /// <tbody><tr>
            /// <td>1</td>
            /// <td>AliYun OSS</td>
            /// <td>Alibaba Cloud</td>
            /// </tr>
            /// <tr>
            /// <td>2</td>
            /// <td>Apsara Stack OSS</td>
            /// <td>Alibaba Cloud Apsara Stack</td>
            /// </tr>
            /// </tbody></table>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public int? Vendor { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to subscribe to high-resolution streams. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false: Subscribes to streams of different resolutions based on the pane area (default).</description></item>
        /// <item><description>true: Uses the highest resolution stream published by the client as padding.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("SubHighResolutionStream")]
        [Validation(Required=false)]
        public bool? SubHighResolutionStream { get; set; }

        /// <summary>
        /// <para>The task ID of the cloud recording task. Only a single ID is supported. The ID can contain letters, digits, underscores (_), and hyphens (-), and can be up to 55 bytes in length.</para>
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
        /// <para>The global text watermarks.</para>
        /// </summary>
        [NameInMap("Texts")]
        [Validation(Required=false)]
        public List<StartCloudRecordShrinkRequestTexts> Texts { get; set; }
        public class StartCloudRecordShrinkRequestTexts : TeaModel {
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
            /// <para>The transparency of the text box.</para>
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
            /// <para>The color of the text box.</para>
            /// </summary>
            [NameInMap("BoxColor")]
            [Validation(Required=false)]
            public StartCloudRecordShrinkRequestTextsBoxColor BoxColor { get; set; }
            public class StartCloudRecordShrinkRequestTextsBoxColor : TeaModel {
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
            public StartCloudRecordShrinkRequestTextsFontColor FontColor { get; set; }
            public class StartCloudRecordShrinkRequestTextsFontColor : TeaModel {
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
