// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ModifyCasterComponentRequest : TeaModel {
        /// <summary>
        /// <para>The information about the subtitle component. The value must be a JSON string. This parameter contains the following fields:</para>
        /// <remarks>
        /// <para> This parameter is required if you set ComponentType to caption.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>SizeNormalized</b>: the normalized value of the font size. The value of this field equals the font size divided by the output height. Valid values: <c>0 to 1</c>. The maximum font size is 1,024, even if the font size calculated based on this field is greater than 1,024.</description></item>
        /// <item><description><b>BorderWidthNormalized</b>: the normalized value of the border width. The value of this field equals the border width divided by the font size. Valid values: <c>0 to 1</c>. Default value: 0. The maximum border width is 16, even if the border width calculated based on this field is greater than 16.</description></item>
        /// <item><description><b>FontName</b>: the font name. Default value: KaiTi. For more information about the valid values, see <b>Fonts used in a production studio</b>.</description></item>
        /// <item><description><b>BorderColor</b>: the color of the text border. Valid values: 0x000000 to 0xffffff. By default, this parameter is left empty. In this case, the color of the text border is transparent.</description></item>
        /// <item><description><b>LocationId</b>: the channel ID of the source subtitles.</description></item>
        /// <item><description><b>SourceLan</b>: the source language of the subtitles in the video. Valid values: en (English), cn (Chinese), es (Spanish), and ru (Russian). Default value: cn.</description></item>
        /// <item><description><b>TargetLan</b>: the target language of the subtitles in the video. If you do not specify this field, speech recognition is used. If you specify this field, translation is used. Valid values: en (English), cn (Chinese), es (Spanish), and ru (Russian).</description></item>
        /// <item><description><b>ShowSourceLan</b>: specifies whether to display the source language. A value of true specifies that the source language is displayed. A value of false specifies that the source language is not displayed. Default value: false.</description></item>
        /// <item><description><b>Truncation</b>: specifies whether to allow subtitle truncation. A value of true specifies that the subtitles can be truncated. A value of false specifies that the subtitles cannot be truncated. Default value: false.</description></item>
        /// <item><description><b>SourceLanPerLineWordCount</b>: the number of words displayed in each line of the source language. This field takes effect only if you set Truncation to true. Default value: 20.</description></item>
        /// <item><description><b>TargetLanPerLineWordCount</b>: the number of words displayed in each line of the target language. This field takes effect only if you set Truncation to true. Default value: 20.</description></item>
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
        /// <para>The ID of the component. If the component was added by calling the <a href="https://help.aliyun.com/document_detail/2848030.html">AddCasterComponent</a> operation, check the value of the response parameter ComponentId to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>05ab713c-676e-49c0-96ce-cc408da1****</para>
        /// </summary>
        [NameInMap("ComponentId")]
        [Validation(Required=false)]
        public string ComponentId { get; set; }

        /// <summary>
        /// <para>The information about the component layer, such as the size and layout, The value must be a JSON string. This parameter contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>HeightNormalized</b>: the normalized value of the height of the component layer.</description></item>
        /// <item><description><b>WidthNormalized</b>: the normalized value of the width of the component layer.</description></item>
        /// <item><description><b>PositionNormalized</b>: the normalized value of the position of the component layer.</description></item>
        /// <item><description><b>PositionRefer</b>: the reference coordinates of the component layer.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;HeightNormalized&quot;:&quot;1&quot;,&quot;PositionRefer&quot;:&quot;topRight&quot;,&quot;WidthNormalized&quot;:&quot;0&quot;,&quot;PositionNormalized&quot;:[&quot;0.1&quot;,&quot;0.2&quot;]}</para>
        /// </summary>
        [NameInMap("ComponentLayer")]
        [Validation(Required=false)]
        public string ComponentLayer { get; set; }

        /// <summary>
        /// <para>The name of the component. By default, the name is the ID of the component.</para>
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
        /// <item><description><b>text</b>: text component. The TextLayerContent parameter is required if you set ComponentType to text.</description></item>
        /// <item><description><b>image</b>: image component. The ImageLayerContent parameter is required if you set ComponentType to image.</description></item>
        /// <item><description><b>caption</b>: subtitle component. The CaptionLayerContent parameter is required if you set ComponentType to caption.</description></item>
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
        /// <item><description><b>none</b> (default)</description></item>
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
        /// <para>The information about the image component. The value must be a JSON string.</para>
        /// <remarks>
        /// <para> This parameter is required if you set ComponentType to image.</para>
        /// </remarks>
        /// <para>The MaterialId field specifies the ID of the material from the media asset library.</para>
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

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The information about the text component. The value must be a JSON string. This parameter contains the following fields:</para>
        /// <remarks>
        /// <para> This parameter is required if you set ComponentType to text.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>SizeNormalized</b>: the normalized value of the font size. The value of this field equals the font size divided by the output height. Valid values: <c>0 to 1</c>. The maximum font size is 1,024, even if the font size calculated based on this field is greater than 1,024.</description></item>
        /// <item><description><b>BorderWidthNormalized</b>: the normalized value of the border width. The value of this field equals the border width divided by the font size. Valid values: <c>0 to 1</c>. Default value: 0. The maximum border width is 16, even if the border width calculated based on this field is greater than 16.</description></item>
        /// <item><description><b>FontName</b>: the font name. Default value: KaiTi. For more information about the valid values, see <b>Fonts used in a production studio</b>.</description></item>
        /// <item><description><b>BorderColor</b>: the color of the text border. Valid values: 0x000000 to 0xffffff. By default, this parameter is left empty. In this case, the color of the text border is transparent.</description></item>
        /// <item><description><b>Text</b>: the content of the text. By default, this parameter is left empty. In this case, the text contains no content.</description></item>
        /// <item><description><b>Color</b>: the color of the text. The default value is 0xff0000, which indicates that the text is in red.</description></item>
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
