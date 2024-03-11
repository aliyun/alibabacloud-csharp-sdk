// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeFaultDiagnosisFactorDistributionStatResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StatList")]
        [Validation(Required=false)]
        public List<DescribeFaultDiagnosisFactorDistributionStatResponseBodyStatList> StatList { get; set; }
        public class DescribeFaultDiagnosisFactorDistributionStatResponseBodyStatList : TeaModel {
            [NameInMap("FactorId")]
            [Validation(Required=false)]
            public string FactorId { get; set; }

            [NameInMap("UserCount")]
            [Validation(Required=false)]
            public int? UserCount { get; set; }

            [NameInMap("UserRatio")]
            [Validation(Required=false)]
            public float? UserRatio { get; set; }

        }

    }

}
