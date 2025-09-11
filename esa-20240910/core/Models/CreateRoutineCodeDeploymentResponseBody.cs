// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateRoutineCodeDeploymentResponseBody : TeaModel {
        [NameInMap("CodeVersions")]
        [Validation(Required=false)]
        public List<CreateRoutineCodeDeploymentResponseBodyCodeVersions> CodeVersions { get; set; }
        public class CreateRoutineCodeDeploymentResponseBodyCodeVersions : TeaModel {
            [NameInMap("CodeVersion")]
            [Validation(Required=false)]
            public string CodeVersion { get; set; }

            [NameInMap("Percentage")]
            [Validation(Required=false)]
            public long? Percentage { get; set; }

        }

        [NameInMap("DeploymentId")]
        [Validation(Required=false)]
        public string DeploymentId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Strategy")]
        [Validation(Required=false)]
        public string Strategy { get; set; }

    }

}
