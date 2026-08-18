// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class ListVpcEndpointsRequest : TeaModel {
        /// <summary>
        /// <para>The protocol version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>IPv4</b>: IPv4.</description></item>
        /// <item><description><b>DualStack</b>: dual-stack.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("AddressIpVersion")]
        [Validation(Required=false)]
        public string AddressIpVersion { get; set; }

        /// <summary>
        /// <para>The endpoint connection status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Pending</b>: being modified.</para>
        /// </description></item>
        /// <item><description><para><b>Connecting</b>: connecting.</para>
        /// </description></item>
        /// <item><description><para><b>Connected</b>: connected.</para>
        /// </description></item>
        /// <item><description><para><b>Disconnecting</b>: disconnecting.</para>
        /// </description></item>
        /// <item><description><para><b>Disconnected</b>: disconnected.</para>
        /// </description></item>
        /// <item><description><para><b>Deleting</b>: being deleted.</para>
        /// </description></item>
        /// <item><description><para><b>ServiceDeleted</b>: the corresponding endpoint service has been deleted.</para>
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
        /// <para>The ID of the endpoint that you want to query.</para>
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
        /// <item><description><para><b>Creating</b>: being created.</para>
        /// </description></item>
        /// <item><description><para><b>Active</b>: available.</para>
        /// </description></item>
        /// <item><description><para><b>Pending</b>: being modified.</para>
        /// </description></item>
        /// <item><description><para><b>Deleting</b>: being deleted.</para>
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
        /// <para>The endpoint type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Interface</b>: interface endpoint.</para>
        /// </description></item>
        /// <item><description><para><b>Reverse</b>: reverse endpoint.</para>
        /// </description></item>
        /// <item><description><para><b>GatewayLoadBalancer</b>: Gateway Load Balancer endpoint (GWLBe). You can create a Gateway Load Balancer endpoint (GWLBe) to connect to a Gateway Load Balancer (GWLB) for load balancing.</para>
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
        /// <para>The number of entries per page. Valid values: <b>1</b> to <b>1000</b>. Default value: <b>50</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Specifies whether to have a token for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If this is the first query or there is no next query, you do not need to specify this parameter.</description></item>
        /// <item><description>If a next query exists, set the value to the <b>NextToken</b> value returned by the previous API call.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID of the endpoints that you want to query.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/120468.html">DescribeRegions</a> operation to obtain the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-huhehaote</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The service name of the endpoint service associated with the endpoint that you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>com.aliyuncs.privatelink.cn-huhehaote.epsrv-hp3vpx8yqxblby3i****</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>The region ID of the endpoint service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-huhehaote</para>
        /// </summary>
        [NameInMap("ServiceRegionId")]
        [Validation(Required=false)]
        public string ServiceRegionId { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListVpcEndpointsRequestTag> Tag { get; set; }
        public class ListVpcEndpointsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the instance. You can specify up to 20 tag keys. The tag key cannot be an empty string.</para>
            /// <para>The tag key can be up to 64 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the instance. You can specify up to 20 tag values. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC) to which the endpoint belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-fdjkf789dfdfdfde****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
