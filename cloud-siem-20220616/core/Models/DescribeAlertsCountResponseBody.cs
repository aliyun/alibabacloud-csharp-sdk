// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeAlertsCountResponseBody : TeaModel {
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
        public DescribeAlertsCountResponseBodyData Data { get; set; }
        public class DescribeAlertsCountResponseBodyData : TeaModel {
            /// <summary>
            /// The total number of alerts.
            /// </summary>
            [NameInMap("All")]
            [Validation(Required=false)]
            public long? All { get; set; }

            /// <summary>
            /// The number of high-risk alerts.
            /// </summary>
            [NameInMap("High")]
            [Validation(Required=false)]
            public long? High { get; set; }

            /// <summary>
            /// The number of low-risk alerts.
            /// </summary>
            [NameInMap("Low")]
            [Validation(Required=false)]
            public long? Low { get; set; }

            /// <summary>
            /// The number of medium-risk alerts.
            /// </summary>
            [NameInMap("Medium")]
            [Validation(Required=false)]
            public long? Medium { get; set; }

            /// <summary>
            /// The number of connected services.
            /// </summary>
            [NameInMap("ProductNum")]
            [Validation(Required=false)]
            public int? ProductNum { get; set; }

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
