// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeRegionsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Regions")]
        [Validation(Required=true)]
        public List<DescribeRegionsResponseRegions> Regions { get; set; }
        public class DescribeRegionsResponseRegions : TeaModel {
            [NameInMap("RegionEnName")]
            [Validation(Required=true)]
            public string RegionEnName { get; set; }

            [NameInMap("RegionName")]
            [Validation(Required=true)]
            public string RegionName { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=true)]
            public string RegionId { get; set; }

        }

    }

}
