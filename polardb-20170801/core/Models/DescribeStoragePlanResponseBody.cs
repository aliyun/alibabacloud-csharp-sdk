// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeStoragePlanResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeStoragePlanResponseBodyItems> Items { get; set; }
        public class DescribeStoragePlanResponseBodyItems : TeaModel {
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public string AliUid { get; set; }

            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            [NameInMap("EndTimes")]
            [Validation(Required=false)]
            public string EndTimes { get; set; }

            [NameInMap("InitCapaCityViewUnit")]
            [Validation(Required=false)]
            public string InitCapaCityViewUnit { get; set; }

            [NameInMap("InitCapacityViewValue")]
            [Validation(Required=false)]
            public string InitCapacityViewValue { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("PeriodCapaCityViewUnit")]
            [Validation(Required=false)]
            public string PeriodCapaCityViewUnit { get; set; }

            [NameInMap("PeriodCapacityViewValue")]
            [Validation(Required=false)]
            public string PeriodCapacityViewValue { get; set; }

            [NameInMap("PeriodTime")]
            [Validation(Required=false)]
            public string PeriodTime { get; set; }

            [NameInMap("ProdCode")]
            [Validation(Required=false)]
            public string ProdCode { get; set; }

            [NameInMap("PurchaseTimes")]
            [Validation(Required=false)]
            public string PurchaseTimes { get; set; }

            [NameInMap("StartTimes")]
            [Validation(Required=false)]
            public string StartTimes { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

    }

}
