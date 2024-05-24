// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class InfraStackResourceState : TeaModel {
        [NameInMap("resourceDrifts")]
        [Validation(Required=false)]
        public List<ResourceDrift> ResourceDrifts { get; set; }

        [NameInMap("resources")]
        [Validation(Required=false)]
        public List<ResourceDetail> Resources { get; set; }

    }

}
