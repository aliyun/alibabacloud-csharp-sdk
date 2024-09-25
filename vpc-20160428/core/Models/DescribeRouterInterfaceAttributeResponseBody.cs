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
        /// <para>The bandwidth of the router interface. Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The status of the router interface. Valid values:</para>
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
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AfterPay</b>: pay-as-you-go</description></item>
        /// <item><description><b>PrePaid</b>: subscription</description></item>
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
        /// <para>The time when the connection was established.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-04-14T08:58:04Z</para>
        /// </summary>
        [NameInMap("ConnectedTime")]
        [Validation(Required=false)]
        public string ConnectedTime { get; set; }

        /// <summary>
        /// <para>The time when the router interface was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-04-14T08:57:24Z</para>
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// <para>Indicates whether the connection is a cross-border connection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b></description></item>
        /// <item><description><b>true</b></description></item>
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
        /// <para>Peer interface.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The end of the time range during which data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2999-09-08T16:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Indicates whether the VBR that is created in the Fast Link mode is uplinked to the router interface. The Fast Link mode helps automatically connect router interfaces that are created for the VBR and its peer VPC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b> (default)</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter takes effect only when <b>RouterType</b> is set to <b>VBR</b> and <b>OppositeRouterType</b> is set to <b>VRouter</b>.</para>
        /// </description></item>
        /// <item><description><para>When <b>FastLinkMode</b> is set to <b>true</b>, <b>Role</b> must be set to <b>InitiatingSide</b>. <b>AccessPointId</b>, <b>OppositeRouterType</b>, <b>OpppsiteRouterId</b>, and <b>OppositeInterfaceOwnerId</b> are required.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("FastLinkMode")]
        [Validation(Required=false)]
        public string FastLinkMode { get; set; }

        /// <summary>
        /// <para>The time when the router interface was modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-04-28T10:02:12Z</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>Indicates whether renewal data is included. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b></description></item>
        /// <item><description><b>true</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("HasReservationData")]
        [Validation(Required=false)]
        public string HasReservationData { get; set; }

        /// <summary>
        /// <para>The rate of health checks. Unit: seconds. The value indicates the interval at which probe packets are sent during a health check.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("HcRate")]
        [Validation(Required=false)]
        public int? HcRate { get; set; }

        /// <summary>
        /// <para>The healthy threshold. This value indicates the number of probe packets that are sent during a health check. Unit: packets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("HcThreshold")]
        [Validation(Required=false)]
        public int? HcThreshold { get; set; }

        /// <summary>
        /// <para>The source IP address that is used for the health check.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.1.XX.XX</para>
        /// </summary>
        [NameInMap("HealthCheckSourceIp")]
        [Validation(Required=false)]
        public string HealthCheckSourceIp { get; set; }

        /// <summary>
        /// <para>The status of the health check. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Abnormal</b></description></item>
        /// <item><description><b>Normal</b></description></item>
        /// <item><description><b>NoRedundantRoute</b></description></item>
        /// <item><description><b>NoHealthCheckConfig</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("HealthCheckStatus")]
        [Validation(Required=false)]
        public string HealthCheckStatus { get; set; }

        /// <summary>
        /// <para>The destination IP address that is used for the health check.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.2.XX.XX</para>
        /// </summary>
        [NameInMap("HealthCheckTargetIp")]
        [Validation(Required=false)]
        public string HealthCheckTargetIp { get; set; }

        /// <summary>
        /// <para>The response parameters.</para>
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
        /// <para>The maximum bandwidth of the peer router interface. Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OppositeBandwidth")]
        [Validation(Required=false)]
        public int? OppositeBandwidth { get; set; }

        /// <summary>
        /// <para>The service status of the peer router interface. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b></description></item>
        /// <item><description><b>FinancialLocked</b></description></item>
        /// <item><description><b>SecurityLocked</b></description></item>
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
        /// <para>The ID of the Alibaba Cloud account to which the peer router interface belongs.</para>
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
        /// <item><description><b>Mini.2</b>: 2 Mbit/s</description></item>
        /// <item><description><b>Mini.5</b>: 5 Mbit/s</description></item>
        /// <item><description><b>Small.1</b>: 10 Mbit/s</description></item>
        /// <item><description><b>Small.2</b>: 20 Mbit/s</description></item>
        /// <item><description><b>Small.5</b>: 50 Mbit/s</description></item>
        /// <item><description><b>Middle.1</b>: 100 Mbit/s</description></item>
        /// <item><description><b>Middle.2</b>: 200 Mbit/s</description></item>
        /// <item><description><b>Middle.5</b>: 500 Mbit/s</description></item>
        /// <item><description><b>Large.1</b>: 1,000 Mbit/s</description></item>
        /// <item><description><b>Large.2</b>: 2,000 Mbit/s</description></item>
        /// <item><description><b>Large.5</b>: 5,000 Mbit/s</description></item>
        /// <item><description><b>Xlarge.1</b>: 10,000 Mbit/s</description></item>
        /// <item><description><b>Negative</b>: not applicable</description></item>
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
        /// <item><description><b>Idle</b></description></item>
        /// <item><description><b>AcceptingConnecting</b></description></item>
        /// <item><description><b>Connecting</b></description></item>
        /// <item><description><b>Activating</b></description></item>
        /// <item><description><b>Active</b></description></item>
        /// <item><description><b>Modifying</b></description></item>
        /// <item><description><b>Deactivating</b></description></item>
        /// <item><description><b>Inactive</b></description></item>
        /// <item><description><b>Deleting</b></description></item>
        /// <item><description><b>Deleted</b></description></item>
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
        /// <item><description><b>VRouter</b></description></item>
        /// <item><description><b>VBR</b></description></item>
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
        /// <para>The time when the renewal takes effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-06-11T16:00:00Z</para>
        /// </summary>
        [NameInMap("ReservationActiveTime")]
        [Validation(Required=false)]
        public string ReservationActiveTime { get; set; }

        /// <summary>
        /// <para>The maximum bandwidth after the renewal takes effect. Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ReservationBandwidth")]
        [Validation(Required=false)]
        public string ReservationBandwidth { get; set; }

        /// <summary>
        /// <para>The metering method that is used after the renewal takes effect. Valid values: If <b>PayByBandwidth</b> is returned, it indicates that the Express Connect circuit is billed on a pay-by-bandwidth basis.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PayByBandwidth</para>
        /// </summary>
        [NameInMap("ReservationInternetChargeType")]
        [Validation(Required=false)]
        public string ReservationInternetChargeType { get; set; }

        /// <summary>
        /// <para>The type of the renewal order. Only <b>RENEW</b> may be returned, which indicates that the order is placed for service renewal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RENEW</para>
        /// </summary>
        [NameInMap("ReservationOrderType")]
        [Validation(Required=false)]
        public string ReservationOrderType { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// <para>For more information about resource groups, see <a href="https://help.aliyun.com/document_detail/94475.html">What is a resource group?</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4ph6aiy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The role of the router interface in the peering connection.</para>
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
        /// <item><description><b>VRouter</b></description></item>
        /// <item><description><b>VBR</b></description></item>
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
        /// <item><description><b>Mini.2</b>: 2 Mbit/s</description></item>
        /// <item><description><b>Mini.5</b>: 5 Mbit/s</description></item>
        /// <item><description><b>Small.1</b>: 10 Mbit/s</description></item>
        /// <item><description><b>Small.2</b>: 20 Mbit/s</description></item>
        /// <item><description><b>Small.5</b>: 50 Mbit/s</description></item>
        /// <item><description><b>Middle.1</b>: 100 Mbit/s</description></item>
        /// <item><description><b>Middle.2</b>: 200 Mbit/s</description></item>
        /// <item><description><b>Middle.5</b>: 500 Mbit/s</description></item>
        /// <item><description><b>Large.1</b>: 1,000 Mbit/s</description></item>
        /// <item><description><b>Large.2</b>: 2,000 Mbit/s</description></item>
        /// <item><description><b>Large.5</b>: 5,000 Mbit/s</description></item>
        /// <item><description><b>Xlarge.1</b>: 10,000 Mbit/s</description></item>
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
        /// <item><description><b>Idle</b></description></item>
        /// <item><description><b>AcceptingConnecting</b></description></item>
        /// <item><description><b>Connecting</b></description></item>
        /// <item><description><b>Activating</b></description></item>
        /// <item><description><b>Active</b></description></item>
        /// <item><description><b>Modifying</b></description></item>
        /// <item><description><b>Deactivating</b></description></item>
        /// <item><description><b>Inactive</b></description></item>
        /// <item><description><b>Deleting</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values: true and false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The tag of the resource.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public DescribeRouterInterfaceAttributeResponseBodyTags Tags { get; set; }
        public class DescribeRouterInterfaceAttributeResponseBodyTags : TeaModel {
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeRouterInterfaceAttributeResponseBodyTagsTags> Tags { get; set; }
            public class DescribeRouterInterfaceAttributeResponseBodyTagsTags : TeaModel {
                /// <summary>
                /// <para>The key of tag N added to the resource. You must enter at least one tag key and at most 20 tag keys. The tag key cannot be an empty string.</para>
                /// <para>The tag key can be up to 64 characters in length and can contain digits, periods (.), underscores (_), and hyphens (-). It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceDept</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of tag N added to the resource. You can specify at most 20 tag values. The tag value can be an empty string.</para>
                /// <para>It can be up to 128 characters in length and can contain digits, periods (.), underscores (_), and hyphens (-). It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
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
