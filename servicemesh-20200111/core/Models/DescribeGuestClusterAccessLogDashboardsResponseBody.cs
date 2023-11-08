// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeGuestClusterAccessLogDashboardsResponseBody : TeaModel {
        /// <summary>
        /// The access log dashboards of the cluster on the data plane.
        /// </summary>
        [NameInMap("Dashboards")]
        [Validation(Required=false)]
        public List<DescribeGuestClusterAccessLogDashboardsResponseBodyDashboards> Dashboards { get; set; }
        public class DescribeGuestClusterAccessLogDashboardsResponseBodyDashboards : TeaModel {
            /// <summary>
            /// The title of the dashboard.
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// The URL of a dashboard.
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// The ID of the cluster on the data plane.
        /// </summary>
        [NameInMap("K8sClusterId")]
        [Validation(Required=false)]
        public string K8sClusterId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
