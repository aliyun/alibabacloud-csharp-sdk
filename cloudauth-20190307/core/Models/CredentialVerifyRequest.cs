// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class CredentialVerifyRequest : TeaModel {
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
        /// <item><description>01: personal card and certificate<list type="bullet">
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
        /// <item><description>01: personal card and certificate</description></item>
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
        /// <para>429001********8211</para>
        /// </summary>
        [NameInMap("IdentifyNum")]
        [Validation(Required=false)]
        public string IdentifyNum { get; set; }

        /// <summary>
        /// <para>The Base64-encoded image. Specify either imageUrl or imageContext.</para>
        /// 
        /// <b>Example:</b>
        /// <para>base64</para>
        /// </summary>
        [NameInMap("ImageContext")]
        [Validation(Required=false)]
        public string ImageContext { get; set; }

        /// <summary>
        /// <para>The image URL. Specify either imageUrl or imageContext.</para>
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
        /// <item><description><b>1</b>: Enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IsCheck")]
        [Validation(Required=false)]
        public string IsCheck { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable optical character recognition (OCR). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Disabled.</description></item>
        /// <item><description><b>1</b>: Enabled.</description></item>
        /// </list>
        /// <para>You can set <b>isOCR</b> to <b>1</b> only when <b>CredType</b> is set to <b>01</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsOCR")]
        [Validation(Required=false)]
        public string IsOCR { get; set; }

        /// <summary>
        /// <para>This parameter is required when PromptModel is set to DEFAULT.</para>
        /// </summary>
        [NameInMap("MerchantDetail")]
        [Validation(Required=false)]
        public List<CredentialVerifyRequestMerchantDetail> MerchantDetail { get; set; }
        public class CredentialVerifyRequestMerchantDetail : TeaModel {
            /// <summary>
            /// <para>The replacement keyword key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>keyword</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The replacement keyword value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>关键字</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The merchant ID. This parameter is required when <b>CredName</b> is set to <b>02</b>.</para>
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
        /// <item><description><para>ANTI_FAKE_CHECK: image anti-forgery detection.</para>
        /// </description></item>
        /// <item><description><para>ANTI_FAKE_VL: image anti-forgery detection and semantic understanding.</para>
        /// </description></item>
        /// <item><description><para>IMAGE_VL_COG: image semantic understanding.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: ANTI_FAKE_CHECK.</para>
        /// <para>ProductCode can be set to ANTI_FAKE_VL or IMAGE_VL_COG only when CredType is set to 02.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ANTI_FAKE_CHECK</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The custom prompt content for image semantic understanding.</para>
        /// <para>This parameter is required when PromptModel is set to CUSTOM.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <para>The method to obtain the prompt for image semantic understanding. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>DEFAULT: system default.</para>
        /// </description></item>
        /// <item><description><para>CUSTOM: custom.</para>
        /// </description></item>
        /// </list>
        /// <para>Note: This parameter is required when ProductCode is set to ANTI_FAKE_VL or IMAGE_VL_COG.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DEFAULT</para>
        /// </summary>
        [NameInMap("PromptModel")]
        [Validation(Required=false)]
        public string PromptModel { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张*</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
