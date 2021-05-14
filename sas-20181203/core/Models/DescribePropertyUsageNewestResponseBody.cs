// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyUsageNewestResponseBody : TeaModel {
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("ItemCount")]
        [Validation(Required=false)]
        public int? ItemCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("NewestStatisticItems")]
        [Validation(Required=false)]
        public List<DescribePropertyUsageNewestResponseBodyNewestStatisticItems> NewestStatisticItems { get; set; }
        public class DescribePropertyUsageNewestResponseBodyNewestStatisticItems : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Create")]
            [Validation(Required=false)]
            public long? Create { get; set; }

        }

    }

}
