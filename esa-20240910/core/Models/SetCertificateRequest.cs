// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class SetCertificateRequest : TeaModel {
        /// <summary>
        /// <para>The cloud certificate ID. This parameter is required when Type is set to cas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30000478</para>
        /// </summary>
        [NameInMap("CasId")]
        [Validation(Required=false)]
        public long? CasId { get; set; }

        /// <summary>
        /// <para>The certificate content. This parameter is required when Type is set to upload.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("Certificate")]
        [Validation(Required=false)]
        public string Certificate { get; set; }

        /// <summary>
        /// <para>The certificate ID. Certificates of the free type (created by calling the ApplyCertificate operation) are not supported. Certificates of the cas and upload types are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>babae7c40fef412d887688b91c9e****</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The keyless server ID. This parameter takes effect only when Type is set to keyless.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1233112****</para>
        /// </summary>
        [NameInMap("KeyServerId")]
        [Validation(Required=false)]
        public string KeyServerId { get; set; }

        /// <summary>
        /// <para>The certificate name. This parameter is required when Type is set to upload.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourCertName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The certificate private key. This parameter is required when Type is set to upload.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN PRIVATE KEY-----</para>
        /// </summary>
        [NameInMap("PrivateKey")]
        [Validation(Required=false)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// <para>The region. This parameter is required when Type is set to cas. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>China site accounts: cn-hangzhou.</para>
        /// </description></item>
        /// <item><description><para>International site accounts: ap-southeast-1.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

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
        /// <para>The certificate type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cas</b>: certificate from SSL Certificates Service.</para>
        /// </description></item>
        /// <item><description><para><b>upload</b>: custom uploaded certificate.</para>
        /// </description></item>
        /// <item><description><para><b>keyless</b>: keyless certificate.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cas</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
