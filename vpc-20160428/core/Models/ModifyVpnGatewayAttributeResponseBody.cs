// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyVpnGatewayAttributeResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether BGP routes are automatically advertised to the VPC. Valid values:
        /// 
        /// *   **true:** yes.
        /// *   **false:** no.
        /// </summary>
        [NameInMap("AutoPropagate")]
        [Validation(Required=false)]
        public bool? AutoPropagate { get; set; }

        /// <summary>
        /// The payment status of the VPN gateway. Valid values:
        /// 
        /// *   **Normal:** The VPN gateway is running as expected.
        /// *   **FinancialLocked:** The VPN gateway is locked due to overdue payments.
        /// </summary>
        [NameInMap("BusinessStatus")]
        [Validation(Required=false)]
        public string BusinessStatus { get; set; }

        /// <summary>
        /// The timestamp generated when the VPN gateway was created. Unit: milliseconds.
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

        [NameInMap("DisasterRecoveryInternetIp")]
        [Validation(Required=false)]
        public string DisasterRecoveryInternetIp { get; set; }

        [NameInMap("DisasterRecoveryVSwitchId")]
        [Validation(Required=false)]
        public string DisasterRecoveryVSwitchId { get; set; }

        /// <summary>
        /// The BGP status of the VPN gateway. Valid values:
        /// 
        /// *   **true:** enabled.
        /// *   **false:** disabled.
        /// </summary>
        [NameInMap("EnableBgp")]
        [Validation(Required=false)]
        public bool? EnableBgp { get; set; }

        /// <summary>
        /// The timestamp generated when the VPN gateway expires. Unit: milliseconds.
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
        /// The private IP address of the VPN gateway.
        /// </summary>
        [NameInMap("IntranetIp")]
        [Validation(Required=false)]
        public string IntranetIp { get; set; }

        /// <summary>
        /// The name of the VPN gateway.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The maximum bandwidth of the VPN gateway. Unit: Mbit/s.
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

        [NameInMap("SslVpnInternetIp")]
        [Validation(Required=false)]
        public string SslVpnInternetIp { get; set; }

        /// <summary>
        /// The status of the VPN gateway. Valid values:
        /// 
        /// *   **init:** The VPN gateway is being initialized.
        /// *   **provisioning:** The VPN gateway is being prepared.
        /// *   **active:** The VPN gateway is ready.
        /// *   **updating:** The VPN gateway is being updated.
        /// *   **deleting:** The VPN gateway is being deleted.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

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

    }

}
