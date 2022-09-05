// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class CreateTemplateScratchRequest : TeaModel {
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
        public List<CreateTemplateScratchRequestPreferenceParameters> PreferenceParameters { get; set; }
        public class CreateTemplateScratchRequestPreferenceParameters : TeaModel {
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SourceResourceGroup")]
        [Validation(Required=false)]
        public CreateTemplateScratchRequestSourceResourceGroup SourceResourceGroup { get; set; }
        public class CreateTemplateScratchRequestSourceResourceGroup : TeaModel {
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("ResourceTypeFilter")]
            [Validation(Required=false)]
            public List<string> ResourceTypeFilter { get; set; }

        }

        [NameInMap("SourceResources")]
        [Validation(Required=false)]
        public List<CreateTemplateScratchRequestSourceResources> SourceResources { get; set; }
        public class CreateTemplateScratchRequestSourceResources : TeaModel {
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        [NameInMap("SourceTag")]
        [Validation(Required=false)]
        public CreateTemplateScratchRequestSourceTag SourceTag { get; set; }
        public class CreateTemplateScratchRequestSourceTag : TeaModel {
            [NameInMap("ResourceTags")]
            [Validation(Required=false)]
            public Dictionary<string, object> ResourceTags { get; set; }

            [NameInMap("ResourceTypeFilter")]
            [Validation(Required=false)]
            public List<string> ResourceTypeFilter { get; set; }

        }

        [NameInMap("TemplateScratchType")]
        [Validation(Required=false)]
        public string TemplateScratchType { get; set; }

    }

}
