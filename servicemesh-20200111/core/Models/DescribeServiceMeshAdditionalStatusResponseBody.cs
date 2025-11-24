// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeServiceMeshAdditionalStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The cluster status.</para>
        /// </summary>
        [NameInMap("ClusterStatus")]
        [Validation(Required=false)]
        public DescribeServiceMeshAdditionalStatusResponseBodyClusterStatus ClusterStatus { get; set; }
        public class DescribeServiceMeshAdditionalStatusResponseBodyClusterStatus : TeaModel {
            /// <summary>
            /// <para>Indicates whether access logs exist. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>exist</c>: Access logs exist.</description></item>
            /// <item><description><c>not_exist</c>: Access logs do not exist.</description></item>
            /// <item><description><c>failed</c>: The check fails.</description></item>
            /// <item><description><c>time_out</c>: The check times out.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>exist</para>
            /// </summary>
            [NameInMap("AccessLogProjectStatus")]
            [Validation(Required=false)]
            public string AccessLogProjectStatus { get; set; }

            /// <summary>
            /// <para>The check result of the EIP associated with the API server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>exist</c>: The EIP exists.</description></item>
            /// <item><description><c>not_exist</c>: The EIP does not exist.</description></item>
            /// <item><description><c>failed</c>: The check fails.</description></item>
            /// <item><description><c>time_out</c>: The check times out.</description></item>
            /// <item><description><c>not_in_use</c>: The EIP is not associated with the API Server.</description></item>
            /// <item><description><c>locked</c>: The EIP is locked.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>exist</para>
            /// </summary>
            [NameInMap("ApiServerEIPStatus")]
            [Validation(Required=false)]
            public string ApiServerEIPStatus { get; set; }

            /// <summary>
            /// <para>The check results of the CLB instance created for exposing the API server.</para>
            /// </summary>
            [NameInMap("ApiServerLoadBalancerStatus")]
            [Validation(Required=false)]
            public DescribeServiceMeshAdditionalStatusResponseBodyClusterStatusApiServerLoadBalancerStatus ApiServerLoadBalancerStatus { get; set; }
            public class DescribeServiceMeshAdditionalStatusResponseBodyClusterStatusApiServerLoadBalancerStatus : TeaModel {
                /// <summary>
                /// <para>Indicates whether the CLB instance is locked. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c></description></item>
                /// <item><description><c>false</c></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Locked")]
                [Validation(Required=false)]
                public bool? Locked { get; set; }

                /// <summary>
                /// <para>The billing method of the CLB instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>PrePay</c>: subscription</description></item>
                /// <item><description><c>PayOnDemand</c>: pay-as-you-go</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PrePay</para>
                /// </summary>
                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                /// <summary>
                /// <para>Indicates whether the CLB instance is reused. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c></description></item>
                /// <item><description><c>false</c></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Reused")]
                [Validation(Required=false)]
                public bool? Reused { get; set; }

                /// <summary>
                /// <para>The check results of the number of backend servers of the CLB instance created for exposing Istio Pilot. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>too_much</c>: An excessive number of backend servers are created.</description></item>
                /// <item><description><c>num_exact</c>: A proper number of backend servers are created.</description></item>
                /// <item><description><c>too_little</c>: The number of backend servers falls short.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>num_exact</para>
                /// </summary>
                [NameInMap("SLBBackEndServerNumStatus")]
                [Validation(Required=false)]
                public string SLBBackEndServerNumStatus { get; set; }

                /// <summary>
                /// <para>The check results of the CLB instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>exist</c>: The CLB instance exists.</description></item>
                /// <item><description><c>not_exist</c>: The CLB instance does not exist.</description></item>
                /// <item><description><c>conflict</c>: Conflicts are detected.</description></item>
                /// <item><description><c>failed</c>: The check fails.</description></item>
                /// <item><description><c>time_out</c>: The check times out.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>exist</para>
                /// </summary>
                [NameInMap("SLBExistStatus")]
                [Validation(Required=false)]
                public string SLBExistStatus { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether audit logs exist. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>exist</c></description></item>
            /// <item><description><c>not exist</c></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>exist</para>
            /// </summary>
            [NameInMap("AuditProjectStatus")]
            [Validation(Required=false)]
            public string AuditProjectStatus { get; set; }

            [NameInMap("CanaryPilotEIPStatus")]
            [Validation(Required=false)]
            public string CanaryPilotEIPStatus { get; set; }

            /// <summary>
            /// <para>The check results of the CLB instance that is created for exposing Istio Pilot and used during canary release.</para>
            /// </summary>
            [NameInMap("CanaryPilotLoadBalancerStatus")]
            [Validation(Required=false)]
            public DescribeServiceMeshAdditionalStatusResponseBodyClusterStatusCanaryPilotLoadBalancerStatus CanaryPilotLoadBalancerStatus { get; set; }
            public class DescribeServiceMeshAdditionalStatusResponseBodyClusterStatusCanaryPilotLoadBalancerStatus : TeaModel {
                /// <summary>
                /// <para>Indicates whether the CLB instance is locked due to overdue payments. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c></description></item>
                /// <item><description><c>false</c></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Locked")]
                [Validation(Required=false)]
                public bool? Locked { get; set; }

                /// <summary>
                /// <para>The billing method of the CLB instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>PrePay</c>: subscription</description></item>
                /// <item><description><c>PayOnDemand</c> (default): pay-as-you-go</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PayOnDemand</para>
                /// </summary>
                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                /// <summary>
                /// <para>Indicates whether the CLB instance is reused. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: The CLB instance is reused. Non-ASM listener configuration is detected in the listener configurations of the CLB instance.</description></item>
                /// <item><description><c>false</c>: The CLB instance is not reused.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Reused")]
                [Validation(Required=false)]
                public bool? Reused { get; set; }

                /// <summary>
                /// <para>The check result of the number of backend servers of the CLB instance created for exposing Istio Pilot. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>num_exact</c>: A proper number of backend servers are created.</description></item>
                /// <item><description><c>too_much</c>: An excessive number of backend servers are created.</description></item>
                /// <item><description><c>too_little</c>: The number of backend servers falls short.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>num_exact</para>
                /// </summary>
                [NameInMap("SLBBackEndServerNumStatus")]
                [Validation(Required=false)]
                public string SLBBackEndServerNumStatus { get; set; }

                /// <summary>
                /// <para>The check result of the CLB instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>exist</c>: The CLB instance exists.</description></item>
                /// <item><description><c>not_exist</c>: The CLB instance does not exist.</description></item>
                /// <item><description><c>time_out</c>: The check times out.</description></item>
                /// <item><description><c>failed</c>: The CLB instance has expired.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>exist</para>
                /// </summary>
                [NameInMap("SLBExistStatus")]
                [Validation(Required=false)]
                public string SLBExistStatus { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether control plane logs exist. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>exist</c>: Control plane logs exist.</description></item>
            /// <item><description><c>not_exist</c>: Control plane logs do not exist.</description></item>
            /// <item><description><c>failed</c>: The check fails.</description></item>
            /// <item><description><c>time_out</c>: The check times out.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>exist</para>
            /// </summary>
            [NameInMap("ControlPlaneProjectStatus")]
            [Validation(Required=false)]
            public string ControlPlaneProjectStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether Logtail is installed in clusters on the data plane.</para>
            /// </summary>
            [NameInMap("LogtailStatusRecord")]
            [Validation(Required=false)]
            public Dictionary<string, object> LogtailStatusRecord { get; set; }

            /// <summary>
            /// <para>The check result of whether the EIP is associated with the API server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>exist</c>: The EIP exists.</description></item>
            /// <item><description><c>not_exist</c>: The EIP does not exist.</description></item>
            /// <item><description><c>failed</c>: The check fails.</description></item>
            /// <item><description><c>time_out</c>: The check is timed out.</description></item>
            /// <item><description><c>not_in_use</c>: The EIP is not associated with the API server.</description></item>
            /// <item><description><c>locked</c>: The EIP is locked.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>exist</para>
            /// </summary>
            [NameInMap("PilotEIPStatus")]
            [Validation(Required=false)]
            public string PilotEIPStatus { get; set; }

            /// <summary>
            /// <para>The check results of the CLB instance created for exposing Istio Pilot.</para>
            /// </summary>
            [NameInMap("PilotLoadBalancerStatus")]
            [Validation(Required=false)]
            public DescribeServiceMeshAdditionalStatusResponseBodyClusterStatusPilotLoadBalancerStatus PilotLoadBalancerStatus { get; set; }
            public class DescribeServiceMeshAdditionalStatusResponseBodyClusterStatusPilotLoadBalancerStatus : TeaModel {
                /// <summary>
                /// <para>Indicates whether the CLB instance is locked. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c></description></item>
                /// <item><description><c>false</c></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Locked")]
                [Validation(Required=false)]
                public bool? Locked { get; set; }

                /// <summary>
                /// <para>The billing method of the CLB instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>PrePay</c>: subscription</description></item>
                /// <item><description><c>PayOnDemand</c>: pay-as-you-go</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PayOnDemand</para>
                /// </summary>
                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                /// <summary>
                /// <para>Indicates whether the CLB instance is reused. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c></description></item>
                /// <item><description><c>false</c></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Reused")]
                [Validation(Required=false)]
                public bool? Reused { get; set; }

                /// <summary>
                /// <para>The check results of the number of backend servers of the CLB instance created for exposing Istio Pilot. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>too_much</c>: An excessive number of backend servers are created.</description></item>
                /// <item><description><c>num_exact</c>: A proper number of backend servers are created.</description></item>
                /// <item><description><c>too_little</c>: The number of backend servers falls short.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>num_exact</para>
                /// </summary>
                [NameInMap("SLBBackEndServerNumStatus")]
                [Validation(Required=false)]
                public string SLBBackEndServerNumStatus { get; set; }

                /// <summary>
                /// <para>The check results of the CLB instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>exist</c>: The CLB instance exists.</description></item>
                /// <item><description><c>not_exist</c>: The CLB instance does not exist.</description></item>
                /// <item><description><c>conflict</c>: Conflicts are detected.</description></item>
                /// <item><description><c>failed</c>: The check fails.</description></item>
                /// <item><description><c>time_out</c>: The check times out.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>exist</para>
                /// </summary>
                [NameInMap("SLBExistStatus")]
                [Validation(Required=false)]
                public string SLBExistStatus { get; set; }

            }

            /// <summary>
            /// <para>The status of the RAM OAuth application that is integrated with Mesh Topology. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>exist</c>: The RAM OAuth application exists.</description></item>
            /// <item><description><c>reused</c>: The RAM OAuth application is reused.</description></item>
            /// <item><description><c>not_exist</c>: The RAM OAuth application does not exist.</description></item>
            /// <item><description><c>failed</c>: The check fails.</description></item>
            /// <item><description><c>time_out</c>: The check times out.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>reused</para>
            /// </summary>
            [NameInMap("RAMApplicationStatus")]
            [Validation(Required=false)]
            public string RAMApplicationStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether the security group is reused. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>reused</c>: The security group is reused.</description></item>
            /// <item><description><c>not_reused</c>: The security group is not reused.</description></item>
            /// <item><description><c>failed</c>: The check fails.</description></item>
            /// <item><description><c>time_out</c>: The check times out.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>reused</para>
            /// </summary>
            [NameInMap("SgStatus")]
            [Validation(Required=false)]
            public string SgStatus { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11fd0027-c27e-41bb-a565-75583054****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
