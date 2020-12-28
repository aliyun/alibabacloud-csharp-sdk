// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ahas_openapi20190901.Models
{
    public class ExecuteExperimentRequest : TeaModel {
        [NameInMap("ExperimentId")]
        [Validation(Required=false)]
        public string ExperimentId { get; set; }

        [NameInMap("NameSpace")]
        [Validation(Required=false)]
        public string NameSpace { get; set; }

        [NameInMap("Definition")]
        [Validation(Required=false)]
        public string Definition { get; set; }

        [NameInMap("AhasRegionId")]
        [Validation(Required=false)]
        public string AhasRegionId { get; set; }

    }

}
