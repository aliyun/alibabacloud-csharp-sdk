// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeRouterInterfaceAttributeResponseBody : TeaModel {
        [NameInMap("AccessPointId")]
        [Validation(Required=false)]
        public string AccessPointId { get; set; }

        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        [NameInMap("BusinessStatus")]
        [Validation(Required=false)]
        public string BusinessStatus { get; set; }

        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ConnectedTime")]
        [Validation(Required=false)]
        public string ConnectedTime { get; set; }

        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        [NameInMap("CrossBorder")]
        [Validation(Required=false)]
        public bool? CrossBorder { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("HasReservationData")]
        [Validation(Required=false)]
        public string HasReservationData { get; set; }

        [NameInMap("HcRate")]
        [Validation(Required=false)]
        public int? HcRate { get; set; }

        [NameInMap("HcThreshold")]
        [Validation(Required=false)]
        public int? HcThreshold { get; set; }

        [NameInMap("HealthCheckSourceIp")]
        [Validation(Required=false)]
        public string HealthCheckSourceIp { get; set; }

        [NameInMap("HealthCheckStatus")]
        [Validation(Required=false)]
        public string HealthCheckStatus { get; set; }

        [NameInMap("HealthCheckTargetIp")]
        [Validation(Required=false)]
        public string HealthCheckTargetIp { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OppositeAccessPointId")]
        [Validation(Required=false)]
        public string OppositeAccessPointId { get; set; }

        [NameInMap("OppositeBandwidth")]
        [Validation(Required=false)]
        public int? OppositeBandwidth { get; set; }

        [NameInMap("OppositeInterfaceBusinessStatus")]
        [Validation(Required=false)]
        public string OppositeInterfaceBusinessStatus { get; set; }

        [NameInMap("OppositeInterfaceId")]
        [Validation(Required=false)]
        public string OppositeInterfaceId { get; set; }

        [NameInMap("OppositeInterfaceOwnerId")]
        [Validation(Required=false)]
        public string OppositeInterfaceOwnerId { get; set; }

        [NameInMap("OppositeInterfaceSpec")]
        [Validation(Required=false)]
        public string OppositeInterfaceSpec { get; set; }

        [NameInMap("OppositeInterfaceStatus")]
        [Validation(Required=false)]
        public string OppositeInterfaceStatus { get; set; }

        [NameInMap("OppositeRegionId")]
        [Validation(Required=false)]
        public string OppositeRegionId { get; set; }

        [NameInMap("OppositeRouterId")]
        [Validation(Required=false)]
        public string OppositeRouterId { get; set; }

        [NameInMap("OppositeRouterType")]
        [Validation(Required=false)]
        public string OppositeRouterType { get; set; }

        [NameInMap("OppositeVpcInstanceId")]
        [Validation(Required=false)]
        public string OppositeVpcInstanceId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ReservationActiveTime")]
        [Validation(Required=false)]
        public string ReservationActiveTime { get; set; }

        [NameInMap("ReservationBandwidth")]
        [Validation(Required=false)]
        public string ReservationBandwidth { get; set; }

        [NameInMap("ReservationInternetChargeType")]
        [Validation(Required=false)]
        public string ReservationInternetChargeType { get; set; }

        [NameInMap("ReservationOrderType")]
        [Validation(Required=false)]
        public string ReservationOrderType { get; set; }

        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        [NameInMap("RouterId")]
        [Validation(Required=false)]
        public string RouterId { get; set; }

        [NameInMap("RouterInterfaceId")]
        [Validation(Required=false)]
        public string RouterInterfaceId { get; set; }

        [NameInMap("RouterType")]
        [Validation(Required=false)]
        public string RouterType { get; set; }

        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("VpcInstanceId")]
        [Validation(Required=false)]
        public string VpcInstanceId { get; set; }

    }

}
