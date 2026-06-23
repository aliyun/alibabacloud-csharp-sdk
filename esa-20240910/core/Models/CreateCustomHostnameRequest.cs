// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateCustomHostnameRequest : TeaModel {
        /// <summary>
        /// <para>The SSL Certificates Service certificate ID. This parameter is required when CertType is set to cas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30000478</para>
        /// </summary>
        [NameInMap("CasId")]
        [Validation(Required=false)]
        public long? CasId { get; set; }

        /// <summary>
        /// <para>The region of the SSL Certificates Service certificate. This parameter is required when CertType is set to cas.</para>
        /// <list type="bullet">
        /// <item><description>For Chinese site accounts, set this parameter to cn-hangzhou.</description></item>
        /// <item><description>For International site accounts, set this parameter to ap-southeast-1.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("CasRegion")]
        [Validation(Required=false)]
        public string CasRegion { get; set; }

        /// <summary>
        /// <para>The certificate type. This parameter is required when SslFlag is set to on. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>free</b>: free certificate.</description></item>
        /// <item><description><b>upload</b>: uploaded certificate.</description></item>
        /// <item><description><b>cas</b>: SSL Certificates Service certificate.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>free</para>
        /// </summary>
        [NameInMap("CertType")]
        [Validation(Required=false)]
        public string CertType { get; set; }

        /// <summary>
        /// <para>The certificate content. This parameter is required when CertType is set to upload.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("Certificate")]
        [Validation(Required=false)]
        public string Certificate { get; set; }

        /// <summary>
        /// <para>The SaaS domain name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom.site.com</para>
        /// </summary>
        [NameInMap("Hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        /// <summary>
        /// <para>The certificate private key. This parameter is required when CertType is set to upload.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN PRIVATE KEY-----</para>
        /// </summary>
        [NameInMap("PrivateKey")]
        [Validation(Required=false)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// <para>The ID of the record to bind. You can call the <a href="https://help.aliyun.com/document_detail/2850265.html">ListRecords</a> operation to obtain the record ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123</para>
        /// </summary>
        [NameInMap("RecordId")]
        [Validation(Required=false)]
        public long? RecordId { get; set; }

        /// <summary>
        /// <para>The site ID. You can call the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation to obtain the site ID.</para>
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
        /// <item><description><b>on</b>: Enable SSL.</description></item>
        /// <item><description><b>off</b>: Disable SSL.</description></item>
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
