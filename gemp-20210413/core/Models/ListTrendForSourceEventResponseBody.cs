// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListTrendForSourceEventResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListTrendForSourceEventResponseBodyData> Data { get; set; }
        public class ListTrendForSourceEventResponseBodyData : TeaModel {
            [NameInMap("convergenceRate")]
            [Validation(Required=false)]
            public string ConvergenceRate { get; set; }

            [NameInMap("maxSustainTime")]
            [Validation(Required=false)]
            public long? MaxSustainTime { get; set; }

            [NameInMap("skipDay")]
            [Validation(Required=false)]
            public bool? SkipDay { get; set; }

            [NameInMap("sourceEventsStatMap")]
            [Validation(Required=false)]
            public Dictionary<string, object> SourceEventsStatMap { get; set; }

            [NameInMap("unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
