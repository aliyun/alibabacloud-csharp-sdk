// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class CreateSM2CertRequest : TeaModel {
        /// <summary>
        /// <para>The name of the SM certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-sm2</para>
        /// </summary>
        [NameInMap("CertName")]
        [Validation(Required=false)]
        public string CertName { get; set; }

        /// <summary>
        /// <para>The content of the SM certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----</para>
        /// <hr>
        /// <para>-----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("EncryptCertificate")]
        [Validation(Required=false)]
        public string EncryptCertificate { get; set; }

        /// <summary>
        /// <para>The private key of the SM certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN PRIVATE KEY-----</para>
        /// <hr>
        /// <para>-----END PRIVATE KEY-----</para>
        /// </summary>
        [NameInMap("EncryptPrivateKey")]
        [Validation(Required=false)]
        public string EncryptPrivateKey { get; set; }

        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query the ID of the WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_v2_public_cn-***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The region in which the WAF instance is deployed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-hangzhou</b>: Chinese mainland.</description></item>
        /// <item><description><b>ap-southeast-1</b>: outside the Chinese mainland.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// <para>The content of the signing certificate for the SM certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----</para>
        /// <hr>
        /// <para>-----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("SignCertificate")]
        [Validation(Required=false)]
        public string SignCertificate { get; set; }

        /// <summary>
        /// <para>The private key of the signing certificate for the SM certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN PRIVATE KEY-----</para>
        /// <hr>
        /// <para>-----END PRIVATE KEY-----</para>
        /// </summary>
        [NameInMap("SignPrivateKey")]
        [Validation(Required=false)]
        public string SignPrivateKey { get; set; }

    }

}
