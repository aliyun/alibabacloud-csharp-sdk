// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class GetResourceSnapshotResponseBody : TeaModel {
        [NameInMap("CPULimit")]
        [Validation(Required=false)]
        public string CPULimit { get; set; }

        [NameInMap("CPURequest")]
        [Validation(Required=false)]
        public string CPURequest { get; set; }

        [NameInMap("adpInfo")]
        [Validation(Required=false)]
        public GetResourceSnapshotResponseBodyAdpInfo AdpInfo { get; set; }
        public class GetResourceSnapshotResponseBodyAdpInfo : TeaModel {
            [NameInMap("CPURequest")]
            [Validation(Required=false)]
            public string CPURequest { get; set; }

            [NameInMap("componentNum")]
            [Validation(Required=false)]
            public int? ComponentNum { get; set; }

            [NameInMap("components")]
            [Validation(Required=false)]
            public List<GetResourceSnapshotResponseBodyAdpInfoComponents> Components { get; set; }
            public class GetResourceSnapshotResponseBodyAdpInfoComponents : TeaModel {
                [NameInMap("CPULimit")]
                [Validation(Required=false)]
                public string CPULimit { get; set; }

                [NameInMap("CPURequest")]
                [Validation(Required=false)]
                public string CPURequest { get; set; }

                [NameInMap("componentName")]
                [Validation(Required=false)]
                public string ComponentName { get; set; }

                [NameInMap("componentReleaseName")]
                [Validation(Required=false)]
                public string ComponentReleaseName { get; set; }

                [NameInMap("componentVersion")]
                [Validation(Required=false)]
                public string ComponentVersion { get; set; }

                [NameInMap("memoryLimit")]
                [Validation(Required=false)]
                public string MemoryLimit { get; set; }

                [NameInMap("memoryRequest")]
                [Validation(Required=false)]
                public string MemoryRequest { get; set; }

                [NameInMap("orchestrationValue")]
                [Validation(Required=false)]
                public string OrchestrationValue { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("storageRequest")]
                [Validation(Required=false)]
                public string StorageRequest { get; set; }

            }

            [NameInMap("memoryRequest")]
            [Validation(Required=false)]
            public string MemoryRequest { get; set; }

            [NameInMap("podNum")]
            [Validation(Required=false)]
            public int? PodNum { get; set; }

            [NameInMap("storageRequest")]
            [Validation(Required=false)]
            public string StorageRequest { get; set; }

            [NameInMap("workloadNum")]
            [Validation(Required=false)]
            public int? WorkloadNum { get; set; }

        }

        [NameInMap("memoryLimit")]
        [Validation(Required=false)]
        public string MemoryLimit { get; set; }

        [NameInMap("memoryRequest")]
        [Validation(Required=false)]
        public string MemoryRequest { get; set; }

        [NameInMap("productInfo")]
        [Validation(Required=false)]
        public GetResourceSnapshotResponseBodyProductInfo ProductInfo { get; set; }
        public class GetResourceSnapshotResponseBodyProductInfo : TeaModel {
            [NameInMap("CPURequest")]
            [Validation(Required=false)]
            public string CPURequest { get; set; }

            [NameInMap("componentNum")]
            [Validation(Required=false)]
            public int? ComponentNum { get; set; }

            [NameInMap("components")]
            [Validation(Required=false)]
            public List<GetResourceSnapshotResponseBodyProductInfoComponents> Components { get; set; }
            public class GetResourceSnapshotResponseBodyProductInfoComponents : TeaModel {
                [NameInMap("CPULimit")]
                [Validation(Required=false)]
                public string CPULimit { get; set; }

                [NameInMap("CPURequest")]
                [Validation(Required=false)]
                public string CPURequest { get; set; }

                [NameInMap("componentName")]
                [Validation(Required=false)]
                public string ComponentName { get; set; }

                [NameInMap("componentReleaseName")]
                [Validation(Required=false)]
                public string ComponentReleaseName { get; set; }

                [NameInMap("componentVersion")]
                [Validation(Required=false)]
                public string ComponentVersion { get; set; }

                [NameInMap("memoryLimit")]
                [Validation(Required=false)]
                public string MemoryLimit { get; set; }

                [NameInMap("memoryRequest")]
                [Validation(Required=false)]
                public string MemoryRequest { get; set; }

                [NameInMap("orchestrationValue")]
                [Validation(Required=false)]
                public string OrchestrationValue { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("storageRequest")]
                [Validation(Required=false)]
                public string StorageRequest { get; set; }

            }

            [NameInMap("memoryRequest")]
            [Validation(Required=false)]
            public string MemoryRequest { get; set; }

            [NameInMap("podNum")]
            [Validation(Required=false)]
            public int? PodNum { get; set; }

            [NameInMap("storageRequest")]
            [Validation(Required=false)]
            public string StorageRequest { get; set; }

            [NameInMap("workloadNum")]
            [Validation(Required=false)]
            public int? WorkloadNum { get; set; }

        }

        [NameInMap("specParamConfigs")]
        [Validation(Required=false)]
        public List<GetResourceSnapshotResponseBodySpecParamConfigs> SpecParamConfigs { get; set; }
        public class GetResourceSnapshotResponseBodySpecParamConfigs : TeaModel {
            [NameInMap("componentName")]
            [Validation(Required=false)]
            public string ComponentName { get; set; }

            [NameInMap("componentReleaseName")]
            [Validation(Required=false)]
            public string ComponentReleaseName { get; set; }

            [NameInMap("componentSource")]
            [Validation(Required=false)]
            public string ComponentSource { get; set; }

            [NameInMap("componentVersion")]
            [Validation(Required=false)]
            public string ComponentVersion { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("paramType")]
            [Validation(Required=false)]
            public string ParamType { get; set; }

            [NameInMap("parentComponentName")]
            [Validation(Required=false)]
            public string ParentComponentName { get; set; }

            [NameInMap("parentComponentReleaseName")]
            [Validation(Required=false)]
            public string ParentComponentReleaseName { get; set; }

            [NameInMap("parentComponentVersion")]
            [Validation(Required=false)]
            public string ParentComponentVersion { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            [NameInMap("valueType")]
            [Validation(Required=false)]
            public string ValueType { get; set; }

        }

        [NameInMap("storageRequest")]
        [Validation(Required=false)]
        public string StorageRequest { get; set; }

    }

}
