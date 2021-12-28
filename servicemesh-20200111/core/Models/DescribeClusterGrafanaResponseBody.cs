// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeClusterGrafanaResponseBody : TeaModel {
        [NameInMap("Dashboards")]
        [Validation(Required=false)]
        public List<DescribeClusterGrafanaResponseBodyDashboards> Dashboards { get; set; }
        public class DescribeClusterGrafanaResponseBodyDashboards : TeaModel {
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
