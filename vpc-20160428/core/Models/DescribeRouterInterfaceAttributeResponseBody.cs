// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeRouterInterfaceAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the access point.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ap-cn-qingdao-ls-A</para>
        /// </summary>
        [NameInMap("AccessPointId")]
        [Validation(Required=false)]
        public string AccessPointId { get; set; }

        /// <summary>
        /// <para>The bandwidth of the router interface. Unit: Mbps.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The business status of the router interface. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Normal</b>: normal.</para>
        /// </description></item>
        /// <item><description><para><b>FinancialLocked</b>: locked due to overdue payment.</para>
        /// </description></item>
        /// <item><description><para><b>SecurityLocked</b>: locked due to security risk control.</para>
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
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AfterPay</b>: pay-as-you-go.</description></item>
        /// <item><description><b>PrePaid</b>: subscription.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AfterPay</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The time when the connection was established. The time is displayed in the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-04-14T08:58:04Z</para>
        /// </summary>
        [NameInMap("ConnectedTime")]
        [Validation(Required=false)]
        public string ConnectedTime { get; set; }

        /// <summary>
        /// <para>The time when the router interface was created. The time is displayed in the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-04-14T08:57:24Z</para>
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// <para>Indicates whether this is a cross-border connection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b>: No.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: Yes.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CrossBorder")]
        [Validation(Required=false)]
        public bool? CrossBorder { get; set; }

        /// <summary>
        /// <para>The description of the router interface.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Peer interface</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The end time of the data retrieval. The time is displayed in the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2999-09-08T16:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Indicates whether the router interface on the VBR was created in fast link mode. Fast link mode allows the router interfaces on both the VBR and VPC sides to automatically connect after creation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes.</description></item>
        /// <item><description><b>false</b> (default): No.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only when <b>RouterType</b> is set to <b>VBR</b> and <b>OppositeRouterType</b> is set to <b>VRouter</b>.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>When <b>FastLinkMode</b> is set to <b>true</b>, <b>Role</b> must be set to <b>InitiatingSide</b>, and <b>AccessPointId</b>, <b>OppositeRouterType</b>, <b>OpppsiteRouterId</b>, and <b>OppositeInterfaceOwnerId</b> are required.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("FastLinkMode")]
        [Validation(Required=false)]
        public string FastLinkMode { get; set; }

        /// <summary>
        /// <para>The time when the router interface was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-04-28T10:02:12Z</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>Indicates whether renewal data exists. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b>: No.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: Yes.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("HasReservationData")]
        [Validation(Required=false)]
        public string HasReservationData { get; set; }

        /// <summary>
        /// <para>The health check rate. Unit: seconds. This value indicates the interval between consecutive probe packets sent during a health check.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("HcRate")]
        [Validation(Required=false)]
        public int? HcRate { get; set; }

        /// <summary>
        /// <para>The health check threshold. This value indicates the number of probe packets sent during a health check. Unit: packets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("HcThreshold")]
        [Validation(Required=false)]
        public int? HcThreshold { get; set; }

        /// <summary>
        /// <para>The health check source IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.1.XX.XX</para>
        /// </summary>
        [NameInMap("HealthCheckSourceIp")]
        [Validation(Required=false)]
        public string HealthCheckSourceIp { get; set; }

        /// <summary>
        /// <para>The health check status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Abnormal</b>: abnormal.</description></item>
        /// <item><description><b>Normal</b>: normal.</description></item>
        /// <item><description><b>NoRedundantRoute</b>: no redundant route configured.</description></item>
        /// <item><description><b>NoHealthCheckConfig</b>: no health check configured.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("HealthCheckStatus")]
        [Validation(Required=false)]
        public string HealthCheckStatus { get; set; }

        /// <summary>
        /// <para>The health check target IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.2.XX.XX</para>
        /// </summary>
        [NameInMap("HealthCheckTargetIp")]
        [Validation(Required=false)]
        public string HealthCheckTargetIp { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The name of the router interface.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RouterInterface1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the peer access point.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ap-cn-qingdao-ls-B</para>
        /// </summary>
        [NameInMap("OppositeAccessPointId")]
        [Validation(Required=false)]
        public string OppositeAccessPointId { get; set; }

        /// <summary>
        /// <para>The bandwidth of the peer router interface. Unit: Mbps.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OppositeBandwidth")]
        [Validation(Required=false)]
        public int? OppositeBandwidth { get; set; }

        /// <summary>
        /// <para>The business status of the peer router interface. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b>: normal.</description></item>
        /// <item><description><b>FinancialLocked</b>: locked due to overdue payment.</description></item>
        /// <item><description><b>SecurityLocked</b>: locked due to security risk control.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("OppositeInterfaceBusinessStatus")]
        [Validation(Required=false)]
        public string OppositeInterfaceBusinessStatus { get; set; }

        /// <summary>
        /// <para>The ID of the peer router interface.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ri-bp1xkrzttximaoxbl****</para>
        /// </summary>
        [NameInMap("OppositeInterfaceId")]
        [Validation(Required=false)]
        public string OppositeInterfaceId { get; set; }

        /// <summary>
        /// <para>The ID of the account to which the peer router interface belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1321932713****</para>
        /// </summary>
        [NameInMap("OppositeInterfaceOwnerId")]
        [Validation(Required=false)]
        public string OppositeInterfaceOwnerId { get; set; }

        /// <summary>
        /// <para>The specification of the peer router interface. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Mini.2</b>: 2 Mbps</description></item>
        /// <item><description><b>Mini.5</b>: 5 Mbps</description></item>
        /// <item><description><b>Small.1</b>: 10 Mbps</description></item>
        /// <item><description><b>Small.2</b>: 20 Mbps</description></item>
        /// <item><description><b>Small.5</b>: 50 Mbps</description></item>
        /// <item><description><b>Middle.1</b>: 100 Mbps</description></item>
        /// <item><description><b>Middle.2</b>: 200 Mbps</description></item>
        /// <item><description><b>Middle.5</b>: 500 Mbps</description></item>
        /// <item><description><b>Large.1</b>: 1000 Mbps</description></item>
        /// <item><description><b>Large.2</b>: 2000 Mbps</description></item>
        /// <item><description><b>Large.5</b>: 5000 Mbps</description></item>
        /// <item><description><b>Xlarge.1</b>: 10000 Mbps</description></item>
        /// <item><description><b>Negative</b>: no specification involved.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Negative</para>
        /// </summary>
        [NameInMap("OppositeInterfaceSpec")]
        [Validation(Required=false)]
        public string OppositeInterfaceSpec { get; set; }

        /// <summary>
        /// <para>The status of the peer router interface. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Idle</b>: not connected.</description></item>
        /// <item><description><b>AcceptingConnecting</b>: accepting a connection.</description></item>
        /// <item><description><b>Connecting</b>: connecting.</description></item>
        /// <item><description><b>Activating</b>: being activated.</description></item>
        /// <item><description><b>Active</b>: activated.</description></item>
        /// <item><description><b>Modifying</b>: being modified.</description></item>
        /// <item><description><b>Deactivating</b>: being frozen.</description></item>
        /// <item><description><b>Inactive</b>: frozen.</description></item>
        /// <item><description><b>Deleting</b>: being deleted.</description></item>
        /// <item><description><b>Deleted</b>: deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("OppositeInterfaceStatus")]
        [Validation(Required=false)]
        public string OppositeInterfaceStatus { get; set; }

        /// <summary>
        /// <para>The region ID of the peer router interface.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("OppositeRegionId")]
        [Validation(Required=false)]
        public string OppositeRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the router to which the peer router interface belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vrt-bp11xvy6lb9photuu****</para>
        /// </summary>
        [NameInMap("OppositeRouterId")]
        [Validation(Required=false)]
        public string OppositeRouterId { get; set; }

        /// <summary>
        /// <para>The type of the router to which the peer router interface belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VRouter</b>: vRouter of a VPC.</description></item>
        /// <item><description><b>VBR</b>: Virtual Border Router.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VRouter</para>
        /// </summary>
        [NameInMap("OppositeRouterType")]
        [Validation(Required=false)]
        public string OppositeRouterType { get; set; }

        /// <summary>
        /// <para>The ID of the peer VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1b49rqrybk45nio****</para>
        /// </summary>
        [NameInMap("OppositeVpcInstanceId")]
        [Validation(Required=false)]
        public string OppositeVpcInstanceId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01818199-04F6-47F4-9ADF-7CC824CF57A4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The renewal active time. The time is displayed in the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-06-11T16:00:00Z</para>
        /// </summary>
        [NameInMap("ReservationActiveTime")]
        [Validation(Required=false)]
        public string ReservationActiveTime { get; set; }

        /// <summary>
        /// <para>The renewal bandwidth. Unit: Mbps.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ReservationBandwidth")]
        [Validation(Required=false)]
        public string ReservationBandwidth { get; set; }

        /// <summary>
        /// <para>The renewal billing type. Valid values: <b>PayByBandwidth</b>, which indicates pay-by-bandwidth.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PayByBandwidth</para>
        /// </summary>
        [NameInMap("ReservationInternetChargeType")]
        [Validation(Required=false)]
        public string ReservationInternetChargeType { get; set; }

        /// <summary>
        /// <para>The renewal order type. Valid values: <b>RENEW</b>, which indicates a renewal order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RENEW</para>
        /// </summary>
        [NameInMap("ReservationOrderType")]
        [Validation(Required=false)]
        public string ReservationOrderType { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// <para>For more information about resource groups, see <a href="https://help.aliyun.com/document_detail/2381067.html">What is a resource group?</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4ph6aiy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The role in the peering connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InitiatingSide</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <para>The ID of the router to which the router interface belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vbr-m5ex0xf63xk8s5bob****</para>
        /// </summary>
        [NameInMap("RouterId")]
        [Validation(Required=false)]
        public string RouterId { get; set; }

        /// <summary>
        /// <para>The ID of the router interface.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ri-m5egfc10sednwk2yt****</para>
        /// </summary>
        [NameInMap("RouterInterfaceId")]
        [Validation(Required=false)]
        public string RouterInterfaceId { get; set; }

        /// <summary>
        /// <para>The type of the router to which the route table belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>VRouter</b>: vRouter of a VPC.</para>
        /// </description></item>
        /// <item><description><para><b>VBR</b>: Virtual Border Router.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VRouter</para>
        /// </summary>
        [NameInMap("RouterType")]
        [Validation(Required=false)]
        public string RouterType { get; set; }

        /// <summary>
        /// <para>The specification of the router interface. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Mini.2</b>: 2 Mbps</description></item>
        /// <item><description><b>Mini.5</b>: 5 Mbps</description></item>
        /// <item><description><b>Small.1</b>: 10 Mbps</description></item>
        /// <item><description><b>Small.2</b>: 20 Mbps</description></item>
        /// <item><description><b>Small.5</b>: 50 Mbps</description></item>
        /// <item><description><b>Middle.1</b>: 100 Mbps</description></item>
        /// <item><description><b>Middle.2</b>: 200 Mbps</description></item>
        /// <item><description><b>Middle.5</b>: 500 Mbps</description></item>
        /// <item><description><b>Large.1</b>: 1000 Mbps</description></item>
        /// <item><description><b>Large.2</b>: 2000 Mbps</description></item>
        /// <item><description><b>Large.5</b>: 5000 Mbps</description></item>
        /// <item><description><b>Xlarge.1</b>: 10000 Mbps</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Mini.2</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

        /// <summary>
        /// <para>The status of the router interface. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Idle</b>: not connected.</description></item>
        /// <item><description><b>AcceptingConnecting</b>: accepting a connection.</description></item>
        /// <item><description><b>Connecting</b>: connecting.</description></item>
        /// <item><description><b>Activating</b>: being activated.</description></item>
        /// <item><description><b>Active</b>: activated.</description></item>
        /// <item><description><b>Modifying</b>: being modified.</description></item>
        /// <item><description><b>Deactivating</b>: being frozen.</description></item>
        /// <item><description><b>Inactive</b>: frozen.</description></item>
        /// <item><description><b>Deleting</b>: being deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public DescribeRouterInterfaceAttributeResponseBodyTags Tags { get; set; }
        public class DescribeRouterInterfaceAttributeResponseBodyTags : TeaModel {
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeRouterInterfaceAttributeResponseBodyTagsTags> Tags { get; set; }
            public class DescribeRouterInterfaceAttributeResponseBodyTagsTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC) to which the router interface belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1b49rqrybk45nio****</para>
        /// </summary>
        [NameInMap("VpcInstanceId")]
        [Validation(Required=false)]
        public string VpcInstanceId { get; set; }

    }

}
