// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeStudioLayoutsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
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
            /// <para>The background material configurations.</para>
            /// </summary>
            [NameInMap("BgImageConfig")]
            [Validation(Required=false)]
            public DescribeStudioLayoutsResponseBodyStudioLayoutsBgImageConfig BgImageConfig { get; set; }
            public class DescribeStudioLayoutsResponseBodyStudioLayoutsBgImageConfig : TeaModel {
                /// <summary>
                /// <para>The unique ID of the material.</para>
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
                /// <para>The position ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RV01</para>
                /// </summary>
                [NameInMap("LocationId")]
                [Validation(Required=false)]
                public string LocationId { get; set; }

                /// <summary>
                /// <para>The ID of the material in ApsaraVideo VOD.</para>
                /// 
                /// <b>Example:</b>
                /// <para>asdfas9df89asd8f9****</para>
                /// </summary>
                [NameInMap("MaterialId")]
                [Validation(Required=false)]
                public string MaterialId { get; set; }

            }

            /// <summary>
            /// <para>The common layout configurations. This parameter is returned only for a common layout.</para>
            /// </summary>
            [NameInMap("CommonConfig")]
            [Validation(Required=false)]
            public DescribeStudioLayoutsResponseBodyStudioLayoutsCommonConfig CommonConfig { get; set; }
            public class DescribeStudioLayoutsResponseBodyStudioLayoutsCommonConfig : TeaModel {
                /// <summary>
                /// <para>The ID of the channel that is bound to the video resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RV01</para>
                /// </summary>
                [NameInMap("ChannelId")]
                [Validation(Required=false)]
                public string ChannelId { get; set; }

                /// <summary>
                /// <para>The ID of the video resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>asdfasdfasdfasdfa****</para>
                /// </summary>
                [NameInMap("VideoResourceId")]
                [Validation(Required=false)]
                public string VideoResourceId { get; set; }

            }

            /// <summary>
            /// <para>The layer sorting configurations.</para>
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
                /// <para>The type of the resource. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>background</b>: background material</description></item>
                /// <item><description><b>media</b>: multimedia material</description></item>
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
            /// <para>The ID of the layout.</para>
            /// 
            /// <b>Example:</b>
            /// <para>445409ec-7eaa-461d-8f29-4bec2eb9****</para>
            /// </summary>
            [NameInMap("LayoutId")]
            [Validation(Required=false)]
            public string LayoutId { get; set; }

            /// <summary>
            /// <para>The name of the layout.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试布局</para>
            /// </summary>
            [NameInMap("LayoutName")]
            [Validation(Required=false)]
            public string LayoutName { get; set; }

            /// <summary>
            /// <para>The type of the layout. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>common</b></description></item>
            /// <item><description><b>studio</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>studio</para>
            /// </summary>
            [NameInMap("LayoutType")]
            [Validation(Required=false)]
            public string LayoutType { get; set; }

            /// <summary>
            /// <para>The multimedia input configurations.</para>
            /// </summary>
            [NameInMap("MediaInputConfigList")]
            [Validation(Required=false)]
            public List<DescribeStudioLayoutsResponseBodyStudioLayoutsMediaInputConfigList> MediaInputConfigList { get; set; }
            public class DescribeStudioLayoutsResponseBodyStudioLayoutsMediaInputConfigList : TeaModel {
                /// <summary>
                /// <para>The ID of the channel that is bound to the video resource.</para>
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
                /// <para>The normalized value of the material height. The value indicates the ratio of the material height to the height of the background. Valid values: <b>0 to 1</b>.</para>
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
                /// <para>The ID of the image in ApsaraVideo VOD.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lkajsdfsa8fd89asd8****</para>
                /// </summary>
                [NameInMap("ImageMaterialId")]
                [Validation(Required=false)]
                public string ImageMaterialId { get; set; }

                /// <summary>
                /// <para>The sequence number of the multimedia material. This parameter is displayed on the frontend but not used in the operation logic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Index")]
                [Validation(Required=false)]
                public int? Index { get; set; }

                /// <summary>
                /// <para>The normalized value of the position of the material, in the format of [unk][x,y][unk]. Valid values of x and y: <b>0 to 1</b>. For example, [unk][0.1,0.2][unk] indicates that the material is horizontally offset by 10% and vertically offset by 20% towards the upper-left corner.</para>
                /// </summary>
                [NameInMap("PositionNormalized")]
                [Validation(Required=false)]
                public List<float?> PositionNormalized { get; set; }

                /// <summary>
                /// <para>The coordinate origin for the material. Default value: topLeft. topLeft indicates that the upper-left corner is used as the coordinate origin.</para>
                /// 
                /// <b>Example:</b>
                /// <para>topLeft</para>
                /// </summary>
                [NameInMap("PositionRefer")]
                [Validation(Required=false)]
                public string PositionRefer { get; set; }

                /// <summary>
                /// <para>The ID of the video resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>asdfasdfasdfasdfa****</para>
                /// </summary>
                [NameInMap("VideoResourceId")]
                [Validation(Required=false)]
                public string VideoResourceId { get; set; }

                /// <summary>
                /// <para>The normalized value of the material width. The value indicates the ratio of the material width to the width of the background. Valid values: <b>0 to 1</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.4</para>
                /// </summary>
                [NameInMap("WidthNormalized")]
                [Validation(Required=false)]
                public float? WidthNormalized { get; set; }

            }

            /// <summary>
            /// <para>The input configurations for chroma key.</para>
            /// </summary>
            [NameInMap("ScreenInputConfigList")]
            [Validation(Required=false)]
            public List<DescribeStudioLayoutsResponseBodyStudioLayoutsScreenInputConfigList> ScreenInputConfigList { get; set; }
            public class DescribeStudioLayoutsResponseBodyStudioLayoutsScreenInputConfigList : TeaModel {
                /// <summary>
                /// <para>The audio configurations.</para>
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
                /// <para>The ID of the channel that is bound to the video resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RV01</para>
                /// </summary>
                [NameInMap("ChannelId")]
                [Validation(Required=false)]
                public string ChannelId { get; set; }

                /// <summary>
                /// <para>The color gamut for chroma key. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>blue</b></description></item>
                /// <item><description><b>green</b></description></item>
                /// <item><description><b>auto</b>: automatic recognition</description></item>
                /// <item><description><b>complex</b>: background replacement</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>green</para>
                /// </summary>
                [NameInMap("Color")]
                [Validation(Required=false)]
                public string Color { get; set; }

                /// <summary>
                /// <para>The normalized value of the height. The value indicates the ratio of the height of the keyed portrait to the height of the background. Valid values: <b>0 to 1</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.4</para>
                /// </summary>
                [NameInMap("HeightNormalized")]
                [Validation(Required=false)]
                public float? HeightNormalized { get; set; }

                /// <summary>
                /// <para>The unique ID of the chroma key source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>k12kj31****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The sequence number of the chroma key source. This parameter is displayed on the frontend but not used in the operation logic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Index")]
                [Validation(Required=false)]
                public int? Index { get; set; }

                /// <summary>
                /// <para>Indicates whether only audio exists.</para>
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
                /// <item><description><b>0</b>: half body</description></item>
                /// <item><description><b>1</b>: full body</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PortraitType")]
                [Validation(Required=false)]
                public int? PortraitType { get; set; }

                /// <summary>
                /// <para>The x-coordinate of the material. Valid values: <b>0 to 1</b>. The upper-left corner is used as the coordinate origin for the material.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.1</para>
                /// </summary>
                [NameInMap("PositionX")]
                [Validation(Required=false)]
                public string PositionX { get; set; }

                /// <summary>
                /// <para>The y-coordinate of the material. Valid values: <b>0 to 1</b>. The upper-left corner is used as the coordinate origin for the material.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.2</para>
                /// </summary>
                [NameInMap("PositionY")]
                [Validation(Required=false)]
                public string PositionY { get; set; }

                /// <summary>
                /// <para>The ID of the video resource.</para>
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
        /// <para>The total number of layouts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
