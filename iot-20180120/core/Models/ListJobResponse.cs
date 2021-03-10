// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListJobResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("Total")]
        [Validation(Required=true)]
        public int? Total { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("Page")]
        [Validation(Required=true)]
        public int? Page { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public ListJobResponseData Data { get; set; }
        public class ListJobResponseData : TeaModel {
            [NameInMap("data")]
            [Validation(Required=true)]
            public List<ListJobResponseDataData> Data { get; set; }
            public class ListJobResponseDataData : TeaModel {
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
