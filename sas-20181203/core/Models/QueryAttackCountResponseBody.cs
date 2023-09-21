// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class QueryAttackCountResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The number of entries returned on the current page.
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// An array that consists of the numbers of alert events in different attack phases.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryAttackCountResponseBodyData> Data { get; set; }
        public class QueryAttackCountResponseBodyData : TeaModel {
            /// <summary>
            /// The number of times that the alert is triggered.
            /// </summary>
            [NameInMap("EventCount")]
            [Validation(Required=false)]
            public int? EventCount { get; set; }

            /// <summary>
            /// The stage ID of the ATT\&CK attack.
            /// </summary>
            [NameInMap("TacticId")]
            [Validation(Required=false)]
            public string TacticId { get; set; }

            /// <summary>
            /// The type of stage of the ATT\&CK attack.
            /// </summary>
            [NameInMap("TacticType")]
            [Validation(Required=false)]
            public string TacticType { get; set; }

        }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether exceptions are handled. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
