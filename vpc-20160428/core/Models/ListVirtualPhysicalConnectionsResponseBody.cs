// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListVirtualPhysicalConnectionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned in this query.</para>
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
        /// <item><description>If the value of <b>NextToken</b> is not returned, it indicates that no next query is to be sent.</description></item>
        /// <item><description>If <b>NextToken</b> was returned in the previous query, specify the value to obtain the next set of results.</description></item>
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
        /// <para>The list of hosted connections returned.</para>
        /// </summary>
        [NameInMap("VirtualPhysicalConnections")]
        [Validation(Required=false)]
        public List<ListVirtualPhysicalConnectionsResponseBodyVirtualPhysicalConnections> VirtualPhysicalConnections { get; set; }
        public class ListVirtualPhysicalConnectionsResponseBodyVirtualPhysicalConnections : TeaModel {
            /// <summary>
            /// <para>The ID of the access point that is associated with the Express Connect circuit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ap-cn-hangzhou-finance-yh-E</para>
            /// </summary>
            [NameInMap("AccessPointId")]
            [Validation(Required=false)]
            public string AccessPointId { get; set; }

            /// <summary>
            /// <para>The geographical location of the access device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Yuhang Economic Development Zone XXX Intersection, Yuhang XX Machine Room, E*** Suite.</para>
            /// </summary>
            [NameInMap("AdLocation")]
            [Validation(Required=false)]
            public string AdLocation { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID of the hosted connection owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>253460731706911258</para>
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
            /// <para>The status of the Express Connect circuit. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Normal</b></description></item>
            /// <item><description><b>FinancialLocked</b></description></item>
            /// <item><description><b>SecurityLocked</b></description></item>
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
            /// <para>If <b>Prepaid</b> is returned, it indicates that the Express Connect circuit is billed on a subscription basis.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Prepaid</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The circuit code of the Express Connect circuit. The circuit code is provided by the connectivity provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>longtel001</para>
            /// </summary>
            [NameInMap("CircuitCode")]
            [Validation(Required=false)]
            public string CircuitCode { get; set; }

            /// <summary>
            /// <para>The time when the Express Connect circuit was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06-08T12:20:55</para>
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
            /// <para>The time when the Express Connect circuit is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-10-08T10:44Z</para>
            /// </summary>
            [NameInMap("EnabledTime")]
            [Validation(Required=false)]
            public string EnabledTime { get; set; }

            /// <summary>
            /// <para>The expiration date of the hosted connection.</para>
            /// <para>The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-08T16:00:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The estimated maximum bandwidth of the shared Express Connect circuit. The estimated bandwidth takes effect after you complete the payment.</para>
            /// <para><b>M</b> indicates Mbit/s and <b>G</b> indicates Gbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50M</para>
            /// </summary>
            [NameInMap("ExpectSpec")]
            [Validation(Required=false)]
            public string ExpectSpec { get; set; }

            /// <summary>
            /// <para>The connectivity provider of the Express Connect circuit. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CT</b>: China Telecom.</description></item>
            /// <item><description><b>CU</b>: China Unicom.</description></item>
            /// <item><description><b>CM</b>: China Mobile.</description></item>
            /// <item><description><b>CO</b>: other connectivity providers in the Chinese mainland.</description></item>
            /// <item><description><b>Equinix</b>: Equinix.</description></item>
            /// <item><description><b>Other</b>: other connectivity providers outside the Chinese mainland.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CU</para>
            /// </summary>
            [NameInMap("LineOperator")]
            [Validation(Required=false)]
            public string LineOperator { get; set; }

            /// <summary>
            /// <para>The status of the letter of authorization (LOA). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Applying</b></description></item>
            /// <item><description><b>Accept</b></description></item>
            /// <item><description><b>Available</b></description></item>
            /// <item><description><b>Rejected</b></description></item>
            /// <item><description><b>Completing</b></description></item>
            /// <item><description><b>Complete</b></description></item>
            /// <item><description><b>Deleted</b></description></item>
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
            /// <para>The payer for the shared Express Connect circuit. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PayByPhysicalConnectionOwner</b>: the owner of the shared Express Connect circuit</description></item>
            /// <item><description><b>PayByVirtualPhysicalConnectionOwner</b>: the owner of the hosted connection</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PayByPhysicalConnectionOwner</para>
            /// </summary>
            [NameInMap("OrderMode")]
            [Validation(Required=false)]
            public string OrderMode { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the Express Connect circuit belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>283117732402483989</para>
            /// </summary>
            [NameInMap("ParentPhysicalConnectionAliUid")]
            [Validation(Required=false)]
            public string ParentPhysicalConnectionAliUid { get; set; }

            /// <summary>
            /// <para>The ID of the Express Connect circuit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pc-bp1ciz7ekd2grn1as****</para>
            /// </summary>
            [NameInMap("ParentPhysicalConnectionId")]
            [Validation(Required=false)]
            public string ParentPhysicalConnectionId { get; set; }

            /// <summary>
            /// <para>The geographical location of the data center.</para>
            /// 
            /// <b>Example:</b>
            /// <para>XX Number, XX Road, XX Town, XX District, Hangzhou City, Zhejiang Province.</para>
            /// </summary>
            [NameInMap("PeerLocation")]
            [Validation(Required=false)]
            public string PeerLocation { get; set; }

            /// <summary>
            /// <para>The ID of the hosted connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pc-bp1mrgfbtmc9brre7****</para>
            /// </summary>
            [NameInMap("PhysicalConnectionId")]
            [Validation(Required=false)]
            public string PhysicalConnectionId { get; set; }

            /// <summary>
            /// <para>The ID of the port on the access device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("PortNumber")]
            [Validation(Required=false)]
            public string PortNumber { get; set; }

            /// <summary>
            /// <para>The port type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>100Base-T</b>: 100 Mbit/s copper Ethernet port</description></item>
            /// <item><description><b>1000Base-T</b>: 1,000 Mbit/s copper Ethernet port</description></item>
            /// <item><description><b>1000Base-LX</b>: 1,000 Mbit/s single-mode optical port (10 km)</description></item>
            /// <item><description><b>10GBase-T</b>: 10,000 Mbit/s copper Ethernet port</description></item>
            /// <item><description><b>10GBase-LR</b>: 10,000 Mbit/s single-mode optical port (10 km)</description></item>
            /// <item><description><b>40GBase-LR</b>: 40,000 Mbit/s single-mode optical port</description></item>
            /// <item><description><b>100GBase-LR</b>: 100,000 Mbit/s single-mode optical port</description></item>
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
            /// <item><description><b>VirtualPhysicalConnection</b>: shared Express Connect circuit</description></item>
            /// <item><description><b>PhysicalConnection</b>: dedicated Express Connect circuit</description></item>
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
            /// <para>The ID of the resource group to which the hosted connection belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfm3wmsyuimpma</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The bandwidth value of the hosted connection.</para>
            /// <para><b>M</b> indicates Mbit/s and <b>G</b> indicates Gbit/s.</para>
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
            /// <item><description><b>Allocating</b>: The system is allocating resources.</description></item>
            /// <item><description><b>Allocated</b>: The Express Connect circuit is under construction.</description></item>
            /// <item><description><b>Confirmed</b>: The Express Connect circuit is pending for user confirmation.</description></item>
            /// <item><description><b>Enabled</b>: The Express Connect circuit is enabled.</description></item>
            /// <item><description><b>Rejected</b>: The application is rejected.</description></item>
            /// <item><description><b>Canceled</b>: The application is canceled.</description></item>
            /// <item><description><b>Allocation Failed</b>: The system failed to allocate resources.</description></item>
            /// <item><description><b>Terminated</b>: The Express Connect circuit is disabled.</description></item>
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
                /// <para>The key of tag N that is added to the resource. You can specify at most 20 tag keys. The tag key cannot be an empty string.</para>
                /// <para>It can be up to 64 characters in length and can contain digits, periods (.), underscores (_), and hyphens (-). It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceDept</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of tag N that is added to the resource. You can specify at most 20 tag values. The tag value can be an empty string.</para>
                /// <para>It can be up to 128 characters in length and can contain digits, periods (.), underscores (_), and hyphens (-). It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceJoshua</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The type of Express Connect circuit. Default value: <b>VPC</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VPC</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The status of the hosted connection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Confirmed</b></description></item>
            /// <item><description><b>UnConfirmed</b></description></item>
            /// <item><description><b>Deleted</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Confirmed</para>
            /// </summary>
            [NameInMap("VirtualPhysicalConnectionStatus")]
            [Validation(Required=false)]
            public string VirtualPhysicalConnectionStatus { get; set; }

            /// <summary>
            /// <para>The VLAN ID of the hosted connection.</para>
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
