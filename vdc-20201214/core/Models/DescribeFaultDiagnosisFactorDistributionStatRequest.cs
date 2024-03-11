// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeFaultDiagnosisFactorDistributionStatRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("EndTs")]
        [Validation(Required=false)]
        public long? EndTs { get; set; }

        [NameInMap("StartTs")]
        [Validation(Required=false)]
        public long? StartTs { get; set; }

    }

}
