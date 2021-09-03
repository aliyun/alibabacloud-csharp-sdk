// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class DeleteStackInstancesShrinkRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("StackGroupName")]
        [Validation(Required=false)]
        public string StackGroupName { get; set; }

        [NameInMap("AccountIds")]
        [Validation(Required=false)]
        public string AccountIdsShrink { get; set; }

        [NameInMap("RegionIds")]
        [Validation(Required=false)]
        public string RegionIdsShrink { get; set; }

        [NameInMap("RetainStacks")]
        [Validation(Required=false)]
        public bool? RetainStacks { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("OperationDescription")]
        [Validation(Required=false)]
        public string OperationDescription { get; set; }

        [NameInMap("OperationPreferences")]
        [Validation(Required=false)]
        public string OperationPreferencesShrink { get; set; }

        [NameInMap("DeploymentTargets")]
        [Validation(Required=false)]
        public string DeploymentTargetsShrink { get; set; }

    }

}
