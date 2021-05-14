// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeInstanceSwitchAzoneResponseBody : TeaModel {
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeInstanceSwitchAzoneResponseBodyResult Result { get; set; }
        public class DescribeInstanceSwitchAzoneResponseBodyResult : TeaModel {
            [NameInMap("OriginAzoneId")]
            [Validation(Required=false)]
            public string OriginAzoneId { get; set; }
            [NameInMap("SwitchAble")]
            [Validation(Required=false)]
            public bool? SwitchAble { get; set; }
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }
            [NameInMap("TargetAzones")]
            [Validation(Required=false)]
            public DescribeInstanceSwitchAzoneResponseBodyResultTargetAzones TargetAzones { get; set; }
            public class DescribeInstanceSwitchAzoneResponseBodyResultTargetAzones : TeaModel {
                [NameInMap("TargetAzone")]
                [Validation(Required=false)]
                public List<string> TargetAzone { get; set; }

            }
        };

    }

}
