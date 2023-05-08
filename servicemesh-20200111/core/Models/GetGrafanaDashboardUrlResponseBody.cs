// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class GetGrafanaDashboardUrlResponseBody : TeaModel {
        /// <summary>
        /// The information about the dashboard.
        /// </summary>
        [NameInMap("Dashboards")]
        [Validation(Required=false)]
        public List<GetGrafanaDashboardUrlResponseBodyDashboards> Dashboards { get; set; }
        public class GetGrafanaDashboardUrlResponseBodyDashboards : TeaModel {
            /// <summary>
            /// The name of the dashboard.
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// The URL of the dashboard.
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
