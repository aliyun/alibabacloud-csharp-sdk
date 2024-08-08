// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiAutoML20220828.Models
{
    public class ListHpoTrialLogsResponseBody : TeaModel {
        /// <summary>
        /// Error code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// Extra error information.
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public Dictionary<string, object> Detail { get; set; }

        /// <summary>
        /// The log.
        /// </summary>
        [NameInMap("Logs")]
        [Validation(Required=false)]
        public List<string> Logs { get; set; }

        /// <summary>
        /// Error message.
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
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
