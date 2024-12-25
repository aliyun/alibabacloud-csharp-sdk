// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class UploadServerCertificateRequest : TeaModel {
        /// <summary>
        /// <para>AliCloud certificate ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>775****</para>
        /// </summary>
        [NameInMap("AliCloudCertificateId")]
        [Validation(Required=false)]
        public string AliCloudCertificateId { get; set; }

        /// <summary>
        /// <para>AliCloud certificate name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloudcertificate</para>
        /// </summary>
        [NameInMap("AliCloudCertificateName")]
        [Validation(Required=false)]
        public string AliCloudCertificateName { get; set; }

        /// <summary>
        /// <para>The region ID of AliCloud certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("AliCloudCertificateRegionId")]
        [Validation(Required=false)]
        public string AliCloudCertificateRegionId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The private key of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN RSA PRIVATE KEY----- MIIEogIB****** -----END RSA PRIVATE KEY-----</para>
        /// </summary>
        [NameInMap("PrivateKey")]
        [Validation(Required=false)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// <para>The region ID of the CLB instance.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/27584.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-atstuj3rto****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The server certificate to be uploaded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE----- MIIGDTCC****** -----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("ServerCertificate")]
        [Validation(Required=false)]
        public string ServerCertificate { get; set; }

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
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<UploadServerCertificateRequestTag> Tag { get; set; }
        public class UploadServerCertificateRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N. Valid values of N: <b>1 to 20</b>. The tag key cannot be an empty string.</para>
            /// <para>The tag key can be up to 64 characters in length, and cannot contain <c>http://</c> or <c>https://</c>. The tag key cannot start with <c>aliyun</c> or <c>acs:</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N. Valid values of N: <b>1 to 20</b>. The tag value can be an empty string. The tag value can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>. The tag value cannot start with <c>aliyun</c> and <c>acs:</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
