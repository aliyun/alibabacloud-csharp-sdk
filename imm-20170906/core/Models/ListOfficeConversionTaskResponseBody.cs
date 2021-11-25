// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class ListOfficeConversionTaskResponseBody : TeaModel {
        [NameInMap("NextMarker")]
        [Validation(Required=false)]
        public string NextMarker { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<ListOfficeConversionTaskResponseBodyTasks> Tasks { get; set; }
        public class ListOfficeConversionTaskResponseBodyTasks : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("ExternalID")]
            [Validation(Required=false)]
            public string ExternalID { get; set; }

            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            [NameInMap("ImageSpec")]
            [Validation(Required=false)]
            public string ImageSpec { get; set; }

            [NameInMap("NotifyEndpoint")]
            [Validation(Required=false)]
            public string NotifyEndpoint { get; set; }

            [NameInMap("NotifyTopicName")]
            [Validation(Required=false)]
            public string NotifyTopicName { get; set; }

            [NameInMap("PageCount")]
            [Validation(Required=false)]
            public int? PageCount { get; set; }

            [NameInMap("Percent")]
            [Validation(Required=false)]
            public int? Percent { get; set; }

            [NameInMap("SrcUri")]
            [Validation(Required=false)]
            public string SrcUri { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("TgtType")]
            [Validation(Required=false)]
            public string TgtType { get; set; }

            [NameInMap("TgtUri")]
            [Validation(Required=false)]
            public string TgtUri { get; set; }

        }

    }

}
