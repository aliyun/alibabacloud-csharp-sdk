// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ExpressConnectRouter20230901.Models
{
    public class CreateExpressConnectRouterAssociationRequest : TeaModel {
        /// <summary>
        /// <para>The list of allowed route prefixes.</para>
        /// </summary>
        [NameInMap("AllowedPrefixes")]
        [Validation(Required=false)]
        public List<string> AllowedPrefixes { get; set; }

        /// <summary>
        /// <para>The route prefix mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MatchMode: match mode. Only the configured route CIDR blocks are advertised to the data center, and the previously advertised specific routes are withdrawn.</description></item>
        /// <item><description>IncrementalMode: incremental mode. The configured route CIDR blocks are advertised to the data center. The previously advertised specific routes that fall within the configured route CIDR blocks are withdrawn, and the specific routes that do not fall within the configured CIDR blocks remain advertised.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MatchMode</para>
        /// </summary>
        [NameInMap("AllowedPrefixesMode")]
        [Validation(Required=false)]
        public string AllowedPrefixesMode { get; set; }

        /// <summary>
        /// <para>The region where the associated resource resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("AssociationRegionId")]
        [Validation(Required=false)]
        public string AssociationRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the Cloud Enterprise Network (CEN) instance.</para>
        /// <remarks>
        /// <para>If you specify TransitRouterId, CenId is required. You must first call the CreateCen operation of the Cbn (2017-09-12) service to create a CEN instance and obtain the CEN instance ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cen-of3o1the3i4gwb****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can generate a parameter value from your client to ensure that the value is unique among different requests. The client token only supports ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request is unique.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-00****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to initiate an association when the Express Connect Router is associated with the transit router. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: No association is initiated on the transit router side.</description></item>
        /// <item><description><b>false</b>: An association is initiated on the transit router side.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CreateAttachment")]
        [Validation(Required=false)]
        public bool? CreateAttachment { get; set; }

        /// <summary>
        /// <para>The description of the associated resource. The description must be 0 to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to only perform a dry run for this request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The system sends a check request without modifying service resources.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): The system sends a normal request.</para>
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
        /// <para>The instance ID of the Express Connect Router (ECR).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecr-mezk2idmsd0vx2****</para>
        /// </summary>
        [NameInMap("EcrId")]
        [Validation(Required=false)]
        public string EcrId { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// <para>You can add up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateExpressConnectRouterAssociationRequestTag> Tag { get; set; }
        public class CreateExpressConnectRouterAssociationRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource. If you specify this parameter, it cannot be an empty string. The tag key can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource. The tag value can be an empty string and can be up to 128 characters in length. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the transit router.</para>
        /// <remarks>
        /// <para>The TransitRouterId and VpcId parameters are mutually exclusive. You must specify one of them. You must first call the CreateTransitRouter operation of the Cbn (2017-09-12) service to create a transit router and obtain the transit router ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>tr-2ze4i71c6be454e2l****</para>
        /// </summary>
        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the transit router instance belongs. The transit router is used to forward routing traffic. Default value: the current logon Alibaba Cloud account ID.</para>
        /// <remarks>
        /// <para>If you want to load a network instance across accounts, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>189159362009****</para>
        /// </summary>
        [NameInMap("TransitRouterOwnerId")]
        [Validation(Required=false)]
        public long? TransitRouterOwnerId { get; set; }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// <para>The instance ID of the VPC-connected instance.</para>
        /// <remarks>
        /// <para>The VpcId and TransitRouterId parameters are mutually exclusive. You must specify one of them.
        /// You must first call the CreateVpc operation of the Vpc (2016-04-28) service to create a VPC and obtain the VPC ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1h37fchc6jmfyln****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID to which the VPC-connected instance belongs. Default value: the current logon Alibaba Cloud account ID.</para>
        /// <remarks>
        /// <para>If you want to load a network instance across accounts, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>132193271328****</para>
        /// </summary>
        [NameInMap("VpcOwnerId")]
        [Validation(Required=false)]
        public long? VpcOwnerId { get; set; }

    }

}
