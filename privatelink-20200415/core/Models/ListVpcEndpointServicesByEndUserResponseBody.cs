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
        /// <para>The information about endpoint services.</para>
        /// </summary>
        [NameInMap("Services")]
        [Validation(Required=false)]
        public List<ListVpcEndpointServicesByEndUserResponseBodyServices> Services { get; set; }
        public class ListVpcEndpointServicesByEndUserResponseBodyServices : TeaModel {
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

            [NameInMap("AutoAcceptEnabled")]
            [Validation(Required=false)]
            public bool? AutoAcceptEnabled { get; set; }

            /// <summary>
            /// <para>The payer. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Endpoint</b>: the service consumer</description></item>
            /// <item><description><b>EndpointService</b>: the service provider</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Endpoint</para>
            /// </summary>
            [NameInMap("Payer")]
            [Validation(Required=false)]
            public string Payer { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmy*****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The domain name of the endpoint service that can be associated with the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>epsrv-hp3vpx8yqxblby3i****.cn-huhehaote.privatelink.aliyuncs.com</para>
            /// </summary>
            [NameInMap("ServiceDomain")]
            [Validation(Required=false)]
            public string ServiceDomain { get; set; }

            /// <summary>
            /// <para>The ID of the endpoint service that can be associated with the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>epsrv-hp3vpx8yqxblby3i****</para>
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <para>The name of the endpoint service that can be associated with the endpoint.</para>
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
            /// <para>Indicates whether IPv6 is enabled. Valid values:</para>
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
            public bool? ServiceSupportIPv6 { get; set; }

            /// <summary>
            /// <para>The type of the endpoint service.</para>
            /// <para>Only <b>Interface</b> is returned, which indicates an interface endpoint. You can specify <b>CLB</b> and <b>ALB</b> instances as service resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Interface</para>
            /// </summary>
            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            /// <summary>
            /// <para>The list of tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListVpcEndpointServicesByEndUserResponseBodyServicesTags> Tags { get; set; }
            public class ListVpcEndpointServicesByEndUserResponseBodyServicesTags : TeaModel {
                /// <summary>
                /// <para>The key of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceDept</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the tag.</para>
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

            [NameInMap("ZoneAffinityEnabled")]
            [Validation(Required=false)]
            public bool? ZoneAffinityEnabled { get; set; }

            /// <summary>
            /// <para>The zones of the endpoint service that can be associated with the endpoint.</para>
            /// </summary>
            [NameInMap("Zones")]
            [Validation(Required=false)]
            public List<string> Zones { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>29</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
