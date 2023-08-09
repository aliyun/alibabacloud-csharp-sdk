// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeKeyPairsResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("KeyPairs")]
        [Validation(Required=false)]
        public DescribeKeyPairsResponseBodyKeyPairs KeyPairs { get; set; }
        public class DescribeKeyPairsResponseBodyKeyPairs : TeaModel {
            [NameInMap("KeyPair")]
            [Validation(Required=false)]
            public List<DescribeKeyPairsResponseBodyKeyPairsKeyPair> KeyPair { get; set; }
            public class DescribeKeyPairsResponseBodyKeyPairsKeyPair : TeaModel {
                /// <summary>
                /// The number of entries returned per page.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// Queries one or more key pairs.
                /// </summary>
                [NameInMap("KeyPairFingerPrint")]
                [Validation(Required=false)]
                public string KeyPairFingerPrint { get; set; }

                /// <summary>
                /// The ID of the request.
                /// </summary>
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

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The tags of the key pair.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The tag value of the key pair.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of the page to return. Pages start from page 1.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
