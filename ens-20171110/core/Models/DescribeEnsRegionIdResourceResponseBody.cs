// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsRegionIdResourceResponseBody : TeaModel {
        [NameInMap("EnsRegionIdResources")]
        [Validation(Required=false)]
        public DescribeEnsRegionIdResourceResponseBodyEnsRegionIdResources EnsRegionIdResources { get; set; }
        public class DescribeEnsRegionIdResourceResponseBodyEnsRegionIdResources : TeaModel {
            [NameInMap("EnsRegionIdResource")]
            [Validation(Required=false)]
            public List<DescribeEnsRegionIdResourceResponseBodyEnsRegionIdResourcesEnsRegionIdResource> EnsRegionIdResource { get; set; }
            public class DescribeEnsRegionIdResourceResponseBodyEnsRegionIdResourcesEnsRegionIdResource : TeaModel {
                public string Area { get; set; }
                public string AreaCode { get; set; }
                public string BizDate { get; set; }
                public string EnsRegionId { get; set; }
                public string EnsRegionIdName { get; set; }
                public int? InstanceCount { get; set; }
                public long? InternetBandwidth { get; set; }
                public string Isp { get; set; }
                public int? VCpu { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

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
