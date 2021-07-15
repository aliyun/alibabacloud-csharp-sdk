// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryTaskResultResponseBody : TeaModel {
        /// <summary>
        /// status
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// message
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// buildId
        /// </summary>
        [NameInMap("BuildId")]
        [Validation(Required=false)]
        public string BuildId { get; set; }

        /// <summary>
        /// passNumber
        /// </summary>
        [NameInMap("PassNumber")]
        [Validation(Required=false)]
        public long? PassNumber { get; set; }

        /// <summary>
        /// totalNumber
        /// </summary>
        [NameInMap("TotalNumber")]
        [Validation(Required=false)]
        public long? TotalNumber { get; set; }

        /// <summary>
        /// url
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        /// <summary>
        /// success
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// testSetRecordId
        /// </summary>
        [NameInMap("TestSetRecordId")]
        [Validation(Required=false)]
        public long? TestSetRecordId { get; set; }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
