// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateTransitRouterPeerAttachmentRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the local Enterprise Edition transit router to automatically advertise the routes of the inter-region connection to the peer transit router. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b> (default): no.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: yes.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPublishRouteEnabled")]
        [Validation(Required=false)]
        public bool? AutoPublishRouteEnabled { get; set; }

        /// <summary>
        /// <para>The bandwidth value of the inter-region connection. Unit: Mbps.</para>
        /// <list type="bullet">
        /// <item><description><para>When <b>BandwidthType</b> is set to <b>BandwidthPackage</b>, this parameter specifies the bandwidth value that the inter-region connection can use.</para>
        /// </description></item>
        /// <item><description><para>When <b>BandwidthType</b> is set to <b>DataTransfer</b>, this parameter specifies the maximum bandwidth value of the inter-region connection.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The method that is used to allocate bandwidth to the inter-region connection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>BandwidthPackage</b>: allocates bandwidth from a bandwidth plan.</para>
        /// </description></item>
        /// <item><description><para><b>DataTransfer</b>: does not allocate bandwidth to the inter-region connection and charges based on pay-by-traffic.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BandwidthPackage</para>
        /// </summary>
        [NameInMap("BandwidthType")]
        [Validation(Required=false)]
        public string BandwidthType { get; set; }

        /// <summary>
        /// <para>The ID of the bandwidth plan that you want to associate with the inter-region connection.</para>
        /// <remarks>
        /// <para>You do not need to configure this parameter when <b>BandwidthType</b> is set to <b>DataTransfer</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cenbwp-3xrxupouolw5ou****</para>
        /// </summary>
        [NameInMap("CenBandwidthPackageId")]
        [Validation(Required=false)]
        public string CenBandwidthPackageId { get; set; }

        /// <summary>
        /// <para>The ID of the Cloud Enterprise Network (CEN) instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-j3jzhw1zpau2km****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The client token used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> as the <b>ClientToken</b>. The <b>RequestId</b> is different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-001****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The default line type.</para>
        /// <para>Valid values: Platinum and Gold. Default value: Gold.</para>
        /// <para>You can set this parameter to Platinum only when the bandwidth allocation method is pay-by-traffic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Gold</para>
        /// </summary>
        [NameInMap("DefaultLinkType")]
        [Validation(Required=false)]
        public string DefaultLinkType { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run to check information such as the permissions and instance status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b> (default): sends a normal request. After the request passes the check, the system creates an inter-region connection.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: sends a check request. The system checks the required parameters and request syntax. If the request fails the dry run, an error message is returned. If the request passes the dry run, a request ID is returned.</para>
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
        /// <para>The ID of the peer transit router instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-m5eq27g6bndum7e88****</para>
        /// </summary>
        [NameInMap("PeerTransitRouterId")]
        [Validation(Required=false)]
        public string PeerTransitRouterId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the peer transit router instance is deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-qingdao</para>
        /// </summary>
        [NameInMap("PeerTransitRouterRegionId")]
        [Validation(Required=false)]
        public string PeerTransitRouterRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the local Enterprise Edition transit router instance is deployed.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query region IDs.</para>
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
        /// <para>The tag information.</para>
        /// <para>You can specify at most 20 tags in each call.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateTransitRouterPeerAttachmentRequestTag> Tag { get; set; }
        public class CreateTransitRouterPeerAttachmentRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag that you want to attach.</para>
            /// <para>You cannot specify an empty string as a tag key. The tag key can be up to 64 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https:// </c>.</para>
            /// <para>You can specify at most 20 tag keys in each call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag_A1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag that you want to attach to the specified resource.</para>
            /// <para>The tag value can be an empty string or a string of up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https:// </c>.</para>
            /// <para>Each key-value pair must be unique. You can specify at most 20 tag values in each call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value_A1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The description of the inter-region connection.</para>
        /// <para>The description is optional. If you enter a description, it must be 1 to 256 characters in length, and cannot start with http\:// or https\://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testdesc</para>
        /// </summary>
        [NameInMap("TransitRouterAttachmentDescription")]
        [Validation(Required=false)]
        public string TransitRouterAttachmentDescription { get; set; }

        /// <summary>
        /// <para>The name of the inter-region connection.</para>
        /// <para>The name can be empty or 1 to 128 characters in length, and cannot start with http\:// or https\://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testname</para>
        /// </summary>
        [NameInMap("TransitRouterAttachmentName")]
        [Validation(Required=false)]
        public string TransitRouterAttachmentName { get; set; }

        /// <summary>
        /// <para>The ID of the local Enterprise Edition transit router instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-bp1su1ytdxtataupl****</para>
        /// </summary>
        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

    }

}
