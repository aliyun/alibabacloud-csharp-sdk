// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class SubmitRemakeScriptJobRequest : TeaModel {
        /// <summary>
        /// <para>The remake parameters in JSON string format. The structure varies depending on the RemakeType. For faithful-remake, the structure is as follows:</para>
        /// <list type="bullet">
        /// <item><description>ComprehensionResult (String, required): The content understanding result, which is the URL of a JSON file.</description></item>
        /// <item><description>Product (Object, required): The product information, including the original and new products.<list type="bullet">
        /// <item><description>OriginalProductName (String, required): The product or brand name in the original video, used to locate and replace mentions of the original product.</description></item>
        /// <item><description>NewProduct (Object, required): The new product information.<list type="bullet">
        /// <item><description>ProductName (String, required): The product or brand name.</description></item>
        /// <item><description>Description (String, required): The product description.</description></item>
        /// <item><description>ProductKnowledge (String, optional): The physical knowledge of the product, such as the material and usage.</description></item>
        /// <item><description>ProductImages (Array<String>, required): The images of the new product. This array cannot be empty, and each item must be an HTTP or HTTPS URL.</description></item>
        /// <item><description>SellingPoints (Array<String>, optional): The list of product selling points.</description></item>
        /// <item><description>OriginalPrice (String, optional): The original price.</description></item>
        /// <item><description>CurrentPrice (String, optional): The current price.</description></item>
        /// <item><description>Discount (String, optional): The discount information, such as &quot;50 off for orders over 200&quot; or &quot;buy one get one free&quot;.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description>AvatarList (Array<Object>, optional): The list of avatar replacements, supporting single and multiple avatar replacements. We recommend using this field. Pass one item for a single avatar and two to five items for multiple avatars. Each item is an object that describes the replacement relationship between an original avatar and a new avatar:<list type="bullet">
        /// <item><description>OriginalAvatarName (String, required for each item): The name of the avatar to be replaced in the original video. Use the avatar name from the video breakdown result to locate the replacement target in the script or video. The original avatar names in the same list cannot be duplicated.</description></item>
        /// <item><description>NewAvatarImages (Array<String>, required for each item): The list of reference images for the new avatar. This array cannot be empty. Images can be HTTP or HTTPS URLs or registered image MediaIds. Currently, only the first image is used.</description></item>
        /// <item><description>AvatarName (String, optional for each item): The role name of the replaced avatar in the generated script.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Avatar (Object, optional): The single avatar replacement information compatible with historical calls, retained as a transitional field. We recommend using AvatarList for new integrations and subsequent calls. The field structure is the same as a single item in AvatarList. When using this field, OriginalAvatarName and NewAvatarImages are required, and AvatarName is optional.</description></item>
        /// <item><description>VoiceoverLanguage (String, optional): The voiceover language. Valid values: zh (Chinese), en (English), es (Spanish), pt (Portuguese), fr (French), de (German), ja (Japanese), ko (Korean), and ar (Arabic). We recommend explicitly specifying this parameter.</description></item>
        /// <item><description>AdditionalRequirements (String, optional): Additional remake requirements.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;ComprehensionResult&quot;: &quot;<a href="https://example-bucket.oss-cn-shanghai.aliyuncs.com/comprehension-result.json">https://example-bucket.oss-cn-shanghai.aliyuncs.com/comprehension-result.json</a>&quot;,
        ///   &quot;Product&quot;: {
        ///     &quot;OriginalProductName&quot;: &quot;Original Shapewear Bodysuit&quot;,
        ///     &quot;NewProduct&quot;: {
        ///       &quot;ProductName&quot;: &quot;Compression Shapewear Bodysuit&quot;,
        ///       &quot;Description&quot;: &quot;Description of the new product.&quot;,
        ///       &quot;ProductImages&quot;: [
        ///         &quot;<a href="https://example.com/product-front.png">https://example.com/product-front.png</a>&quot;,
        ///         &quot;<a href="https://example.com/product-side.png">https://example.com/product-side.png</a>&quot;,
        ///         &quot;<a href="https://example.com/product-back.png">https://example.com/product-back.png</a>&quot;
        ///       ],
        ///       &quot;ProductKnowledge&quot;: &quot;Product materials, physical characteristics, and usage instructions.&quot;
        ///     }
        ///   },
        ///   &quot;AvatarList&quot;: [
        ///     {
        ///       &quot;OriginalAvatarName&quot;: &quot;Original Person A&quot;,
        ///       &quot;NewAvatarImages&quot;: [
        ///         &quot;<a href="https://example.com/new-avatar-a.png">https://example.com/new-avatar-a.png</a>&quot;
        ///       ],
        ///       &quot;AvatarName&quot;: &quot;Alice&quot;
        ///     },
        ///     {
        ///       &quot;OriginalAvatarName&quot;: &quot;Original Person B&quot;,
        ///       &quot;NewAvatarImages&quot;: [
        ///         &quot;<a href="https://example.com/new-avatar-b.png">https://example.com/new-avatar-b.png</a>&quot;
        ///       ],
        ///       &quot;AvatarName&quot;: &quot;Bob&quot;
        ///     }
        ///   ],
        ///   &quot;VoiceoverLanguage&quot;: &quot;zh&quot;
        /// }</para>
        /// </summary>
        [NameInMap("RemakeParams")]
        [Validation(Required=false)]
        public string RemakeParams { get; set; }

        /// <summary>
        /// <para>The remake type, which determines the structure of RemakeParams. Currently, only faithful-remake is supported. This type faithfully remakes the original viral video structure segment by segment, replacing the product and avatar.</para>
        /// 
        /// <b>Example:</b>
        /// <para>faithful-remake</para>
        /// </summary>
        [NameInMap("RemakeType")]
        [Validation(Required=false)]
        public string RemakeType { get; set; }

        /// <summary>
        /// <para>The custom parameters in JSON string format, which are returned as-is in the callback result, such as newsKey. The system reserves the NotifyAddress field for the callback URL, which is invoked after the task is completed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;NotifyAddress&quot;: &quot;<a href="https://example.com/callback">https://example.com/callback</a>&quot;
        /// }</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
