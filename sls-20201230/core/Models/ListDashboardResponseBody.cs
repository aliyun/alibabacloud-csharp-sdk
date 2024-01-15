// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListDashboardResponseBody : TeaModel {
        /// <summary>
        /// The details of the dashboard.
        /// </summary>
        [NameInMap("dashboardItems")]
        [Validation(Required=false)]
        public List<ListDashboardResponseBodyDashboardItems> DashboardItems { get; set; }
        public class ListDashboardResponseBodyDashboardItems : TeaModel {
            /// <summary>
            /// The dashboard ID. The ID must be unique in a project. Fuzzy search is supported. For example, if you enter da, all dashboards whose IDs start with da are queried.
            /// </summary>
            [NameInMap("dashboardName")]
            [Validation(Required=false)]
            public string DashboardName { get; set; }

            /// <summary>
            /// The display name of the dashboard.
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

        }

        /// <summary>
        /// The queried dashboards. Each dashboard in the array is specified by dashboardName.
        /// </summary>
        [NameInMap("dashboards")]
        [Validation(Required=false)]
        public List<string> Dashboards { get; set; }

    }

}
