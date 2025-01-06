// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterVpcAttachmentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that determines the start point of the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is returned, it indicates that no additional results exist.</description></item>
        /// <item><description>If <b>NextToken</b> was returned in the previous query, specify the value to obtain the next set of results.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C97FF53F-3EF8-4883-B459-60E171924B23</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The information about the VPC connection.</para>
        /// </summary>
        [NameInMap("TransitRouterAttachments")]
        [Validation(Required=false)]
        public List<ListTransitRouterVpcAttachmentsResponseBodyTransitRouterAttachments> TransitRouterAttachments { get; set; }
        public class ListTransitRouterVpcAttachmentsResponseBodyTransitRouterAttachments : TeaModel {
            /// <summary>
            /// <para>Indicates whether the Enterprise Edition transit router can automatically advertise routes to the VPC. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>false</b></description></item>
            /// <item><description><b>true</b></description></item>
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
            /// <para>Only <b>POSTPAY</b> may be returned, which indicates the default pay-as-you-go billing method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>POSTPAY</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The time when the VPC connection was created.</para>
            /// <para>The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06-15T02:14Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The entity that pays the fees of the network instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PayByCenOwner</b>: the Alibaba Cloud account that owns the CEN instance.</description></item>
            /// <item><description><b>PayByResourceOwner</b>: the Alibaba Cloud account that owns the network instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PayByCenOwner</para>
            /// </summary>
            [NameInMap("OrderType")]
            [Validation(Required=false)]
            public string OrderType { get; set; }

            /// <summary>
            /// <para>The type of resource to which the transit router is connected.</para>
            /// <para>Only <b>VPC</b> may be returned, which indicates VPCs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VPC</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The status of the VPC connection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Attached</b></description></item>
            /// <item><description><b>Attaching</b></description></item>
            /// <item><description><b>Detaching</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Attached</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tags.</para>
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
            /// <para>The VPC connection ID.</para>
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
            /// <para>The description of the Enterprise Edition transit router.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-bp1su1ytdxtataupl****</para>
            /// </summary>
            [NameInMap("TransitRouterId")]
            [Validation(Required=false)]
            public string TransitRouterId { get; set; }

            /// <summary>
            /// <para>The features of the VPC connection.</para>
            /// </summary>
            [NameInMap("TransitRouterVPCAttachmentOptions")]
            [Validation(Required=false)]
            public Dictionary<string, string> TransitRouterVPCAttachmentOptions { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1h8vbrbcgohcju5****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the VPC belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1250123456123456</para>
            /// </summary>
            [NameInMap("VpcOwnerId")]
            [Validation(Required=false)]
            public long? VpcOwnerId { get; set; }

            /// <summary>
            /// <para>The region ID of the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("VpcRegionId")]
            [Validation(Required=false)]
            public string VpcRegionId { get; set; }

            /// <summary>
            /// <para>The primary and secondary zones, vSwitches, and ENIs of the VPC.</para>
            /// </summary>
            [NameInMap("ZoneMappings")]
            [Validation(Required=false)]
            public List<ListTransitRouterVpcAttachmentsResponseBodyTransitRouterAttachmentsZoneMappings> ZoneMappings { get; set; }
            public class ListTransitRouterVpcAttachmentsResponseBodyTransitRouterAttachmentsZoneMappings : TeaModel {
                /// <summary>
                /// <para>The ID of the ENI created by the Enterprise Edition transit router in the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eni-bp149hmyaqegerml****</para>
                /// </summary>
                [NameInMap("NetworkInterfaceId")]
                [Validation(Required=false)]
                public string NetworkInterfaceId { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp1a214sbus8z3b54****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The zone ID.</para>
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
