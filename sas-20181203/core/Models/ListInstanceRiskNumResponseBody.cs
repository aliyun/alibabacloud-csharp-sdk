// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListInstanceRiskNumResponseBody : TeaModel {
        [NameInMap("InstanceRiskNum")]
        [Validation(Required=false)]
        public List<ListInstanceRiskNumResponseBodyInstanceRiskNum> InstanceRiskNum { get; set; }
        public class ListInstanceRiskNumResponseBodyInstanceRiskNum : TeaModel {
            [NameInMap("InstanceItem")]
            [Validation(Required=false)]
            public ListInstanceRiskNumResponseBodyInstanceRiskNumInstanceItem InstanceItem { get; set; }
            public class ListInstanceRiskNumResponseBodyInstanceRiskNumInstanceItem : TeaModel {
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            [NameInMap("RiskNumEntity")]
            [Validation(Required=false)]
            public ListInstanceRiskNumResponseBodyInstanceRiskNumRiskNumEntity RiskNumEntity { get; set; }
            public class ListInstanceRiskNumResponseBodyInstanceRiskNumRiskNumEntity : TeaModel {
                [NameInMap("SuspiciousHighCount")]
                [Validation(Required=false)]
                public int? SuspiciousHighCount { get; set; }

                [NameInMap("SuspiciousLowCount")]
                [Validation(Required=false)]
                public int? SuspiciousLowCount { get; set; }

                [NameInMap("SuspiciousMediumCount")]
                [Validation(Required=false)]
                public int? SuspiciousMediumCount { get; set; }

                [NameInMap("VulHighCount")]
                [Validation(Required=false)]
                public int? VulHighCount { get; set; }

                [NameInMap("VulLowCount")]
                [Validation(Required=false)]
                public int? VulLowCount { get; set; }

                [NameInMap("VulMediumCount")]
                [Validation(Required=false)]
                public int? VulMediumCount { get; set; }

                [NameInMap("WeakPassWordCount")]
                [Validation(Required=false)]
                public int? WeakPassWordCount { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
