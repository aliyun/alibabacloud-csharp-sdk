// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class RoutePolicy : TeaModel {
        [NameInMap("condition")]
        [Validation(Required=false)]
        public string Condition { get; set; }

        [NameInMap("policyItems")]
        [Validation(Required=false)]
        public List<PolicyItem> PolicyItems { get; set; }

    }

}
