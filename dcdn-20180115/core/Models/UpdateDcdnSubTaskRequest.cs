// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class UpdateDcdnSubTaskRequest : TeaModel {
        /// <summary>
        /// The domain names that you want to include in the operations report. If you do not specify a domain name, all domain names that belong to your Alibaba Cloud account are included.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The end time of the operations report. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The IDs of the metrics that you want to update. Separate IDs with commas (,). You can call the [DescribeDcdnSubList](~~270075~~) operation to query the IDs.
        /// </summary>
        [NameInMap("ReportIds")]
        [Validation(Required=false)]
        public string ReportIds { get; set; }

        /// <summary>
        /// The start time of the operations report. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
