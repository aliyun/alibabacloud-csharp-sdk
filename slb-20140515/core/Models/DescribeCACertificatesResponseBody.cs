// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeCACertificatesResponseBody : TeaModel {
        [NameInMap("CACertificates")]
        [Validation(Required=false)]
        public DescribeCACertificatesResponseBodyCACertificates CACertificates { get; set; }
        public class DescribeCACertificatesResponseBodyCACertificates : TeaModel {
            [NameInMap("CACertificate")]
            [Validation(Required=false)]
            public List<DescribeCACertificatesResponseBodyCACertificatesCACertificate> CACertificate { get; set; }
            public class DescribeCACertificatesResponseBodyCACertificatesCACertificate : TeaModel {
                [NameInMap("CACertificateId")]
                [Validation(Required=false)]
                public string CACertificateId { get; set; }

                [NameInMap("CACertificateName")]
                [Validation(Required=false)]
                public string CACertificateName { get; set; }

                [NameInMap("CommonName")]
                [Validation(Required=false)]
                public string CommonName { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("CreateTimeStamp")]
                [Validation(Required=false)]
                public long? CreateTimeStamp { get; set; }

                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                [NameInMap("ExpireTimeStamp")]
                [Validation(Required=false)]
                public long? ExpireTimeStamp { get; set; }

                [NameInMap("Fingerprint")]
                [Validation(Required=false)]
                public string Fingerprint { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeCACertificatesResponseBodyCACertificatesCACertificateTags Tags { get; set; }
                public class DescribeCACertificatesResponseBodyCACertificatesCACertificateTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeCACertificatesResponseBodyCACertificatesCACertificateTagsTag> Tag { get; set; }
                    public class DescribeCACertificatesResponseBodyCACertificatesCACertificateTagsTag : TeaModel {
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

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
