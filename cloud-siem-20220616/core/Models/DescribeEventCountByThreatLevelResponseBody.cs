// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeEventCountByThreatLevelResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeEventCountByThreatLevelResponseBodyData Data { get; set; }
        public class DescribeEventCountByThreatLevelResponseBodyData : TeaModel {
            /// <summary>
            /// The total number of events.
            /// </summary>
            [NameInMap("EventNum")]
            [Validation(Required=false)]
            public long? EventNum { get; set; }

            /// <summary>
            /// The number of high-risk events.
            /// </summary>
            [NameInMap("HighLevelEventNum")]
            [Validation(Required=false)]
            public long? HighLevelEventNum { get; set; }

            /// <summary>
            /// The number of low-risk events.
            /// </summary>
            [NameInMap("LowLevelEventNum")]
            [Validation(Required=false)]
            public long? LowLevelEventNum { get; set; }

            /// <summary>
            /// The number of medium-risk events.
            /// </summary>
            [NameInMap("MediumLevelEventNum")]
            [Validation(Required=false)]
            public long? MediumLevelEventNum { get; set; }

            /// <summary>
            /// The number of unhandled events.
            /// </summary>
            [NameInMap("UndealEventNum")]
            [Validation(Required=false)]
            public long? UndealEventNum { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
