// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpnGatewayResponseBody : TeaModel {
        /// <summary>
        /// The billing method of the VPN gateway. Valid values:
        /// 
        /// Only **POSTPAY** is returned, which indicates the pay-as-you-go billing method.
        /// </summary>
        [NameInMap("AutoPropagate")]
        [Validation(Required=false)]
        public bool? AutoPropagate { get; set; }

        /// <summary>
        /// The status of the SSL-VPN feature. Valid values:
        /// 
        /// *   **enable**: enabled
        /// *   **disable**: disabled
        /// </summary>
        [NameInMap("BusinessStatus")]
        [Validation(Required=false)]
        public string BusinessStatus { get; set; }

        /// <summary>
        /// The ID of the VPN gateway.
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// Indicates whether BGP routes are automatically advertised to VPCs. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// Indicates whether BGP is enabled for the VPN gateway. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DisasterRecoveryInternetIp")]
        [Validation(Required=false)]
        public string DisasterRecoveryInternetIp { get; set; }

        [NameInMap("DisasterRecoveryVSwitchId")]
        [Validation(Required=false)]
        public string DisasterRecoveryVSwitchId { get; set; }

        /// <summary>
        /// The payment status of the VPN gateway. Valid values:
        /// 
        /// *   **Normal**: The VPN gateway is normal.
        /// *   **FinancialLocked**: The VPN gateway is locked due to overdue payments.
        /// </summary>
        [NameInMap("EnableBgp")]
        [Validation(Required=false)]
        public bool? EnableBgp { get; set; }

        /// <summary>
        /// The ID of the vSwitch to which the VPN gateway belongs.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The timestamp that indicates when the VPN gateway was created. Unit: milliseconds.
        /// 
        /// This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
        /// </summary>
        [NameInMap("InternetIp")]
        [Validation(Required=false)]
        public string InternetIp { get; set; }

        /// <summary>
        /// The timestamp that indicates when the VPN gateway expires. Unit: milliseconds.
        /// 
        /// This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
        /// </summary>
        [NameInMap("IpsecVpn")]
        [Validation(Required=false)]
        public string IpsecVpn { get; set; }

        /// <summary>
        /// The information about pending orders.
        /// 
        /// >  This parameter is returned only when **IncludeReservationData** is set to **true**.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// The description of the VPN gateway.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the pending order. Valid values:
        /// 
        /// *   **1**: indicates that the order of the renewal or specification change has not taken effect.
        /// *   **2**: indicates that the order of the temporary upgrade has taken effect. After the temporary upgrade expires, the system restores the VPN gateway to its previous specification. In this case, **ReservationIpsec**, **ReservationMaxConnections**, **ReservationSpec**, and **ReservationSsl** indicate the previous specifications.
        /// </summary>
        [NameInMap("ReservationData")]
        [Validation(Required=false)]
        public DescribeVpnGatewayResponseBodyReservationData ReservationData { get; set; }
        public class DescribeVpnGatewayResponseBodyReservationData : TeaModel {
            /// <summary>
            /// The custom tag of the VPN gateway.
            /// </summary>
            [NameInMap("ReservationEndTime")]
            [Validation(Required=false)]
            public string ReservationEndTime { get; set; }

            /// <summary>
            /// The bandwidth specification of the pending order. Unit: Mbit/s.
            /// </summary>
            [NameInMap("ReservationIpsec")]
            [Validation(Required=false)]
            public string ReservationIpsec { get; set; }

            /// <summary>
            /// If the order type is **TEMP_UPGRADE** (temporary upgrade), this parameter indicates the time when the temporary upgrade expires.
            /// 
            /// If the order type is **RENEWCHANGE** (specification change) or **RENEW** (renewal), this parameter indicates the time when the renewal or specification change takes effect.
            /// </summary>
            [NameInMap("ReservationMaxConnections")]
            [Validation(Required=false)]
            public int? ReservationMaxConnections { get; set; }

            /// <summary>
            /// The IPsec-VPN status of the pending order. Valid values:
            /// 
            /// *   **enable**: enabled
            /// *   **disable**: disabled
            /// </summary>
            [NameInMap("ReservationOrderType")]
            [Validation(Required=false)]
            public string ReservationOrderType { get; set; }

            /// <summary>
            /// The SSL-VPN status of the pending order. Valid values:
            /// 
            /// *   **enable**: enabled
            /// *   **disable**: disabled
            /// </summary>
            [NameInMap("ReservationSpec")]
            [Validation(Required=false)]
            public string ReservationSpec { get; set; }

            /// <summary>
            /// The maximum number of concurrent SSL-VPN connections for the pending order.
            /// </summary>
            [NameInMap("ReservationSsl")]
            [Validation(Required=false)]
            public string ReservationSsl { get; set; }

            /// <summary>
            /// The type of the pending order. Valid values:
            /// 
            /// *   **RENEWCHANGE**: renewal with upgrade or downgrade
            /// *   **TEMP_UPGRADE**: temporary upgrade
            /// *   **RENEW**: renewal
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The public IP address of the VPN gateway.
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

        /// <summary>
        /// The maximum bandwidth of the VPN gateway. Unit: Mbit/s.
        /// </summary>
        [NameInMap("SslMaxConnections")]
        [Validation(Required=false)]
        public long? SslMaxConnections { get; set; }

        /// <summary>
        /// The name of the VPN gateway.
        /// </summary>
        [NameInMap("SslVpn")]
        [Validation(Required=false)]
        public string SslVpn { get; set; }

        [NameInMap("SslVpnInternetIp")]
        [Validation(Required=false)]
        public string SslVpnInternetIp { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC) to which the VPN gateway belongs.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// Indicates whether the IPsec-VPN feature is enabled. Valid values:
        /// 
        /// *   **enable**: enabled
        /// *   **disable**: disabled
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        /// <summary>
        /// The tag key
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
                /// The tag value.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The network type of the VPN gateway. 
                /// 
                /// - **public**: public VPN gateway
                /// - **private**: private VPN gateway
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The maximum number of concurrent SSL-VPN connections.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

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
        [NameInMap("VpnGatewayId")]
        [Validation(Required=false)]
        public string VpnGatewayId { get; set; }

        /// <summary>
        /// The status of the VPN gateway. Valid values:
        /// 
        /// *   **init**: being initialized
        /// *   **provisioning**: being prepared
        /// *   **active**: active
        /// *   **updating**: being updated
        /// *   **deleting**: being deleted
        /// </summary>
        [NameInMap("VpnType")]
        [Validation(Required=false)]
        public string VpnType { get; set; }

    }

}
