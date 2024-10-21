// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryContactInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>xi hu qu *** jiedao *** xiaoqu *** zhuang 101</para>
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hang zhou shi</para>
        /// </summary>
        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CN</para>
        /// </summary>
        [NameInMap("Country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2019-03-20 11:37:29</para>
        /// </summary>
        [NameInMap("CreateDate")]
        [Validation(Required=false)]
        public string CreateDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="mailto:username@example.com">username@example.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>310024</para>
        /// </summary>
        [NameInMap("PostalCode")]
        [Validation(Required=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zhe jiang</para>
        /// </summary>
        [NameInMap("Province")]
        [Validation(Required=false)]
        public string Province { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zhang san</para>
        /// </summary>
        [NameInMap("RegistrantName")]
        [Validation(Required=false)]
        public string RegistrantName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zhang san</para>
        /// </summary>
        [NameInMap("RegistrantOrganization")]
        [Validation(Required=false)]
        public string RegistrantOrganization { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C39ECA8A-BB5E-4F92-B013-6A032FA06B04</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>86</para>
        /// </summary>
        [NameInMap("TelArea")]
        [Validation(Required=false)]
        public string TelArea { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("TelExt")]
        [Validation(Required=false)]
        public string TelExt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1820000****</para>
        /// </summary>
        [NameInMap("Telephone")]
        [Validation(Required=false)]
        public string Telephone { get; set; }

        [NameInMap("ZhAddress")]
        [Validation(Required=false)]
        public string ZhAddress { get; set; }

        [NameInMap("ZhCity")]
        [Validation(Required=false)]
        public string ZhCity { get; set; }

        [NameInMap("ZhProvince")]
        [Validation(Required=false)]
        public string ZhProvince { get; set; }

        [NameInMap("ZhRegistrantName")]
        [Validation(Required=false)]
        public string ZhRegistrantName { get; set; }

        [NameInMap("ZhRegistrantOrganization")]
        [Validation(Required=false)]
        public string ZhRegistrantOrganization { get; set; }

    }

}
