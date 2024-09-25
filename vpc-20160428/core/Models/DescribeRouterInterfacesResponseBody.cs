// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeRouterInterfacesResponseBody : TeaModel {
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
        /// <para>The number of entries per page. Maximum value: <b>50</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C7F6FCBD-F9CC-4501-8EF3-CDC9577CAE45</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the router interface.</para>
        /// </summary>
        [NameInMap("RouterInterfaceSet")]
        [Validation(Required=false)]
        public DescribeRouterInterfacesResponseBodyRouterInterfaceSet RouterInterfaceSet { get; set; }
        public class DescribeRouterInterfacesResponseBodyRouterInterfaceSet : TeaModel {
            [NameInMap("RouterInterfaceType")]
            [Validation(Required=false)]
            public List<DescribeRouterInterfacesResponseBodyRouterInterfaceSetRouterInterfaceType> RouterInterfaceType { get; set; }
            public class DescribeRouterInterfacesResponseBodyRouterInterfaceSetRouterInterfaceType : TeaModel {
                /// <summary>
                /// <para>The ID of the access point.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ap-cn-shanghaiSZ-****</para>
                /// </summary>
                [NameInMap("AccessPointId")]
                [Validation(Required=false)]
                public string AccessPointId { get; set; }

                /// <summary>
                /// <para>The bandwidth of the router interface. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public int? Bandwidth { get; set; }

                /// <summary>
                /// <para>The service status of the router interface. Valid values:</para>
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
                /// <para>The billing method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PayByTraffic</para>
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// <para>The time when the connection was established.</para>
                /// <para>The time follows the ISO8601 standard in the <c>YYYY-MM-DDThh:mmZ</c> format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-06-08T12:20:55</para>
                /// </summary>
                [NameInMap("ConnectedTime")]
                [Validation(Required=false)]
                public string ConnectedTime { get; set; }

                /// <summary>
                /// <para>The time when the route table was created.</para>
                /// <para>The time follows the ISO8601 standard in the <c>YYYY-MM-DDThh:mmZ</c> format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-06-08T12:20:55</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>Indicates whether the connection is a cross-border connection.</para>
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
                /// <para>The description of the router interface.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The end of the time range during which data was queried.</para>
                /// <para>The time follows the ISO8601 standard in the <c>YYYY-MM-DDThh:mmZ</c> format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-06-08T12:20:55</para>
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
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("FastLinkMode")]
                [Validation(Required=false)]
                public bool? FastLinkMode { get; set; }

                /// <summary>
                /// <para>Indicates whether renewal data is included.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("HasReservationData")]
                [Validation(Required=false)]
                public string HasReservationData { get; set; }

                /// <summary>
                /// <para>The rate of heath checks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("HcRate")]
                [Validation(Required=false)]
                public int? HcRate { get; set; }

                /// <summary>
                /// <para>The health check threshold.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("HcThreshold")]
                [Validation(Required=false)]
                public int? HcThreshold { get; set; }

                /// <summary>
                /// <para>The source IP address that is used for the health check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>116.62.XX.XX</para>
                /// </summary>
                [NameInMap("HealthCheckSourceIp")]
                [Validation(Required=false)]
                public string HealthCheckSourceIp { get; set; }

                /// <summary>
                /// <para>The destination IP address that is used for the health check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>116.62.XX.XX</para>
                /// </summary>
                [NameInMap("HealthCheckTargetIp")]
                [Validation(Required=false)]
                public string HealthCheckTargetIp { get; set; }

                /// <summary>
                /// <para>Indicates whether protection against malicious IPv6 traffic is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>on</b></description></item>
                /// <item><description><b>off</b></description></item>
                /// <item><description><b>unsupport</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Ipv6Status")]
                [Validation(Required=false)]
                public string Ipv6Status { get; set; }

                /// <summary>
                /// <para>The custom name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the peer access point.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ap-cn-shanghaiSZ-****</para>
                /// </summary>
                [NameInMap("OppositeAccessPointId")]
                [Validation(Required=false)]
                public string OppositeAccessPointId { get; set; }

                /// <summary>
                /// <para>The maximum bandwidth of the peer router interface. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("OppositeBandwidth")]
                [Validation(Required=false)]
                public int? OppositeBandwidth { get; set; }

                /// <summary>
                /// <para>The service status of the peer router interface.</para>
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
                /// <para>ri-bp1itx13bwe6f2wfh****</para>
                /// </summary>
                [NameInMap("OppositeInterfaceId")]
                [Validation(Required=false)]
                public string OppositeInterfaceId { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account to which the peer router interface belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>271598332402530847</para>
                /// </summary>
                [NameInMap("OppositeInterfaceOwnerId")]
                [Validation(Required=false)]
                public string OppositeInterfaceOwnerId { get; set; }

                /// <summary>
                /// <para>The specification of the peer router interface.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Large</para>
                /// </summary>
                [NameInMap("OppositeInterfaceSpec")]
                [Validation(Required=false)]
                public string OppositeInterfaceSpec { get; set; }

                /// <summary>
                /// <para>The status of the peer router interface.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("OppositeInterfaceStatus")]
                [Validation(Required=false)]
                public string OppositeInterfaceStatus { get; set; }

                /// <summary>
                /// <para>The region ID of the peer router interface.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("OppositeRegionId")]
                [Validation(Required=false)]
                public string OppositeRegionId { get; set; }

                /// <summary>
                /// <para>The ID of the router to which the peer router interface belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vrt-bp1d3bxtdv68tfd7g****</para>
                /// </summary>
                [NameInMap("OppositeRouterId")]
                [Validation(Required=false)]
                public string OppositeRouterId { get; set; }

                /// <summary>
                /// <para>The type of the router to which the peer router interface belongs.</para>
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
                /// <para>vpc-bp1qpo0kug3a20qqe****</para>
                /// </summary>
                [NameInMap("OppositeVpcInstanceId")]
                [Validation(Required=false)]
                public string OppositeVpcInstanceId { get; set; }

                /// <summary>
                /// <para>The time when the renewal takes effect.</para>
                /// <para>The time follows the ISO8601 standard in the <c>YYYY-MM-DDThh:mmZ</c> format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-03-11T16:00:00Z</para>
                /// </summary>
                [NameInMap("ReservationActiveTime")]
                [Validation(Required=false)]
                public string ReservationActiveTime { get; set; }

                /// <summary>
                /// <para>The maximum bandwidth after the renewal takes effect. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ReservationBandwidth")]
                [Validation(Required=false)]
                public string ReservationBandwidth { get; set; }

                /// <summary>
                /// <para>The metering method that is used after the renewal takes effect. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>PayByBandwidth</para>
                /// </summary>
                [NameInMap("ReservationInternetChargeType")]
                [Validation(Required=false)]
                public string ReservationInternetChargeType { get; set; }

                /// <summary>
                /// <para>The type of the renewal order. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>RENEWCHANGE</para>
                /// </summary>
                [NameInMap("ReservationOrderType")]
                [Validation(Required=false)]
                public string ReservationOrderType { get; set; }

                /// <summary>
                /// <para>Resource Group ID.</para>
                /// <para>For more information about resource groups, please refer to <a href="https://help.aliyun.com/document_detail/94475.html">What is a Resource Group?</a></para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmxazb4ph6aiy****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>Indicates whether the router interface is the initiator or acceptor of the peering connection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>InitiatingSide</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <para>The ID of the router to which the route entry belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vrt-bp1d3bxtdv68tfd7g****</para>
                /// </summary>
                [NameInMap("RouterId")]
                [Validation(Required=false)]
                public string RouterId { get; set; }

                /// <summary>
                /// <para>The ID of the router interface.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ri-2zenfgfpyu3v93koa****</para>
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
                /// <para>The specification of the router interface.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Large</para>
                /// </summary>
                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                /// <summary>
                /// <para>The status of the router interface.</para>
                /// 
                /// <b>Example:</b>
                /// <para>active</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The tags of the resource.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeRouterInterfacesResponseBodyRouterInterfaceSetRouterInterfaceTypeTags Tags { get; set; }
                public class DescribeRouterInterfacesResponseBodyRouterInterfaceSetRouterInterfaceTypeTags : TeaModel {
                    [NameInMap("Tags")]
                    [Validation(Required=false)]
                    public List<DescribeRouterInterfacesResponseBodyRouterInterfaceSetRouterInterfaceTypeTagsTags> Tags { get; set; }
                    public class DescribeRouterInterfacesResponseBodyRouterInterfaceSetRouterInterfaceTypeTagsTags : TeaModel {
                        /// <summary>
                        /// <para>The key of the resource tag. At least one tag key must be entered, and a maximum of 20 tag keys are supported. If this value needs to be passed in, it cannot be an empty string.</para>
                        /// <para>A tag key can support up to 128 characters, cannot start with \&quot;aliyun\&quot; or \&quot;acs:\&quot;, and cannot contain \&quot;http://\&quot; or \&quot;https://\&quot;.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>FinanceDept</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of the resource tag. A maximum of 20 tag values can be entered. If this value needs to be passed in, an empty string can be entered.</para>
                        /// <para>A maximum of 128 characters are supported, it cannot start with \&quot;aliyun\&quot; or \&quot;acs:\&quot;, and it cannot contain \&quot;http://\&quot; or \&quot;https://\&quot;.</para>
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
                /// <para>The ID of the local virtual private cloud (VPC) in the peering connection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-2ze3tq4uxhysg717x****</para>
                /// </summary>
                [NameInMap("VpcInstanceId")]
                [Validation(Required=false)]
                public string VpcInstanceId { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
