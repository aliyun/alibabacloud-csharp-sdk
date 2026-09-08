// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class UpdateTransitRouterVpcAttachmentZonesRequest : TeaModel {
        /// <summary>
        /// <para>The list of zones and vSwitches to add to the VPC connection.</para>
        /// </summary>
        [NameInMap("AddZoneMappings")]
        [Validation(Required=false)]
        public List<UpdateTransitRouterVpcAttachmentZonesRequestAddZoneMappings> AddZoneMappings { get; set; }
        public class UpdateTransitRouterVpcAttachmentZonesRequestAddZoneMappings : TeaModel {
            /// <summary>
            /// <para>The ID of the vSwitch to add to the VPC connection.</para>
            /// <para>You can add up to 10 vSwitches at a time.</para>
            /// <list type="bullet">
            /// <item><description>If the Alibaba Cloud account that you use to log on and the VPC-connected instance belong to the same account, you can invoke the <a href="https://help.aliyun.com/document_detail/35748.html">DescribeVSwitches</a> operation to query the vSwitch IDs and the IDs of the zones to which the vSwitches belong in the VPC-connected instance.</description></item>
            /// <item><description>If the Alibaba Cloud account that you use to log on and the VPC-connected instance belong to different accounts, you can invoke the <a href="https://help.aliyun.com/document_detail/427599.html">ListGrantVSwitchesToCen</a> operation to query the vSwitch IDs and the IDs of the zones to which the vSwitches belong in the VPC-connected instance.</description></item>
            /// </list>
            /// <para>If you set <b>VSwitchId</b>, you must also set <b>ZoneId</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-wz988dda8ldm4uvmx****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The ID of the zone to which the vSwitch to add to the VPC connection belongs.</para>
            /// <para>You can add up to 10 vSwitches at a time.</para>
            /// <para>If you set <b>ZoneId</b>, you must also set <b>VSwitchId</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-h</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may be different for each API request.</para>
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
        /// <item><description><b>true</b>: performs a dry run. The system checks the required parameters, request syntax, and business restrictions. If the request fails the dry run, the corresponding error message is returned. If the request passes the dry run, the error code <c>DryRunOperation</c> is returned. The zones and vSwitches of the VPC connection are not modified.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and sends the request. If the request passes the dry run, the zones and vSwitches of the VPC connection are modified.</description></item>
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
        /// <para>The list of zones and vSwitches to remove from the VPC connection.</para>
        /// </summary>
        [NameInMap("RemoveZoneMappings")]
        [Validation(Required=false)]
        public List<UpdateTransitRouterVpcAttachmentZonesRequestRemoveZoneMappings> RemoveZoneMappings { get; set; }
        public class UpdateTransitRouterVpcAttachmentZonesRequestRemoveZoneMappings : TeaModel {
            /// <summary>
            /// <para>The ID of the vSwitch to remove from the VPC connection.</para>
            /// <para>You can remove up to 10 vSwitches at a time.</para>
            /// <para>If you set <b>VSwitchId</b>, you must also set <b>ZoneId</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-wz9f5izl6wshndmta****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The ID of the zone to which the vSwitch to remove from the VPC connection belongs.</para>
            /// <para>You can remove up to 10 vSwitches at a time.</para>
            /// <para>If you set <b>ZoneId</b>, you must also set <b>VSwitchId</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC connection.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-attach-9bbqyygouv4cpn****</para>
        /// </summary>
        [NameInMap("TransitRouterAttachmentId")]
        [Validation(Required=false)]
        public string TransitRouterAttachmentId { get; set; }

    }

}
