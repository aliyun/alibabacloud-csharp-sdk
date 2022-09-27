// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeKeyPairsResponseBody : TeaModel {
        [NameInMap("KeyPairs")]
        [Validation(Required=false)]
        public DescribeKeyPairsResponseBodyKeyPairs KeyPairs { get; set; }
        public class DescribeKeyPairsResponseBodyKeyPairs : TeaModel {
            [NameInMap("KeyPair")]
            [Validation(Required=false)]
            public List<DescribeKeyPairsResponseBodyKeyPairsKeyPair> KeyPair { get; set; }
            public class DescribeKeyPairsResponseBodyKeyPairsKeyPair : TeaModel {
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("KeyPairFingerPrint")]
                [Validation(Required=false)]
                public string KeyPairFingerPrint { get; set; }

                [NameInMap("KeyPairName")]
                [Validation(Required=false)]
                public string KeyPairName { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeKeyPairsResponseBodyKeyPairsKeyPairTags Tags { get; set; }
                public class DescribeKeyPairsResponseBodyKeyPairsKeyPairTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeKeyPairsResponseBodyKeyPairsKeyPairTagsTag> Tag { get; set; }
                    public class DescribeKeyPairsResponseBodyKeyPairsKeyPairTagsTag : TeaModel {
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

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
