// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateEndpointGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the accelerator.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga-bp1odcab8tmno0hdq****</para>
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// <para>The client token used to ensure request idempotence.</para>
        /// <para>You can generate the token on your client. Ensure that it is unique across different requests. The value of <c>ClientToken</c> can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the request as the <b>ClientToken</b>. The <b>RequestId</b> is unique for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1F4B6A4A-C89E-489E-BAF1-52777EE148EF</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: performs a dry run but does not create the resource. The system checks the required parameters, request format, and service limits. If the request fails the dry run, the system returns an error message. If the request passes the dry run, the system returns a 2xx HTTP status code.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): sends a normal request and creates the resource if the request passes.</para>
        /// </description></item>
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
        /// <para>You can configure up to 10 endpoint groups.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("EndpointGroupConfigurations")]
        [Validation(Required=false)]
        public List<CreateEndpointGroupsRequestEndpointGroupConfigurations> EndpointGroupConfigurations { get; set; }
        public class CreateEndpointGroupsRequestEndpointGroupConfigurations : TeaModel {
            /// <summary>
            /// <para>The configurations of the endpoints in the endpoint group.</para>
            /// </summary>
            [NameInMap("EndpointConfigurations")]
            [Validation(Required=false)]
            public List<CreateEndpointGroupsRequestEndpointGroupConfigurationsEndpointConfigurations> EndpointConfigurations { get; set; }
            public class CreateEndpointGroupsRequestEndpointGroupConfigurationsEndpointConfigurations : TeaModel {
                [NameInMap("ApiKeys")]
                [Validation(Required=false)]
                public List<string> ApiKeys { get; set; }

                /// <summary>
                /// <para>Specifies whether to preserve client IP addresses. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: preserves client IP addresses.</para>
                /// </description></item>
                /// <item><description><para><b>false</b> (default): does not preserve client IP addresses.</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description><para>For endpoint groups of UDP and TCP listeners, the preserve client IP feature is disabled by default. You can enable this feature based on your business requirements.</para>
                /// </description></item>
                /// <item><description><para>For endpoint groups of HTTP and HTTPS listeners, the preserve client IP feature is enabled by default. Client IP addresses are preserved in the X-Forwarded-For header. You cannot disable this feature.</para>
                /// </description></item>
                /// <item><description><para><c>EnableClientIPPreservation</c> and <c>EnableProxyProtocol</c> cannot be set to <c>true</c> at the same time.</para>
                /// </description></item>
                /// <item><description><para>For more information, see <a href="https://help.aliyun.com/document_detail/158080.html">preserve client IP addresses</a>.</para>
                /// </description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("EnableClientIPPreservation")]
                [Validation(Required=false)]
                public bool? EnableClientIPPreservation { get; set; }

                /// <summary>
                /// <para>Specifies whether to use the Proxy Protocol to preserve client IP addresses. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: uses the Proxy Protocol to preserve client IP addresses.</para>
                /// </description></item>
                /// <item><description><para><b>false</b> (default): does not use the Proxy Protocol to preserve client IP addresses.</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description><para>This parameter is available only for endpoint groups that are associated with TCP listeners.</para>
                /// </description></item>
                /// <item><description><para><c>EnableClientIPPreservation</c> and <c>EnableProxyProtocol</c> cannot be set to <c>true</c> at the same time.</para>
                /// </description></item>
                /// <item><description><para>For more information, see <a href="https://help.aliyun.com/document_detail/158080.html">preserve client IP addresses</a>.</para>
                /// </description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("EnableProxyProtocol")]
                [Validation(Required=false)]
                public bool? EnableProxyProtocol { get; set; }

                /// <summary>
                /// <para>The IP address or domain name of the endpoint.</para>
                /// <para>In an endpoint group of an intelligent routing listener, you can enter a maximum of 100 endpoint IP addresses or domain names.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.1.1.1</para>
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>BAILIAN</para>
                /// </summary>
                [NameInMap("Provider")]
                [Validation(Required=false)]
                public string Provider { get; set; }

                /// <summary>
                /// <para>The private IP address of the elastic network interface (ENI).</para>
                /// <remarks>
                /// <para>This parameter is available only when the endpoint type is <b>ENI</b>. If you do not specify this parameter, the system uses the primary private IP address of the ENI.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>172.168.XX.XX</para>
                /// </summary>
                [NameInMap("SubAddress")]
                [Validation(Required=false)]
                public string SubAddress { get; set; }

                /// <summary>
                /// <para>The type of endpoint in an intelligent routing listener. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Domain</b>: a custom domain name.</para>
                /// </description></item>
                /// <item><description><para><b>Ip</b>: a custom IP address.</para>
                /// </description></item>
                /// <item><description><para><b>IpTarget</b>: a custom private IP address.</para>
                /// </description></item>
                /// <item><description><para><b>PublicIp</b>: an Alibaba Cloud public IP address.</para>
                /// </description></item>
                /// <item><description><para><b>ECS</b>: an ECS instance.</para>
                /// </description></item>
                /// <item><description><para><b>SLB</b>: an SLB instance.</para>
                /// </description></item>
                /// <item><description><para><b>ALB</b>: an ALB instance.</para>
                /// </description></item>
                /// <item><description><para><b>OSS</b>: an OSS bucket.</para>
                /// </description></item>
                /// <item><description><para><b>ENI</b>: an elastic network interface.</para>
                /// </description></item>
                /// <item><description><para><b>NLB</b>: an NLB instance.</para>
                /// </description></item>
                /// </list>
                /// <para>In an endpoint group of an intelligent routing listener, you can specify up to 100 endpoints.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description><para>If the routing type of the listener is <b>Standard</b> (intelligent routing), you must configure the endpoint group and endpoint information for the listener. This parameter is required.</para>
                /// </description></item>
                /// <item><description><para>If you set Type to <b>ECS</b>, <b>ENI</b>, <b>SLB</b>, or <b>IpTarget</b> and a service-linked role does not exist, the system automatically creates a service-linked role named AliyunServiceRoleForGaVpcEndpoint.</para>
                /// </description></item>
                /// <item><description><para>If you set Type to <b>ALB</b> and a service-linked role does not exist, the system automatically creates a service-linked role named AliyunServiceRoleForGaAlb.</para>
                /// </description></item>
                /// <item><description><para>If you set Type to <b>OSS</b> and a service-linked role does not exist, the system automatically creates a service-linked role named AliyunServiceRoleForGaOss.</para>
                /// </description></item>
                /// <item><description><para>If you set Type to <b>NLB</b> and a service-linked role does not exist, the system automatically creates a service-linked role named AliyunServiceRoleForGaNlb.</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/178360.html">service-linked roles</a>.</para>
                /// </remarks>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Domain</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>A list of VSwitch IDs.</para>
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public List<string> VSwitchIds { get; set; }

                /// <summary>
                /// <para>The ID of the VPC.</para>
                /// <para>In an endpoint group of an intelligent routing listener, you can specify only one VPC ID.</para>
                /// <remarks>
                /// <para>This parameter is required only when you set Type to <b>IpTarget</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-2zekzii824szm3hps****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The weight of the endpoint.</para>
                /// <para>Valid values: <b>0</b> to <b>255</b>.</para>
                /// <remarks>
                /// <para>If you set the weight of an endpoint to 0, Global Accelerator stops distributing traffic to the endpoint. Proceed with caution.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public long? Weight { get; set; }

            }

            /// <summary>
            /// <para>The description of the endpoint group.</para>
            /// <para>The description can be up to 200 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EndpointGroup</para>
            /// </summary>
            [NameInMap("EndpointGroupDescription")]
            [Validation(Required=false)]
            public string EndpointGroupDescription { get; set; }

            /// <summary>
            /// <para>The name of the endpoint group.</para>
            /// <para>The name must be 1 to 128 characters long, start with a letter or a Chinese character, and contain digits, periods (.), underscores (_), and hyphens (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>group1</para>
            /// </summary>
            [NameInMap("EndpointGroupName")]
            [Validation(Required=false)]
            public string EndpointGroupName { get; set; }

            /// <summary>
            /// <para>The ID of the region where the endpoint group is deployed.</para>
            /// <para>You can enter up to 10 endpoint group region IDs.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hongkong</para>
            /// </summary>
            [NameInMap("EndpointGroupRegion")]
            [Validation(Required=false)]
            public string EndpointGroupRegion { get; set; }

            /// <summary>
            /// <para>The type of the endpoint group in an intelligent routing listener. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>default</b> (default): a default endpoint group.</para>
            /// </description></item>
            /// <item><description><para><b>virtual</b>: a virtual endpoint group.</para>
            /// </description></item>
            /// </list>
            /// <para>You can enter up to 10 endpoint group types.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("EndpointGroupType")]
            [Validation(Required=false)]
            public string EndpointGroupType { get; set; }

            /// <summary>
            /// <para>The IP version of the backend service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>IPv4</b> (default): Global Accelerator uses only IPv4 addresses to communicate with the backend service.</para>
            /// </description></item>
            /// <item><description><para><b>IPv6</b>: Global Accelerator uses only IPv6 addresses to communicate with the backend service.</para>
            /// </description></item>
            /// <item><description><para><b>ProtocolAffinity</b>: Global Accelerator communicates with the backend service using the same IP version as the client request.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IPv4</para>
            /// </summary>
            [NameInMap("EndpointIpVersion")]
            [Validation(Required=false)]
            public string EndpointIpVersion { get; set; }

            /// <summary>
            /// <para>The protocol version of the backend service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>HTTP1.1</b> (default): HTTP 1.1.</para>
            /// </description></item>
            /// <item><description><para><b>HTTP2</b>: HTTP 2.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>You can set this parameter only when <c>EndpointRequestProtocol</c> is set to <b>HTTPS</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP1.1</para>
            /// </summary>
            [NameInMap("EndpointProtocolVersion")]
            [Validation(Required=false)]
            public string EndpointProtocolVersion { get; set; }

            /// <summary>
            /// <para>The protocol of the backend service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>HTTP</b></para>
            /// </description></item>
            /// <item><description><para><b>HTTPS</b></para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>You can set this parameter only when you create an endpoint group for an HTTP or HTTPS listener.</para>
            /// </description></item>
            /// <item><description><para>For an HTTP listener, you can set this parameter only to HTTP.</para>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>HTTPS</para>
            /// </summary>
            [NameInMap("EndpointRequestProtocol")]
            [Validation(Required=false)]
            public string EndpointRequestProtocol { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable health checks for the endpoint group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: enables health checks.</para>
            /// </description></item>
            /// <item><description><para><b>false</b> (default): disables health checks.</para>
            /// </description></item>
            /// </list>
            /// <para>You can enable health checks for up to 10 endpoint groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HealthCheckEnabled")]
            [Validation(Required=false)]
            public bool? HealthCheckEnabled { get; set; }

            /// <summary>
            /// <para>The domain name to which health check requests are sent.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.taobao.com">www.taobao.com</a></para>
            /// </summary>
            [NameInMap("HealthCheckHost")]
            [Validation(Required=false)]
            public string HealthCheckHost { get; set; }

            /// <summary>
            /// <para>The interval between health checks, in seconds.</para>
            /// <para>You can enter up to 10 health check intervals.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("HealthCheckIntervalSeconds")]
            [Validation(Required=false)]
            public long? HealthCheckIntervalSeconds { get; set; }

            /// <summary>
            /// <para>The path used for health checks.</para>
            /// <para>You can enter up to 10 health check paths.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/healthcheck</para>
            /// </summary>
            [NameInMap("HealthCheckPath")]
            [Validation(Required=false)]
            public string HealthCheckPath { get; set; }

            /// <summary>
            /// <para>The port used for health checks. Valid values: <b>1</b> to <b>65535</b>.</para>
            /// <para>You can enter up to 10 ports for health checks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>443</para>
            /// </summary>
            [NameInMap("HealthCheckPort")]
            [Validation(Required=false)]
            public long? HealthCheckPort { get; set; }

            /// <summary>
            /// <para>The protocol used for health checks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>tcp</b> or <b>TCP</b>: TCP protocol.</para>
            /// </description></item>
            /// <item><description><para><b>http</b> or <b>HTTP</b>: HTTP protocol.</para>
            /// </description></item>
            /// <item><description><para><b>https</b> or <b>HTTPS</b>: HTTPS protocol.</para>
            /// </description></item>
            /// </list>
            /// <para>You can enter up to 10 health check protocols.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HTTPS</para>
            /// </summary>
            [NameInMap("HealthCheckProtocol")]
            [Validation(Required=false)]
            public string HealthCheckProtocol { get; set; }

            /// <summary>
            /// <para>The port override settings.</para>
            /// </summary>
            [NameInMap("PortOverrides")]
            [Validation(Required=false)]
            public List<CreateEndpointGroupsRequestEndpointGroupConfigurationsPortOverrides> PortOverrides { get; set; }
            public class CreateEndpointGroupsRequestEndpointGroupConfigurationsPortOverrides : TeaModel {
                /// <summary>
                /// <para>The endpoint port used for the port override.</para>
                /// 
                /// <b>Example:</b>
                /// <para>443</para>
                /// </summary>
                [NameInMap("EndpointPort")]
                [Validation(Required=false)]
                public long? EndpointPort { get; set; }

                /// <summary>
                /// <para>The listener port.</para>
                /// <para>Valid values: <b>1</b> to <b>65499</b>.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description><para>For TCP listeners, you cannot configure port overrides for a virtual endpoint group. If a virtual endpoint group already exists for the listener, you cannot configure port overrides for the default endpoint group. If port overrides are configured for the default endpoint group, you cannot add a virtual endpoint group.</para>
                /// </description></item>
                /// <item><description><para>After you configure a port override, you cannot change the listener protocol, except for switching between HTTP and HTTPS.</para>
                /// </description></item>
                /// <item><description><para>When you modify the listener port range, the new range must include all listener ports that are used in the port overrides. For example, if the listener port range is 80-82 and a port override is configured to map listener ports to endpoint ports 100-102, you cannot change the listener port range to 80-81.</para>
                /// </description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("ListenerPort")]
                [Validation(Required=false)]
                public long? ListenerPort { get; set; }

            }

            /// <summary>
            /// <para>This parameter is reserved.</para>
            /// </summary>
            [NameInMap("SystemTag")]
            [Validation(Required=false)]
            public List<CreateEndpointGroupsRequestEndpointGroupConfigurationsSystemTag> SystemTag { get; set; }
            public class CreateEndpointGroupsRequestEndpointGroupConfigurationsSystemTag : TeaModel {
                /// <summary>
                /// <para>This parameter is reserved.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>This parameter is reserved.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("Scope")]
                [Validation(Required=false)]
                public string Scope { get; set; }

                /// <summary>
                /// <para>This parameter is reserved.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The tags to add to the endpoint group. You can specify up to 20 tags.</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<CreateEndpointGroupsRequestEndpointGroupConfigurationsTag> Tag { get; set; }
            public class CreateEndpointGroupsRequestEndpointGroupConfigurationsTag : TeaModel {
                /// <summary>
                /// <para>The key of the tag. The tag key cannot be an empty string.</para>
                /// <para>The tag key can be up to 64 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
                /// <para>You can enter up to 20 tag keys.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag-key</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the tag. The tag value can be an empty string.</para>
                /// <para>The tag value can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
                /// <para>You can enter up to 20 tag values.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag-value</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The number of consecutive health checks that must succeed for an endpoint to be considered healthy, or fail for it to be considered unhealthy. Valid values: <b>2</b> to <b>10</b>. Default value: <b>3</b>.</para>
            /// <para>You can enter up to 10 values for the number of consecutive health checks required for a health status change.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ThresholdCount")]
            [Validation(Required=false)]
            public long? ThresholdCount { get; set; }

            /// <summary>
            /// <para>The traffic distribution percentage for the endpoint group. If an intelligent routing listener is associated with multiple endpoint groups, this parameter specifies the percentage of traffic that is routed to this endpoint group.</para>
            /// <para>Valid values: <b>1</b> to <b>100</b>. Default value: <b>100</b>.</para>
            /// <para>You can enter traffic dial values for up to 10 endpoint groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TrafficPercentage")]
            [Validation(Required=false)]
            public long? TrafficPercentage { get; set; }

        }

        /// <summary>
        /// <para>The ID of the listener.</para>
        /// <remarks>
        /// <para>If the listener protocol is <b>HTTP</b> or <b>HTTPS</b>, you can create only one endpoint group in each <b>CreateEndpointGroups</b> call.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsr-bp1bpn0kn908w4nbw****</para>
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the accelerator is deployed. Set the value to <b>cn-hangzhou</b>.</para>
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
