// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetRepoBuildRecordResponseBody : TeaModel {
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("BuildRecordId")]
        [Validation(Required=false)]
        public string BuildRecordId { get; set; }

        [NameInMap("Image")]
        [Validation(Required=false)]
        public GetRepoBuildRecordResponseBodyImage Image { get; set; }
        public class GetRepoBuildRecordResponseBodyImage : TeaModel {
            [NameInMap("RepoNamespaceName")]
            [Validation(Required=false)]
            public string RepoNamespaceName { get; set; }
            [NameInMap("ImageTag")]
            [Validation(Required=false)]
            public string ImageTag { get; set; }
            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
