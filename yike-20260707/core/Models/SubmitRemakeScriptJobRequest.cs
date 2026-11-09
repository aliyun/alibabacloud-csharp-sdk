// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class SubmitRemakeScriptJobRequest : TeaModel {
        /// <summary>
        /// <para>The remake parameters. This parameter is a JSON string. The structure varies based on RemakeType. For faithful-remake, the structure is as follows:</para>
        /// <list type="bullet">
        /// <item><description><para>ComprehensionResult (string, required): The content understanding result. This is the URL of the JSON file.</para>
        /// </description></item>
        /// <item><description><para>Product (object, required): The product information, including the original product and the new product.</para>
        /// <list type="bullet">
        /// <item><description><para>OriginalProductName (string, required): The product or brand name in the original video to be replaced. This is used to locate and replace mentions of the original product in the script.</para>
        /// </description></item>
        /// <item><description><para>NewProduct (object, required): The new product information. </para>
        /// <list type="bullet">
        /// <item><description>ProductName (string, required): The product or brand name.</description></item>
        /// <item><description>Description (string, required): The product description.</description></item>
        /// <item><description>ProductKnowledge (string, required): The physical knowledge of the product, such as the material and usage instructions.</description></item>
        /// <item><description>ProductImages (array of strings, required): The images of the new product. This array cannot be empty. Each item must be an HTTP or HTTPS URL.</description></item>
        /// <item><description>SellingPoints (array of strings, optional): The list of product selling points.</description></item>
        /// <item><description>OriginalPrice (string, optional): The original price.</description></item>
        /// <item><description>CurrentPrice (string, optional): The current price.</description></item>
        /// <item><description>Discount (string, optional): The discount information, such as &quot;50 off for purchases over 200&quot; or &quot;buy one get one free&quot;.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Avatar (object, required): The avatar information, including the original avatar and the new avatar.</para>
        /// <list type="bullet">
        /// <item><description>NewAvatarImages (array of strings, required): The list of images for the new avatar. This array cannot be empty. Each item must be a media asset ID or an image URL. If a URL is provided, the system automatically registers it as a media asset. <b>Currently, only one image is supported</b> (only the first element of the array is used). The array format is reserved for future extensions.</description></item>
        /// <item><description>OriginalAvatarName (string, required): The avatar name in the original video to be replaced. This is used to locate and replace the original avatar in the script or video frames.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>VoiceoverLanguage (string, optional): The voiceover language. Valid values: <c>zh</c> (Chinese), <c>en</c> (English), <c>es</c> (Spanish), <c>pt</c> (Portuguese), <c>fr</c> (French), <c>de</c> (German), <c>ja</c> (Japanese), <c>ko</c> (Korean), and <c>ar</c> (Arabic). Default value: <c>zh</c>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;ComprehensionResult&quot;: &quot;<a href="http://xxxx.json">http://xxxx.json</a>&quot;,
        ///     &quot;Product&quot;:
        ///     {
        ///         &quot;OriginalProductName&quot;: &quot;xxxx&quot;,
        ///         &quot;NewProduct&quot;:
        ///         {
        ///             &quot;ProductName&quot;: &quot;xxxx&quot;,
        ///             &quot;Description&quot;: &quot;xxxx&quot;,
        ///             &quot;ProductImages&quot;:
        ///             [
        ///                 &quot;<a href="https://xxxx.png">https://xxxx.png</a>&quot;,
        ///                 &quot;<a href="https://xxxx.png">https://xxxx.png</a>&quot;,
        ///                 &quot;<a href="https://xxxx.png">https://xxxx.png</a>&quot;
        ///             ],
        ///             &quot;ProductKnowledge&quot;: &quot;xxxx&quot;
        ///         }
        ///     },
        ///     &quot;Avatar&quot;:
        ///     {
        ///         &quot;NewAvatarImages&quot;:
        ///         [
        ///             &quot;<a href="https://xxxx.png">https://xxxx.png</a>&quot;
        ///         ],
        ///         &quot;OriginalAvatarName&quot;: &quot;xxxx&quot;
        ///     },
        ///     &quot;VoiceoverLanguage&quot;: &quot;zh&quot;
        /// }</para>
        /// </summary>
        [NameInMap("RemakeParams")]
        [Validation(Required=false)]
        public string RemakeParams { get; set; }

        /// <summary>
        /// <para>The remake type. This parameter determines the structure of RemakeParams. Currently, only faithful-remake is supported. faithful-remake indicates a faithful remake that replicates the original viral structure paragraph by paragraph and replaces the product and avatar.</para>
        /// 
        /// <b>Example:</b>
        /// <para>faithful-remake</para>
        /// </summary>
        [NameInMap("RemakeType")]
        [Validation(Required=false)]
        public string RemakeType { get; set; }

        /// <summary>
        /// <para>The custom parameters. This parameter is a JSON string and is returned as-is in the callback result, such as newsKey. NotifyAddress is a system-reserved field for the callback URL. The system sends a callback to this URL after the task is completed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;NotifyAddress&quot;: &quot;<a href="http://xxx.callback.url%22%7D">http://xxx.callback.url&quot;}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
