// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeCACertificatesResponseBody : TeaModel {
        /// <summary>
        /// The information about the CA certificate.
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
                /// The CA certificate ID.
                /// </summary>
                [NameInMap("CACertificateId")]
                [Validation(Required=false)]
                public string CACertificateId { get; set; }

                /// <summary>
                /// The CA certificate name.
                /// </summary>
                [NameInMap("CACertificateName")]
                [Validation(Required=false)]
                public string CACertificateName { get; set; }

                /// <summary>
                /// The domain name of the CA certificate.
                /// </summary>
                [NameInMap("CommonName")]
                [Validation(Required=false)]
                public string CommonName { get; set; }

                /// <summary>
                /// The time when the CA certificate was created. The time is in the `YYYY-MM-DDThh:mm:ssZ` format.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The timestamp when the CA certificate was created. Unit: milliseconds.
                /// 
                /// This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("CreateTimeStamp")]
                [Validation(Required=false)]
                public long? CreateTimeStamp { get; set; }

                /// <summary>
                /// The time when the CA certificate expires. The time is in the `YYYY-MM-DDThh:mm:ssZ` format.
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// The timestamp that indicates when the CA certificate expires. Unit: milliseconds.
                /// 
                /// This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("ExpireTimeStamp")]
                [Validation(Required=false)]
                public long? ExpireTimeStamp { get; set; }

                /// <summary>
                /// The fingerprint of the CA certificate.
                /// </summary>
                [NameInMap("Fingerprint")]
                [Validation(Required=false)]
                public string Fingerprint { get; set; }

                /// <summary>
                /// The region of the CA certificate.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The resource group ID.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The tag.
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
                        /// The tag key.
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// The tag value.
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
