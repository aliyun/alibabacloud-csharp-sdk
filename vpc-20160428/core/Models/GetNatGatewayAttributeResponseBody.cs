// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class GetNatGatewayAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The access mode for reverse access to the VPC NAT gateway.</para>
        /// </summary>
        [NameInMap("AccessMode")]
        [Validation(Required=false)]
        public GetNatGatewayAttributeResponseBodyAccessMode AccessMode { get; set; }
        public class GetNatGatewayAttributeResponseBodyAccessMode : TeaModel {
            /// <summary>
            /// <para>The access mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>route</b>: route mode.</description></item>
            /// <item><description><b>tunnel</b>: tunnel mode.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>route</para>
            /// </summary>
            [NameInMap("ModeValue")]
            [Validation(Required=false)]
            public string ModeValue { get; set; }

            /// <summary>
            /// <para>The tunnel type. Valid value:</para>
            /// <list type="bullet">
            /// <item><description><b>geneve</b>: Geneve.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>geneve</para>
            /// </summary>
            [NameInMap("TunnelType")]
            [Validation(Required=false)]
            public string TunnelType { get; set; }

        }

        /// <summary>
        /// <para>The disaster recovery type of the NAT gateway. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CrossAZ</b>: cross-zone disaster recovery.</description></item>
        /// <item><description><b>SingleAZ</b>: single-zone disaster recovery.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CrossAZ</para>
        /// </summary>
        [NameInMap("AvailabilityMode")]
        [Validation(Required=false)]
        public string AvailabilityMode { get; set; }

        /// <summary>
        /// <para>The billing configuration.</para>
        /// </summary>
        [NameInMap("BillingConfig")]
        [Validation(Required=false)]
        public GetNatGatewayAttributeResponseBodyBillingConfig BillingConfig { get; set; }
        public class GetNatGatewayAttributeResponseBodyBillingConfig : TeaModel {
            /// <summary>
            /// <para>Indicates whether automatic payment is enabled. This parameter is returned when the <b>InstanceChargeType</b> parameter is set to <b>PrePaid</b>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>false</b>: Automatic payment is disabled. You must complete the payment in the User Center after the order is generated.</description></item>
            /// <item><description><b>true</b>: Automatic payment is enabled. The order is automatically paid.</description></item>
            /// </list>
            /// <para>If the <b>InstanceChargeType</b> parameter is set to <b>PostPaid</b>, this parameter is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AutoPay")]
            [Validation(Required=false)]
            public string AutoPay { get; set; }

            /// <summary>
            /// <para>&lt;props=&quot;china&quot;&gt;The billing method of the NAT gateway. Valid values:</para>
            /// <para>&lt;props=&quot;china&quot;&gt;- <b>PostPaid</b>: pay-as-you-go.</para>
            /// <para>&lt;props=&quot;china&quot;&gt;- <b>PrePaid</b>: subscription.</para>
            /// <para>&lt;props=&quot;intl&quot;&gt;The billing method of the NAT gateway. Valid value: <b>PostPaid</b> (pay-as-you-go).</para>
            /// 
            /// <b>Example:</b>
            /// <para>PostPaid</para>
            /// </summary>
            [NameInMap("InstanceChargeType")]
            [Validation(Required=false)]
            public string InstanceChargeType { get; set; }

            /// <summary>
            /// <para>The billing type of the NAT gateway instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PayBySpec</b>: billing by defined specifications.</description></item>
            /// <item><description><b>PayByLcu</b>: billing by usage.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PayBySpec</para>
            /// </summary>
            [NameInMap("InternetChargeType")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            /// <summary>
            /// <para>The specification of the Internet NAT gateway. This parameter is returned when the <b>InternetChargeType</b> parameter is set to <b>PayBySpec</b>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Small</b>: small.</description></item>
            /// <item><description><b>Middle</b>: medium.</description></item>
            /// <item><description><b>Large</b>: large.</description></item>
            /// </list>
            /// <para>If the <b>InternetChargeType</b> parameter is set to <b>PayByLcu</b>, this parameter is empty.</para>
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
        /// <item><description><b>Normal</b>: The NAT gateway is running normally.</description></item>
        /// <item><description><b>FinancialLocked</b>: The NAT gateway is locked due to an overdue payment.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("BusinessStatus")]
        [Validation(Required=false)]
        public string BusinessStatus { get; set; }

        /// <summary>
        /// <para>The time when the NAT gateway was created. The time is displayed in the YYYY-MM-DDThh:mm:ssZ format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-08T12:20:20Z</para>
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// <para>The deletion protection information.</para>
        /// </summary>
        [NameInMap("DeletionProtectionInfo")]
        [Validation(Required=false)]
        public GetNatGatewayAttributeResponseBodyDeletionProtectionInfo DeletionProtectionInfo { get; set; }
        public class GetNatGatewayAttributeResponseBodyDeletionProtectionInfo : TeaModel {
            /// <summary>
            /// <para>Indicates whether deletion protection is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Deletion protection is enabled.</description></item>
            /// <item><description><b>false</b>: Deletion protection is disabled.</description></item>
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
        /// <item><description><b>true</b>: The traffic monitoring feature is enabled.</description></item>
        /// <item><description><b>false</b>: The traffic monitoring feature is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EcsMetricEnabled")]
        [Validation(Required=false)]
        public bool? EcsMetricEnabled { get; set; }

        /// <summary>
        /// <para>Indicates whether the session log feature is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The session log feature is enabled.</description></item>
        /// <item><description><b>false</b>: The session log feature is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableSessionLog")]
        [Validation(Required=false)]
        public bool? EnableSessionLog { get; set; }

        /// <summary>
        /// <para>The expiration time of the NAT gateway. The time is displayed in the YYYY-MM-DDThh:mm:ssZ format in UTC.</para>
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
            /// <para>The instance ID of the EIP.</para>
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
            /// <para>The association status of the EIP that is associated with the Internet NAT gateway. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>idle</b>: The EIP is not associated with an SNAT entry or a DNAT entry.</description></item>
            /// <item><description><b>UsedBySnatTable</b>: The EIP is associated with an SNAT entry.</description></item>
            /// <item><description><b>UsedByForwardTable</b>: The EIP is associated with a DNAT entry.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>idle</para>
            /// </summary>
            [NameInMap("UsingStatus")]
            [Validation(Required=false)]
            public string UsingStatus { get; set; }

        }

        /// <summary>
        /// <para>The session log configuration.</para>
        /// </summary>
        [NameInMap("LogDelivery")]
        [Validation(Required=false)]
        public GetNatGatewayAttributeResponseBodyLogDelivery LogDelivery { get; set; }
        public class GetNatGatewayAttributeResponseBodyLogDelivery : TeaModel {
            /// <summary>
            /// <para>The error message returned when session log delivery fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LogStoreNotExist: logstore session_log_test does not exist</para>
            /// </summary>
            [NameInMap("DeliverLogsErrorMessage")]
            [Validation(Required=false)]
            public string DeliverLogsErrorMessage { get; set; }

            /// <summary>
            /// <para>The delivery status of session logs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Succsess</b>: The delivery is successful.</description></item>
            /// <item><description><b>Failure</b>: The delivery failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Failure</para>
            /// </summary>
            [NameInMap("DeliveryStatus")]
            [Validation(Required=false)]
            public string DeliveryStatus { get; set; }

            /// <summary>
            /// <para>The destination type for session log delivery. Valid value:</para>
            /// <list type="bullet">
            /// <item><description><b>sls</b>: Simple Log Service.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>sls</para>
            /// </summary>
            [NameInMap("LogDeliveryType")]
            [Validation(Required=false)]
            public string LogDeliveryType { get; set; }

            /// <summary>
            /// <para>The destination address for session log delivery.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:log:cn-hangzhou:0000:project/nat_session_log_project/logstore/session_log_test</para>
            /// </summary>
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
        /// <para>The type of the Internet NAT gateway. The value is <b>Enhanced</b>, which indicates an enhanced NAT gateway.</para>
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
        /// <item><description><b>internet</b>: Internet NAT gateway.</description></item>
        /// <item><description><b>intranet</b>: VPC NAT gateway.</description></item>
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
            /// <para>The instance ID of the elastic network interface controller (NIC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>eni-bp1cmgtoaka8vfyg****</para>
            /// </summary>
            [NameInMap("EniInstanceId")]
            [Validation(Required=false)]
            public string EniInstanceId { get; set; }

            /// <summary>
            /// <para>The zone to which the NAT gateway belongs.</para>
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
        /// <para>Indicates whether PrivateLink is supported. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: PrivateLink is supported.</description></item>
        /// <item><description><b>false</b>: PrivateLink is not supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PrivateLinkEnabled")]
        [Validation(Required=false)]
        public bool? PrivateLinkEnabled { get; set; }

        /// <summary>
        /// <para>The PrivateLink service translation mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>FullNat</b>: FULLNAT mode.</description></item>
        /// <item><description><b>Geneve</b>: Geneve mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FullNat</para>
        /// </summary>
        [NameInMap("PrivateLinkMode")]
        [Validation(Required=false)]
        public string PrivateLinkMode { get; set; }

        /// <summary>
        /// <para>The region ID of the NAT gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-qingdao</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
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
        /// <item><description><b>Creating</b>: The NAT gateway is being created. Creating a NAT gateway is an asynchronous operation. The NAT gateway remains in the <b>Creating</b> state until the operation is complete.</description></item>
        /// <item><description><b>Available</b>: The NAT gateway is available. This is the stable state of a NAT gateway after it is created.</description></item>
        /// <item><description><b>Modifying</b>: The NAT gateway is being modified. Modifying the specifications of a NAT gateway is an asynchronous operation. The NAT gateway remains in the <b>Modifying</b> state until the operation is complete.</description></item>
        /// <item><description><b>Deleting</b>: The NAT gateway is being deleted. Deleting a NAT gateway is an asynchronous operation. The NAT gateway remains in the <b>Deleting</b> state until the operation is complete.</description></item>
        /// <item><description><b>Converting</b>: The NAT gateway is being upgraded. Upgrading a standard NAT gateway to an enhanced NAT gateway is an asynchronous operation. The NAT gateway remains in the <b>Converting</b> state until the operation is complete.</description></item>
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
