// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class CredentialVerifyRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>4601*****</para>
        /// </summary>
        [NameInMap("CertNum")]
        [Validation(Required=false)]
        public string CertNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0104</para>
        /// </summary>
        [NameInMap("CredName")]
        [Validation(Required=false)]
        public string CredName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>01</para>
        /// </summary>
        [NameInMap("CredType")]
        [Validation(Required=false)]
        public string CredType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>429001********8211</para>
        /// </summary>
        [NameInMap("IdentifyNum")]
        [Validation(Required=false)]
        public string IdentifyNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>base64</para>
        /// </summary>
        [NameInMap("ImageContext")]
        [Validation(Required=false)]
        public string ImageContext { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://marry.momocdn.com/avatar/3B/B6/3BB6527E-7467-926E-1048-B43614F20CC420230803_L.jpg">http://marry.momocdn.com/avatar/3B/B6/3BB6527E-7467-926E-1048-B43614F20CC420230803_L.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IsCheck")]
        [Validation(Required=false)]
        public string IsCheck { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsOCR")]
        [Validation(Required=false)]
        public string IsOCR { get; set; }

        [NameInMap("MerchantDetail")]
        [Validation(Required=false)]
        public List<CredentialVerifyRequestMerchantDetail> MerchantDetail { get; set; }
        public class CredentialVerifyRequestMerchantDetail : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("MerchantId")]
        [Validation(Required=false)]
        public string MerchantId { get; set; }

        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        [NameInMap("PromptModel")]
        [Validation(Required=false)]
        public string PromptModel { get; set; }

        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
