// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gws20190618.Models
{
    public class DescribeAvailableResourceResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("AvailableResources")]
        [Validation(Required=true)]
        public List<DescribeAvailableResourceResponseAvailableResources> AvailableResources { get; set; }
        public class DescribeAvailableResourceResponseAvailableResources : TeaModel {
            [NameInMap("ClusterType")]
            [Validation(Required=true)]
            public string ClusterType { get; set; }

            [NameInMap("Zone")]
            [Validation(Required=true)]
            public string Zone { get; set; }

        }

    }

}
