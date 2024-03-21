// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDdosServiceResponseBody : TeaModel {
        /// <summary>
        /// The time when the renewed service takes effect. The time is displayed in UTC.
        /// </summary>
        [NameInMap("ChangingAffectTime")]
        [Validation(Required=false)]
        public string ChangingAffectTime { get; set; }

        /// <summary>
        /// The metering method after the configuration changes Valid values:
        /// 
        /// *   **PayByBandwidth**
        /// *   **PayByTraffic**
        /// *   **PayByBandwidth95**
        /// </summary>
        [NameInMap("ChangingChargeType")]
        [Validation(Required=false)]
        public string ChangingChargeType { get; set; }

        /// <summary>
        /// The number of protected domain names.
        /// </summary>
        [NameInMap("ChangingDomianNum")]
        [Validation(Required=false)]
        public int? ChangingDomianNum { get; set; }

        /// <summary>
        /// The protection edition for which the configuration changes take effect. Valid values:
        /// 
        /// *   **poc**: POC Edition
        /// *   **basic**: Basic Edition
        /// *   **insurance**: Insurance Edition
        /// *   **unlimited**: Unlimited Edition
        /// </summary>
        [NameInMap("ChangingEdition")]
        [Validation(Required=false)]
        public string ChangingEdition { get; set; }

        /// <summary>
        /// The number of mitigation sessions with configuration changes.
        /// </summary>
        [NameInMap("ChangingProtectNum")]
        [Validation(Required=false)]
        public int? ChangingProtectNum { get; set; }

        /// <summary>
        /// The billing method. Valid values:
        /// 
        /// *   **PayByBandwidth**
        /// *   **PayByTraffic**
        /// *   **PayByBandwidth95**
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// The number of protected domain names.
        /// </summary>
        [NameInMap("DomianNum")]
        [Validation(Required=false)]
        public int? DomianNum { get; set; }

        /// <summary>
        /// The protection edition. Valid values:
        /// 
        /// *   **poc**: POC Edition
        /// *   **basic**: Basic Edition
        /// *   **insurance**: Insurance Edition
        /// *   **unlimited**: Unlimited Edition
        /// </summary>
        [NameInMap("Edition")]
        [Validation(Required=false)]
        public string Edition { get; set; }

        /// <summary>
        /// The activation status of the service. Valid values:
        /// 
        /// *   **on**
        /// *   **off**
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public string Enabled { get; set; }

        /// <summary>
        /// The service expiration time.
        /// </summary>
        [NameInMap("EndingTime")]
        [Validation(Required=false)]
        public string EndingTime { get; set; }

        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The time when the service was enabled.
        /// </summary>
        [NameInMap("OpeningTime")]
        [Validation(Required=false)]
        public string OpeningTime { get; set; }

        /// <summary>
        /// The number of mitigation sessions.
        /// </summary>
        [NameInMap("ProtectNum")]
        [Validation(Required=false)]
        public int? ProtectNum { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the service. Valid values:
        /// 
        /// *   **Normal**
        /// *   **WaitForExpire**
        /// *   **expired**
        /// *   **Released**
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
