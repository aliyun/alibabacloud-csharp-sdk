// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class DescribeAppResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public DescribeAppResponseBodyResult Result { get; set; }
        public class DescribeAppResponseBodyResult : TeaModel {
            [NameInMap("created")]
            [Validation(Required=false)]
            public int? Created { get; set; }
            [NameInMap("clusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }
            [NameInMap("autoSwitch")]
            [Validation(Required=false)]
            public bool? AutoSwitch { get; set; }
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("schema")]
            [Validation(Required=false)]
            public Dictionary<string, string> Schema { get; set; }
            [NameInMap("progressPercent")]
            [Validation(Required=false)]
            public int? ProgressPercent { get; set; }
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("algoDeploymentId")]
            [Validation(Required=false)]
            public int? AlgoDeploymentId { get; set; }
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("fetchFields")]
            [Validation(Required=false)]
            public List<string> FetchFields { get; set; }
            [NameInMap("quota")]
            [Validation(Required=false)]
            public DescribeAppResponseBodyResultQuota Quota { get; set; }
            public class DescribeAppResponseBodyResultQuota : TeaModel {
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                [NameInMap("qps")]
                [Validation(Required=false)]
                public int? Qps { get; set; }

                [NameInMap("docSize")]
                [Validation(Required=false)]
                public int? DocSize { get; set; }

                [NameInMap("computeResource")]
                [Validation(Required=false)]
                public int? ComputeResource { get; set; }

            }
        };

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
