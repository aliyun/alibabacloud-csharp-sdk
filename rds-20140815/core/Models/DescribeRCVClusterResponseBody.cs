// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCVClusterResponseBody : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        [NameInMap("MysqlOperator")]
        [Validation(Required=false)]
        public DescribeRCVClusterResponseBodyMysqlOperator MysqlOperator { get; set; }
        public class DescribeRCVClusterResponseBodyMysqlOperator : TeaModel {
            [NameInMap("DashboardPublicEndpoint")]
            [Validation(Required=false)]
            public string DashboardPublicEndpoint { get; set; }

            [NameInMap("DashboardUsername")]
            [Validation(Required=false)]
            public string DashboardUsername { get; set; }

            [NameInMap("DashboardVpcEndpoint")]
            [Validation(Required=false)]
            public string DashboardVpcEndpoint { get; set; }

            [NameInMap("DeployTime")]
            [Validation(Required=false)]
            public string DeployTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SupportDiskPerformanceLevel")]
        [Validation(Required=false)]
        public List<string> SupportDiskPerformanceLevel { get; set; }

        [NameInMap("VClusterStatus")]
        [Validation(Required=false)]
        public string VClusterStatus { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
