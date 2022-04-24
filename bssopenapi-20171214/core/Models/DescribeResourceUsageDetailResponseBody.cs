// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeResourceUsageDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeResourceUsageDetailResponseBodyData Data { get; set; }
        public class DescribeResourceUsageDetailResponseBodyData : TeaModel {
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<DescribeResourceUsageDetailResponseBodyDataItems> Items { get; set; }
            public class DescribeResourceUsageDetailResponseBodyDataItems : TeaModel {
                public string CapacityUnit { get; set; }
                public string Currency { get; set; }
                public float? DeductQuantity { get; set; }
                public string EndTime { get; set; }
                public string ImageType { get; set; }
                public string InstanceSpec { get; set; }
                public string PostpaidCost { get; set; }
                public string PotentialSavedCost { get; set; }
                public long? Quantity { get; set; }
                public string Region { get; set; }
                public string RegionNo { get; set; }
                public string ReservationCost { get; set; }
                public string ResourceInstanceId { get; set; }
                public string SavedCost { get; set; }
                public string StartTime { get; set; }
                public string Status { get; set; }
                public string StatusName { get; set; }
                public float? TotalQuantity { get; set; }
                public float? UsagePercentage { get; set; }
                public string UserId { get; set; }
                public string UserName { get; set; }
                public string Zone { get; set; }
                public string ZoneName { get; set; }
            }
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
