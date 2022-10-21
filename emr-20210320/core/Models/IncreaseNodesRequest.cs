// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class IncreaseNodesRequest : TeaModel {
        [NameInMap("ApplicationConfigs")]
        [Validation(Required=false)]
        public List<ApplicationConfig> ApplicationConfigs { get; set; }

        [NameInMap("AutoPayOrder")]
        [Validation(Required=false)]
        public bool? AutoPayOrder { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("IncreaseNodeCount")]
        [Validation(Required=false)]
        public int? IncreaseNodeCount { get; set; }

        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        [NameInMap("PaymentDuration")]
        [Validation(Required=false)]
        public int? PaymentDuration { get; set; }

        [NameInMap("PaymentDurationUnit")]
        [Validation(Required=false)]
        public string PaymentDurationUnit { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
