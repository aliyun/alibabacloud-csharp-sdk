// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wuying_personal_pc20251111.Models
{
    public class DescribeCorePackageListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("CorePackageInfo")]
        [Validation(Required=false)]
        public DescribeCorePackageListResponseBodyCorePackageInfo CorePackageInfo { get; set; }
        public class DescribeCorePackageListResponseBodyCorePackageInfo : TeaModel {
            [NameInMap("CorePackageList")]
            [Validation(Required=false)]
            public List<DescribeCorePackageListResponseBodyCorePackageInfoCorePackageList> CorePackageList { get; set; }
            public class DescribeCorePackageListResponseBodyCorePackageInfoCorePackageList : TeaModel {
                [NameInMap("AssignedCoreHours")]
                [Validation(Required=false)]
                public float? AssignedCoreHours { get; set; }

                [NameInMap("DeductionInstanceList")]
                [Validation(Required=false)]
                public List<object> DeductionInstanceList { get; set; }

                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("PeriodEndTime")]
                [Validation(Required=false)]
                public string PeriodEndTime { get; set; }

                [NameInMap("PeriodStartTime")]
                [Validation(Required=false)]
                public string PeriodStartTime { get; set; }

                [NameInMap("ProductType")]
                [Validation(Required=false)]
                public string ProductType { get; set; }

                [NameInMap("RemainingCoreHours")]
                [Validation(Required=false)]
                public float? RemainingCoreHours { get; set; }

                [NameInMap("RemainingPeriods")]
                [Validation(Required=false)]
                public List<DescribeCorePackageListResponseBodyCorePackageInfoCorePackageListRemainingPeriods> RemainingPeriods { get; set; }
                public class DescribeCorePackageListResponseBodyCorePackageInfoCorePackageListRemainingPeriods : TeaModel {
                    [NameInMap("PeriodEndTime")]
                    [Validation(Required=false)]
                    public string PeriodEndTime { get; set; }

                    [NameInMap("PeriodStartTime")]
                    [Validation(Required=false)]
                    public string PeriodStartTime { get; set; }

                    [NameInMap("RemainingCoreHours")]
                    [Validation(Required=false)]
                    public float? RemainingCoreHours { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("TotalCoreHours")]
                    [Validation(Required=false)]
                    public float? TotalCoreHours { get; set; }

                    [NameInMap("UsedCoreHours")]
                    [Validation(Required=false)]
                    public float? UsedCoreHours { get; set; }

                }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TotalCoreHours")]
                [Validation(Required=false)]
                public float? TotalCoreHours { get; set; }

                [NameInMap("UnassignedCoreHours")]
                [Validation(Required=false)]
                public float? UnassignedCoreHours { get; set; }

                [NameInMap("UsedCoreHours")]
                [Validation(Required=false)]
                public float? UsedCoreHours { get; set; }

            }

            [NameInMap("SummaryRemainingCoreHours")]
            [Validation(Required=false)]
            public float? SummaryRemainingCoreHours { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
