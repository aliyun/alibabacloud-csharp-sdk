// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListDiagnoseReportIdsRequest : TeaModel {
        /// <summary>
        /// The end of the time range to query. The value must be a UNIX timestamp.
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The language of the reports.
        /// </summary>
        [NameInMap("lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The number of the page to return. Valid values: 1 to 200. Default value: 1.
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: 1 to 500. Default value: 10.
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// The beginning of the time range to query. The value must be a UNIX timestamp.
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// The method that is used to trigger health diagnostics. Valid values: SYSTEM, INNER, and USER.
        /// </summary>
        [NameInMap("trigger")]
        [Validation(Required=false)]
        public string Trigger { get; set; }

    }

}
