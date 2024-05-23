// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20160722.Models
{
    public class DescribeCapacityHistoryResponseBody : TeaModel {
        [NameInMap("CapacityHistoryItems")]
        [Validation(Required=false)]
        public DescribeCapacityHistoryResponseBodyCapacityHistoryItems CapacityHistoryItems { get; set; }
        public class DescribeCapacityHistoryResponseBodyCapacityHistoryItems : TeaModel {
            [NameInMap("CapacityHistoryModel")]
            [Validation(Required=false)]
            public List<DescribeCapacityHistoryResponseBodyCapacityHistoryItemsCapacityHistoryModel> CapacityHistoryModel { get; set; }
            public class DescribeCapacityHistoryResponseBodyCapacityHistoryItemsCapacityHistoryModel : TeaModel {
                [NameInMap("AttachedCapacity")]
                [Validation(Required=false)]
                public int? AttachedCapacity { get; set; }

                [NameInMap("AutoCreatedCapacity")]
                [Validation(Required=false)]
                public int? AutoCreatedCapacity { get; set; }

                [NameInMap("ScalingGroupId")]
                [Validation(Required=false)]
                public string ScalingGroupId { get; set; }

                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

                [NameInMap("TotalCapacity")]
                [Validation(Required=false)]
                public int? TotalCapacity { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
