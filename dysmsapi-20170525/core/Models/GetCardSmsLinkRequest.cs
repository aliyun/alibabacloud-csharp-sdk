// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class GetCardSmsLinkRequest : TeaModel {
        /// <summary>
        /// <para>The encoding type of the short URL for the card message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: bulk sending.</description></item>
        /// <item><description>2: personalized.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CardCodeType")]
        [Validation(Required=false)]
        public int? CardCodeType { get; set; }

        /// <summary>
        /// <para>The type of the short URL for the card message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: standard short URL.</description></item>
        /// <item><description>2: custom short URL.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If <b>CardLinkType</b> is left empty, the default value is standard short URL. To generate a custom short URL, contact Alibaba Cloud operations to register in advance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CardLinkType")]
        [Validation(Required=false)]
        public int? CardLinkType { get; set; }

        /// <summary>
        /// <para>The code of the card message template. In the console, go to the <a href="https://dysms.console.aliyun.com/domestic/card">Card Messages &gt; Template Management</a> page and select the code of an approved card message template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CARD_SMS_****</para>
        /// </summary>
        [NameInMap("CardTemplateCode")]
        [Validation(Required=false)]
        public string CardTemplateCode { get; set; }

        /// <summary>
        /// <para>The variables of the card message template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;customUrl\&quot;:\&quot;<a href="https://alibaba.com%5C%5C%22,%5C%5C%22dyncParams%5C%5C">https://alibaba.com\\&quot;,\\&quot;dyncParams\\</a>&quot;: \&quot;{\\\&quot;动参key\\\&quot;:\\\&quot;动参value\\\&quot;}\&quot;},{\&quot;customUrl\&quot;:\&quot;<a href="https://alibaba.com%5C%5C%22,%5C%5C%22dyncParams%5C%5C">https://alibaba.com\\&quot;,\\&quot;dyncParams\\</a>&quot;: \&quot;{\\\&quot;动参key\\\&quot;:\\\&quot;动参value\\\&quot;}\&quot;}]</para>
        /// </summary>
        [NameInMap("CardTemplateParamJson")]
        [Validation(Required=false)]
        public string CardTemplateParamJson { get; set; }

        /// <summary>
        /// <para>The custom short code. The value must be 4 to 8 digits or letters.</para>
        /// <remarks>
        /// <para>This parameter is required when the generation type is custom short URL.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>abCde</para>
        /// </summary>
        [NameInMap("CustomShortCodeJson")]
        [Validation(Required=false)]
        public string CustomShortCodeJson { get; set; }

        /// <summary>
        /// <para>The short URL domain assigned to the sending account. The domain must be registered in advance.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>When <b>CardLinkType</b> is set to <b>2</b>, the <b>Domain</b> parameter is required.</description></item>
        /// <item><description>If the <b>Domain</b> parameter is left empty, the system default domain is used. The value can be up to 100 characters in length.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>xxx.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The external extension field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BC20220608102511660860762****</para>
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        /// <summary>
        /// <para>The phone number, user ID, or internal system identifier.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Supports up to 10,000 phone numbers.</description></item>
        /// <item><description>You can also specify a custom identifier of up to 60 characters.</description></item>
        /// <item><description>For OPPO templates, you can submit up to 10 requests at a time.</description></item>
        /// </list>
        /// </remarks>
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
        /// <para>The signature name of the SMS message.
        /// In the console, go to the <a href="https://dysms.console.aliyun.com/domestic/text/sign">Domestic Messages &gt; Signature Management</a> tab and view the name in the <b>Signature Name</b> column. You can also call the <a href="https://www.alibabacloud.com/help/en/sms/developer-reference/api-dysmsapi-2017-05-25-querysmssignlist">QuerySmsSignList</a> operation to view SMS signature names.</para>
        /// <remarks>
        /// <para>The signature must be added and approved. The number of SMS signatures must match the number of phone numbers, and each signature must correspond to a phone number.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;阿里云\&quot;, \&quot;阿里云2\&quot;]</para>
        /// </summary>
        [NameInMap("SignNameJson")]
        [Validation(Required=false)]
        public string SignNameJson { get; set; }

    }

}
