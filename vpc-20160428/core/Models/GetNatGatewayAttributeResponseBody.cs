// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class GetNatGatewayAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The access mode of the VPC NAT Gateway.</para>
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
            /// <para>The tunnel type. This parameter is returned only when <c>ModeValue</c> is set to <c>tunnel</c>. Valid value:</para>
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
            /// <para>Indicates whether auto-payment is enabled. This parameter is returned only if <b>InstanceChargeType</b> is set to <b>PrePaid</b>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>false</b>: Auto-payment is disabled. After an order is generated, the payment must be completed in the Orders console.</para>
            /// </description></item>
            /// <item><description><para><b>true</b>: Auto-payment is enabled. Payments are automatically completed.</para>
            /// </description></item>
            /// </list>
            /// <para>If <b>InstanceChargeType</b> is set to <b>PostPaid</b>, an empty string is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AutoPay")]
            [Validation(Required=false)]
            public string AutoPay { get; set; }

            /// <summary>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <para>The billing method of the NAT Gateway instance. Valid values:</para>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <list type="bullet">
            /// <item><description><b>PostPaid</b>: pay-as-you-go.</description></item>
            /// </list>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <list type="bullet">
            /// <item><description><b>PrePaid</b>: subscription.</description></item>
            /// </list>
            /// <para>&lt;props=&quot;intl&quot;&gt;</para>
            /// <para>The billing method of the NAT Gateway instance. The value is <b>PostPaid</b> (pay-as-you-go).</para>
            /// 
            /// <b>Example:</b>
            /// <para>PostPaid</para>
            /// </summary>
            [NameInMap("InstanceChargeType")]
            [Validation(Required=false)]
            public string InstanceChargeType { get; set; }

            /// <summary>
            /// <para>The billing method of the NAT Gateway instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>PayBySpec</b>: billed by specification.</para>
            /// </description></item>
            /// <item><description><para><b>PayByLcu</b>: billed by usage.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PayBySpec</para>
            /// </summary>
            [NameInMap("InternetChargeType")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            /// <summary>
            /// <para>The specification of the public NAT gateway instance. This parameter is returned only if <b>InternetChargeType</b> is set to <b>PayBySpec</b>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Small</b></para>
            /// </description></item>
            /// <item><description><para><b>Middle</b></para>
            /// </description></item>
            /// <item><description><para><b>Large</b></para>
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
        /// <para>The business status of the NAT Gateway instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Normal</b>: The instance is running normally.</para>
        /// </description></item>
        /// <item><description><para><b>FinancialLocked</b>: The instance is suspended due to an overdue payment.</para>
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
        /// <para>The creation time of the NAT Gateway instance. The time is in the <c>YYYY-MM-DDThh:mm:ssZ</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-08T12:20:20Z</para>
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// <para>Information about the deletion protection feature.</para>
        /// </summary>
        [NameInMap("DeletionProtectionInfo")]
        [Validation(Required=false)]
        public GetNatGatewayAttributeResponseBodyDeletionProtectionInfo DeletionProtectionInfo { get; set; }
        public class GetNatGatewayAttributeResponseBodyDeletionProtectionInfo : TeaModel {
            /// <summary>
            /// <para>Indicates whether deletion protection is enabled.</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b></para>
            /// </description></item>
            /// <item><description><para><b>false</b></para>
            /// </description></item>
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
        /// <para>The description of the NAT Gateway instance.</para>
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
        /// <item><description><para><b>true</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disabled.</para>
        /// </description></item>
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
        /// <item><description><para><b>true</b></para>
        /// </description></item>
        /// <item><description><para><b>false</b></para>
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
        /// <para>The expiration time of the NAT Gateway instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-26T12:20:20Z</para>
        /// </summary>
        [NameInMap("ExpiredTime")]
        [Validation(Required=false)]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// <para>Information about the DNAT table.</para>
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
        /// <para>Information about the FULLNAT table.</para>
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
        /// <para>The Elastic IP Addresses (EIPs) that are associated with the public NAT gateway.</para>
        /// </summary>
        [NameInMap("IpList")]
        [Validation(Required=false)]
        public List<GetNatGatewayAttributeResponseBodyIpList> IpList { get; set; }
        public class GetNatGatewayAttributeResponseBodyIpList : TeaModel {
            /// <summary>
            /// <para>The ID of the EIP instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eip-bp13e9i2qst4g6jzi****</para>
            /// </summary>
            [NameInMap("AllocationId")]
            [Validation(Required=false)]
            public string AllocationId { get; set; }

            /// <summary>
            /// <para>The EIP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>116.33.XX.XX</para>
            /// </summary>
            [NameInMap("IpAddress")]
            [Validation(Required=false)]
            public string IpAddress { get; set; }

            /// <summary>
            /// <para>The usage status of the EIP.</para>
            /// <list type="bullet">
            /// <item><description><para><b>Idle</b>: Not associated with an SNAT entry or a DNAT entry.</para>
            /// </description></item>
            /// <item><description><para><b>UsedBySnat</b>: Associated with an SNAT entry.</para>
            /// </description></item>
            /// <item><description><para><b>UsedByForward</b>: Associated with a DNAT entry.</para>
            /// </description></item>
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
        /// <para>The session log delivery settings.</para>
        /// </summary>
        [NameInMap("LogDelivery")]
        [Validation(Required=false)]
        public GetNatGatewayAttributeResponseBodyLogDelivery LogDelivery { get; set; }
        public class GetNatGatewayAttributeResponseBodyLogDelivery : TeaModel {
            /// <summary>
            /// <para>The error message that is returned when log delivery fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LogStoreNotExist: logstore session_log_test does not exist</para>
            /// </summary>
            [NameInMap("DeliverLogsErrorMessage")]
            [Validation(Required=false)]
            public string DeliverLogsErrorMessage { get; set; }

            /// <summary>
            /// <para>The status of log delivery. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Success</b>: The logs are delivered successfully.</para>
            /// </description></item>
            /// <item><description><para><b>Failure</b>: The logs failed to be delivered.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Failure</para>
            /// </summary>
            [NameInMap("DeliveryStatus")]
            [Validation(Required=false)]
            public string DeliveryStatus { get; set; }

            /// <summary>
            /// <para>The destination to which session logs are delivered. The value is always
            /// <b>sls</b>, which indicates Log Service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sls</para>
            /// </summary>
            [NameInMap("LogDeliveryType")]
            [Validation(Required=false)]
            public string LogDeliveryType { get; set; }

            /// <summary>
            /// <para>The Log Service Logstore to which session logs are delivered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:log:cn-hangzhou:0000:project/nat_session_log_project/logstore/session_log_test</para>
            /// </summary>
            [NameInMap("LogDestination")]
            [Validation(Required=false)]
            public string LogDestination { get; set; }

        }

        /// <summary>
        /// <para>The name of the NAT Gateway instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the NAT Gateway instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-bp1047e2d4z7kf2ki****</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <para>The type of the public NAT gateway. The value <b>Enhanced</b> indicates an Enhanced NAT Gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enhanced</para>
        /// </summary>
        [NameInMap("NatType")]
        [Validation(Required=false)]
        public string NatType { get; set; }

        /// <summary>
        /// <para>The type of the NAT Gateway. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>internet</b>: A public NAT gateway.</para>
        /// </description></item>
        /// <item><description><para><b>intranet</b>: A VPC NAT Gateway.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>internet</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <para>The private network information about the NAT Gateway instance.</para>
        /// </summary>
        [NameInMap("PrivateInfo")]
        [Validation(Required=false)]
        public GetNatGatewayAttributeResponseBodyPrivateInfo PrivateInfo { get; set; }
        public class GetNatGatewayAttributeResponseBodyPrivateInfo : TeaModel {
            /// <summary>
            /// <para>The ID of the elastic network interface instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eni-bp1cmgtoaka8vfyg****</para>
            /// </summary>
            [NameInMap("EniInstanceId")]
            [Validation(Required=false)]
            public string EniInstanceId { get; set; }

            /// <summary>
            /// <para>The ID of the availability zone to which the NAT Gateway instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-qingdao-b</para>
            /// </summary>
            [NameInMap("IzNo")]
            [Validation(Required=false)]
            public string IzNo { get; set; }

            /// <summary>
            /// <para>The maximum bandwidth, in Mbps.</para>
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
            /// <para>The ID of the vSwitch to which the NAT Gateway instance belongs.</para>
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
        /// <item><description><para><b>true</b>: PrivateLink is supported.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: PrivateLink is not supported.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PrivateLinkEnabled")]
        [Validation(Required=false)]
        public bool? PrivateLinkEnabled { get; set; }

        /// <summary>
        /// <para>The mode of the PrivateLink service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>FullNat</b>: FULLNAT mode.</para>
        /// </description></item>
        /// <item><description><para><b>Geneve</b>: Geneve mode.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FullNat</para>
        /// </summary>
        [NameInMap("PrivateLinkMode")]
        [Validation(Required=false)]
        public string PrivateLinkMode { get; set; }

        /// <summary>
        /// <para>The region ID of the NAT Gateway instance.</para>
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
        /// <para>Information about the SNAT table.</para>
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
        /// <para>The status of the NAT Gateway instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Creating</b>: Being created. This is an asynchronous operation.</para>
        /// </description></item>
        /// <item><description><para><b>Available</b>: Available. This is the steady state of the NAT Gateway after creation.</para>
        /// </description></item>
        /// <item><description><para><b>Modifying</b>: Being modified. This is an asynchronous operation.</para>
        /// </description></item>
        /// <item><description><para><b>Deleting</b>: Being deleted. This is an asynchronous operation.</para>
        /// </description></item>
        /// <item><description><para><b>Converting</b>: Being converted to an Enhanced NAT Gateway. This is an asynchronous operation.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the VPC to which the NAT Gateway instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp15zckdt37pq72z****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
