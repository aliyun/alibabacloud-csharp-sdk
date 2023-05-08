// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeServiceMeshAdditionalStatusResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the SLB instance is reused. Valid values:
        /// 
        /// *   `true`: The SLB instance is reused.
        /// *   `false`: The SLB instance is not reused.
        /// </summary>
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

            /// <summary>
            /// Indicates whether the SLB instance is locked. Valid values:
            /// 
            /// *   `true`: The SLB instance is locked.
            /// *   `false`: The SLB instance is not locked.
            /// </summary>
            [NameInMap("ApiServerLoadBalancerStatus")]
            [Validation(Required=false)]
            public DescribeServiceMeshAdditionalStatusResponseBodyClusterStatusApiServerLoadBalancerStatus ApiServerLoadBalancerStatus { get; set; }
            public class DescribeServiceMeshAdditionalStatusResponseBodyClusterStatusApiServerLoadBalancerStatus : TeaModel {
                /// <summary>
                /// The check result of the number of SLB instances created for exposing Istio Pilot. Valid values:
                /// 
                /// *   `too_much`: An excessive number of SLB instances are created.
                /// *   `num_exact`: A proper number of SLB instances are created.
                /// *   `too_little`: The number of SLB instances falls short.
                /// </summary>
                [NameInMap("Locked")]
                [Validation(Required=false)]
                public bool? Locked { get; set; }

                /// <summary>
                /// Indicates whether the SLB instance is reused. Valid values:
                /// 
                /// *   `true`: The SLB instance is reused.
                /// *   `false`: The SLB instance is not reused.
                /// </summary>
                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                /// <summary>
                /// The check result of the SLB instance. Valid values:
                /// 
                /// *   `exist`: The SLB instance exists.
                /// *   `not_exist`: The SLB instance does not exist.
                /// *   `conflict`: Conflicts are detected.
                /// *   `failed`: The check fails.
                /// *   `time_out`: The check times out.
                /// </summary>
                [NameInMap("Reused")]
                [Validation(Required=false)]
                public bool? Reused { get; set; }

                /// <summary>
                /// The check results of the SLB instances created for exposing Istio Pilot.
                /// </summary>
                [NameInMap("SLBBackEndServerNumStatus")]
                [Validation(Required=false)]
                public string SLBBackEndServerNumStatus { get; set; }

                /// <summary>
                /// The billing method of the SLB instance. Valid values:
                /// 
                /// *   `PrePay`: subscription
                /// *   `PayOnDemand`: pay-as-you-go
                /// </summary>
                [NameInMap("SLBExistStatus")]
                [Validation(Required=false)]
                public string SLBExistStatus { get; set; }

            }

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

            [NameInMap("ControlPlaneProjectStatus")]
            [Validation(Required=false)]
            public string ControlPlaneProjectStatus { get; set; }

            /// <summary>
            /// The check result of access logs. Valid values:
            /// 
            /// *   `exist`: Access logs exist.
            /// *   `not_exist`: Access logs do not exist.
            /// *   `failed`: The check fails.
            /// *   `time_out`: The check times out.
            /// </summary>
            [NameInMap("LogtailStatusRecord")]
            [Validation(Required=false)]
            public Dictionary<string, object> LogtailStatusRecord { get; set; }

            /// <summary>
            /// Indicates whether the SLB instance is locked. Valid values:
            /// 
            /// *   `true`: The SLB instance is locked.
            /// *   `false`: The SLB instance is not locked.
            /// </summary>
            [NameInMap("PilotLoadBalancerStatus")]
            [Validation(Required=false)]
            public DescribeServiceMeshAdditionalStatusResponseBodyClusterStatusPilotLoadBalancerStatus PilotLoadBalancerStatus { get; set; }
            public class DescribeServiceMeshAdditionalStatusResponseBodyClusterStatusPilotLoadBalancerStatus : TeaModel {
                /// <summary>
                /// The check result of control plane logs. Valid values:
                /// 
                /// *   `exist`: Control plane logs exist.
                /// *   `not_exist`: Control plane logs do not exist.
                /// *   `failed`: The check fails.
                /// *   `time_out`: The check times out.
                /// </summary>
                [NameInMap("Locked")]
                [Validation(Required=false)]
                public bool? Locked { get; set; }

                /// <summary>
                /// Indicates whether the security group is reused. Valid values:
                /// 
                /// *   `reused`: The security group is reused.
                /// *   `not_reused`: The security group is not reused.
                /// *   `failed`: The check fails.
                /// *   `time_out`: The check times out.
                /// </summary>
                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                /// <summary>
                /// The check results of the Logtail installation for clusters on the data plane.
                /// </summary>
                [NameInMap("Reused")]
                [Validation(Required=false)]
                public bool? Reused { get; set; }

                /// <summary>
                /// The check result of audit logs. Valid values:
                /// 
                /// *   `exist`: Audit logs exist.
                /// *   `not exist`: Audit logs do not exist.
                /// </summary>
                [NameInMap("SLBBackEndServerNumStatus")]
                [Validation(Required=false)]
                public string SLBBackEndServerNumStatus { get; set; }

                /// <summary>
                /// The billing method of the SLB instance. Valid values:
                /// 
                /// *   `PrePay`: subscription
                /// *   `PayOnDemand`: pay-as-you-go
                /// </summary>
                [NameInMap("SLBExistStatus")]
                [Validation(Required=false)]
                public string SLBExistStatus { get; set; }

            }

            [NameInMap("SgStatus")]
            [Validation(Required=false)]
            public string SgStatus { get; set; }

        }

        /// <summary>
        /// The check result of the number of SLB instances created for exposing the API server. Valid values:
        /// 
        /// *   `too_much`: An excessive number of SLB instances are created.
        /// *   `num_exact`: A proper number of SLB instances are created.
        /// *   `too_little`: The number of SLB instances falls short.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
