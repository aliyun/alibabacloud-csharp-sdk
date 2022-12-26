// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeTotalStatisticsResponseBody : TeaModel {
        [NameInMap("Account")]
        [Validation(Required=false)]
        public int? Account { get; set; }

        [NameInMap("Health")]
        [Validation(Required=false)]
        public int? Health { get; set; }

        [NameInMap("HealthTotal")]
        [Validation(Required=false)]
        public int? HealthTotal { get; set; }

        [NameInMap("HealthdealedTotal")]
        [Validation(Required=false)]
        public int? HealthdealedTotal { get; set; }

        [NameInMap("HealthhighTotal")]
        [Validation(Required=false)]
        public int? HealthhighTotal { get; set; }

        [NameInMap("HealthlowTotal")]
        [Validation(Required=false)]
        public int? HealthlowTotal { get; set; }

        [NameInMap("HealthmediumTotal")]
        [Validation(Required=false)]
        public int? HealthmediumTotal { get; set; }

        [NameInMap("HealthseriousTotal")]
        [Validation(Required=false)]
        public int? HealthseriousTotal { get; set; }

        [NameInMap("Newsuspicious")]
        [Validation(Required=false)]
        public int? Newsuspicious { get; set; }

        [NameInMap("Online")]
        [Validation(Required=false)]
        public bool? Online { get; set; }

        [NameInMap("Patch")]
        [Validation(Required=false)]
        public int? Patch { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Suspicious")]
        [Validation(Required=false)]
        public int? Suspicious { get; set; }

        [NameInMap("SuspiciousTotal")]
        [Validation(Required=false)]
        public int? SuspiciousTotal { get; set; }

        [NameInMap("SuspiciousdealedTotal")]
        [Validation(Required=false)]
        public int? SuspiciousdealedTotal { get; set; }

        [NameInMap("SuspicioushighTotal")]
        [Validation(Required=false)]
        public int? SuspicioushighTotal { get; set; }

        [NameInMap("SuspiciouslowTotal")]
        [Validation(Required=false)]
        public int? SuspiciouslowTotal { get; set; }

        [NameInMap("SuspiciousmediumTotal")]
        [Validation(Required=false)]
        public int? SuspiciousmediumTotal { get; set; }

        [NameInMap("SuspiciousseriousTotal")]
        [Validation(Required=false)]
        public int? SuspiciousseriousTotal { get; set; }

        [NameInMap("Trojan")]
        [Validation(Required=false)]
        public int? Trojan { get; set; }

        [NameInMap("Vul")]
        [Validation(Required=false)]
        public int? Vul { get; set; }

        [NameInMap("VulAsapSum")]
        [Validation(Required=false)]
        public int? VulAsapSum { get; set; }

        [NameInMap("VulDealedTotal")]
        [Validation(Required=false)]
        public int? VulDealedTotal { get; set; }

        [NameInMap("VulLaterSum")]
        [Validation(Required=false)]
        public int? VulLaterSum { get; set; }

        [NameInMap("VulNntfSum")]
        [Validation(Required=false)]
        public int? VulNntfSum { get; set; }

        [NameInMap("VulTotal")]
        [Validation(Required=false)]
        public int? VulTotal { get; set; }

    }

}
