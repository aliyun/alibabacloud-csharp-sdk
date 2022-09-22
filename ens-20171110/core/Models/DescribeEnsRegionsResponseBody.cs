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
                [NameInMap("Area")]
                [Validation(Required=false)]
                public string Area { get; set; }

                [NameInMap("EnName")]
                [Validation(Required=false)]
                public string EnName { get; set; }

                [NameInMap("EnsRegionId")]
                [Validation(Required=false)]
                public string EnsRegionId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Province")]
                [Validation(Required=false)]
                public string Province { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
