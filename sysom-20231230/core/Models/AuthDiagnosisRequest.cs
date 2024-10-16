// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class AuthDiagnosisRequest : TeaModel {
        [NameInMap("autoCreateRole")]
        [Validation(Required=false)]
        public bool? AutoCreateRole { get; set; }

        [NameInMap("autoInstallAgent")]
        [Validation(Required=false)]
        public bool? AutoInstallAgent { get; set; }

        [NameInMap("instances")]
        [Validation(Required=false)]
        public List<AuthDiagnosisRequestInstances> Instances { get; set; }
        public class AuthDiagnosisRequestInstances : TeaModel {
            [NameInMap("instance")]
            [Validation(Required=false)]
            public string Instance { get; set; }

            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }

        }

    }

}
