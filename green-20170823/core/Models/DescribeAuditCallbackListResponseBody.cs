// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20170823.Models
{
    public class DescribeAuditCallbackListResponseBody : TeaModel {
        [NameInMap("CallbackList")]
        [Validation(Required=false)]
        public List<DescribeAuditCallbackListResponseBodyCallbackList> CallbackList { get; set; }
        public class DescribeAuditCallbackListResponseBodyCallbackList : TeaModel {
            [NameInMap("CallbackSuggestions")]
            [Validation(Required=false)]
            public List<string> CallbackSuggestions { get; set; }

            [NameInMap("CallbackTypes")]
            [Validation(Required=false)]
            public List<string> CallbackTypes { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("CryptType")]
            [Validation(Required=false)]
            public string CryptType { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Seed")]
            [Validation(Required=false)]
            public string Seed { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
