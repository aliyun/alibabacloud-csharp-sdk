// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20181221.Models
{
    public class DescribeAntChainContractProjectsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeAntChainContractProjectsResponseBodyResult Result { get; set; }
        public class DescribeAntChainContractProjectsResponseBodyResult : TeaModel {
            [NameInMap("Pagination")]
            [Validation(Required=false)]
            public DescribeAntChainContractProjectsResponseBodyResultPagination Pagination { get; set; }
            public class DescribeAntChainContractProjectsResponseBodyResultPagination : TeaModel {
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
            [NameInMap("ContractProjects")]
            [Validation(Required=false)]
            public List<DescribeAntChainContractProjectsResponseBodyResultContractProjects> ContractProjects { get; set; }
            public class DescribeAntChainContractProjectsResponseBodyResultContractProjects : TeaModel {
                public long? UpdateTime { get; set; }
                public string ConsortiumId { get; set; }
                public long? CreateTime { get; set; }
                public string ProjectId { get; set; }
                public string ProjectName { get; set; }
                public string ProjectVersion { get; set; }
                public string ProjectDescription { get; set; }
            }
        };

    }

}
