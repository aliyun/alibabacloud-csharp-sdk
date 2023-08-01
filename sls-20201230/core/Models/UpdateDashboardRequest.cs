// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UpdateDashboardRequest : TeaModel {
        [NameInMap("attribute")]
        [Validation(Required=false)]
        public Dictionary<string, string> Attribute { get; set; }

        [NameInMap("charts")]
        [Validation(Required=false)]
        public List<Chart> Charts { get; set; }

        [NameInMap("dashboardName")]
        [Validation(Required=false)]
        public string DashboardName { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

    }

}
