// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeDiagnoseResponseBody : TeaModel {
        [NameInMap("DiagnoseInstances")]
        [Validation(Required=false)]
        public DescribeDiagnoseResponseBodyDiagnoseInstances DiagnoseInstances { get; set; }
        public class DescribeDiagnoseResponseBodyDiagnoseInstances : TeaModel {
            [NameInMap("DiagnoseInstance")]
            [Validation(Required=false)]
            public List<DescribeDiagnoseResponseBodyDiagnoseInstancesDiagnoseInstance> DiagnoseInstance { get; set; }
            public class DescribeDiagnoseResponseBodyDiagnoseInstancesDiagnoseInstance : TeaModel {
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("DiagnoseAction")]
                [Validation(Required=false)]
                public string DiagnoseAction { get; set; }

                [NameInMap("DiagnoseId")]
                [Validation(Required=false)]
                public string DiagnoseId { get; set; }

                [NameInMap("DiagnoseRequestId")]
                [Validation(Required=false)]
                public string DiagnoseRequestId { get; set; }

                [NameInMap("DiskCategory")]
                [Validation(Required=false)]
                public string DiskCategory { get; set; }

                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }

                [NameInMap("InstanceTypeName")]
                [Validation(Required=false)]
                public string InstanceTypeName { get; set; }

                [NameInMap("IzNo")]
                [Validation(Required=false)]
                public string IzNo { get; set; }

                [NameInMap("Mark")]
                [Validation(Required=false)]
                public string Mark { get; set; }

                [NameInMap("ModificationTime")]
                [Validation(Required=false)]
                public string ModificationTime { get; set; }

                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                [NameInMap("Period")]
                [Validation(Required=false)]
                public int? Period { get; set; }

                [NameInMap("PeriodUnit")]
                [Validation(Required=false)]
                public string PeriodUnit { get; set; }

                [NameInMap("Product")]
                [Validation(Required=false)]
                public string Product { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("Solutions")]
                [Validation(Required=false)]
                public string Solutions { get; set; }

                [NameInMap("Star")]
                [Validation(Required=false)]
                public int? Star { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
