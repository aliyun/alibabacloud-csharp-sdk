// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class SubmitVideoRemakeJobRequest : TeaModel {
        /// <summary>
        /// <para>The JSON object string for the original video input. The Type of the first item in Medias is video, and a MediaId or HTTP(S) URL is provided.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Medias&quot;:[{&quot;Type&quot;:&quot;video&quot;,&quot;Url&quot;:&quot;<a href="https://example.com/source.mp4%22%7D%5D%7D">https://example.com/source.mp4&quot;}]}</a></para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string Input { get; set; }

        /// <summary>
        /// <para>The remake parameters in JSON string format. The structure is as follows:</para>
        /// <list type="bullet">
        /// <item><description>Product (Object, required): The product information, including the original and new products.<list type="bullet">
        /// <item><description>OriginalProductName (String, optional): The product or brand name in the original video, used to locate and replace mentions of the original product.</description></item>
        /// <item><description>NewProduct (Object, required): The new product information.<list type="bullet">
        /// <item><description>ProductName (String, required): The product or brand name.</description></item>
        /// <item><description>Description (String, optional): The product description.</description></item>
        /// <item><description>ProductKnowledge (String, optional): The physical knowledge of the product, such as material and usage.</description></item>
        /// <item><description>ProductImages (Array<String>, required): A non-empty list of new product images, where each item is an HTTP(S) URL.</description></item>
        /// <item><description>SellingPoints (Array<String>, optional): The list of product selling points.</description></item>
        /// <item><description>OriginalPrice (String, optional): The original price.</description></item>
        /// <item><description>CurrentPrice (String, optional): The current price.</description></item>
        /// <item><description>Discount (String, optional): The discount information, such as &quot;$50 off for orders over $200&quot; or &quot;Buy one get one free&quot;.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description>AvatarList (Array<Object>, optional): The character replacement list, supporting 1 to 5 items. Each item describes the replacement relationship between an original character and a new character. If this parameter is not passed or is an empty array, no characters are replaced.<list type="bullet">
        /// <item><description>OriginalAvatarImage (String, required for each item when there are multiple characters, optional for a single character): The reference image of the target character in the original video. An HTTP(S) URL or a registered image MediaId is supported. Duplicates are not allowed in the same list.</description></item>
        /// <item><description>NewAvatarImages (Array<String>, required for each item): A non-empty list of reference images for the new character. An HTTP(S) URL or a registered image MediaId is supported.</description></item>
        /// <item><description>AvatarName (String, optional for each item): The role name of the replaced character in the generated script.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>VoiceoverLanguage (String, optional): The voiceover language. Default value: zh.</description></item>
        /// <item><description>AdditionalRequirements (String, optional): Additional remake requirements.</description></item>
        /// </list>
        /// <para>This operation uses AvatarList and does not use the legacy Avatar or OriginalAvatarName from the standalone scripting interface. The two character structures are not interchangeable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Product&quot;:{&quot;OriginalProductName&quot;:&quot;Original product&quot;,&quot;NewProduct&quot;:{&quot;ProductName&quot;:&quot;New product&quot;,&quot;Description&quot;:&quot;Product description&quot;,&quot;ProductImages&quot;:[&quot;<a href="https://example.com/product.jpg%22%5D%7D%7D,%22AvatarList%22:%5B%7B%22OriginalAvatarImage%22:%22https://example.com/original.jpg%22,%22NewAvatarImages%22:%5B%22https://example.com/avatar.jpg%22%5D,%22AvatarName%22:%22Alice%22%7D%5D,%22VoiceoverLanguage%22:%22en%22%7D">https://example.com/product.jpg&quot;]}},&quot;AvatarList&quot;:[{&quot;OriginalAvatarImage&quot;:&quot;https://example.com/original.jpg&quot;,&quot;NewAvatarImages&quot;:[&quot;https://example.com/avatar.jpg&quot;],&quot;AvatarName&quot;:&quot;Alice&quot;}],&quot;VoiceoverLanguage&quot;:&quot;en&quot;}</a></para>
        /// </summary>
        [NameInMap("RemakeParams")]
        [Validation(Required=false)]
        public string RemakeParams { get; set; }

        /// <summary>
        /// <para>The user-defined JSON object string, which is returned as-is when queried. NotifyAddress is the callback URL for the final state of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;NotifyAddress&quot;:&quot;<a href="https://example.com/callback%22,%22bizId%22:%22remake_001%22%7D">https://example.com/callback&quot;,&quot;bizId&quot;:&quot;remake_001&quot;}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
