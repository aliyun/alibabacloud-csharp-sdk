// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListDashboardResponseBody : TeaModel {
        [NameInMap("dashboardItems")]
        [Validation(Required=false)]
        public List<ListDashboardResponseBodyDashboardItems> DashboardItems { get; set; }
        public class ListDashboardResponseBodyDashboardItems : TeaModel {
            [NameInMap("dashboardName")]
            [Validation(Required=false)]
            public string DashboardName { get; set; }

            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

        }

        [NameInMap("dashboards")]
        [Validation(Required=false)]
        public List<string> Dashboards { get; set; }

    }

}
