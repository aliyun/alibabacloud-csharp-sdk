// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class AssociateWebCertRequest : TeaModel {
        /// <summary>
        /// <para>The public key of the certificate to associate. This parameter must be used together with CertName and Key. </para>
        /// <remarks>
        /// <para>If you specify CertName, Cert, and Key, you do not need to specify CertId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE----- 62EcYPWd2Oy1vs6MTXcJSf*************************************************************************************************************************************************************************ZIo2ZUhl02SIDNggIEeg== -----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("Cert")]
        [Validation(Required=false)]
        public string Cert { get; set; }

        /// <summary>
        /// <para>The certificate ID.</para>
        /// <remarks>
        /// <para>If you specify the certificate ID, you do not need to specify CertName, Cert, or Key. This parameter cannot be used together with CertIdentifier.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2404693</para>
        /// </summary>
        [NameInMap("CertId")]
        [Validation(Required=false)]
        public int? CertId { get; set; }

        /// <summary>
        /// <para>The global certificate ID, which is in the format of certificate ID + &quot;-cn-hangzhou&quot;. For example, if the certificate ID is 123, set CertIdentifier to &quot;123-cn-hangzhou&quot;.</para>
        /// <remarks>
        /// <para>This parameter cannot be used together with CertId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>9430680-cn-hangzhou</para>
        /// </summary>
        [NameInMap("CertIdentifier")]
        [Validation(Required=false)]
        public string CertIdentifier { get; set; }

        /// <summary>
        /// <para>The certificate name. </para>
        /// <remarks>
        /// <para>The name of the certificate to associate. This parameter must be used together with Cert and Key.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>example-cert</para>
        /// </summary>
        [NameInMap("CertName")]
        [Validation(Required=false)]
        public string CertName { get; set; }

        /// <summary>
        /// <para>The region where the certificate is stored. Valid values: <b>cn-hangzhou</b> and <b>ap-southeast-1</b>. Default value: <b>cn-hangzhou</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("CertRegion")]
        [Validation(Required=false)]
        public string CertRegion { get; set; }

        /// <summary>
        /// <para>The domain name of the website service.</para>
        /// <remarks>
        /// <para>The domain name must have a website forwarding rule configured. You can call <a href="https://help.aliyun.com/document_detail/91724.html">DescribeDomains</a> to query all domain names.</para>
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
        /// <para>The private key of the certificate to associate. This parameter must be used together with CertName and Cert. </para>
        /// <remarks>
        /// <para>If you specify CertName, Cert, and Key, you do not need to specify CertId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN RSA PRIVATE KEY----- DADTPZoOHd9WtZ3UKHJT**************************************************************************************************************************************************************************qf0YF8bv5UK5G04RtKadOw== -----END RSA PRIVATE KEY-----</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

    }

}
