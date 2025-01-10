// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class GetErResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public GetErResponseBodyContent Content { get; set; }
        public class GetErResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>The time when the data address was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1644283112720</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Description</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Network instance information list</para>
            /// </summary>
            [NameInMap("ErAttachments")]
            [Validation(Required=false)]
            public List<GetErResponseBodyContentErAttachments> ErAttachments { get; set; }
            public class GetErResponseBodyContentErAttachments : TeaModel {
                /// <summary>
                /// <para>Cross-account</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Across")]
                [Validation(Required=false)]
                public bool? Across { get; set; }

                /// <summary>
                /// <para>Receive all routes automatically</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AutoReceiveAllRoute")]
                [Validation(Required=false)]
                public bool? AutoReceiveAllRoute { get; set; }

                /// <summary>
                /// <para>The time when the data address was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1644283112720</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The connection ID of the Lingjun HUB network instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>er-attachment-f32hxfsu</para>
                /// </summary>
                [NameInMap("ErAttachmentId")]
                [Validation(Required=false)]
                public string ErAttachmentId { get; set; }

                /// <summary>
                /// <para>Network Instance Name</para>
                /// 
                /// <b>Example:</b>
                /// <para>fudan-egpu</para>
                /// </summary>
                [NameInMap("ErAttachmentName")]
                [Validation(Required=false)]
                public string ErAttachmentName { get; set; }

                /// <summary>
                /// <para>Lingjun HUB Instance ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>er-kkopgtne</para>
                /// </summary>
                [NameInMap("ErId")]
                [Validation(Required=false)]
                public string ErId { get; set; }

                /// <summary>
                /// <para>The time when the agent was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1649303733000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpd-kkopgtne</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The name of the ECU.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zhijiao</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>Instance type: VPD and VCC</para>
                /// <para>Valid value:</para>
                /// <list type="bullet">
                /// <item><description>VCC: Lingjun Connection.</description></item>
                /// <item><description>VPD: Lingjun network segment.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>VPD</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>The returned message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The synchronized region where the ECS instances are deployed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-wulanchabu</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>Resource group instance ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmzzka6bnjvbi</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The ID of the tenant to which the resource belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxxxxxx</para>
                /// </summary>
                [NameInMap("ResourceTenantId")]
                [Validation(Required=false)]
                public string ResourceTenantId { get; set; }

                /// <summary>
                /// <para>The status of the intervention entry. Valid value:</para>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The ID of the tenant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1620939556166277</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

            }

            /// <summary>
            /// <para>Lingjun HUB Instance ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>er-aueyxxsy</para>
            /// </summary>
            [NameInMap("ErId")]
            [Validation(Required=false)]
            public string ErId { get; set; }

            /// <summary>
            /// <para>Lingjun HUB Instance Name</para>
            /// 
            /// <b>Example:</b>
            /// <para>er-heyuan-main</para>
            /// </summary>
            [NameInMap("ErName")]
            [Validation(Required=false)]
            public string ErName { get; set; }

            /// <summary>
            /// <para>The list of route entry information.</para>
            /// </summary>
            [NameInMap("ErRouteEntrys")]
            [Validation(Required=false)]
            public List<GetErResponseBodyContentErRouteEntrys> ErRouteEntrys { get; set; }
            public class GetErResponseBodyContentErRouteEntrys : TeaModel {
                /// <summary>
                /// <para>Destination CIDR Block</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.0.0/9</para>
                /// </summary>
                [NameInMap("DestinationCidrBlock")]
                [Validation(Required=false)]
                public string DestinationCidrBlock { get; set; }

                /// <summary>
                /// <para>Lingjun HUB Instance ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>er-kkopgtne</para>
                /// </summary>
                [NameInMap("ErId")]
                [Validation(Required=false)]
                public string ErId { get; set; }

                /// <summary>
                /// <para>The ID of the route entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>er-rte-xnmsd2kl</para>
                /// </summary>
                [NameInMap("ErRouteEntryId")]
                [Validation(Required=false)]
                public string ErRouteEntryId { get; set; }

                /// <summary>
                /// <para>The time when the cluster was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1623317089000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>Next Hop Instance</para>
                /// 
                /// <b>Example:</b>
                /// <para>vcc-xxkmggkw</para>
                /// </summary>
                [NameInMap("NextHopId")]
                [Validation(Required=false)]
                public string NextHopId { get; set; }

                /// <summary>
                /// <para>Next Hop Instance Type</para>
                /// 
                /// <b>Example:</b>
                /// <para>VCC</para>
                /// </summary>
                [NameInMap("NextHopType")]
                [Validation(Required=false)]
                public string NextHopType { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-wulanchabu</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>Resource group instance ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmyoj5mg3w54y</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The ID of the tenant to which the resource belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1620939556166277</para>
                /// </summary>
                [NameInMap("ResourceTenantId")]
                [Validation(Required=false)]
                public string ResourceTenantId { get; set; }

                /// <summary>
                /// <para>Route type</para>
                /// 
                /// <b>Example:</b>
                /// <para>System</para>
                /// </summary>
                [NameInMap("RouteType")]
                [Validation(Required=false)]
                public string RouteType { get; set; }

                /// <summary>
                /// <para>The status of the intervention entry. Valid value:</para>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The ID of the tenant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1620939556166277</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

            }

            /// <summary>
            /// <para>routing policy information list</para>
            /// </summary>
            [NameInMap("ErRouteMaps")]
            [Validation(Required=false)]
            public List<GetErResponseBodyContentErRouteMaps> ErRouteMaps { get; set; }
            public class GetErResponseBodyContentErRouteMaps : TeaModel {
                /// <summary>
                /// <para>Policy behavior</para>
                /// <para>Valid value:</para>
                /// <list type="bullet">
                /// <item><description>deny: rejects the.</description></item>
                /// <item><description>permit: The allows.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>permit</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The time when the data address was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1645766599809</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>Policy description</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Destination CIDR Block</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.0.0/8</para>
                /// </summary>
                [NameInMap("DestinationCidrBlock")]
                [Validation(Required=false)]
                public string DestinationCidrBlock { get; set; }

                /// <summary>
                /// <para>Lingjun HUB ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>er-kkopgtne</para>
                /// </summary>
                [NameInMap("ErId")]
                [Validation(Required=false)]
                public string ErId { get; set; }

                /// <summary>
                /// <para>routing policy ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>er-rmap-xkslnmsr</para>
                /// </summary>
                [NameInMap("ErRouteMapId")]
                [Validation(Required=false)]
                public string ErRouteMapId { get; set; }

                /// <summary>
                /// <para>The name of the routing policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>route-map-name</para>
                /// </summary>
                [NameInMap("ErRouteMapName")]
                [Validation(Required=false)]
                public string ErRouteMapName { get; set; }

                /// <summary>
                /// <para>The time when the agent was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1623899444000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The message that is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The ID of the destination instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpd-sdkd2gkx</para>
                /// </summary>
                [NameInMap("ReceptionInstanceId")]
                [Validation(Required=false)]
                public string ReceptionInstanceId { get; set; }

                /// <summary>
                /// <para>The name of the destination instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Reception-name</para>
                /// </summary>
                [NameInMap("ReceptionInstanceName")]
                [Validation(Required=false)]
                public string ReceptionInstanceName { get; set; }

                /// <summary>
                /// <para>The tenant to which the destination instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1620939556166277</para>
                /// </summary>
                [NameInMap("ReceptionInstanceOwner")]
                [Validation(Required=false)]
                public string ReceptionInstanceOwner { get; set; }

                /// <summary>
                /// <para>The type of the destination instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VPD</para>
                /// </summary>
                [NameInMap("ReceptionInstanceType")]
                [Validation(Required=false)]
                public string ReceptionInstanceType { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-wulanchabu</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>Resource group instance ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmzaq3ypaqkdy</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>Policy sequence number (1001-2000)</para>
                /// 
                /// <b>Example:</b>
                /// <para>1001</para>
                /// </summary>
                [NameInMap("RouteMapNum")]
                [Validation(Required=false)]
                public int? RouteMapNum { get; set; }

                /// <summary>
                /// <para>The status of the intervention entry. Valid value:</para>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The ID of the tenant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>XXQGPROD-zh_CN</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                /// <summary>
                /// <para>The ID of the source instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpd-xmglsymg</para>
                /// </summary>
                [NameInMap("TransmissionInstanceId")]
                [Validation(Required=false)]
                public string TransmissionInstanceId { get; set; }

                /// <summary>
                /// <para>Source instance name</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-transmission</para>
                /// </summary>
                [NameInMap("TransmissionInstanceName")]
                [Validation(Required=false)]
                public string TransmissionInstanceName { get; set; }

                /// <summary>
                /// <para>The tenant to which the source instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1620939556166277</para>
                /// </summary>
                [NameInMap("TransmissionInstanceOwner")]
                [Validation(Required=false)]
                public string TransmissionInstanceOwner { get; set; }

                /// <summary>
                /// <para>The type of the source instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VPD</para>
                /// </summary>
                [NameInMap("TransmissionInstanceType")]
                [Validation(Required=false)]
                public string TransmissionInstanceType { get; set; }

            }

            /// <summary>
            /// <para>The time when the agent was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1627545952000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>Primary Zone</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-wulanchabu-b</para>
            /// </summary>
            [NameInMap("MasterZoneId")]
            [Validation(Required=false)]
            public string MasterZoneId { get; set; }

            /// <summary>
            /// <para>The message that is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-wulanchabu</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>Resource group instance ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekzlki4ehfse4y</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The status of the intervention entry. Valid value:</para>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1620939556166277</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        /// <summary>
        /// <para>Information returned when the call fails</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID of the current request</para>
        /// 
        /// <b>Example:</b>
        /// <para>308DE9D2-03A6-5B44-A369-67B75D1EE091</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
