// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeStudioLayoutsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5c6a2a0d-f228-4a64-af62-20e91b9676b3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The layout information.</para>
        /// </summary>
        [NameInMap("StudioLayouts")]
        [Validation(Required=false)]
        public List<DescribeStudioLayoutsResponseBodyStudioLayouts> StudioLayouts { get; set; }
        public class DescribeStudioLayoutsResponseBodyStudioLayouts : TeaModel {
            /// <summary>
            /// <para>The background resource configuration.</para>
            /// </summary>
            [NameInMap("BgImageConfig")]
            [Validation(Required=false)]
            public DescribeStudioLayoutsResponseBodyStudioLayoutsBgImageConfig BgImageConfig { get; set; }
            public class DescribeStudioLayoutsResponseBodyStudioLayoutsBgImageConfig : TeaModel {
                /// <summary>
                /// <para>The unique ID of the background material.</para>
                /// 
                /// <b>Example:</b>
                /// <para>k12kj31****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The URL of the material.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://example.org">http://example.org</a></para>
                /// </summary>
                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

                /// <summary>
                /// <para>The location ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RV01</para>
                /// </summary>
                [NameInMap("LocationId")]
                [Validation(Required=false)]
                public string LocationId { get; set; }

                /// <summary>
                /// <para>The video-on-demand material ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>asdfas9df89asd8f9****</para>
                /// </summary>
                [NameInMap("MaterialId")]
                [Validation(Required=false)]
                public string MaterialId { get; set; }

            }

            /// <summary>
            /// <para>The common layout information. This field is returned when the layout is a common layout.</para>
            /// </summary>
            [NameInMap("CommonConfig")]
            [Validation(Required=false)]
            public DescribeStudioLayoutsResponseBodyStudioLayoutsCommonConfig CommonConfig { get; set; }
            public class DescribeStudioLayoutsResponseBodyStudioLayoutsCommonConfig : TeaModel {
                /// <summary>
                /// <para>The channel location ID to which the video resource is bound.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RV01</para>
                /// </summary>
                [NameInMap("ChannelId")]
                [Validation(Required=false)]
                public string ChannelId { get; set; }

                /// <summary>
                /// <para>The video resource ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>asdfasdfasdfasdfa****</para>
                /// </summary>
                [NameInMap("VideoResourceId")]
                [Validation(Required=false)]
                public string VideoResourceId { get; set; }

            }

            /// <summary>
            /// <para>The layer order configuration.</para>
            /// </summary>
            [NameInMap("LayerOrderConfigList")]
            [Validation(Required=false)]
            public List<DescribeStudioLayoutsResponseBodyStudioLayoutsLayerOrderConfigList> LayerOrderConfigList { get; set; }
            public class DescribeStudioLayoutsResponseBodyStudioLayoutsLayerOrderConfigList : TeaModel {
                /// <summary>
                /// <para>The unique ID of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>k12kj31****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The type of the resource configuration. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>background</b>: background material.</description></item>
                /// <item><description><b>media</b>: multimedia material.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>media</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The studio layout ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>445409ec-7eaa-461d-8f29-4bec2eb9****</para>
            /// </summary>
            [NameInMap("LayoutId")]
            [Validation(Required=false)]
            public string LayoutId { get; set; }

            /// <summary>
            /// <para>The studio layout name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试布局</para>
            /// </summary>
            [NameInMap("LayoutName")]
            [Validation(Required=false)]
            public string LayoutName { get; set; }

            /// <summary>
            /// <para>The studio layout type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>common</b>: common layout.</description></item>
            /// <item><description><b>studio</b>: studio layout.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>studio</para>
            /// </summary>
            [NameInMap("LayoutType")]
            [Validation(Required=false)]
            public string LayoutType { get; set; }

            /// <summary>
            /// <para>The multimedia input resource configuration.</para>
            /// </summary>
            [NameInMap("MediaInputConfigList")]
            [Validation(Required=false)]
            public List<DescribeStudioLayoutsResponseBodyStudioLayoutsMediaInputConfigList> MediaInputConfigList { get; set; }
            public class DescribeStudioLayoutsResponseBodyStudioLayoutsMediaInputConfigList : TeaModel {
                /// <summary>
                /// <para>The channel location ID to which the video resource is bound.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RV01</para>
                /// </summary>
                [NameInMap("ChannelId")]
                [Validation(Required=false)]
                public string ChannelId { get; set; }

                /// <summary>
                /// <para>The fill type. Default value: none.</para>
                /// 
                /// <b>Example:</b>
                /// <para>none</para>
                /// </summary>
                [NameInMap("FillMode")]
                [Validation(Required=false)]
                public string FillMode { get; set; }

                /// <summary>
                /// <para>The normalized height of the material. This is the height ratio of the material to the background. Valid values: <b>0 to 1</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.4</para>
                /// </summary>
                [NameInMap("HeightNormalized")]
                [Validation(Required=false)]
                public float? HeightNormalized { get; set; }

                /// <summary>
                /// <para>The unique ID of the multimedia material.</para>
                /// 
                /// <b>Example:</b>
                /// <para>k12kj31****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The video-on-demand image material ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lkajsdfsa8fd89asd8****</para>
                /// </summary>
                [NameInMap("ImageMaterialId")]
                [Validation(Required=false)]
                public string ImageMaterialId { get; set; }

                /// <summary>
                /// <para>The multimedia material number. Used for frontend display only and has no logical function.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Index")]
                [Validation(Required=false)]
                public int? Index { get; set; }

                /// <summary>
                /// <para>The normalized position of the material fill area [x,y]. The values of x and y range from <b>0 to 1</b>. For example, [0.1,0.2] indicates a horizontal offset of 10% and a vertical offset of 20% from the upper-left corner.</para>
                /// </summary>
                [NameInMap("PositionNormalized")]
                [Validation(Required=false)]
                public List<float?> PositionNormalized { get; set; }

                /// <summary>
                /// <para>The position reference coordinate of the material. Default value: topLeft, which indicates that the position is set based on the upper-left corner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>topLeft</para>
                /// </summary>
                [NameInMap("PositionRefer")]
                [Validation(Required=false)]
                public string PositionRefer { get; set; }

                /// <summary>
                /// <para>The video resource ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>asdfasdfasdfasdfa****</para>
                /// </summary>
                [NameInMap("VideoResourceId")]
                [Validation(Required=false)]
                public string VideoResourceId { get; set; }

                /// <summary>
                /// <para>The normalized width of the material. This is the width ratio of the material to the background. Valid values: <b>0 to 1</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.4</para>
                /// </summary>
                [NameInMap("WidthNormalized")]
                [Validation(Required=false)]
                public float? WidthNormalized { get; set; }

            }

            /// <summary>
            /// <para>The chroma key input configuration.</para>
            /// </summary>
            [NameInMap("ScreenInputConfigList")]
            [Validation(Required=false)]
            public List<DescribeStudioLayoutsResponseBodyStudioLayoutsScreenInputConfigList> ScreenInputConfigList { get; set; }
            public class DescribeStudioLayoutsResponseBodyStudioLayoutsScreenInputConfigList : TeaModel {
                /// <summary>
                /// <para>The audio configuration information.</para>
                /// </summary>
                [NameInMap("AudioConfig")]
                [Validation(Required=false)]
                public DescribeStudioLayoutsResponseBodyStudioLayoutsScreenInputConfigListAudioConfig AudioConfig { get; set; }
                public class DescribeStudioLayoutsResponseBodyStudioLayoutsScreenInputConfigListAudioConfig : TeaModel {
                    /// <summary>
                    /// <para>The corresponding channel.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("ValidChannel")]
                    [Validation(Required=false)]
                    public string ValidChannel { get; set; }

                    /// <summary>
                    /// <para>The volume.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.0</para>
                    /// </summary>
                    [NameInMap("VolumeRate")]
                    [Validation(Required=false)]
                    public float? VolumeRate { get; set; }

                }

                /// <summary>
                /// <para>The channel location ID to which the video resource is bound.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RV01</para>
                /// </summary>
                [NameInMap("ChannelId")]
                [Validation(Required=false)]
                public string ChannelId { get; set; }

                /// <summary>
                /// <para>The chroma key color gamut. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>blue</b>: blue screen background.</description></item>
                /// <item><description><b>green</b>: green screen background.</description></item>
                /// <item><description><b>auto</b>: automatic detection.</description></item>
                /// <item><description><b>complex</b>: real-scene chroma keying.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>green</para>
                /// </summary>
                [NameInMap("Color")]
                [Validation(Required=false)]
                public string Color { get; set; }

                /// <summary>
                /// <para>The normalized height. This is the height ratio of the extracted portrait to the background. Valid values: <b>0 to 1</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.4</para>
                /// </summary>
                [NameInMap("HeightNormalized")]
                [Validation(Required=false)]
                public float? HeightNormalized { get; set; }

                /// <summary>
                /// <para>The unique ID of the chroma key source material.</para>
                /// 
                /// <b>Example:</b>
                /// <para>k12kj31****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The chroma key source number. Used for frontend display only and has no logical function.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Index")]
                [Validation(Required=false)]
                public int? Index { get; set; }

                /// <summary>
                /// <para>Indicates whether only audio is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("OnlyAudio")]
                [Validation(Required=false)]
                public bool? OnlyAudio { get; set; }

                /// <summary>
                /// <para>The portrait type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: half-body.</description></item>
                /// <item><description><b>1</b>: full-body.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PortraitType")]
                [Validation(Required=false)]
                public int? PortraitType { get; set; }

                /// <summary>
                /// <para>The position parameter, x coordinate. Valid values: <b>0 to 1</b>. The material position is based on the upper-left corner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.1</para>
                /// </summary>
                [NameInMap("PositionX")]
                [Validation(Required=false)]
                public string PositionX { get; set; }

                /// <summary>
                /// <para>The position parameter, y coordinate. Valid values: <b>0 to 1</b>. The material position is based on the upper-left corner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.2</para>
                /// </summary>
                [NameInMap("PositionY")]
                [Validation(Required=false)]
                public string PositionY { get; set; }

                /// <summary>
                /// <para>The video resource ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>asdfasdfasdfasdfa****</para>
                /// </summary>
                [NameInMap("VideoResourceId")]
                [Validation(Required=false)]
                public string VideoResourceId { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of layouts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
