// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdatePublishCronRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Cron")]
        [Validation(Required=false)]
        public string Cron { get; set; }

        [NameInMap("CronDay")]
        [Validation(Required=false)]
        public string CronDay { get; set; }

        [NameInMap("CronTime")]
        [Validation(Required=false)]
        public long? CronTime { get; set; }

        [NameInMap("CronType")]
        [Validation(Required=false)]
        public string CronType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

    }

}
