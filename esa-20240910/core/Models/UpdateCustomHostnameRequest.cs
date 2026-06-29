// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateCustomHostnameRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the SSL Certificates Service certificate. This parameter is required when CertType is set to cas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30000478</para>
        /// </summary>
        [NameInMap("CasId")]
        [Validation(Required=false)]
        public long? CasId { get; set; }

        /// <summary>
        /// <para>The region of the SSL Certificates Service certificate. This parameter is required when CertType is set to cas. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Chinese mainland accounts: cn-hangzhou.</description></item>
        /// <item><description>International accounts: ap-southeast-1.</description></item>
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
        /// <para>cas</para>
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
        /// <para>The ID of the SaaS domain name. You can obtain the ID by calling the <a href="https://help.aliyun.com/document_detail/3018667.html">ListCustomHostnames</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123</para>
        /// </summary>
        [NameInMap("HostnameId")]
        [Validation(Required=false)]
        public long? HostnameId { get; set; }

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
        /// <para>The ID of the record to bind. You can obtain the ID by calling the <a href="https://help.aliyun.com/document_detail/2850265.html">ListRecords</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123</para>
        /// </summary>
        [NameInMap("RecordId")]
        [Validation(Required=false)]
        public long? RecordId { get; set; }

        /// <summary>
        /// <para>The SSL switch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: Enables SSL.</description></item>
        /// <item><description><b>off</b>: Disables SSL.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("SslFlag")]
        [Validation(Required=false)]
        public string SslFlag { get; set; }

    }

}
