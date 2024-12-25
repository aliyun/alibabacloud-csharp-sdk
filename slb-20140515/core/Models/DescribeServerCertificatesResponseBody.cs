// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeServerCertificatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>365F4154-92F6-4AE4-92F8-7FF34B540710</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The server certificates.</para>
        /// </summary>
        [NameInMap("ServerCertificates")]
        [Validation(Required=false)]
        public DescribeServerCertificatesResponseBodyServerCertificates ServerCertificates { get; set; }
        public class DescribeServerCertificatesResponseBodyServerCertificates : TeaModel {
            [NameInMap("ServerCertificate")]
            [Validation(Required=false)]
            public List<DescribeServerCertificatesResponseBodyServerCertificatesServerCertificate> ServerCertificate { get; set; }
            public class DescribeServerCertificatesResponseBodyServerCertificatesServerCertificate : TeaModel {
                /// <summary>
                /// <para>The ID of the server certificate from Alibaba Cloud Certificate Management Service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7309********_15d97e7709a_71445759hr_789289731</para>
                /// </summary>
                [NameInMap("AliCloudCertificateId")]
                [Validation(Required=false)]
                public string AliCloudCertificateId { get; set; }

                /// <summary>
                /// <para>The name of the server certificate from Alibaba Cloud Certificate Management Service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testcertkey</para>
                /// </summary>
                [NameInMap("AliCloudCertificateName")]
                [Validation(Required=false)]
                public string AliCloudCertificateName { get; set; }

                /// <summary>
                /// <para>The domain name of the server certificate. The domain name is specified in the <c>CommonName</c> field.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com">www.example.com</a></para>
                /// </summary>
                [NameInMap("CommonName")]
                [Validation(Required=false)]
                public string CommonName { get; set; }

                /// <summary>
                /// <para>The time when the server certificate was uploaded.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-08-31T02:49:05Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The timestamp when the server certificate was uploaded.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1504147745000</para>
                /// </summary>
                [NameInMap("CreateTimeStamp")]
                [Validation(Required=false)]
                public long? CreateTimeStamp { get; set; }

                /// <summary>
                /// <para>The time when the server certificate expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-01-26T23:59:59Z</para>
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// <para>The timestamp when the server certificate expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15041477450</para>
                /// </summary>
                [NameInMap("ExpireTimeStamp")]
                [Validation(Required=false)]
                public long? ExpireTimeStamp { get; set; }

                /// <summary>
                /// <para>The fingerprint of the server certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>68:08:1a:f8:2c:97:69:a3:a1:e6:16:41:4b:ca:4f:5d:ee:a5:ef:0d</para>
                /// </summary>
                [NameInMap("Fingerprint")]
                [Validation(Required=false)]
                public string Fingerprint { get; set; }

                /// <summary>
                /// <para>Indicates whether the server certificate is from Alibaba Cloud Certificate Management Service. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: yes</description></item>
                /// <item><description><b>0</b>: no</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IsAliCloudCertificate")]
                [Validation(Required=false)]
                public int? IsAliCloudCertificate { get; set; }

                /// <summary>
                /// <para>The region ID of the server certificate.</para>
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
                /// <para>rg-atstuj3rtop****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The server certificate ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123157********_166f8204689_1714763408_709981430-cn-east-hangzhou-02</para>
                /// </summary>
                [NameInMap("ServerCertificateId")]
                [Validation(Required=false)]
                public string ServerCertificateId { get; set; }

                /// <summary>
                /// <para>The name of the server certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>slb</para>
                /// </summary>
                [NameInMap("ServerCertificateName")]
                [Validation(Required=false)]
                public string ServerCertificateName { get; set; }

                /// <summary>
                /// <para>The alternative domain names of the server certificate. The alternative domain names are specified in the Subject Alternative Name field of the server certificate.</para>
                /// </summary>
                [NameInMap("SubjectAlternativeNames")]
                [Validation(Required=false)]
                public DescribeServerCertificatesResponseBodyServerCertificatesServerCertificateSubjectAlternativeNames SubjectAlternativeNames { get; set; }
                public class DescribeServerCertificatesResponseBodyServerCertificatesServerCertificateSubjectAlternativeNames : TeaModel {
                    [NameInMap("SubjectAlternativeName")]
                    [Validation(Required=false)]
                    public List<string> SubjectAlternativeName { get; set; }

                }

                /// <summary>
                /// <para>The tags.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeServerCertificatesResponseBodyServerCertificatesServerCertificateTags Tags { get; set; }
                public class DescribeServerCertificatesResponseBodyServerCertificatesServerCertificateTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeServerCertificatesResponseBodyServerCertificatesServerCertificateTagsTag> Tag { get; set; }
                    public class DescribeServerCertificatesResponseBodyServerCertificatesServerCertificateTagsTag : TeaModel {
                        /// <summary>
                        /// <para>The tag keys of the resource.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// <para>The tag value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

            }

        }

    }

}
