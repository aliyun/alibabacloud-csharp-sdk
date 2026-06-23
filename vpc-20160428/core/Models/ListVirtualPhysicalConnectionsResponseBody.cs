// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListVirtualPhysicalConnectionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>NextToken</b> is not returned, no more results are available.</para>
        /// </description></item>
        /// <item><description><para>If a value is returned for <b>NextToken</b>, use it in the next request to retrieve the subsequent page of results.</para>
        /// </description></item>
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
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>A list of virtual physical connections.</para>
        /// </summary>
        [NameInMap("VirtualPhysicalConnections")]
        [Validation(Required=false)]
        public List<ListVirtualPhysicalConnectionsResponseBodyVirtualPhysicalConnections> VirtualPhysicalConnections { get; set; }
        public class ListVirtualPhysicalConnectionsResponseBodyVirtualPhysicalConnections : TeaModel {
            /// <summary>
            /// <para>The ID of the access point.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ap-cn-hangzhou-finance-yh-E</para>
            /// </summary>
            [NameInMap("AccessPointId")]
            [Validation(Required=false)]
            public string AccessPointId { get; set; }

            /// <summary>
            /// <para>The physical location of the access device for the physical connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>余杭经济开发区XXX交叉口, 余杭XX机房, E***包间</para>
            /// </summary>
            [NameInMap("AdLocation")]
            [Validation(Required=false)]
            public string AdLocation { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account that owns the virtual physical connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15346073170691****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public string AliUid { get; set; }

            /// <summary>
            /// <para>The bandwidth of the physical connection. Unit: Mbps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public long? Bandwidth { get; set; }

            /// <summary>
            /// <para>The business status of the physical connection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Normal</b>: The connection is running as expected.</para>
            /// </description></item>
            /// <item><description><para><b>FinancialLocked</b>: The connection is locked due to an overdue payment.</para>
            /// </description></item>
            /// <item><description><para><b>SecurityLocked</b>: The connection is locked for security reasons.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("BusinessStatus")]
            [Validation(Required=false)]
            public string BusinessStatus { get; set; }

            /// <summary>
            /// <para>The billing method of the physical connection.</para>
            /// <para>The only valid value is <b>Prepaid</b>, which corresponds to the subscription billing method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Prepaid</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The circuit code of the physical connection, which is provided by the carrier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>longtel001</para>
            /// </summary>
            [NameInMap("CircuitCode")]
            [Validation(Required=false)]
            public string CircuitCode { get; set; }

            /// <summary>
            /// <para>The time the physical connection was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06-08T12:20:55</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The description of the physical connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desctest</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The time the physical connection was enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-10-08T10:44Z</para>
            /// </summary>
            [NameInMap("EnabledTime")]
            [Validation(Required=false)]
            public string EnabledTime { get; set; }

            /// <summary>
            /// <para>The expiration time of the virtual physical connection.</para>
            /// <para>The time is in UTC and follows the <c>YYYY-MM-DDThh:mm:ssZ</c> format (ISO 8601).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-08T16:00:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The expected bandwidth for the virtual physical connection. This bandwidth is applied after the payment is completed.</para>
            /// <para><b>M</b> indicates Mbps, and <b>G</b> indicates Gbps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50M</para>
            /// </summary>
            [NameInMap("ExpectSpec")]
            [Validation(Required=false)]
            public string ExpectSpec { get; set; }

            /// <summary>
            /// <para>The carrier that provides the physical connection. Valid values include:</para>
            /// <list type="bullet">
            /// <item><description><para><b>CT</b>: China Telecom.</para>
            /// </description></item>
            /// <item><description><para><b>CU</b>: China Unicom.</para>
            /// </description></item>
            /// <item><description><para><b>CM</b>: China Mobile.</para>
            /// </description></item>
            /// <item><description><para><b>CO</b>: other Chinese carriers.</para>
            /// </description></item>
            /// <item><description><para><b>Equinix</b>: Equinix.</para>
            /// </description></item>
            /// <item><description><para><b>Other</b>: other carriers outside China.</para>
            /// </description></item>
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
            /// <item><description><para><b>Applying</b>: The LOA request is being processed.</para>
            /// </description></item>
            /// <item><description><para><b>Accept</b>: The LOA application is approved.</para>
            /// </description></item>
            /// <item><description><para><b>Available</b>: The LOA is generated and ready for use.</para>
            /// </description></item>
            /// <item><description><para><b>Rejected</b>: The LOA request is rejected.</para>
            /// </description></item>
            /// <item><description><para><b>Completing</b>: The physical connection is being provisioned.</para>
            /// </description></item>
            /// <item><description><para><b>Complete</b>: Provisioning is complete.</para>
            /// </description></item>
            /// <item><description><para><b>Deleted</b>: The LOA is deleted.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("LoaStatus")]
            [Validation(Required=false)]
            public string LoaStatus { get; set; }

            /// <summary>
            /// <para>The name of the physical connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nametest</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The billing method of the virtual physical connection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>PayByPhysicalConnectionOwner</b>: The owner of the parent physical connection pays.</para>
            /// </description></item>
            /// <item><description><para><b>PayByVirtualPhysicalConnectionOwner</b>: The owner of the virtual physical connection pays.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PayByPhysicalConnectionOwner</para>
            /// </summary>
            [NameInMap("OrderMode")]
            [Validation(Required=false)]
            public string OrderMode { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account that owns the parent physical connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18311773240248****</para>
            /// </summary>
            [NameInMap("ParentPhysicalConnectionAliUid")]
            [Validation(Required=false)]
            public string ParentPhysicalConnectionAliUid { get; set; }

            /// <summary>
            /// <para>The ID of the parent physical connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pc-bp1ciz7ekd2grn1as****</para>
            /// </summary>
            [NameInMap("ParentPhysicalConnectionId")]
            [Validation(Required=false)]
            public string ParentPhysicalConnectionId { get; set; }

            /// <summary>
            /// <para>The location of the on-premises data center.</para>
            /// 
            /// <b>Example:</b>
            /// <para>浙江省杭州市XX区XX街道XX号</para>
            /// </summary>
            [NameInMap("PeerLocation")]
            [Validation(Required=false)]
            public string PeerLocation { get; set; }

            /// <summary>
            /// <para>The ID of the virtual physical connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pc-bp1mrgfbtmc9brre7****</para>
            /// </summary>
            [NameInMap("PhysicalConnectionId")]
            [Validation(Required=false)]
            public string PhysicalConnectionId { get; set; }

            /// <summary>
            /// <para>The port number of the access device for the physical connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("PortNumber")]
            [Validation(Required=false)]
            public string PortNumber { get; set; }

            /// <summary>
            /// <para>The port type of the physical connection access point. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>100Base-T</b>: 100 Mbps copper port.</para>
            /// </description></item>
            /// <item><description><para><b>1000Base-T</b>: 1 Gbps copper port.</para>
            /// </description></item>
            /// <item><description><para><b>1000Base-LX</b>: 1 Gbps single-mode optical port (10 km).</para>
            /// </description></item>
            /// <item><description><para><b>10GBase-T</b>: 10 Gbps copper port.</para>
            /// </description></item>
            /// <item><description><para><b>10GBase-LR</b>: 10 Gbps single-mode optical port (10 km).</para>
            /// </description></item>
            /// <item><description><para><b>40GBase-LR</b>: 40 Gbps single-mode optical port.</para>
            /// </description></item>
            /// <item><description><para><b>100GBase-LR</b>: 100 Gbps single-mode optical port.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>10GBase-LR</para>
            /// </summary>
            [NameInMap("PortType")]
            [Validation(Required=false)]
            public string PortType { get; set; }

            /// <summary>
            /// <para>The type of the physical connection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>VirtualPhysicalConnection</b>: a virtual physical connection.</para>
            /// </description></item>
            /// <item><description><para><b>PhysicalConnection</b>: a dedicated physical connection.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>VirtualPhysicalConnection</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// <para>The ID of the redundant physical connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pc-119mfjzm****</para>
            /// </summary>
            [NameInMap("RedundantPhysicalConnectionId")]
            [Validation(Required=false)]
            public string RedundantPhysicalConnectionId { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the virtual physical connection belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfm3wmsyui****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The bandwidth of the virtual physical connection.</para>
            /// <para>M indicates Mbps, and G indicates Gbps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50M</para>
            /// </summary>
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }

            /// <summary>
            /// <para>The status of the physical connection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Initial</b>: The application is under review.</para>
            /// </description></item>
            /// <item><description><para><b>Approved</b>: The application is approved.</para>
            /// </description></item>
            /// <item><description><para><b>Allocating</b>: Resources are being allocated.</para>
            /// </description></item>
            /// <item><description><para><b>Allocated</b>: The connection is ready for provisioning.</para>
            /// </description></item>
            /// <item><description><para><b>Confirmed</b>: Awaiting user confirmation.</para>
            /// </description></item>
            /// <item><description><para><b>Enabled</b>: The connection is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>Rejected</b>: The application is rejected.</para>
            /// </description></item>
            /// <item><description><para><b>Canceled</b>: The application is canceled.</para>
            /// </description></item>
            /// <item><description><para><b>Allocation Failed</b>: Resource allocation failed.</para>
            /// </description></item>
            /// <item><description><para><b>Terminated</b>: The connection is terminated.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>A list of tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListVirtualPhysicalConnectionsResponseBodyVirtualPhysicalConnectionsTags> Tags { get; set; }
            public class ListVirtualPhysicalConnectionsResponseBodyVirtualPhysicalConnectionsTags : TeaModel {
                /// <summary>
                /// <para>The tag key, which cannot be an empty string. You can specify up to 20 tag keys.</para>
                /// <para>The key can be up to 64 characters in length and can contain digits, periods (.), underscores (_), and hyphens (-). The key cannot start with <c>aliyun</c> or <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceDept</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value. You can specify up to 20 tag values. The tag value can be an empty string.</para>
                /// <para>The value can be up to 128 characters in length. It can contain digits, periods (.), underscores (_), and hyphens (-). It cannot start with <c>aliyun</c> or <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceJoshua</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The type of the physical connection. The default value is <b>VPC</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VPC</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The business status of the virtual physical connection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Confirmed</b>: The virtual physical connection has been accepted by the recipient.</para>
            /// </description></item>
            /// <item><description><para><b>UnConfirmed</b>: The virtual physical connection is awaiting acceptance.</para>
            /// </description></item>
            /// <item><description><para><b>Deleted</b>: The virtual physical connection is deleted.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Confirmed</para>
            /// </summary>
            [NameInMap("VirtualPhysicalConnectionStatus")]
            [Validation(Required=false)]
            public string VirtualPhysicalConnectionStatus { get; set; }

            /// <summary>
            /// <para>The VLAN ID of the virtual physical connection.</para>
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
