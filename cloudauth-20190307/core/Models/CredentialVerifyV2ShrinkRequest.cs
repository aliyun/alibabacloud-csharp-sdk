// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class CredentialVerifyV2ShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The certificate number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4601*****</para>
        /// </summary>
        [NameInMap("CertNum")]
        [Validation(Required=false)]
        public string CertNum { get; set; }

        /// <summary>
        /// <para>The credential name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>01: personal card or certificate<list type="bullet">
        /// <item><description>0101: ID card</description></item>
        /// <item><description>0102: bank card</description></item>
        /// <item><description>0104: teacher qualification certificate</description></item>
        /// <item><description>0107: student ID card</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>02: business scenario<list type="bullet">
        /// <item><description>0201: storefront photo</description></item>
        /// <item><description>0202: counter photo</description></item>
        /// <item><description>0203: scene photo</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>03: enterprise qualification<list type="bullet">
        /// <item><description>0301: business license.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0104</para>
        /// </summary>
        [NameInMap("CredName")]
        [Validation(Required=false)]
        public string CredName { get; set; }

        /// <summary>
        /// <para>The credential type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>01: personal card or certificate</description></item>
        /// <item><description>02: business scenario</description></item>
        /// <item><description>03: enterprise qualification.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>01</para>
        /// </summary>
        [NameInMap("CredType")]
        [Validation(Required=false)]
        public string CredType { get; set; }

        /// <summary>
        /// <para>The ID card number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4****************1</para>
        /// </summary>
        [NameInMap("IdentifyNum")]
        [Validation(Required=false)]
        public string IdentifyNum { get; set; }

        /// <summary>
        /// <para>The Base64-encoded image. Specify one of imageUrl, imageFile, or imageContext.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("ImageContext")]
        [Validation(Required=false)]
        public string ImageContext { get; set; }

        /// <summary>
        /// <para>The input stream of the image. Specify one of imageUrl, imageFile, or imageContext.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("ImageFile")]
        [Validation(Required=false)]
        public string ImageFile { get; set; }

        /// <summary>
        /// <para>The URL of the image. Specify one of imageUrl, imageFile, or imageContext.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://marry.momocdn.com/avatar/3B/B6/3BB6527E-7467-926E-1048-B43614F20CC420230803_L.jpg">http://marry.momocdn.com/avatar/3B/B6/3BB6527E-7467-926E-1048-B43614F20CC420230803_L.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable authoritative verification. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Disabled.</description></item>
        /// <item><description><b>1</b>: Enabled.<remarks>
        /// <para>Danger: Deprecated.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IsCheck")]
        [Validation(Required=false)]
        public string IsCheck { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable OCR.</para>
        /// <remarks>
        /// <para>Danger: Deprecated.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IsOcr")]
        [Validation(Required=false)]
        public string IsOcr { get; set; }

        /// <summary>
        /// <para>This feature is offline. This parameter no longer takes effect.</para>
        /// </summary>
        [NameInMap("MerchantDetail")]
        [Validation(Required=false)]
        public string MerchantDetailShrink { get; set; }

        /// <summary>
        /// <para>The merchant ID. This parameter is required when CredName is set to 02.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无。</para>
        /// </summary>
        [NameInMap("MerchantId")]
        [Validation(Required=false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// <para>The call mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ANTI_FAKE_CHECK (default): image anti-forgery detection.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ANTI_FAKE_CHECK</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>This feature is offline. This parameter no longer takes effect.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <para>This feature is offline. This parameter no longer takes effect.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("PromptModel")]
        [Validation(Required=false)]
        public string PromptModel { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
