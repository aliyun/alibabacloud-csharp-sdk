// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class CreateDigitalSignOrderRequest : TeaModel {
        /// <summary>
        /// <para>Reserved for future use.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("ExtendMessage")]
        [Validation(Required=false)]
        public string ExtendMessage { get; set; }

        /// <summary>
        /// <para>The qualification information. This object is required when you create a signature, or when you update a signature\&quot;s qualification information.</para>
        /// <list type="bullet">
        /// <item><description><para>qualificationCompanyName: Company name. The name can be up to 150 characters long. It cannot consist of only digits or contain symbols other than the middle dot (·), Chinese brackets (【】), Chinese parentheses (（）), English parentheses (()), and spaces.</para>
        /// </description></item>
        /// <item><description><para><c>qualificationOrganizationCode</c>: The 18-character Unified Social Credit Identifier (USCI). It must be an 18-digit code or a code that consists of 18 uppercase or lowercase letters and digits.</para>
        /// </description></item>
        /// <item><description><para><c>qualificationAdminName</c>: The name of the agent or legal representative. The name must be in Chinese.</para>
        /// </description></item>
        /// <item><description><para><c>qualificationAdminIDCard</c>: The 18-digit ID card number of the agent. Only PRC ID cards are supported.</para>
        /// </description></item>
        /// <item><description><para><c>qualificationLegalPersonName</c>: The name of the legal representative or agent.</para>
        /// </description></item>
        /// <item><description><para><c>qualificationLegalPersonIDCard</c>: The 18-digit ID card number of the legal representative. Only PRC ID cards are supported.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;qualificationCompanyName&quot;: &quot;阿里阿巴&quot;,
        ///   &quot;qualificationOrganizationCode&quot;: &quot;91330106MA2A0XABCD&quot;,
        ///   &quot;qualificationLegalPersonName&quot;: &quot;张三&quot;,
        ///   &quot;qualificationLegalPersonIDCard&quot;: &quot;110105199001011234&quot;,
        ///   &quot;qualificationAdminName&quot;: &quot;李四&quot;,
        ///   &quot;qualificationAdminIDCard&quot;: &quot;11010519900101****&quot;
        /// }</para>
        /// </summary>
        [NameInMap("OrderContext")]
        [Validation(Required=false)]
        public Dictionary<string, object> OrderContext { get; set; }

        /// <summary>
        /// <para>The operation to perform on the signature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>UPDATE_DIGITALSMS_SIGN</c>: Update a signature.</para>
        /// </description></item>
        /// <item><description><para><c>DELETE_DIGITALSMS_SIGN</c>: Delete a signature.</para>
        /// </description></item>
        /// <item><description><para><c>CREATE_DIGITALSMS_SIGN</c>: Create a signature.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CREATE_DIGITALSMS_SIGN</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the qualification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>41</para>
        /// </summary>
        [NameInMap("QualificationId")]
        [Validation(Required=false)]
        public long? QualificationId { get; set; }

        /// <summary>
        /// <para>The version of the qualification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>49</para>
        /// </summary>
        [NameInMap("QualificationVersion")]
        [Validation(Required=false)]
        public long? QualificationVersion { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The unique ID of the signature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("SignId")]
        [Validation(Required=false)]
        public long? SignId { get; set; }

        /// <summary>
        /// <para>The industry type. This parameter is required when you create or update a signature. It is optional when you delete a signature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>0</c>: General (GENERAL)</para>
        /// </description></item>
        /// <item><description><para><c>1</c>: E-commerce and retail (ECOMMERCE)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SignIndustry")]
        [Validation(Required=false)]
        public long? SignIndustry { get; set; }

        /// <summary>
        /// <para>The signature name. This parameter is required for creating, updating, and deleting signatures.</para>
        /// <ol>
        /// <item><description><para>The name must be 2 to 16 characters in length.</para>
        /// </description></item>
        /// <item><description><para>The name can contain Chinese characters, letters, and digits.</para>
        /// </description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description><para>Special characters are not allowed, including $, &amp;, %, #, @, !, ^, \*, (, ), _, +, -, =, {, }, [, ], |, ;, :, \&quot;, &quot;, &lt;, &gt;, ,, ., /, ?, \~, and .</para>
        /// </description></item>
        /// <item><description><para>The name cannot be only letters.</para>
        /// </description></item>
        /// <item><description><para>The name cannot be only digits. Spaces are not allowed.</para>
        /// </description></item>
        /// <item><description><para>Emojis are not allowed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>阿里云商城</para>
        /// </summary>
        [NameInMap("SignName")]
        [Validation(Required=false)]
        public string SignName { get; set; }

        /// <summary>
        /// <para>The signature source. This parameter is required when you create or update a signature. It is optional when you delete a signature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>0</c>: Enterprises and public institutions</para>
        /// </description></item>
        /// <item><description><para><c>2</c>: App</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SignSource")]
        [Validation(Required=false)]
        public long? SignSource { get; set; }

        /// <summary>
        /// <para>The ID of the user who submits the order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>110000001750080</para>
        /// </summary>
        [NameInMap("Submitter")]
        [Validation(Required=false)]
        public string Submitter { get; set; }

    }

}
