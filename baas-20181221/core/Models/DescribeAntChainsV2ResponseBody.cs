// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20181221.Models
{
    public class DescribeAntChainsV2ResponseBody : TeaModel {
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
        public DescribeAntChainsV2ResponseBodyResult Result { get; set; }
        public class DescribeAntChainsV2ResponseBodyResult : TeaModel {
            [NameInMap("AntChains")]
            [Validation(Required=false)]
            public List<DescribeAntChainsV2ResponseBodyResultAntChains> AntChains { get; set; }
            public class DescribeAntChainsV2ResponseBodyResultAntChains : TeaModel {
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

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("IsAdmin")]
                [Validation(Required=false)]
                public bool? IsAdmin { get; set; }

                [NameInMap("MemberStatus")]
                [Validation(Required=false)]
                public string MemberStatus { get; set; }

                [NameInMap("MerkleTreeSuit")]
                [Validation(Required=false)]
                public string MerkleTreeSuit { get; set; }

                [NameInMap("MonitorStatus")]
                [Validation(Required=false)]
                public bool? MonitorStatus { get; set; }

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

                [NameInMap("RestStatus")]
                [Validation(Required=false)]
                public string RestStatus { get; set; }

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
            public DescribeAntChainsV2ResponseBodyResultPagination Pagination { get; set; }
            public class DescribeAntChainsV2ResponseBodyResultPagination : TeaModel {
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
