// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class UpdateTransitRouterVpcAttachmentAttributeRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to allow the Enterprise Edition transit router to automatically advertise routes to the VPC.</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b>: The transit router does not automatically advertise routes.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: The transit router automatically advertises routes.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPublishRouteEnabled")]
        [Validation(Required=false)]
        public bool? AutoPublishRouteEnabled { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can generate the token from your client, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.</para>
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
        /// <para>Specifies whether to perform a dry run, which checks for issues such as permissions and instance status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b> (default): sends a normal request. After the request passes the check, the system modifies the name and description of the VPC connection.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: sends a check request. The system validates the request without modifying the VPC connection. If the check passes, the system returns the ID of the request. Otherwise, the system returns an error.</para>
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
        /// <para>The billing method.</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public UpdateTransitRouterVpcAttachmentAttributeRequestOptions Options { get; set; }
        public class UpdateTransitRouterVpcAttachmentAttributeRequestOptions : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>enable</para>
            /// </summary>
            [NameInMap("ApplianceModeSupport")]
            [Validation(Required=false)]
            public string ApplianceModeSupport { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>enable</para>
            /// </summary>
            [NameInMap("Ipv6Support")]
            [Validation(Required=false)]
            public string Ipv6Support { get; set; }

        }

        /// <summary>
        /// <para>The billing method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PayByCenOwner</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The new description of the VPC connection.</para>
        /// <para>The description can be empty or 1 to 256 characters in length, and cannot start with http\:// or https\://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testdesc</para>
        /// </summary>
        [NameInMap("TransitRouterAttachmentDescription")]
        [Validation(Required=false)]
        public string TransitRouterAttachmentDescription { get; set; }

        /// <summary>
        /// <para>The ID of the VPC connection.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-attach-nls9fzkfat8934****</para>
        /// </summary>
        [NameInMap("TransitRouterAttachmentId")]
        [Validation(Required=false)]
        public string TransitRouterAttachmentId { get; set; }

        /// <summary>
        /// <para>The new name of the VPC connection.</para>
        /// <para>The name can be empty or 1 to 128 characters in length, and cannot start with http\:// or https\://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testname</para>
        /// </summary>
        [NameInMap("TransitRouterAttachmentName")]
        [Validation(Required=false)]
        public string TransitRouterAttachmentName { get; set; }

        /// <summary>
        /// <para>The feature properties of the VPC connection. This parameter is deprecated. We recommend that you use the <c>Options</c> parameter.</para>
        /// </summary>
        [NameInMap("TransitRouterVPCAttachmentOptions")]
        [Validation(Required=false)]
        public Dictionary<string, string> TransitRouterVPCAttachmentOptions { get; set; }

    }

}
