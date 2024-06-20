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
            [NameInMap("ContractProjects")]
            [Validation(Required=false)]
            public List<DescribeAntChainContractProjectsResponseBodyResultContractProjects> ContractProjects { get; set; }
            public class DescribeAntChainContractProjectsResponseBodyResultContractProjects : TeaModel {
                [NameInMap("ConsortiumId")]
                [Validation(Required=false)]
                public string ConsortiumId { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("ProjectDescription")]
                [Validation(Required=false)]
                public string ProjectDescription { get; set; }

                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public string ProjectId { get; set; }

                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                [NameInMap("ProjectVersion")]
                [Validation(Required=false)]
                public string ProjectVersion { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

            [NameInMap("Pagination")]
            [Validation(Required=false)]
            public DescribeAntChainContractProjectsResponseBodyResultPagination Pagination { get; set; }
            public class DescribeAntChainContractProjectsResponseBodyResultPagination : TeaModel {
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
