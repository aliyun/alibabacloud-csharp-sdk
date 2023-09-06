// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class ReceiverListReportResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("nextCursor")]
        [Validation(Required=false)]
        public long? NextCursor { get; set; }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("useridList")]
        [Validation(Required=false)]
        public List<string> UseridList { get; set; }

    }

}
