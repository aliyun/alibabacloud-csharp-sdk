// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateTransitRouterShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Cloud Enterprise Network (CEN) instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-j3jzhw1zpau2km****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not set this parameter, the system automatically uses <b>RequestId</b> as <b>ClientToken</b>. The value of <b>RequestId</b> of each API request is different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-001****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to check the request without performing the operation. Check items include permissions and the status of the specified cloud resources. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): sends the request. If the request passes the check, an Enterprise Edition transit router is created.</description></item>
        /// <item><description><b>true</b>: checks the request but does not create the Enterprise Edition transit router. If you use this value, the system checks whether the required parameters are set, and whether the request syntax is valid. If the request fails the check, an error message is returned. If the request passes the check, the <c>DryRunOperation</c> error code is returned.</description></item>
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
        /// <item><description><b>false</b> (default): no</description></item>
        /// <item><description><b>true</b>: yes</description></item>
        /// </list>
        /// <para>The multicast feature is supported only in specific regions. You can call <a href="https://help.aliyun.com/document_detail/261356.html">ListTransitRouterAvailableResource</a> to query the regions that support multicast.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SupportMulticast")]
        [Validation(Required=false)]
        public bool? SupportMulticast { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateTransitRouterShrinkRequestTag> Tag { get; set; }
        public class CreateTransitRouterShrinkRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// <para>The tag keys cannot be an empty string. The tag key can be up to 64 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>You can specify at most 20 tag keys in each call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tagtest</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// <para>The tag value can be an empty string or up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>Each key-value must be unique. You can specify at most 20 tag values in each call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TagValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The CIDR blocks to be added to the transit router.</para>
        /// </summary>
        [NameInMap("TransitRouterCidrList")]
        [Validation(Required=false)]
        public string TransitRouterCidrListShrink { get; set; }

        /// <summary>
        /// <para>The description of the Enterprise Edition transit router instance.</para>
        /// <para>The description must be 1 to 256 characters in length, and cannot start with http:// or https://. You can also leave this parameter empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testdesc</para>
        /// </summary>
        [NameInMap("TransitRouterDescription")]
        [Validation(Required=false)]
        public string TransitRouterDescription { get; set; }

        /// <summary>
        /// <para>The name of the Enterprise Edition transit router.</para>
        /// <para>The name must be 1 to 128 characters in length, and cannot start with http:// or https://. You can also leave this parameter empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testname</para>
        /// </summary>
        [NameInMap("TransitRouterName")]
        [Validation(Required=false)]
        public string TransitRouterName { get; set; }

    }

}
