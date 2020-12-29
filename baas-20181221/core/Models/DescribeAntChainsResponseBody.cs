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
            [NameInMap("Pagination")]
            [Validation(Required=false)]
            public DescribeAntChainsResponseBodyResultPagination Pagination { get; set; }
            public class DescribeAntChainsResponseBodyResultPagination : TeaModel {
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                [NameInMap("PageNumber")]
                [Validation(Required=false)]
                public int? PageNumber { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }
            [NameInMap("AntChains")]
            [Validation(Required=false)]
            public List<DescribeAntChainsResponseBodyResultAntChains> AntChains { get; set; }
            public class DescribeAntChainsResponseBodyResultAntChains : TeaModel {
                public long? ExpireTime { get; set; }
                public long? CreateTime { get; set; }
                public string ChainType { get; set; }
                public bool? IsAdmin { get; set; }
                public string MerkleTreeSuit { get; set; }
                public string MemberStatus { get; set; }
                public string RegionId { get; set; }
                public string AntChainName { get; set; }
                public string Network { get; set; }
                public string TlsAlgo { get; set; }
                public string Version { get; set; }
                public string CipherSuit { get; set; }
                public string ResourceSize { get; set; }
                public int? NodeNum { get; set; }
                public string AntChainId { get; set; }
            }
            [NameInMap("IsExist")]
            [Validation(Required=false)]
            public bool? IsExist { get; set; }
        };

    }

}
