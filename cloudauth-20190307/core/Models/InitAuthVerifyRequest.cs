// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class InitAuthVerifyRequest : TeaModel {
        /// <summary>
        /// <para>A security token that you generate to prevent replay attacks and data tampering.
        /// If this value is set, the CallbackToken field is included in the callback to CallbackUrl.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NMjvQanQgplBSaEI0sL86WnQplB</para>
        /// </summary>
        [NameInMap("CallbackToken")]
        [Validation(Required=false)]
        public string CallbackToken { get; set; }

        /// <summary>
        /// <para>The callback URL for OCR results. The callback request method is GET by default. The callback URL must start with https. After OCR is completed, a callback is sent to this URL with the certifyId and subcode fields automatically appended.</para>
        /// <remarks>
        /// <para>Warning</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The URL is validated for public network access before the API is invoked. If the URL is not publicly accessible, a 400 error is returned.</description></item>
        /// <item><description>The callback is executed immediately after the OCR invocation is completed, but may be delayed due to network issues. Accept the request completion notification from the client side first, and then invoke the query API to obtain the result details.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.aliyun.com?callbackToken=100000****&certifyId=shaxxxx&subCode=200">https://www.aliyun.com?callbackToken=100000****&amp;certifyId=shaxxxx&amp;subCode=200</a></para>
        /// </summary>
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// <para>The number of card pages collected by the SDK. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>&quot;1&quot;: front side only</description></item>
        /// <item><description>&quot;2&quot;: both front and back sides.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CardPageNumber")]
        [Validation(Required=false)]
        public string CardPageNumber { get; set; }

        /// <summary>
        /// <para>The document type. Set the value to IDENTITY_CARD.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IDENTITY_CARD</para>
        /// </summary>
        [NameInMap("CardType")]
        [Validation(Required=false)]
        public string CardType { get; set; }

        /// <summary>
        /// <para>The OCR document scan pattern. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>shoot (default): photo capture</description></item>
        /// <item><description>scan: scan</description></item>
        /// <item><description>auto: automatic switchover between photo capture and scan.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>shoot</para>
        /// </summary>
        [NameInMap("DocScanMode")]
        [Validation(Required=false)]
        public string DocScanMode { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the document anti-forgery detection feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Y: Enabled.</description></item>
        /// <item><description>N: Disabled. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("IdSpoof")]
        [Validation(Required=false)]
        public string IdSpoof { get; set; }

        /// <summary>
        /// <para>The MetaInfo environment parameter, which must be obtained from the client SDK.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;zimVer&quot;: &quot;3.0.0&quot;,
        ///   &quot;appVersion&quot;: &quot;1&quot;,
        ///   &quot;bioMetaInfo&quot;: &quot;4.1.0:1150****,0&quot;,
        ///   &quot;appName&quot;: &quot;com.aliyun.antcloudauth&quot;,
        ///   &quot;deviceType&quot;: &quot;ios&quot;,
        ///   &quot;osVersion&quot;: &quot;iOS 10.3.2&quot;,
        ///   &quot;apdidToken&quot;: &quot;&quot;,
        ///   &quot;deviceModel&quot;: &quot;iPhone9,1&quot;
        /// }</para>
        /// </summary>
        [NameInMap("MetaInfo")]
        [Validation(Required=false)]
        public string MetaInfo { get; set; }

        /// <summary>
        /// <para>A custom business unique identifier that you specify for subsequent troubleshooting.</para>
        /// <para>The value can contain letters (both uppercase and lowercase) and digits, with a maximum length of 32 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e0c34a77f5ac40a5aa5e6ed20c******</para>
        /// </summary>
        [NameInMap("OuterOrderNo")]
        [Validation(Required=false)]
        public string OuterOrderNo { get; set; }

        /// <summary>
        /// <para>The product solution to use. Set the value to ID_OCR.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ID_OCR</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The China Chinese authentication scenario ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000002996</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public long? SceneId { get; set; }

    }

}
