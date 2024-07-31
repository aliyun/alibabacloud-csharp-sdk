// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeHybridCloudClustersResponseBody : TeaModel {
        [NameInMap("ClusterInfos")]
        [Validation(Required=false)]
        public List<DescribeHybridCloudClustersResponseBodyClusterInfos> ClusterInfos { get; set; }
        public class DescribeHybridCloudClustersResponseBodyClusterInfos : TeaModel {
            [NameInMap("AccessMode")]
            [Validation(Required=false)]
            public string AccessMode { get; set; }

            [NameInMap("AccessRegion")]
            [Validation(Required=false)]
            public string AccessRegion { get; set; }

            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            [NameInMap("ClusterResourceId")]
            [Validation(Required=false)]
            public string ClusterResourceId { get; set; }

            [NameInMap("HttpPorts")]
            [Validation(Required=false)]
            public string HttpPorts { get; set; }

            [NameInMap("HttpsPorts")]
            [Validation(Required=false)]
            public string HttpsPorts { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("ProtectionServerCount")]
            [Validation(Required=false)]
            public int? ProtectionServerCount { get; set; }

            [NameInMap("ProxyStatus")]
            [Validation(Required=false)]
            public string ProxyStatus { get; set; }

            [NameInMap("ProxyType")]
            [Validation(Required=false)]
            public string ProxyType { get; set; }

            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("RuleConfig")]
            [Validation(Required=false)]
            public string RuleConfig { get; set; }

            [NameInMap("RuleStatus")]
            [Validation(Required=false)]
            public string RuleStatus { get; set; }

            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
