// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateVpcGatewayEndpointRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF3898</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: performs a dry run without creating the gateway endpoint. The system checks the required parameters, request syntax, and limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned. The check items include whether the AccessKey pair is valid, whether the Resource Access Management (RAM) user has the required authorization, and whether the required parameters are specified.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): sends a Normal request. If the request passes the dry run, a 2xx HTTP status code is returned and the gateway endpoint is created.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The description of the gateway endpoint.</para>
        /// <para>The description must be 1 to 255 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("EndpointDescription")]
        [Validation(Required=false)]
        public string EndpointDescription { get; set; }

        /// <summary>
        /// <para>The name of the gateway endpoint.</para>
        /// <para>The name must be 1 to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("EndpointName")]
        [Validation(Required=false)]
        public string EndpointName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The access policy for the cloud service.</para>
        /// <para>For more information about the syntax and structure of access policies, see <a href="https://help.aliyun.com/document_detail/93739.html">Policy structure and syntax</a>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required if the selected endpoint service supports access policies.</description></item>
        /// <item><description>This parameter must be empty if the selected endpoint service does not support access policies.</description></item>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/448920.html">ListVpcEndpointServicesByEndUser</a> operation to check whether an endpoint service supports access policies. A value of true for SupportPolicy indicates that access policies are supported.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{   &quot;Version&quot; : &quot;1&quot;,   &quot;Statement&quot; : [ {     &quot;Effect&quot; : &quot;Allow&quot;,     &quot;Resource&quot; : [ &quot;<em>&quot; ],     &quot;Action&quot; : [ &quot;</em>&quot; ],     &quot;Principal&quot; : [ &quot;*&quot; ]   } ] }</para>
        /// </summary>
        [NameInMap("PolicyDocument")]
        [Validation(Required=false)]
        public string PolicyDocument { get; set; }

        /// <summary>
        /// <para>The region ID of the gateway endpoint that you want to create.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the gateway endpoint belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4ph****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The service name of the endpoint service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>com.aliyun.cn-hangzhou.oss</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>The tags of the resource.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateVpcGatewayEndpointRequestTag> Tag { get; set; }
        public class CreateVpcGatewayEndpointRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource. You can specify up to 20 tag keys. The tag key cannot be an empty string.</para>
            /// <para>The tag key can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource. You can specify up to 20 tag values. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the VPC for which you want to create the gateway endpoint.</para>
        /// <para>The VPC must be in the same region as the gateway endpoint.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1gsk7h12ew7oegk****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
