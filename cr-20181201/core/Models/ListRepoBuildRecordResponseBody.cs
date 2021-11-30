// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListRepoBuildRecordResponseBody : TeaModel {
        [NameInMap("BuildRecords")]
        [Validation(Required=false)]
        public List<ListRepoBuildRecordResponseBodyBuildRecords> BuildRecords { get; set; }
        public class ListRepoBuildRecordResponseBodyBuildRecords : TeaModel {
            [NameInMap("BuildRecordId")]
            [Validation(Required=false)]
            public string BuildRecordId { get; set; }

            [NameInMap("BuildStatus")]
            [Validation(Required=false)]
            public string BuildStatus { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("Image")]
            [Validation(Required=false)]
            public ListRepoBuildRecordResponseBodyBuildRecordsImage Image { get; set; }
            public class ListRepoBuildRecordResponseBodyBuildRecordsImage : TeaModel {
                [NameInMap("ImageTag")]
                [Validation(Required=false)]
                public string ImageTag { get; set; }
                [NameInMap("RepoId")]
                [Validation(Required=false)]
                public string RepoId { get; set; }
                [NameInMap("RepoName")]
                [Validation(Required=false)]
                public string RepoName { get; set; }
                [NameInMap("RepoNamespaceName")]
                [Validation(Required=false)]
                public string RepoNamespaceName { get; set; }
            };

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
