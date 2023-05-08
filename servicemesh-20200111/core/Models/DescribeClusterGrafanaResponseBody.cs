// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeClusterGrafanaResponseBody : TeaModel {
        /// <summary>
        /// The information of Grafana dashboards.
        /// </summary>
        [NameInMap("Dashboards")]
        [Validation(Required=false)]
        public List<DescribeClusterGrafanaResponseBodyDashboards> Dashboards { get; set; }
        public class DescribeClusterGrafanaResponseBodyDashboards : TeaModel {
            /// <summary>
            /// The title of the Grafana dashboard.
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// The endpoint of the Grafana dashboard.
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
