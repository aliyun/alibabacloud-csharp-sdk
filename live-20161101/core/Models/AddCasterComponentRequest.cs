// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddCasterComponentRequest : TeaModel {
        /// <summary>
        /// <para>The information about the caption layer. This parameter contains the following fields:</para>
        /// <remarks>
        /// <para> This parameter is required when the ComponentType parameter is set to caption.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>SizeNormalized</b>: the normalized font size. The font size is set to font_size/output_height. The value range is <c>[0,1]</c> and accurate to two decimal places. If the font size calculated by the system based on the normalization method is greater than <b>1024</b>, <b>1024</b> is used.</description></item>
        /// <item><description><b>BorderWidthNormalized</b>: the normalized value of the text border width, which is calculated based on the size of the text, namely &quot;BorderWidth/FontSize&quot;. The value range is <c>[0,1]</c> and accurate to two decimal places. If the value calculated according to the normalization method exceeds <b>16</b>, <b>16</b> is used. The default value is <b>0</b>.</description></item>
        /// <item><description><b>FontName</b>: the font name. For more information about the value, see <b>Font description</b>. The default font name is KaiTi.</description></item>
        /// <item><description><b>BorderColor</b>: the color of the text border. Valid values: 0x000000 to 0xffffff. By default, this parameter is not set. In this case, the color of the text border is transparent.</description></item>
        /// <item><description><b>LocationId</b>: the channel ID of the source subtitle.</description></item>
        /// <item><description><b>SourceLan</b>: the source language of the audio in the source video. Valid values: en, cn, es, and ru, which indicate English, Chinese, Spanish, and Russian respectively. Default value: cn.</description></item>
        /// <item><description><b>TargetLan</b>: the target audio language in the source video. If you do not specify this field, speech recognition is used. If you specify this field, translation is used. Valid values: en, cn, es, and ru, which indicate English, Chinese, Spanish, and Russian respectively. Default value: cn.</description></item>
        /// <item><description><b>ShowSourceLan</b>: specifies whether to display the source language. Valid values: true: displays the source language. false: hides the source language. Default value: false.</description></item>
        /// <item><description><b>Truncation</b>: specifies whether to allow caption truncation. Valid values: true: specifies that the caption can be truncated. false: specifies that the caption cannot be truncated. Default value: false.</description></item>
        /// <item><description><b>SourceLanPerLineWordCount</b>: the number of words displayed in each line when the subtitle is in the source language. Default value: 20.</description></item>
        /// <item><description><b>TargetLanPerLineWordCount</b>: the number of words displayed in each line when the subtitle is in the destination language. Default value: 20.</description></item>
        /// <item><description><b>SourceLanReservePages</b>: the number of lines reserved when the subtitle is in the source language. This field takes effect only when the Truncation field is set to true. Default value: 2.</description></item>
        /// <item><description><b>TargetLanReservePages</b>: the number of lines reserved when the subtitle is in the destination language. This field takes effect only when the Truncation field is set to true. Default value: 2.</description></item>
        /// </list>
        /// <para>The value is a JSON string. Use upper camel case for field names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;BorderWidthNormalized&quot;:0.01,&quot;SizeNormalized&quot;:0.05,&quot;Color&quot;:&quot;0x000000&quot;,&quot;LocationId&quot;:&quot;RV01&quot;,&quot;SourceLan&quot;:&quot;cn&quot;,&quot;FontName&quot;:&quot;KaiTi&quot;,&quot;BorderColor&quot;:&quot;0xffffff&quot;}</para>
        /// </summary>
        [NameInMap("CaptionLayerContent")]
        [Validation(Required=false)]
        public string CaptionLayerContent { get; set; }

        /// <summary>
        /// <para>The ID of the production studio.</para>
        /// <list type="bullet">
        /// <item><description>If the production studio was created by calling the <a href="https://help.aliyun.com/document_detail/2848009.html">CreateCaster</a> operation, check the value of the response parameter CasterId to obtain the ID.</description></item>
        /// <item><description>If the production studio was created by using the ApsaraVideo Live console, obtain the ID on the <b>Production Studio Management</b> page. To go to the page, log on to the <b>ApsaraVideo Live console</b> and click <b>Production Studios</b> in the left-side navigation pane.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You can find the ID of the production studio in the Instance ID/Name column.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LIVEPRODUCER_POST-cn-0pp1czt****</para>
        /// </summary>
        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        /// <summary>
        /// <para>The information about the component layer, such as the size and layout. This parameter contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>HeightNormalized</b>: the normalized value of heights for the elements in the component layer</description></item>
        /// <item><description><b>WidthNormalized</b>: the normalized value of widths for the elements in the component layer</description></item>
        /// <item><description><b>PositionNormalized</b>: the normalized value of the coordinates of the component layer</description></item>
        /// <item><description><b>PositionRefer</b>: the reference coordinates of the component layer.</description></item>
        /// </list>
        /// <para>The value is a JSON string. Use upper camel case for field names.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;HeightNormalized&quot;:&quot;1&quot;,&quot;PositionRefer&quot;:&quot;topRight&quot;,&quot;WidthNormalized&quot;:&quot;0&quot;,&quot;PositionNormalized&quot;:[&quot;0.1&quot;,&quot;0.2&quot;]}</para>
        /// </summary>
        [NameInMap("ComponentLayer")]
        [Validation(Required=false)]
        public string ComponentLayer { get; set; }

        /// <summary>
        /// <para>The component name. By default, the component name is the component ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text01</para>
        /// </summary>
        [NameInMap("ComponentName")]
        [Validation(Required=false)]
        public string ComponentName { get; set; }

        /// <summary>
        /// <para>The component type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>text</b>: a text component. If you set ComponentType to text, you must also specify TextLayerContent.</description></item>
        /// <item><description><b>image</b>: an image component. If you set ComponentType to image, you must also specify ImageLayerContent.</description></item>
        /// <item><description><b>caption</b>: a caption component. If you set ComponentType to caption, you must also specify CaptionLayerContent.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("ComponentType")]
        [Validation(Required=false)]
        public string ComponentType { get; set; }

        /// <summary>
        /// <para>The effect of the component. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>none (default)</b></description></item>
        /// <item><description><b>animateH</b>: horizontal scrolling</description></item>
        /// <item><description><b>animateV</b>: vertical scrolling</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>animateH</para>
        /// </summary>
        [NameInMap("Effect")]
        [Validation(Required=false)]
        public string Effect { get; set; }

        /// <summary>
        /// <para>The information about the HTML5 layer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;htmlUrl&quot;:<a href="http://caster.example.com%7D">http://caster.example.com}</a></para>
        /// </summary>
        [NameInMap("HtmlLayerContent")]
        [Validation(Required=false)]
        public string HtmlLayerContent { get; set; }

        /// <summary>
        /// <para>The information about the image layer. This parameter contains the following fields:</para>
        /// <remarks>
        /// <para> This parameter is required when the ComponentType parameter is set to image.</para>
        /// </remarks>
        /// <para>MaterialId: the ID of the asset from the media asset library. The name that you set when you upload an asset is the ID of the asset.</para>
        /// <para>The value is a JSON string. Use upper camel case for field names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;MaterialId&quot;:&quot;6cf724c6ebfd4a59b5b3cec6f10d****&quot;}</para>
        /// </summary>
        [NameInMap("ImageLayerContent")]
        [Validation(Required=false)]
        public string ImageLayerContent { get; set; }

        /// <summary>
        /// <para>The layer stacking order of the component. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cover</description></item>
        /// <item><description>background</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cover</para>
        /// </summary>
        [NameInMap("LayerOrder")]
        [Validation(Required=false)]
        public string LayerOrder { get; set; }

        /// <summary>
        /// <para>The location ID of the component. Each location ID can be assigned to only one component and must be in the RC[Number] format. The values specified by this parameter must be in ascending order, such as RC01 to RC99.</para>
        /// <remarks>
        /// <para> If the ComponentType parameter is set to caption, the LocationId parameter specifies the location ID of the video source referenced by the component.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RC01</para>
        /// </summary>
        [NameInMap("LocationId")]
        [Validation(Required=false)]
        public string LocationId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The information about the text layer. This parameter contains the following fields:</para>
        /// <remarks>
        /// <para> This parameter is available and required only when the ComponentType parameter is set to text.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>SizeNormalized</b>: the normalized font size. The font size is set to font_size/output_height. The value range is <c>[0,1]</c>. If the font size calculated by the system based on the normalization method is greater than 1024, 1024 is used.</description></item>
        /// <item><description><b>BorderWidthNormalized</b>: the normalized value of the text border width. The normalized value is calculated based on the size of the text, that is, &quot;BorderWidth/FontSize&quot;. The value range is <c>[0,1]</c>. If the value calculated based on the normalization method exceeds 16, 16 is used. The default value is 0.</description></item>
        /// <item><description><b>FontName</b>: the font name. For more information about the value, see <b>Font description</b>. The default value is KaiTi.</description></item>
        /// <item><description><b>BorderColor</b>: the color of the text border. Valid values: 0x000000 to 0xffffff. By default, this parameter is not set. In this case, the color of the text border is transparent.</description></item>
        /// <item><description><b>Text</b>: the content of the text. By default, this parameter is not set. In this case, the text contains no content.</description></item>
        /// <item><description><b>Color</b>: the color of the text. The default value is 0xff0000, which indicates that the text is in red.</description></item>
        /// </list>
        /// <para>The value is a JSON string. Use upper camel case for field names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;BorderWidthNormalized&quot;:&quot;1&quot;,&quot;SizeNormalized&quot;:&quot;0.2&quot;,&quot;Color&quot;:&quot;0x000000&quot;,&quot;FontName&quot;:&quot;KaiTi&quot;,&quot;BorderColor&quot;:&quot;0x000000&quot;,&quot;Text&quot;:&quot;hello world!&quot;}</para>
        /// </summary>
        [NameInMap("TextLayerContent")]
        [Validation(Required=false)]
        public string TextLayerContent { get; set; }

    }

}
