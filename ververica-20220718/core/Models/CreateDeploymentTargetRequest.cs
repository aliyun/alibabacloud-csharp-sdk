// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class CreateDeploymentTargetRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public ResourceSpec Body { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("deploymentTargetName")]
        [Validation(Required=false)]
        public string DeploymentTargetName { get; set; }

    }

}
