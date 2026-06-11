// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class GetVpcEndpointServiceAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The IP address version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>IPv4</b>: The IPv4 address family.</para>
        /// </description></item>
        /// <item><description><para><b>DualStack</b>: The dual stack IP address family.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("AddressIpVersion")]
        [Validation(Required=false)]
        public string AddressIpVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically accept endpoint connections. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Endpoint connections are automatically accepted.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Endpoint connections are not automatically accepted.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoAcceptEnabled")]
        [Validation(Required=false)]
        public bool? AutoAcceptEnabled { get; set; }

        /// <summary>
        /// <para>The default maximum bandwidth of an endpoint connection, in Mbps. Valid values are <b>100 to 10,240</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3072</para>
        /// </summary>
        [NameInMap("ConnectBandwidth")]
        [Validation(Required=false)]
        public int? ConnectBandwidth { get; set; }

        /// <summary>
        /// <para>The time the service was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-01-02T19:11:12Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The maximum bandwidth of the endpoint connection, in Mbps.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("MaxBandwidth")]
        [Validation(Required=false)]
        public int? MaxBandwidth { get; set; }

        /// <summary>
        /// <para>The minimum bandwidth of the endpoint connection, in Mbps.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MinBandwidth")]
        [Validation(Required=false)]
        public int? MinBandwidth { get; set; }

        /// <summary>
        /// <para>The party that pays for the service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Endpoint</b>: The service consumer.</para>
        /// </description></item>
        /// <item><description><para><b>EndpointService</b>: The service provider.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Endpoint</para>
        /// </summary>
        [NameInMap("Payer")]
        [Validation(Required=false)]
        public string Payer { get; set; }

        /// <summary>
        /// <para>The region where the service is deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-huhehaote</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8D8992C1-6712-423C-BAC5-E5E817484C6B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmy*****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The business status of the service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Normal</b>: The service is operating normally.</para>
        /// </description></item>
        /// <item><description><para><b>FinancialLocked</b>: The endpoint service is locked due to an overdue payment.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("ServiceBusinessStatus")]
        [Validation(Required=false)]
        public string ServiceBusinessStatus { get; set; }

        /// <summary>
        /// <para>The description of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is my EndpointService.</para>
        /// </summary>
        [NameInMap("ServiceDescription")]
        [Validation(Required=false)]
        public string ServiceDescription { get; set; }

        /// <summary>
        /// <para>The domain name of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epsrv-hp3vpx8yqxblby3i****.cn-huhehaote.privatelink.aliyuncs.com</para>
        /// </summary>
        [NameInMap("ServiceDomain")]
        [Validation(Required=false)]
        public string ServiceDomain { get; set; }

        /// <summary>
        /// <para>The ID of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epsrv-hp3vpx8yqxblby3i****</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The name of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>com.aliyuncs.privatelink.cn-huhehaote.epsrv-hp3vpx8yqxblby3i****</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>The type of the service resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>slb</b>: The service resource is a Classic Load Balancer (CLB).</para>
        /// </description></item>
        /// <item><description><para><b>alb</b>: The service resource is an Application Load Balancer (ALB).</para>
        /// </description></item>
        /// <item><description><para><b>nlb</b>: The service resource is a Network Load Balancer (NLB).</para>
        /// </description></item>
        /// <item><description><para><b>gwlb</b>: The service resource is a Gateway Load Balancer (GWLB).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>slb</para>
        /// </summary>
        [NameInMap("ServiceResourceType")]
        [Validation(Required=false)]
        public string ServiceResourceType { get; set; }

        /// <summary>
        /// <para>The status of the service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Creating</b>: The service is being created.</para>
        /// </description></item>
        /// <item><description><para><b>Pending</b>: The service is being updated.</para>
        /// </description></item>
        /// <item><description><para><b>Active</b>: The service is available.</para>
        /// </description></item>
        /// <item><description><para><b>Deleting</b>: The service is being deleted.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("ServiceStatus")]
        [Validation(Required=false)]
        public string ServiceStatus { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Specifies whether the service supports IPv6. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The service supports IPv6.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): The service does not support IPv6.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ServiceSupportIPv6")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? ServiceSupportIPv6 { get; set; }

        /// <summary>
        /// <para>The endpoint type.</para>
        /// <list type="bullet">
        /// <item><description><para><b>Interface</b>: An interface endpoint. You can add Classic Load Balancer (CLB), Application Load Balancer (ALB), and Network Load Balancer (NLB) instances as service resources.</para>
        /// </description></item>
        /// <item><description><para><b>GatewayLoadBalancer</b>: A gateway endpoint. You can add Gateway Load Balancer (GWLB) instances as service resources.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Interface</para>
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// <para>The regions where the service is supported. Service consumers can create endpoint connections to the service from these regions.</para>
        /// </summary>
        [NameInMap("SupportedRegionSet")]
        [Validation(Required=false)]
        public List<GetVpcEndpointServiceAttributeResponseBodySupportedRegionSet> SupportedRegionSet { get; set; }
        public class GetVpcEndpointServiceAttributeResponseBodySupportedRegionSet : TeaModel {
            /// <summary>
            /// <para>The business status of the endpoint service in the supported region. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Normal</b>: The service is operating normally in the supported region.</para>
            /// </description></item>
            /// <item><description><para><b>FinancialLocked</b>: The endpoint service is locked due to an overdue payment.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("RegionBusinessStatus")]
            [Validation(Required=false)]
            public string RegionBusinessStatus { get; set; }

            /// <summary>
            /// <para>The status of the endpoint service in the supported region. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Pending</b>: The supported region is being modified.</para>
            /// </description></item>
            /// <item><description><para><b>Available</b>: The service is available in the supported region.</para>
            /// </description></item>
            /// <item><description><para><b>Deleting</b>: The supported region is being deleted.</para>
            /// </description></item>
            /// <item><description><para><b>Failed</b>: The service failed to be deployed in the supported region.</para>
            /// </description></item>
            /// <item><description><para><b>Closed</b>: The endpoint service is not available in the supported region.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("RegionServiceStatus")]
            [Validation(Required=false)]
            public string RegionServiceStatus { get; set; }

            /// <term><b>Obsolete</b></term>
            [NameInMap("ServiceRegionId")]
            [Validation(Required=false)]
            [Obsolete]
            public string ServiceRegionId { get; set; }

            /// <summary>
            /// <para>The ID of the supported region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("SupportedRegionId")]
            [Validation(Required=false)]
            public string SupportedRegionId { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether zone affinity is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b> (default): Zone affinity is enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Zone affinity is disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ZoneAffinityEnabled")]
        [Validation(Required=false)]
        public bool? ZoneAffinityEnabled { get; set; }

        /// <summary>
        /// <para>The zones where the service is available.</para>
        /// </summary>
        [NameInMap("Zones")]
        [Validation(Required=false)]
        public List<string> Zones { get; set; }

    }

}
