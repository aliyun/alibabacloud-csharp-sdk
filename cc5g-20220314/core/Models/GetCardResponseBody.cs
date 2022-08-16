// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CC5G20220314.Models
{
    public class GetCardResponseBody : TeaModel {
        [NameInMap("APN")]
        [Validation(Required=false)]
        public string APN { get; set; }

        [NameInMap("ActivatedTime")]
        [Validation(Required=false)]
        public string ActivatedTime { get; set; }

        [NameInMap("AlarmThreshold")]
        [Validation(Required=false)]
        public long? AlarmThreshold { get; set; }

        [NameInMap("CloudConnectorId")]
        [Validation(Required=false)]
        public string CloudConnectorId { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("ISP")]
        [Validation(Required=false)]
        public string ISP { get; set; }

        [NameInMap("Iccid")]
        [Validation(Required=false)]
        public string Iccid { get; set; }

        [NameInMap("Imei")]
        [Validation(Required=false)]
        public string Imei { get; set; }

        [NameInMap("Imsi")]
        [Validation(Required=false)]
        public string Imsi { get; set; }

        [NameInMap("IpAddress")]
        [Validation(Required=false)]
        public string IpAddress { get; set; }

        [NameInMap("LimitThreshold")]
        [Validation(Required=false)]
        public long? LimitThreshold { get; set; }

        [NameInMap("Lock")]
        [Validation(Required=false)]
        public string Lock { get; set; }

        [NameInMap("Msisdn")]
        [Validation(Required=false)]
        public string Msisdn { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("NetType")]
        [Validation(Required=false)]
        public string NetType { get; set; }

        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SimStatus")]
        [Validation(Required=false)]
        public string SimStatus { get; set; }

        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("StopThreshold")]
        [Validation(Required=false)]
        public long? StopThreshold { get; set; }

        [NameInMap("UsageDataMonth")]
        [Validation(Required=false)]
        public int? UsageDataMonth { get; set; }

        [NameInMap("UsageDataTotal")]
        [Validation(Required=false)]
        public long? UsageDataTotal { get; set; }

        [NameInMap("WirelessCloudConnectorId")]
        [Validation(Required=false)]
        public string WirelessCloudConnectorId { get; set; }

    }

}
