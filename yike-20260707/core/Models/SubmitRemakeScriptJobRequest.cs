// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class SubmitRemakeScriptJobRequest : TeaModel {
        /// <summary>
        /// <para>The remake parameters (JSON string). The structure varies depending on <c>RemakeType</c>. For <c>faithful-remake</c>, the structure is as follows:</para>
        /// <list type="bullet">
        /// <item><description><para>ComprehensionResult (string, required): The content comprehension result. A URL to a JSON file.</para>
        /// </description></item>
        /// <item><description><para>Product (Object, required): The product information (original product + new product).</para>
        /// <list type="bullet">
        /// <item><description><para>OriginalProductName (String, required): The product or brand name in the original video (the object to be replaced). Used to locate and replace mentions of the original product in the script.</para>
        /// </description></item>
        /// <item><description><para>NewProduct (Object, required): The new product information. </para>
        /// <list type="bullet">
        /// <item><description>ProductName (String, required): The product or brand name.</description></item>
        /// <item><description>Description (String, required): The product description.</description></item>
        /// <item><description>ProductKnowledge (String, required): The physical knowledge of the product, such as material and usage instructions.</description></item>
        /// <item><description>ProductImages (Array\&lt;String\&gt;, required): The images of the new product. Must not be empty. Each item is an http(s) URL.</description></item>
        /// <item><description>SellingPoints (Array\&lt;String\&gt;, optional): The list of product selling points.</description></item>
        /// <item><description>OriginalPrice (String, optional): The original price.</description></item>
        /// <item><description>CurrentPrice (String, optional): The current price.</description></item>
        /// <item><description>Discount (String, optional): The discount information, such as &quot;50 off 200&quot; or &quot;buy one get one free&quot;.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Avatar (Object, required): The model information (original model + new model).</para>
        /// <list type="bullet">
        /// <item><description>NewAvatarImages (Array\&lt;String\&gt;, required): The list of new model images. Must not be empty. Each item is a media asset ID or an image URL (when a URL is provided, the system automatically registers it as a media asset). <b>Currently, only 1 image is supported</b> (only the first element of the array is used). The array format is reserved for future expansion.</description></item>
        /// <item><description>OriginalAvatarName (String, required): The name of the model in the original video (the object to be replaced). Used to locate and replace the original model in the script and visuals.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>VoiceoverLanguage (String, optional): The voiceover language. Valid values: <c>zh</c> (Chinese), <c>en</c> (English), <c>es</c> (Spanish), <c>pt</c> (Portuguese), <c>fr</c> (French), <c>de</c> (German), <c>ja</c> (Japanese), <c>ko</c> (Korean), <c>ar</c> (Arabic). Default value: <c>zh</c>.</para>
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
        /// <para>The remake type, which determines the structure of <c>RemakeParams</c>. Currently, only <c>faithful-remake</c> is supported (faithful remake: remakes the original hit video segment by segment, replacing the product and model).</para>
        /// 
        /// <b>Example:</b>
        /// <para>faithful-remake</para>
        /// </summary>
        [NameInMap("RemakeType")]
        [Validation(Required=false)]
        public string RemakeType { get; set; }

        /// <summary>
        /// <para>The custom parameters in JSON format. These parameters are returned as-is in the callback result (for example, newsKey). The system reserved field NotifyAddress specifies the callback URL. The system sends a callback to this URL after the task is completed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;NotifyAddress&quot;: &quot;<a href="http://xxx.callback.url%22%7D">http://xxx.callback.url&quot;}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
