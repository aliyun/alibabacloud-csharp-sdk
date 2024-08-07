// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20181221.Models
{
    public class DescribeAntChainConsortiumsV2ResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeAntChainConsortiumsV2ResponseBodyResult Result { get; set; }
        public class DescribeAntChainConsortiumsV2ResponseBodyResult : TeaModel {
            [NameInMap("AntConsortiums")]
            [Validation(Required=false)]
            public List<DescribeAntChainConsortiumsV2ResponseBodyResultAntConsortiums> AntConsortiums { get; set; }
            public class DescribeAntChainConsortiumsV2ResponseBodyResultAntConsortiums : TeaModel {
                [NameInMap("ChainNum")]
                [Validation(Required=false)]
                public long? ChainNum { get; set; }

                [NameInMap("ConsortiumDescription")]
                [Validation(Required=false)]
                public string ConsortiumDescription { get; set; }

                [NameInMap("ConsortiumId")]
                [Validation(Required=false)]
                public string ConsortiumId { get; set; }

                [NameInMap("ConsortiumName")]
                [Validation(Required=false)]
                public string ConsortiumName { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("IsEmptyConsortium")]
                [Validation(Required=false)]
                public bool? IsEmptyConsortium { get; set; }

                [NameInMap("MemberNum")]
                [Validation(Required=false)]
                public long? MemberNum { get; set; }

                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("Pagination")]
            [Validation(Required=false)]
            public DescribeAntChainConsortiumsV2ResponseBodyResultPagination Pagination { get; set; }
            public class DescribeAntChainConsortiumsV2ResponseBodyResultPagination : TeaModel {
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

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
