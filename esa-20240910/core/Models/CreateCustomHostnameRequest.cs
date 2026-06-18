// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateCustomHostnameRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the CAS certificate. This parameter is required if <c>CertType</c> is set to <c>cas</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30000478</para>
        /// </summary>
        [NameInMap("CasId")]
        [Validation(Required=false)]
        public long? CasId { get; set; }

        /// <summary>
        /// <para>The region of the CAS certificate. This parameter is required if <c>CertType</c> is set to <c>cas</c>.</para>
        /// <list type="bullet">
        /// <item><description><para>For accounts on the China site, set this parameter to <c>cn-hangzhou</c>.</para>
        /// </description></item>
        /// <item><description><para>For accounts on the International site, set this parameter to <c>ap-southeast-1</c>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("CasRegion")]
        [Validation(Required=false)]
        public string CasRegion { get; set; }

        /// <summary>
        /// <para>The certificate type. This parameter is required if <c>SslFlag</c> is set to <c>on</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>free</b>: A free certificate.</para>
        /// </description></item>
        /// <item><description><para><b>upload</b>: A user-uploaded certificate.</para>
        /// </description></item>
        /// <item><description><para><b>cas</b>: A CAS certificate.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>free</para>
        /// </summary>
        [NameInMap("CertType")]
        [Validation(Required=false)]
        public string CertType { get; set; }

        /// <summary>
        /// <para>The content of the certificate. This parameter is required if <c>CertType</c> is set to <c>upload</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("Certificate")]
        [Validation(Required=false)]
        public string Certificate { get; set; }

        /// <summary>
        /// <para>The custom hostname.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom.site.com</para>
        /// </summary>
        [NameInMap("Hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        /// <summary>
        /// <para>The private key of the certificate. This parameter is required if <c>CertType</c> is set to <c>upload</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN PRIVATE KEY-----</para>
        /// </summary>
        [NameInMap("PrivateKey")]
        [Validation(Required=false)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// <para>The ID of the record to bind. Call the <a href="https://help.aliyun.com/document_detail/2850265.html">ListRecords</a> operation to get this ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123</para>
        /// </summary>
        [NameInMap("RecordId")]
        [Validation(Required=false)]
        public long? RecordId { get; set; }

        /// <summary>
        /// <para>The site ID. Call the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation to get this ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable SSL. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>on</b>: Enable SSL.</para>
        /// </description></item>
        /// <item><description><para><b>off</b>: Disable SSL.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("SslFlag")]
        [Validation(Required=false)]
        public string SslFlag { get; set; }

    }

}
