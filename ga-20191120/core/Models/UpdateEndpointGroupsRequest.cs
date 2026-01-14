// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class UpdateEndpointGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true:</b> performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The configurations of the endpoint groups.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("EndpointGroupConfigurations")]
        [Validation(Required=false)]
        public List<UpdateEndpointGroupsRequestEndpointGroupConfigurations> EndpointGroupConfigurations { get; set; }
        public class UpdateEndpointGroupsRequestEndpointGroupConfigurations : TeaModel {
            /// <summary>
            /// <para>Specifies whether to use the proxy protocol to preserve client IP addresses. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableClientIPPreservationProxyProtocol")]
            [Validation(Required=false)]
            public bool? EnableClientIPPreservationProxyProtocol { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the TCP Option Address (TOA) module to preserve client IP addresses. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableClientIPPreservationToa")]
            [Validation(Required=false)]
            public bool? EnableClientIPPreservationToa { get; set; }

            /// <summary>
            /// <para>The configurations of the endpoints in the endpoint group.</para>
            /// </summary>
            [NameInMap("EndpointConfigurations")]
            [Validation(Required=false)]
            public List<UpdateEndpointGroupsRequestEndpointGroupConfigurationsEndpointConfigurations> EndpointConfigurations { get; set; }
            public class UpdateEndpointGroupsRequestEndpointGroupConfigurationsEndpointConfigurations : TeaModel {
                /// <summary>
                /// <para>Specifies whether to automatically preserve client IP addresses. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b> (default)</description></item>
                /// </list>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>By default, client IP address preservation is disabled for an endpoint group of a UDP or TCP listener. You can configure this parameter based on your business requirements.</description></item>
                /// <item><description>By default, client IP address preservation is enabled for an endpoint group of an HTTP or HTTP listener. You can obtain client IP addresses by using the X-Forwarded-For header. You cannot disable the feature.</description></item>
                /// <item><description>EnableClientIPPreservation and EnableProxyProtocol cannot be set to true at the same time.<remarks>
                /// <para> For more information, see <a href="https://help.aliyun.com/document_detail/158080.html">Preserve client IP addresses</a>.</para>
                /// </remarks>
                /// </description></item>
                /// </list>
                /// </remarks>
                /// </summary>
                [NameInMap("EnableClientIPPreservation")]
                [Validation(Required=false)]
                public bool? EnableClientIPPreservation { get; set; }

                /// <summary>
                /// <para>Specifies whether to use the proxy protocol to preserve client IP addresses. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b> (default)</description></item>
                /// </list>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>This parameter is available only to endpoint groups of TCP listeners.</description></item>
                /// <item><description>EnableClientIPPreservation and EnableProxyProtocol cannot be set to true at the same time.<remarks>
                /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/158080.html">Preserve client IP addresses</a>.</para>
                /// </remarks>
                /// </description></item>
                /// </list>
                /// </remarks>
                /// </summary>
                [NameInMap("EnableProxyProtocol")]
                [Validation(Required=false)]
                public bool? EnableProxyProtocol { get; set; }

                /// <summary>
                /// <para>The IP address, domain name, or instance ID based on the value of Type.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.0.XX.XX</para>
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <para>The private IP address of the ENI.</para>
                /// <remarks>
                /// <para> If you set the endpoint type to ENI, you can specify this parameter. 
                /// If you leave this parameter empty, the primary private IP address of the ENI is used.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>172.168.XX.XX</para>
                /// </summary>
                [NameInMap("SubAddress")]
                [Validation(Required=false)]
                public string SubAddress { get; set; }

                /// <summary>
                /// <para>The type of the endpoint. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Domain</b>: a custom domain name.</description></item>
                /// <item><description><b>Ip</b>: a custom IP address.</description></item>
                /// <item><description><b>IpTarget</b>: a custom private IP address.</description></item>
                /// <item><description><b>PublicIp</b>: a public IP address provided by Alibaba Cloud.</description></item>
                /// <item><description><b>ECS</b>: an Elastic Compute Service (ECS) instance.</description></item>
                /// <item><description><b>SLB</b>: a Server Load Balancer (SLB) instance.</description></item>
                /// <item><description><b>ALB</b>: an Application Load Balancer (ALB) instance.</description></item>
                /// <item><description><b>OSS</b>: an Object Storage Service (OSS) bucket.</description></item>
                /// <item><description><b>ENI</b>: an elastic network interface (ENI).</description></item>
                /// <item><description><b>NLB</b>: a Network Load Balancer (NLB) instance.</description></item>
                /// </list>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>If you set this parameter to <b>ECS</b>, <b>ENI</b>, <b>SLB</b>, <b>ALB</b>, <b>NLB</b>, or <b>IpTarget</b> and the AliyunServiceRoleForGaVpcEndpoint service-linked role does not exist, the system automatically creates the role.</description></item>
                /// <item><description>If you set this parameter to <b>ALB</b> and the AliyunServiceRoleForGaAlb service-linked role does not exist, the system automatically creates the role.</description></item>
                /// <item><description>If you set this parameter to <b>OSS</b> and the AliyunServiceRoleForGaOss service-linked role does not exist, the system automatically creates the role.<remarks>
                /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/178360.html">Service-linked roles</a>.</para>
                /// </remarks>
                /// </description></item>
                /// </list>
                /// </remarks>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Ip</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The IDs of vSwitches that are deployed in the VPC.</para>
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public List<string> VSwitchIds { get; set; }

                /// <summary>
                /// <para>The virtual private cloud (VPC) ID.</para>
                /// <para>You can specify one VPC ID for an endpoint group of an intelligent routing listener.</para>
                /// <remarks>
                /// <para> This parameter is valid and required only if Type is set to <b>IpTarget</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-uf66oesmrqge1t2gs****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The weight of the endpoint.</para>
                /// <para>Valid values: <b>0</b> to <b>255</b>.</para>
                /// <remarks>
                /// <para> If you set the weight of an endpoint to 0, GA stops distributing traffic to the endpoint. Proceed with caution.</para>
                /// </remarks>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public long? Weight { get; set; }

            }

            /// <summary>
            /// <para>The description of the endpoint group.</para>
            /// <para>The description cannot exceed 200 characters in length and cannot start with http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>group1</para>
            /// </summary>
            [NameInMap("EndpointGroupDescription")]
            [Validation(Required=false)]
            public string EndpointGroupDescription { get; set; }

            /// <summary>
            /// <para>The endpoint ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ep-bp1d2utp8qqe2a44t****</para>
            /// </summary>
            [NameInMap("EndpointGroupId")]
            [Validation(Required=false)]
            public string EndpointGroupId { get; set; }

            /// <summary>
            /// <para>The name of the endpoint group.</para>
            /// <para>The name must be 1 to 128 characters in length and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>group1</para>
            /// </summary>
            [NameInMap("EndpointGroupName")]
            [Validation(Required=false)]
            public string EndpointGroupName { get; set; }

            [NameInMap("EndpointIpVersion")]
            [Validation(Required=false)]
            public string EndpointIpVersion { get; set; }

            /// <summary>
            /// <para>The backend service protocol of the endpoint that is associated with the intelligent routing listener. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>HTTP1.1</b> (default)</description></item>
            /// <item><description><b>HTTP2</b></description></item>
            /// </list>
            /// <remarks>
            /// <para> You can specify this parameter only if EndpointRequestProtocol is set to HTTPS.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP1.1</para>
            /// </summary>
            [NameInMap("EndpointProtocolVersion")]
            [Validation(Required=false)]
            public string EndpointProtocolVersion { get; set; }

            /// <summary>
            /// <para>The backend service protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>HTTP</b></description></item>
            /// <item><description><b>HTTPS</b></description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>You can specify this parameter only if the listener that is associated with the endpoint group uses HTTP or HTTPS.</description></item>
            /// <item><description>The backend service protocol of an HTTP listener must be HTTP.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("EndpointRequestProtocol")]
            [Validation(Required=false)]
            public string EndpointRequestProtocol { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the health check feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: enables the health check feature.</description></item>
            /// <item><description><b>false</b> (default): disables the health check feature.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HealthCheckEnabled")]
            [Validation(Required=false)]
            public bool? HealthCheckEnabled { get; set; }

            [NameInMap("HealthCheckHost")]
            [Validation(Required=false)]
            public string HealthCheckHost { get; set; }

            /// <summary>
            /// <para>The interval at which health checks are performed. Unit: seconds. Valid values: <b>1</b> to <b>50</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("HealthCheckIntervalSeconds")]
            [Validation(Required=false)]
            public long? HealthCheckIntervalSeconds { get; set; }

            /// <summary>
            /// <para>The health check path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/healthcheck</para>
            /// </summary>
            [NameInMap("HealthCheckPath")]
            [Validation(Required=false)]
            public string HealthCheckPath { get; set; }

            /// <summary>
            /// <para>The port that you want to use for health checks.</para>
            /// <para>Valid values: <b>1</b> to <b>65535</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("HealthCheckPort")]
            [Validation(Required=false)]
            public long? HealthCheckPort { get; set; }

            /// <summary>
            /// <para>The protocol over which health check requests are sent. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>tcp</b> or <b>TCP</b></description></item>
            /// <item><description><b>http</b> or <b>HTTP</b></description></item>
            /// <item><description><b>https</b> or <b>HTTPS</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>tcp</para>
            /// </summary>
            [NameInMap("HealthCheckProtocol")]
            [Validation(Required=false)]
            public string HealthCheckProtocol { get; set; }

            /// <summary>
            /// <para>The port mappings.</para>
            /// </summary>
            [NameInMap("PortOverrides")]
            [Validation(Required=false)]
            public List<UpdateEndpointGroupsRequestEndpointGroupConfigurationsPortOverrides> PortOverrides { get; set; }
            public class UpdateEndpointGroupsRequestEndpointGroupConfigurationsPortOverrides : TeaModel {
                /// <summary>
                /// <para>The endpoint port.</para>
                /// <para>Valid values: <b>1</b> to <b>65499</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("EndpointPort")]
                [Validation(Required=false)]
                public long? EndpointPort { get; set; }

                /// <summary>
                /// <para>The listener port.</para>
                /// <para>Valid values: <b>1</b> to <b>65499</b>.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>You cannot configure port mappings for virtual endpoint groups of TCP listeners. If a virtual endpoint group already exists on the listener, you cannot configure port mappings for the default endpoint group. If port mappings are configured for the default endpoint group, you cannot add a virtual endpoint group.</description></item>
                /// <item><description>If you configure port mappings for a listener, you cannot modify the listener protocol. You can only switch between HTTP and HTTPS.</description></item>
                /// <item><description>Listener port: When you modify the listener port range, make sure that the port range includes the ports configured in port mappings. For example, if you set the listener port range to 80 to 82 and map the listener ports to endpoint ports 100 to 102, you cannot change the listener port range to 80 to 81.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>443</para>
                /// </summary>
                [NameInMap("ListenerPort")]
                [Validation(Required=false)]
                public long? ListenerPort { get; set; }

            }

            /// <summary>
            /// <para>The number of failed consecutive health checks that must occur before a healthy endpoint group is considered unhealthy or the number of successful consecutive health checks that must occur before an unhealthy endpoint group is considered healthy.</para>
            /// <para>Valid values: <b>2</b> to <b>10</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ThresholdCount")]
            [Validation(Required=false)]
            public long? ThresholdCount { get; set; }

            /// <summary>
            /// <para>The traffic ratio of the endpoint group when the specified listener is associated with multiple endpoint groups.</para>
            /// <para>Valid values: <b>1</b> to <b>100</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TrafficPercentage")]
            [Validation(Required=false)]
            public long? TrafficPercentage { get; set; }

        }

        /// <summary>
        /// <para>The listener ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsr-bp1bpn0kn908w4nbw****</para>
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// <para>The region ID of the GA instance. Set the value to <b>cn-hangzhou</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
