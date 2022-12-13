// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GetIncidentSubtotalCountResponseBody : TeaModel {
        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetIncidentSubtotalCountResponseBodyData Data { get; set; }
        public class GetIncidentSubtotalCountResponseBodyData : TeaModel {
            /// <summary>
            /// id of the request
            /// </summary>
            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// map
            /// </summary>
            [NameInMap("subtotalCount")]
            [Validation(Required=false)]
            public Dictionary<string, object> SubtotalCount { get; set; }

        }

    }

}
