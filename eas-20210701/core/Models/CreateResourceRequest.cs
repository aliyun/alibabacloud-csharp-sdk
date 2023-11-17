// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class CreateResourceRequest : TeaModel {
        [NameInMap("AutoRenewal")]
        [Validation(Required=false)]
        public bool? AutoRenewal { get; set; }

        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        [NameInMap("EcsInstanceCount")]
        [Validation(Required=false)]
        public int? EcsInstanceCount { get; set; }

        [NameInMap("EcsInstanceType")]
        [Validation(Required=false)]
        public string EcsInstanceType { get; set; }

        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("SelfManagedResourceOptions")]
        [Validation(Required=false)]
        public CreateResourceRequestSelfManagedResourceOptions SelfManagedResourceOptions { get; set; }
        public class CreateResourceRequestSelfManagedResourceOptions : TeaModel {
            [NameInMap("ExternalClusterId")]
            [Validation(Required=false)]
            public string ExternalClusterId { get; set; }

            [NameInMap("NodeMatchLabels")]
            [Validation(Required=false)]
            public Dictionary<string, string> NodeMatchLabels { get; set; }

            [NameInMap("NodeTolerations")]
            [Validation(Required=false)]
            public List<CreateResourceRequestSelfManagedResourceOptionsNodeTolerations> NodeTolerations { get; set; }
            public class CreateResourceRequestSelfManagedResourceOptionsNodeTolerations : TeaModel {
                [NameInMap("effect")]
                [Validation(Required=false)]
                public string Effect { get; set; }

                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

        }

        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public int? SystemDiskSize { get; set; }

        [NameInMap("Zone")]
        [Validation(Required=false)]
        public string Zone { get; set; }

    }

}
