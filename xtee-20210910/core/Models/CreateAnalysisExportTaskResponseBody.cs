// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class CreateAnalysisExportTaskResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public CreateAnalysisExportTaskResponseBodyResultObject ResultObject { get; set; }
        public class CreateAnalysisExportTaskResponseBodyResultObject : TeaModel {
            [NameInMap("columns")]
            [Validation(Required=false)]
            public string Columns { get; set; }

            [NameInMap("conditions")]
            [Validation(Required=false)]
            public string Conditions { get; set; }

            [NameInMap("eventBeginTime")]
            [Validation(Required=false)]
            public long? EventBeginTime { get; set; }

            [NameInMap("eventCodes")]
            [Validation(Required=false)]
            public string EventCodes { get; set; }

            [NameInMap("eventEndTime")]
            [Validation(Required=false)]
            public long? EventEndTime { get; set; }

            [NameInMap("fileFormat")]
            [Validation(Required=false)]
            public string FileFormat { get; set; }

            [NameInMap("ossKey")]
            [Validation(Required=false)]
            public string OssKey { get; set; }

            [NameInMap("scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

    }

}
