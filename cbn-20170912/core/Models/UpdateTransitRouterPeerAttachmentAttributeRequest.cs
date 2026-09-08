// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class UpdateTransitRouterPeerAttachmentAttributeRequest : TeaModel {
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
        /// <item><description>If <b>BandwidthType</b> is set to <b>BandwidthPackage</b>, this parameter specifies the bandwidth that the inter-region connection can use.</description></item>
        /// <item><description>If <b>BandwidthType</b> is set to <b>DataTransfer</b>, this parameter specifies the bandwidth limit of the inter-region connection.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The bandwidth allocation method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BandwidthPackage</b>: allocates bandwidth from a bandwidth package.</description></item>
        /// <item><description><b>DataTransfer</b>: does not allocate bandwidth to the inter-region connection. Billing is based on the traffic volume.</description></item>
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
        /// <para>&lt;props=&quot;china&quot;&gt;If you do not specify a bandwidth package ID, the test bandwidth is used. The default test bandwidth is 1 Kbit/s and is intended only for testing (IPv4) network connectivity.</para>
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
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> as the <b>ClientToken</b>. The <b>RequestId</b> of each API request may be different.</para>
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
        /// <para>The value can be set to Platinum only when the bandwidth allocation method is pay-by-data-transfer.</para>
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
        /// <item><description><b>false</b> (default): sends a normal request and directly modifies the configuration of the inter-region connection after the request passes the check.</description></item>
        /// <item><description><b>true</b>: sends a check request. Only the check is performed and the configuration of the inter-region connection is not modified. The check items include whether required parameters are specified and the request format. If the check fails, the corresponding error is returned. If the check succeeds, the corresponding request ID is returned.</description></item>
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

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The new description of the inter-region connection.</para>
        /// <para>The description can be empty or 1 to 256 characters in length, and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testdesc</para>
        /// </summary>
        [NameInMap("TransitRouterAttachmentDescription")]
        [Validation(Required=false)]
        public string TransitRouterAttachmentDescription { get; set; }

        /// <summary>
        /// <para>The ID of the inter-region connection.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-attach-ft94dcrbc3e5taun3x</para>
        /// </summary>
        [NameInMap("TransitRouterAttachmentId")]
        [Validation(Required=false)]
        public string TransitRouterAttachmentId { get; set; }

        /// <summary>
        /// <para>The new name of the inter-region connection.</para>
        /// <para>The name can be empty or 1 to 128 characters in length, and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testname</para>
        /// </summary>
        [NameInMap("TransitRouterAttachmentName")]
        [Validation(Required=false)]
        public string TransitRouterAttachmentName { get; set; }

    }

}
