// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class GetVpcGatewayEndpointAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the gateway endpoint was created. The time is displayed in UTC in the YYYY-MM-DDThh:mm:ssZ format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-08-27T01:58:37Z</para>
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// <para>The description of the gateway endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("EndpointDescription")]
        [Validation(Required=false)]
        public string EndpointDescription { get; set; }

        /// <summary>
        /// <para>The endpoint instance ID of the gateway endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpce-bp1w1dmdqjpwul0v3****</para>
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
        /// <item><description><para><b>Creating</b>: being created.</para>
        /// </description></item>
        /// <item><description><para><b>Created</b>: created and in a normal state.</para>
        /// </description></item>
        /// <item><description><para><b>Modifying</b>: being modified.</para>
        /// </description></item>
        /// <item><description><para><b>Associating</b>: being associated.</para>
        /// </description></item>
        /// <item><description><para><b>Dissociating</b>: being disassociated.</para>
        /// </description></item>
        /// <item><description><para><b>Deleting</b>: being deleted.</para>
        /// </description></item>
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
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Version&quot; : &quot;1&quot;,   &quot;Statement&quot; : [ {     &quot;Effect&quot; : &quot;Allow&quot;,     &quot;Resource&quot; : [ &quot;<em>&quot; ],     &quot;Action&quot; : [ &quot;</em>&quot; ],     &quot;Principal&quot; : [ &quot;*&quot; ]   } ] }</para>
        /// </summary>
        [NameInMap("PolicyDocument")]
        [Validation(Required=false)]
        public string PolicyDocument { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A1122D0F-7B3B-5445-BB19-17F27F97FE1C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
        /// <para>The IDs of the route tables associated with the gateway endpoint.</para>
        /// </summary>
        [NameInMap("RouteTables")]
        [Validation(Required=false)]
        public List<string> RouteTables { get; set; }

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
        public List<GetVpcGatewayEndpointAttributeResponseBodyTags> Tags { get; set; }
        public class GetVpcGatewayEndpointAttributeResponseBodyTags : TeaModel {
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
        /// <para>vpc-bp1nh86rugg01zol0****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
