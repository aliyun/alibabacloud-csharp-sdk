// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class InitCardVerifyRequest : TeaModel {
        /// <summary>
        /// <para>The security token used for anti-replay and anti-tampering verification. If you specify this parameter, the CallbackToken field is included in the callback URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NMjvQanQgplBSaEI0sL86WnQplB</para>
        /// </summary>
        [NameInMap("CallbackToken")]
        [Validation(Required=false)]
        public string CallbackToken { get; set; }

        /// <summary>
        /// <para>The callback URL for authentication results. The URL must start with https. After the authentication is complete, the system sends a callback to this URL with the certifyId and passed fields automatically appended. Example: <a href="https://www.aliyun.com?certifyId=xxxx&passed=T">https://www.aliyun.com?certifyId=xxxx&amp;passed=T</a></para>
        /// <remarks>
        /// <para><b>Warning</b> The callback is triggered only when the authentication is complete. No notification is sent if the authentication is abandoned, interrupted, or not performed. After you receive the callback notification, call the query operation to obtain the authentication details if needed.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.aliyun.com">https://www.aliyun.com</a></para>
        /// </summary>
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// <para>The number of card pages to be collected by the SDK. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>1: collects the front side only.</para>
        /// </description></item>
        /// <item><description><para>2: collects both the front and back sides.</para>
        /// </description></item>
        /// <item><description><para>If the verification type is ID card validity period (VerifyMeta is set to ID_PERIOD), set this parameter to 2.</para>
        /// </description></item>
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
        /// <para>The document type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>IDENTITY_CARD: resident identity card.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IDENTITY_CARD</para>
        /// </summary>
        [NameInMap("CardType")]
        [Validation(Required=false)]
        public string CardType { get; set; }

        /// <summary>
        /// <para>The photo capture mode (manual or automatic). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>shoot: manual capture</description></item>
        /// <item><description>scan: scan mode </description></item>
        /// <item><description>auto: automatic switchover.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>shoot</para>
        /// </summary>
        [NameInMap("DocScanMode")]
        [Validation(Required=false)]
        public string DocScanMode { get; set; }

        /// <summary>
        /// <para>A custom business unique identifier that you define for subsequent troubleshooting. The value is a combination of letters and digits up to 32 characters in length. Make sure the value is unique.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e0c34a77f5ac40a5aa5e6ed20c35****</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <para>The MetaInfo environment parameter. Obtain this value by using the client SDK.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;zimVer&quot;:&quot;3.0.0&quot;,&quot;appVersion&quot;: &quot;1&quot;,&quot;bioMetaInfo&quot;: &quot;4.1.0:1150****,0&quot;,&quot;appName&quot;: &quot;com.aliyun.antcloudauth&quot;,&quot;deviceType&quot;: &quot;ios&quot;,&quot;osVersion&quot;: &quot;iOS 10.3.2&quot;,&quot;apdidToken&quot;: &quot;&quot;,&quot;deviceModel&quot;: &quot;iPhone9,1&quot;}</para>
        /// </summary>
        [NameInMap("MetaInfo")]
        [Validation(Required=false)]
        public string MetaInfo { get; set; }

        /// <summary>
        /// <para>The verification mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OCR_VERIFY: OCR recognition and authentication mode.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OCR_VERIFY</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>Specifies whether to temporarily store images collected by the app. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Y: Yes.</description></item>
        /// <item><description>N: No.</description></item>
        /// <item><description>If you set this parameter to Y, the query operation returns card image information.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("PictureSave")]
        [Validation(Required=false)]
        public string PictureSave { get; set; }

        /// <summary>
        /// <para>The verification type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ID_2_META: two-factor identity verification (name + ID card number).</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ID_2_META</para>
        /// </summary>
        [NameInMap("VerifyMeta")]
        [Validation(Required=false)]
        public string VerifyMeta { get; set; }

    }

}
