// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class DetectStackGroupDriftShrinkRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=true)]
        public string RegionId { get; set; }

        [NameInMap("StackGroupName")]
        [Validation(Required=true)]
        public string StackGroupName { get; set; }

        [NameInMap("OperationPreferences")]
        [Validation(Required=false)]
        public string OperationPreferencesShrink { get; set; }

    }

}
