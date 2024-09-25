// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class GetNatGatewayAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The billing information.</para>
        /// </summary>
        [NameInMap("BillingConfig")]
        [Validation(Required=false)]
        public GetNatGatewayAttributeResponseBodyBillingConfig BillingConfig { get; set; }
        public class GetNatGatewayAttributeResponseBodyBillingConfig : TeaModel {
            /// <summary>
            /// <para>Indicates whether automatic payment is enabled. If the <b>InstanceChargeType</b> parameter is set to <b>PrePaid</b>, one of the following values is returned:</para>
            /// <list type="bullet">
            /// <item><description><b>false</b>: disabled. After an order is generated, you must go to the Order Center to complete the payment.</description></item>
            /// <item><description><b>true</b>: enabled. Payments are automatically completed.</description></item>
            /// </list>
            /// <para>The return value of this parameter is empty if <b>InstanceChargeType</b> is set to <b>PostPaid</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AutoPay")]
            [Validation(Required=false)]
            public string AutoPay { get; set; }

            /// <summary>
            /// <para>The billing method of the NAT gateway. The value is set to <b>PostPaid</b>, which indicates the pay-as-you-go billing method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PostPaid</para>
            /// </summary>
            [NameInMap("InstanceChargeType")]
            [Validation(Required=false)]
            public string InstanceChargeType { get; set; }

            /// <summary>
            /// <para>The metering method of the NAT gateway. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PayBySpec</b>: pay-by-specification</description></item>
            /// <item><description><b>PayByLcu</b>: pay-by-CU</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PayBySpec</para>
            /// </summary>
            [NameInMap("InternetChargeType")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            /// <summary>
            /// <para>The specification of the Internet NAT gateway. If the <b>InternetChargeType</b> parameter is set to <b>PayBySpec</b>, one of the following values is returned:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Small</b>: small</para>
            /// </description></item>
            /// <item><description><para><b>Middle</b>: medium</para>
            /// </description></item>
            /// <item><description><para><b>Large</b>: large</para>
            /// <para>The return value of this parameter is empty if <b>InternetChargeType</b> is set to <b>PayByLcu</b>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Small</para>
            /// </summary>
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }

        }

        /// <summary>
        /// <para>The service status of the NAT gateway. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b>: normal</description></item>
        /// <item><description><b>FinancialLocked</b>: locked due to overdue payments</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("BusinessStatus")]
        [Validation(Required=false)]
        public string BusinessStatus { get; set; }

        /// <summary>
        /// <para>The time when the NAT gateway was created. Format: YYYY-MM-DDThh:mm:ssZ.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-08T12:20:20Z</para>
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// <para>The information about the deletion protection feature.</para>
        /// </summary>
        [NameInMap("DeletionProtectionInfo")]
        [Validation(Required=false)]
        public GetNatGatewayAttributeResponseBodyDeletionProtectionInfo DeletionProtectionInfo { get; set; }
        public class GetNatGatewayAttributeResponseBodyDeletionProtectionInfo : TeaModel {
            /// <summary>
            /// <para>Indicates whether deletion protection is enabled.</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

        }

        /// <summary>
        /// <para>The description of the NAT gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NAT</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Indicates whether the traffic monitoring feature is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EcsMetricEnabled")]
        [Validation(Required=false)]
        public bool? EcsMetricEnabled { get; set; }

        [NameInMap("EnableSessionLog")]
        [Validation(Required=false)]
        public bool? EnableSessionLog { get; set; }

        /// <summary>
        /// <para>The time when the NAT gateway expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-26T12:20:20Z</para>
        /// </summary>
        [NameInMap("ExpiredTime")]
        [Validation(Required=false)]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// <para>The information about the DNAT table.</para>
        /// </summary>
        [NameInMap("ForwardTable")]
        [Validation(Required=false)]
        public GetNatGatewayAttributeResponseBodyForwardTable ForwardTable { get; set; }
        public class GetNatGatewayAttributeResponseBodyForwardTable : TeaModel {
            /// <summary>
            /// <para>The number of DNAT entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ForwardEntryCount")]
            [Validation(Required=false)]
            public int? ForwardEntryCount { get; set; }

            /// <summary>
            /// <para>The ID of the DNAT table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ftb-uf6gj3mhsg94qsqst****</para>
            /// </summary>
            [NameInMap("ForwardTableId")]
            [Validation(Required=false)]
            public string ForwardTableId { get; set; }

        }

        /// <summary>
        /// <para>The information about the FULLNAT table.</para>
        /// </summary>
        [NameInMap("FullNatTable")]
        [Validation(Required=false)]
        public GetNatGatewayAttributeResponseBodyFullNatTable FullNatTable { get; set; }
        public class GetNatGatewayAttributeResponseBodyFullNatTable : TeaModel {
            /// <summary>
            /// <para>The number of FULLNAT entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FullNatEntryCount")]
            [Validation(Required=false)]
            public long? FullNatEntryCount { get; set; }

            /// <summary>
            /// <para>The ID of the FULLNAT table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fulltb-gw88z7hhlv43rmb26****</para>
            /// </summary>
            [NameInMap("FullNatTableId")]
            [Validation(Required=false)]
            public string FullNatTableId { get; set; }

        }

        /// <summary>
        /// <para>The elastic IP addresses (EIPs) that are associated with the Internet NAT gateway.</para>
        /// </summary>
        [NameInMap("IpList")]
        [Validation(Required=false)]
        public List<GetNatGatewayAttributeResponseBodyIpList> IpList { get; set; }
        public class GetNatGatewayAttributeResponseBodyIpList : TeaModel {
            /// <summary>
            /// <para>The ID of the EIP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eip-bp13e9i2qst4g6jzi****</para>
            /// </summary>
            [NameInMap("AllocationId")]
            [Validation(Required=false)]
            public string AllocationId { get; set; }

            /// <summary>
            /// <para>The IP address of the EIP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>116.33.XX.XX</para>
            /// </summary>
            [NameInMap("IpAddress")]
            [Validation(Required=false)]
            public string IpAddress { get; set; }

            /// <summary>
            /// <para>The association status of the EIP.</para>
            /// <list type="bullet">
            /// <item><description><b>idle</b>: The EIP is not specified in an SNAT entry or a DNAT entry.</description></item>
            /// <item><description><b>UsedBySnatTable</b>: The EIP is specified in an SNAT entry.</description></item>
            /// <item><description><b>UsedByForwardTable</b>: The EIP is specified in a DNAT entry.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>idle</para>
            /// </summary>
            [NameInMap("UsingStatus")]
            [Validation(Required=false)]
            public string UsingStatus { get; set; }

        }

        [NameInMap("LogDelivery")]
        [Validation(Required=false)]
        public GetNatGatewayAttributeResponseBodyLogDelivery LogDelivery { get; set; }
        public class GetNatGatewayAttributeResponseBodyLogDelivery : TeaModel {
            [NameInMap("DeliverLogsErrorMessage")]
            [Validation(Required=false)]
            public string DeliverLogsErrorMessage { get; set; }

            [NameInMap("DeliveryStatus")]
            [Validation(Required=false)]
            public string DeliveryStatus { get; set; }

            [NameInMap("LogDeliveryType")]
            [Validation(Required=false)]
            public string LogDeliveryType { get; set; }

            [NameInMap("LogDestination")]
            [Validation(Required=false)]
            public string LogDestination { get; set; }

        }

        /// <summary>
        /// <para>The name of the NAT gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the NAT gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-bp1047e2d4z7kf2ki****</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <para>The type of the Internet NAT gateway. Only <b>Enhanced</b> is returned, which indicates an enhanced Internet NAT gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enhanced</para>
        /// </summary>
        [NameInMap("NatType")]
        [Validation(Required=false)]
        public string NatType { get; set; }

        /// <summary>
        /// <para>The type of the NAT gateway. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>internet</b>: an Internet NAT gateway</description></item>
        /// <item><description><b>intranet</b>: a VPC NAT gateway</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>internet</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <para>The private network information about the NAT gateway.</para>
        /// </summary>
        [NameInMap("PrivateInfo")]
        [Validation(Required=false)]
        public GetNatGatewayAttributeResponseBodyPrivateInfo PrivateInfo { get; set; }
        public class GetNatGatewayAttributeResponseBodyPrivateInfo : TeaModel {
            /// <summary>
            /// <para>The ID of the elastic network interface (ENI).</para>
            /// 
            /// <b>Example:</b>
            /// <para>eni-bp1cmgtoaka8vfyg****</para>
            /// </summary>
            [NameInMap("EniInstanceId")]
            [Validation(Required=false)]
            public string EniInstanceId { get; set; }

            /// <summary>
            /// <para>The zone where the NAT gateway is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-qingdao-b</para>
            /// </summary>
            [NameInMap("IzNo")]
            [Validation(Required=false)]
            public string IzNo { get; set; }

            /// <summary>
            /// <para>The maximum bandwidth. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5120</para>
            /// </summary>
            [NameInMap("MaxBandwidth")]
            [Validation(Required=false)]
            public int? MaxBandwidth { get; set; }

            /// <summary>
            /// <para>The private IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("PrivateIpAddress")]
            [Validation(Required=false)]
            public string PrivateIpAddress { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch to which the NAT gateway belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1s2laxhdf9ayjbo***</para>
            /// </summary>
            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the NAT gateway supports PrivateLink. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PrivateLinkEnabled")]
        [Validation(Required=false)]
        public bool? PrivateLinkEnabled { get; set; }

        /// <summary>
        /// <para>The mode that is used by PrivateLink. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>FullNat</b>: the FULLNAT mode</description></item>
        /// <item><description><b>Geneve</b>: the GENEVE mode</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FullNat</para>
        /// </summary>
        [NameInMap("PrivateLinkMode")]
        [Validation(Required=false)]
        public string PrivateLinkMode { get; set; }

        /// <summary>
        /// <para>The ID of the region where the NAT gateway is deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-qingdao</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4EC47282-1B74-4534-BD0E-403F3EE64CAF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4ph****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The information about the SNAT table.</para>
        /// </summary>
        [NameInMap("SnatTable")]
        [Validation(Required=false)]
        public GetNatGatewayAttributeResponseBodySnatTable SnatTable { get; set; }
        public class GetNatGatewayAttributeResponseBodySnatTable : TeaModel {
            /// <summary>
            /// <para>The number of SNAT entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SnatEntryCount")]
            [Validation(Required=false)]
            public int? SnatEntryCount { get; set; }

            /// <summary>
            /// <para>The ID of the SNAT table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>stb-SnatTableIds****</para>
            /// </summary>
            [NameInMap("SnatTableId")]
            [Validation(Required=false)]
            public string SnatTableId { get; set; }

        }

        /// <summary>
        /// <para>The status of the NAT gateway. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Creating</b>: being created. The operation to create a NAT gateway is asynchronous. The NAT gateway remains in the <b>Creating</b> state until it is created.</description></item>
        /// <item><description><b>Available</b>: available. After a NAT gateway is created, it remains in a stable state.</description></item>
        /// <item><description><b>Modifying</b>: being modified. The operation to upgrade or downgrade a NAT gateway is asynchronous. The NAT gateway remains in the <b>Modifying</b> state until it is upgraded or downgraded.</description></item>
        /// <item><description><b>Deleting</b>: being deleted. The operation to delete a NAT gateway is asynchronous. The NAT gateway remains in the <b>Deleting</b> state until it is deleted.</description></item>
        /// <item><description><b>Converting</b>: being converted. The operation to convert a standard NAT gateway to an enhanced NAT gateway is asynchronous. The NAT gateway remains in the <b>Converting</b> state until it is converted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the VPC to which the NAT gateway belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp15zckdt37pq72z****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
