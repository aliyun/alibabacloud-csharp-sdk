// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20171120.Models
{
    public class DescribeResourcePackStatisticsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("AvailablePackNum")]
        [Validation(Required=true)]
        public int? AvailablePackNum { get; set; }

        [NameInMap("TotalCurrCapacity")]
        [Validation(Required=true)]
        public long TotalCurrCapacity { get; set; }

        [NameInMap("TotalUsedCapacity")]
        [Validation(Required=true)]
        public long TotalUsedCapacity { get; set; }

        [NameInMap("TotalInitCapacity")]
        [Validation(Required=true)]
        public long TotalInitCapacity { get; set; }

    }

}
