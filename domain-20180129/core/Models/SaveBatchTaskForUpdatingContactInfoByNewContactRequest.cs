// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SaveBatchTaskForUpdatingContactInfoByNewContactRequest : TeaModel {
        /// <summary>
        /// <para>Specific address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chao yang qu</para>
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <para>City.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bei jing shi</para>
        /// </summary>
        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// <para>Contact type. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>registrant</b>: Registrant.  </description></item>
        /// <item><description><b>admin</b>: Administrator.  </description></item>
        /// <item><description><b>billing</b>: Billing contact.  </description></item>
        /// <item><description><b>tech</b>: Technical contact.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registrant</para>
        /// </summary>
        [NameInMap("ContactType")]
        [Validation(Required=false)]
        public string ContactType { get; set; }

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
        /// <para>Domain name list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alibabacloud.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public List<string> DomainName { get; set; }

        /// <summary>
        /// <para>Mailbox.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:test@aliyun.com">test@aliyun.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>Language of error messages returned by the API. Valid values:  </para>
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
        /// <para>123456</para>
        /// </summary>
        [NameInMap("PostalCode")]
        [Validation(Required=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// <para>Province.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bei jing</para>
        /// </summary>
        [NameInMap("Province")]
        [Validation(Required=false)]
        public string Province { get; set; }

        /// <summary>
        /// <para>Contact name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ce shi</para>
        /// </summary>
        [NameInMap("RegistrantName")]
        [Validation(Required=false)]
        public string RegistrantName { get; set; }

        /// <summary>
        /// <para>Registrant organization name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ce shi</para>
        /// </summary>
        [NameInMap("RegistrantOrganization")]
        [Validation(Required=false)]
        public string RegistrantOrganization { get; set; }

        /// <summary>
        /// <para>Domain registrant type. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Individual.  </description></item>
        /// <item><description><b>2</b>: Enterprise.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RegistrantType")]
        [Validation(Required=false)]
        public string RegistrantType { get; set; }

        /// <summary>
        /// <para>Telephone country code.</para>
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
        /// <para>1235</para>
        /// </summary>
        [NameInMap("TelExt")]
        [Validation(Required=false)]
        public string TelExt { get; set; }

        /// <summary>
        /// <para>Telephone number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("Telephone")]
        [Validation(Required=false)]
        public string Telephone { get; set; }

        /// <summary>
        /// <para>Whether to add a transfer-out prohibition restriction. This parameter only takes effect when <b>ContactType</b> is <b>registrant</b>, indicating whether the domain name is restricted from transfer-out for 60 days after the registrant is modified. The default value is <b>false</b>, which means transfer-out is not restricted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("TransferOutProhibited")]
        [Validation(Required=false)]
        public bool? TransferOutProhibited { get; set; }

        /// <summary>
        /// <para>User IP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

        /// <summary>
        /// <para>Chinese address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>朝阳区</para>
        /// </summary>
        [NameInMap("ZhAddress")]
        [Validation(Required=false)]
        public string ZhAddress { get; set; }

        /// <summary>
        /// <para>Chinese city.</para>
        /// 
        /// <b>Example:</b>
        /// <para>北京市</para>
        /// </summary>
        [NameInMap("ZhCity")]
        [Validation(Required=false)]
        public string ZhCity { get; set; }

        /// <summary>
        /// <para>Chinese province.</para>
        /// 
        /// <b>Example:</b>
        /// <para>北京</para>
        /// </summary>
        [NameInMap("ZhProvince")]
        [Validation(Required=false)]
        public string ZhProvince { get; set; }

        /// <summary>
        /// <para>Chinese contact name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试</para>
        /// </summary>
        [NameInMap("ZhRegistrantName")]
        [Validation(Required=false)]
        public string ZhRegistrantName { get; set; }

        /// <summary>
        /// <para>Chinese registrant organization name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试</para>
        /// </summary>
        [NameInMap("ZhRegistrantOrganization")]
        [Validation(Required=false)]
        public string ZhRegistrantOrganization { get; set; }

    }

}
