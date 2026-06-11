// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class ListVpcEndpointServicesByEndUserResponseBody : TeaModel {
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
        /// <para>The token that is used to retrieve the next page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If this parameter is empty, all results have been returned.</para>
        /// </description></item>
        /// <item><description><para>If a value is returned, use it in a subsequent request to retrieve the next page of results.</para>
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
        /// <para>The endpoint services.</para>
        /// </summary>
        [NameInMap("Services")]
        [Validation(Required=false)]
        public List<ListVpcEndpointServicesByEndUserResponseBodyServices> Services { get; set; }
        public class ListVpcEndpointServicesByEndUserResponseBodyServices : TeaModel {
            /// <summary>
            /// <para>The IP version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>IPv4</b>: The service supports IPv4.</para>
            /// </description></item>
            /// <item><description><para><b>DualStack</b>: The service supports both IPv4 and IPv6 (dual stack).</para>
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
            /// <para>Specifies whether connection requests are automatically accepted. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Connection requests are automatically accepted.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Connection requests must be manually accepted.</para>
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
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmy*****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

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
            /// <para>The service resource type.</para>
            /// <list type="bullet">
            /// <item><description><para><b>slb</b>: A Classic Load Balancer (CLB) instance.</para>
            /// </description></item>
            /// <item><description><para><b>alb</b>: An Application Load Balancer (ALB) instance.</para>
            /// </description></item>
            /// <item><description><para><b>nlb</b>: A Network Load Balancer (NLB) instance.</para>
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
            /// <para>Specifies whether the endpoint service supports IPv6. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The endpoint service supports IPv6.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The endpoint service does not support IPv6.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ServiceSupportIPv6")]
            [Validation(Required=false)]
            public bool? ServiceSupportIPv6 { get; set; }

            /// <summary>
            /// <para>The type of the endpoint service.</para>
            /// <para>The value is always <b>Interface</b>. This indicates an interface endpoint where you can add service resources such as Application Load Balancer (ALB), Classic Load Balancer (CLB), and Network Load Balancer (NLB).</para>
            /// 
            /// <b>Example:</b>
            /// <para>Interface</para>
            /// </summary>
            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            /// <summary>
            /// <para>A list of tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListVpcEndpointServicesByEndUserResponseBodyServicesTags> Tags { get; set; }
            public class ListVpcEndpointServicesByEndUserResponseBodyServicesTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceDept</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceJoshua</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("VpcEndpointPolicySupported")]
            [Validation(Required=false)]
            public bool? VpcEndpointPolicySupported { get; set; }

            /// <summary>
            /// <para>Specifies whether zone affinity is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Zone affinity is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Zone affinity is disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ZoneAffinityEnabled")]
            [Validation(Required=false)]
            public bool? ZoneAffinityEnabled { get; set; }

            /// <summary>
            /// <para>The zones where the endpoint service is available.</para>
            /// </summary>
            [NameInMap("Zones")]
            [Validation(Required=false)]
            public List<string> Zones { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>29</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
