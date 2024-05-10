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
        /// The information about VPN gateways.
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
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("AutoPropagate")]
                [Validation(Required=false)]
                public bool? AutoPropagate { get; set; }

                /// <summary>
                /// The payment status of the VPN gateway.
                /// 
                /// *   **Normal**
                /// *   **FinancialLocked**
                /// </summary>
                [NameInMap("BusinessStatus")]
                [Validation(Required=false)]
                public string BusinessStatus { get; set; }

                /// <summary>
                /// The billing method of the VPN gateway.
                /// 
                /// The value is fixed as **POSTPAY**, which indicates the pay-as-you-go billing method.
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// The timestamp when the VPN gateway was created. Unit: millisecond.
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
                /// The second IP address assigned by the system to create an IPsec-VPN connection.
                /// 
                /// This parameter is returned only when the VPN gateway supports the dual-tunnel mode.
                /// </summary>
                [NameInMap("DisasterRecoveryInternetIp")]
                [Validation(Required=false)]
                public string DisasterRecoveryInternetIp { get; set; }

                /// <summary>
                /// The ID of the second vSwitch associated with the VPN gateway.
                /// 
                /// This parameter is returned only when the VPN gateway supports the dual-tunnel mode.
                /// </summary>
                [NameInMap("DisasterRecoveryVSwitchId")]
                [Validation(Required=false)]
                public string DisasterRecoveryVSwitchId { get; set; }

                /// <summary>
                /// The BGP status of the VPN gateway.
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("EnableBgp")]
                [Validation(Required=false)]
                public bool? EnableBgp { get; set; }

                /// <summary>
                /// The timestamp when the VPN gateway expires. Unit: millisecond.
                /// 
                /// This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("EniInstanceIds")]
                [Validation(Required=false)]
                public DescribeVpnGatewaysResponseBodyVpnGatewaysVpnGatewayEniInstanceIds EniInstanceIds { get; set; }
                public class DescribeVpnGatewaysResponseBodyVpnGatewaysVpnGatewayEniInstanceIds : TeaModel {
                    [NameInMap("EniInstanceId")]
                    [Validation(Required=false)]
                    public List<string> EniInstanceId { get; set; }

                }

                /// <summary>
                /// *   If the VPN gateway supports IPsec-VPN connections in single-tunnel mode, the address is the IP address of the VPN gateway and can be used to create an IPsec-VPN connection or an SSL-VPN connection.
                /// 
                /// *   If the VPN gateway supports IPsec-VPN connections in dual-tunnel mode, the address is the first IP address used to create an IPsec-VPN connection. The address cannot be used to create an SSL-VPN connection.
                /// 
                ///     If the VPN gateway supports IPsec-VPN connections in dual-tunnel mode, the system assigns two IP addresses to the VPN gateway to create two encrypted tunnels.
                /// </summary>
                [NameInMap("InternetIp")]
                [Validation(Required=false)]
                public string InternetIp { get; set; }

                /// <summary>
                /// Indicates whether IPsec-VPN is enabled for the VPN gateway.
                /// 
                /// *   **enable**
                /// *   **disable**
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
                /// *   **public**
                /// *   **private**
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// The information about pending orders.
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
                    /// If the order type is **RENEWCHANGE** (renewal with a specification change) or **RENEW** (renewal), this parameter indicates the time when the renewal or renewal with a specification change takes effect.
                    /// </summary>
                    [NameInMap("ReservationEndTime")]
                    [Validation(Required=false)]
                    public string ReservationEndTime { get; set; }

                    /// <summary>
                    /// The IPsec-VPN status of the order that has not taken effect. Valid values:
                    /// 
                    /// *   **enable**
                    /// *   **disable**
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
                    /// *   **RENEWCHANGE**: renewal with upgrade or downgrade
                    /// *   **TEMP_UPGRADE**: temporary upgrade
                    /// *   **RENEW**: renewal
                    /// </summary>
                    [NameInMap("ReservationOrderType")]
                    [Validation(Required=false)]
                    public string ReservationOrderType { get; set; }

                    /// <summary>
                    /// The bandwidth of the pending order. Unit: Mbit/s.
                    /// </summary>
                    [NameInMap("ReservationSpec")]
                    [Validation(Required=false)]
                    public string ReservationSpec { get; set; }

                    /// <summary>
                    /// The SSL-VPN status of the order that has not taken effect. Valid values:
                    /// 
                    /// *   **enable**
                    /// *   **disable**
                    /// </summary>
                    [NameInMap("ReservationSsl")]
                    [Validation(Required=false)]
                    public string ReservationSsl { get; set; }

                    /// <summary>
                    /// The status of the order that has not taken effect.
                    /// 
                    /// *   **1**: indicates that the order is an order for renewal or renewal with a specification change and the order has not taken effect.
                    /// *   **2**: indicates that the order is an order for temporary upgrade and the order has taken effect. After the temporary upgrade expires, the system restores the VPN gateway to its previous specifications. In this case, **ReservationIpsec**, **ReservationMaxConnections**, **ReservationSpec**, and **ReservationSsl** indicate the previous specification.
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// The ID of the resource group to which the VPN gateway belongs.
                /// 
                /// You can call the [ListResourceGroups](https://help.aliyun.com/document_detail/158855.html) operation to query the resource group information.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

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
                /// *   **enable**
                /// *   **disable**
                /// </summary>
                [NameInMap("SslVpn")]
                [Validation(Required=false)]
                public string SslVpn { get; set; }

                /// <summary>
                /// The IP address of the SSL-VPN connection.
                /// 
                /// This parameter is returned only when the VPN gateway is a public VPN gateway and supports only the single-tunnel mode. In addition, the VPN gateway must have the SSL-VPN feature enabled.
                /// </summary>
                [NameInMap("SslVpnInternetIp")]
                [Validation(Required=false)]
                public string SslVpnInternetIp { get; set; }

                /// <summary>
                /// The status of the VPN gateway. Valid values:
                /// 
                /// *   **init**
                /// *   **provisioning**
                /// *   **active**
                /// *   **updating**
                /// *   **deleting**
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The automatically generated tag of the VPN gateway.
                /// 
                /// *   **VpnEnableBgp**: indicates whether the VPN gateway supports BGP. Valid values:
                /// 
                ///     *   **true**
                ///     *   **false**
                /// 
                /// *   **VisuallySsl**: indicates whether the VPN gateway allows you to view information about connected SSL clients.
                /// 
                ///     *   **true**
                ///     *   **false**
                /// 
                /// *   **PbrPriority**: indicates whether the VPN gateway allows you to configure priorities for policy-based routes.
                /// 
                ///     *   **true**
                ///     *   **false**
                /// 
                /// *   **VpnNewImage**: indicates whether the VPN gateway is upgraded.
                /// 
                ///     *   **true**
                ///     *   **false**
                /// 
                /// *   **description**: the description of the VPN gateway. This parameter is for internal system use only.
                /// 
                /// *   **VpnVersion**: the version of the VPN gateway.
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// The tags to be added to the VPN gateway.
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
                        /// The key of tag N.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The value of tag N.
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
                /// The ID of the virtual private cloud (VPC) to which the VPN gateway belongs.
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
                /// Only **Normal** may be returned, which indicates a standard NAT gateway.
                /// </summary>
                [NameInMap("VpnType")]
                [Validation(Required=false)]
                public string VpnType { get; set; }

            }

        }

    }

}
