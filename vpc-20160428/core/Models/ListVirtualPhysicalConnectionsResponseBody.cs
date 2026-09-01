// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListVirtualPhysicalConnectionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned in the current query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>Indicates whether a next query token exists. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next query exists.</description></item>
        /// <item><description>If <b>NextToken</b> has a return value, the value is the token for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dd20****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2A55F69E-EE3D-5CBE-8805-734F7D5B46B9</para>
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
        /// <para>The list of shared Express Connect circuits.</para>
        /// </summary>
        [NameInMap("VirtualPhysicalConnections")]
        [Validation(Required=false)]
        public List<ListVirtualPhysicalConnectionsResponseBodyVirtualPhysicalConnections> VirtualPhysicalConnections { get; set; }
        public class ListVirtualPhysicalConnectionsResponseBodyVirtualPhysicalConnections : TeaModel {
            /// <summary>
            /// <para>The access point ID of the Express Connect circuit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ap-cn-hangzhou-finance-yh-E</para>
            /// </summary>
            [NameInMap("AccessPointId")]
            [Validation(Required=false)]
            public string AccessPointId { get; set; }

            /// <summary>
            /// <para>The physical location of the access device for the Express Connect circuit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Yuhang Economic Development Zone, XX Intersection, Yuhang XX Data Center, Room E***</para>
            /// </summary>
            [NameInMap("AdLocation")]
            [Validation(Required=false)]
            public string AdLocation { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID of the shared Express Connect circuits owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15346073170691****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public string AliUid { get; set; }

            /// <summary>
            /// <para>The bandwidth of the Express Connect circuit. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public long? Bandwidth { get; set; }

            /// <summary>
            /// <para>The business status of the Express Connect circuit. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Normal</b>: Enabled.</description></item>
            /// <item><description><b>FinancialLocked</b>: Locked due to overdue payment.</description></item>
            /// <item><description><b>SecurityLocked</b>: Locked for security reasons.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("BusinessStatus")]
            [Validation(Required=false)]
            public string BusinessStatus { get; set; }

            /// <summary>
            /// <para>The billing method of the Express Connect circuit.</para>
            /// <para>Valid values: <b>Prepaid</b>, which indicates subscription.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Prepaid</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The circuit code provided by the carrier for the Express Connect circuit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>longtel001</para>
            /// </summary>
            [NameInMap("CircuitCode")]
            [Validation(Required=false)]
            public string CircuitCode { get; set; }

            /// <summary>
            /// <para>The time when the Express Connect circuit was created. The time is displayed in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06-08T12:20:55Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The description of the Express Connect circuit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desctest</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The time when the Express Connect circuit was enabled. The time is displayed in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-10-08T10:44:00Z</para>
            /// </summary>
            [NameInMap("EnabledTime")]
            [Validation(Required=false)]
            public string EnabledTime { get; set; }

            /// <summary>
            /// <para>The expiration time of the shared Express Connect circuits.</para>
            /// <para>The time is displayed in the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-08T16:00:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The expected bandwidth value of the shared Express Connect circuits. The expected bandwidth value takes effect only after payment is completed.</para>
            /// <para>Unit: <b>M</b> indicates Mbit/s, and <b>G</b> indicates Gbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50M</para>
            /// </summary>
            [NameInMap("ExpectSpec")]
            [Validation(Required=false)]
            public string ExpectSpec { get; set; }

            /// <summary>
            /// <para>The carrier that provides the physical line for access. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CT</b>: China Telecom.</description></item>
            /// <item><description><b>CU</b>: China Unicom.</description></item>
            /// <item><description><b>CM</b>: China Mobile.</description></item>
            /// <item><description><b>CO</b>: Other carriers in the Chinese mainland.</description></item>
            /// <item><description><b>Equinix</b>: Equinix.</description></item>
            /// <item><description><b>Other</b>: Other carriers outside the Chinese mainland.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CU</para>
            /// </summary>
            [NameInMap("LineOperator")]
            [Validation(Required=false)]
            public string LineOperator { get; set; }

            /// <summary>
            /// <para>The status of the Letter of Authorization (LOA). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Applying</b>: The LOA application is being processed.</description></item>
            /// <item><description><b>Accept</b>: The LOA application is approved.</description></item>
            /// <item><description><b>Available</b>: The LOA is available.</description></item>
            /// <item><description><b>Rejected</b>: The LOA application is rejected.</description></item>
            /// <item><description><b>Completing</b>: The Express Connect circuit is under construction.</description></item>
            /// <item><description><b>Complete</b>: The Express Connect circuit construction is complete.</description></item>
            /// <item><description><b>Deleted</b>: The LOA is deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("LoaStatus")]
            [Validation(Required=false)]
            public string LoaStatus { get; set; }

            /// <summary>
            /// <para>The name of the Express Connect circuit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nametest</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The payer of the shared Express Connect circuits. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PayByPhysicalConnectionOwner</b>: The owner of the Express Connect circuit associated with the shared Express Connect circuits is the payer.</description></item>
            /// <item><description><b>PayByVirtualPhysicalConnectionOwner</b>: The owner of the shared Express Connect circuits is the payer.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PayByPhysicalConnectionOwner</para>
            /// </summary>
            [NameInMap("OrderMode")]
            [Validation(Required=false)]
            public string OrderMode { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID that owns the Express Connect circuit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18311773240248****</para>
            /// </summary>
            [NameInMap("ParentPhysicalConnectionAliUid")]
            [Validation(Required=false)]
            public string ParentPhysicalConnectionAliUid { get; set; }

            /// <summary>
            /// <para>The instance ID of the Express Connect circuit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pc-bp1ciz7ekd2grn1as****</para>
            /// </summary>
            [NameInMap("ParentPhysicalConnectionId")]
            [Validation(Required=false)]
            public string ParentPhysicalConnectionId { get; set; }

            /// <summary>
            /// <para>The geographic location of the on-premises data center.</para>
            /// 
            /// <b>Example:</b>
            /// <para>No. XX, XX Street, XX District, Hangzhou, Zhejiang Province</para>
            /// </summary>
            [NameInMap("PeerLocation")]
            [Validation(Required=false)]
            public string PeerLocation { get; set; }

            /// <summary>
            /// <para>The instance ID of the shared Express Connect circuits.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pc-bp1mrgfbtmc9brre7****</para>
            /// </summary>
            [NameInMap("PhysicalConnectionId")]
            [Validation(Required=false)]
            public string PhysicalConnectionId { get; set; }

            /// <summary>
            /// <para>The port number of the access device for the Express Connect circuit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("PortNumber")]
            [Validation(Required=false)]
            public string PortNumber { get; set; }

            /// <summary>
            /// <para>The port type of the access device for the Express Connect circuit. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>100Base-T</b>: 100M Ethernet port.</description></item>
            /// <item><description><b>1000Base-T</b>: GE electrical port.</description></item>
            /// <item><description><b>1000Base-LX</b>: GE single-mode optical port (10 km).</description></item>
            /// <item><description><b>10GBase-T</b>: 10 GE electrical port.</description></item>
            /// <item><description><b>10GBase-LR</b>: 10 GE single-mode optical port (10 km).</description></item>
            /// <item><description><b>40GBase-LR</b>: 40 GE single-mode optical port.</description></item>
            /// <item><description><b>100GBase-LR</b>: 100 GE single-mode optical port.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>10GBase-LR</para>
            /// </summary>
            [NameInMap("PortType")]
            [Validation(Required=false)]
            public string PortType { get; set; }

            /// <summary>
            /// <para>The type of the Express Connect circuit. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>VirtualPhysicalConnection</b>: Shared Express Connect circuits.</description></item>
            /// <item><description><b>PhysicalConnection</b>: Dedicated Express Connect circuit.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>VirtualPhysicalConnection</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// <para>The ID of the redundant Express Connect circuit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pc-119mfjzm****</para>
            /// </summary>
            [NameInMap("RedundantPhysicalConnectionId")]
            [Validation(Required=false)]
            public string RedundantPhysicalConnectionId { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the shared Express Connect circuits belong.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfm3wmsyui****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The bandwidth value of the shared Express Connect circuits.</para>
            /// <para>Unit: <b>M</b> indicates Mbit/s, and <b>G</b> indicates Gbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50M</para>
            /// </summary>
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }

            /// <summary>
            /// <para>The status of the Express Connect circuit. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Initial</b>: The application is under review.</description></item>
            /// <item><description><b>Approved</b>: The application is approved.</description></item>
            /// <item><description><b>Allocating</b>: Resources are being allocated.</description></item>
            /// <item><description><b>Allocated</b>: Under construction.</description></item>
            /// <item><description><b>Confirmed</b>: Waiting for user confirmation.</description></item>
            /// <item><description><b>Enabled</b>: Enabled.</description></item>
            /// <item><description><b>Rejected</b>: The application is rejected.</description></item>
            /// <item><description><b>Canceled</b>: Canceled.</description></item>
            /// <item><description><b>Allocation Failed</b>: Resource allocation failed.</description></item>
            /// <item><description><b>Terminated</b>: Terminated.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tag list.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListVirtualPhysicalConnectionsResponseBodyVirtualPhysicalConnectionsTags> Tags { get; set; }
            public class ListVirtualPhysicalConnectionsResponseBodyVirtualPhysicalConnectionsTags : TeaModel {
                /// <summary>
                /// <para>The tag key of the resource. You can specify up to 20 tag keys. The tag key cannot be an empty string.</para>
                /// <para>The tag key can be up to 64 characters in length and can contain digits, periods (.), underscores (_), and hyphens (-). It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceDept</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value of the resource. You can specify up to 20 tag values. The tag value can be an empty string.</para>
                /// <para>The tag value can be up to 128 characters in length and can contain digits, periods (.), underscores (_), and hyphens (-). It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceJoshua</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The type of the Express Connect circuit. Default value: <b>VPC</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VPC</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The business status of the shared Express Connect circuits. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Confirmed</b>: The shared Express Connect circuits have been accepted.</description></item>
            /// <item><description><b>UnConfirmed</b>: The shared Express Connect circuits have not been accepted.</description></item>
            /// <item><description><b>Deleted</b>: The shared Express Connect circuits have been deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Confirmed</para>
            /// </summary>
            [NameInMap("VirtualPhysicalConnectionStatus")]
            [Validation(Required=false)]
            public string VirtualPhysicalConnectionStatus { get; set; }

            /// <summary>
            /// <para>The VLAN ID of the shared Express Connect circuits.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("VlanId")]
            [Validation(Required=false)]
            public string VlanId { get; set; }

        }

    }

}
