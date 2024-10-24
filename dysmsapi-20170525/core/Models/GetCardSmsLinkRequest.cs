// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class GetCardSmsLinkRequest : TeaModel {
        /// <summary>
        /// <para>The code type of the URLs.</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: group texting</description></item>
        /// <item><description><b>2</b>: personalization</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CardCodeType")]
        [Validation(Required=false)]
        public int? CardCodeType { get; set; }

        /// <summary>
        /// <para>The type of the short URLs.</para>
        /// <list type="bullet">
        /// <item><description>1: standard short code.</description></item>
        /// <item><description>2: custom short code.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If the <b>CardLinkType</b> is not specified, standard short codes are generated. If you need to generate custom short codes, contact Alibaba Cloud SMS technical support.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CardLinkType")]
        [Validation(Required=false)]
        public int? CardLinkType { get; set; }

        /// <summary>
        /// <para>The code of the message template. You can view the template code in the <b>Template Code</b> column on the <b>Templates</b> tab of the <b>Go China</b> page in the Alibaba Cloud SMS console.</para>
        /// <remarks>
        /// <para>Make sure that the message template has been approved.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CARD_SMS_****</para>
        /// </summary>
        [NameInMap("CardTemplateCode")]
        [Validation(Required=false)]
        public string CardTemplateCode { get; set; }

        /// <summary>
        /// <para>The variables of the message template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{},{}]</para>
        /// </summary>
        [NameInMap("CardTemplateParamJson")]
        [Validation(Required=false)]
        public string CardTemplateParamJson { get; set; }

        /// <summary>
        /// <para>The custom short code. It can contain 4 to 8 digits or letters.</para>
        /// <remarks>
        /// <para>If the CardLinkType parameter is set to 2, the CustomShortCodeJson parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>abCde</para>
        /// </summary>
        [NameInMap("CustomShortCodeJson")]
        [Validation(Required=false)]
        public string CustomShortCodeJson { get; set; }

        /// <summary>
        /// <para>The original domain name. You must submit domain names for approval in advance.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If the <b>CardLinkType</b> parameter is set to <b>2</b>, the <b>Domain</b> parameter is required.</para>
        /// </description></item>
        /// <item><description><para>The <b>Domain</b> parameter cannot exceed 100 characters in length. If the parameter is not specified, a default domain name is used.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>xxx.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The extension field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BC20220608102511660860762****</para>
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        /// <summary>
        /// <para>The mobile phone numbers of recipients, custom identifiers, or system identifiers.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>A maximum of 10,000 mobile phone numbers are supported.</para>
        /// </description></item>
        /// <item><description><para>You can enter custom identifier. Each identifier can be a maximum of 60 characters in length.</para>
        /// </description></item>
        /// <item><description><para>You can apply for a maximum of 10 OPPO templates at a time.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;1390000****
        /// \&quot;,\&quot;1370000****
        /// \&quot;]</para>
        /// </summary>
        [NameInMap("PhoneNumberJson")]
        [Validation(Required=false)]
        public string PhoneNumberJson { get; set; }

        /// <summary>
        /// <para>The signature. You can view the template code in the <b>Signature</b> column on the <b>Signaturess</b> tab of the <b>Go China</b> page in the Alibaba Cloud SMS console.</para>
        /// <remarks>
        /// <para>The signatures must be approved and correspond to the mobile numbers in sequence.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;aliyun\&quot;, \&quot;aliyun2\&quot;]</para>
        /// </summary>
        [NameInMap("SignNameJson")]
        [Validation(Required=false)]
        public string SignNameJson { get; set; }

    }

}
