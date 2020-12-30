// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class ClassifyVehicleInsuranceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ClassifyVehicleInsuranceResponseBodyData Data { get; set; }
        public class ClassifyVehicleInsuranceResponseBodyData : TeaModel {
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<ClassifyVehicleInsuranceResponseBodyDataLabels> Labels { get; set; }
            public class ClassifyVehicleInsuranceResponseBodyDataLabels : TeaModel {
                public float? Score { get; set; }
                public string Name { get; set; }
            }
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public float? Threshold { get; set; }
        };

    }

}
