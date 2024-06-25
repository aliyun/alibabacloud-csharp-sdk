// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class GetCardSmsLinkRequest : TeaModel {
        /// <summary>
        /// The code type of the URLs.
        /// 
        /// *   **1**: group texting
        /// *   **2**: personalization
        /// </summary>
        [NameInMap("CardCodeType")]
        [Validation(Required=false)]
        public int? CardCodeType { get; set; }

        /// <summary>
        /// The type of the short URLs.
        /// 
        /// *   1: standard short code.
        /// *   2: custom short code.
        /// 
        /// > If the **CardLinkType** is not specified, standard short codes are generated. If you need to generate custom short codes, contact Alibaba Cloud SMS technical support.
        /// </summary>
        [NameInMap("CardLinkType")]
        [Validation(Required=false)]
        public int? CardLinkType { get; set; }

        /// <summary>
        /// The code of the message template. You can view the template code in the **Template Code** column on the **Templates** tab of the **Go China** page in the Alibaba Cloud SMS console.
        /// 
        /// > Make sure that the message template has been approved.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CardTemplateCode")]
        [Validation(Required=false)]
        public string CardTemplateCode { get; set; }

        /// <summary>
        /// The variables of the message template.
        /// </summary>
        [NameInMap("CardTemplateParamJson")]
        [Validation(Required=false)]
        public string CardTemplateParamJson { get; set; }

        /// <summary>
        /// The custom short code. It can contain 4 to 8 digits or letters.
        /// 
        /// > If the CardLinkType parameter is set to 2, the CustomShortCodeJson parameter is required.
        /// </summary>
        [NameInMap("CustomShortCodeJson")]
        [Validation(Required=false)]
        public string CustomShortCodeJson { get; set; }

        /// <summary>
        /// The original domain name. You must submit domain names for approval in advance.
        /// 
        /// > 
        /// 
        /// *   If the **CardLinkType** parameter is set to **2**, the **Domain** parameter is required.
        /// 
        /// *   The **Domain** parameter cannot exceed 100 characters in length. If the parameter is not specified, a default domain name is used.
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// The extension field.
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        /// <summary>
        /// The mobile phone numbers of recipients, custom identifiers, or system identifiers.
        /// 
        /// > 
        /// 
        /// *   A maximum of 10,000 mobile phone numbers are supported.
        /// 
        /// *   You can enter custom identifier. Each identifier can be a maximum of 60 characters in length.
        /// 
        /// *   You can apply for a maximum of 10 OPPO templates at a time.
        /// </summary>
        [NameInMap("PhoneNumberJson")]
        [Validation(Required=false)]
        public string PhoneNumberJson { get; set; }

        /// <summary>
        /// The signature. You can view the template code in the **Signature** column on the **Signaturess** tab of the **Go China** page in the Alibaba Cloud SMS console.
        /// 
        /// > The signatures must be approved and correspond to the mobile numbers in sequence.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SignNameJson")]
        [Validation(Required=false)]
        public string SignNameJson { get; set; }

    }

}
