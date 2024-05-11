// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetTraceRequest : TeaModel {
        /// <summary>
        /// The end of the time range to query. Unit: milliseconds.
        /// 
        /// > If the ID of the trace is 30 characters in length, this parameter is optional. Otherwise, this parameter is required.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Unit: milliseconds.
        /// 
        /// > If the ID of the trace is 30 characters in length, this parameter is optional. Otherwise, this parameter is required.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// The trace ID. You can log on to the ARMS console and obtain the trace ID on the **Trace Query** page or **Interface Snapshot** tab.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TraceID")]
        [Validation(Required=false)]
        public string TraceID { get; set; }

    }

}
