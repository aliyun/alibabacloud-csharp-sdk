// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class UpdateTemplateScratchShrinkRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("ExecutionMode")]
        [Validation(Required=false)]
        public string ExecutionMode { get; set; }

        [NameInMap("LogicalIdStrategy")]
        [Validation(Required=false)]
        public string LogicalIdStrategy { get; set; }

        [NameInMap("PreferenceParameters")]
        [Validation(Required=false)]
        public string PreferenceParametersShrink { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SourceResourceGroup")]
        [Validation(Required=false)]
        public string SourceResourceGroupShrink { get; set; }

        [NameInMap("SourceResources")]
        [Validation(Required=false)]
        public string SourceResourcesShrink { get; set; }

        [NameInMap("SourceTag")]
        [Validation(Required=false)]
        public string SourceTagShrink { get; set; }

        [NameInMap("TemplateScratchId")]
        [Validation(Required=false)]
        public string TemplateScratchId { get; set; }

    }

}
