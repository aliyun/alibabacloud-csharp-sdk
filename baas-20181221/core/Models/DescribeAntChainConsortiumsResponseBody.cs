// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20181221.Models
{
    public class DescribeAntChainConsortiumsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeAntChainConsortiumsResponseBodyResult Result { get; set; }
        public class DescribeAntChainConsortiumsResponseBodyResult : TeaModel {
            [NameInMap("AntConsortiums")]
            [Validation(Required=false)]
            public List<DescribeAntChainConsortiumsResponseBodyResultAntConsortiums> AntConsortiums { get; set; }
            public class DescribeAntChainConsortiumsResponseBodyResultAntConsortiums : TeaModel {
                public string ConsortiumDescription { get; set; }
                public string Status { get; set; }
                public string ConsortiumId { get; set; }
                public long? CreateTime { get; set; }
                public long? MemberNum { get; set; }
                public string Role { get; set; }
                public string ConsortiumName { get; set; }
                public long? ChainNum { get; set; }
            }
            [NameInMap("Pagination")]
            [Validation(Required=false)]
            public DescribeAntChainConsortiumsResponseBodyResultPagination Pagination { get; set; }
            public class DescribeAntChainConsortiumsResponseBodyResultPagination : TeaModel {
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
        };

    }

}
