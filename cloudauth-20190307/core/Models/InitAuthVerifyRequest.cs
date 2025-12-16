// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class InitAuthVerifyRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>NMjvQanQgplBSaEI0sL86WnQplB</para>
        /// </summary>
        [NameInMap("CallbackToken")]
        [Validation(Required=false)]
        public string CallbackToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://www.aliyun.com?callbackToken=100000****&certifyId=shaxxxx&subCode=200">https://www.aliyun.com?callbackToken=100000****&amp;certifyId=shaxxxx&amp;subCode=200</a></para>
        /// </summary>
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CardPageNumber")]
        [Validation(Required=false)]
        public string CardPageNumber { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IDENTITY_CARD</para>
        /// </summary>
        [NameInMap("CardType")]
        [Validation(Required=false)]
        public string CardType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>shoot</para>
        /// </summary>
        [NameInMap("DocScanMode")]
        [Validation(Required=false)]
        public string DocScanMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("IdSpoof")]
        [Validation(Required=false)]
        public string IdSpoof { get; set; }

        /// <summary>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e0c34a77f5ac40a5aa5e6ed20c******</para>
        /// </summary>
        [NameInMap("OuterOrderNo")]
        [Validation(Required=false)]
        public string OuterOrderNo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ID_OCR</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
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
