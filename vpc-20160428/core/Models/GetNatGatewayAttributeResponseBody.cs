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
            /// <item><description><para><b>route</b>: route mode.</para>
            /// </description></item>
            /// <item><description><para><b>tunnel</b>: tunnel mode.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>route</para>
            /// </summary>
            [NameInMap("ModeValue")]
            [Validation(Required=false)]
            public string ModeValue { get; set; }

            /// <summary>
            /// <para>The tunnel mode type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>geneve</b>: Geneve type.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>geneve</para>
            /// </summary>
            [NameInMap("TunnelType")]
            [Validation(Required=false)]
            public string TunnelType { get; set; }

        }

        [NameInMap("AvailabilityMode")]
        [Validation(Required=false)]
        public string AvailabilityMode { get; set; }

        /// <summary>
        /// <para>The billing configuration information.</para>
        /// </summary>
        [NameInMap("BillingConfig")]
        [Validation(Required=false)]
        public GetNatGatewayAttributeResponseBodyBillingConfig BillingConfig { get; set; }
        public class GetNatGatewayAttributeResponseBodyBillingConfig : TeaModel {
            /// <summary>
            /// <para>Indicates whether automatic payment is enabled. When the value of <b>InstanceChargeType</b> is <b>PrePaid</b>, the following values are returned:</para>
            /// <list type="bullet">
            /// <item><description><para><b>false</b>: Automatic payment is not enabled. After an order is generated, go to the Order Center to complete the payment.</para>
            /// </description></item>
            /// <item><description><para><b>true</b>: Automatic payment is enabled. The order is automatically paid.</para>
            /// </description></item>
            /// </list>
            /// <para>When the value of <b>InstanceChargeType</b> is <b>PostPaid</b>, an empty value is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AutoPay")]
            [Validation(Required=false)]
            public string AutoPay { get; set; }

            /// <summary>
            /// <para>&lt;props=&quot;china&quot;&gt;The billing method of the NAT gateway instance. Valid values:</para>
            /// <para>&lt;props=&quot;china&quot;&gt;- <b>PostPaid</b>: pay-as-you-go.</para>
            /// <para>&lt;props=&quot;china&quot;&gt;- <b>PrePaid</b>: subscription.</para>
            /// <para>&lt;props=&quot;intl&quot;&gt;The billing method of the NAT gateway instance. Valid values: <b>PostPaid</b> (pay-as-you-go).</para>
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
            /// <item><description><b>PayBySpec</b>: billed by defined specifications.</description></item>
            /// <item><description><b>PayByLcu</b>: billed by usage.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PayBySpec</para>
            /// </summary>
            [NameInMap("InternetChargeType")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            /// <summary>
            /// <para>The specification of the Internet NAT gateway instance. When <b>InternetChargeType</b> is <b>PayBySpec</b>, the following values are returned:</para>
            /// <list type="bullet">
            /// <item><description><b>Small</b>: small.</description></item>
            /// <item><description><b>Middle</b>: medium.</description></item>
            /// <item><description><b>Large</b>: large.
            /// When <b>InternetChargeType</b> is <b>PayByLcu</b>, an empty value is returned.</description></item>
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
        /// <para>The business status of the NAT gateway. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b>: Normal.</description></item>
        /// <item><description><b>FinancialLocked</b>: Locked due to overdue payment.</description></item>
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
            /// <para>Indicates whether deletion protection is enabled.</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Deletion protection is enabled.</description></item>
            /// <item><description><b>false</b>: Deletion protection is not enabled.</description></item>
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
        /// <para>The description of the NAT gateway instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NAT</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Indicates whether the gateway traffic monitoring feature is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The gateway traffic monitoring feature is enabled.</description></item>
        /// <item><description><b>false</b>: The gateway traffic monitoring feature is not enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EcsMetricEnabled")]
        [Validation(Required=false)]
        public bool? EcsMetricEnabled { get; set; }

        /// <summary>
        /// <para>Indicates whether session logging is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Session logging is enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Session logging is disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableSessionLog")]
        [Validation(Required=false)]
        public bool? EnableSessionLog { get; set; }

        /// <summary>
        /// <para>The expiration time of the NAT gateway instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-26T12:20:20Z</para>
        /// </summary>
        [NameInMap("ExpiredTime")]
        [Validation(Required=false)]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// <para>The DNAT table information.</para>
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
        /// <para>The FULLNAT table information.</para>
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
        /// <para>The list of elastic IP addresses (EIPs) associated with the Internet NAT gateway.</para>
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
            /// <para>The association status of the EIP bound to the Internet NAT gateway instance.</para>
            /// <list type="bullet">
            /// <item><description><b>idle</b>: The EIP is not associated with any SNAT entry or DNAT entry.</description></item>
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
        /// <para>The session log configuration information.</para>
        /// </summary>
        [NameInMap("LogDelivery")]
        [Validation(Required=false)]
        public GetNatGatewayAttributeResponseBodyLogDelivery LogDelivery { get; set; }
        public class GetNatGatewayAttributeResponseBodyLogDelivery : TeaModel {
            /// <summary>
            /// <para>The error message for session log writing failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LogStoreNotExist: logstore session_log_test does not exist</para>
            /// </summary>
            [NameInMap("DeliverLogsErrorMessage")]
            [Validation(Required=false)]
            public string DeliverLogsErrorMessage { get; set; }

            /// <summary>
            /// <para>The status of session log writing. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Succsess</b>: Succeeded.</description></item>
            /// <item><description><b>Failure</b>: Failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Failure</para>
            /// </summary>
            [NameInMap("DeliveryStatus")]
            [Validation(Required=false)]
            public string DeliveryStatus { get; set; }

            /// <summary>
            /// <para>The destination type for session log delivery. Valid values:
            /// <b>sls</b>: Simple Log Service (SLS).</para>
            /// 
            /// <b>Example:</b>
            /// <para>sls</para>
            /// </summary>
            [NameInMap("LogDeliveryType")]
            [Validation(Required=false)]
            public string LogDeliveryType { get; set; }

            /// <summary>
            /// <para>The destination address to which session logs are written.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:log:cn-hangzhou:0000:project/nat_session_log_project/logstore/session_log_test</para>
            /// </summary>
            [NameInMap("LogDestination")]
            [Validation(Required=false)]
            public string LogDestination { get; set; }

        }

        /// <summary>
        /// <para>The name of the NAT gateway instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the NAT gateway instance.</para>
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
        /// <para>The private network information of the NAT gateway instance.</para>
        /// </summary>
        [NameInMap("PrivateInfo")]
        [Validation(Required=false)]
        public GetNatGatewayAttributeResponseBodyPrivateInfo PrivateInfo { get; set; }
        public class GetNatGatewayAttributeResponseBodyPrivateInfo : TeaModel {
            /// <summary>
            /// <para>The instance ID of the elastic network interfaces (ENIs) network interface controller (NIC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>eni-bp1cmgtoaka8vfyg****</para>
            /// </summary>
            [NameInMap("EniInstanceId")]
            [Validation(Required=false)]
            public string EniInstanceId { get; set; }

            /// <summary>
            /// <para>The zone to which the NAT gateway instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-qingdao-b</para>
            /// </summary>
            [NameInMap("IzNo")]
            [Validation(Required=false)]
            public string IzNo { get; set; }

            /// <summary>
            /// <para>The maximum bandwidth value. Unit: Mbit/s.</para>
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
            /// <para>The ID of the vSwitch to which the NAT gateway instance belongs.</para>
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
        /// <para>The PrivateLink service conversion mode. Valid values:</para>
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
        /// <para>The region ID of the NAT gateway instance.</para>
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
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4ph****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The SNAT table information.</para>
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
        /// <item><description><b>Creating</b>: The NAT gateway is being created. The creation of a NAT gateway is an asynchronous operation. The NAT gateway remains in the <b>Creating</b> state until the creation is complete.</description></item>
        /// <item><description><b>Available</b>: The NAT gateway is available. This is a stable state after the NAT gateway is created.</description></item>
        /// <item><description><b>Modifying</b>: The NAT gateway is being modified. The modification of a NAT gateway is an asynchronous operation. The NAT gateway remains in the <b>Modifying</b> state during the modification.</description></item>
        /// <item><description><b>Deleting</b>: The NAT gateway is being deleted. The deletion of a NAT gateway is an asynchronous operation. The NAT gateway remains in the <b>Deleting</b> state during the deletion.</description></item>
        /// <item><description><b>Converting</b>: The NAT gateway is being converted. The conversion from a standard NAT gateway to an enhanced NAT gateway is an asynchronous operation. The NAT gateway remains in the <b>Converting</b> state during the conversion.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the VPC to which the NAT gateway instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp15zckdt37pq72z****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
