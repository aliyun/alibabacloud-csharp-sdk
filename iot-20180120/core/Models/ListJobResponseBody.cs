// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListJobResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListJobResponseBodyData Data { get; set; }
        public class ListJobResponseBodyData : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public List<ListJobResponseBodyDataData> Data { get; set; }
            public class ListJobResponseBodyDataData : TeaModel {
                public string JobId { get; set; }
                public string JobName { get; set; }
                public string UtcCreate { get; set; }
                public string UtcModified { get; set; }
                public string Status { get; set; }
                public string Description { get; set; }
                public string Type { get; set; }
            }
        };

    }

}
