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
        /// <para>The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If no value is returned for <b>NextToken</b>, no next requests are performed.</description></item>
        /// <item><description>If a value is returned for <b>NextToken</b>, the value can be used in the next request to retrieve a new page of results.</description></item>
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
        /// <para>The endpoint services.</para>
        /// </summary>
        [NameInMap("Services")]
        [Validation(Required=false)]
        public List<ListVpcEndpointServicesResponseBodyServices> Services { get; set; }
        public class ListVpcEndpointServicesResponseBodyServices : TeaModel {
            /// <summary>
            /// <para>The protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>IPv4</b></description></item>
            /// <item><description><b>DualStack</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IPv4</para>
            /// </summary>
            [NameInMap("AddressIpVersion")]
            [Validation(Required=false)]
            public string AddressIpVersion { get; set; }

            /// <summary>
            /// <para>Indicates whether endpoint connection requests are automatically accepted. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Endpoint connection requests are automatically accepted.</description></item>
            /// <item><description><b>false</b>: Endpoint connection requests are not automatically accepted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AutoAcceptEnabled")]
            [Validation(Required=false)]
            public bool? AutoAcceptEnabled { get; set; }

            /// <summary>
            /// <para>The default maximum bandwidth of the endpoint connection. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("ConnectBandwidth")]
            [Validation(Required=false)]
            public int? ConnectBandwidth { get; set; }

            /// <summary>
            /// <para>The time when the endpoint service was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-09-24T17:15:10Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The maximum bandwidth of the endpoint connection. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("MaxBandwidth")]
            [Validation(Required=false)]
            public int? MaxBandwidth { get; set; }

            /// <summary>
            /// <para>The minimum bandwidth of the endpoint connection. Unit: Mbit/s.</para>
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
            /// <item><description><b>Endpoint</b>: service consumer</description></item>
            /// <item><description><b>EndpointService</b>: service provider</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Endpoint</para>
            /// </summary>
            [NameInMap("Payer")]
            [Validation(Required=false)]
            public string Payer { get; set; }

            /// <summary>
            /// <para>The region ID of the endpoint service.</para>
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
            /// <para>The service state of the endpoint service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Normal</b>: The endpoint service runs as expected.</description></item>
            /// <item><description><b>FinancialLocked</b>: The endpoint service is locked due to overdue payments.</description></item>
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
            /// <item><description><b>slb</b>: Classic Load Balancer (CLB) instance</description></item>
            /// <item><description><b>alb</b>: Application Load Balancer (ALB) instance</description></item>
            /// <item><description><b>nlb</b>: Network Load Balancer (NLB) instance</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>slb</para>
            /// </summary>
            [NameInMap("ServiceResourceType")]
            [Validation(Required=false)]
            public string ServiceResourceType { get; set; }

            /// <summary>
            /// <para>The state of the endpoint service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Creating</b>: The endpoint service is being created.</description></item>
            /// <item><description><b>Pending</b>: The endpoint service is being modified.</description></item>
            /// <item><description><b>Active</b>: The endpoint service is available.</description></item>
            /// <item><description><b>Deleting</b>: The endpoint service is being deleted.</description></item>
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
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
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
            /// <para>The type of the endpoint service.</para>
            /// <list type="bullet">
            /// <item><description>Only <b>Interface</b> may be returned. You can specify CLB, ALB, and NLB instances as the service resources of the endpoint service.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Interface</para>
            /// </summary>
            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            /// <summary>
            /// <para>The tags added to the resource.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListVpcEndpointServicesResponseBodyServicesTags> Tags { get; set; }
            public class ListVpcEndpointServicesResponseBodyServicesTags : TeaModel {
                /// <summary>
                /// <para>The key of the tag added to the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceDept</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the tag added to the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceJoshua</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether zone affinity is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
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
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
