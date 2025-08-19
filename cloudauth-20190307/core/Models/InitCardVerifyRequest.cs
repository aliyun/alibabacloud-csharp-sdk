// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class InitCardVerifyRequest : TeaModel {
        /// <summary>
        /// <para>Security Token, used for anti-replay and anti-tampering checks. If this parameter is passed, the CallbackToken field will be displayed in the callback address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NMjvQanQgplBSaEI0sL86WnQplB</para>
        /// </summary>
        [NameInMap("CallbackToken")]
        [Validation(Required=false)]
        public string CallbackToken { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>The callback notification address for the authentication result, which must start with https.</description></item>
        /// <item><description>The platform will call back this address after completing the authentication and automatically add the certifyId and passed fields, example: <a href="https://www.aliyun.com?certifyId=xxxx&passed=T">https://www.aliyun.com?certifyId=xxxx&amp;passed=T</a></description></item>
        /// <item><description>Warning
        /// The callback is triggered only when the authentication is completed. If the authentication is abandoned, interrupted abnormally, or not performed, no notification will be sent. It is recommended that when you receive the callback notification, if necessary, you can obtain detailed authentication information through the query interface.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.aliyun.com">https://www.aliyun.com</a></para>
        /// </summary>
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// <para>Number of card pages collected by the SDK</para>
        /// <list type="bullet">
        /// <item><description><para>You can input 1 or 2; input 1 to collect the front side, input 2 to collect both the front and back sides.</para>
        /// </description></item>
        /// <item><description><para>If the verification type is ID period (VerifyMeta value is ID_PERIOD), you must input 2.</para>
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
        /// <para>Type of identification</para>
        /// <list type="bullet">
        /// <item><description>Resident Second Generation ID Card: IDENTITY_CARD</description></item>
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
        /// <para>Enumeration of photo-taking methods (manual/auto)</para>
        /// <list type="bullet">
        /// <item><description>Take a photo: shoot</description></item>
        /// <item><description>Scan: scan </description></item>
        /// <item><description>Auto switch: auto</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>shoot</para>
        /// </summary>
        [NameInMap("DocScanMode")]
        [Validation(Required=false)]
        public string DocScanMode { get; set; }

        /// <summary>
        /// <para>A unique business identifier you define, used for subsequent troubleshooting.
        /// Supports a combination of 32 alphanumeric characters, please ensure uniqueness.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e0c34a77f5ac40a5aa5e6ed20c35****</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <para>MetaInfo environment parameter, which needs to be obtained through the client SDK.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;zimVer&quot;:&quot;3.0.0&quot;,&quot;appVersion&quot;: &quot;1&quot;,&quot;bioMetaInfo&quot;: &quot;4.1.0:1150****,0&quot;,&quot;appName&quot;: &quot;com.aliyun.antcloudauth&quot;,&quot;deviceType&quot;: &quot;ios&quot;,&quot;osVersion&quot;: &quot;iOS 10.3.2&quot;,&quot;apdidToken&quot;: &quot;&quot;,&quot;deviceModel&quot;: &quot;iPhone9,1&quot;}</para>
        /// </summary>
        [NameInMap("MetaInfo")]
        [Validation(Required=false)]
        public string MetaInfo { get; set; }

        /// <summary>
        /// <para>Verification method, value:</para>
        /// <list type="bullet">
        /// <item><description>OCR_VERIFY: OCR recognition and verification mode.</description></item>
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
        /// <para>Whether to temporarily store the images collected by the app.</para>
        /// <list type="bullet">
        /// <item><description>Y: Yes</description></item>
        /// <item><description>N: No</description></item>
        /// <item><description>If \&quot;Yes\&quot; is selected here, the query interface will support returning the card image information.</description></item>
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
        /// <para>Verification type, value:</para>
        /// <list type="bullet">
        /// <item><description>Identity two elements (name + ID number): ID_2_META</description></item>
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
