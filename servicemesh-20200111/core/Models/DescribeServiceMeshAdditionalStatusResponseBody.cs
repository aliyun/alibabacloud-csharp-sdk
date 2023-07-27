// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeServiceMeshAdditionalStatusResponseBody : TeaModel {
        /// <summary>
        /// The status of the cluster.
        /// </summary>
        [NameInMap("ClusterStatus")]
        [Validation(Required=false)]
        public DescribeServiceMeshAdditionalStatusResponseBodyClusterStatus ClusterStatus { get; set; }
        public class DescribeServiceMeshAdditionalStatusResponseBodyClusterStatus : TeaModel {
            /// <summary>
            /// Indicates whether access logs exist. Valid values:
            /// 
            /// *   `exist`: Access logs exist.
            /// *   `not_exist`: Access logs do not exist.
            /// *   `failed`: The check fails.
            /// *   `time_out`: The check times out.
            /// </summary>
            [NameInMap("AccessLogProjectStatus")]
            [Validation(Required=false)]
            public string AccessLogProjectStatus { get; set; }

            /// <summary>
            /// The check result of the EIP associated with the API server. Valid values:
            /// 
            /// *   `exist`: The EIP exists.
            /// *   `not_exist`: The EIP does not exist.
            /// *   `failed`: The check fails.
            /// *   `time_out`: The check times out.
            /// *   `not_in_use`: The EIP is not associated with the API Server.
            /// *   `locked`: The EIP is locked.
            /// </summary>
            [NameInMap("ApiServerEIPStatus")]
            [Validation(Required=false)]
            public string ApiServerEIPStatus { get; set; }

            /// <summary>
            /// The check results of the SLB instance created for exposing the API server.
            /// </summary>
            [NameInMap("ApiServerLoadBalancerStatus")]
            [Validation(Required=false)]
            public DescribeServiceMeshAdditionalStatusResponseBodyClusterStatusApiServerLoadBalancerStatus ApiServerLoadBalancerStatus { get; set; }
            public class DescribeServiceMeshAdditionalStatusResponseBodyClusterStatusApiServerLoadBalancerStatus : TeaModel {
                /// <summary>
                /// Indicates whether the SLB instance is locked. Valid values:
                /// 
                /// *   `true`
                /// *   `false`
                /// </summary>
                [NameInMap("Locked")]
                [Validation(Required=false)]
                public bool? Locked { get; set; }

                /// <summary>
                /// The billing method of the SLB instance. Valid values:
                /// 
                /// *   `PrePay`: subscription
                /// *   `PayOnDemand`: pay-as-you-go
                /// </summary>
                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                /// <summary>
                /// Indicates whether the SLB instance is reused. Valid values:
                /// 
                /// *   `true`
                /// *   `false`
                /// </summary>
                [NameInMap("Reused")]
                [Validation(Required=false)]
                public bool? Reused { get; set; }

                /// <summary>
                /// The check result of the number of the backend servers of the SLB instance created for exposing Istio Pilot. Valid values:
                /// 
                /// *   `too_much`: An excessive number of backend servers are created.
                /// *   `num_exact`: A proper number of backend servers are created.
                /// *   `too_little`: The number of backend servers falls short.
                /// </summary>
                [NameInMap("SLBBackEndServerNumStatus")]
                [Validation(Required=false)]
                public string SLBBackEndServerNumStatus { get; set; }

                /// <summary>
                /// The check result of the SLB instance. Valid values:
                /// 
                /// *   `exist`: The SLB instance exists.
                /// *   `not_exist`: The SLB instance does not exist.
                /// *   `conflict`: Conflicts are detected.
                /// *   `failed`: The check fails.
                /// *   `time_out`: The check times out.
                /// </summary>
                [NameInMap("SLBExistStatus")]
                [Validation(Required=false)]
                public string SLBExistStatus { get; set; }

            }

            /// <summary>
            /// Indicates whether audit logs exist. Valid values:
            /// 
            /// *   `exist`
            /// *   `not exist`
            /// </summary>
            [NameInMap("AuditProjectStatus")]
            [Validation(Required=false)]
            public string AuditProjectStatus { get; set; }

            [NameInMap("CanaryPilotLoadBalancerStatus")]
            [Validation(Required=false)]
            public DescribeServiceMeshAdditionalStatusResponseBodyClusterStatusCanaryPilotLoadBalancerStatus CanaryPilotLoadBalancerStatus { get; set; }
            public class DescribeServiceMeshAdditionalStatusResponseBodyClusterStatusCanaryPilotLoadBalancerStatus : TeaModel {
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

            /// <summary>
            /// Indicates whether control plane logs exist. Valid values:
            /// 
            /// *   `exist`: Control plane logs exist.
            /// *   `not_exist`: Control plane logs do not exist.
            /// *   `failed`: The check fails.
            /// *   `time_out`: The check times out.
            /// </summary>
            [NameInMap("ControlPlaneProjectStatus")]
            [Validation(Required=false)]
            public string ControlPlaneProjectStatus { get; set; }

            /// <summary>
            /// Indicates whether Logtail is installed in clusters on the data plane.
            /// </summary>
            [NameInMap("LogtailStatusRecord")]
            [Validation(Required=false)]
            public Dictionary<string, object> LogtailStatusRecord { get; set; }

            /// <summary>
            /// The check results of the SLB instance created for exposing Istio Pilot.
            /// </summary>
            [NameInMap("PilotLoadBalancerStatus")]
            [Validation(Required=false)]
            public DescribeServiceMeshAdditionalStatusResponseBodyClusterStatusPilotLoadBalancerStatus PilotLoadBalancerStatus { get; set; }
            public class DescribeServiceMeshAdditionalStatusResponseBodyClusterStatusPilotLoadBalancerStatus : TeaModel {
                /// <summary>
                /// Indicates whether the SLB instance is locked. Valid values:
                /// 
                /// *   `true`
                /// *   `false`
                /// </summary>
                [NameInMap("Locked")]
                [Validation(Required=false)]
                public bool? Locked { get; set; }

                /// <summary>
                /// The billing method of the SLB instance. Valid values:
                /// 
                /// *   `PrePay`: subscription
                /// *   `PayOnDemand`: pay-as-you-go
                /// </summary>
                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                /// <summary>
                /// Indicates whether the SLB instance is reused. Valid values:
                /// 
                /// *   `true`
                /// *   `false`
                /// </summary>
                [NameInMap("Reused")]
                [Validation(Required=false)]
                public bool? Reused { get; set; }

                /// <summary>
                /// The check result of the number of the backend servers of the SLB instance created for exposing Istio Pilot. Valid values:
                /// 
                /// *   `too_much`: An excessive number of backend servers are created.
                /// *   `num_exact`: A proper number of backend servers are created.
                /// *   `too_little`: The number of backend servers falls short.
                /// </summary>
                [NameInMap("SLBBackEndServerNumStatus")]
                [Validation(Required=false)]
                public string SLBBackEndServerNumStatus { get; set; }

                /// <summary>
                /// The check result of the SLB instance. Valid values:
                /// 
                /// *   `exist`: The SLB instance exists.
                /// *   `not_exist`: The SLB instance does not exist.
                /// *   `conflict`: Conflicts are detected.
                /// *   `failed`: The check fails.
                /// *   `time_out`: The check times out.
                /// </summary>
                [NameInMap("SLBExistStatus")]
                [Validation(Required=false)]
                public string SLBExistStatus { get; set; }

            }

            [NameInMap("RAMApplicationStatus")]
            [Validation(Required=false)]
            public string RAMApplicationStatus { get; set; }

            /// <summary>
            /// Indicates whether the security group is reused. Valid values:
            /// 
            /// *   `reused`: The security group is reused.
            /// *   `not_reused`: The security group is not reused.
            /// *   `failed`: The check fails.
            /// *   `time_out`: The check times out.
            /// </summary>
            [NameInMap("SgStatus")]
            [Validation(Required=false)]
            public string SgStatus { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
