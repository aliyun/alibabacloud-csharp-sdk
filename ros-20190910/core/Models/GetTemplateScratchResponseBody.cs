// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetTemplateScratchResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TemplateScratch")]
        [Validation(Required=false)]
        public GetTemplateScratchResponseBodyTemplateScratch TemplateScratch { get; set; }
        public class GetTemplateScratchResponseBodyTemplateScratch : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("FailedCode")]
            [Validation(Required=false)]
            public string FailedCode { get; set; }
            [NameInMap("LogicalIdStrategy")]
            [Validation(Required=false)]
            public string LogicalIdStrategy { get; set; }
            [NameInMap("PreferenceParameters")]
            [Validation(Required=false)]
            public List<GetTemplateScratchResponseBodyTemplateScratchPreferenceParameters> PreferenceParameters { get; set; }
            public class GetTemplateScratchResponseBodyTemplateScratchPreferenceParameters : TeaModel {
                public string ParameterKey { get; set; }
                public string ParameterValue { get; set; }
            }
            [NameInMap("SourceResourceGroup")]
            [Validation(Required=false)]
            public GetTemplateScratchResponseBodyTemplateScratchSourceResourceGroup SourceResourceGroup { get; set; }
            public class GetTemplateScratchResponseBodyTemplateScratchSourceResourceGroup : TeaModel {
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("ResourceTypeFilter")]
                [Validation(Required=false)]
                public List<string> ResourceTypeFilter { get; set; }

            }
            [NameInMap("SourceResources")]
            [Validation(Required=false)]
            public List<GetTemplateScratchResponseBodyTemplateScratchSourceResources> SourceResources { get; set; }
            public class GetTemplateScratchResponseBodyTemplateScratchSourceResources : TeaModel {
                public string ResourceId { get; set; }
                public string ResourceType { get; set; }
            }
            [NameInMap("SourceTag")]
            [Validation(Required=false)]
            public GetTemplateScratchResponseBodyTemplateScratchSourceTag SourceTag { get; set; }
            public class GetTemplateScratchResponseBodyTemplateScratchSourceTag : TeaModel {
                [NameInMap("ResourceTags")]
                [Validation(Required=false)]
                public Dictionary<string, object> ResourceTags { get; set; }

                [NameInMap("ResourceTypeFilter")]
                [Validation(Required=false)]
                public List<string> ResourceTypeFilter { get; set; }

            }
            [NameInMap("StackProvision")]
            [Validation(Required=false)]
            public GetTemplateScratchResponseBodyTemplateScratchStackProvision StackProvision { get; set; }
            public class GetTemplateScratchResponseBodyTemplateScratchStackProvision : TeaModel {
                [NameInMap("Creatable")]
                [Validation(Required=false)]
                public bool? Creatable { get; set; }

                [NameInMap("Importable")]
                [Validation(Required=false)]
                public bool? Importable { get; set; }

            }
            [NameInMap("Stacks")]
            [Validation(Required=false)]
            public List<GetTemplateScratchResponseBodyTemplateScratchStacks> Stacks { get; set; }
            public class GetTemplateScratchResponseBodyTemplateScratchStacks : TeaModel {
                public string RegionId { get; set; }
                public string StackId { get; set; }
                public string UsageType { get; set; }
            }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("StatusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }
            [NameInMap("TemplateScratchData")]
            [Validation(Required=false)]
            public Dictionary<string, string> TemplateScratchData { get; set; }
            [NameInMap("TemplateScratchId")]
            [Validation(Required=false)]
            public string TemplateScratchId { get; set; }
            [NameInMap("TemplateScratchType")]
            [Validation(Required=false)]
            public string TemplateScratchType { get; set; }
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }
        };

    }

}
