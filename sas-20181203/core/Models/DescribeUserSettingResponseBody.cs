// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeUserSettingResponseBody : TeaModel {
        /// <summary>
        /// The severities of alerts. If this parameter is empty, no custom alerts are generated.
        /// </summary>
        [NameInMap("AlertLevels")]
        [Validation(Required=false)]
        public List<string> AlertLevels { get; set; }

        /// <summary>
        /// The number of days during which you want to retain invalid alerts.
        /// </summary>
        [NameInMap("InvalidWarningKeepDays")]
        [Validation(Required=false)]
        public int? InvalidWarningKeepDays { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
