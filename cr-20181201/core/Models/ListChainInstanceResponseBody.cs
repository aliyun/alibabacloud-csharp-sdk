// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListChainInstanceResponseBody : TeaModel {
        [NameInMap("ChainInstances")]
        [Validation(Required=false)]
        public List<ListChainInstanceResponseBodyChainInstances> ChainInstances { get; set; }
        public class ListChainInstanceResponseBodyChainInstances : TeaModel {
            [NameInMap("Chain")]
            [Validation(Required=false)]
            public ListChainInstanceResponseBodyChainInstancesChain Chain { get; set; }
            public class ListChainInstanceResponseBodyChainInstancesChain : TeaModel {
                [NameInMap("ChainId")]
                [Validation(Required=false)]
                public string ChainId { get; set; }
                [NameInMap("ChainName")]
                [Validation(Required=false)]
                public string ChainName { get; set; }
                [NameInMap("Version")]
                [Validation(Required=false)]
                public long? Version { get; set; }
            };

            [NameInMap("ChainInstanceId")]
            [Validation(Required=false)]
            public string ChainInstanceId { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

            [NameInMap("RepoNamespaceName")]
            [Validation(Required=false)]
            public string RepoNamespaceName { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

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
