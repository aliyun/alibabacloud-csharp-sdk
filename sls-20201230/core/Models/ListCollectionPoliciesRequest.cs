// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListCollectionPoliciesRequest : TeaModel {
        [NameInMap("centralProject")]
        [Validation(Required=false)]
        public string CentralProject { get; set; }

        [NameInMap("dataCode")]
        [Validation(Required=false)]
        public string DataCode { get; set; }

        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("offset")]
        [Validation(Required=false)]
        public int? Offset { get; set; }

        [NameInMap("policyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        [NameInMap("productCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        [NameInMap("size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

    }

}
