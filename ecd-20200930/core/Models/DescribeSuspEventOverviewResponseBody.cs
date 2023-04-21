// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeSuspEventOverviewResponseBody : TeaModel {
        /// <summary>
        /// The total number of alerts at the remind level.
        /// </summary>
        [NameInMap("RemindCount")]
        [Validation(Required=false)]
        public int? RemindCount { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of alerts at the serious level.
        /// </summary>
        [NameInMap("SeriousCount")]
        [Validation(Required=false)]
        public int? SeriousCount { get; set; }

        /// <summary>
        /// The total number of alerts at the suspicious level.
        /// </summary>
        [NameInMap("SuspiciousCount")]
        [Validation(Required=false)]
        public int? SuspiciousCount { get; set; }

    }

}
