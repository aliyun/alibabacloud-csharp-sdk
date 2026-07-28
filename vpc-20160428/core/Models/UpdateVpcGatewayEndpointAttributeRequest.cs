// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class UpdateVpcGatewayEndpointAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may differ for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe637760</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: performs a dry run without updating the gateway endpoint configuration. The system checks the AccessKey pair, the authorization of the Resource Access Management (RAM) user, and the required parameters. If the check fails, the corresponding error is returned. If the check succeeds, the <c>DryRunOperation</c> error code is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): sends a Normal request. If the check succeeds, a 2xx HTTP status code is returned and the gateway endpoint configuration is updated.</para>
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
        /// <para>The new description of the gateway endpoint.</para>
        /// <para>The description must be 1 to 255 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>updateendpoint</para>
        /// </summary>
        [NameInMap("EndpointDescription")]
        [Validation(Required=false)]
        public string EndpointDescription { get; set; }

        /// <summary>
        /// <para>The instance ID of the gateway endpoint whose configuration you want to update.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpce-bp1w1dmdqjpwul0v3****</para>
        /// </summary>
        [NameInMap("EndpointId")]
        [Validation(Required=false)]
        public string EndpointId { get; set; }

        /// <summary>
        /// <para>The new name of the gateway endpoint.</para>
        /// <para>The name must be 1 to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>update</para>
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
        /// <para>For more information about the syntax and structure of access policies, see <a href="https://help.aliyun.com/document_detail/93739.html">Policy syntax and structure</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{   &quot;Version&quot; : &quot;1&quot;,   &quot;Statement&quot; : [ {     &quot;Effect&quot; : &quot;Allow&quot;,     &quot;Resource&quot; : [ &quot;<em>&quot; ],     &quot;Action&quot; : [ &quot;</em>&quot; ],     &quot;Principal&quot; : [ &quot;*&quot; ]   } ] }</para>
        /// </summary>
        [NameInMap("PolicyDocument")]
        [Validation(Required=false)]
        public string PolicyDocument { get; set; }

        /// <summary>
        /// <para>The region ID of the gateway endpoint whose configuration you want to update.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
