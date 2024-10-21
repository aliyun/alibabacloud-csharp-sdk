// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class UpdateTransitRouterVpcAttachmentZonesRequest : TeaModel {
        /// <summary>
        /// <para>The zones and vSwitches that you want to add to the VPC connection.</para>
        /// </summary>
        [NameInMap("AddZoneMappings")]
        [Validation(Required=false)]
        public List<UpdateTransitRouterVpcAttachmentZonesRequestAddZoneMappings> AddZoneMappings { get; set; }
        public class UpdateTransitRouterVpcAttachmentZonesRequestAddZoneMappings : TeaModel {
            /// <summary>
            /// <para>The ID of the vSwitch that you want to add to the VPC connection.</para>
            /// <para>You can specify at most 10 vSwitches in each call.</para>
            /// <list type="bullet">
            /// <item><description>If the VPC connection belongs to the current Alibaba Cloud account, you can call the <a href="https://help.aliyun.com/document_detail/35748.html">DescribeVSwitches</a> operation to query the IDs of the vSwitches and zones of the VPC.</description></item>
            /// <item><description>If the VPC connection belongs to another Alibaba Cloud account, you can call the <a href="https://help.aliyun.com/document_detail/427599.html">ListGrantVSwitchesToCen</a> operation to query the IDs of the vSwitches and zones of the VPC.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-wz988dda8ldm4uvmx****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The ID of the zone where the vSwitch that you want to add to the VPC connection is deployed.</para>
            /// <para>You can specify at most 10 vSwitches in each call.</para>
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
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not set this parameter, ClientToken is set to the value of RequestId. The value of RequestId for each API request may be different.</para>
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
        /// <para>The zones and vSwitches that you want to remove from the VPC connection.</para>
        /// </summary>
        [NameInMap("RemoveZoneMappings")]
        [Validation(Required=false)]
        public List<UpdateTransitRouterVpcAttachmentZonesRequestRemoveZoneMappings> RemoveZoneMappings { get; set; }
        public class UpdateTransitRouterVpcAttachmentZonesRequestRemoveZoneMappings : TeaModel {
            /// <summary>
            /// <para>The ID of the vSwitch that you want to remove from the VPC connection.</para>
            /// <para>You can remove at most 10 vSwitches from a VPC in each call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-wz9f5izl6wshndmta****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The ID of the zone where the vSwitch that you want to remove from the VPC connection is deployed.</para>
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
