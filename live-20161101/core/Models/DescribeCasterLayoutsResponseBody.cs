// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeCasterLayoutsResponseBody : TeaModel {
        /// <summary>
        /// <para>The layouts.</para>
        /// </summary>
        [NameInMap("Layouts")]
        [Validation(Required=false)]
        public DescribeCasterLayoutsResponseBodyLayouts Layouts { get; set; }
        public class DescribeCasterLayoutsResponseBodyLayouts : TeaModel {
            [NameInMap("Layout")]
            [Validation(Required=false)]
            public List<DescribeCasterLayoutsResponseBodyLayoutsLayout> Layout { get; set; }
            public class DescribeCasterLayoutsResponseBodyLayoutsLayout : TeaModel {
                /// <summary>
                /// <para>The configurations of the audio layers.</para>
                /// </summary>
                [NameInMap("AudioLayers")]
                [Validation(Required=false)]
                public DescribeCasterLayoutsResponseBodyLayoutsLayoutAudioLayers AudioLayers { get; set; }
                public class DescribeCasterLayoutsResponseBodyLayoutsLayoutAudioLayers : TeaModel {
                    [NameInMap("AudioLayer")]
                    [Validation(Required=false)]
                    public List<DescribeCasterLayoutsResponseBodyLayoutsLayoutAudioLayersAudioLayer> AudioLayer { get; set; }
                    public class DescribeCasterLayoutsResponseBodyLayoutsLayoutAudioLayersAudioLayer : TeaModel {
                        /// <summary>
                        /// <para>The fixed delay of the audio layer. This parameter is used to synchronize the audio with subtitles.</para>
                        /// <para>Unit: milliseconds. Default value: <b>0</b>. Valid values: <b>0 to 5000</b>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>20</para>
                        /// </summary>
                        [NameInMap("FixedDelayDuration")]
                        [Validation(Required=false)]
                        public int? FixedDelayDuration { get; set; }

                        /// <summary>
                        /// <para>The sound channels that are used for volume input in the audio layer. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>leftChannel</b>: the left channel</description></item>
                        /// <item><description><b>rightChannel</b>: the right channel</description></item>
                        /// <item><description><b>all</b> (default): both the left and right channels</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>all</para>
                        /// </summary>
                        [NameInMap("ValidChannel")]
                        [Validation(Required=false)]
                        public string ValidChannel { get; set; }

                        /// <summary>
                        /// <para>The normalized value of the height of the audio layer. The width of the audio layer is proportionally scaled based on this parameter.</para>
                        /// <remarks>
                        /// <para> The default value is <b>0</b>, which indicates that the audio layer is not scaled.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("VolumeRate")]
                        [Validation(Required=false)]
                        public float? VolumeRate { get; set; }

                    }

                }

                /// <summary>
                /// <para>The location IDs of the video layers, which are in the same order as the video layers.</para>
                /// </summary>
                [NameInMap("BlendList")]
                [Validation(Required=false)]
                public DescribeCasterLayoutsResponseBodyLayoutsLayoutBlendList BlendList { get; set; }
                public class DescribeCasterLayoutsResponseBodyLayoutsLayoutBlendList : TeaModel {
                    [NameInMap("LocationId")]
                    [Validation(Required=false)]
                    public List<string> LocationId { get; set; }

                }

                /// <summary>
                /// <para>The ID of the layout.</para>
                /// 
                /// <b>Example:</b>
                /// <para>72d2ec7a-4cd7-4a01-974b-7cd53947****</para>
                /// </summary>
                [NameInMap("LayoutId")]
                [Validation(Required=false)]
                public string LayoutId { get; set; }

                /// <summary>
                /// <para>The location IDs of the audio layers, which are in the same order as the audio layers.</para>
                /// </summary>
                [NameInMap("MixList")]
                [Validation(Required=false)]
                public DescribeCasterLayoutsResponseBodyLayoutsLayoutMixList MixList { get; set; }
                public class DescribeCasterLayoutsResponseBodyLayoutsLayoutMixList : TeaModel {
                    [NameInMap("LocationId")]
                    [Validation(Required=false)]
                    public List<string> LocationId { get; set; }

                }

                /// <summary>
                /// <para>The configurations of the video layers, which are in the default array sequence.</para>
                /// </summary>
                [NameInMap("VideoLayers")]
                [Validation(Required=false)]
                public DescribeCasterLayoutsResponseBodyLayoutsLayoutVideoLayers VideoLayers { get; set; }
                public class DescribeCasterLayoutsResponseBodyLayoutsLayoutVideoLayers : TeaModel {
                    [NameInMap("VideoLayer")]
                    [Validation(Required=false)]
                    public List<DescribeCasterLayoutsResponseBodyLayoutsLayoutVideoLayersVideoLayer> VideoLayer { get; set; }
                    public class DescribeCasterLayoutsResponseBodyLayoutsLayoutVideoLayersVideoLayer : TeaModel {
                        /// <summary>
                        /// <para>The scaling mode of the video layer. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>none</b> (default): specifies that the video layer is not scaled. The video layer is displayed based on its original size.</description></item>
                        /// <item><description><b>fit</b>: specifies that the video layer is adapted to the fill area. The video layer is displayed based on the fill area. In this case, the video layer is scaled proportionally, with its original aspect ratio retained. The video layer is placed in the center, with its longer sides aligned with the fill area. If the aspect ratio of the video layer is different from that of the fill area, the content of the lower layer is displayed alongside the shorter sides. If there is no lower layer, black bars are displayed instead.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>fit</para>
                        /// </summary>
                        [NameInMap("FillMode")]
                        [Validation(Required=false)]
                        public string FillMode { get; set; }

                        /// <summary>
                        /// <para>The fixed delay of the video layer. This parameter is used to synchronize the video with subtitles.</para>
                        /// <para>Unit: milliseconds. Default value: <b>0</b>. Valid values: <b>0 to 5000</b>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>20</para>
                        /// </summary>
                        [NameInMap("FixedDelayDuration")]
                        [Validation(Required=false)]
                        public int? FixedDelayDuration { get; set; }

                        /// <summary>
                        /// <para>The normalized value of the height of the video layer.</para>
                        /// <list type="bullet">
                        /// <item><description>If the FillMode parameter of the video layer is set to none, the width of the video layer is proportionally scaled based on this parameter. The default value is <b>0</b>, which indicates that the video layer is not scaled.</description></item>
                        /// <item><description>If the FillMode parameter of the video layer is set to fit, the value of this parameter is greater than <b>0</b>.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.5</para>
                        /// </summary>
                        [NameInMap("HeightNormalized")]
                        [Validation(Required=false)]
                        public float? HeightNormalized { get; set; }

                        /// <summary>
                        /// <para>The normalized value of the position of the video layer, in the format of <c>[x,y]</c>. Default value: <c>[0,0]</c>.</para>
                        /// <remarks>
                        /// <para> The values of x and y are normalized.</para>
                        /// </remarks>
                        /// </summary>
                        [NameInMap("PositionNormalizeds")]
                        [Validation(Required=false)]
                        public DescribeCasterLayoutsResponseBodyLayoutsLayoutVideoLayersVideoLayerPositionNormalizeds PositionNormalizeds { get; set; }
                        public class DescribeCasterLayoutsResponseBodyLayoutsLayoutVideoLayersVideoLayerPositionNormalizeds : TeaModel {
                            [NameInMap("Position")]
                            [Validation(Required=false)]
                            public List<float?> Position { get; set; }

                        }

                        /// <summary>
                        /// <para>The reference coordinates of the video layer. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>topLeft</b> (default): the upper-left corner</description></item>
                        /// <item><description><b>topRight</b>: the upper-right corner</description></item>
                        /// <item><description><b>bottomLeft</b>: the lower-left corner</description></item>
                        /// <item><description><b>bottomRight</b>: the lower-right corner</description></item>
                        /// <item><description><b>center</b>: the center</description></item>
                        /// <item><description><b>topCenter</b>: the upper center</description></item>
                        /// <item><description><b>bottomCenter</b>: the lower center</description></item>
                        /// <item><description><b>leftCenter</b>: the left center</description></item>
                        /// <item><description><b>rightCenter</b>: the right center</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>topLeft</para>
                        /// </summary>
                        [NameInMap("PositionRefer")]
                        [Validation(Required=false)]
                        public string PositionRefer { get; set; }

                        /// <summary>
                        /// <para>The normalized value of the width of the video layer.</para>
                        /// <list type="bullet">
                        /// <item><description>If the FillMode parameter of the video layer is set to none, the height of the video layer is scaled based on this parameter. The default value is <b>0</b>, which indicates that the video layer is not scaled.</description></item>
                        /// <item><description>If the FillMode parameter of the video layer is set to fit, the value of this parameter is greater than <b>0</b>.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.5</para>
                        /// </summary>
                        [NameInMap("WidthNormalized")]
                        [Validation(Required=false)]
                        public float? WidthNormalized { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The normalized value of the width of the video layer image.</para>
        /// <list type="bullet">
        /// <item><description>If the FillMode parameter of the video layer is set to none, the height of the video image is scaled based on this parameter. The default value is <b>0</b>, which indicates that the video image is displayed in the original size.</description></item>
        /// <item><description>If the FillMode parameter of the video layer is set to fit, the value of the parameter is greater than <b>0</b>.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
