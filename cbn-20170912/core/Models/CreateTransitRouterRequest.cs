// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateTransitRouterRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the CEN instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-j3jzhw1zpau2km****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>Generate a client token to make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the request as the <b>ClientToken</b>. The <b>RequestId</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-001****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. The dry run checks permissions and whether the required parameters are specified. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b> (default): sends the request and creates the instance after the request passes the check.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: sends a dry run request to check the parameters without creating the instance. The system checks the required parameters, request format, and permissions. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the Enterprise Edition transit router is deployed.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/132080.html">DescribeChildInstanceRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-zhangjiakou</para>
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

        /// <summary>
        /// <para>Specifies whether to enable the multicast feature for the Enterprise Edition transit router. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b> (default): disables the multicast feature.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: enables the multicast feature.</para>
        /// </description></item>
        /// </list>
        /// <para>The multicast feature is supported only in some regions. You can call the <a href="https://help.aliyun.com/document_detail/261356.html">ListTransitRouterAvailableResource</a> operation to query the regions that support multicast.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SupportMulticast")]
        [Validation(Required=false)]
        public bool? SupportMulticast { get; set; }

        /// <summary>
        /// <para>The tag.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateTransitRouterRequestTag> Tag { get; set; }
        public class CreateTransitRouterRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// <para>The tag key cannot be an empty string. The tag key can be up to 64 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https:// </c>.</para>
            /// <para>You can specify at most 20 tag keys.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tagtest</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// <para>The tag value can be empty or a string of up to 128 characters. It cannot start with <c>aliyun</c> or <c>acs:</c> and cannot contain <c>http://</c> or <c>https:// </c>.</para>
            /// <para>Each tag key must have a unique tag value. You can specify at most 20 tag values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TagValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The CIDR blocks of the transit router.</para>
        /// </summary>
        [NameInMap("TransitRouterCidrList")]
        [Validation(Required=false)]
        public List<CreateTransitRouterRequestTransitRouterCidrList> TransitRouterCidrList { get; set; }
        public class CreateTransitRouterRequestTransitRouterCidrList : TeaModel {
            /// <summary>
            /// <para>The CIDR block of the transit router.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.10.0/24</para>
            /// </summary>
            [NameInMap("Cidr")]
            [Validation(Required=false)]
            public string Cidr { get; set; }

            /// <summary>
            /// <para>The description of the CIDR block.</para>
            /// <para>The description must be 1 to 256 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desctest</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the CIDR block.</para>
            /// <para>The name must be 1 to 128 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nametest</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Specifies whether to automatically advertise the route of the CIDR block to the route table of the transit router.</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b> (default): yes.</para>
            /// <para>If you select this option, after you create a VPN connection that uses a private gateway and create a route learning correlation for the VPN connection, the system automatically adds the following route to the route table of the transit router with which the VPN connection is associated:</para>
            /// <para>A blackhole route whose destination CIDR block is the CIDR block of the transit router. The CIDR block of the transit router refers to the CIDR block from which a gateway IP address is allocated to the IPsec connection.</para>
            /// <para>This blackhole route is advertised only to the route tables of virtual border router (VBR) instances that are connected to the transit router.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: no.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PublishCidrRoute")]
            [Validation(Required=false)]
            public bool? PublishCidrRoute { get; set; }

        }

        /// <summary>
        /// <para>The description of the Enterprise Edition transit router instance.</para>
        /// <para>The description can be empty or 1 to 256 characters in length, and cannot start with http\:// or https\://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testdesc</para>
        /// </summary>
        [NameInMap("TransitRouterDescription")]
        [Validation(Required=false)]
        public string TransitRouterDescription { get; set; }

        /// <summary>
        /// <para>The name of the Enterprise Edition transit router instance.</para>
        /// <para>The name can be empty or 1 to 128 characters in length, and cannot start with http\:// or https\://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testname</para>
        /// </summary>
        [NameInMap("TransitRouterName")]
        [Validation(Required=false)]
        public string TransitRouterName { get; set; }

    }

}
