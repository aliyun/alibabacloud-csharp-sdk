// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20181221.Models
{
    public class DescribeAntChainsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeAntChainsResponseBodyResult Result { get; set; }
        public class DescribeAntChainsResponseBodyResult : TeaModel {
            [NameInMap("AntChains")]
            [Validation(Required=false)]
            public List<DescribeAntChainsResponseBodyResultAntChains> AntChains { get; set; }
            public class DescribeAntChainsResponseBodyResultAntChains : TeaModel {
                [NameInMap("AntChainId")]
                [Validation(Required=false)]
                public string AntChainId { get; set; }

                [NameInMap("AntChainName")]
                [Validation(Required=false)]
                public string AntChainName { get; set; }

                [NameInMap("ChainType")]
                [Validation(Required=false)]
                public string ChainType { get; set; }

                [NameInMap("CipherSuit")]
                [Validation(Required=false)]
                public string CipherSuit { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public long? ExpireTime { get; set; }

                [NameInMap("IsAdmin")]
                [Validation(Required=false)]
                public bool? IsAdmin { get; set; }

                [NameInMap("MemberStatus")]
                [Validation(Required=false)]
                public string MemberStatus { get; set; }

                [NameInMap("MerkleTreeSuit")]
                [Validation(Required=false)]
                public string MerkleTreeSuit { get; set; }

                [NameInMap("Network")]
                [Validation(Required=false)]
                public string Network { get; set; }

                [NameInMap("NodeNum")]
                [Validation(Required=false)]
                public int? NodeNum { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ResourceSize")]
                [Validation(Required=false)]
                public string ResourceSize { get; set; }

                [NameInMap("TlsAlgo")]
                [Validation(Required=false)]
                public string TlsAlgo { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            [NameInMap("IsExist")]
            [Validation(Required=false)]
            public bool? IsExist { get; set; }

            [NameInMap("Pagination")]
            [Validation(Required=false)]
            public DescribeAntChainsResponseBodyResultPagination Pagination { get; set; }
            public class DescribeAntChainsResponseBodyResultPagination : TeaModel {
                [NameInMap("PageNumber")]
                [Validation(Required=false)]
                public int? PageNumber { get; set; }

                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }

        }

    }

}
