// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class PostCustomizeRuleTestRequest : TeaModel {
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SimulatedData")]
        [Validation(Required=false)]
        public string SimulatedData { get; set; }

        [NameInMap("TestType")]
        [Validation(Required=false)]
        public string TestType { get; set; }

    }

}
