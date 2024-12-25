// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class UploadServerCertificateResponseBody : TeaModel {
        /// <summary>
        /// <para>The AliCloud certificate ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>775****</para>
        /// </summary>
        [NameInMap("AliCloudCertificateId")]
        [Validation(Required=false)]
        public string AliCloudCertificateId { get; set; }

        /// <summary>
        /// <para>The AliCloud certificate name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloudcertificate****</para>
        /// </summary>
        [NameInMap("AliCloudCertificateName")]
        [Validation(Required=false)]
        public string AliCloudCertificateName { get; set; }

        /// <summary>
        /// <para>The domain name of the CA certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("CommonName")]
        [Validation(Required=false)]
        public string CommonName { get; set; }

        /// <summary>
        /// <para>The time when the CA certificate is uploaded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-02-21T02:49:05Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The timestamp generated when the CA certificate is uploaded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1504147745000</para>
        /// </summary>
        [NameInMap("CreateTimeStamp")]
        [Validation(Required=false)]
        public long? CreateTimeStamp { get; set; }

        /// <summary>
        /// <para>The time when the CA certificate expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-10-18T23:59:59Z</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>The timestamp generated when the CA certificate expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1504147745000</para>
        /// </summary>
        [NameInMap("ExpireTimeStamp")]
        [Validation(Required=false)]
        public long? ExpireTimeStamp { get; set; }

        /// <summary>
        /// <para>The fingerprint of the CA certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8f:7d:cb:e5:f8:c8:33:9c:17:65:c1:92:30:9e:45:55:9c:3a:85:60</para>
        /// </summary>
        [NameInMap("Fingerprint")]
        [Validation(Required=false)]
        public string Fingerprint { get; set; }

        /// <summary>
        /// <para>Indicates whether the certificate is provided by Alibaba Cloud Certificate Management Service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: The certificate is not provided by Alibaba Cloud Certificate Management Service.</description></item>
        /// <item><description><b>1</b>: The certificate is provided by Alibaba Cloud Certificate Management Service.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IsAliCloudCertificate")]
        [Validation(Required=false)]
        public int? IsAliCloudCertificate { get; set; }

        /// <summary>
        /// <para>The ID of the region where the Classic Load Balancer (CLB) instance is deployed.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/27584.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>365F4154-92F6-4AE4-92F8-7FF34B540710</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-atstuj3rt****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the server certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1321932713******<em>17f1b4b696b_1114720822</em>-1671******</para>
        /// </summary>
        [NameInMap("ServerCertificateId")]
        [Validation(Required=false)]
        public string ServerCertificateId { get; set; }

        /// <summary>
        /// <para>The name of the server certificate.</para>
        /// <para>The name must be 1 to 80 characters in length. It must start with an English letter. It can contain letters, numbers, periods (.), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>mycert01</para>
        /// </summary>
        [NameInMap("ServerCertificateName")]
        [Validation(Required=false)]
        public string ServerCertificateName { get; set; }

        /// <summary>
        /// <para>The subject alternative names.</para>
        /// <para>A domain name list is supported. A maximum of 10 domain names are supported.</para>
        /// </summary>
        [NameInMap("SubjectAlternativeNames")]
        [Validation(Required=false)]
        public UploadServerCertificateResponseBodySubjectAlternativeNames SubjectAlternativeNames { get; set; }
        public class UploadServerCertificateResponseBodySubjectAlternativeNames : TeaModel {
            [NameInMap("SubjectAlternativeName")]
            [Validation(Required=false)]
            public List<string> SubjectAlternativeName { get; set; }

        }

    }

}
