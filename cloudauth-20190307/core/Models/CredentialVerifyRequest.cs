// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class CredentialVerifyRequest : TeaModel {
        /// <summary>
        /// <para>Relevant certificate number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4601*****</para>
        /// </summary>
        [NameInMap("CertNum")]
        [Validation(Required=false)]
        public string CertNum { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>01: Personal ID cards<list type="bullet">
        /// <item><description><b>0101</b>: ID card</description></item>
        /// <item><description><b>0102</b>: Bank card</description></item>
        /// <item><description><b>0104</b>: Teacher qualification certificate</description></item>
        /// <item><description><b>0107</b>: Student ID card</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>02: Business scenario<list type="bullet">
        /// <item><description><b>0201</b>: Storefront photo</description></item>
        /// <item><description><b>0202</b>: Counter photo</description></item>
        /// <item><description><b>0203</b>: Scene photo</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>03: Corporate qualifications<list type="bullet">
        /// <item><description><b>0301</b>: Business license</description></item>
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
        /// <para>Credential type:</para>
        /// <list type="bullet">
        /// <item><description>01: Personal ID cards</description></item>
        /// <item><description>02: Business scenario</description></item>
        /// <item><description>03: Corporate qualifications</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>01</para>
        /// </summary>
        [NameInMap("CredType")]
        [Validation(Required=false)]
        public string CredType { get; set; }

        /// <summary>
        /// <para>ID number:</para>
        /// <para>Note
        /// Only supports the ID numbers of second-generation resident IDs and Hong Kong, Macao, and Taiwan residence permits.</para>
        /// <list type="bullet">
        /// <item><description><para>When paramType is normal: enter the plaintext ID number.</para>
        /// </description></item>
        /// <item><description><para>When paramType is md5: first 6 digits of the ID number (plaintext) + date of birth (ciphertext) + last 4 digits of the ID number (plaintext).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>429001********8211</para>
        /// </summary>
        [NameInMap("IdentifyNum")]
        [Validation(Required=false)]
        public string IdentifyNum { get; set; }

        /// <summary>
        /// <para>Base64 encoded image, choose one from <c>imageUrl</c>, <c>imageFile</c>, or <c>imageContext</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>base64</para>
        /// </summary>
        [NameInMap("ImageContext")]
        [Validation(Required=false)]
        public string ImageContext { get; set; }

        /// <summary>
        /// <para>Image URL, choose one from <c>imageUrl</c>, <c>imageFile</c>, or <c>imageContext</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://marry.momocdn.com/avatar/3B/B6/3BB6527E-7467-926E-1048-B43614F20CC420230803_L.jpg">http://marry.momocdn.com/avatar/3B/B6/3BB6527E-7467-926E-1048-B43614F20CC420230803_L.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>Whether to enable authoritative authentication</para>
        /// <list type="bullet">
        /// <item><description><b><b>0</b></b>: No</description></item>
        /// <item><description><b>1</b>: Yes</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IsCheck")]
        [Validation(Required=false)]
        public string IsCheck { get; set; }

        /// <summary>
        /// <para>Whether to enable OCR recognition.</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: No</description></item>
        /// <item><description><b>1</b>: Yes</description></item>
        /// </list>
        /// <remarks>
        /// <para>IsOCR can be set to 1 only when <b>CredType</b> is 01.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsOCR")]
        [Validation(Required=false)]
        public string IsOCR { get; set; }

        /// <summary>
        /// <para>Merchant details:</para>
        /// <remarks>
        /// <para>This field is required when PromptModel is set to DEFAULT.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("MerchantDetail")]
        [Validation(Required=false)]
        public List<CredentialVerifyRequestMerchantDetail> MerchantDetail { get; set; }
        public class CredentialVerifyRequestMerchantDetail : TeaModel {
            /// <summary>
            /// <para>The private key of the certificate.</para>
            /// <remarks>
            /// <para> If this parameter is specified, you must also specify <b>CertName</b> and <b>Cert</b>. If <b>CertName</b>, <b>Cert</b>, and <b>Key</b> are specified, you do not need to specify <b>CertId</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>keyword</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>Keyword value.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Merchant ID. </para>
        /// <remarks>
        /// <para>This field is required when <b><b>CredName</b></b> is set to <b>02</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>913100********KW8P</para>
        /// </summary>
        [NameInMap("MerchantId")]
        [Validation(Required=false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// <para>Invocation mode:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ANTI_FAKE_CHECK</b>: Image anti-forgery check</para>
        /// </description></item>
        /// <item><description><para><b>ANTI_FAKE_VL</b>: Image anti-forgery check and semantic understanding</para>
        /// </description></item>
        /// <item><description><para><b>IMAGE_VL_COG</b>: Image semantic understanding</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: ANTI_FAKE_CHECK</para>
        /// <remarks>
        /// <para>When <b>CredType</b> is set to 02, <b>ProductCode</b> can only be ANTI_FAKE_VL or IMAGE_VL_COG.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ANTI_FAKE_CHECK</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>Customer-defined prompt content for image semantic understanding.</para>
        /// <remarks>
        /// <para>This field is required when PromptModel is set to CUSTOM.</para>
        /// </remarks>
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
        /// <para>Prompt acquisition method for image semantic understanding:</para>
        /// <list type="bullet">
        /// <item><description><para><b>DEFAULT</b>: System default</para>
        /// </description></item>
        /// <item><description><para><b>CUSTOM</b>: Customer-defined</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>When <b>ProductCode</b> is set to <b>ANTI_FAKE_VL</b> or <b>IMAGE_VL_COG</b>, this parameter must be provided.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>DEFAULT</para>
        /// </summary>
        [NameInMap("PromptModel")]
        [Validation(Required=false)]
        public string PromptModel { get; set; }

        /// <summary>
        /// <para>UserName</para>
        /// 
        /// <b>Example:</b>
        /// <para>张*</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
