// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20230601.Models
{
    public class GetImportTaskResultResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetImportTaskResultResponseBodyData Data { get; set; }
        public class GetImportTaskResultResponseBodyData : TeaModel {
            [NameInMap("Details")]
            [Validation(Required=false)]
            public List<GetImportTaskResultResponseBodyDataDetails> Details { get; set; }
            public class GetImportTaskResultResponseBodyDataDetails : TeaModel {
                [NameInMap("DataId")]
                [Validation(Required=false)]
                public string DataId { get; set; }

                [NameInMap("DataName")]
                [Validation(Required=false)]
                public string DataName { get; set; }

                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public int? TaskStatus { get; set; }

            [NameInMap("TaskStatusText")]
            [Validation(Required=false)]
            public string TaskStatusText { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
