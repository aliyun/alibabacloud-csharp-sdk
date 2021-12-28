// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class CreateServiceInstanceShrinkRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("EnableAccountOps")]
        [Validation(Required=false)]
        public bool? EnableAccountOps { get; set; }

        [NameInMap("EnableInstanceOps")]
        [Validation(Required=false)]
        public bool? EnableInstanceOps { get; set; }

        [NameInMap("OperationMetadata")]
        [Validation(Required=false)]
        public CreateServiceInstanceShrinkRequestOperationMetadata OperationMetadata { get; set; }
        public class CreateServiceInstanceShrinkRequestOperationMetadata : TeaModel {
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }
            [NameInMap("Resources")]
            [Validation(Required=false)]
            public string Resources { get; set; }
            [NameInMap("ServiceInstanceId")]
            [Validation(Required=false)]
            public string ServiceInstanceId { get; set; }
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }
        };

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string ParametersShrink { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestTag")]
        [Validation(Required=false)]
        public List<CreateServiceInstanceShrinkRequestRequestTag> RequestTag { get; set; }
        public class CreateServiceInstanceShrinkRequestRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        [NameInMap("ServiceVersion")]
        [Validation(Required=false)]
        public string ServiceVersion { get; set; }

        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
