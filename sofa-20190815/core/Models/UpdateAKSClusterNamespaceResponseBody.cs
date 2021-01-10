// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateAKSClusterNamespaceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public UpdateAKSClusterNamespaceResponseBodyNamespace Namespace { get; set; }
        public class UpdateAKSClusterNamespaceResponseBodyNamespace : TeaModel {
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }
            [NameInMap("Annotations")]
            [Validation(Required=false)]
            public List<UpdateAKSClusterNamespaceResponseBodyNamespaceAnnotations> Annotations { get; set; }
            public class UpdateAKSClusterNamespaceResponseBodyNamespaceAnnotations : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<UpdateAKSClusterNamespaceResponseBodyNamespaceLabels> Labels { get; set; }
            public class UpdateAKSClusterNamespaceResponseBodyNamespaceLabels : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
        };

    }

}
