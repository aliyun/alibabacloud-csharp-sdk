// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class AddAKSDeploymentSidecarRequest : TeaModel {
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("AppVersion")]
        [Validation(Required=false)]
        public string AppVersion { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("DeployTemplate")]
        [Validation(Required=false)]
        public string DeployTemplate { get; set; }

        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

        [NameInMap("SidecarParams")]
        [Validation(Required=false)]
        public List<AddAKSDeploymentSidecarRequestSidecarParams> SidecarParams { get; set; }
        public class AddAKSDeploymentSidecarRequestSidecarParams : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
