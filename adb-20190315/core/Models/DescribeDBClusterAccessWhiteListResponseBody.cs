// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDBClusterAccessWhiteListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBClusterAccessWhiteListResponseBodyItems Items { get; set; }
        public class DescribeDBClusterAccessWhiteListResponseBodyItems : TeaModel {
            [NameInMap("IPArray")]
            [Validation(Required=false)]
            public List<DescribeDBClusterAccessWhiteListResponseBodyItemsIPArray> IPArray { get; set; }
            public class DescribeDBClusterAccessWhiteListResponseBodyItemsIPArray : TeaModel {
                public string DBClusterIPArrayAttribute { get; set; }
                public string SecurityIPList { get; set; }
                public string DBClusterIPArrayName { get; set; }
            }
        };

    }

}
