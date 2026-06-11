// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class ListVpcEndpointConnectionsRequest : TeaModel {
        /// <summary>
        /// <para>The state of the endpoint connection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Pending</b>: The endpoint connection is being modified.</para>
        /// </description></item>
        /// <item><description><para><b>Connecting</b>: The endpoint connection is being established.</para>
        /// </description></item>
        /// <item><description><para><b>Connected</b>: The endpoint is connected to the endpoint service.</para>
        /// </description></item>
        /// <item><description><para><b>Disconnecting</b>: The endpoint is being disconnected from the endpoint service.</para>
        /// </description></item>
        /// <item><description><para><b>Disconnected</b>: The endpoint is disconnected from the endpoint service.</para>
        /// </description></item>
        /// <item><description><para><b>Deleting</b>: The endpoint connection is being deleted.</para>
        /// </description></item>
        /// <item><description><para><b>ServiceDeleted</b>: The corresponding endpoint service is deleted.</para>
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
        /// <para>The endpoint ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ep-hp33b2e43fays7s8****</para>
        /// </summary>
        [NameInMap("EndpointId")]
        [Validation(Required=false)]
        public string EndpointId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the endpoint belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25346073170691****</para>
        /// </summary>
        [NameInMap("EndpointOwnerId")]
        [Validation(Required=false)]
        public long? EndpointOwnerId { get; set; }

        /// <summary>
        /// <para>The endpoint elastic network interface (ENI) ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eni-hp32lk0pyv6o94hs****</para>
        /// </summary>
        [NameInMap("EniId")]
        [Validation(Required=false)]
        public string EniId { get; set; }

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
        /// <para>The token that is used for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>You do not need to specify this parameter for the first query or if no next query is to be sent.</description></item>
        /// <item><description>If a next query is to be sent, set the value to the value of <b>NextToken</b> that is returned from the last API call.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID of the endpoint connections that you want to query.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/120468.html">DescribeRegions</a> operation to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-huhehaote</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the service resource that is replaced in the smooth migration scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-hp32z1wp5peaoox2q****</para>
        /// </summary>
        [NameInMap("ReplacedResourceId")]
        [Validation(Required=false)]
        public string ReplacedResourceId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the endpoint belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmy*****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The service resource ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-hp32z1wp5peaoox2q****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The endpoint service ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epsrv-hp3vpx8yqxblby3i****</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

    }

}
