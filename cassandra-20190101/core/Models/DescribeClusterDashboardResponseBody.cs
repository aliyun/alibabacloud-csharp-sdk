// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cassandra20190101.Models
{
    public class DescribeClusterDashboardResponseBody : TeaModel {
        [NameInMap("Dashboard")]
        [Validation(Required=false)]
        public DescribeClusterDashboardResponseBodyDashboard Dashboard { get; set; }
        public class DescribeClusterDashboardResponseBodyDashboard : TeaModel {
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("DataCenters")]
            [Validation(Required=false)]
            public DescribeClusterDashboardResponseBodyDashboardDataCenters DataCenters { get; set; }
            public class DescribeClusterDashboardResponseBodyDashboardDataCenters : TeaModel {
                [NameInMap("DataCenter")]
                [Validation(Required=false)]
                public List<DescribeClusterDashboardResponseBodyDashboardDataCentersDataCenter> DataCenter { get; set; }
                public class DescribeClusterDashboardResponseBodyDashboardDataCentersDataCenter : TeaModel {
                    [NameInMap("DataCenterId")]
                    [Validation(Required=false)]
                    public string DataCenterId { get; set; }

                    [NameInMap("Nodes")]
                    [Validation(Required=false)]
                    public DescribeClusterDashboardResponseBodyDashboardDataCentersDataCenterNodes Nodes { get; set; }
                    public class DescribeClusterDashboardResponseBodyDashboardDataCentersDataCenterNodes : TeaModel {
                        [NameInMap("Node")]
                        [Validation(Required=false)]
                        public List<DescribeClusterDashboardResponseBodyDashboardDataCentersDataCenterNodesNode> Node { get; set; }
                        public class DescribeClusterDashboardResponseBodyDashboardDataCentersDataCenterNodesNode : TeaModel {
                            [NameInMap("Address")]
                            [Validation(Required=false)]
                            public string Address { get; set; }

                            [NameInMap("Load")]
                            [Validation(Required=false)]
                            public string Load { get; set; }

                            [NameInMap("Status")]
                            [Validation(Required=false)]
                            public string Status { get; set; }

                        }

                    }

                }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
