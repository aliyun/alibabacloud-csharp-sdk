// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class VerifyContactFieldRequest : TeaModel {
        /// <summary>
        /// <para>Street address (in English).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Rd. xitucheng</para>
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <para>City (in English).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Bei jing</para>
        /// </summary>
        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// <para>Country code, such as <b>CN</b> or <b>US</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CN</para>
        /// </summary>
        [NameInMap("Country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        /// <summary>
        /// <para>Domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>Email address.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:username@example.com">username@example.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>Language of the error message returned by the API. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese.  </description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// <para>Default value: <b>en</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Postal code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100000</para>
        /// </summary>
        [NameInMap("PostalCode")]
        [Validation(Required=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// <para>Province (in English).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Bei jing</para>
        /// </summary>
        [NameInMap("Province")]
        [Validation(Required=false)]
        public string Province { get; set; }

        /// <summary>
        /// <para>Contact name (in English).</para>
        /// 
        /// <b>Example:</b>
        /// <para>wang xian sheng</para>
        /// </summary>
        [NameInMap("RegistrantName")]
        [Validation(Required=false)]
        public string RegistrantName { get; set; }

        /// <summary>
        /// <para>Registrant name (in English).</para>
        /// 
        /// <b>Example:</b>
        /// <para>wang xian sheng</para>
        /// </summary>
        [NameInMap("RegistrantOrganization")]
        [Validation(Required=false)]
        public string RegistrantOrganization { get; set; }

        /// <summary>
        /// <para>Registrant type. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Individual.  </description></item>
        /// <item><description><b>2</b>: Enterprise.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RegistrantType")]
        [Validation(Required=false)]
        public string RegistrantType { get; set; }

        /// <summary>
        /// <para>Telephone country code, for example, <b>86</b> for China.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86</para>
        /// </summary>
        [NameInMap("TelArea")]
        [Validation(Required=false)]
        public string TelArea { get; set; }

        /// <summary>
        /// <para>Extension number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01</para>
        /// </summary>
        [NameInMap("TelExt")]
        [Validation(Required=false)]
        public string TelExt { get; set; }

        /// <summary>
        /// <para>Telephone number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1390000****</para>
        /// </summary>
        [NameInMap("Telephone")]
        [Validation(Required=false)]
        public string Telephone { get; set; }

        /// <summary>
        /// <para>User IP address, which can be set to <b>127.0.0.1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

        /// <summary>
        /// <para>Detailed address (in Chinese).</para>
        /// <remarks>
        /// <para>This parameter applies only to the China site (aliyun.com).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>西土城路</para>
        /// </summary>
        [NameInMap("ZhAddress")]
        [Validation(Required=false)]
        public string ZhAddress { get; set; }

        /// <summary>
        /// <para>City (in Chinese).  </para>
        /// <remarks>
        /// <para>This parameter applies only to the China site (aliyun.com).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>北京市</para>
        /// </summary>
        [NameInMap("ZhCity")]
        [Validation(Required=false)]
        public string ZhCity { get; set; }

        /// <summary>
        /// <para>Province (in Chinese).  </para>
        /// <remarks>
        /// <para>This parameter applies only to the China site (aliyun.com).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>北京</para>
        /// </summary>
        [NameInMap("ZhProvince")]
        [Validation(Required=false)]
        public string ZhProvince { get; set; }

        /// <summary>
        /// <para>Contact name (in Chinese).  </para>
        /// <remarks>
        /// <para>This parameter applies only to the China site (aliyun.com).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>王先生</para>
        /// </summary>
        [NameInMap("ZhRegistrantName")]
        [Validation(Required=false)]
        public string ZhRegistrantName { get; set; }

        /// <summary>
        /// <para>Registrant name (in Chinese).</para>
        /// <remarks>
        /// <para>This parameter applies only to the China site (aliyun.com).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>王先生</para>
        /// </summary>
        [NameInMap("ZhRegistrantOrganization")]
        [Validation(Required=false)]
        public string ZhRegistrantOrganization { get; set; }

    }

}
