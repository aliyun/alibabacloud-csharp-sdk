// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeTableDetailResponseBody : TeaModel {
        [NameInMap("AvgSize")]
        [Validation(Required=false)]
        public long? AvgSize { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeTableDetailResponseBodyItems Items { get; set; }
        public class DescribeTableDetailResponseBodyItems : TeaModel {
            [NameInMap("Shard")]
            [Validation(Required=false)]
            public List<DescribeTableDetailResponseBodyItemsShard> Shard { get; set; }
            public class DescribeTableDetailResponseBodyItemsShard : TeaModel {
                public int? Id { get; set; }
                public long? Size { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
