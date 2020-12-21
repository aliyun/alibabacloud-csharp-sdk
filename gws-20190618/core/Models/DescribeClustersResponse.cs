// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gws20190618.Models
{
    public class DescribeClustersResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public long TotalCount { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=true)]
        public long PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public long PageSize { get; set; }

        [NameInMap("Clusters")]
        [Validation(Required=true)]
        public List<DescribeClustersResponseClusters> Clusters { get; set; }
        public class DescribeClustersResponseClusters : TeaModel {
            [NameInMap("ClusterId")]
            [Validation(Required=true)]
            public string ClusterId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=true)]
            public string Name { get; set; }

            [NameInMap("Status")]
            [Validation(Required=true)]
            public string Status { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=true)]
            public string VpcId { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=true)]
            public string CreateTime { get; set; }

            [NameInMap("SecurityGroup")]
            [Validation(Required=true)]
            public string SecurityGroup { get; set; }

            [NameInMap("DomainName")]
            [Validation(Required=true)]
            public string DomainName { get; set; }

            [NameInMap("NatId")]
            [Validation(Required=true)]
            public string NatId { get; set; }

            [NameInMap("NatEip")]
            [Validation(Required=true)]
            public string NatEip { get; set; }

            [NameInMap("InstanceCount")]
            [Validation(Required=true)]
            public long InstanceCount { get; set; }

        }

    }

}
