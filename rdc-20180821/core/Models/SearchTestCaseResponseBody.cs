// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rdc20180821.Models
{
    public class SearchTestCaseResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public SearchTestCaseResponseBodyData Data { get; set; }
        public class SearchTestCaseResponseBodyData : TeaModel {
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public string PageNum { get; set; }
            [NameInMap("Cases")]
            [Validation(Required=false)]
            public string Cases { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }
            [NameInMap("PageTotal")]
            [Validation(Required=false)]
            public string PageTotal { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public string TotalCount { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
