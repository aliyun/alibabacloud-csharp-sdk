// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20181012.Models
{
    public class ListInstanceTaskResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListInstanceTaskResponseBodyResult> Result { get; set; }
        public class ListInstanceTaskResponseBodyResult : TeaModel {
            [NameInMap("SubProgressInfos")]
            [Validation(Required=false)]
            public List<ListInstanceTaskResponseBodyResultSubProgressInfos> SubProgressInfos { get; set; }
            public class ListInstanceTaskResponseBodyResultSubProgressInfos : TeaModel {
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Progress")]
                [Validation(Required=false)]
                public int? Progress { get; set; }

                [NameInMap("FinishedNum")]
                [Validation(Required=false)]
                public int? FinishedNum { get; set; }

                [NameInMap("TotalNum")]
                [Validation(Required=false)]
                public int? TotalNum { get; set; }

                [NameInMap("Detail")]
                [Validation(Required=false)]
                public string Detail { get; set; }

            }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("TotalProgress")]
            [Validation(Required=false)]
            public int? TotalProgress { get; set; }

        }

    }

}
