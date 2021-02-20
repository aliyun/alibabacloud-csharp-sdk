// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsRegionsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("EnsRegions")]
        [Validation(Required=false)]
        public DescribeEnsRegionsResponseBodyEnsRegions EnsRegions { get; set; }
        public class DescribeEnsRegionsResponseBodyEnsRegions : TeaModel {
            [NameInMap("EnsRegions")]
            [Validation(Required=false)]
            public List<DescribeEnsRegionsResponseBodyEnsRegionsEnsRegions> EnsRegions { get; set; }
            public class DescribeEnsRegionsResponseBodyEnsRegionsEnsRegions : TeaModel {
                public string Area { get; set; }
                public string EnName { get; set; }
                public string EnsRegionId { get; set; }
                public string Name { get; set; }
                public string Province { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
