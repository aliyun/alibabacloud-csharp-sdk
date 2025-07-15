// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeCasterComponentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The components.</para>
        /// </summary>
        [NameInMap("Components")]
        [Validation(Required=false)]
        public DescribeCasterComponentsResponseBodyComponents Components { get; set; }
        public class DescribeCasterComponentsResponseBodyComponents : TeaModel {
            [NameInMap("Component")]
            [Validation(Required=false)]
            public List<DescribeCasterComponentsResponseBodyComponentsComponent> Component { get; set; }
            public class DescribeCasterComponentsResponseBodyComponentsComponent : TeaModel {
                /// <summary>
                /// <para>The information about the subtitle component.</para>
                /// </summary>
                [NameInMap("CaptionLayerContent")]
                [Validation(Required=false)]
                public DescribeCasterComponentsResponseBodyComponentsComponentCaptionLayerContent CaptionLayerContent { get; set; }
                public class DescribeCasterComponentsResponseBodyComponentsComponentCaptionLayerContent : TeaModel {
                    /// <summary>
                    /// <para>The color of the text border.</para>
                    /// <para>Valid values: <b>0x000000 to 0xffffff</b>. If the value of this parameter is &quot;&quot;, this parameter does not take effect.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0x000000</para>
                    /// </summary>
                    [NameInMap("BorderColor")]
                    [Validation(Required=false)]
                    public string BorderColor { get; set; }

                    /// <summary>
                    /// <para>The normalized value of the width of the text border. The value of this parameter equals the border width divided by the font size.</para>
                    /// <para>The maximum width of the text border is <b>16</b>, even if the border width calculated based on this parameter is greater than <b>16</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("BorderWidthNormalized")]
                    [Validation(Required=false)]
                    public float? BorderWidthNormalized { get; set; }

                    /// <summary>
                    /// <para>The color of the text. Valid values: <b>0x000000 to 0xffffff</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0x000000</para>
                    /// </summary>
                    [NameInMap("Color")]
                    [Validation(Required=false)]
                    public string Color { get; set; }

                    /// <summary>
                    /// <para>The font of the text, which is specified by the system. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>KaiTi</b></description></item>
                    /// <item><description><b>AlibabaPuHuiTi-Regular</b></description></item>
                    /// <item><description><b>AlibabaPuHuiTi-Bold</b></description></item>
                    /// <item><description><b>NAlibabaPuHuiTi-Light</b></description></item>
                    /// <item><description><b>NotoSansHans-Regular</b></description></item>
                    /// <item><description><b>NotoSansHans-Bold</b></description></item>
                    /// <item><description><b>NotoSansHans-Light</b></description></item>
                    /// </list>
                    /// <hr>
                    /// 
                    /// <b>Example:</b>
                    /// <para>KaiTi</para>
                    /// </summary>
                    [NameInMap("FontName")]
                    [Validation(Required=false)]
                    public string FontName { get; set; }

                    /// <summary>
                    /// <para>The line spacing, which indicates the interval between every two lines.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("LineSpaceNormalized")]
                    [Validation(Required=false)]
                    public float? LineSpaceNormalized { get; set; }

                    /// <summary>
                    /// <para>The location ID of the component. If the value of the ComponentType parameter is caption, the LocationId parameter indicates the channel ID of the video source that is referenced by the component.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>RV01</para>
                    /// </summary>
                    [NameInMap("LocationId")]
                    [Validation(Required=false)]
                    public string LocationId { get; set; }

                    /// <summary>
                    /// <para>The offset between the presentation timestamps (PTS) of the subtitles and the audio.</para>
                    /// <para>Valid values: <b>-10000 to 10000</b>. Default value: <b>0</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("PtsOffset")]
                    [Validation(Required=false)]
                    public int? PtsOffset { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the source language of the subtitles is displayed. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b>: The source language is displayed.</description></item>
                    /// <item><description><b>false</b>: The source language is not displayed.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("ShowSourceLan")]
                    [Validation(Required=false)]
                    public bool? ShowSourceLan { get; set; }

                    /// <summary>
                    /// <para>The normalized value of the font size of the subtitles. The value of this parameter equals the font size divided by the output height.``</para>
                    /// <para>The maximum font size of the subtitles is <b>1,024</b>, even if the font size calculated based on this parameter is greater than <b>1,024</b>. If the value of this parameter is <b>-1</b>, this parameter does not take effect.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.1</para>
                    /// </summary>
                    [NameInMap("SizeNormalized")]
                    [Validation(Required=false)]
                    public float? SizeNormalized { get; set; }

                    /// <summary>
                    /// <para>The source language of the audio in the video source. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>en</b>: English</description></item>
                    /// <item><description><b>cn</b>: Chinese</description></item>
                    /// <item><description><b>es</b>: Spanish</description></item>
                    /// <item><description><b>ru</b>: Russian</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn</para>
                    /// </summary>
                    [NameInMap("SourceLan")]
                    [Validation(Required=false)]
                    public string SourceLan { get; set; }

                    /// <summary>
                    /// <para>The target language of the audio in the video source. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>en</b>: English</description></item>
                    /// <item><description><b>cn</b>: Chinese</description></item>
                    /// <item><description><b>es</b>: Spanish</description></item>
                    /// <item><description><b>ru</b>: Russian</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn</para>
                    /// </summary>
                    [NameInMap("TargetLan")]
                    [Validation(Required=false)]
                    public string TargetLan { get; set; }

                    /// <summary>
                    /// <para>The maximum number of words displayed in each line.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>15</para>
                    /// </summary>
                    [NameInMap("WordCountPerLine")]
                    [Validation(Required=false)]
                    public int? WordCountPerLine { get; set; }

                    /// <summary>
                    /// <para>The word spacing, which indicates the interval between every two words.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("WordSpaceNormalized")]
                    [Validation(Required=false)]
                    public float? WordSpaceNormalized { get; set; }

                    /// <summary>
                    /// <para>The number of words displayed on the component. The value of this parameter can be specified based on the font size.</para>
                    /// <para>Valid values: <b>10 to 50</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>35</para>
                    /// </summary>
                    [NameInMap("WordsCount")]
                    [Validation(Required=false)]
                    public int? WordsCount { get; set; }

                }

                /// <summary>
                /// <para>The component ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>72d2ec7a-4cd7-4a01-974b-7cd53947****</para>
                /// </summary>
                [NameInMap("ComponentId")]
                [Validation(Required=false)]
                public string ComponentId { get; set; }

                /// <summary>
                /// <para>The information about the component layer, such as the size and layout.</para>
                /// </summary>
                [NameInMap("ComponentLayer")]
                [Validation(Required=false)]
                public DescribeCasterComponentsResponseBodyComponentsComponentComponentLayer ComponentLayer { get; set; }
                public class DescribeCasterComponentsResponseBodyComponentsComponentComponentLayer : TeaModel {
                    /// <summary>
                    /// <para>The normalized value for heights of the elements in the layer. The widths of the elements are proportionally scaled based on this parameter.</para>
                    /// <para>If the value of this parameter is <b>0</b>, the elements in the layer are not scaled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.5</para>
                    /// </summary>
                    [NameInMap("HeightNormalized")]
                    [Validation(Required=false)]
                    public float? HeightNormalized { get; set; }

                    /// <summary>
                    /// <para>The normalized value of the position of the layer, in the format of <c>[x,y]</c>. Example: <c>[0,0]</c>.</para>
                    /// <remarks>
                    /// <para> The values of x and y need to be normalized.</para>
                    /// </remarks>
                    /// </summary>
                    [NameInMap("PositionNormalizeds")]
                    [Validation(Required=false)]
                    public DescribeCasterComponentsResponseBodyComponentsComponentComponentLayerPositionNormalizeds PositionNormalizeds { get; set; }
                    public class DescribeCasterComponentsResponseBodyComponentsComponentComponentLayerPositionNormalizeds : TeaModel {
                        [NameInMap("Position")]
                        [Validation(Required=false)]
                        public List<float?> Position { get; set; }

                    }

                    /// <summary>
                    /// <para>The reference coordinates of the layer. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>topLeft</b>: the upper-left corner</description></item>
                    /// <item><description><b>topRight</b>: the upper-right corner</description></item>
                    /// <item><description><b>bottomLeft</b>: the lower-left corner</description></item>
                    /// <item><description><b>bottomRight</b>: the lower-right corner</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>topLeft</para>
                    /// </summary>
                    [NameInMap("PositionRefer")]
                    [Validation(Required=false)]
                    public string PositionRefer { get; set; }

                    /// <summary>
                    /// <para>The transparency of the layer. Valid values: 0 to 255.</para>
                    /// <para>A value of <b>0</b> indicates that the layer is completely transparent. A value of <b>255</b> indicates that the layer is completely opaque.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("Transparency")]
                    [Validation(Required=false)]
                    public int? Transparency { get; set; }

                    /// <summary>
                    /// <para>The normalized value for widths of the elements in the layer. The heights of the elements are proportionally scaled based on this parameter. If the value of this parameter is <b>0</b>, the elements in the layer are not scaled.</para>
                    /// <remarks>
                    /// <para> This parameter conflicts with the HeightNormalized parameter. If both of them are specified, only the HeightNormalized parameter takes effect. If only one of them is specified, the latest specified value is used.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.5</para>
                    /// </summary>
                    [NameInMap("WidthNormalized")]
                    [Validation(Required=false)]
                    public float? WidthNormalized { get; set; }

                }

                /// <summary>
                /// <para>The name of the component. By default, the name is the ID of the component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>component_name</para>
                /// </summary>
                [NameInMap("ComponentName")]
                [Validation(Required=false)]
                public string ComponentName { get; set; }

                /// <summary>
                /// <para>The type of the component. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>text</b>: a text component</description></item>
                /// <item><description><b>image</b>: an image component</description></item>
                /// <item><description><b>caption</b>: a caption component</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("ComponentType")]
                [Validation(Required=false)]
                public string ComponentType { get; set; }

                /// <summary>
                /// <para>The display effect for the component. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>none</b></description></item>
                /// <item><description><b>animateH</b>: horizontal scrolling</description></item>
                /// <item><description><b>animateV</b>: vertical scrolling</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>animateV</para>
                /// </summary>
                [NameInMap("Effect")]
                [Validation(Required=false)]
                public string Effect { get; set; }

                /// <summary>
                /// <para>The information about the image component. This parameter is returned only for image components.</para>
                /// </summary>
                [NameInMap("ImageLayerContent")]
                [Validation(Required=false)]
                public DescribeCasterComponentsResponseBodyComponentsComponentImageLayerContent ImageLayerContent { get; set; }
                public class DescribeCasterComponentsResponseBodyComponentsComponentImageLayerContent : TeaModel {
                    /// <summary>
                    /// <para>The ID of the material from the media library.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>6cf724c6ebfd4a59b5b3cec6f10d****</para>
                    /// </summary>
                    [NameInMap("MaterialId")]
                    [Validation(Required=false)]
                    public string MaterialId { get; set; }

                }

                /// <summary>
                /// <para>The location ID of the component.</para>
                /// <para>Each location ID can be assigned to only one component and must be in the RC[Number] format. The values of this parameter are in ascending order, for example, from RC01 to RC12.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RC01</para>
                /// </summary>
                [NameInMap("LocationId")]
                [Validation(Required=false)]
                public string LocationId { get; set; }

                /// <summary>
                /// <para>The information about the text component. This parameter is returned only for text components.</para>
                /// </summary>
                [NameInMap("TextLayerContent")]
                [Validation(Required=false)]
                public DescribeCasterComponentsResponseBodyComponentsComponentTextLayerContent TextLayerContent { get; set; }
                public class DescribeCasterComponentsResponseBodyComponentsComponentTextLayerContent : TeaModel {
                    /// <summary>
                    /// <para>The color of the text border. Valid values: <b>0x000000 to 0xffffff</b>. If the value of this parameter is <b>&quot;&quot;</b>, this parameter does not take effect.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0x000000</para>
                    /// </summary>
                    [NameInMap("BorderColor")]
                    [Validation(Required=false)]
                    public string BorderColor { get; set; }

                    /// <summary>
                    /// <para>The normalized value of the width of the text border. The value of this parameter equals the border width divided by the font size.****</para>
                    /// <para>The maximum width of the text border is <b>16</b>, even if the border width calculated based on this parameter is greater than <b>16</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("BorderWidthNormalized")]
                    [Validation(Required=false)]
                    public float? BorderWidthNormalized { get; set; }

                    /// <summary>
                    /// <para>The color of the text. Valid values: <b>0x000000 to 0xffffff</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0xff0000</para>
                    /// </summary>
                    [NameInMap("Color")]
                    [Validation(Required=false)]
                    public string Color { get; set; }

                    /// <summary>
                    /// <para>The font of the text, which is specified by the system. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>KaiTi</b></description></item>
                    /// <item><description><b>AlibabaPuHuiTi-Regular</b></description></item>
                    /// <item><description><b>AlibabaPuHuiTi-Bold</b></description></item>
                    /// <item><description><b>NAlibabaPuHuiTi-Light</b></description></item>
                    /// <item><description><b>NotoSansHans-Regular</b></description></item>
                    /// <item><description><b>NotoSansHans-Bold</b></description></item>
                    /// <item><description><b>NotoSansHans-Light</b></description></item>
                    /// </list>
                    /// <hr>
                    /// 
                    /// <b>Example:</b>
                    /// <para>KaiTi</para>
                    /// </summary>
                    [NameInMap("FontName")]
                    [Validation(Required=false)]
                    public string FontName { get; set; }

                    /// <summary>
                    /// <para>The normalized value of the font size of the text.</para>
                    /// <para>The value of this parameter equals the font size divided by the output height.**** The maximum font size of the text is <b>1,024</b>, even if the font size calculated based on this parameter is greater than <b>1,024</b>. If the value of this parameter is <b>-1</b>, this parameter does not take effect.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>16</para>
                    /// </summary>
                    [NameInMap("SizeNormalized")]
                    [Validation(Required=false)]
                    public float? SizeNormalized { get; set; }

                    /// <summary>
                    /// <para>The content of the text.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>hello world</para>
                    /// </summary>
                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3be7ade8-d907-483c-b24a-0dad45******</para>
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
