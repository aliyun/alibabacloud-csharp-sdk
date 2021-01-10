// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class EnableMsSgCircuitBreakerRuleRequest : TeaModel {
        [NameInMap("DataId")]
        [Validation(Required=false)]
        public string DataId { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

    }

}
