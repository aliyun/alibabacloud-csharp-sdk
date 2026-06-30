// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateTransitRouterVpcAttachmentRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the Enterprise Edition transit router to automatically advertise routes to the VPC.</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b> (default): Do not automatically advertise routes.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: Automatically advertise routes.</para>
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
        /// <para>The ID of the CEN instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-j3jzhw1zpau2km****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The billing method. The default value is <b>POSTPAY</b> (pay-as-you-go).</para>
        /// 
        /// <b>Example:</b>
        /// <para>POSTPAY</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The client token used to ensure request idempotency.</para>
        /// <para>You must generate a value on your client that is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the request ID as the client token, which is unique for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-001****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run to check the validity of the request without creating the resource. The check includes permissions and instance status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b> (default): Sends a normal request. The system creates the VPC connection if the request is valid.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: Sends only a check request. The system checks required parameters, request format, and permissions. The VPC connection is not created. If the check fails, an error is returned. If the check succeeds, the <c>DryRunOperation</c> error code is returned.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("Options")]
        [Validation(Required=false)]
        public CreateTransitRouterVpcAttachmentRequestOptions Options { get; set; }
        public class CreateTransitRouterVpcAttachmentRequestOptions : TeaModel {
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

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the VPC is located.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/132080.html">DescribeChildInstanceRegions</a> operation to query region IDs.</para>
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

        /// <summary>
        /// <para>The tags to add to the VPC connection.</para>
        /// <para>You can add up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateTransitRouterVpcAttachmentRequestTag> Tag { get; set; }
        public class CreateTransitRouterVpcAttachmentRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// <para>The tag key cannot be an empty string. The key can be up to 64 characters long and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tagtest</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// <para>The tag value can be an empty string or a string up to 128 characters long. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tagtest</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The description of the VPC connection.</para>
        /// <para>The description can be empty or 1 to 256 characters long, and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testname</para>
        /// </summary>
        [NameInMap("TransitRouterAttachmentDescription")]
        [Validation(Required=false)]
        public string TransitRouterAttachmentDescription { get; set; }

        /// <summary>
        /// <para>The name of the VPC connection.</para>
        /// <para>The name can be empty or 1 to 128 characters long, and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testname</para>
        /// </summary>
        [NameInMap("TransitRouterAttachmentName")]
        [Validation(Required=false)]
        public string TransitRouterAttachmentName { get; set; }

        /// <summary>
        /// <para>The ID of the Enterprise Edition transit router.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-bp1su1ytdxtataupl****</para>
        /// </summary>
        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

        /// <summary>
        /// <para>The properties of the VPC connection. This parameter is deprecated. We recommend that you use the <c>Options</c> parameter instead.</para>
        /// </summary>
        [NameInMap("TransitRouterVPCAttachmentOptions")]
        [Validation(Required=false)]
        public Dictionary<string, string> TransitRouterVPCAttachmentOptions { get; set; }

        /// <summary>
        /// <para>The ID of the VPC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1kbjcre9vtsebo1****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account that owns the VPC. By default, this is the ID of the current Alibaba Cloud account.</para>
        /// <remarks>
        /// <para>This parameter is required if you want to attach a cross-account network instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1250123456123456</para>
        /// </summary>
        [NameInMap("VpcOwnerId")]
        [Validation(Required=false)]
        public long? VpcOwnerId { get; set; }

        /// <summary>
        /// <para>The zone mappings for the VPC connection. For each mapping, you must specify a vSwitch in a zone that is supported by the Enterprise Edition transit router.</para>
        /// <para>You can specify up to 10 zone mappings.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ZoneMappings")]
        [Validation(Required=false)]
        public List<CreateTransitRouterVpcAttachmentRequestZoneMappings> ZoneMappings { get; set; }
        public class CreateTransitRouterVpcAttachmentRequestZoneMappings : TeaModel {
            /// <summary>
            /// <para>The ID of the vSwitch.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1a214sbus8z3b54****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The ID of the zone. The zone must be supported by the Enterprise Edition transit router.</para>
            /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36064.html">DescribeZones</a> operation to query available zones.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-h</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
