// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListTemplateScratchesResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TemplateScratches")]
        [Validation(Required=false)]
        public List<ListTemplateScratchesResponseBodyTemplateScratches> TemplateScratches { get; set; }
        public class ListTemplateScratchesResponseBodyTemplateScratches : TeaModel {
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
            public List<ListTemplateScratchesResponseBodyTemplateScratchesPreferenceParameters> PreferenceParameters { get; set; }
            public class ListTemplateScratchesResponseBodyTemplateScratchesPreferenceParameters : TeaModel {
                [NameInMap("ParameterKey")]
                [Validation(Required=false)]
                public string ParameterKey { get; set; }

                [NameInMap("ParameterValue")]
                [Validation(Required=false)]
                public string ParameterValue { get; set; }

            }

            [NameInMap("SourceResourceGroup")]
            [Validation(Required=false)]
            public ListTemplateScratchesResponseBodyTemplateScratchesSourceResourceGroup SourceResourceGroup { get; set; }
            public class ListTemplateScratchesResponseBodyTemplateScratchesSourceResourceGroup : TeaModel {
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }
                [NameInMap("ResourceTypeFilter")]
                [Validation(Required=false)]
                public List<string> ResourceTypeFilter { get; set; }
            };

            [NameInMap("SourceResources")]
            [Validation(Required=false)]
            public List<ListTemplateScratchesResponseBodyTemplateScratchesSourceResources> SourceResources { get; set; }
            public class ListTemplateScratchesResponseBodyTemplateScratchesSourceResources : TeaModel {
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            [NameInMap("SourceTag")]
            [Validation(Required=false)]
            public ListTemplateScratchesResponseBodyTemplateScratchesSourceTag SourceTag { get; set; }
            public class ListTemplateScratchesResponseBodyTemplateScratchesSourceTag : TeaModel {
                [NameInMap("ResourceTags")]
                [Validation(Required=false)]
                public Dictionary<string, string> ResourceTags { get; set; }
                [NameInMap("ResourceTypeFilter")]
                [Validation(Required=false)]
                public List<string> ResourceTypeFilter { get; set; }
            };

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StatusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }

            [NameInMap("TemplateScratchId")]
            [Validation(Required=false)]
            public string TemplateScratchId { get; set; }

            [NameInMap("TemplateScratchType")]
            [Validation(Required=false)]
            public string TemplateScratchType { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
