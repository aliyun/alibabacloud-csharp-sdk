// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gws20190618.Models
{
    public class DescribeClustersResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("Clusters")]
        [Validation(Required=false)]
        public List<DescribeClustersResponseBodyClusters> Clusters { get; set; }
        public class DescribeClustersResponseBodyClusters : TeaModel {
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("NatId")]
            [Validation(Required=false)]
            public string NatId { get; set; }

            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public long? InstanceCount { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("NatEip")]
            [Validation(Required=false)]
            public string NatEip { get; set; }

            [NameInMap("SecurityGroup")]
            [Validation(Required=false)]
            public string SecurityGroup { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

        }

    }

}
