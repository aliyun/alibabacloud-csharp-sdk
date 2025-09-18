// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ExpressConnectRouter20230901.Models
{
    public class CreateExpressConnectRouterAssociationRequest : TeaModel {
        /// <summary>
        /// <para>The allowed route prefixes.</para>
        /// </summary>
        [NameInMap("AllowedPrefixes")]
        [Validation(Required=false)]
        public List<string> AllowedPrefixes { get; set; }

        /// <summary>
        /// <para>The route prefix mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>MatchMode</b>: After you distribute new route CIDR blocks to data centers, original specific routes that are distributed are withdrawn.</para>
        /// </description></item>
        /// <item><description><para><b>IncrementalMode</b>: After you distribute new route CIDR blocks to data centers, the original specific routes that fall in the CIDR blocks that you configure are withdrawn, and the original specific routes that do not fall in the CIDR blocks are still distributed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MatchMode</para>
        /// </summary>
        [NameInMap("AllowedPrefixesMode")]
        [Validation(Required=false)]
        public string AllowedPrefixesMode { get; set; }

        /// <summary>
        /// <para>The region ID of the resource to be associated.</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>cen-of3o1the3i4gwb****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-00****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to initiate an association on the TR when the ECR is associated with the TR. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: You do not need to initiate an association on the TR.</description></item>
        /// <item><description><b>false</b>: You need to initiate an association on the TR.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CreateAttachment")]
        [Validation(Required=false)]
        public bool? CreateAttachment { get; set; }

        /// <summary>
        /// <para>The information about the associated resource. It must be 0 to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs only a dry run.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and performs the actual request.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ECR ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecr-mezk2idmsd0vx2****</para>
        /// </summary>
        [NameInMap("EcrId")]
        [Validation(Required=false)]
        public string EcrId { get; set; }

        /// <summary>
        /// <para>The TR ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-2ze4i71c6be454e2l****</para>
        /// </summary>
        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account that owns the TR. Default value: ID of the Alibaba Cloud account that logs in.</para>
        /// <remarks>
        /// <para> If you want to connect to a network instance that belongs to a different account, this parameter is required.</para>
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
        /// <para>The VPC ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1h37fchc6jmfyln****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account that owns the VPC. Default value: ID of the Alibaba Cloud account that logs in.</para>
        /// <remarks>
        /// <para> If you want to connect to a network instance that belongs to a different account, this parameter is required.</para>
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
