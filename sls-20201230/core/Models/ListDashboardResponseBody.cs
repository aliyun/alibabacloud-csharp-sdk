// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListDashboardResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the dashboard.</para>
        /// </summary>
        [NameInMap("dashboardItems")]
        [Validation(Required=false)]
        public List<ListDashboardResponseBodyDashboardItems> DashboardItems { get; set; }
        public class ListDashboardResponseBodyDashboardItems : TeaModel {
            /// <summary>
            /// <para>The dashboard ID. The ID must be unique in a project. Fuzzy search is supported. For example, if you enter da, all dashboards whose IDs start with da are queried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dashboard-1609294922657-434834</para>
            /// </summary>
            [NameInMap("dashboardName")]
            [Validation(Required=false)]
            public string DashboardName { get; set; }

            /// <summary>
            /// <para>The display name of the dashboard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>data-ingest</para>
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

        }

        /// <summary>
        /// <para>The queried dashboards. Each dashboard in the array is specified by dashboardName.</para>
        /// </summary>
        [NameInMap("dashboards")]
        [Validation(Required=false)]
        public List<string> Dashboards { get; set; }

    }

}
