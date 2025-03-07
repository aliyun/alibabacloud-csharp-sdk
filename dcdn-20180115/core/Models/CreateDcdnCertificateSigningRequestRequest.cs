// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class CreateDcdnCertificateSigningRequestRequest : TeaModel {
        /// <summary>
        /// <para>The city. Default value: Hangzhou.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hangzhou</para>
        /// </summary>
        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// <para>The Common Name of the certificate.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testName</para>
        /// </summary>
        [NameInMap("CommonName")]
        [Validation(Required=false)]
        public string CommonName { get; set; }

        /// <summary>
        /// <para>The country or region in which the organization is located. Default value: CN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CN</para>
        /// </summary>
        [NameInMap("Country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        /// <summary>
        /// <para>The email address.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:test@aliyundoc.com">test@aliyundoc.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>The name of the organization. Default value: Alibaba Inc.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba Inc</para>
        /// </summary>
        [NameInMap("Organization")]
        [Validation(Required=false)]
        public string Organization { get; set; }

        /// <summary>
        /// <para>The name of the department. Default value: Aliyun CDN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Aliyun CDN</para>
        /// </summary>
        [NameInMap("OrganizationUnit")]
        [Validation(Required=false)]
        public string OrganizationUnit { get; set; }

        /// <summary>
        /// <para>The Subject Alternative Name (SAN) extension that allows multiple domain names to be associated with the certificate. Separate multiple domain names with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com,example.org</para>
        /// </summary>
        [NameInMap("SANs")]
        [Validation(Required=false)]
        public string SANs { get; set; }

        /// <summary>
        /// <para>The provincial district. Default value: Zhejiang.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Zhejiang</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
