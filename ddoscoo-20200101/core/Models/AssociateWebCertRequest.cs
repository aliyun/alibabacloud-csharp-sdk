// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class AssociateWebCertRequest : TeaModel {
        /// <summary>
        /// <para>The public key of the certificate that you want to associate. This parameter must be used together with the CertName and Key parameters.</para>
        /// <remarks>
        /// <para> If you specify a value for the CertName, Cert, and Key parameters, you do not need to specify a value for the CertId parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE----- 62EcYPWd2Oy1vs6MTXcJSfN9Z7rZ9fmxWr2BFN2XbahgnsSXM48ixZJ4krc+1M+j2kcubVpsE2cgHdj4v8H6jUz9Ji4mr7vMNS6dXv8PUkl/qoDeNGCNdyTS5NIL5ir+g92cL8IGOkjgvhlqt9vc65Cgb4mL+n5+DV9uOyTZTW/MojmlgfUekC2xiXa54nxJf17Y1TADGSbyJbsC0Q9nIrHsPl8YKkvRWvIAqYxXZ7wRwWWmv4TMxFhWRiNY7yZIo2ZUhl02SIDNggIEeg== -----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("Cert")]
        [Validation(Required=false)]
        public string Cert { get; set; }

        /// <summary>
        /// <para>The ID of the certificate.</para>
        /// <remarks>
        /// <para> If you specify a certificate ID, you do not need to specify a value for the CertName, Cert, and Key parameters. You can specify only one of this parameter and the CertIdentifier parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2404693</para>
        /// </summary>
        [NameInMap("CertId")]
        [Validation(Required=false)]
        public int? CertId { get; set; }

        /// <summary>
        /// <para>The globally unique ID of the certificate. The value is in the &quot;Certificate ID-cn-hangzhou&quot; format. For example, if the ID of the certificate is 123, the value of the CertIdentifier parameter is 123-cn-hangzhou.</para>
        /// <remarks>
        /// <para> You can specify only one of this parameter and the CertId parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>9430680-cn-hangzhou</para>
        /// </summary>
        [NameInMap("CertIdentifier")]
        [Validation(Required=false)]
        public string CertIdentifier { get; set; }

        /// <summary>
        /// <para>The name of the certificate.</para>
        /// <remarks>
        /// <para> You can specify the name of the certificate that you want to associate. This parameter must be used together with the Cert and Key parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>example-cert</para>
        /// </summary>
        [NameInMap("CertName")]
        [Validation(Required=false)]
        public string CertName { get; set; }

        /// <summary>
        /// <para>The region of the certificate. Valid values: <b>cn-hangzhou</b> and <b>ap-southeast-1</b>. Default value: <b>cn-hangzhou</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("CertRegion")]
        [Validation(Required=false)]
        public string CertRegion { get; set; }

        /// <summary>
        /// <para>The domain name of the website.</para>
        /// <remarks>
        /// <para> A forwarding rule must be configured for the domain name. You can call the <a href="https://help.aliyun.com/document_detail/91724.html">DescribeDomains</a> operation to query all domain names.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyun.com">www.aliyun.com</a></para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The private key of the certificate that you want to associate. This parameter must be used together with the CertName and Cert parameters.</para>
        /// <remarks>
        /// <para> If you specify a value for the CertName, Cert, and Key parameters, you do not need to specify a value for the CertId parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN RSA PRIVATE KEY----- DADTPZoOHd9WtZ3UKHJTRgNQmioPQn2bqdKHop+B/dn/4VZL7Jt8zSDGM9sTMThLyvsmLQKBgQCr+ujntC1kN6pGBj2Fw2l/EA/W3rYEce2tyhjgmG7rZ+A/jVE9fld5sQra6ZdwBcQJaiygoIYoaMF2EjRwc0qwHaluq0C15f6ujSoHh2e+D5zdmkTg/3NKNjqNv6xA2gYpinVDzFdZ9Zujxvuh9o4Vqf0YF8bv5UK5G04RtKadOw== -----END RSA PRIVATE KEY-----</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

    }

}
