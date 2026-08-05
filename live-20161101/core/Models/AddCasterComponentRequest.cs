// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddCasterComponentRequest : TeaModel {
        /// <summary>
        /// <para>The properties of the layer element. The properties are described as follows:</para>
        /// <remarks>
        /// <para>Notice: This parameter is required when ComponentType is set to caption.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para><b>SizeNormalized</b>: The normalized font size. This value is calculated as font size / output height. The value must be in the <c>[0,1]</c> range and accurate to two decimal places. If the font size calculated from the normalized value is greater than <b>1024</b>, the font size is set to <b>1024</b>.</para>
        /// </description></item>
        /// <item><description><para><b>BorderWidthNormalized</b>: The normalized width of the text border. This value is calculated based on the font size: BorderWidth / FontSize. The value must be in the <c>[0,1]</c> range and accurate to two decimal places. If the width calculated from the normalized value is greater than <b>16</b>, the width is set to <b>16</b>. The default value is <b>0</b>.</para>
        /// </description></item>
        /// <item><description><para><b>FontName</b>: The font name. For valid values, see <b>Production studio fonts</b>. The default font is KaiTi.</para>
        /// </description></item>
        /// <item><description><para><b>BorderColor</b>: The color of the text border. The value must be a hexadecimal color code that ranges from 0x000000 to 0xffffff. The default value is an empty string (&quot;&quot;), which indicates that no border color is set.</para>
        /// </description></item>
        /// <item><description><para><b>LocationId</b>: The channel ID of the translation source.</para>
        /// </description></item>
        /// <item><description><para><b>SourceLan</b>: The original audio language of the video source. Valid values: en (English), cn (Chinese), es (Spanish), and ru (Russian). The default value is cn.</para>
        /// </description></item>
        /// <item><description><para><b>TargetLan</b>: The target audio language for the video source. If you do not set this parameter, only speech recognition is performed. If you set this parameter, the audio is translated. Valid values: en (English), cn (Chinese), es (Spanish), and ru (Russian).</para>
        /// </description></item>
        /// <item><description><para><b>ShowSourceLan</b>: Specifies whether to display the source language. Valid values: true and false. The default value is false.</para>
        /// </description></item>
        /// <item><description><para><b>Truncation</b>: Specifies whether captions can be truncated. Valid values: true and false. The default value is false.</para>
        /// </description></item>
        /// <item><description><para><b>SourceLanPerLineWordCount</b>: The maximum number of words per line for the source language captions. The default value is 20.</para>
        /// </description></item>
        /// <item><description><para><b>TargetLanPerLineWordCount</b>: The maximum number of words per line for the target language captions. The default value is 20.</para>
        /// </description></item>
        /// <item><description><para><b>SourceLanReservePages</b>: The number of lines to reserve for the source language captions. This parameter takes effect only when Truncation is set to true. The default value is 2.</para>
        /// </description></item>
        /// <item><description><para><b>TargetLanReservePages</b>: The number of lines to reserve for the target language captions. This parameter takes effect only when Truncation is set to true. The default value is 2.</para>
        /// </description></item>
        /// </list>
        /// <para>The value must be a JSON-formatted string. Parameter names must be in upper-camel case.</para>
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
        /// <item><description><para>If you create the production studio by calling the <a href="https://help.aliyun.com/document_detail/2848009.html">CreateCaster</a> operation, find the ID in the CasterId parameter of the response.</para>
        /// </description></item>
        /// <item><description><para>If you create the production studio in the LIVE console, go to the <b>LIVE Console</b> &gt; <b>Production Studio</b> &gt; <b>Cloud Production Studio</b> page to view the ID.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The name of the production studio in the list on the Cloud Production Studio page is the production studio ID.</para>
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
        /// <para>The size, layout, and other information about the component layer. The elements are described as follows:</para>
        /// <list type="bullet">
        /// <item><description><para><b>HeightNormalized</b>: The normalized height.</para>
        /// </description></item>
        /// <item><description><para><b>WidthNormalized</b>: The normalized width.</para>
        /// </description></item>
        /// <item><description><para><b>PositionNormalized</b>: The normalized position of the layer element.</para>
        /// </description></item>
        /// <item><description><para><b>PositionRefer</b>: The reference coordinates for the element\&quot;s position.</para>
        /// </description></item>
        /// </list>
        /// <para>The value is a JSON-formatted string. Parameter names must be in upper-camel case.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;HeightNormalized&quot;:&quot;1&quot;,&quot;PositionRefer&quot;:&quot;topRight&quot;,&quot;WidthNormalized&quot;:&quot;0&quot;,&quot;PositionNormalized&quot;:[&quot;0.1&quot;,&quot;0.2&quot;]}</para>
        /// </summary>
        [NameInMap("ComponentLayer")]
        [Validation(Required=false)]
        public string ComponentLayer { get; set; }

        /// <summary>
        /// <para>The name of the component. The default value is the component ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text01</para>
        /// </summary>
        [NameInMap("ComponentName")]
        [Validation(Required=false)]
        public string ComponentName { get; set; }

        /// <summary>
        /// <para>The type of component. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>text</b>: A text component. If you set this parameter to text, you must also set the TextLayerContent parameter.</para>
        /// </description></item>
        /// <item><description><para><b>image</b>: An image component. If you set this parameter to image, you must also set the ImageLayerContent parameter.</para>
        /// </description></item>
        /// <item><description><para><b>caption</b>: A caption component. If you set this parameter to caption, you must also set the CaptionLayerContent parameter.</para>
        /// </description></item>
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
        /// <para>The display effect of the component. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>none</b> (default): No effect.</para>
        /// </description></item>
        /// <item><description><para><b>animateH</b>: Scrolls horizontally.</para>
        /// </description></item>
        /// <item><description><para><b>animateV</b>: Scrolls vertically.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>animateH</para>
        /// </summary>
        [NameInMap("Effect")]
        [Validation(Required=false)]
        public string Effect { get; set; }

        /// <summary>
        /// <para>The configuration of the H5 component.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;htmlUrl&quot;:<a href="http://caster.example.com%7D">http://caster.example.com}</a></para>
        /// </summary>
        [NameInMap("HtmlLayerContent")]
        [Validation(Required=false)]
        public string HtmlLayerContent { get; set; }

        /// <summary>
        /// <para>The properties of the layer element. The properties are described as follows:</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>This parameter is required when ComponentType is set to image.</para>
        /// <para>MaterialId: The ID of the media asset. The name that you specify when you upload a media asset is used as the ID of the media asset.</para>
        /// <para>The value must be a JSON-formatted string. Parameter names must be in upper-camel case.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;MaterialId&quot;:&quot;6cf724c6ebfd4a59b5b3cec6f10d****&quot;}</para>
        /// </summary>
        [NameInMap("ImageLayerContent")]
        [Validation(Required=false)]
        public string ImageLayerContent { get; set; }

        /// <summary>
        /// <para>The layer order of the component.</para>
        /// <list type="bullet">
        /// <item><description><para>cover: The component is in the foreground.</para>
        /// </description></item>
        /// <item><description><para>background: The component is in the background.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cover</para>
        /// </summary>
        [NameInMap("LayerOrder")]
        [Validation(Required=false)]
        public string LayerOrder { get; set; }

        /// <summary>
        /// <para>Specifies the position of the component. Each position can hold only one component. The format must be RC01 to RC99.</para>
        /// <remarks>
        /// <para>If the component type is caption, this parameter specifies the location of the referenced video source.</para>
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

        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The properties of the layer element. The properties are described as follows:</para>
        /// <remarks>
        /// <para>Notice: This parameter is required only when ComponentType is set to text.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para><b>SizeNormalized</b>: The normalized font size. This value is calculated as font size / output height. The value must be in the <c>[0,1]</c> range. If the font size calculated from the normalized value is greater than 1024, the font size is set to 1024.</para>
        /// </description></item>
        /// <item><description><para><b>BorderWidthNormalized</b>: The normalized width of the text border. This value is calculated based on the font size: BorderWidth / FontSize. The value must be in the <c>[0,1]</c> range. If the width calculated from the normalized value is greater than 16, the width is set to 16. The default value is 0.</para>
        /// </description></item>
        /// <item><description><para><b>FontName</b>: The font name. For valid values, see <b>Production studio fonts</b>. The default font is KaiTi.</para>
        /// </description></item>
        /// <item><description><para><b>BorderColor</b>: The color of the text border. The value must be a hexadecimal color code that ranges from 0x000000 to 0xffffff. The default value is an empty string (&quot;&quot;), which indicates that no border color is set.</para>
        /// </description></item>
        /// <item><description><para><b>Text</b>: The text content. The default value is an empty string (&quot;&quot;).</para>
        /// </description></item>
        /// <item><description><para><b>Color</b>: The text color. The default value is 0xff0000, which represents red.</para>
        /// </description></item>
        /// </list>
        /// <para>The value must be a JSON-formatted string. Parameter names must be in upper-camel case.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;BorderWidthNormalized&quot;:&quot;1&quot;,&quot;SizeNormalized&quot;:&quot;0.2&quot;,&quot;Color&quot;:&quot;0x000000&quot;,&quot;FontName&quot;:&quot;KaiTi&quot;,&quot;BorderColor&quot;:&quot;0x000000&quot;,&quot;Text&quot;:&quot;hello world!&quot;}</para>
        /// </summary>
        [NameInMap("TextLayerContent")]
        [Validation(Required=false)]
        public string TextLayerContent { get; set; }

    }

}
