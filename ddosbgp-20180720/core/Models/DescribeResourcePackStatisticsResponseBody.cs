// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeResourcePackStatisticsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalInitCapacity")]
        [Validation(Required=false)]
        public long? TotalInitCapacity { get; set; }

        [NameInMap("TotalCurrCapacity")]
        [Validation(Required=false)]
        public long? TotalCurrCapacity { get; set; }

        [NameInMap("AvailablePackNum")]
        [Validation(Required=false)]
        public int? AvailablePackNum { get; set; }

        [NameInMap("TotalUsedCapacity")]
        [Validation(Required=false)]
        public long? TotalUsedCapacity { get; set; }

    }

}
