// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class CreateAppGroupRequest : TeaModel {
        [NameInMap("chargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("quota")]
        [Validation(Required=false)]
        public CreateAppGroupRequestQuota Quota { get; set; }
        public class CreateAppGroupRequestQuota : TeaModel {
            [NameInMap("computeResource")]
            [Validation(Required=false)]
            public int? ComputeResource { get; set; }

            [NameInMap("docSize")]
            [Validation(Required=false)]
            public int? DocSize { get; set; }

            [NameInMap("spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }

        }

        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
