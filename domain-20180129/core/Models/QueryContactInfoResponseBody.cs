// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryContactInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>Mailing address (English).</para>
        /// 
        /// <b>Example:</b>
        /// <para>xi hu qu *** jiedao *** xiaoqu *** zhuang 101</para>
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <para>City (English).</para>
        /// 
        /// <b>Example:</b>
        /// <para>hang zhou shi</para>
        /// </summary>
        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// <para>Country code. For example, <b>CN</b> represents China and <b>US</b> represents the United States.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CN</para>
        /// </summary>
        [NameInMap("Country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        /// <summary>
        /// <para>Domain registration date.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-03-20 11:37:29</para>
        /// </summary>
        [NameInMap("CreateDate")]
        [Validation(Required=false)]
        public string CreateDate { get; set; }

        /// <summary>
        /// <para>Mailbox.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:username@example.com">username@example.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>Postal code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>310024</para>
        /// </summary>
        [NameInMap("PostalCode")]
        [Validation(Required=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// <para>Province (English).</para>
        /// 
        /// <b>Example:</b>
        /// <para>zhe jiang</para>
        /// </summary>
        [NameInMap("Province")]
        [Validation(Required=false)]
        public string Province { get; set; }

        /// <summary>
        /// <para>Contact name (English).</para>
        /// 
        /// <b>Example:</b>
        /// <para>zhang san</para>
        /// </summary>
        [NameInMap("RegistrantName")]
        [Validation(Required=false)]
        public string RegistrantName { get; set; }

        /// <summary>
        /// <para>Registrant name (English).</para>
        /// 
        /// <b>Example:</b>
        /// <para>zhang san</para>
        /// </summary>
        [NameInMap("RegistrantOrganization")]
        [Validation(Required=false)]
        public string RegistrantOrganization { get; set; }

        /// <summary>
        /// <para>Unique request access token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C39ECA8A-BB5E-4F92-B013-6A032FA06B04</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The country code for the telephone number. For example, the country code for China is <b>86</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86</para>
        /// </summary>
        [NameInMap("TelArea")]
        [Validation(Required=false)]
        public string TelArea { get; set; }

        /// <summary>
        /// <para>Telephone extension number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("TelExt")]
        [Validation(Required=false)]
        public string TelExt { get; set; }

        /// <summary>
        /// <para>Telephone number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1820000****</para>
        /// </summary>
        [NameInMap("Telephone")]
        [Validation(Required=false)]
        public string Telephone { get; set; }

        /// <summary>
        /// <para>Mailing address (in Chinese).</para>
        /// 
        /// <b>Example:</b>
        /// <para>西湖区<em><b>街道</b></em>小区***幢101</para>
        /// </summary>
        [NameInMap("ZhAddress")]
        [Validation(Required=false)]
        public string ZhAddress { get; set; }

        /// <summary>
        /// <para>City (Chinese).</para>
        /// 
        /// <b>Example:</b>
        /// <para>杭州市</para>
        /// </summary>
        [NameInMap("ZhCity")]
        [Validation(Required=false)]
        public string ZhCity { get; set; }

        /// <summary>
        /// <para>Province (Chinese).</para>
        /// 
        /// <b>Example:</b>
        /// <para>浙江</para>
        /// </summary>
        [NameInMap("ZhProvince")]
        [Validation(Required=false)]
        public string ZhProvince { get; set; }

        /// <summary>
        /// <para>Contact name (Chinese).</para>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("ZhRegistrantName")]
        [Validation(Required=false)]
        public string ZhRegistrantName { get; set; }

        /// <summary>
        /// <para>Registrant name (Chinese).</para>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("ZhRegistrantOrganization")]
        [Validation(Required=false)]
        public string ZhRegistrantOrganization { get; set; }

    }

}
