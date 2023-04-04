// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Car : TeaModel {
        [NameInMap("Boundary")]
        [Validation(Required=false)]
        public Boundary Boundary { get; set; }

        [NameInMap("CarColor")]
        [Validation(Required=false)]
        public string CarColor { get; set; }

        [NameInMap("CarColorConfidence")]
        [Validation(Required=false)]
        public double? CarColorConfidence { get; set; }

        [NameInMap("CarType")]
        [Validation(Required=false)]
        public string CarType { get; set; }

        [NameInMap("CarTypeConfidence")]
        [Validation(Required=false)]
        public double? CarTypeConfidence { get; set; }

        [NameInMap("Confidence")]
        [Validation(Required=false)]
        public double? Confidence { get; set; }

        [NameInMap("LicensePlates")]
        [Validation(Required=false)]
        public List<LicensePlate> LicensePlates { get; set; }

    }

}
