// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Safe20220117.Models
{
    public class SafeScopeDataResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public SafeScopeDataResponseBodyData Data { get; set; }
        public class SafeScopeDataResponseBodyData : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<object> Data { get; set; }

            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public Dictionary<string, string> ExtraInfo { get; set; }

            [NameInMap("Pagination")]
            [Validation(Required=false)]
            public SafeScopeDataResponseBodyDataPagination Pagination { get; set; }
            public class SafeScopeDataResponseBodyDataPagination : TeaModel {
                [NameInMap("Limit")]
                [Validation(Required=false)]
                public int? Limit { get; set; }

                [NameInMap("Page")]
                [Validation(Required=false)]
                public int? Page { get; set; }

            }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
