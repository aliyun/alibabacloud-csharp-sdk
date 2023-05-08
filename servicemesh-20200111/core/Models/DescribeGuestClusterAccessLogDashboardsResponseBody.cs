// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeGuestClusterAccessLogDashboardsResponseBody : TeaModel {
        /// <summary>
        /// The access log reports of a cluster on the data plane.
        /// </summary>
        [NameInMap("Dashboards")]
        [Validation(Required=false)]
        public List<DescribeGuestClusterAccessLogDashboardsResponseBodyDashboards> Dashboards { get; set; }
        public class DescribeGuestClusterAccessLogDashboardsResponseBodyDashboards : TeaModel {
            /// <summary>
            /// The title of the report.
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// The URL of the report.
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
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
