// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class QueryClusterSpecificationResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryClusterSpecificationResponseBodyData> Data { get; set; }
        public class QueryClusterSpecificationResponseBodyData : TeaModel {
            [NameInMap("ClusterSpecificationName")]
            [Validation(Required=false)]
            public string ClusterSpecificationName { get; set; }

            [NameInMap("DiskCapacity")]
            [Validation(Required=false)]
            public string DiskCapacity { get; set; }

            [NameInMap("MemoryCapacity")]
            [Validation(Required=false)]
            public string MemoryCapacity { get; set; }

            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public string InstanceCount { get; set; }

            [NameInMap("MaxTps")]
            [Validation(Required=false)]
            public string MaxTps { get; set; }

            [NameInMap("MaxCon")]
            [Validation(Required=false)]
            public string MaxCon { get; set; }

            [NameInMap("CpuCapacity")]
            [Validation(Required=false)]
            public string CpuCapacity { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
