// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class ListVpcEndpointsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the endpoints.</para>
        /// </summary>
        [NameInMap("Endpoints")]
        [Validation(Required=false)]
        public List<ListVpcEndpointsResponseBodyEndpoints> Endpoints { get; set; }
        public class ListVpcEndpointsResponseBodyEndpoints : TeaModel {
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
            /// <para>The bandwidth of the endpoint connection. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public long? Bandwidth { get; set; }

            /// <summary>
            /// <para>The state of the endpoint connection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Pending</b>: The endpoint connection is being modified.</description></item>
            /// <item><description><b>Connecting</b>: The endpoint connection is being established.</description></item>
            /// <item><description><b>Connected</b>: The endpoint connection is established.</description></item>
            /// <item><description><b>Disconnecting</b>: The endpoint is being disconnected from the endpoint service.</description></item>
            /// <item><description><b>Disconnected</b>: The endpoint is disconnected from the endpoint service.</description></item>
            /// <item><description><b>Deleting</b>: The endpoint connection is being deleted.</description></item>
            /// <item><description><b>ServiceDeleted</b>: The corresponding service is deleted.</description></item>
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

            [NameInMap("CrossRegionBandwidth")]
            [Validation(Required=false)]
            public int? CrossRegionBandwidth { get; set; }

            /// <summary>
            /// <para>The service state of the endpoint. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Normal</b>: The endpoint runs as expected.</description></item>
            /// <item><description><b>FinancialLocked</b>: The endpoint is locked due to overdue payments.</description></item>
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
            /// <para>The state of the endpoint. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Creating</b>: The endpoint is being created.</description></item>
            /// <item><description><b>Active</b>: The endpoint is available.</description></item>
            /// <item><description><b>Pending</b>: The endpoint is being modified.</description></item>
            /// <item><description><b>Deleting</b>: The endpoint is being deleted.</description></item>
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
            /// <item><description><b>Interface</b>: interface endpoint</description></item>
            /// <item><description><b>Reverse</b>: reverse endpoint</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Interface</para>
            /// </summary>
            [NameInMap("EndpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

            /// <summary>
            /// <para>The Resource Access Management (RAM) policy. For more information about policy definitions, see <a href="https://help.aliyun.com/document_detail/93738.html">Policy elements</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\n  \&quot;Version\&quot;: \&quot;1\&quot;,\n  \&quot;Statement\&quot;: [\n    {\n      \&quot;Effect\&quot;: \&quot;Allow\&quot;,\n      \&quot;Action\&quot;: \&quot;<em>\&quot;,\n      \&quot;Principal\&quot;: \&quot;</em>\&quot;,\n      \&quot;Resource\&quot;: \&quot;*\&quot;\n    }\n  ]\n}</para>
            /// </summary>
            [NameInMap("PolicyDocument")]
            [Validation(Required=false)]
            public string PolicyDocument { get; set; }

            /// <summary>
            /// <para>The region ID of the endpoint.</para>
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
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ResourceOwner")]
            [Validation(Required=false)]
            public bool? ResourceOwner { get; set; }

            /// <summary>
            /// <para>The ID of the endpoint service that is associated with the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>epsrv-hp3vpx8yqxblby3i****</para>
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <para>The name of the endpoint service that is associated with the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>com.aliyuncs.privatelink.cn-huhehaote.epsrv-hp3xdsq46ael67lo****</para>
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            [NameInMap("ServiceRegionId")]
            [Validation(Required=false)]
            public string ServiceRegionId { get; set; }

            /// <summary>
            /// <para>The tags added to the resource.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListVpcEndpointsResponseBodyEndpointsTags> Tags { get; set; }
            public class ListVpcEndpointsResponseBodyEndpointsTags : TeaModel {
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
            /// <para>The ID of the virtual private cloud (VPC) to which the endpoint belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-hp356stwkxg3fn2xe****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>Indicates whether the domain name of the nearest endpoint that is associated with the endpoint service is resolved first. Valid values:</para>
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
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If this is your first request and no next requests are to be performed, you do not need to specify this parameter.</description></item>
        /// <item><description>If a next request is to be performed, set the parameter to the value of <b>NextToken</b> that is returned from the last call.</description></item>
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
