// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateTransitRouterVpcAttachmentRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the Enterprise Edition transit router automatically publishes route entries to the VPC instance.</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): does not automatically publish route entries.</description></item>
        /// <item><description><b>true</b>: automatically publishes route entries.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPublishRouteEnabled")]
        [Validation(Required=false)]
        public bool? AutoPublishRouteEnabled { get; set; }

        /// <summary>
        /// <para>The instance ID of the Cloud Enterprise Network (CEN).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-j3jzhw1zpau2km****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The billing method. Default value: <b>POSTPAY</b>, which indicates the pay-as-you-go billing method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>POSTPAY</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>Generate a unique value from your client for this parameter. ClientToken supports only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system uses the RequestId of the API request as the ClientToken. The RequestId of each API request is different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-001****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run on the request, including permission checks and instance status validation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): sends a normal request and creates a VPC after the check passes. Use this value to create a VPC.</description></item>
        /// <item><description><b>true</b>: sends a dry run request for validation only without creating the VPC attachment. The check includes whether required parameters are specified and whether the request format is valid. If the check fails, the corresponding error is returned. If the check passes, the error code <c>DryRunOperation</c> is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The collection of feature attributes.</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public CreateTransitRouterVpcAttachmentRequestOptions Options { get; set; }
        public class CreateTransitRouterVpcAttachmentRequestOptions : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable the network appliance traffic redirection mode.</para>
            /// <list type="bullet">
            /// <item><description><b>disable</b> (default): disabled.</description></item>
            /// <item><description><b>enable</b>: enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enable</para>
            /// </summary>
            [NameInMap("ApplianceModeSupport")]
            [Validation(Required=false)]
            public string ApplianceModeSupport { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable IPv6 support.</para>
            /// <list type="bullet">
            /// <item><description><b>disable</b> (default): disabled.</description></item>
            /// <item><description><b>enable</b>: enabled.</description></item>
            /// </list>
            /// 
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
        /// <para>The ID of the region where the VPC instance is deployed.</para>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/132080.html">DescribeChildInstanceRegions</a> to query region IDs.</para>
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
        /// <para>The list of tags.</para>
        /// <para>You can specify up to 20 tags at a time.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateTransitRouterVpcAttachmentRequestTag> Tag { get; set; }
        public class CreateTransitRouterVpcAttachmentRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource.</para>
            /// <para>If this parameter is specified, it cannot be an empty string. The tag key can be up to 64 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>You can specify up to 20 tag keys at a time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tagtest</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource.</para>
            /// <para>If this parameter is specified, it cannot be empty. The tag value can be up to 128 characters in length and cannot start with aliyun or acs:. It cannot contain http:// or https://.</para>
            /// <para>Each tag key corresponds to one tag value. You can specify up to 20 tag key-value pairs at a time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tagtest</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The description of the VPC attachment.</para>
        /// <para>The description can be left empty or can contain 1 to 256 characters. It cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testname</para>
        /// </summary>
        [NameInMap("TransitRouterAttachmentDescription")]
        [Validation(Required=false)]
        public string TransitRouterAttachmentDescription { get; set; }

        /// <summary>
        /// <para>The name of the VPC attachment.</para>
        /// <para>The name can be left empty or can contain 1 to 128 characters. It cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testname</para>
        /// </summary>
        [NameInMap("TransitRouterAttachmentName")]
        [Validation(Required=false)]
        public string TransitRouterAttachmentName { get; set; }

        /// <summary>
        /// <para>The instance ID of the Enterprise Edition transit router.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-bp1su1ytdxtataupl****</para>
        /// </summary>
        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

        /// <summary>
        /// <para>The list of feature attributes for the VPC attachment (to be deprecated — use the new Options parameter instead).</para>
        /// </summary>
        [NameInMap("TransitRouterVPCAttachmentOptions")]
        [Validation(Required=false)]
        public Dictionary<string, string> TransitRouterVPCAttachmentOptions { get; set; }

        /// <summary>
        /// <para>The instance ID of the VPC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1kbjcre9vtsebo1****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the VPC instance belongs. The default value is the ID of the current logon Alibaba Cloud account.</para>
        /// <remarks>
        /// <para>This parameter is required if you want to attach a network instance that belongs to a different account.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1250123456123456</para>
        /// </summary>
        [NameInMap("VpcOwnerId")]
        [Validation(Required=false)]
        public long? VpcOwnerId { get; set; }

        /// <summary>
        /// <para>Select a vSwitch instance in a zone supported by the Enterprise Edition transit router.</para>
        /// <para>You can add up to 10 entries at a time.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ZoneMappings")]
        [Validation(Required=false)]
        public List<CreateTransitRouterVpcAttachmentRequestZoneMappings> ZoneMappings { get; set; }
        public class CreateTransitRouterVpcAttachmentRequestZoneMappings : TeaModel {
            /// <summary>
            /// <para>The vSwitch instance in a zone supported by the Enterprise Edition transit router.</para>
            /// <para>You can select vSwitch instances for up to 10 zones at a time.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1a214sbus8z3b54****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The ID of a zone supported by the Enterprise Edition transit router.</para>
            /// <para>You can call <a href="https://help.aliyun.com/document_detail/36064.html">DescribeZones</a> to query zone IDs.</para>
            /// <para>You can select up to 10 zones at a time.</para>
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
