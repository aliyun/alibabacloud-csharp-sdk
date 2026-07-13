// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateAtiRegistrantRequest : TeaModel {
        /// <summary>
        /// <para>The country.</para>
        /// 
        /// <b>Example:</b>
        /// <para>中国</para>
        /// </summary>
        [NameInMap("Cc")]
        [Validation(Required=false)]
        public string Cc { get; set; }

        /// <summary>
        /// <para>The city.</para>
        /// 
        /// <b>Example:</b>
        /// <para>杭州市</para>
        /// </summary>
        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// <para>Ensures the idempotency of the request. Generate a unique parameter value from your client to ensure that the value is unique across different requests. ClientToken supports only ASCII characters and cannot exceed 64 characters in length.</para>
        /// <para>If you do not specify this parameter, the system automatically uses the RequestId of the API request as the ClientToken. The RequestId may be different for each API request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJhbGciOiJIUzI1NiIsInR5cC.....</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The document number of the registrant. Maximum length: 50 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11011239900307663x</para>
        /// </summary>
        [NameInMap("DocumentCode")]
        [Validation(Required=false)]
        public string DocumentCode { get; set; }

        /// <summary>
        /// <para>The document image of the registrant (Base64-encoded). The original file size must be between 50 KB and 3 MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>证件图片</para>
        /// </summary>
        [NameInMap("DocumentImage")]
        [Validation(Required=false)]
        public string DocumentImage { get; set; }

        /// <summary>
        /// <para>The document type of the registrant. For more information, see the appendix on document types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SFZ</para>
        /// </summary>
        [NameInMap("DocumentType")]
        [Validation(Required=false)]
        public string DocumentType { get; set; }

        /// <summary>
        /// <para>The email address. Maximum length: 300 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:example@example.com">example@example.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>The name of the registrant. Maximum length: 255 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张xx</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The phone number of the registrant. Maximum length: 128 characters. If the country is China, the area code of a non-mobile phone number must match the city.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13112345678</para>
        /// </summary>
        [NameInMap("Phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        /// <summary>
        /// <para>The ID of the registrant profile.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2072277378616354816</para>
        /// </summary>
        [NameInMap("RegistrantId")]
        [Validation(Required=false)]
        public string RegistrantId { get; set; }

        /// <summary>
        /// <para>The state or province.</para>
        /// 
        /// <b>Example:</b>
        /// <para>浙江省</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The street.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xx区xx街道</para>
        /// </summary>
        [NameInMap("Street")]
        [Validation(Required=false)]
        public string Street { get; set; }

    }

}
