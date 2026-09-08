// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateTransitRouterPeerAttachmentRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to allow the Enterprise Edition transit router to automatically advertise routes of the inter-region connection to the peer region.</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): no.</description></item>
        /// <item><description><b>true</b>: yes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPublishRouteEnabled")]
        [Validation(Required=false)]
        public bool? AutoPublishRouteEnabled { get; set; }

        /// <summary>
        /// <para>The bandwidth value of the inter-region connection. Unit: Mbit/s.</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>BandwidthType</b> is set to <b>BandwidthPackage</b>, this parameter specifies the bandwidth that can be used by the inter-region connection.</para>
        /// </description></item>
        /// <item><description><para>If <b>BandwidthType</b> is set to <b>DataTransfer</b>, this parameter specifies the bandwidth limit of the inter-region connection.</para>
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
        /// <para>The bandwidth allocation method of the inter-region connection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>BandwidthPackage</b>: allocates bandwidth from a bandwidth package.</para>
        /// </description></item>
        /// <item><description><para><b>DataTransfer</b>: does not allocate bandwidth to the inter-region connection. The system charges you based on the actual traffic.</para>
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
        /// <para>The ID of the bandwidth package to be associated with the inter-region connection.</para>
        /// <remarks>
        /// <para>If <b>BandwidthType</b> is set to <b>DataTransfer</b>, you do not need to configure this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cenbwp-3xrxupouolw5ou****</para>
        /// </summary>
        [NameInMap("CenBandwidthPackageId")]
        [Validation(Required=false)]
        public string CenBandwidthPackageId { get; set; }

        /// <summary>
        /// <para>The Cloud Enterprise Network (CEN) instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-j3jzhw1zpau2km****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-001****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The default link type.</para>
        /// <para>Valid values: Platinum and Gold. Default value: Gold.</para>
        /// <para>The link type can be set to Platinum only when the bandwidth allocation method is pay-by-data-transfer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Gold</para>
        /// </summary>
        [NameInMap("DefaultLinkType")]
        [Validation(Required=false)]
        public string DefaultLinkType { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run, including permission and instance status verification. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): sends a normal request. If the request passes the verification, the inter-region connection is created.</description></item>
        /// <item><description><b>true</b>: sends a check request. Only the verification is performed. No inter-region connection is created. The system checks whether the required parameters are specified, and validates the request format. If the check fails, the corresponding error is returned. If the check succeeds, the corresponding request ID is returned.</description></item>
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
        /// <para>The region ID of the peer transit router instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-qingdao</para>
        /// </summary>
        [NameInMap("PeerTransitRouterRegionId")]
        [Validation(Required=false)]
        public string PeerTransitRouterRegionId { get; set; }

        /// <summary>
        /// <para>The region ID of the local Enterprise Edition transit router instance.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
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
        /// <para>You can specify up to 20 tags at a time.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateTransitRouterPeerAttachmentRequestTag> Tag { get; set; }
        public class CreateTransitRouterPeerAttachmentRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource.</para>
            /// <para>Once specified, the tag key cannot be an empty string. The tag key can be up to 64 characters in length, and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>You can specify up to 20 tag keys at a time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag_A1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource.</para>
            /// <para>Once specified, the tag value cannot be empty. The tag value can be up to 128 characters in length, and cannot start with aliyun or acs:. It cannot contain http:// or https://.</para>
            /// <para>Each tag key corresponds to one tag value. You can specify up to 20 tag values at a time.</para>
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
        /// <para>The description can be empty or 1 to 256 characters in length, and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testdesc</para>
        /// </summary>
        [NameInMap("TransitRouterAttachmentDescription")]
        [Validation(Required=false)]
        public string TransitRouterAttachmentDescription { get; set; }

        /// <summary>
        /// <para>The name of the inter-region connection.</para>
        /// <para>The name can be empty or 1 to 128 characters in length, and cannot start with http:// or https://.</para>
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
