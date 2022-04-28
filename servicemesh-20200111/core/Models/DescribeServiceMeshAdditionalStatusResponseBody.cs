// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeServiceMeshAdditionalStatusResponseBody : TeaModel {
        [NameInMap("ClusterStatus")]
        [Validation(Required=false)]
        public DescribeServiceMeshAdditionalStatusResponseBodyClusterStatus ClusterStatus { get; set; }
        public class DescribeServiceMeshAdditionalStatusResponseBodyClusterStatus : TeaModel {
            [NameInMap("AccessLogProjectStatus")]
            [Validation(Required=false)]
            public string AccessLogProjectStatus { get; set; }
            [NameInMap("ApiServerEIPStatus")]
            [Validation(Required=false)]
            public string ApiServerEIPStatus { get; set; }
            [NameInMap("ApiServerLoadBalancerStatus")]
            [Validation(Required=false)]
            public DescribeServiceMeshAdditionalStatusResponseBodyClusterStatusApiServerLoadBalancerStatus ApiServerLoadBalancerStatus { get; set; }
            public class DescribeServiceMeshAdditionalStatusResponseBodyClusterStatusApiServerLoadBalancerStatus : TeaModel {
                [NameInMap("Locked")]
                [Validation(Required=false)]
                public bool? Locked { get; set; }

                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                [NameInMap("Reused")]
                [Validation(Required=false)]
                public bool? Reused { get; set; }

                [NameInMap("SLBBackEndServerNumStatus")]
                [Validation(Required=false)]
                public string SLBBackEndServerNumStatus { get; set; }

                [NameInMap("SLBExistStatus")]
                [Validation(Required=false)]
                public string SLBExistStatus { get; set; }

            }
            [NameInMap("AuditProjectStatus")]
            [Validation(Required=false)]
            public string AuditProjectStatus { get; set; }
            [NameInMap("ControlPlaneProjectStatus")]
            [Validation(Required=false)]
            public string ControlPlaneProjectStatus { get; set; }
            [NameInMap("LogtailStatusRecord")]
            [Validation(Required=false)]
            public Dictionary<string, string> LogtailStatusRecord { get; set; }
            [NameInMap("PilotLoadBalancerStatus")]
            [Validation(Required=false)]
            public DescribeServiceMeshAdditionalStatusResponseBodyClusterStatusPilotLoadBalancerStatus PilotLoadBalancerStatus { get; set; }
            public class DescribeServiceMeshAdditionalStatusResponseBodyClusterStatusPilotLoadBalancerStatus : TeaModel {
                [NameInMap("Locked")]
                [Validation(Required=false)]
                public bool? Locked { get; set; }

                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                [NameInMap("Reused")]
                [Validation(Required=false)]
                public bool? Reused { get; set; }

                [NameInMap("SLBBackEndServerNumStatus")]
                [Validation(Required=false)]
                public string SLBBackEndServerNumStatus { get; set; }

                [NameInMap("SLBExistStatus")]
                [Validation(Required=false)]
                public string SLBExistStatus { get; set; }

            }
            [NameInMap("SgStatus")]
            [Validation(Required=false)]
            public string SgStatus { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
