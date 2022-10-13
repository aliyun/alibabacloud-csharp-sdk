// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CC5G20220314.Models
{
    public class ListCardsRequest : TeaModel {
        [NameInMap("Apn")]
        [Validation(Required=false)]
        public string Apn { get; set; }

        [NameInMap("Iccid")]
        [Validation(Required=false)]
        public string Iccid { get; set; }

        [NameInMap("Iccids")]
        [Validation(Required=false)]
        public List<string> Iccids { get; set; }

        [NameInMap("IpAddress")]
        [Validation(Required=false)]
        public string IpAddress { get; set; }

        [NameInMap("Lock")]
        [Validation(Required=false)]
        public bool? Lock { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        [NameInMap("Msisdn")]
        [Validation(Required=false)]
        public string Msisdn { get; set; }

        [NameInMap("NetLinkId")]
        [Validation(Required=false)]
        public string NetLinkId { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("Online")]
        [Validation(Required=false)]
        public bool? Online { get; set; }

        [NameInMap("Statuses")]
        [Validation(Required=false)]
        public List<string> Statuses { get; set; }

        [NameInMap("WirelessCloudConnectorId")]
        [Validation(Required=false)]
        public string WirelessCloudConnectorId { get; set; }

    }

}
