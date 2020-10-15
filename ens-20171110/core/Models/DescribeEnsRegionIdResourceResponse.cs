// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsRegionIdResourceResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=true)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("EnsRegionIdResources")]
        [Validation(Required=true)]
        public DescribeEnsRegionIdResourceResponseEnsRegionIdResources EnsRegionIdResources { get; set; }
        public class DescribeEnsRegionIdResourceResponseEnsRegionIdResources : TeaModel {
            [NameInMap("EnsRegionIdResource")]
            [Validation(Required=true)]
            public List<DescribeEnsRegionIdResourceResponseEnsRegionIdResourcesEnsRegionIdResource> EnsRegionIdResource { get; set; }
            public class DescribeEnsRegionIdResourceResponseEnsRegionIdResourcesEnsRegionIdResource : TeaModel {
                public string Area { get; set; }
                public string AreaCode { get; set; }
                public string EnsRegionId { get; set; }
                public string EnsRegionIdName { get; set; }
                public int? VCpu { get; set; }
                public int? InternetBandwidth { get; set; }
                public string Isp { get; set; }
                public string BizDate { get; set; }
                public int? InstanceCount { get; set; }
            }
        };

    }

}
