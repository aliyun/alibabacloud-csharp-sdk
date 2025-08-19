// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class CredentialVerifyV2AdvanceRequest : TeaModel {
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
        /// <item><description>0101: ID card</description></item>
        /// <item><description>0102: Bank card</description></item>
        /// <item><description>0104: Teacher qualification certificate</description></item>
        /// <item><description>0107: Student ID card</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>02: Business scenario<list type="bullet">
        /// <item><description>0201: Storefront photo</description></item>
        /// <item><description>0202: Counter photo</description></item>
        /// <item><description>0203: Scene photo</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>03: Corporate qualifications<list type="bullet">
        /// <item><description>0301: Business license</description></item>
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
        /// <para>ID number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4****************1</para>
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
        /// <para>Image input stream, choose one from <c>imageUrl</c>, <c>imageFile</c>, or <c>imageContext</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("ImageFile")]
        [Validation(Required=false)]
        public Stream ImageFileObject { get; set; }

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
        /// <para>Whether to use OCR</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IsOcr")]
        [Validation(Required=false)]
        public string IsOcr { get; set; }

        /// <summary>
        /// <para>Merchant details:</para>
        /// <para>MerchantName: Merchant name</para>
        /// <para>BusinessType: Industry information</para>
        /// <para>BusinessContent: Business content</para>
        /// <para>This field is required when PromptModel is set to DEFAULT.</para>
        /// </summary>
        [NameInMap("MerchantDetail")]
        [Validation(Required=false)]
        public List<CredentialVerifyV2AdvanceRequestMerchantDetail> MerchantDetail { get; set; }
        public class CredentialVerifyV2AdvanceRequestMerchantDetail : TeaModel {
            /// <summary>
            /// <para>Keyword key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MerchantName</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>Keyword value.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Merchant ID. This field is required when <b><b>CredName</b></b> is set to <b>02</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("MerchantId")]
        [Validation(Required=false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// <para>Invocation mode:</para>
        /// <list type="bullet">
        /// <item><description><para>ANTI_FAKE_CHECK: Image anti-forgery check</para>
        /// </description></item>
        /// <item><description><para>ANTI_FAKE_VL: Image anti-forgery check and semantic understanding</para>
        /// </description></item>
        /// <item><description><para>IMAGE_VL_COG: Image semantic understanding</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: ANTI_FAKE_CHECK</para>
        /// <para>When CredType is set to 02, ProductCode can only be ANTI_FAKE_VL or IMAGE_VL_COG.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ANTI_FAKE_CHECK</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>Customer-defined prompt content for image semantic understanding.</para>
        /// <para>This field is required when PromptModel is set to CUSTOM.</para>
        /// 
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <para>Prompt acquisition method for image semantic understanding:</para>
        /// <list type="bullet">
        /// <item><description><para>DEFAULT: System default</para>
        /// </description></item>
        /// <item><description><para>CUSTOM: Customer-defined</para>
        /// </description></item>
        /// </list>
        /// <para>Note: When ProductCode is set to ANTI_FAKE_VL or IMAGE_VL_COG, this parameter must be provided.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DEFAULT</para>
        /// </summary>
        [NameInMap("PromptModel")]
        [Validation(Required=false)]
        public string PromptModel { get; set; }

        /// <summary>
        /// <para>Name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
