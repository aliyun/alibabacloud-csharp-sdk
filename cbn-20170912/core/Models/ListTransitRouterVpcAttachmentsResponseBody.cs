// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterVpcAttachmentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token to retrieve the next page of results.</para>
        /// <list type="bullet">
        /// <item><description><para>If this parameter is empty, all results have been returned.</para>
        /// </description></item>
        /// <item><description><para>If a value is returned for <b>NextToken</b>, it is the token to start the next query.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C97FF53F-3EF8-4883-B459-60E171924B23</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>A list of VPC connections.</para>
        /// </summary>
        [NameInMap("TransitRouterAttachments")]
        [Validation(Required=false)]
        public List<ListTransitRouterVpcAttachmentsResponseBodyTransitRouterAttachments> TransitRouterAttachments { get; set; }
        public class ListTransitRouterVpcAttachmentsResponseBodyTransitRouterAttachments : TeaModel {
            /// <summary>
            /// <para>Specifies whether the Enterprise Edition transit router automatically advertises routes to the VPC.</para>
            /// <list type="bullet">
            /// <item><description><para><b>false</b>: Routes are not automatically advertised.</para>
            /// </description></item>
            /// <item><description><para><b>true</b>: Routes are automatically advertised.</para>
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
            /// <para>The billing method of the VPC connection.</para>
            /// <para>The value is always <b>POSTPAY</b>, which indicates the pay-as-you-go billing method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>POSTPAY</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The time when the VPC connection was created.</para>
            /// <para>The time is in the <c>YYYY-MM-DDThh:mmZ</c> format and in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06-15T02:14Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The cloud service to which the resource belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SAS</para>
            /// </summary>
            [NameInMap("ManagedService")]
            [Validation(Required=false)]
            public string ManagedService { get; set; }

            /// <summary>
            /// <para>A collection of feature attributes.</para>
            /// </summary>
            [NameInMap("Options")]
            [Validation(Required=false)]
            public ListTransitRouterVpcAttachmentsResponseBodyTransitRouterAttachmentsOptions Options { get; set; }
            public class ListTransitRouterVpcAttachmentsResponseBodyTransitRouterAttachmentsOptions : TeaModel {
                /// <summary>
                /// <para>Specifies whether appliance mode is enabled.</para>
                /// <list type="bullet">
                /// <item><description><para><b>disable</b> (default): Appliance mode is disabled.</para>
                /// </description></item>
                /// <item><description><para><b>enable</b>: Appliance mode is enabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>enable</para>
                /// </summary>
                [NameInMap("ApplianceModeSupport")]
                [Validation(Required=false)]
                public string ApplianceModeSupport { get; set; }

                /// <summary>
                /// <para>Specifies whether IPv6 is enabled.</para>
                /// <list type="bullet">
                /// <item><description><para><b>disable</b> (default): IPv6 is disabled.</para>
                /// </description></item>
                /// <item><description><para><b>enable</b>: IPv6 is enabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>enable</para>
                /// </summary>
                [NameInMap("Ipv6Support")]
                [Validation(Required=false)]
                public string Ipv6Support { get; set; }

            }

            /// <summary>
            /// <para>Specifies who pays for the network instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>PayByCenOwner</b>: The account that owns the CEN instance pays the fees.</para>
            /// </description></item>
            /// <item><description><para><b>PayByResourceOwner</b>: The account that owns the network instance pays the fees.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PayByCenOwner</para>
            /// </summary>
            [NameInMap("OrderType")]
            [Validation(Required=false)]
            public string OrderType { get; set; }

            /// <summary>
            /// <para>The type of resource to which the connection is attached.</para>
            /// <para>The value is always <b>VPC</b>, which indicates a VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VPC</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The status of the VPC connection.</para>
            /// <list type="bullet">
            /// <item><description><para><b>Attached</b>: The connection is established.</para>
            /// </description></item>
            /// <item><description><para><b>Attaching</b>: The connection is being created.</para>
            /// </description></item>
            /// <item><description><para><b>Detaching</b>: The connection is being deleted.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Attached</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>A list of tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListTransitRouterVpcAttachmentsResponseBodyTransitRouterAttachmentsTags> Tags { get; set; }
            public class ListTransitRouterVpcAttachmentsResponseBodyTransitRouterAttachmentsTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The description of the VPC connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testdesc</para>
            /// </summary>
            [NameInMap("TransitRouterAttachmentDescription")]
            [Validation(Required=false)]
            public string TransitRouterAttachmentDescription { get; set; }

            /// <summary>
            /// <para>The ID of the VPC connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-attach-nls9fzkfat8934****</para>
            /// </summary>
            [NameInMap("TransitRouterAttachmentId")]
            [Validation(Required=false)]
            public string TransitRouterAttachmentId { get; set; }

            /// <summary>
            /// <para>The name of the VPC connection.</para>
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
            /// <para>The feature attributes of the VPC connection. This parameter is deprecated. We recommend that you use the Options parameter instead.</para>
            /// </summary>
            [NameInMap("TransitRouterVPCAttachmentOptions")]
            [Validation(Required=false)]
            public Dictionary<string, string> TransitRouterVPCAttachmentOptions { get; set; }

            /// <summary>
            /// <para>The ID of the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1h8vbrbcgohcju5****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The ID of the account that owns the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1250123456123456</para>
            /// </summary>
            [NameInMap("VpcOwnerId")]
            [Validation(Required=false)]
            public long? VpcOwnerId { get; set; }

            /// <summary>
            /// <para>The ID of the region where the VPC is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("VpcRegionId")]
            [Validation(Required=false)]
            public string VpcRegionId { get; set; }

            /// <summary>
            /// <para>The zone mappings of the VPC connection. This includes the vSwitches and elastic network interfaces (ENIs) in the associated VPC.</para>
            /// </summary>
            [NameInMap("ZoneMappings")]
            [Validation(Required=false)]
            public List<ListTransitRouterVpcAttachmentsResponseBodyTransitRouterAttachmentsZoneMappings> ZoneMappings { get; set; }
            public class ListTransitRouterVpcAttachmentsResponseBodyTransitRouterAttachmentsZoneMappings : TeaModel {
                /// <summary>
                /// <para>The ID of the ENI that the Enterprise Edition transit router creates in the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eni-bp149hmyaqegerml****</para>
                /// </summary>
                [NameInMap("NetworkInterfaceId")]
                [Validation(Required=false)]
                public string NetworkInterfaceId { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp1a214sbus8z3b54****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The ID of the zone.</para>
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

}
