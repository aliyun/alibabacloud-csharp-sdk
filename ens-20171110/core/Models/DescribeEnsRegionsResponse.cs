// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsRegionsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public int? Code { get; set; }

        [NameInMap("EnsRegions")]
        [Validation(Required=true)]
        public DescribeEnsRegionsResponseEnsRegions EnsRegions { get; set; }
        public class DescribeEnsRegionsResponseEnsRegions : TeaModel {
            [NameInMap("EnsRegions")]
            [Validation(Required=true)]
            public List<DescribeEnsRegionsResponseEnsRegionsEnsRegions> EnsRegions { get; set; }
            public class DescribeEnsRegionsResponseEnsRegionsEnsRegions : TeaModel {
                public string EnsRegionId { get; set; }
                public string Name { get; set; }
                public string EnName { get; set; }
                public string Area { get; set; }
                public string Province { get; set; }
            }
        };

    }

}
