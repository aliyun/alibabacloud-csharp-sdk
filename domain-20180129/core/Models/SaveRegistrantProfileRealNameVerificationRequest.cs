// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SaveRegistrantProfileRealNameVerificationRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>chao yang qu</para>
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>bei jing shi</para>
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
        /// <para><a href="mailto:username@example.com">username@example.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dGVzdA==</para>
        /// </summary>
        [NameInMap("IdentityCredential")]
        [Validation(Required=false)]
        public string IdentityCredential { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4111111111111110**</para>
        /// </summary>
        [NameInMap("IdentityCredentialNo")]
        [Validation(Required=false)]
        public string IdentityCredentialNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SFZ</para>
        /// </summary>
        [NameInMap("IdentityCredentialType")]
        [Validation(Required=false)]
        public string IdentityCredentialType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234567</para>
        /// </summary>
        [NameInMap("PostalCode")]
        [Validation(Required=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>bei jing</para>
        /// </summary>
        [NameInMap("Province")]
        [Validation(Required=false)]
        public string Province { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ce shi</para>
        /// </summary>
        [NameInMap("RegistrantName")]
        [Validation(Required=false)]
        public string RegistrantName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ce shi</para>
        /// </summary>
        [NameInMap("RegistrantOrganization")]
        [Validation(Required=false)]
        public string RegistrantOrganization { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234567</para>
        /// </summary>
        [NameInMap("RegistrantProfileId")]
        [Validation(Required=false)]
        public long? RegistrantProfileId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>common</para>
        /// </summary>
        [NameInMap("RegistrantProfileType")]
        [Validation(Required=false)]
        public string RegistrantProfileType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RegistrantType")]
        [Validation(Required=false)]
        public string RegistrantType { get; set; }

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
        /// <para>12345678</para>
        /// </summary>
        [NameInMap("Telephone")]
        [Validation(Required=false)]
        public string Telephone { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

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
