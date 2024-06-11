// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeRegionsResponseBody : TeaModel {
        [NameInMap("RegionModels")]
        [Validation(Required=false)]
        public List<DescribeRegionsResponseBodyRegionModels> RegionModels { get; set; }
        public class DescribeRegionsResponseBodyRegionModels : TeaModel {
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
