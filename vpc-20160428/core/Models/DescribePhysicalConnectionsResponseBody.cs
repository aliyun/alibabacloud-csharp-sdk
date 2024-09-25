// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribePhysicalConnectionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: <b>10</b>. Valid values: <b>1</b> to <b>50</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The list of Express Connect circuits.</para>
        /// </summary>
        [NameInMap("PhysicalConnectionSet")]
        [Validation(Required=false)]
        public DescribePhysicalConnectionsResponseBodyPhysicalConnectionSet PhysicalConnectionSet { get; set; }
        public class DescribePhysicalConnectionsResponseBodyPhysicalConnectionSet : TeaModel {
            [NameInMap("PhysicalConnectionType")]
            [Validation(Required=false)]
            public List<DescribePhysicalConnectionsResponseBodyPhysicalConnectionSetPhysicalConnectionType> PhysicalConnectionType { get; set; }
            public class DescribePhysicalConnectionsResponseBodyPhysicalConnectionSetPhysicalConnectionType : TeaModel {
                /// <summary>
                /// <para>The ID of the Express Connect circuit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ap-cn-hangzhou-finance-yh-E</para>
                /// </summary>
                [NameInMap("AccessPointId")]
                [Validation(Required=false)]
                public string AccessPointId { get; set; }

                /// <summary>
                /// <para>The type of the access point.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VPC</para>
                /// </summary>
                [NameInMap("AccessPointType")]
                [Validation(Required=false)]
                public string AccessPointType { get; set; }

                /// <summary>
                /// <para>The information about the data center and rack.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Position 30, Server Rack JXX, Booth ET135ET135-XX-2, Room XX, Building 10, XX Road, XX Town, XX District, Hangzhou, Zhejiang Province</para>
                /// </summary>
                [NameInMap("AdDetailLocation")]
                [Validation(Required=false)]
                public string AdDetailLocation { get; set; }

                /// <summary>
                /// <para>The location of the access point.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Number 10, XX Road, XX Town, XX District, Hangzhou City, Zhejiang Province.</para>
                /// </summary>
                [NameInMap("AdLocation")]
                [Validation(Required=false)]
                public string AdLocation { get; set; }

                /// <summary>
                /// <para>The maximum bandwidth of the Express Connect circuit.</para>
                /// <para>Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public long? Bandwidth { get; set; }

                /// <summary>
                /// <para>The status of the Express Connect circuit. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Normal</b>: enabled</description></item>
                /// <item><description><b>FinancialLocked</b>: locked due to overdue payments</description></item>
                /// <item><description><b>SecurityLocked</b>: locked for security reasons</description></item>
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
                /// <para>2021-08-24T07:30:58Z</para>
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
                /// <para>The time when the Express Connect circuit was enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-08-24T07:33:18Z</para>
                /// </summary>
                [NameInMap("EnabledTime")]
                [Validation(Required=false)]
                public string EnabledTime { get; set; }

                /// <summary>
                /// <para>The time when the Express Connect circuit expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-04-24T16:00:00Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The estimated maximum bandwidth of the shared Express Connect circuit. The estimated bandwidth takes effect after you complete the payment.</para>
                /// <para>Unit: <b>M</b> (Mbit/s) and <b>G</b> (Gbit/s).</para>
                /// 
                /// <b>Example:</b>
                /// <para>50M</para>
                /// </summary>
                [NameInMap("ExpectSpec")]
                [Validation(Required=false)]
                public string ExpectSpec { get; set; }

                /// <summary>
                /// <para>Indicates whether the data about pending orders is returned. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("HasReservationData")]
                [Validation(Required=false)]
                public string HasReservationData { get; set; }

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
                /// <para>CT</para>
                /// </summary>
                [NameInMap("LineOperator")]
                [Validation(Required=false)]
                public string LineOperator { get; set; }

                /// <summary>
                /// <para>The status of the letter of authorization (LOA). Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Applying</b>: The LOA is pending for approval.</description></item>
                /// <item><description><b>Accept</b>: The LOA is approved.</description></item>
                /// <item><description><b>Available</b>: The LOA is available.</description></item>
                /// <item><description><b>Rejected</b>: The LOA is rejected.</description></item>
                /// <item><description><b>Completing</b>: The Express Connect circuit is under construction.</description></item>
                /// <item><description><b>Complete</b>: The Express Connect circuit is installed.</description></item>
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
                /// <para>The payer for the hosted connection. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>PayByPhysicalConnectionOwner</b>: The partner pays for the shared Express Connect circuit.</description></item>
                /// <item><description><b>PayByVirtualPhysicalConnectionOwner</b>: The tenant pays for the shared Express Connect circuit.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PayByPhysicalConnectionOwner</para>
                /// </summary>
                [NameInMap("OrderMode")]
                [Validation(Required=false)]
                public string OrderMode { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account to which the parent Express Connect circuit belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>283117732402483989</para>
                /// </summary>
                [NameInMap("ParentPhysicalConnectionAliUid")]
                [Validation(Required=false)]
                public long? ParentPhysicalConnectionAliUid { get; set; }

                /// <summary>
                /// <para>The ID of the parent Express Connect circuit.</para>
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
                /// <para>The ID of the Express Connect circuit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pc-bp1ciz7ekd2grn1as****</para>
                /// </summary>
                [NameInMap("PhysicalConnectionId")]
                [Validation(Required=false)]
                public string PhysicalConnectionId { get; set; }

                /// <summary>
                /// <para>The ID of the port on the access device.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1/1/1</para>
                /// </summary>
                [NameInMap("PortNumber")]
                [Validation(Required=false)]
                public string PortNumber { get; set; }

                /// <summary>
                /// <para>The port type of the Express Connect circuit. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>100Base-T</b>: 100 Mbit/s copper Ethernet port</description></item>
                /// <item><description><b>1000Base-T</b>: 1,000 Mbit/s copper Ethernet port</description></item>
                /// <item><description><b>1000Base-LX</b>: 1,000 Mbit/s single-mode optical port (10 km)</description></item>
                /// <item><description><b>10GBase-T</b>: 10,000 Mbit/s copper Ethernet port</description></item>
                /// <item><description><b>10GBase-LR</b>: 10,000 Mbit/s single-mode optical port (10 km)</description></item>
                /// <item><description><b>40GBase-LR</b>: 40,000 Mbit/s single-mode optical port</description></item>
                /// <item><description><b>100GBase-LR</b>: 100,000 Mbit/s single-mode optical port</description></item>
                /// </list>
                /// <remarks>
                /// <para>Whether 40GBase-LR and 100GBase-LR ports can be created depends on resource supplies. For more information, contact your account manager.</para>
                /// </remarks>
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
                /// <para>PhysicalConnection</para>
                /// </summary>
                [NameInMap("ProductType")]
                [Validation(Required=false)]
                public string ProductType { get; set; }

                /// <summary>
                /// <para>The ID of the QoS policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qos-bp10s3szn8rgnxuw7****</para>
                /// </summary>
                [NameInMap("QosId")]
                [Validation(Required=false)]
                public string QosId { get; set; }

                /// <summary>
                /// <para>The ID of the standby Express Connect circuit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pc-119mfjzm****</para>
                /// </summary>
                [NameInMap("RedundantPhysicalConnectionId")]
                [Validation(Required=false)]
                public string RedundantPhysicalConnectionId { get; set; }

                /// <summary>
                /// <para>The time when the pending order takes effect.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-02-25T11:01:04Z</para>
                /// </summary>
                [NameInMap("ReservationActiveTime")]
                [Validation(Required=false)]
                public string ReservationActiveTime { get; set; }

                /// <summary>
                /// <para>The billing method of the pending order.</para>
                /// <para>If <b>PayByBandwidth</b> is returned, it indicates that the Express Connect circuit is billed on a pay-by-bandwidth basis.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PayByBandwidth</para>
                /// </summary>
                [NameInMap("ReservationInternetChargeType")]
                [Validation(Required=false)]
                public string ReservationInternetChargeType { get; set; }

                /// <summary>
                /// <para>The type of the pending order.</para>
                /// <para>If the value is <b>RENEW</b>, it indicates that the order is placed for service renewal.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RENEW</para>
                /// </summary>
                [NameInMap("ReservationOrderType")]
                [Validation(Required=false)]
                public string ReservationOrderType { get; set; }

                /// <summary>
                /// <para>The resource group ID to which the instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmwu3k52prgdi</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The specification of the Express Connect circuit.</para>
                /// <para>Unit: <b>G</b> (Gbit/s).</para>
                /// 
                /// <b>Example:</b>
                /// <para>10G</para>
                /// </summary>
                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                /// <summary>
                /// <para>The status of the Express Connect circuit. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Initial</b></description></item>
                /// <item><description><b>Approved</b></description></item>
                /// <item><description><b>Allocating</b></description></item>
                /// <item><description><b>Allocated</b></description></item>
                /// <item><description><b>Confirmed</b></description></item>
                /// <item><description><b>Enabled</b></description></item>
                /// <item><description><b>Rejected</b></description></item>
                /// <item><description><b>Canceled</b></description></item>
                /// <item><description><b>Allocation Failed</b></description></item>
                /// <item><description><b>Terminating</b></description></item>
                /// <item><description><b>Terminated</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Enabled</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The tags that are added to the cluster.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribePhysicalConnectionsResponseBodyPhysicalConnectionSetPhysicalConnectionTypeTags Tags { get; set; }
                public class DescribePhysicalConnectionsResponseBodyPhysicalConnectionSetPhysicalConnectionTypeTags : TeaModel {
                    [NameInMap("tags")]
                    [Validation(Required=false)]
                    public List<DescribePhysicalConnectionsResponseBodyPhysicalConnectionSetPhysicalConnectionTypeTagsTags> Tags { get; set; }
                    public class DescribePhysicalConnectionsResponseBodyPhysicalConnectionSetPhysicalConnectionTypeTagsTags : TeaModel {
                        /// <summary>
                        /// <para>The key of tag N added to the resource. You can specify up to 20 tag keys. The tag key cannot be an empty string.</para>
                        /// <para>The tag key can be up to 64 characters in length and can contain letters, digits, periods (.), underscores (_), and hyphens (-). It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>FinanceDept</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of tag N added to the resource. You can specify up to 20 tag values. The tag value can be an empty string.</para>
                        /// <para>The tag value can be up to 128 characters in length and can contain letters, digits, periods (.), underscores (_), and hyphens (-). It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>FinanceJoshua</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The type of resource to which the Express Connect circuit is connected. Only <b>VPC</b> may be returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VPC</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The number of Express Connect circuits that are established.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("VirtualPhysicalConnectionCount")]
                [Validation(Required=false)]
                public int? VirtualPhysicalConnectionCount { get; set; }

                /// <summary>
                /// <para>The VLAN ID of the shared Express Connect circuit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("VlanId")]
                [Validation(Required=false)]
                public string VlanId { get; set; }

                /// <summary>
                /// <para>The status of the shared Express Connect circuit. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Confirmed</b></description></item>
                /// <item><description><b>UnConfirmed</b></description></item>
                /// <item><description><b>Deleted</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Confirmed</para>
                /// </summary>
                [NameInMap("VpconnStatus")]
                [Validation(Required=false)]
                public string VpconnStatus { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0E6D0EC4-7C91-53E2-9F65-64BF713114B0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
