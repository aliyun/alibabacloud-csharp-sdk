// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListVpcGatewayEndpointsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of gateway endpoints.</para>
        /// </summary>
        [NameInMap("Endpoints")]
        [Validation(Required=false)]
        public List<ListVpcGatewayEndpointsResponseBodyEndpoints> Endpoints { get; set; }
        public class ListVpcGatewayEndpointsResponseBodyEndpoints : TeaModel {
            /// <summary>
            /// <para>The IDs of the route tables associated with the gateway endpoint.</para>
            /// </summary>
            [NameInMap("AssociatedRouteTables")]
            [Validation(Required=false)]
            public List<string> AssociatedRouteTables { get; set; }

            /// <summary>
            /// <para>The time when the gateway endpoint was created. The time is displayed in UTC in the YYYY-MM-DDThh:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-09-08T08:43:04Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The description of the gateway endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_description</para>
            /// </summary>
            [NameInMap("EndpointDescription")]
            [Validation(Required=false)]
            public string EndpointDescription { get; set; }

            /// <summary>
            /// <para>The endpoint instance ID of the gateway endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpce-bp1i1212ss2whuwyw****</para>
            /// </summary>
            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            /// <summary>
            /// <para>The name of the gateway endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("EndpointName")]
            [Validation(Required=false)]
            public string EndpointName { get; set; }

            /// <summary>
            /// <para>The status of the gateway endpoint. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Creating</b>: being created.</description></item>
            /// <item><description><b>Created</b>: created and in a normal state.</description></item>
            /// <item><description><b>Modifying</b>: being modified.</description></item>
            /// <item><description><b>Associating</b>: being associated.</description></item>
            /// <item><description><b>Dissociating</b>: being disassociated.</description></item>
            /// <item><description><b>Deleting</b>: being deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Created</para>
            /// </summary>
            [NameInMap("EndpointStatus")]
            [Validation(Required=false)]
            public string EndpointStatus { get; set; }

            /// <summary>
            /// <para>The access policy for the cloud service.</para>
            /// <para>For more information about the syntax and structure of access policies, see <a href="https://help.aliyun.com/document_detail/93739.html">Policy structure and syntax</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\n  \&quot;Version\&quot;: \&quot;1\&quot;,\n  \&quot;Statement\&quot;: [\n    {\n      \&quot;Effect\&quot;: \&quot;Allow\&quot;,\n      \&quot;Action\&quot;: \&quot;<em>\&quot;,\n      \&quot;Principal\&quot;: \&quot;</em>\&quot;,\n      \&quot;Resource\&quot;: \&quot;*\&quot;\n    }\n  ]\n}</para>
            /// </summary>
            [NameInMap("PolicyDocument")]
            [Validation(Required=false)]
            public string PolicyDocument { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the gateway endpoint belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmxvfvazb4p****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The service name of the endpoint service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>com.aliyun.cn-hangzhou.oss</para>
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// <para>The list of tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListVpcGatewayEndpointsResponseBodyEndpointsTags> Tags { get; set; }
            public class ListVpcGatewayEndpointsResponseBodyEndpointsTags : TeaModel {
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
            /// <para>The ID of the VPC to which the gateway endpoint belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1gsk7h12ew7oegk****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page for a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>Indicates whether a next query token is available. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no more results are available.</description></item>
        /// <item><description>If <b>NextToken</b> is returned, the value indicates the token for the next query.</description></item>
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
        /// <para>0AB1129F-32C1-5E4D-9E22-E4A859CA46EB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
