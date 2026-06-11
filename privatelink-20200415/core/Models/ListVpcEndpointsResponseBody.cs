// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class ListVpcEndpointsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of endpoints.</para>
        /// </summary>
        [NameInMap("Endpoints")]
        [Validation(Required=false)]
        public List<ListVpcEndpointsResponseBodyEndpoints> Endpoints { get; set; }
        public class ListVpcEndpointsResponseBodyEndpoints : TeaModel {
            /// <summary>
            /// <para>The IP address family. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>IPv4</b>: IPv4.</para>
            /// </description></item>
            /// <item><description><para><b>DualStack</b>: dual stack.</para>
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
            /// <para>The connection bandwidth of the endpoint, in Mbps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public long? Bandwidth { get; set; }

            /// <summary>
            /// <para>The connection status of the endpoint. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Pending</b>: The connection is being modified.</para>
            /// </description></item>
            /// <item><description><para><b>Connecting</b>: The endpoint is being connected.</para>
            /// </description></item>
            /// <item><description><para><b>Connected</b>: The endpoint is connected.</para>
            /// </description></item>
            /// <item><description><para><b>Disconnecting</b>: The endpoint is being disconnected.</para>
            /// </description></item>
            /// <item><description><para><b>Disconnected</b>: The endpoint is disconnected.</para>
            /// </description></item>
            /// <item><description><para><b>Deleting</b>: The endpoint is being deleted.</para>
            /// </description></item>
            /// <item><description><para><b>ServiceDeleted</b>: The associated endpoint service has been deleted.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Disconnected</para>
            /// </summary>
            [NameInMap("ConnectionStatus")]
            [Validation(Required=false)]
            public string ConnectionStatus { get; set; }

            /// <summary>
            /// <para>The time when the endpoint was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-09-24T18:00:07Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The bandwidth of the cross-region connection, in Mbps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("CrossRegionBandwidth")]
            [Validation(Required=false)]
            public int? CrossRegionBandwidth { get; set; }

            /// <summary>
            /// <para>The business status of the endpoint. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Normal</b>: The endpoint is running as expected.</para>
            /// </description></item>
            /// <item><description><para><b>FinancialLocked</b>: The endpoint is locked due to an overdue payment.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("EndpointBusinessStatus")]
            [Validation(Required=false)]
            public string EndpointBusinessStatus { get; set; }

            /// <summary>
            /// <para>The description of the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is my Endpoint.</para>
            /// </summary>
            [NameInMap("EndpointDescription")]
            [Validation(Required=false)]
            public string EndpointDescription { get; set; }

            /// <summary>
            /// <para>The domain name of the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ep-hp33b2e43fays7s8****.epsrv-hp3xdsq46ael67lo****.cn-huhehaote.privatelink.aliyuncs.com</para>
            /// </summary>
            [NameInMap("EndpointDomain")]
            [Validation(Required=false)]
            public string EndpointDomain { get; set; }

            /// <summary>
            /// <para>The ID of the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ep-hp33b2e43fays7s8****</para>
            /// </summary>
            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            /// <summary>
            /// <para>The name of the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("EndpointName")]
            [Validation(Required=false)]
            public string EndpointName { get; set; }

            /// <summary>
            /// <para>The status of the endpoint. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Creating</b>: The endpoint is being created.</para>
            /// </description></item>
            /// <item><description><para><b>Active</b>: The endpoint is available.</para>
            /// </description></item>
            /// <item><description><para><b>Pending</b>: The endpoint is being modified.</para>
            /// </description></item>
            /// <item><description><para><b>Deleting</b>: The endpoint is being deleted.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("EndpointStatus")]
            [Validation(Required=false)]
            public string EndpointStatus { get; set; }

            /// <summary>
            /// <para>The type of the endpoint. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Interface</b>: an interface endpoint.</para>
            /// </description></item>
            /// <item><description><para><b>Reverse</b>: a reverse endpoint.</para>
            /// </description></item>
            /// <item><description><para><b>GatewayLoadBalancer</b>: a gateway load balancer endpoint.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Interface</para>
            /// </summary>
            [NameInMap("EndpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

            /// <summary>
            /// <para>The RAM access policy. For details on the policy syntax, see <a href="https://help.aliyun.com/document_detail/93738.html">Basic elements of a RAM policy</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\n  \&quot;Version\&quot;: \&quot;1\&quot;,\n  \&quot;Statement\&quot;: [\n    {\n      \&quot;Effect\&quot;: \&quot;Allow\&quot;,\n      \&quot;Action\&quot;: \&quot;<em>\&quot;,\n      \&quot;Principal\&quot;: \&quot;</em>\&quot;,\n      \&quot;Resource\&quot;: \&quot;*\&quot;\n    }\n  ]\n}</para>
            /// </summary>
            [NameInMap("PolicyDocument")]
            [Validation(Required=false)]
            public string PolicyDocument { get; set; }

            /// <summary>
            /// <para>The ID of the region that contains the endpoint.</para>
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
            /// <para>1</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>Indicates whether the endpoint and the endpoint service belong to the same Alibaba Cloud account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b></para>
            /// </description></item>
            /// <item><description><para><b>false</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ResourceOwner")]
            [Validation(Required=false)]
            public bool? ResourceOwner { get; set; }

            /// <summary>
            /// <para>The ID of the associated endpoint service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>epsrv-hp3vpx8yqxblby3i****</para>
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <para>The name of the associated endpoint service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>com.aliyuncs.privatelink.cn-huhehaote.epsrv-hp3xdsq46ael67lo****</para>
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// <para>The ID of the region where the associated endpoint service is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-huhehaote</para>
            /// </summary>
            [NameInMap("ServiceRegionId")]
            [Validation(Required=false)]
            public string ServiceRegionId { get; set; }

            /// <summary>
            /// <para>A list of tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListVpcEndpointsResponseBodyEndpointsTags> Tags { get; set; }
            public class ListVpcEndpointsResponseBodyEndpointsTags : TeaModel {
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

            /// <summary>
            /// <para>The ID of the VPC to which the endpoint belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-hp356stwkxg3fn2xe****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>Indicates whether zone-aware DNS resolution is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b></para>
            /// </description></item>
            /// <item><description><para><b>false</b></para>
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
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token to retrieve the next page of results.</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>NextToken</b> is empty, no next page exists.</para>
        /// </description></item>
        /// <item><description><para>If a value is returned, use it in your next request to retrieve the next page of results.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
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
        /// <para>The total number of entries that match the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
