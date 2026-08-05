// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ModifyCasterComponentRequest : TeaModel {
        /// <summary>
        /// <para>The properties of the caption layer. The value is a JSON string. The following properties are supported:</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>This parameter is required if you set ComponentType to caption.</para>
        /// <list type="bullet">
        /// <item><description><para><b>SizeNormalized</b>: The normalized font size. The font size is calculated using the formula: font_size/output_height. The value must be in the range of <c>[0,1]</c>. If the calculated font size is greater than 1024, the value 1024 is used.</para>
        /// </description></item>
        /// <item><description><para><b>BorderWidthNormalized</b>: The normalized width of the text border. The normalized width is calculated based on the font size using the formula: BorderWidth/FontSize. The value must be in the range of <c>[0,1]</c>. If the calculated value is greater than 16, the value 16 is used. Default value: 0.</para>
        /// </description></item>
        /// <item><description><para><b>FontName</b>: The font name. For more information about valid values, see <b>Production studio fonts</b>. Default value: KaiTi.</para>
        /// </description></item>
        /// <item><description><para><b>BorderColor</b>: The color of the text border. Valid values are from 0x000000 to 0xffffff. The default value is an empty string, which indicates that this parameter is not used.</para>
        /// </description></item>
        /// <item><description><para><b>LocationId</b>: The channel ID of the translation source.</para>
        /// </description></item>
        /// <item><description><para><b>SourceLan</b>: The source language of the audio in the video source. Valid values are en (English), cn (Chinese), es (Spanish), and ru (Russian). Default value: cn.</para>
        /// </description></item>
        /// <item><description><para><b>TargetLan</b>: The target language for translation. If you do not set this parameter, only speech recognition is performed. If you set this parameter, translation is also performed. Valid values are en (English), cn (Chinese), es (Spanish), and ru (Russian).</para>
        /// </description></item>
        /// <item><description><para><b>ShowSourceLan</b>: Specifies whether to display the source language. Valid values are true (display) and false (do not display). Default value: false.</para>
        /// </description></item>
        /// <item><description><para><b>Truncation</b>: Specifies whether to truncate the caption. Valid values are true (truncate) and false (do not truncate). Default value: false.</para>
        /// </description></item>
        /// <item><description><para><b>SourceLanPerLineWordCount</b>: The number of words per line for the source language. This parameter takes effect only if Truncation is set to true. Default value: 20.</para>
        /// </description></item>
        /// <item><description><para><b>TargetLanPerLineWordCount</b>: The number of words per line for the target language. This parameter takes effect only if Truncation is set to true. Default value: 20.</para>
        /// </description></item>
        /// </list>
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
        /// <item><description><para>The ID is returned after you call the <a href="https://help.aliyun.com/document_detail/2848009.html">CreateCaster</a> operation.</para>
        /// </description></item>
        /// <item><description><para>If you create a production studio in the LIVE console, go to the <b>LIVE</b> &gt; <b>Production Studio</b> &gt; <b>Cloud Production Studio</b> page to find the ID.</para>
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
        /// <para>The component ID. The ID is returned after you call the <a href="https://help.aliyun.com/document_detail/2848030.html">AddCasterComponent</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>05ab713c-676e-49c0-96ce-cc408da1****</para>
        /// </summary>
        [NameInMap("ComponentId")]
        [Validation(Required=false)]
        public string ComponentId { get; set; }

        /// <summary>
        /// <para>The size and layout of the layer. The value is a JSON string. The following properties are supported:</para>
        /// <list type="bullet">
        /// <item><description><para><b>HeightNormalized</b>: The normalized height.</para>
        /// </description></item>
        /// <item><description><para><b>WidthNormalized</b>: The normalized width.</para>
        /// </description></item>
        /// <item><description><para><b>PositionNormalized</b>: The normalized position of the layer.</para>
        /// </description></item>
        /// <item><description><para><b>PositionRefer</b>: The reference point for the position of the layer.</para>
        /// </description></item>
        /// </list>
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
        /// <para>The type of the component. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>text</b>: A text component. The TextLayerContent parameter is required only if you set ComponentType to text.</para>
        /// </description></item>
        /// <item><description><para><b>image</b>: An image component. The ImageLayerContent parameter is required only if you set ComponentType to image.</para>
        /// </description></item>
        /// <item><description><para><b>caption</b>: A translation caption component. The CaptionLayerContent parameter is required only if you set ComponentType to caption.</para>
        /// </description></item>
        /// </list>
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
        /// <item><description><para><b>none</b> (default): no effect.</para>
        /// </description></item>
        /// <item><description><para><b>animateH</b>: horizontal scroll.</para>
        /// </description></item>
        /// <item><description><para><b>animateV</b>: vertical scroll.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>animateV</para>
        /// </summary>
        [NameInMap("Effect")]
        [Validation(Required=false)]
        public string Effect { get; set; }

        /// <summary>
        /// <para>The properties of the image layer. The value is a JSON string.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>This parameter is required if you set ComponentType to image.</para>
        /// <para>MaterialId is the ID of the material in the media asset library.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;MaterialId&quot;:&quot;6cf724c6ebfd4a59b5b3cec6f10d5ecf&quot;}</para>
        /// </summary>
        [NameInMap("ImageLayerContent")]
        [Validation(Required=false)]
        public string ImageLayerContent { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The properties of the text layer. The value is a JSON string. The following properties are supported:</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>This parameter is required if you set ComponentType to text.</para>
        /// <list type="bullet">
        /// <item><description><para><b>SizeNormalized</b>: The normalized font size. The font size is calculated using the formula: font_size/output_height. The value must be in the range of <c>[0,1]</c>. If the calculated font size is greater than 1024, the value 1024 is used.</para>
        /// </description></item>
        /// <item><description><para><b>BorderWidthNormalized</b>: The normalized width of the text border. The normalized width is calculated based on the font size using the formula: BorderWidth/FontSize. The value must be in the range of <c>[0,1]</c>. If the calculated value is greater than 16, the value 16 is used. Default value: 0.</para>
        /// </description></item>
        /// <item><description><para><b>FontName</b>: The font name. For more information about valid values, see <b>Production studio fonts</b>. Default value: KaiTi.</para>
        /// </description></item>
        /// <item><description><para><b>BorderColor</b>: The color of the text border. Valid values are from 0x000000 to 0xffffff. The default value is an empty string, which indicates that this parameter is not used.</para>
        /// </description></item>
        /// <item><description><para><b>Text</b>: The text content. The default value is an empty string.</para>
        /// </description></item>
        /// <item><description><para><b>Color</b>: The color of the text. Default value: 0xff0000, which is red.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;BorderWidthNormalized&quot;:&quot;1&quot;,&quot;SizeNormalized&quot;:&quot;0.2&quot;,&quot;Color&quot;:&quot;0x000000&quot;,&quot;FontName&quot;:&quot;KaiTi&quot;,&quot;BorderColor&quot;:&quot;0x000000&quot;,&quot;Text&quot;:&quot;hello world!&quot;}</para>
        /// </summary>
        [NameInMap("TextLayerContent")]
        [Validation(Required=false)]
        public string TextLayerContent { get; set; }

    }

}
