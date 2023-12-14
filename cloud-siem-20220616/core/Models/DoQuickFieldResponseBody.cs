// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DoQuickFieldResponseBody : TeaModel {
        /// <summary>
        /// The response of the quick analysis.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DoQuickFieldResponseBodyData Data { get; set; }
        public class DoQuickFieldResponseBodyData : TeaModel {
            /// <summary>
            /// This parameter is deprecated.
            /// </summary>
            [NameInMap("AggQueryd")]
            [Validation(Required=false)]
            public string AggQueryd { get; set; }

            /// <summary>
            /// Indicates whether the quick analysis was successful. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("CompleteOrNot")]
            [Validation(Required=false)]
            public bool? CompleteOrNot { get; set; }

            /// <summary>
            /// The number of entries returned.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// This parameter is deprecated.
            /// </summary>
            [NameInMap("HasSQL")]
            [Validation(Required=false)]
            public bool? HasSQL { get; set; }

            /// <summary>
            /// This parameter is deprecated.
            /// </summary>
            [NameInMap("Keys")]
            [Validation(Required=false)]
            public List<string> Keys { get; set; }

            /// <summary>
            /// This parameter is deprecated.
            /// </summary>
            [NameInMap("Limited")]
            [Validation(Required=false)]
            public long? Limited { get; set; }

            /// <summary>
            /// The logs queried by using the quick analysis feature.
            /// </summary>
            [NameInMap("Logs")]
            [Validation(Required=false)]
            public List<object> Logs { get; set; }

            /// <summary>
            /// This parameter is deprecated.
            /// </summary>
            [NameInMap("PQuery")]
            [Validation(Required=false)]
            public string PQuery { get; set; }

            /// <summary>
            /// The number of entries queried.
            /// </summary>
            [NameInMap("ProcessedRows")]
            [Validation(Required=false)]
            public long? ProcessedRows { get; set; }

            /// <summary>
            /// This parameter is deprecated.
            /// </summary>
            [NameInMap("QueryMode")]
            [Validation(Required=false)]
            public int? QueryMode { get; set; }

            /// <summary>
            /// This parameter is deprecated.
            /// </summary>
            [NameInMap("WhereQuery")]
            [Validation(Required=false)]
            public string WhereQuery { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
