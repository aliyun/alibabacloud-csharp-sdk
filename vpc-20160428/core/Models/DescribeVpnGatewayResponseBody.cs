// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpnGatewayResponseBody : TeaModel {
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
        /// The payment status of the VPN gateway. Valid values:
        /// 
        /// *   **Normal**
        /// *   **FinancialLocked**
        /// </summary>
        [NameInMap("BusinessStatus")]
        [Validation(Required=false)]
        public string BusinessStatus { get; set; }

        /// <summary>
        /// The billing method. Valid value:
        /// 
        /// **POSTPAY**: pay-as-you-go
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
        /// Indicates whether BGP is enabled for the VPN gateway. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
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

        [NameInMap("EniInstanceIds")]
        [Validation(Required=false)]
        public DescribeVpnGatewayResponseBodyEniInstanceIds EniInstanceIds { get; set; }
        public class DescribeVpnGatewayResponseBodyEniInstanceIds : TeaModel {
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
        /// Indicates whether the IPsec-VPN feature is enabled. Valid values:
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
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about pending orders.
        /// 
        /// > This set of parameters is returned only when **IncludeReservationData** is set to **true**.
        /// </summary>
        [NameInMap("ReservationData")]
        [Validation(Required=false)]
        public DescribeVpnGatewayResponseBodyReservationData ReservationData { get; set; }
        public class DescribeVpnGatewayResponseBodyReservationData : TeaModel {
            /// <summary>
            /// If the order type is **TEMP_UPGRADE** (temporary upgrade), this parameter specifies the time when the temporary upgrade expires.
            /// 
            /// If the order type is **RENEWCHANGE** (renewal with a specification change) or **RENEW** (renewal), this parameter indicates the time when the renewal or renewal with a specification change takes effect.
            /// </summary>
            [NameInMap("ReservationEndTime")]
            [Validation(Required=false)]
            public string ReservationEndTime { get; set; }

            /// <summary>
            /// The IPsec-VPN status of the pending order. Valid values:
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
            /// The type of the pending order. Valid values:
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
            /// The SSL-VPN status of the pending order. Valid values:
            /// 
            /// *   **enable**
            /// *   **disable**
            /// </summary>
            [NameInMap("ReservationSsl")]
            [Validation(Required=false)]
            public string ReservationSsl { get; set; }

            /// <summary>
            /// The status of the pending order. Valid values:
            /// 
            /// *   **1**: indicates that the order of the renewal or specification change has not taken effect.
            /// *   **2**: indicates that the order is an order for temporary upgrade and the order has taken effect. After the temporary upgrade expires, the system restores the VPN gateway to its previous specifications. In this case, **ReservationIpsec**, **ReservationMaxConnections**, **ReservationSpec**, and **ReservationSsl** indicate the previous specification.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The ID of the resource group to which the VPN gateway belongs.
        /// 
        /// You can call the [ListResourceGroups](~~158855~~) operation to query resource groups.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The maximum bandwidth of the VPN gateway. Unit: Mbit/s.
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

        /// <summary>
        /// The maximum number of concurrent SSL-VPN connections.
        /// </summary>
        [NameInMap("SslMaxConnections")]
        [Validation(Required=false)]
        public long? SslMaxConnections { get; set; }

        /// <summary>
        /// The status of the SSL-VPN feature. Valid values:
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
        /// *   **description**
        /// 
        /// *   **VpnVersion**
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        /// <summary>
        /// The tag value.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public DescribeVpnGatewayResponseBodyTags Tags { get; set; }
        public class DescribeVpnGatewayResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeVpnGatewayResponseBodyTagsTag> Tag { get; set; }
            public class DescribeVpnGatewayResponseBodyTagsTag : TeaModel {
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
        /// Only **Normal** may be returned, which indicates a standard VPN gateway.
        /// </summary>
        [NameInMap("VpnType")]
        [Validation(Required=false)]
        public string VpnType { get; set; }

    }

}
