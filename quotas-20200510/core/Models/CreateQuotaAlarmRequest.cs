/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class CreateQuotaAlarmRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AlarmName")]
        [Validation(Required=false)]
        public string AlarmName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("QuotaActionCode")]
        [Validation(Required=false)]
        public string QuotaActionCode { get; set; }

        [NameInMap("QuotaDimensions")]
        [Validation(Required=false)]
        public List<CreateQuotaAlarmRequestQuotaDimensions> QuotaDimensions { get; set; }
        public class CreateQuotaAlarmRequestQuotaDimensions : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public float? Threshold { get; set; }

        [NameInMap("ThresholdPercent")]
        [Validation(Required=false)]
        public float? ThresholdPercent { get; set; }

        [NameInMap("ThresholdType")]
        [Validation(Required=false)]
        public string ThresholdType { get; set; }

        [NameInMap("WebHook")]
        [Validation(Required=false)]
        public string WebHook { get; set; }

    }

}
