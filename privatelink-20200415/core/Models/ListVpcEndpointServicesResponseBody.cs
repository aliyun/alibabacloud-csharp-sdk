// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class ListVpcEndpointServicesResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>NextToken</b> is empty, no further results exist.</para>
        /// </description></item>
        /// <item><description><para>If <b>NextToken</b> has a value, use it as the starting token for the next query.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0ED8D006-F706-4D23-88ED-E11ED28DCAC0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The collection of endpoint services.</para>
        /// </summary>
        [NameInMap("Services")]
        [Validation(Required=false)]
        public List<ListVpcEndpointServicesResponseBodyServices> Services { get; set; }
        public class ListVpcEndpointServicesResponseBodyServices : TeaModel {
            /// <summary>
            /// <para>The IP address version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>IPv4</b>: IPv4 type.</para>
            /// </description></item>
            /// <item><description><para><b>DualStack</b>: Dual-stack type.</para>
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
            /// <item><description><para><b>true</b>: Automatically accept endpoint connections.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Do not automatically accept endpoint connections.</para>
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
            /// <para>The default maximum bandwidth. Unit: Mbps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("ConnectBandwidth")]
            [Validation(Required=false)]
            public int? ConnectBandwidth { get; set; }

            /// <summary>
            /// <para>The time when the endpoint service was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-09-24T17:15:10Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The maximum bandwidth of the endpoint connection. Unit: Mbps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("MaxBandwidth")]
            [Validation(Required=false)]
            public int? MaxBandwidth { get; set; }

            /// <summary>
            /// <para>The minimum bandwidth of the endpoint connection. Unit: Mbps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("MinBandwidth")]
            [Validation(Required=false)]
            public int? MinBandwidth { get; set; }

            /// <summary>
            /// <para>The payer. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Endpoint</b>: the service consumer.</para>
            /// </description></item>
            /// <item><description><para><b>EndpointService</b>: the service provider.</para>
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
            /// <para>The region where the endpoint service is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-huhehaote</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

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
            /// <para>The business status of the endpoint service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Normal</b>: The endpoint service is running as expected.</para>
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
            /// <para>The description of the endpoint service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is my EndpointService.</para>
            /// </summary>
            [NameInMap("ServiceDescription")]
            [Validation(Required=false)]
            public string ServiceDescription { get; set; }

            /// <summary>
            /// <para>The domain name of the endpoint service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>epsrv-hp3vpx8yqxblby3i****.cn-huhehaote.privatelink.aliyuncs.com</para>
            /// </summary>
            [NameInMap("ServiceDomain")]
            [Validation(Required=false)]
            public string ServiceDomain { get; set; }

            /// <summary>
            /// <para>The ID of the endpoint service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>epsrv-hp3vpx8yqxblby3i****</para>
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <para>The name of the endpoint service.</para>
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
            /// <item><description><para><b>slb</b>: The service resource is a CLB instance.</para>
            /// </description></item>
            /// <item><description><para><b>alb</b>: The service resource is an ALB instance.</para>
            /// </description></item>
            /// <item><description><para><b>nlb</b>: The service resource is an NLB instance.</para>
            /// </description></item>
            /// <item><description><para><b>gwlb</b>: The service resource is a GWLB instance.</para>
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
            /// <para>The status of the endpoint service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Creating</b>: The endpoint service is being created.</para>
            /// </description></item>
            /// <item><description><para><b>Pending</b>: The endpoint service is being modified.</para>
            /// </description></item>
            /// <item><description><para><b>Active</b>: The endpoint service is available.</para>
            /// </description></item>
            /// <item><description><para><b>Deleting</b>: The endpoint service is being deleted.</para>
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
            /// <para>Indicates whether the endpoint service supports IPv6. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Yes.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: No.</para>
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
            /// <para>The type of the endpoint service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Interface</b>: an interface endpoint. You can add CLB, ALB, and NLB instances as service resources.</para>
            /// </description></item>
            /// <item><description><para><b>GatewayLoadBalancer</b>: a Gateway Load Balancer endpoint. You can add GWLB instances as service resources.</para>
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
            /// <para>The list of regions supported by the endpoint service. Service consumers can initiate endpoint connections from these regions.</para>
            /// </summary>
            [NameInMap("SupportedRegionSet")]
            [Validation(Required=false)]
            public List<ListVpcEndpointServicesResponseBodyServicesSupportedRegionSet> SupportedRegionSet { get; set; }
            public class ListVpcEndpointServicesResponseBodyServicesSupportedRegionSet : TeaModel {
                /// <summary>
                /// <para>The business status of the region supported by the endpoint service. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Normal</b>: Normal.</para>
                /// </description></item>
                /// <item><description><para><b>FinancialLocked</b>: Locked due to an overdue payment.</para>
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
                /// <para>The status of the region supported by the endpoint service. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Pending</b>: The status is being updated.</para>
                /// </description></item>
                /// <item><description><para><b>Available</b>: The region is available.</para>
                /// </description></item>
                /// <item><description><para><b>Deleting</b>: The region is being deleted.</para>
                /// </description></item>
                /// <item><description><para><b>Failed</b>: The operation failed.</para>
                /// </description></item>
                /// <item><description><para><b>Closed</b>: The region is closed.</para>
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
                /// <para>The ID of the region supported by the endpoint service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("SupportedRegionId")]
                [Validation(Required=false)]
                public string SupportedRegionId { get; set; }

            }

            /// <summary>
            /// <para>The list of tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListVpcEndpointServicesResponseBodyServicesTags> Tags { get; set; }
            public class ListVpcEndpointServicesResponseBodyServicesTags : TeaModel {
                /// <summary>
                /// <para>The tag key of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceDept</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceJoshua</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether zonal affinity is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Yes.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: No.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ZoneAffinityEnabled")]
            [Validation(Required=false)]
            public bool? ZoneAffinityEnabled { get; set; }

        }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
