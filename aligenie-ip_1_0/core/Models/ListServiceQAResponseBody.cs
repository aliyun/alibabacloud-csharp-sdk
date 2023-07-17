// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class ListServiceQAResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public ListServiceQAResponseBodyPage Page { get; set; }
        public class ListServiceQAResponseBodyPage : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListServiceQAResponseBodyResult> Result { get; set; }
        public class ListServiceQAResponseBodyResult : TeaModel {
            [NameInMap("Active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

            [NameInMap("Answer")]
            [Validation(Required=false)]
            public string Answer { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("Question")]
            [Validation(Required=false)]
            public string Question { get; set; }

            [NameInMap("ServiceQAId")]
            [Validation(Required=false)]
            public long? ServiceQAId { get; set; }

            [NameInMap("Templates")]
            [Validation(Required=false)]
            public string Templates { get; set; }

        }

        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

    }

}
