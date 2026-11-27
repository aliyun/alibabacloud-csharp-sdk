// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class UpdateCloudRecordRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. You can create and query it in the console. Only one ID is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eo85****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>Background images.</para>
        /// </summary>
        [NameInMap("Backgrounds")]
        [Validation(Required=false)]
        public List<UpdateCloudRecordRequestBackgrounds> Backgrounds { get; set; }
        public class UpdateCloudRecordRequestBackgrounds : TeaModel {
            /// <summary>
            /// <para>Transparency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.9</para>
            /// </summary>
            [NameInMap("Alpha")]
            [Validation(Required=false)]
            public double? Alpha { get; set; }

            /// <summary>
            /// <para>The cropping mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: Crop while maintaining aspect ratio.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: Maintain aspect ratio with padding.</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: Stretch to fill.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("BackgroundCropMode")]
            [Validation(Required=false)]
            public int? BackgroundCropMode { get; set; }

            /// <summary>
            /// <para>Height.</para>
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
            /// <para>Width.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public double? Width { get; set; }

            /// <summary>
            /// <para>The horizontal coordinate.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("X")]
            [Validation(Required=false)]
            public double? X { get; set; }

            /// <summary>
            /// <para>The vertical coordinate.</para>
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
        /// <para>The existing channel ID. Only one ID is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testid</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// <para>Global clock watermarks.</para>
        /// </summary>
        [NameInMap("ClockWidgets")]
        [Validation(Required=false)]
        public List<UpdateCloudRecordRequestClockWidgets> ClockWidgets { get; set; }
        public class UpdateCloudRecordRequestClockWidgets : TeaModel {
            /// <summary>
            /// <para>Transparency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.9</para>
            /// </summary>
            [NameInMap("Alpha")]
            [Validation(Required=false)]
            public double? Alpha { get; set; }

            /// <summary>
            /// <para>Rectangle box transparency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.6</para>
            /// </summary>
            [NameInMap("BoxAlpha")]
            [Validation(Required=false)]
            public double? BoxAlpha { get; set; }

            /// <summary>
            /// <para>Rectangle box border width.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("BoxBorderw")]
            [Validation(Required=false)]
            public int? BoxBorderw { get; set; }

            /// <summary>
            /// <para>Rectangle box color.</para>
            /// </summary>
            [NameInMap("BoxColor")]
            [Validation(Required=false)]
            public UpdateCloudRecordRequestClockWidgetsBoxColor BoxColor { get; set; }
            public class UpdateCloudRecordRequestClockWidgetsBoxColor : TeaModel {
                /// <summary>
                /// <para>B.</para>
                /// 
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("B")]
                [Validation(Required=false)]
                public int? B { get; set; }

                /// <summary>
                /// <para>G.</para>
                /// 
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("G")]
                [Validation(Required=false)]
                public int? G { get; set; }

                /// <summary>
                /// <para>R.</para>
                /// 
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("R")]
                [Validation(Required=false)]
                public int? R { get; set; }

            }

            /// <summary>
            /// <para>Font.</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: Alibaba PuHuiTi Regular</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: Alibaba PuHuiTi Light</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: Alibaba PuHuiTi Medium</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: Alibaba PuHuiTi Bold</para>
            /// </description></item>
            /// <item><description><para><b>4</b>: Alibaba PuHuiTi Heavy</para>
            /// </description></item>
            /// <item><description><para><b>5</b>: Ali Mama ShuHeiTi</para>
            /// </description></item>
            /// <item><description><para><b>6</b>: DingTalk JinBuTi</para>
            /// </description></item>
            /// <item><description><para><b>7</b>: Ali Mama DaoLiTi</para>
            /// </description></item>
            /// <item><description><para><b>8</b>: Ali Mama DongFang DaKai</para>
            /// </description></item>
            /// <item><description><para><b>9</b>: Ali Mama FangYuanTi</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Font")]
            [Validation(Required=false)]
            public int? Font { get; set; }

            /// <summary>
            /// <para>Font color.</para>
            /// </summary>
            [NameInMap("FontColor")]
            [Validation(Required=false)]
            public UpdateCloudRecordRequestClockWidgetsFontColor FontColor { get; set; }
            public class UpdateCloudRecordRequestClockWidgetsFontColor : TeaModel {
                /// <summary>
                /// <para>B.</para>
                /// 
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("B")]
                [Validation(Required=false)]
                public int? B { get; set; }

                /// <summary>
                /// <para>G.</para>
                /// 
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("G")]
                [Validation(Required=false)]
                public int? G { get; set; }

                /// <summary>
                /// <para>R.</para>
                /// 
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("R")]
                [Validation(Required=false)]
                public int? R { get; set; }

            }

            /// <summary>
            /// <para>Clock font size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("FontSize")]
            [Validation(Required=false)]
            public int? FontSize { get; set; }

            /// <summary>
            /// <para>Whether to draw a rectangle box.</para>
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
            /// <para>The horizontal coordinate.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("X")]
            [Validation(Required=false)]
            public double? X { get; set; }

            /// <summary>
            /// <para>The vertical coordinate.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("Y")]
            [Validation(Required=false)]
            public double? Y { get; set; }

            /// <summary>
            /// <para>Time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("Zone")]
            [Validation(Required=false)]
            public int? Zone { get; set; }

        }

        /// <summary>
        /// <para>Global image watermarks.</para>
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public List<UpdateCloudRecordRequestImages> Images { get; set; }
        public class UpdateCloudRecordRequestImages : TeaModel {
            /// <summary>
            /// <para>Transparency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.9</para>
            /// </summary>
            [NameInMap("Alpha")]
            [Validation(Required=false)]
            public double? Alpha { get; set; }

            /// <summary>
            /// <para>Height.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public double? Height { get; set; }

            /// <summary>
            /// <para>The cropping mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: Crop while maintaining aspect ratio.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: Maintain aspect ratio with padding.</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: Stretch to fill.</para>
            /// </description></item>
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
            /// <para><a href="https://aliyun.com/123.jpg">https://aliyun.com/123.jpg</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            /// <summary>
            /// <para>Width.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public double? Width { get; set; }

            /// <summary>
            /// <para>The horizontal coordinate.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("X")]
            [Validation(Required=false)]
            public double? X { get; set; }

            /// <summary>
            /// <para>The vertical coordinate.</para>
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
        /// <para>A list that specifies users for layout generation. It supports both blacklists and whitelists.</para>
        /// <para>Whitelist: Specifies the users whose video streams are subscribed to in the channel.</para>
        /// <list type="bullet">
        /// <item><description><para>The auto-fill feature uses this list for sequential filling.</para>
        /// </description></item>
        /// <item><description><para>During multi-layout switching, only users in the whitelist are included.</para>
        /// </description></item>
        /// </list>
        /// <para>Blacklist: Specifies the users whose video streams are not subscribed to in the channel.</para>
        /// <list type="bullet">
        /// <item><description>During multi-layout switching, only users not in the blacklist are included.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("LayoutSpecifiedUsers")]
        [Validation(Required=false)]
        public UpdateCloudRecordRequestLayoutSpecifiedUsers LayoutSpecifiedUsers { get; set; }
        public class UpdateCloudRecordRequestLayoutSpecifiedUsers : TeaModel {
            /// <summary>
            /// <para>The list of specified user IDs.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Ids")]
            [Validation(Required=false)]
            public List<string> Ids { get; set; }

            /// <summary>
            /// <para>The type of the user list. Valid values: `black` for a blacklist and `white` for a whitelist.</para>
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
        /// <para>Cell settings.</para>
        /// </summary>
        [NameInMap("Panes")]
        [Validation(Required=false)]
        public List<UpdateCloudRecordRequestPanes> Panes { get; set; }
        public class UpdateCloudRecordRequestPanes : TeaModel {
            /// <summary>
            /// <para>Background images.</para>
            /// </summary>
            [NameInMap("Backgrounds")]
            [Validation(Required=false)]
            public List<UpdateCloudRecordRequestPanesBackgrounds> Backgrounds { get; set; }
            public class UpdateCloudRecordRequestPanesBackgrounds : TeaModel {
                /// <summary>
                /// <para>Transparency.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.9</para>
                /// </summary>
                [NameInMap("Alpha")]
                [Validation(Required=false)]
                public double? Alpha { get; set; }

                /// <summary>
                /// <para>When to display.</para>
                /// <list type="bullet">
                /// <item><description><para>streamOnly: Display only when the user has a video stream (default).</para>
                /// </description></item>
                /// <item><description><para>backup: Display only when the user has no video stream.</para>
                /// </description></item>
                /// <item><description><para>always: Always display.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>backup</para>
                /// </summary>
                [NameInMap("Display")]
                [Validation(Required=false)]
                public string Display { get; set; }

                /// <summary>
                /// <para>Height.</para>
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
                /// <para>The cropping mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>1</b>: Crop while maintaining aspect ratio.</para>
                /// </description></item>
                /// <item><description><para><b>2</b>: Maintain aspect ratio with padding.</para>
                /// </description></item>
                /// <item><description><para><b>3</b>: Stretch to fill.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("PaneBackgroundCropMode")]
                [Validation(Required=false)]
                public int? PaneBackgroundCropMode { get; set; }

                /// <summary>
                /// <para>The background image URL.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://aliyun.com/123xx.jpg">https://aliyun.com/123xx.jpg</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// <para>Width.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.2</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public double? Width { get; set; }

                /// <summary>
                /// <para>The horizontal coordinate.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.2</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public double? X { get; set; }

                /// <summary>
                /// <para>The vertical coordinate.</para>
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
            /// <para>Local image watermarks for the pane.</para>
            /// </summary>
            [NameInMap("Images")]
            [Validation(Required=false)]
            public List<UpdateCloudRecordRequestPanesImages> Images { get; set; }
            public class UpdateCloudRecordRequestPanesImages : TeaModel {
                /// <summary>
                /// <para>Transparency.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.9</para>
                /// </summary>
                [NameInMap("Alpha")]
                [Validation(Required=false)]
                public double? Alpha { get; set; }

                /// <summary>
                /// <para>When to display the watermark.</para>
                /// <list type="bullet">
                /// <item><description><para>streamOnly: Display only when the user has a video stream (default).</para>
                /// </description></item>
                /// <item><description><para>backup: Display only when the user has no video stream.</para>
                /// </description></item>
                /// <item><description><para>always: Always display.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>backup</para>
                /// </summary>
                [NameInMap("Display")]
                [Validation(Required=false)]
                public string Display { get; set; }

                /// <summary>
                /// <para>Height.</para>
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
                /// <para>The cropping mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>1</b>: Crop while maintaining aspect ratio.</para>
                /// </description></item>
                /// <item><description><para><b>2</b>: Maintain aspect ratio with padding.</para>
                /// </description></item>
                /// <item><description><para><b>3</b>: Stretch to fill.</para>
                /// </description></item>
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
                /// <para><a href="https://aliyun.com/123xxx.jpg">https://aliyun.com/123xxx.jpg</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// <para>Width.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.2</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public double? Width { get; set; }

                /// <summary>
                /// <para>The horizontal coordinate.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.2</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public double? X { get; set; }

                /// <summary>
                /// <para>The vertical coordinate.</para>
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
            /// <para>The cropping mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: Crop while maintaining aspect ratio.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: Maintain aspect ratio with padding.</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: Stretch to fill.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("PaneCropMode")]
            [Validation(Required=false)]
            public int? PaneCropMode { get; set; }

            /// <summary>
            /// <para>The pane ID, starting from 0.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PaneId")]
            [Validation(Required=false)]
            public int? PaneId { get; set; }

            /// <summary>
            /// <para>Reserves a pane for a user who goes offline. The default value is true. If true, the pane for a specified user or wildcard user remains as a placeholder. If false, the pane is filled with a video stream based on the Auto Fill order.</para>
            /// </summary>
            [NameInMap("ReservePaneForOfflineUser")]
            [Validation(Required=false)]
            public bool? ReservePaneForOfflineUser { get; set; }

            /// <summary>
            /// <para>The media source for the cell. You can specify a userId to target a specific user. Wildcard characters are also supported:</para>
            /// <list type="bullet">
            /// <item><description><para><b>$ActiveSpeaker</b>: The current active speaker in the channel.</para>
            /// </description></item>
            /// <item><description><para><b>$ScreenShare</b>: A screen-sharing user. If multiple users share their screens, they are filled in sequence.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The media type of the cell. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>video</b>: Camera or screen sharing stream (default).</para>
            /// </description></item>
            /// <item><description><para><b>camera</b>: Camera stream.</para>
            /// </description></item>
            /// <item><description><para><b>screen</b>: Screen sharing stream.</para>
            /// </description></item>
            /// <item><description><para><b>whiteboard</b>: Whiteboard.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>video</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>Local text watermarks for the pane.</para>
            /// </summary>
            [NameInMap("Texts")]
            [Validation(Required=false)]
            public List<UpdateCloudRecordRequestPanesTexts> Texts { get; set; }
            public class UpdateCloudRecordRequestPanesTexts : TeaModel {
                /// <summary>
                /// <para>Watermark transparency.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.9</para>
                /// </summary>
                [NameInMap("Alpha")]
                [Validation(Required=false)]
                public double? Alpha { get; set; }

                /// <summary>
                /// <para>Rectangle box transparency.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.6</para>
                /// </summary>
                [NameInMap("BoxAlpha")]
                [Validation(Required=false)]
                public double? BoxAlpha { get; set; }

                /// <summary>
                /// <para>Rectangle box border width.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("BoxBorderw")]
                [Validation(Required=false)]
                public int? BoxBorderw { get; set; }

                /// <summary>
                /// <para>Rectangle box color.</para>
                /// </summary>
                [NameInMap("BoxColor")]
                [Validation(Required=false)]
                public UpdateCloudRecordRequestPanesTextsBoxColor BoxColor { get; set; }
                public class UpdateCloudRecordRequestPanesTextsBoxColor : TeaModel {
                    /// <summary>
                    /// <para>B.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>255</para>
                    /// </summary>
                    [NameInMap("B")]
                    [Validation(Required=false)]
                    public int? B { get; set; }

                    /// <summary>
                    /// <para>G.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>255</para>
                    /// </summary>
                    [NameInMap("G")]
                    [Validation(Required=false)]
                    public int? G { get; set; }

                    /// <summary>
                    /// <para>R.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>255</para>
                    /// </summary>
                    [NameInMap("R")]
                    [Validation(Required=false)]
                    public int? R { get; set; }

                }

                /// <summary>
                /// <para>When to display the watermark.</para>
                /// <list type="bullet">
                /// <item><description><para>streamOnly: Display only when the user has a video stream (default).</para>
                /// </description></item>
                /// <item><description><para>backup: Display only when the user has no video stream.</para>
                /// </description></item>
                /// <item><description><para>always: Always display.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>backup</para>
                /// </summary>
                [NameInMap("Display")]
                [Validation(Required=false)]
                public string Display { get; set; }

                /// <summary>
                /// <para>Font.</para>
                /// <list type="bullet">
                /// <item><description><para><b>0</b>: Alibaba PuHuiTi Regular</para>
                /// </description></item>
                /// <item><description><para><b>1</b>: Alibaba PuHuiTi Light</para>
                /// </description></item>
                /// <item><description><para><b>2</b>: Alibaba PuHuiTi Medium</para>
                /// </description></item>
                /// <item><description><para><b>3</b>: Alibaba PuHuiTi Bold</para>
                /// </description></item>
                /// <item><description><para><b>4</b>: Alibaba PuHuiTi Heavy</para>
                /// </description></item>
                /// <item><description><para><b>5</b>: Ali Mama ShuHeiTi</para>
                /// </description></item>
                /// <item><description><para><b>6</b>: DingTalk JinBuTi</para>
                /// </description></item>
                /// <item><description><para><b>7</b>: Ali Mama DaoLiTi</para>
                /// </description></item>
                /// <item><description><para><b>8</b>: Ali Mama DongFang DaKai</para>
                /// </description></item>
                /// <item><description><para><b>9</b>: Ali Mama FangYuanTi</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Font")]
                [Validation(Required=false)]
                public int? Font { get; set; }

                /// <summary>
                /// <para>Font color.</para>
                /// </summary>
                [NameInMap("FontColor")]
                [Validation(Required=false)]
                public UpdateCloudRecordRequestPanesTextsFontColor FontColor { get; set; }
                public class UpdateCloudRecordRequestPanesTextsFontColor : TeaModel {
                    /// <summary>
                    /// <para>B.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>255</para>
                    /// </summary>
                    [NameInMap("B")]
                    [Validation(Required=false)]
                    public int? B { get; set; }

                    /// <summary>
                    /// <para>G.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>255</para>
                    /// </summary>
                    [NameInMap("G")]
                    [Validation(Required=false)]
                    public int? G { get; set; }

                    /// <summary>
                    /// <para>R.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>255</para>
                    /// </summary>
                    [NameInMap("R")]
                    [Validation(Required=false)]
                    public int? R { get; set; }

                }

                /// <summary>
                /// <para>Font size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>36</para>
                /// </summary>
                [NameInMap("FontSize")]
                [Validation(Required=false)]
                public int? FontSize { get; set; }

                /// <summary>
                /// <para>Whether to draw a rectangle box.</para>
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
                /// <para>文字水印</para>
                /// </summary>
                [NameInMap("Texture")]
                [Validation(Required=false)]
                public string Texture { get; set; }

                /// <summary>
                /// <para>The horizontal coordinate.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.2</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public double? X { get; set; }

                /// <summary>
                /// <para>The vertical coordinate.</para>
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
            /// <para>The fill order when SourceType is video.</para>
            /// <list type="bullet">
            /// <item><description><para>screenFirst: Prioritize screen sharing (default).</para>
            /// </description></item>
            /// <item><description><para>cameraFirst: Prioritize camera.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cameraFirst</para>
            /// </summary>
            [NameInMap("VideoOrder")]
            [Validation(Required=false)]
            public string VideoOrder { get; set; }

            /// <summary>
            /// <para>Whiteboard configuration.</para>
            /// </summary>
            [NameInMap("Whiteboard")]
            [Validation(Required=false)]
            public UpdateCloudRecordRequestPanesWhiteboard Whiteboard { get; set; }
            public class UpdateCloudRecordRequestPanesWhiteboard : TeaModel {
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
        /// <para>The task ID for this cloud recording. Only one ID is supported. It can contain letters, digits, underscores (_), and hyphens (-), with a maximum length of 55 bytes.</para>
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
        /// <para>Notice: To update the layout, change the template ID. Resolution updates are not supported.</para>
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
        /// <para>Global text watermarks.</para>
        /// </summary>
        [NameInMap("Texts")]
        [Validation(Required=false)]
        public List<UpdateCloudRecordRequestTexts> Texts { get; set; }
        public class UpdateCloudRecordRequestTexts : TeaModel {
            /// <summary>
            /// <para>Watermark transparency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.1</para>
            /// </summary>
            [NameInMap("Alpha")]
            [Validation(Required=false)]
            public double? Alpha { get; set; }

            /// <summary>
            /// <para>Rectangle box transparency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.6</para>
            /// </summary>
            [NameInMap("BoxAlpha")]
            [Validation(Required=false)]
            public double? BoxAlpha { get; set; }

            /// <summary>
            /// <para>Rectangle box border width.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("BoxBorderw")]
            [Validation(Required=false)]
            public int? BoxBorderw { get; set; }

            /// <summary>
            /// <para>Rectangle box color.</para>
            /// </summary>
            [NameInMap("BoxColor")]
            [Validation(Required=false)]
            public UpdateCloudRecordRequestTextsBoxColor BoxColor { get; set; }
            public class UpdateCloudRecordRequestTextsBoxColor : TeaModel {
                /// <summary>
                /// <para>B.</para>
                /// 
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("B")]
                [Validation(Required=false)]
                public int? B { get; set; }

                /// <summary>
                /// <para>G.</para>
                /// 
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("G")]
                [Validation(Required=false)]
                public int? G { get; set; }

                /// <summary>
                /// <para>R.</para>
                /// 
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("R")]
                [Validation(Required=false)]
                public int? R { get; set; }

            }

            /// <summary>
            /// <para>Font.</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: Alibaba PuHuiTi Regular</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: Alibaba PuHuiTi Light</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: Alibaba PuHuiTi Medium</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: Alibaba PuHuiTi Bold</para>
            /// </description></item>
            /// <item><description><para><b>4</b>: Alibaba PuHuiTi Heavy</para>
            /// </description></item>
            /// <item><description><para><b>5</b>: Ali Mama ShuHeiTi</para>
            /// </description></item>
            /// <item><description><para><b>6</b>: DingTalk JinBuTi</para>
            /// </description></item>
            /// <item><description><para><b>7</b>: Ali Mama DaoLiTi</para>
            /// </description></item>
            /// <item><description><para><b>8</b>: Ali Mama DongFang DaKai</para>
            /// </description></item>
            /// <item><description><para><b>9</b>: Ali Mama FangYuanTi</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Font")]
            [Validation(Required=false)]
            public int? Font { get; set; }

            /// <summary>
            /// <para>Font color.</para>
            /// </summary>
            [NameInMap("FontColor")]
            [Validation(Required=false)]
            public UpdateCloudRecordRequestTextsFontColor FontColor { get; set; }
            public class UpdateCloudRecordRequestTextsFontColor : TeaModel {
                /// <summary>
                /// <para>B.</para>
                /// 
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("B")]
                [Validation(Required=false)]
                public int? B { get; set; }

                /// <summary>
                /// <para>G.</para>
                /// 
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("G")]
                [Validation(Required=false)]
                public int? G { get; set; }

                /// <summary>
                /// <para>R.</para>
                /// 
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("R")]
                [Validation(Required=false)]
                public int? R { get; set; }

            }

            /// <summary>
            /// <para>Font size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>36</para>
            /// </summary>
            [NameInMap("FontSize")]
            [Validation(Required=false)]
            public int? FontSize { get; set; }

            /// <summary>
            /// <para>Whether to draw a rectangle box.</para>
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
            /// <para>文字水印</para>
            /// </summary>
            [NameInMap("Texture")]
            [Validation(Required=false)]
            public string Texture { get; set; }

            /// <summary>
            /// <para>The horizontal coordinate.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("X")]
            [Validation(Required=false)]
            public double? X { get; set; }

            /// <summary>
            /// <para>The vertical coordinate.</para>
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
