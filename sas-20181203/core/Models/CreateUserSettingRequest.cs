// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateUserSettingRequest : TeaModel {
        /// <summary>
        /// The severities of alerts.
        /// </summary>
        [NameInMap("AlertLevels")]
        [Validation(Required=false)]
        public string AlertLevels { get; set; }

        /// <summary>
        /// The number of days during which you want to retain invalid alerts.
        /// </summary>
        [NameInMap("InvalidWarningKeepDays")]
        [Validation(Required=false)]
        public int? InvalidWarningKeepDays { get; set; }

        /// <summary>
        /// The source IP address.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
