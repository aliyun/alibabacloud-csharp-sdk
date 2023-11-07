// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class LookupEventsResponseBody : TeaModel {
        /// <summary>
        /// The end of the time range when event details were queried.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The returned event details.
        /// 
        /// For more information about the fields in an event log, see [ActionTrail event log reference](~~28819~~).
        /// </summary>
        [NameInMap("Events")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Events { get; set; }

        /// <summary>
        /// The token used to return the next page of query results.
        /// 
        /// > This parameter is not returned if no more results are to be returned.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The beginning of the time range when event details were queried.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
