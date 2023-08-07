// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpnGatewaysResponseBody : TeaModel {
        /// <summary>
        /// The number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// If the order type is **TEMP_UPGRADE** (temporary upgrade), this parameter specifies the time when the temporary upgrade expires.
        /// 
        /// If the order type is **RENEWCHANGE** (renewal with a specification change) or **RENEW** (renewal), this parameter indicates the time when the renewal or renewal with a specification change takes effect.
        /// </summary>
        [NameInMap("VpnGateways")]
        [Validation(Required=false)]
        public DescribeVpnGatewaysResponseBodyVpnGateways VpnGateways { get; set; }
        public class DescribeVpnGatewaysResponseBodyVpnGateways : TeaModel {
            [NameInMap("VpnGateway")]
            [Validation(Required=false)]
            public List<DescribeVpnGatewaysResponseBodyVpnGatewaysVpnGateway> VpnGateway { get; set; }
            public class DescribeVpnGatewaysResponseBodyVpnGatewaysVpnGateway : TeaModel {
                /// <summary>
                /// Indicates whether BGP routes are automatically advertised to the VPC. Valid values:
                /// 
                /// *   **true**: yes
                /// *   **false**: no
                /// </summary>
                [NameInMap("AutoPropagate")]
                [Validation(Required=false)]
                public bool? AutoPropagate { get; set; }

                /// <summary>
                /// The payment status of the VPN gateway.
                /// 
                /// *   **Normal:** The VPN gateway is running as expected.
                /// *   **FinancialLocked**: The VPN gateway is locked due to overdue payments.
                /// </summary>
                [NameInMap("BusinessStatus")]
                [Validation(Required=false)]
                public string BusinessStatus { get; set; }

                /// <summary>
                /// The billing method of the VPN gateway.
                /// 
                /// The value is set to **POSTPAY**, which indicates the pay-as-you-go billing method.
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// The timestamp when the VPN gateway was created. Unit: milliseconds.
                /// 
                /// This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// The description of the VPN gateway.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// 系统为VPN网关实例分配的用于创建IPsec-VPN连接的第二个IP地址。
                /// 
                /// 仅支持创建双隧道模式IPsec-VPN连接的VPN网关实例会返回当前参数。
                /// </summary>
                [NameInMap("DisasterRecoveryInternetIp")]
                [Validation(Required=false)]
                public string DisasterRecoveryInternetIp { get; set; }

                /// <summary>
                /// VPN网关实例关联的第二个交换机ID。
                /// 
                /// 仅支持创建双隧道模式IPsec-VPN连接的VPN网关实例会返回当前参数。
                /// </summary>
                [NameInMap("DisasterRecoveryVSwitchId")]
                [Validation(Required=false)]
                public string DisasterRecoveryVSwitchId { get; set; }

                /// <summary>
                /// The BGP status of the VPN gateway.
                /// 
                /// *   **true**: enabled
                /// *   **false**: disabled
                /// </summary>
                [NameInMap("EnableBgp")]
                [Validation(Required=false)]
                public bool? EnableBgp { get; set; }

                /// <summary>
                /// The timestamp when the VPN gateway expires. Unit: milliseconds.
                /// 
                /// This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// The public IP address of the VPN gateway.
                /// </summary>
                [NameInMap("InternetIp")]
                [Validation(Required=false)]
                public string InternetIp { get; set; }

                /// <summary>
                /// Indicates whether IPsec-VPN is enabled for the VPN gateway.
                /// 
                /// *   **enable**: enabled
                /// *   **disable**: disabled
                /// </summary>
                [NameInMap("IpsecVpn")]
                [Validation(Required=false)]
                public string IpsecVpn { get; set; }

                /// <summary>
                /// The name of the VPN gateway.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The network type of the VPN gateway.
                /// 
                /// *   **public**: public VPN gateway
                /// *   **private**: private VPN gateway
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// The information about the pending orders. 
                /// 
                /// >  This parameter is returned only when **IncludeReservationData** is set to **true**.
                /// </summary>
                [NameInMap("ReservationData")]
                [Validation(Required=false)]
                public DescribeVpnGatewaysResponseBodyVpnGatewaysVpnGatewayReservationData ReservationData { get; set; }
                public class DescribeVpnGatewaysResponseBodyVpnGatewaysVpnGatewayReservationData : TeaModel {
                    /// <summary>
                    /// If the order type is **TEMP_UPGRADE** (temporary upgrade), this parameter specifies the time when the temporary upgrade expires. 
                    /// 
                    /// If the order type is **RENEWCHANGE** (renewal with an upgrade or a downgrade) or **RENEW** (renewal), this parameter indicates the time when the renewal or renewal with an upgrade or a downgrade takes effect.
                    /// </summary>
                    [NameInMap("ReservationEndTime")]
                    [Validation(Required=false)]
                    public string ReservationEndTime { get; set; }

                    /// <summary>
                    /// The IPsec-VPN status of the order that has not taken effect. Valid values: 
                    /// 
                    /// - **enable**: enabled
                    /// - **disable**: disabled
                    /// </summary>
                    [NameInMap("ReservationIpsec")]
                    [Validation(Required=false)]
                    public string ReservationIpsec { get; set; }

                    /// <summary>
                    /// The maximum number of concurrent SSL-VPN connections of the pending order.
                    /// </summary>
                    [NameInMap("ReservationMaxConnections")]
                    [Validation(Required=false)]
                    public int? ReservationMaxConnections { get; set; }

                    /// <summary>
                    /// The type of the order that has not taken effect. Valid values: 
                    /// 
                    /// - **RENEWCHANGE**: renewal with a specification change
                    /// - **TEMP_UPGRADE**: temporary upgrade
                    /// - **RENEW**: renewal
                    /// </summary>
                    [NameInMap("ReservationOrderType")]
                    [Validation(Required=false)]
                    public string ReservationOrderType { get; set; }

                    /// <summary>
                    /// The bandwidth specification of the order that has not taken effect. Unit: Mbit/s.
                    /// </summary>
                    [NameInMap("ReservationSpec")]
                    [Validation(Required=false)]
                    public string ReservationSpec { get; set; }

                    /// <summary>
                    /// The SSL-VPN status of the order that has not taken effect. Valid values: 
                    /// 
                    /// - **enable**: enabled
                    /// - **disable**: disabled
                    /// </summary>
                    [NameInMap("ReservationSsl")]
                    [Validation(Required=false)]
                    public string ReservationSsl { get; set; }

                    /// <summary>
                    /// The status of the pending order. 
                    /// 
                    /// - **1**: indicates that the order for renewal or the order for renewal with a specification change has not taken effect.
                    /// - **2**: indicates that the order for a temporary upgrade has taken effect. After the temporary upgrade expires, the system restores the VPN gateway to its previous specifications. In this case, **ReservationIpsec**, **ReservationMaxConnections**, **ReservationSpec**, and **ReservationSsl** indicate the previous specification.
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// The maximum bandwidth of the VPN gateway. **M** indicates Mbit/s.
                /// </summary>
                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                /// <summary>
                /// The number of SSL-VPN connections supported by the VPN gateway.
                /// </summary>
                [NameInMap("SslMaxConnections")]
                [Validation(Required=false)]
                public long? SslMaxConnections { get; set; }

                /// <summary>
                /// Indicates whether SSL-VPN is enabled for the VPN gateway.
                /// 
                /// *   **enable**: enabled
                /// *   **disable**: disabled
                /// </summary>
                [NameInMap("SslVpn")]
                [Validation(Required=false)]
                public string SslVpn { get; set; }

                /// <summary>
                /// SSL-VPN连接的IP地址。
                /// 
                /// 仅支持创建双隧道模式IPsec-VPN连接的公网网络类型的VPN网关实例开启SSL-VPN功能后，才会返回当前参数。
                /// </summary>
                [NameInMap("SslVpnInternetIp")]
                [Validation(Required=false)]
                public string SslVpnInternetIp { get; set; }

                /// <summary>
                /// The status of the pending order.
                /// 
                /// *   **1**: indicates that the order for renewal or the order for renewal with a specification change has not taken effect.
                /// *   **2**: indicates that the order for a temporary upgrade has taken effect. After the temporary upgrade expires, the system restores the VPN gateway to its previous specifications. In this case, **ReservationIpsec**, **ReservationMaxConnections**, **ReservationSpec**, and **ReservationSsl** indicate the previous specification.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The automatically generated tag of the VPN gateway.
                /// 
                /// *   **VpnEnableBgp**: indicates whether the VPN gateway supports BGP. Valid values:
                /// 
                ///     *   **true**: yes
                ///     *   **false**: no
                /// 
                /// *   **VisuallySsl**: indicates whether the VPN gateway allows you to view information about connected SSL clients.
                /// 
                ///     *   **true**: yes
                ///     *   **false**: no
                /// 
                /// *   **PbrPriority**: indicates whether the VPN gateway allows you to configure priorities for policy-based routes.
                /// 
                ///     *   **true**: yes
                ///     *   **false**: no
                /// 
                /// *   **VpnNewImage**: indicates whether the VPN gateway is upgraded.
                /// 
                ///     *   **true**: yes
                ///     *   **false**: no
                /// 
                /// *   **description**: the description of the VPN gateway. This parameter is for internal system use only.
                /// 
                /// *   **VpnVersion**: the version of the VPN gateway.
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// The list of tags added to the VPN gateway.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeVpnGatewaysResponseBodyVpnGatewaysVpnGatewayTags Tags { get; set; }
                public class DescribeVpnGatewaysResponseBodyVpnGatewaysVpnGatewayTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeVpnGatewaysResponseBodyVpnGatewaysVpnGatewayTagsTag> Tag { get; set; }
                    public class DescribeVpnGatewaysResponseBodyVpnGatewaysVpnGatewayTagsTag : TeaModel {
                        /// <summary>
                        /// The tag key.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The tag value.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The ID of the vSwitch to which the VPN gateway belongs.
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// The ID of the VPC to which the VPN gateway belongs.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// The ID of the VPN gateway.
                /// </summary>
                [NameInMap("VpnGatewayId")]
                [Validation(Required=false)]
                public string VpnGatewayId { get; set; }

                /// <summary>
                /// The type of the VPN gateway.
                /// 
                /// The value is set to **Normal**, which indicates a standard NAT gateway.
                /// </summary>
                [NameInMap("VpnType")]
                [Validation(Required=false)]
                public string VpnType { get; set; }

            }

        }

    }

}
