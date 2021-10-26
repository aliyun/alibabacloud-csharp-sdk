// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ListCallTaskResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListCallTaskResponseBodyData> Data { get; set; }
        public class ListCallTaskResponseBodyData : TeaModel {
            [NameInMap("BizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public string CompleteTime { get; set; }

            [NameInMap("CompletedCount")]
            [Validation(Required=false)]
            public long? CompletedCount { get; set; }

            [NameInMap("CompletedRate")]
            [Validation(Required=false)]
            public int? CompletedRate { get; set; }

            [NameInMap("Data")]
            [Validation(Required=false)]
            public string Data { get; set; }

            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            [NameInMap("FireTime")]
            [Validation(Required=false)]
            public string FireTime { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StopTime")]
            [Validation(Required=false)]
            public string StopTime { get; set; }

            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            [NameInMap("TemplateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
