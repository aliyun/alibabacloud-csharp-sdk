// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateMsSgRouterRuleGroupStatusRequest : TeaModel {
        [NameInMap("DispatchVersion")]
        [Validation(Required=false)]
        public long? DispatchVersion { get; set; }

        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public long? Enabled { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
