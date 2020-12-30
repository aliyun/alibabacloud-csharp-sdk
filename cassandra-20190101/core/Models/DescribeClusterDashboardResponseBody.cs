// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cassandra20190101.Models
{
    public class DescribeClusterDashboardResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Dashboard")]
        [Validation(Required=false)]
        public DescribeClusterDashboardResponseBodyDashboard Dashboard { get; set; }
        public class DescribeClusterDashboardResponseBodyDashboard : TeaModel {
            [NameInMap("DataCenters")]
            [Validation(Required=false)]
            public DescribeClusterDashboardResponseBodyDashboardDataCenters DataCenters { get; set; }
            public class DescribeClusterDashboardResponseBodyDashboardDataCenters : TeaModel {
                [NameInMap("DataCenter")]
                [Validation(Required=false)]
                public List<DescribeClusterDashboardResponseBodyDashboardDataCentersDataCenter> DataCenter { get; set; }
                public class DescribeClusterDashboardResponseBodyDashboardDataCentersDataCenter : TeaModel {
                    [NameInMap("Nodes")]
                    [Validation(Required=false)]
                    public DescribeClusterDashboardResponseBodyDashboardDataCentersDataCenterNodes Nodes { get; set; }
                    public class DescribeClusterDashboardResponseBodyDashboardDataCentersDataCenterNodes : TeaModel {
                        [NameInMap("Node")]
                        [Validation(Required=false)]
                        public List<DescribeClusterDashboardResponseBodyDashboardDataCentersDataCenterNodesNode> Node { get; set; }
                        public class DescribeClusterDashboardResponseBodyDashboardDataCentersDataCenterNodesNode : TeaModel {
                            public string Status { get; set; }
                            public string Address { get; set; }
                            public string Load { get; set; }
                        }
                    };

                    [NameInMap("DataCenterId")]
                    [Validation(Required=false)]
                    public string DataCenterId { get; set; }

                }

            }
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }
        };

    }

}
