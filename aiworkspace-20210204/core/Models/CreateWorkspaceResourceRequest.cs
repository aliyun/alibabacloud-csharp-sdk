// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class CreateWorkspaceResourceRequest : TeaModel {
        [NameInMap("Option")]
        [Validation(Required=false)]
        public string Option { get; set; }

        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<CreateWorkspaceResourceRequestResources> Resources { get; set; }
        public class CreateWorkspaceResourceRequestResources : TeaModel {
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<CreateWorkspaceResourceRequestResourcesLabels> Labels { get; set; }
            public class CreateWorkspaceResourceRequestResourcesLabels : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            [NameInMap("Quotas")]
            [Validation(Required=false)]
            public List<CreateWorkspaceResourceRequestResourcesQuotas> Quotas { get; set; }
            public class CreateWorkspaceResourceRequestResourcesQuotas : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

            }

            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            [NameInMap("Spec")]
            [Validation(Required=false)]
            public Dictionary<string, object> Spec { get; set; }

            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

    }

}
