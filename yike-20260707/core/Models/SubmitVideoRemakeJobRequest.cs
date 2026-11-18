// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class SubmitVideoRemakeJobRequest : TeaModel {
        /// <summary>
        /// <para>The input materials. The value is a JSON string with the following structure:</para>
        /// <list type="bullet">
        /// <item><description>Medias (Array<Object>, required): A non-empty list of media assets. This operation uses the first video in the list and does not support batch remakes. The first item contains the following fields:<list type="bullet">
        /// <item><description>Type (String, required): The type of the media asset. For this operation, set the value to video for the first item. The value is case-insensitive.</description></item>
        /// <item><description>Url (String, mutually exclusive with MediaId): The URL of the media asset. The URL must start with http:// or https:// and cannot exceed 2,048 characters in length. Unregistered URLs are automatically registered as media assets.</description></item>
        /// <item><description>MediaId (String, mutually exclusive with Url): The ID of the registered media asset. If both Url and MediaId are specified, MediaId takes precedence.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Medias&quot;:[{&quot;Type&quot;:&quot;video&quot;,&quot;Url&quot;:&quot;<a href="https://example.com/source.mp4%22%7D%5D%7D">https://example.com/source.mp4&quot;}]}</a></para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string Input { get; set; }

        /// <summary>
        /// <para>The remake parameters. The value is a JSON string with the following structure:</para>
        /// <list type="bullet">
        /// <item><description>Product (Object, required): The product information, including the original product and the new product.<list type="bullet">
        /// <item><description>OriginalProductName (String, optional): The name of the product or brand in the original video. This is used to locate and replace mentions of the original product.</description></item>
        /// <item><description>NewProduct (Object, required): The information about the new product.<list type="bullet">
        /// <item><description>ProductName (String, required): The name of the product or brand.</description></item>
        /// <item><description>Description (String, optional): The description of the product.</description></item>
        /// <item><description>ProductKnowledge (String, optional): The physical knowledge of the product, such as the material and usage.</description></item>
        /// <item><description>ProductImages (Array\&lt;String\&gt;, required): The images of the new product. The list cannot be empty. Each item is an HTTP or HTTPS URL.</description></item>
        /// <item><description>SellingPoints (Array\&lt;String\&gt;, optional): The list of selling points of the product.</description></item>
        /// <item><description>OriginalPrice (String, optional): The original price.</description></item>
        /// <item><description>CurrentPrice (String, optional): The current price.</description></item>
        /// <item><description>Discount (String, optional): The discount information, such as &quot;50 off for orders over 200&quot; or &quot;buy one get one free&quot;.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description>AvatarList (Array\&lt;Object\&gt;, optional): The list of character replacements. Single-character and multi-character replacements are supported. Pass one item for single-character replacement and two to five items for multi-character replacement. Each item is an object that describes the replacement relationship between an original character and a new character. If this parameter is not passed or is an empty array, no characters are replaced.<list type="bullet">
        /// <item><description>OriginalAvatarImage (String, required for each item in multi-character replacement, optional for single-character replacement): The reference image of the target character in the original video. HTTP and HTTPS URLs or registered image MediaIds are supported. The value cannot be duplicated within the same list.</description></item>
        /// <item><description>NewAvatarImages (Array\&lt;String\&gt;, required for each item): The list of reference images for the new character. The list cannot be empty. HTTP and HTTPS URLs or registered image MediaIds are supported.</description></item>
        /// <item><description>AvatarName (String, optional for each item): The role name of the replaced character in the generated script.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>VoiceoverLanguage (String, optional): The voiceover language. Explicitly specify the language, such as zh for Chinese or en for English.</description></item>
        /// <item><description>AdditionalRequirements (String, optional): Additional remake requirements.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
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
        ///       &quot;OriginalAvatarImage&quot;: &quot;<a href="https://example.com/original-avatar-a.png">https://example.com/original-avatar-a.png</a>&quot;,
        ///       &quot;NewAvatarImages&quot;: [
        ///         &quot;<a href="https://example.com/new-avatar-a.png">https://example.com/new-avatar-a.png</a>&quot;
        ///       ],
        ///       &quot;AvatarName&quot;: &quot;Alice&quot;
        ///     },
        ///     {
        ///       &quot;OriginalAvatarImage&quot;: &quot;<a href="https://example.com/original-avatar-b.png">https://example.com/original-avatar-b.png</a>&quot;,
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
        /// <para>The user-defined data.</para>
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
