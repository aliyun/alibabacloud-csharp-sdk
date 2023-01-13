// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListJobResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("Page")]
        [Validation(Required=true)]
        public int? Page { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=true)]
        public int? Total { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public ListJobResponseData Data { get; set; }
        public class ListJobResponseData : TeaModel {
            [NameInMap("data")]
            [Validation(Required=true)]
            public List<ListJobResponseDataData> Data { get; set; }
            public class ListJobResponseDataData : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=true)]
                public string Description { get; set; }

                [NameInMap("JobId")]
                [Validation(Required=true)]
                public string JobId { get; set; }

                [NameInMap("JobName")]
                [Validation(Required=true)]
                public string JobName { get; set; }

                [NameInMap("ScheduledTime")]
                [Validation(Required=true)]
                public long? ScheduledTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=true)]
                public string Status { get; set; }

                [NameInMap("Type")]
                [Validation(Required=true)]
                public string Type { get; set; }

                [NameInMap("UtcCreate")]
                [Validation(Required=true)]
                public string UtcCreate { get; set; }

                [NameInMap("UtcModified")]
                [Validation(Required=true)]
                public string UtcModified { get; set; }

            }

        }

    }

}
