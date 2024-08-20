// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class BatchGetProjectTaskResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultList")]
        [Validation(Required=false)]
        public List<BatchGetProjectTaskResponseBodyResultList> ResultList { get; set; }
        public class BatchGetProjectTaskResponseBodyResultList : TeaModel {
            [NameInMap("errorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("videoDownloadUrl")]
            [Validation(Required=false)]
            public string VideoDownloadUrl { get; set; }

            [NameInMap("videoDuration")]
            [Validation(Required=false)]
            public int? VideoDuration { get; set; }

            [NameInMap("videoUrl")]
            [Validation(Required=false)]
            public string VideoUrl { get; set; }

        }

    }

}
