// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeCACertificatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the CA certificate.</para>
        /// </summary>
        [NameInMap("CACertificates")]
        [Validation(Required=false)]
        public DescribeCACertificatesResponseBodyCACertificates CACertificates { get; set; }
        public class DescribeCACertificatesResponseBodyCACertificates : TeaModel {
            [NameInMap("CACertificate")]
            [Validation(Required=false)]
            public List<DescribeCACertificatesResponseBodyCACertificatesCACertificate> CACertificate { get; set; }
            public class DescribeCACertificatesResponseBodyCACertificatesCACertificate : TeaModel {
                /// <summary>
                /// <para>The CA certificate ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>139a00604bd-cn-east-hangzho****</para>
                /// </summary>
                [NameInMap("CACertificateId")]
                [Validation(Required=false)]
                public string CACertificateId { get; set; }

                /// <summary>
                /// <para>The CA certificate name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("CACertificateName")]
                [Validation(Required=false)]
                public string CACertificateName { get; set; }

                /// <summary>
                /// <para>The domain name of the CA certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com">www.example.com</a></para>
                /// </summary>
                [NameInMap("CommonName")]
                [Validation(Required=false)]
                public string CommonName { get; set; }

                /// <summary>
                /// <para>The time when the CA certificate was created. The time is in the <c>YYYY-MM-DDThh:mm:ssZ</c> format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-08-31T02:49:05Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The timestamp when the CA certificate was created. Unit: milliseconds.</para>
                /// <para>This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1504147745000</para>
                /// </summary>
                [NameInMap("CreateTimeStamp")]
                [Validation(Required=false)]
                public long? CreateTimeStamp { get; set; }

                /// <summary>
                /// <para>The time when the CA certificate expires. The time is in the <c>YYYY-MM-DDThh:mm:ssZ</c> format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-11-21T06:04:25Z</para>
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// <para>The timestamp that indicates when the CA certificate expires. Unit: milliseconds.</para>
                /// <para>This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1732169065000</para>
                /// </summary>
                [NameInMap("ExpireTimeStamp")]
                [Validation(Required=false)]
                public long? ExpireTimeStamp { get; set; }

                /// <summary>
                /// <para>The fingerprint of the CA certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>79:43:fb:7d:a4:7f:44:32:61:16:57:17:e3:e8:b7:36:03:57:f6:89</para>
                /// </summary>
                [NameInMap("Fingerprint")]
                [Validation(Required=false)]
                public string Fingerprint { get; set; }

                /// <summary>
                /// <para>The region of the CA certificate.</para>
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
                /// <para>The tag.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeCACertificatesResponseBodyCACertificatesCACertificateTags Tags { get; set; }
                public class DescribeCACertificatesResponseBodyCACertificatesCACertificateTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeCACertificatesResponseBodyCACertificatesCACertificateTagsTag> Tag { get; set; }
                    public class DescribeCACertificatesResponseBodyCACertificatesCACertificateTagsTag : TeaModel {
                        /// <summary>
                        /// <para>The tag key.</para>
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

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>365F4154-92F6-4AE4-92F8-7FF34B540710</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
