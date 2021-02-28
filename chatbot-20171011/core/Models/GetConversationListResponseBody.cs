// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class GetConversationListResponseBody : TeaModel {
        [NameInMap("Messages")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Messages { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("TotalCounts")]
        [Validation(Required=false)]
        public long? TotalCounts { get; set; }

    }

}
