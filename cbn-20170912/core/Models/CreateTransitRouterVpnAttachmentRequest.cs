// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateTransitRouterVpnAttachmentRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to allow the transit router to automatically advertise routes to the IPsec-VPN attachment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default): yes</description></item>
        /// <item><description><b>false</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPublishRouteEnabled")]
        [Validation(Required=false)]
        public bool? AutoPublishRouteEnabled { get; set; }

        /// <summary>
        /// <para>The ID of the Cloud Enterprise Network (CEN) instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-rsgxs8ng2awen2****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The billing method.</para>
        /// <para>Set the value to <b>POSTPAY</b>, which is the default value and specifies the pay-as-you-go billing method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>POSTPAY</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among all requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not set this parameter, <b>ClientToken</b> is set to the value of <b>RequestId</b>. The value of <b>RequestId</b> for each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run. The system checks the required parameters, request syntax, and limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and sends the request.</description></item>
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
        /// <para>The ID of the region where the transit router is deployed.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/132080.html">DescribeChildInstanceRegions</a> operation to query the most recent region list.</para>
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
        /// <para>The tags.</para>
        /// <para>You can specify at most 20 tags in each call.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateTransitRouterVpnAttachmentRequestTag> Tag { get; set; }
        public class CreateTransitRouterVpnAttachmentRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// <para>The tag keys cannot be an empty string. The tag key can be up to 64 characters in length, and cannot start with <c>acs:</c> or <c>aliyun</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>You can specify at most 20 tag keys.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TagKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// <para>The tag value can be 0 to 128 characters in length, and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>Each tag key must have a unique tag value. You can specify at most 20 tag values in each call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TagValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The description of the VPN attachment.</para>
        /// <para>The description must be 2 to 256 characters in length. The description must start with a letter but cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desctest</para>
        /// </summary>
        [NameInMap("TransitRouterAttachmentDescription")]
        [Validation(Required=false)]
        public string TransitRouterAttachmentDescription { get; set; }

        /// <summary>
        /// <para>The name of the VPN attachment.</para>
        /// <para>The name must be 2 to 128 characters in length, and can contain letters, digits, underscores (_), and hyphens (-). It must start with a letter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nametest</para>
        /// </summary>
        [NameInMap("TransitRouterAttachmentName")]
        [Validation(Required=false)]
        public string TransitRouterAttachmentName { get; set; }

        /// <summary>
        /// <para>The ID of the transit router.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-p0wm740vjnbaprv0m****</para>
        /// </summary>
        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

        /// <summary>
        /// <para>The ID of the IPsec-VPN attachment.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vco-p0w042cqwvlhl4zyw****</para>
        /// </summary>
        [NameInMap("VpnId")]
        [Validation(Required=false)]
        public string VpnId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the IPsec-VPN connection belongs.</para>
        /// <list type="bullet">
        /// <item><description>If you do not set this parameter, the ID of the current Alibaba Cloud account is used.</description></item>
        /// <item><description>You must set VpnOwnerId if you want to connect the transit router to an IPsec-VPN connection that belongs to another Alibaba Cloud account.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1210123456123456</para>
        /// </summary>
        [NameInMap("VpnOwnerId")]
        [Validation(Required=false)]
        public long? VpnOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the zone in the current region.</para>
        /// <para>Resources are deployed in the specified zone.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Zone")]
        [Validation(Required=false)]
        public List<CreateTransitRouterVpnAttachmentRequestZone> Zone { get; set; }
        public class CreateTransitRouterVpnAttachmentRequestZone : TeaModel {
            /// <summary>
            /// <para>The zone ID of the read-only instance.</para>
            /// <para>You can call the <a href="https://help.aliyun.com/document_detail/261356.html">ListTransitRouterAvailableResource</a> operation to query the most recent zone list.</para>
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
